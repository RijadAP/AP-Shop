using AutoMapper;
using DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using EntityModels;
using DBUnitOfWork;
using System.Linq;

namespace DataAccessLayer
{
    public class OrderMenager : IOrderMenager
    {
        private IMapper _mapper;
        public OrderMenager (IMapper mapper)
        {
            _mapper = mapper;
        }


        public bool AddOrder(int id, DTOs.Order order)
        {
            if (order != null)
            {
                using (APShopContext context = new APShopContext())
                {
                    UnitOfWork UoW = new UnitOfWork(context);

                    EntityModels.Order EMOrder = _mapper.Map<EntityModels.Order>(order);
                    foreach (var orderProduct in order.Items)
                    {
                        if (!(UoW.Product.CheckProductIsAvailable(orderProduct.Id, orderProduct.Quantity)))
                        {
                            throw new Exception("product not found or not enough in stock");
                        }
                    }
                    UoW.User.GetById(id).Order.Add(EMOrder);
                    foreach (var orderProduct in order.Items)
                    {
                        EntityModels.OrderProduct EMOrderProduct = _mapper.Map<EntityModels.OrderProduct>(orderProduct);
                        EMOrder.OrderProduct.Add(EMOrderProduct);
                        UoW.Product.ReduceInStock(orderProduct.Id, orderProduct.Quantity);
                    }
                    UoW.commit();
                    return true;
                }
            }
            else return false;
        }

        public List<DTOs.Order> GetAllOders(int id)
        {
            using (APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);
                var DTOsOrderList = new List<DTOs.Order>();
                var EMOrderList = UoW.Order.GetAllOrders(id);

                if (EMOrderList != null)
                {
                    foreach(var order in EMOrderList)
                    {
                        var dtoOrder = _mapper.Map<DTOs.Order>(order);
                        dtoOrder.Items = new List<DTOs.OrderItem>();
                        foreach(var orderItem in order.OrderProduct)
                        {
                            var Item = _mapper.Map<DTOs.OrderItem>(orderItem);
                            Item.product = new DTOs.FullProduct();
                            var EMsearchProduct = UoW.Product.GetEntireProductById(orderItem.ProductId);
                            var EMProductDetails = EMsearchProduct.ProductDetails.SingleOrDefault();

                            Item.product.product = _mapper.Map<DTOs.Product>(EMsearchProduct);
                            Item.product.productDetails = _mapper.Map<DTOs.ProductDetails>(EMProductDetails);
                            DTOsOrderList.Add(dtoOrder);

                        }
                    }
                }
                return DTOsOrderList;


            }

        }
    }
}
