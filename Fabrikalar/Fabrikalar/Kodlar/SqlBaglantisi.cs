using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Fabrikalar.Kodlar
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-7RH20KT;Initial Catalog=Lokanta1;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        public SqlConnection kapat()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-7RH20KT;Initial Catalog=Lokanta1;Integrated Security=True");
            baglan.Close();
            return baglan;
        }
        
    }
}
