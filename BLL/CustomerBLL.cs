using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.exception;
using WindowsForms2.DAL;

namespace WindowsForms2.BLL
{
    public class CustomerBLL
    {
        private static CustomerBLL instance;
        private jewelryStoreManagementEntities db;
        private CustomerBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static CustomerBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerBLL();
                }
                return instance;
            }
        }

        public List<customer> GetCustomers()
        {
            return db.customers.ToList();
        }

        public customer findById(int id)
        {
            customer c = db.customers.Find(id);
            if (c == null)
                throw new ResourceNotFoundException("Không tìm thấy");
            return c;

        }

        public customer save(customer customer)
        {
            return db.customers.Add(customer);
        }

        public void deleteById(int id)
        {
            db.customers.Remove(findById(id));
        }
    }
}
