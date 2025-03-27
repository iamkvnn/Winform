using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.DAL;
using WindowsForms2.exception;

namespace WindowsForms2.BLL
{
    public class CollectionBLL
    {
        private static CollectionBLL instance;
        private jewelryStoreManagementEntities db;
        private CollectionBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static CollectionBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CollectionBLL();
                }
                return instance;
            }
        }

        public List<collection> GetCollections()
        {
            return db.collections.ToList();
        }

        public collection findById(int id)
        {
            collection c = db.collections.Find(id);
            if (c == null)
            {
                throw new ResourceNotFoundException("Không tìm thấy bộ sưu tập");
            }
            return c;
        }

        public collection save(collection a)
        {
            return db.collections.Add(a);
        }

        public void deleteById(int id)
        {
            db.collections.Remove(findById(id));
        }
    }
}
