using DPDHL_GIAAPI.Constanst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DPDHL_GIAAPI.Models.Reqt
{
    [XmlRoot(ElementName = "GenrcRqObj")]
    public class GenrcRqObj
    {
        [XmlElement(ElementName = "RspnAtt")]
        public List<string> RspnAtt { get; set; }
        [XmlAttribute(AttributeName = "MxRspnRecs")]
        public string MxRspnRecs { get; set; }
        [XmlAttribute(AttributeName = "ObjTyCd")]
        public CObjTyCd ObjTyCd { get; set; }

        internal GenrcRqObj()
        {
            RspnAtt = new List<string>();
        }
    }
}
