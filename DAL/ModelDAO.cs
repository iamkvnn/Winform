using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms2.DAL
{
    public class ModelDAO
    {
        private static ModelDAO instance;
        private jewelryStoreManagementEntities dbContext;
        private ModelDAO()
        {
            dbContext = new jewelryStoreManagementEntities();
        }

        public static ModelDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ModelDAO();
                }
                return instance;
            }
        }

        public jewelryStoreManagementEntities DbContext
        {
            get
            {
                return dbContext;
            }
        }

        public void Dispose()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
                dbContext = null;
            }
        }
    }
}
