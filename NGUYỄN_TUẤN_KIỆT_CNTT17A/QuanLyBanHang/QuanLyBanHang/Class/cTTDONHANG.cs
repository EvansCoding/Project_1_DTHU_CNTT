using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Class
{
    class cTTDONHANG
    {

        #region PROPERTIES
        private string strMASP;
        private string strTENSP;
        private int iSOLUONG;
        private decimal dGIA;
        public string StrTENSP { get => strTENSP; set => strTENSP = value; }
        public string StrMASP { get => strMASP; set => strMASP = value; }
        public int ISOLUONG { get => iSOLUONG; set => iSOLUONG = value; }
        public decimal DGIA { get => dGIA; set => dGIA = value; }
        #endregion

    }
}
