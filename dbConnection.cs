using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquipmentManager
{
    class dbConnection
    {
        
        public static string connection
        {
            get
            {
                return "Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\demo\\EquipmentManager\\EquipmentManager\\database\\shebei.mdf;Integrated Security=True;Connect Timeout=30";
                //return "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\database\\shebei.mdf;Integrated Security=True;Connect Timeout=30";
            }
        }
    }
    
}
