using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DPDHL_GIAAPI.Interfaces;
using DPDHL_GIAAPI.Models.Reqt;
using DPDHL_GIAAPI.Constanst;
using System.Xml.Serialization;
using System.IO;

namespace DPDHL_GIAAPI.Utils
{

    public static class Utils
    {

        static XmlElement GenerateXmlHeader(XmlDocument xmlRequest)
        {
            XmlElement root = xmlRequest.CreateElement("Envelope", " ");
            root.Prefix = "SOAP-ENV";
            root.SetAttribute("xmlns:ns0", "DocumentManagement.SOAP.PublishedDocumentImageQuery");
            root.SetAttribute("xmlns:ns1", "http://schemas.xmlsoap.org/soap/envelope/");
            root.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            root.SetAttribute("xmlns:v3", "http://www.dhl.com/Express/CM/CM_GenRqstMsg/v3");
            root.SetAttribute("xmlns:SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/");

            return root;
        }

        public static string GenerateSoapRequest(GenReq genReq)
        {
            XmlDocument xmlRequest = new XmlDocument();
            XmlElement root = GenerateXmlHeader(xmlRequest);

            XmlElement body = xmlRequest.CreateElement("ns1:Body", "http://schemas.xmlsoap.org/soap/envelope/");

            XmlElement publishedDocumentImageQuery = xmlRequest.CreateElement("ns0:PublishedDocumentImageQuery", "DocumentManagement.SOAP.PublishedDocumentImageQuery");

            XmlElement genRqstMsg = xmlRequest.CreateElement("v3:GenRqstMsg", "http://www.dhl.com/Express/CM/CM_GenRqstMsg/v3");

            genRqstMsg.InnerXml = @"
                <Hdr Id='e2cfae2f-62a1-483f-aeed-8a50420f3bc7' Ver='1.004' Dtm='2018-01-29T16:48:40' sysEnvCd='PROD'>
               <GI sysEnvCd='PROD'>
                  <TID Src='E2E' TID='10b26ebe-157c-49b8-97fe-746203aeff92'/>
               </GI>
               <Sndr AppCd='UAT_DK' AppVer='2.0' AppNm='UAT_DK'/>
               <Rcp AppCd='UAT_DK'/>
               <Orgntr AppCd='UAT_DK'/>
            </Hdr>
            ";

            XmlElement bd = xmlRequest.CreateElement("Bd");

            bd.InnerXml = ConvertObjClassToXml(xmlRequest, genReq);

            genRqstMsg.AppendChild(bd);
            publishedDocumentImageQuery.AppendChild(genRqstMsg);

            body.AppendChild(publishedDocumentImageQuery);

            root.AppendChild(body);

            xmlRequest.AppendChild(root);

            return xmlRequest.OuterXml;
        }

        static string ConvertObjClassToXml(XmlDocument xmlRequest, GenReq genReq)
        {
            XmlElement root = xmlRequest.CreateElement(nameof(GenReq));
            foreach (GenrcRqCritr critr in genReq.GenrcRqCritr)
            {
                XmlElement critrEl = xmlRequest.CreateElement(typeof(GenrcRqCritr).Name);
                critrEl.SetAttribute("TyCd", critr.TyCd.ToString());
                XmlElement critrValEl = xmlRequest.CreateElement("Val");
                critrValEl.InnerText = critr.Val;
                critrEl.AppendChild(critrValEl);
                root.AppendChild(critrEl);
            }

            XmlElement rqobjEl = xmlRequest.CreateElement(typeof(GenrcRqObj).Name);
            rqobjEl.SetAttribute("MxRspnRecs", genReq.GenrcRqObj.MxRspnRecs);
            rqobjEl.SetAttribute("ObjTyCd", genReq.GenrcRqObj.ObjTyCd.ToString());

            foreach (string att in genReq.GenrcRqObj.RspnAtt)
            {
                XmlElement attEl = xmlRequest.CreateElement("RspnAtt");
                attEl.InnerText = att;
                rqobjEl.AppendChild(attEl);
            }
            root.AppendChild(rqobjEl);

            foreach (GenrcRqCmd cmd in genReq.GenrcRqCmd)
            {
                XmlElement cmdEl = xmlRequest.CreateElement(typeof(GenrcRqCmd).Name);
                cmdEl.SetAttribute("TyCd", cmd.TyCd.ToString());
                cmdEl.InnerText = cmd.Text;
                root.AppendChild(cmdEl);
            }
            return root.OuterXml;
        }
    }
}
