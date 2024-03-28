using BUS.Services;
using DAL.DomainClass;

namespace PRL
{
    public partial class Form1 : Form
    {
        nhanvienService ser;
        private string idWhenClick;
        public Form1()
        {
            InitializeComponent();
            ser = new nhanvienService();
            LoadGrid(null); //null ko search gì
            settingComboBox();
            rbtn_Nam.Checked = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn Chắc chưa?", "Xóa đối tượng", MessageBoxButtons.YesNo))
            {
                MessageBox.Show(ser.XoaNhanVien(idWhenClick));
                LoadGrid(txt_search.Text);
            }
            else
            {
                return;
            }
        }

        public void LoadGrid(string search)
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
            foreach (var nv in ser.GetNhanViens(search))
            {
                dtgView.Rows.Add(nv.MaNv, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.Diachi);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //tạo nv mới
            NhanVien nv = new NhanVien();
            //gán giá trị từ màn hình vào các thuộc tính của nv
            nv.MaNv = txt_MaNV.Text;
            nv.HoTen = txt_HoTen.Text;
            nv.NgaySinh = DateTime.Parse(txt_NgSinh.Text);
            if (rbtn_Nam.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                nv.GioiTinh = "Nữ";
            }
            nv.Diachi = cmbx_Dchi.Text;
            MessageBox.Show(ser.ThemNhanVien(nv));
            //load lại grid để làm mới
            LoadGrid(txt_search.Text);
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //xác định dòng đang bấm
            int rowindex = e.RowIndex;
            //xác định vùng có thể bấm
            if (rowindex < 0 || rowindex >= ser.GetNhanViens(txt_search.Text).Count)
            {
                return;
            }
            idWhenClick = dtgView.Rows[rowindex].Cells[0].Value.ToString();
            bindData();
        }

        public void bindData()
        {
            //từ ID => thông tin đối tượng => điền vào các textbox...
            var nv = ser.GetNhanViens(txt_search.Text).Find(x => x.MaNv == idWhenClick);
            txt_HoTen.Text = nv.HoTen;
            txt_MaNV.Text = nv.MaNv;
            txt_NgSinh.Text = nv.NgaySinh.ToString();
            if (nv.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            else
            {
                rbtn_Nu.Checked = true;
            }
            cmbx_Dchi.Text = nv.Diachi;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var clone = ser.GetNhanViens(txt_search.Text).Find(x => x.MaNv == idWhenClick);
            clone.HoTen = txt_HoTen.Text;
            clone.Diachi = cmbx_Dchi.Text;
            clone.NgaySinh = DateTime.Parse(txt_NgSinh.Text);
            if (rbtn_Nam.Checked)
            {
                clone.GioiTinh = "Nam";
            }
            else
            {
                clone.GioiTinh = "Nữ";
            }
            MessageBox.Show(ser.SuaNhanVien(clone));
            LoadGrid(txt_search.Text);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_HoTen.Text = String.Empty;
            txt_NgSinh.Clear();
            rbtn_Nam.Checked = true;
        }

        public void settingComboBox()
        {
            cmbx_Dchi.Items.Add("HN"); //các item
            cmbx_Dchi.Items.Add("DN");
            cmbx_Dchi.Items.Add("HP");
            cmbx_Dchi.Items.Add("HCM");
            cmbx_Dchi.DropDownStyle = ComboBoxStyle.DropDownList; // ko edit dc
            cmbx_Dchi.SelectedIndex = 0; //set giá trị hiển thị
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txt_search.Text);
        }
    }
}
