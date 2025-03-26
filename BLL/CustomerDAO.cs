using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.Exception;

namespace WindowsForms2.DAL
{
    public class CustomerDAO
    {
        private jewelryStoreManagementEntities _db;
        public CustomerDAO(jewelryStoreManagementEntities db)
        {
            _db = db;
        }

        public List<customer> GetCustomers()
        {
            return _db.customers.ToList();
        }

        public customer findById(int id)
        {
            customer c = _db.customers.Find(id);
            if (c == null)
                throw new ResourceNotFoundException("Không tìm thấy");
            return c;

        }

        public customer save(customer customer)
        {
            return _db.customers.Add(customer);
        }

        public void deleteById(int id)
        {
            _db.customers.Remove(findById(id));
        }
    }
}
