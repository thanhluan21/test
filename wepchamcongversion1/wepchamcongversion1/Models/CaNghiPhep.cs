﻿using System;
using System.Collections.Generic;

#nullable disable

namespace wepchamcongversion1.Models
{
    public partial class CaNghiPhep
    {
        public string MaNgayNghiPhep { get; set; }
        public string MaYeuCauNghiPhep { get; set; }
        public string MaCaLamViec { get; set; }
        public bool? Xoa { get; set; }

        public virtual CaLamViec MaCaLamViecNavigation { get; set; }
        public virtual NgayNghiPhep MaNgayNghiPhepNavigation { get; set; }
        public virtual YeuCauNghiPhep MaYeuCauNghiPhepNavigation { get; set; }
    }
}
