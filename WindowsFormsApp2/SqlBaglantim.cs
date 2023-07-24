using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
   public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-TDUP3J1\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
