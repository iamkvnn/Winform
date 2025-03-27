using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.exception;
using WindowsForms2.DAL;

namespace WindowsForms2.BLL
{
    public class Attribute_valueBLL
    {
        private static Attribute_valueBLL instance;
        private jewelryStoreManagementEntities db;
        private Attribute_valueBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static Attribute_valueBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Attribute_valueBLL();
                }
                return instance;
            }
        }

        public List<attribute_value> GetAttribute_values()
        {
            return db.attribute_value.ToList();
        }

        public attribute_value findById(int id)
        {
            attribute_value a = db.attribute_value.Find(id);
            if (a == null)
                throw new ResourceNotFoundException("Không tìm thấy");
            return a;
        }

        public attribute_value findbyValue(string value)
        {
            attribute_value a = db.attribute_value.Where(attribute_value => attribute_value.value == value).FirstOrDefault();
            if (a == null)
                throw new ResourceNotFoundException("Không tìm thấy ");
            return a;
        }

        public attribute_value save(attribute_value value)
        {
            return db.attribute_value.Add(value);
        }

        public void deleteById(int id)
        {
            db.attribute_value.Remove(findById(id));
        }
    }
}
