using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.exception;
using WindowsForms2.DAL;

namespace WindowsForms2.BLL
{
    public class UserBLL
    {
        private static UserBLL instance;
        private jewelryStoreManagementEntities db;
        private UserBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static UserBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserBLL();
                }
                return instance;
            }
        }

        public List<user> GetOrder_Vouchers()
        {
            return db.users.ToList();
        }

        public customer findById(int id)
        {
            customer c = db.customers.Find(id);
            if (c == null)
                throw new ResourceNotFoundException("Không tìm thấy ");
            return c;
        }

        public customer save(customer customer)
        {
            return db.customers.Add(customer);
        }

        public void deleteId(int id)
        {
            db.customers.Remove(findById(id));
        }
    }
}
