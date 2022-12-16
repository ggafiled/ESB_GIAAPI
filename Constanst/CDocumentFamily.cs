using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPDHL_GIAAPI.Constanst
{
    public enum CDocumentFamily
    {
        WB, /*** For retrieve waybills ***/
        PPW, /*** For retrieve paperwork ***/
        INV, /*** For retrieve invoice ***/
        ENT, /*** For retrieve customs document ***/
        CA /*** For retrieve customer agreements ***/
    }
}
