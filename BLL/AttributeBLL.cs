using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.exception;
using WindowsForms2.DAL;

namespace WindowsForms2.BLL
{
    public class AttributeBLL
    {
        private static AttributeBLL instance;
        private jewelryStoreManagementEntities db;
        private AttributeBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static AttributeBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AttributeBLL();
                }
                return instance;
            }
        }

        public List<attribute> GetAttributes()
        {
            return db.attributes.ToList();
        }

        public attribute findById(int id)
        {
            attribute a = db.attributes.Find(id);
            if (a == null)
            {
                throw new ResourceNotFoundException("Không tìm thấy thuộc tính");
            }
            return a;
        }

        public attribute save(attribute a) 
        { 
            return db.attributes.Add(a);
        }

        public void deleteById(int id) 
        {
           db.attributes.Remove(findById(id));        
        }
    }
}