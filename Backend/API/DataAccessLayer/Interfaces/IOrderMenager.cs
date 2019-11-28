using DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IOrderMenager
    {
        bool AddOrder(int id, Order order);
        List<Order> GetAllOders(int id);
    }
}
