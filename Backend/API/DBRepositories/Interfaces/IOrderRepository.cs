using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositories
{
    public interface IOrderRepository
    {
        List<EntityModels.Order> GetAllOrders(int id);

    }
}
