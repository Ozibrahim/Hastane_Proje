using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastahane_Proje
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-I8RD6T2;Initial Catalog=HastahaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
            
        }
    }
}
