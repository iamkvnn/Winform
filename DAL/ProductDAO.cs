using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.Exception;

namespace WindowsForms2.DAL
{
    public class ProductDAO
    {
        private jewelryStoreManagementEntities _db;
        public ProductDAO(jewelryStoreManagementEntities db) {
            _db = db;
        }

        public List<product> GetProducts()
        {
            return _db.products.ToList();
        }

        public product findById(int id)
        {
            product p = _db.products.Find(id);
            if (p == null)
                throw new ResourceNotFoundException("Không tìm thấy sản phẩm");
            return p;
        }

        public product findByTitle(string title)
        {
            product p = _db.products.Where(product => product.title == title).FirstOrDefault();
            if (p == null)
                throw new ResourceNotFoundException("Không tìm thấy sản phẩm");
            return p;
        }

        public product filterByField() { return null; }

        public product save(product product)
        {
            return _db.products.Add(product);
        }

        public void deleteById(int id)
        {
            _db.products.Remove(findById(id));
        }
    }
}
