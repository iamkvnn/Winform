using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.exception;
using WindowsForms2.DAL;

namespace WindowsForms2.BLL
{
    public class OrderBLL
    {
        private static OrderBLL instance;
        private jewelryStoreManagementEntities db;
        private OrderBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static OrderBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderBLL();
                }
                return instance;
            }
        }

        public List<order> GetOrders()
        {
            return db.orders.ToList();
        }

        public order findById(int id)
        {
            order o = db.orders.Find(id);
            if (o == null) 
                throw new ResourceNotFoundException("Không tìm thấy");
            return o;
        }

        public order save(order o)
        {
            return db.orders.Add(o);
        }

        public void deleteById(int id)
        {
            db.orders.Remove(findById(id));
        }
    }
}
