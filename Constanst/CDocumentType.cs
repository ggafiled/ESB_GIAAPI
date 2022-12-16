using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPDHL_GIAAPI.Constanst
{
    public enum CDocumentType
    {
        EWB, /*** For Electronic Waybill ***/
        HWB, /*** For House Waybill ***/
        INV, /*** For Commercial Invoice ***/
        CRL, /*** For Control Document ***/
        CI2, /*** For Export Invoice ***/
        FRI, /*** For Freight Invoice ***/
        DVI, /*** For Duty And VAT Invoice ***/
        DTI, /*** For Duty Only Invoices ***/
        VTI, /*** For VAT Only Invoices ***/
        FDI, /*** For Freight And Duty Invoices ***/
        WHI, /*** For Warehouse Invoice ***/
        ENT, /*** For Customs Entry  ***/
        CSD, /*** For Consolidated Customs Entry  ***/
        MFT, /*** For Customs Manifest ***/
        REC, /*** For Customs Clearance Receipt ***/
        EXL, /*** For XML Entry ***/
        CRQ, /*** For Customer Request ***/
        CUA, /*** For Customer Agreement ***/
        ADA, /*** For Customer Agreement DHL Approval ***/
        POA, /*** For Customer Handling Authorizations ***/
        CAO /*** For Other Customer Agreement ***/
    }
}
