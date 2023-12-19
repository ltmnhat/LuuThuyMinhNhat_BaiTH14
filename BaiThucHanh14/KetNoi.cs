using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BaiThucHanh14
{
    class KetNoi
    {
        public SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(@"Data Source=A209PC02;Initial Catalog = QL_GiaoVien; Integrated Security = True");
        }
    }
}
