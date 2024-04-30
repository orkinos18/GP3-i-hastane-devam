using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//ekle

namespace GP3iö30042024
{
    internal class metodlar
    {
        SqlConnection bag = new SqlConnection("server=orkinos\\orkinos;initial catalog=hastanerandevu;integrated security=true");
        public void lbyukle(ListBox lb,string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lb.DataSource = dt;
            lb.DisplayMember = dt.Columns[1].ColumnName;//"polno","doktorno,"saatno
            lb.ValueMember = dt.Columns[0].ColumnName;// "polno". . . ;
        }

    }
}
