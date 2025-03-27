using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.exception;
using WindowsForms2.DAL;

namespace WindowsForms2.BLL
{
    public class Product_sizeBLL
    {
        private static Product_sizeBLL instance;
        private jewelryStoreManagementEntities db;
        private Product_sizeBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static Product_sizeBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Product_sizeBLL();
                }
                return instance;
            }
        }

        public List<product_size> GetProduct_Sizes()
        {
            return db.product_size.ToList();
        }

        public product_size findById(int id)
        {
            product_size p = db.product_size.Find(id);
            if (p == null)
                throw new ResourceNotFoundException("Không tìm thấy");
            return p;
        }

        public product_size save(product_size p)
        {
            return db.product_size.Add(p);
        }

        public void deleteById(int id)
        {
            db.product_size.Remove(findById(id));
        }
    }
}
