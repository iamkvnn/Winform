using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.Exception;

namespace WindowsForms2.DAL
{
    public class Order_itemDAO
    {
        private jewelryStoreManagementEntities _db;
        public Order_itemDAO(jewelryStoreManagementEntities db)
        {
            _db = db;
        }

        public List<order_item> GetOrder_items()
        {
            return _db.order_item.ToList();
        }

        public order_item findById(int id)
        {
            order_item o = _db.order_item.Find(id);
            if (o == null)
                throw new ResourceNotFoundException("Không tìm thấy");
            return o;
        }

        public order_item save (order_item item)
        {
            return _db.order_item.Add(item);
        }

        public void deleteById(order_item item)
        {
            _db.order_item.Remove(item);
        }
    }
}
