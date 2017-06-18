using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquipmentManager
{
    class BaseClass
    {
        #region 判断是否为数字
        /// <summary>
        /// 判断数据字符是否为数字（1234567890.）
        /// </summary>
        /// <param name="strCode">需要判断的字符串</param>
        /// <returns></returns>
        public bool IsNumeric(string strCode)
        {

            if (strCode == null || strCode.Length == 0)
            {
                return false;
            }
            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] byteStr = ascii.GetBytes(strCode);
            foreach (byte code in byteStr)
            {

                //if (code == 190 || code == 110)                //.的ASCII为110或190
                    if (code < 48 || code > 57)
                        return false;
            }
            return true;
        }
        #endregion
    }
}
