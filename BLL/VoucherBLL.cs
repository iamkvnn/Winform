using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.exception;
using WindowsForms2.DAL;

namespace WindowsForms2.BLL
{
    public class VoucherBLL
    {
        private static VoucherBLL instance;
        private jewelryStoreManagementEntities db;
        private VoucherBLL()
        {
            db = ModelDAO.Instance.DbContext;
        }

        public static VoucherBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VoucherBLL();
                }
                return instance;
            }
        }

        public List<voucher> GetVouchers()
        {
            return db.vouchers.ToList();
        }

        public voucher findById(int id)
        {
            voucher v = db.vouchers.Find(id);
            if (v == null)
                throw new ResourceNotFoundException("Không tìm thấy voucher");
            return v;
        }

        public voucher findByName(string name) 
        {
            voucher v = db.vouchers.Where(voucher => voucher.name == name).FirstOrDefault();
            if (v == null)
                throw new ResourceNotFoundException("Không tìm thấy voucher");
            return v;
        }

        public voucher save(voucher v)
        {
            return db.vouchers.Add(v);
        }

        public void deleteByid(int id)
        {
            db.vouchers.Remove(findById(id));
        }
    }
}
