using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.exception;
using WindowsForms2.DAL;

namespace WindowsForms2.BLL
{
    public class Order_itemBLL
    {
        private static Order_itemBLL instance;
        private jewelryStoreManagementEntities db;
        private Order_itemBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static Order_itemBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Order_itemBLL();
                }
                return instance;
            }
        }

        public List<order_item> GetOrder_items()
        {
            return db.order_item.ToList();
        }

        public order_item findById(int id)
        {
            order_item o = db.order_item.Find(id);
            if (o == null)
                throw new ResourceNotFoundException("Không tìm thấy");
            return o;
        }

        public order_item save (order_item item)
        {
            return db.order_item.Add(item);
        }

        public void deleteById(order_item item)
        {
            db.order_item.Remove(item);
        }
    }
}
