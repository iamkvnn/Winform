using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.Exception;

namespace WindowsForms2.DAL
{
    public class AttributeDAO
    {
        private jewelryStoreManagementEntities _db;
        public AttributeDAO(jewelryStoreManagementEntities db)
        {
            _db = db;
        }

        public List<attribute> GetAttributes()
        {
            return _db.attributes.ToList();
        }

        public attribute findById(int id)
        {
            attribute a = _db.attributes.Find(id);
            if (a == null)
            {
                throw new ResourceNotFoundException("Không tìm thấy thuộc tính");
            }
            return a;
        }

        public attribute save(attribute a) 
        { 
            return _db.attributes.Add(a);
        }

        public void deleteById(int id) 
        {
           _db.attributes.Remove(findById(id));        
        }
    }
}