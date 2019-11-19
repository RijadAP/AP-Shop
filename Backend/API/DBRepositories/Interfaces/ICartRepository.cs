using EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositories
{
    public interface ICartRepository
    {
        void CreateCart(Cart cart);
    }
}
