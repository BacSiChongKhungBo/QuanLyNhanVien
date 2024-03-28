namespace PRL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgView = new DataGridView();
            btn_Xoa = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_MaNV = new TextBox();
            txt_HoTen = new TextBox();
            txt_NgSinh = new TextBox();
            rbtn_Nam = new RadioButton();
            rbtn_Nu = new RadioButton();
            cmbx_Dchi = new ComboBox();
            txt_search = new TextBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(12, 422);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(776, 150);
            dtgView.TabIndex = 0;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(602, 220);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(177, 86);
            btn_Xoa.TabIndex = 1;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 2;
            label1.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 3;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(138, 37);
            label3.TabIndex = 4;
            label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(124, 37);
            label4.TabIndex = 5;
            label4.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 269);
            label5.Name = "label5";
            label5.Size = new Size(103, 37);
            label5.TabIndex = 6;
            label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 370);
            label6.Name = "label6";
            label6.Size = new Size(125, 37);
            label6.TabIndex = 7;
            label6.Text = "Tìm kiếm";
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(174, 53);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(334, 23);
            txt_MaNV.TabIndex = 8;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(174, 106);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(334, 23);
            txt_HoTen.TabIndex = 9;
            // 
            // txt_NgSinh
            // 
            txt_NgSinh.Location = new Point(174, 164);
            txt_NgSinh.Name = "txt_NgSinh";
            txt_NgSinh.Size = new Size(334, 23);
            txt_NgSinh.TabIndex = 10;
            // 
            // rbtn_Nam
            // 
            rbtn_Nam.AutoSize = true;
            rbtn_Nam.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_Nam.Location = new Point(174, 208);
            rbtn_Nam.Name = "rbtn_Nam";
            rbtn_Nam.Size = new Size(92, 41);
            rbtn_Nam.TabIndex = 11;
            rbtn_Nam.TabStop = true;
            rbtn_Nam.Text = "Nam";
            rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nu
            // 
            rbtn_Nu.AutoSize = true;
            rbtn_Nu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_Nu.Location = new Point(300, 208);
            rbtn_Nu.Name = "rbtn_Nu";
            rbtn_Nu.Size = new Size(71, 41);
            rbtn_Nu.TabIndex = 12;
            rbtn_Nu.TabStop = true;
            rbtn_Nu.Text = "Nữ";
            rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // cmbx_Dchi
            // 
            cmbx_Dchi.FormattingEnabled = true;
            cmbx_Dchi.Location = new Point(174, 283);
            cmbx_Dchi.Name = "cmbx_Dchi";
            cmbx_Dchi.Size = new Size(94, 23);
            cmbx_Dchi.TabIndex = 13;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(174, 384);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(334, 23);
            txt_search.TabIndex = 14;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(602, 53);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(177, 76);
            btn_Them.TabIndex = 15;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(602, 137);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(177, 76);
            btn_Sua.TabIndex = 16;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(602, 312);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(177, 76);
            btn_Clear.TabIndex = 17;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(txt_search);
            Controls.Add(cmbx_Dchi);
            Controls.Add(rbtn_Nu);
            Controls.Add(rbtn_Nam);
            Controls.Add(txt_NgSinh);
            Controls.Add(txt_HoTen);
            Controls.Add(txt_MaNV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Xoa);
            Controls.Add(dtgView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgView;
        private Button btn_Xoa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_MaNV;
        private TextBox txt_HoTen;
        private TextBox txt_NgSinh;
        private RadioButton rbtn_Nam;
        private RadioButton rbtn_Nu;
        private ComboBox cmbx_Dchi;
        private TextBox txt_search;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Clear;
    }
}
