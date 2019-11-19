using AutoMapper;
using DBUnitOfWork;
using DTOs;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class UserMenager : IUserMenager
    {
        private IMapper _mapper;

        public UserMenager(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public User GetUser(int Id)
        {
            using (APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);

                EntityModels.Users efUser = UoW.User.GetById(Id);
                if (efUser == null)
                {
                    return null;
                }
                DTOs.User user = _mapper.Map<DTOs.User>(efUser);
                return user;
            }
        }

        public int LogInUser(string username, string password)
        {
            using(APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);
                //int id = UoW.User.LogIn(username, password);
                //return id;

                try
                {
                    return UoW.User.LogIn(username, password);
                }

                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int RegisterUser(DTOs.User loginUser, DateTime LastUpdated)
        {
            if (loginUser == null)
            {
                throw new ArgumentNullException();
            }
            using (APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);
                EntityModels.Users user = _mapper.Map<EntityModels.Users>(loginUser);
                UoW.User.Register(user);

                EntityModels.Cart cart = new EntityModels.Cart();
                user.Cart.Add(cart);

                UoW.commit();
                return user.Id;
            }
        }

        public bool CheckIfUserExists(string username)
        {
            if (username ==  null){
                throw new ArgumentNullException();
            }

            using (APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);
                return UoW.User.CheckIfUserExists(username);
            }

        }
    }
}
