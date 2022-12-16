using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DPDHL_GIAAPI.Constanst;

namespace DPDHL_GIAAPI.Models.Reqt
{
    [XmlRoot(ElementName = "GenrcRqCritr")]
    public class GenrcRqCritr
    {
        [XmlElement(ElementName = "Val")]
        public string Val { get; set; }
        [XmlAttribute(AttributeName = "TyCd")]
        public string TyCd { get; set; }
        [XmlAttribute(AttributeName = "CompOp")]
        public string CompOp { get; set; }

        internal GenrcRqCritr(string Val, CTyCd TyCd, CCompOp CompOp)
        {
            this.Val = Val;
            this.TyCd = nameof(TyCd);
            this.CompOp = nameof(CompOp);
        }
    }
}
