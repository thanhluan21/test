﻿using System;
using System.Collections.Generic;

#nullable disable

namespace wepchamcongversion1.Models
{
    public partial class ApDungThamNien
    {
        public string MaChinhSachNghiPhep { get; set; }
        public string MaThamNien { get; set; }

        public virtual ChinhSachNghiPhep MaChinhSachNghiPhepNavigation { get; set; }
        public virtual ChinhSachTheoThamNien MaThamNienNavigation { get; set; }
    }
}
