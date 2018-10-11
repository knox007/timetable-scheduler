using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Timetable_Processing.Control
{
    class Database_Controller
    {
        public SqlConnection New_Connection()
        {
            SqlConnection conn = new SqlConnection();
            return conn;
        }
    }
}
