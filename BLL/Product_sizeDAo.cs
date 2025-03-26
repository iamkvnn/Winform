using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.Exception;

namespace WindowsForms2.DAL
{
    public class Product_sizeDAo
    {
        private jewelryStoreManagementEntities _db;
        public Product_sizeDAo(jewelryStoreManagementEntities db)
        {
            _db = db;
        }

        public List<product_size> GetProduct_Sizes()
        {
            return _db.product_size.ToList();
        }

        public product_size findById(int id)
        {
            product_size p = _db.product_size.Find(id);
            if (p == null)
                throw new ResourceNotFoundException("Không tìm thấy");
            return p;
        }

        public product_size save(product_size p)
        {
            return _db.product_size.Add(p);
        }

        public void deleteById(int id)
        {
            _db.product_size.Remove(findById(id));
        }
    }
}
