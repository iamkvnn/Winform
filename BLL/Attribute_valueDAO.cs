using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.Exception;

namespace WindowsForms2.DAL
{
    public class Attribute_valueDAO
    {
        private jewelryStoreManagementEntities _db;
        public Attribute_valueDAO(jewelryStoreManagementEntities db)
        {
            _db = db;
        }

        public List<attribute_value> GetAttribute_values()
        {
            return _db.attribute_value.ToList();
        }

        public attribute_value findById(int id)
        {
            attribute_value a = _db.attribute_value.Find(id);
            if (a == null)
                throw new ResourceNotFoundException("Không tìm thấy");
            return a;
        }

        public attribute_value findbyValue(string value)
        {
            attribute_value a = _db.attribute_value.Where(attribute_value => attribute_value.value == value).FirstOrDefault();
            if (a == null)
                throw new ResourceNotFoundException("Không tìm thấy ");
            return a;
        }

        public attribute_value save(attribute_value value)
        {
            return _db.attribute_value.Add(value);
        }

        public void deleteById(int id)
        {
            _db.attribute_value.Remove(findById(id));
        }
    }
}
