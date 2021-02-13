using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TalyplarOyiSystema
{
   public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-0K1CF3Q\SQLEXPRESS;Initial Catalog=TalyplarOyi;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
