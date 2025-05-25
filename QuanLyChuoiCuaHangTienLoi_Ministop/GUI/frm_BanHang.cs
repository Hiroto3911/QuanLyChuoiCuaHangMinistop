using BUS;
using ET;
using GUI.Reporting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_BanHang : Form
    {
        // biến tầng bus
        private BUS_HoaDon bus_hd = new BUS_HoaDon();
        private BUS_ChiTietHoaDon bus_cthd = new BUS_ChiTietHoaDon();
        private BUS_CuaHang bus_CH = new BUS_CuaHang();
        private BUS_SanPham bus_SP = new BUS_SanPham();
        private BUS_ChiTietKho bus_CTK = new BUS_ChiTietKho();
        private BUS_KhuyenMai_SanPham bus_KM_SP = new BUS_KhuyenMai_SanPham();
        private BUS_KhuyenMai bus_KM = new BUS_KhuyenMai();
        private BUS_LichSuKho bus_LichSuKho = new BUS_LichSuKho();
        // biến tầng et 
        private ET_ChiTietHoaDon et_cthd = new ET_ChiTietHoaDon();
        private ET_HoaDon et_hd = new ET_HoaDon();
        private ET_KhuyenMaiApDung et_KMAP = new ET_KhuyenMaiApDung();
        // biến static 
        private static string maHDMoiThem;
        // biến local 


        public frm_BanHang()
        {
            InitializeComponent();
        }

        // Các Function của các control
        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            if (Session.VaiTro == "QuanLy")
            {
                btn_Them.Enabled = false;
            }
            cbo_MaCH.Text = Session.MaCuaHang;
            txt_MaNV.Text = Session.MaNhanVien;
            dtp_NgayLapHD.Text = DateTime.Now.ToShortDateString();
            LoadHoaDon();
            if (dgv_Data.CurrentCell == null || dgv_Data.Rows.Count == 0)
                return;
            LoadChiTietHoaDonTheoMaHD(dgv_Data.CurrentRow.Cells[0].Value.ToString());


        }



        private void frm_BanHang_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2;
            gbo_HoaDon.Left = (this.ClientSize.Width - gbo_HoaDon.Width) / 2;
            gbo_HoaDon.Top = 90;
            gbo_ChiTietHoaDon.Left = (this.ClientSize.Width - gbo_ChiTietHoaDon.Width) / 2;
            gbo_ChiTietHoaDon.Top = gbo_HoaDon.Bottom + 20;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maHD = txt_MaHD.Text;
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {maHD} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {

                bus_hd.Xoa(maHD);
                MessageBox.Show("Xoá thành công");
                LamMoiHoaDon();
                LoadHoaDon();

            }
            catch (Exception ex) { MessageBox.Show("Xoá thất bại\n Lỗi:" + ex); }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            LamMoiLableKhuyenMai();
            try
            {
                string maCH = Session.MaCuaHang;
                maHDMoiThem = TaoMaTuDong.TaoMa(bus_hd.LayDanhSachMaHD(), "HD");
                string maNV = Session.MaNhanVien;
                DateTime ngayLap = DateTime.Now.Date;
                et_hd.MaHoaDon = maHDMoiThem;
                et_hd.MaCuaHang = maCH;
                et_hd.MaNhanVien = maNV;
                et_hd.NgayLap = ngayLap;
                //et_hd.TongTien = 0.0;
                bus_hd.Them(et_hd);
                MessageBox.Show("Thêm thành công");
                LoadHoaDon();
                LoadChiTietHoaDonTheoMaHD(maHDMoiThem);
                btn_HoanTat.Enabled = true;
                btn_InHoaDon.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_ThemChiTiet.Enabled = true;
                btn_XoaChiTiet.Enabled = true;
                btn_SuaChiTiet.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show("Thêm thất bại \n Lỗi:" + ex); }
        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            string maHD = txt_MaHD.Text;
            frm_RP_HoaDon frm = new frm_RP_HoaDon(maHD);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_ThemChiTiet_Click(object sender, EventArgs e)
        {
            if (maHDMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Hoá đơn này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo mã hoá đơn mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            try
            {

                string maCTHD = TaoMaTuDong.TaoMa(bus_cthd.LayDanhSachMaCTHD(), "CTHD");
                et_cthd.MaHoaDon = maHDMoiThem;
                et_cthd.MaChiTietHD = maCTHD;
                et_cthd.MaSanPham = txt_SanPham.Text;
                et_cthd.SoLuong = int.Parse(txt_SL.Text);
                et_cthd.GiaBan = Convert.ToDecimal(txt_DonGia.Text);
                //et_cthd.ThanhTien = 0.0;
                // kiểm tra chi tiết kho 
                if (!bus_CTK.KiemTraSanPhamConHang(Session.MaCuaHang, et_cthd))
                {
                    MessageBox.Show("Thành thật xin lỗi bạn. Nhưng sản phẩm trong kho không đáp ứng đủ Sl mua"
                  , "Thông báo", MessageBoxButtons.OKCancel);
                    return;
                }
                else
                {
                    // kiểm tra xem sản phẩm có đủ điều kiện để áp dụng khuyến mãi hay không
                    et_KMAP = bus_KM_SP.ApDungKhuyenMaiChoSanPham(et_cthd, Convert.ToDateTime(dtp_NgayLapHD.Text));
                    if (et_KMAP == null) { lbl_KhuyenMai_SanPham.Text = ""; }
                    else { lbl_KhuyenMai_SanPham.Text = "Sản phẩm đã áp dụng KM " + et_KMAP.TenKhuyenMai; }
                    // thêm sản phẩm
                    bus_cthd.Them(et_cthd);
                    MessageBox.Show("Thêm thành công");
                    // Cập nhập lại chi tiết kho 
                    bus_CTK.CapNhapSLSanPham(Session.MaCuaHang, "Them", et_cthd);
                    // cập nhập tổng tiền cho hoá đơn
                    CapNhapTongTienChoHoaDon();
                    // làm mới dữ liệu
                    LoadHoaDon();
                    LoadChiTietHoaDonTheoMaHD(maHDMoiThem);
                    LamMoiChiTietHoaDon();

                }
            }
            catch (Exception ex) { MessageBox.Show("Thêm thất bại \n Lỗi:" + ex); }
        }

        private void btn_SuaChiTiet_Click(object sender, EventArgs e)
        {
            if (maHDMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Hoá đơn này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo mã hoá đơn mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            try
            {

                et_cthd.MaHoaDon = maHDMoiThem;
                et_cthd.MaChiTietHD = txt_MaCTHD.Text;
                et_cthd.MaSanPham = txt_SanPham.Text;
                et_cthd.SoLuong = int.Parse(txt_SL.Text);
                et_cthd.GiaBan = Convert.ToDecimal(txt_DonGia.Text);
                // Cập nhập lại chi tiết kho 
                bus_CTK.CapNhapSLSanPham(Session.MaCuaHang, "Sua", et_cthd, bus_cthd.LaySLCuaChiTietHDTheoMaCTHD(et_cthd.MaHoaDon, et_cthd.MaChiTietHD));
                // kiểm tra xem sản phẩm có đủ điều kiện để áp dụng khuyến mãi hay không
                et_KMAP = bus_KM_SP.ApDungKhuyenMaiChoSanPham(et_cthd, Convert.ToDateTime(dtp_NgayLapHD.Text));
                if (et_KMAP == null) { lbl_KhuyenMai_SanPham.Text = ""; }
                else { lbl_KhuyenMai_SanPham.Text = "Sản phẩm đã áp dụng KM " + et_KMAP.TenKhuyenMai; }
                // sửa lại sản phẩm
                bus_cthd.Sua(et_cthd);
                // cập nhập tổng tiền cho hoá đơn
                CapNhapTongTienChoHoaDon();
                // làm mới dữ liệu
                LoadHoaDon();
                LoadChiTietHoaDonTheoMaHD(maHDMoiThem);
                LamMoiChiTietHoaDon();
            }
            catch (Exception ex) { MessageBox.Show("Cập nhập thất bại\n Lỗi:" + ex, "Thông báo"); }
        }

        private void btn_XoaChiTiet_Click(object sender, EventArgs e)
        {
            if (maHDMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Hoá đơn này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo mã hoá đơn mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            string maCTHD = txt_MaCTHD.Text;
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {maCTHD} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {
                // Cập nhập lại chi tiết kho 
                bus_CTK.CapNhapSLSanPham(Session.MaCuaHang, "Xoa", et_cthd);
                bus_cthd.Xoa(maCTHD);
                // cập nhập tổng tiền cho hoá đơn
                CapNhapTongTienChoHoaDon();
                MessageBox.Show("Xoá thành công");
                // làm mới dữ liệu
                LoadHoaDon();
                LoadChiTietHoaDonTheoMaHD(maHDMoiThem);
                LamMoiChiTietHoaDon();
            }
            catch (Exception ex) { MessageBox.Show("Xoá thất bại\n Lỗi:" + ex); }

        }

        private void btn_LamMoiChiTiet_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadChiTietHoaDonTheoMaHD(dgv_Data.CurrentRow.Cells[0].Value.ToString());
            LamMoiChiTietHoaDon();



        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            if (dgv_Data.CurrentCell == null || dgv_Data.Rows.Count == 0)
                return;
            int dong = dgv_Data.CurrentCell.RowIndex;
            if (dong > dgv_Data.Rows.Count - 1) return;
            txt_MaHD.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            dtp_NgayLapHD.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
            txt_TongTien.Text = dgv_Data.Rows[dong].Cells[4].Value.ToString();
            LoadChiTietHoaDonTheoMaHD(dgv_Data.Rows[dong].Cells[0].Value.ToString());
        }

        private void dgv_DataChiTiet_Click(object sender, EventArgs e)
        {
            if (dgv_DataChiTiet.CurrentCell == null || dgv_DataChiTiet.Rows.Count == 0)
                return;
            int dong = dgv_DataChiTiet.CurrentCell.RowIndex;
            if (dong > dgv_DataChiTiet.Rows.Count - 1) return;
            txt_MaCTHD.Text = dgv_DataChiTiet.Rows[dong].Cells[0].Value.ToString();
            txt_SanPham.Text = dgv_DataChiTiet.Rows[dong].Cells[2].Value.ToString();
            txt_SL.Text = dgv_DataChiTiet.Rows[dong].Cells[3].Value.ToString();
            txt_DonGia.Text = dgv_DataChiTiet.Rows[dong].Cells[4].Value.ToString();
            txt_ThanhTien.Text = dgv_DataChiTiet.Rows[dong].Cells[5].Value.ToString();
            lbl_TenSP.Text = TimTenSanPham(dgv_DataChiTiet.Rows[dong].Cells[2].Value.ToString());

        }


        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            int dem = 0;
            // kiểm tra lại các sản phẩm để áp dụng khuyến mãi
            foreach (var cthd in bus_cthd.HienThiDuLieuSapXepGiamDanTheoMaHD(maHDMoiThem))
            {



                et_KMAP = bus_KM_SP.ApDungKhuyenMaiChoSanPham(cthd, Convert.ToDateTime(dtp_NgayLapHD.Text));
                if (et_KMAP != null)
                {
                    cthd.ThanhTien -= et_KMAP.MucGiamGia;
                    bus_cthd.CapNhapThanhTien(cthd);
                    dem++;

                }
                var query = bus_CTK.layChiTietKhoTheoMaSPVaMaCH(cbo_MaCH.Text, cthd.MaSanPham);
                bus_LichSuKho.ThemLichSuKho(new ET_LichSuKho
                {
                    MaLichSuKho = TaoMaTuDong.TaoMa(bus_LichSuKho.LayDanhSachMaLSK(), "LSK"),
                    MaChiTietKho = query.MaChiTietKho,
                    NgayThayDoi = DateTime.Now,
                    SoLuongThayDoi = -cthd.SoLuong,
                    LoaiThayDoi = "Ban",
                    MaThamChieu = cthd.MaHoaDon
                });
            }
            if (dem > 0)
            {
                CapNhapTongTienChoHoaDon();
            }
            // cập nhập hoá đơn
            ApDungKhuyenMaiChoHoaDon(et_hd, et_hd.NgayLap);
            // làm mới dữ liệu
            LoadHoaDon();
            LoadChiTietHoaDonTheoMaHD(dgv_Data.CurrentRow.Cells[0].Value.ToString());
            // set hoá đơn về null để người dùng muốn crud thì phải tạo một hoá đơn mới
            maHDMoiThem = null;
            btn_HoanTat.Enabled = false;

        }

        private void txt_SanPham_Leave(object sender, EventArgs e)
        {
            lbl_TenSP.Text = TimTenSanPham(txt_SanPham.Text);
            txt_DonGia.Text = LayGiaBanCuaSanPham(Session.MaCuaHang, txt_SanPham.Text).ToString();
        }

        // Các Function hỗ trợ
        private string TimTenSanPham(string maSP)
        {
            return bus_SP.TimTenSPBangMaSP(maSP);
        }
        private void LoadHoaDon()
        {
            dgv_Data.DataSource = bus_hd.HienThiDuLieuMotCHSapXepGiamDanTheoMa(cbo_MaCH.Text);
        }
        private void LoadChiTietHoaDonTheoMaHD(string maHD)
        {
            dgv_DataChiTiet.DataSource = bus_cthd.HienThiDuLieuSapXepGiamDanTheoMaHD(maHD);
        }
        private void LoadComboboxCuaHang()
        {
            cbo_MaCH.DataSource = bus_CH.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.ValueMember = "MaCH";
            cbo_MaCH.DisplayMember = "TenCH";
        }
        /// <summary>
        /// Hàm lấy giá bán hiện tại của sản phẩm trong cửa hàng  
        /// </summary>
        /// <param name="maSP">mã sản phẩm</param>
        /// <returns>giá bán hiện tại của một cửa hàng</returns>
        private double LayGiaBanCuaSanPham(string maCH, string maSP)
        {

            return bus_CTK.LayGiaBanCuaSanPhamCuaMotCH(maCH, maSP);
        }
        /// <summary>
        /// hàm cập nhập tổng tiền cho hoá đơn
        /// </summary>
        /// <param name="hoaDon">truyền giá trị hoá đơn cần chỉnh</param>
        private void CapNhapTongTienHoaDon(ET_HoaDon hoaDon)
        {
            try
            {

                bus_hd.Sua(hoaDon);
            }
            catch (Exception ex) { MessageBox.Show("Cập nhập tổng tiền thất bại\n Lỗi:" + ex, "Thông báo"); }

        }

        private void CapNhapTongTienChoHoaDon()
        {
            et_hd.MaHoaDon = maHDMoiThem;
            et_hd.MaCuaHang = cbo_MaCH.Text;
            et_hd.MaNhanVien = txt_MaNV.Text;
            et_hd.NgayLap = Convert.ToDateTime(dtp_NgayLapHD.Text);
            et_hd.TongTien = bus_cthd.TinhTongTienTheoMaHD(maHDMoiThem);
            CapNhapTongTienHoaDon(et_hd);

        }
        /// <summary>
        /// Hàm kiểm tra, áp dụng khuyến mãi và cập nhập lại tổng tiền cho hoá đơn
        /// </summary>
        /// <param name="hd"> hoá đơn cần kiểm tra</param>
        /// <param name="tgianMua">tgian lập hoá đơn </param>
        private void ApDungKhuyenMaiChoHoaDon(ET_HoaDon hd, DateTime tgianMua)
        {
            var km_HD = bus_KM.ApDungKhuyenMaiChoHoaDon(hd, tgianMua);
            if (km_HD != null)
            {
                lbl_KhuyenMai_HoaDon.Text = "Đã áp dụng khuyến mãi cho hoá đơn trên " + km_HD.DieuKienAP + " giảm " + km_HD.MucGiamGia + "vnd";
                hd.TongTien -= km_HD.MucGiamGia;
                CapNhapTongTienHoaDon(et_hd);


            }
            else
            {
                lbl_KhuyenMai_HoaDon.Text = "";
            }
        }
        // function làm mới các control
        private void LamMoiHoaDon()
        {
            txt_MaHD.Clear();
            dtp_NgayLapHD.Text = DateTime.Now.ToShortDateString();

        }
        private void LamMoiChiTietHoaDon()
        {
            txt_MaCTHD.Clear();
            txt_SanPham.Clear();
            txt_SanPham.Text = "SP00";
            txt_SL.Clear();
            txt_ThanhTien.Text = "0";
            txt_DonGia.Clear();
        }
        private void LamMoiLableKhuyenMai()
        {
            lbl_KhuyenMai_HoaDon.Text = "";
            lbl_KhuyenMai_SanPham.Text = "";
        }
        public bool KiemTraSoNguyenHopLe(string s)
        {
            return int.TryParse(s, out _);
        }

        private void txt_SL_Leave(object sender, EventArgs e)
        {
            if (!KiemTraSoNguyenHopLe(txt_SL.Text))
            {
                errorProvider1.SetError(txt_SL,"Chỉ được nhập số");
                txt_SL.Text = "";
            }
            else
            {
                errorProvider1.SetError(txt_SL, ""); 
            }
        }
    }
}
