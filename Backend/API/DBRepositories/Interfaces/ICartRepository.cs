using EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositories
{
    interface ICartRepository
    {
        void CreateCart(Cart cart);
    }
}
