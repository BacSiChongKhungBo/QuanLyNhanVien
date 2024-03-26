using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repositories
{
    internal class nhanvienRepository
    {
        DBContext context; //khai báo
        //ctor + tab
        public nhanvienRepository()
        {
            context = new DBContext(); // khởi tạo
        }

        //lấy danh sách đối tượng
        //select * from nhanvien
        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }

        //insert
        public bool AddObj(NhanVien nv)
        {
            if(nv == null) 
            {
                return false;
            }
            context.NhanViens.Add(nv); // thêm vào table
            context.SaveChanges(); // lưu thay đổi
            return true;
        }
        //update
        public bool UpdateObj(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Update(nv); // update table
            context.SaveChanges(); // lưu thay đổi
            return true;
        }
        //delete
        public bool DeleteObj(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Remove(nv); // xóa khỏi table
            context.SaveChanges(); // lưu thay đổi
            return true;
        }
    }
}
