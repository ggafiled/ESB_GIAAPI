using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPDHL_GIAAPI.Models
{
    class Img
    {
        public string ImgId { get; set; }
        public DateTime AvlDtm { get; set; }
        public string Loc { get; set; }
        public DatElGrp DatElGrp { get; set; }
    }
}
