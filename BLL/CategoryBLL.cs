using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.DAL;
using WindowsForms2.exception;

namespace WindowsForms2.BLL
{
    public class CategoryBLL
    {
        private static CategoryBLL instance;
        private jewelryStoreManagementEntities db;
        private CategoryBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static CategoryBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryBLL();
                }
                return instance;
            }
        }

        public List<category> GetCategories()
        {
            return db.categories.ToList();
        }

        public category findById(int id)
        {
            category c = db.categories.Find(id);
            if (c == null)
            {
                throw new ResourceNotFoundException("Không tìm thấy danh mục");
            }
            return c;
        }

        public category save(category a)
        {
            return db.categories.Add(a);
        }

        public void deleteById(int id)
        {
            db.categories.Remove(findById(id));
        }
    }
}
