using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANZLEE_RETAIL_MANAGEMENT_SYSTEM
{
    class CONNECTIONSTRING
    {
        //Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\MSM_DB.mdf;Integrated Security=True;User Instance=True
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\Administrator\Documents\Visual Studio 2015\Projects\MANZLEE RETAIL MANAGEMENT SYSTEM\MANZLEE RETAIL MANAGEMENT SYSTEM\PURCHAS.mdf";Integrated Security=True;User Instance=False
        public string dbcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PURCHAS.mdf;Integrated Security=True";
    }
}
