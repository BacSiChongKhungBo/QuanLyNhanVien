using BUS.Repositories;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    //lưu ý, service thì đổi internal thành public
    public class nhanvienService
    {
        nhanvienRepository repos;
        public nhanvienService() 
        {
            repos = new nhanvienRepository();
        }
        //-------------------------------------
        //trong này thực hiện thêm sửa xóa select
        //select
        public List<NhanVien> GetNhanViens(string search)
        {
            if(search == null || search == string.Empty)
                return repos.GetAll();
            else
                return repos.GetAll().Where(x => x.MaNv.Contains(search) || x.HoTen.Contains(search)).ToList();
        }

        //thêm
        public string ThemNhanVien(NhanVien nv)
        {
            if (repos.AddObj(nv))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        //Sửa :hơi nguy hiểm, dễ sai
        public string SuaNhanVien(NhanVien nv)
        {
            if (repos.UpdateObj(nv))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public string XoaNhanVien(string id)
        {
            NhanVien clone = repos.GetAll().Find(x => x.MaNv == id);
            if (repos.DeleteObj(clone))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }
    }
}
