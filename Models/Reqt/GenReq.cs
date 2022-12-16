using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DPDHL_GIAAPI.Models.Reqt
{
    [XmlRoot(ElementName = "GenReq")]
    public class GenReq
    {
        [XmlElement(ElementName = "GenrcRqCritr")]
        public List<GenrcRqCritr> GenrcRqCritr { get; set; }
        [XmlElement(ElementName = "GenrcRqObj")]
        public GenrcRqObj GenrcRqObj { get; set; }
        [XmlElement(ElementName = "GenrcRqCmd")]
        public List<GenrcRqCmd> GenrcRqCmd { get; set; }

        public GenReq()
        {

        }

        public GenReq(List<GenrcRqCritr> GenrcRqCritr, GenrcRqObj GenrcRqObj, List<GenrcRqCmd> GenrcRqCmd)
        {
            this.GenrcRqCritr = GenrcRqCritr;
            this.GenrcRqObj = GenrcRqObj;
            this.GenrcRqCmd = GenrcRqCmd;
        }
    }
}
