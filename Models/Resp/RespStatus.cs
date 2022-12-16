using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DPDHL_GIAAPI.Models
{
    class RespStatus
    {
        [XmlElement("GI")]
        public string GI { get; set; }

        [XmlElement("Sev")]
        public int Sev { get; set; }

        [XmlElement("MsgCIgd")]
        public int MsgCIgd { get; set; }

        [XmlElement("MsgClg")]
        public string MsgClg { get; set; }

        [XmlElement("Dsc")]
        public string Dsc { get; set; }

        [XmlElement("DtlDsc")]
        public string DtlDsc { get; set; }

        [XmlElement("RpBy")]
        public string RpBy { get; set; }
    }
}
