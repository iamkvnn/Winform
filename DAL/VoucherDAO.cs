using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms2.Exception;

namespace WindowsForms2.DAL
{
    public class VoucherDAO
    {
        private jewelryStoreManagementEntities _db;
        public VoucherDAO(jewelryStoreManagementEntities db)
        {
            _db = db;
        }

        public List<voucher> GetVouchers()
        {
            return _db.vouchers.ToList();
        }

        public voucher findById(int id)
        {
            voucher v = _db.vouchers.Find(id);
            if (v == null)
                throw new ResourceNotFoundException("Không tìm thấy voucher");
            return v;
        }

        public voucher findByName(string name) 
        {
            voucher v = _db.vouchers.Where(voucher => voucher.name == name).FirstOrDefault();
            if (v == null)
                throw new ResourceNotFoundException("Không tìm thấy voucher");
            return v;
        }

        public voucher save(voucher v)
        {
            return _db.vouchers.Add(v);
        }

        public void deleteByid(int id)
        {
            _db.vouchers.Remove(findById(id));
        }
    }
}
