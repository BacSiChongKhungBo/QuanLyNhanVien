using BUS.Services;

namespace PRL
{
    public partial class Form1 : Form
    {
        nhanvienService ser;
        public Form1()
        {
            InitializeComponent();
            ser = new nhanvienService();
            LoadGrid();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string id = "NV03";
            MessageBox.Show(ser.XoaNhanVien(id));
            LoadGrid();
        }

        public void LoadGrid()
        {
            //seting số cột
            dtgView.ColumnCount = 5;
            //đặt tên
            dtgView.Columns[0].Name = "Mã";
            dtgView.Columns[1].Name = "Họ Tên";
            dtgView.Columns[2].Name = "Ngày Sinh";
            dtgView.Columns[3].Name = "Giới Tính";
            dtgView.Columns[4].Name = "Địa chỉ";
            //reset sau mỗi lần gọi
            dtgView.Rows.Clear();
            //đẩy dữ liệu từ service
            foreach(var nv in ser.GetNhanViens())
            {
                dtgView.Rows.Add(nv.MaNv, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.Diachi);
            }
        }
    }
}
