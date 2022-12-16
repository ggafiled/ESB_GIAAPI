using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DPDHL_GIAAPI.Constanst;

namespace DPDHL_GIAAPI.Models.Reqt
{
    [XmlRoot(ElementName = "GenrcRqCmd")]
    public class GenrcRqCmd
    {
        [XmlAttribute(AttributeName = "TyCd")]
        public CTyCd TyCd { get; set; }

        [XmlText]
        public string Text { get; set; }

        internal GenrcRqCmd(CTyCd TyCd, string Text = "")
        {
            this.TyCd = TyCd;
            this.Text = Text;
        }
    }
}
