using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.Exception;

namespace WindowsForms2.DAL
{
    public class OrderDAO
    {
        private jewelryStoreManagementEntities _db;
        public OrderDAO(jewelryStoreManagementEntities db)
        {
            _db = db;
        }

        public List<order> GetOrders()
        {
            return _db.orders.ToList();
        }

        public order findById(int id)
        {
            order o = _db.orders.Find(id);
            if (o == null) 
                throw new ResourceNotFoundException("Không tìm thấy");
            return o;
        }

        public order save(order o)
        {
            return _db.orders.Add(o);
        }

        public void deleteById(int id)
        {
            _db.orders.Remove(findById(id));
        }
    }
}
