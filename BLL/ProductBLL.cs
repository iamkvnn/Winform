using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.exception;
using WindowsForms2.DAL;

namespace WindowsForms2.BLL
{
    public class ProductBLL
    {
        private static ProductBLL instance;
        private jewelryStoreManagementEntities db;
        private ProductBLL() {
            db = ModelDAO.Instance.DbContext;
        }

        public static ProductBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductBLL();
                }
                return instance;
            }
        }

        public List<product> GetProducts()
        {
            return db.products.ToList();
        }

        public product findById(int id)
        {
            product p = db.products.Find(id);
            if (p == null)
                throw new ResourceNotFoundException("Không tìm thấy sản phẩm");
            return p;
        }

        public product findByTitle(string title)
        {
            product p = db.products.Where(product => product.title == title).FirstOrDefault();
            if (p == null)
                throw new ResourceNotFoundException("Không tìm thấy sản phẩm");
            return p;
        }

        public product filterByField() 
        { 
            return null; 
        }

        public product save(product product)
        {
            return db.products.Add(product);
        }

        public void deleteById(int id)
        {
            db.products.Remove(findById(id));
        }
    }
}
