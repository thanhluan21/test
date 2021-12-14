using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace wepchamcongversion1.Models
{
    public partial class MauNghiPhep
    {
        public MauNghiPhep()
        {
            KhuVucApDungMauNghiPheps = new HashSet<KhuVucApDungMauNghiPhep>();
            NguoiPheDuyetNghiPheps = new HashSet<NguoiPheDuyetNghiPhep>();
            NguoiTheoDoiNghiPheps = new HashSet<NguoiTheoDoiNghiPhep>();
            YeuCauNghiPheps = new HashSet<YeuCauNghiPhep>();
        }
        [DisplayName("Mã Mẫu Nghỉ Phép")]
        public string MaMauNghiPhep { get; set; }
        [DisplayName("Tên Mẫu Nghỉ Phép")]
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is requied")]
        public string TenMauNghiPhep { get; set; }
        [DisplayName("Mã Loại Nghỉ Phép")]
        [Required(ErrorMessage = "This field is requied")]
        public string MaLoaiNghiPhep { get; set; }
        [DisplayName("Yêu Cầu Phê Duyệt")]
        [Required(ErrorMessage = "This field is requied")]
        public bool? YeuCauPheDuyet { get; set; }
        [DisplayName("Mã Quy Trình Phê Duyệt")]
        [Required(ErrorMessage = "This field is requied")]
        public string MaQuyTrinhPheDuyet { get; set; }
        [DisplayName("Gioi Hạng Ngày Nghỉ")]

        [Required(ErrorMessage = "This field is requied")]
        public bool? GioiHanNgayNghi { get; set; }
        [DisplayName("Thời gian xử lý")]
        
        public byte? ThoiHanXuLy { get; set; }
        [DisplayName("Số Ngày Trước Ngày Nghỉ")]

      
        public byte? SoNgayTruocNgayNghi { get; set; }
        [DisplayName("Gioi Hạng Số Ngày Nghỉ")]

        public byte? GioiHanSoNgayNghi { get; set; }
        [DisplayName("Quy Định")]
       /* [Required(ErrorMessage = "This field is requied")]*/
        public string QuiDinh { get; set; }
        [DisplayName("Xóa")]

        public bool? Xoa { get; set; }

        public virtual LoaiNghiPhep MaLoaiNghiPhepNavigation { get; set; }
        public virtual QuyTrinhPheDuyet MaQuyTrinhPheDuyetNavigation { get; set; }
        public virtual ICollection<KhuVucApDungMauNghiPhep> KhuVucApDungMauNghiPheps { get; set; }
        public virtual ICollection<NguoiPheDuyetNghiPhep> NguoiPheDuyetNghiPheps { get; set; }
        public virtual ICollection<NguoiTheoDoiNghiPhep> NguoiTheoDoiNghiPheps { get; set; }
        public virtual ICollection<YeuCauNghiPhep> YeuCauNghiPheps { get; set; }
    }
}
