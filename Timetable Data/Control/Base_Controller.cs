using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Data.Control
{
    abstract class Base_Controller<T> where T : class
    {
        private static string connection_string
            = @"Server=.\SQLEXPRESS;Database=Timsh;Integrated Security=SSPI;";
        protected IDbConnection connection = null;
        
        public Base_Controller()
        {
            connection = new SqlConnection(connection_string);
        }

        public bool Exists_In_Table(string table_name,
            string column_name, string column_value)
        {
            return connection.ExecuteScalar<bool>
                ("SELECT COUNT(1) FROM " + table_name +
                "WHERE "+ column_name + " = @Id", new { column_value });
        }

        public virtual T Get(int Id)
        {
            return connection.Get<T>(Id);
        }
        public virtual long Insert(T t)
        {
            return connection.Insert<T>(t);
        }
        public virtual bool Delete(T t)
        {
            return connection.Delete<T>(t);
        }
        public virtual bool Update(T t)
        {
            return connection.Update<T>(t);
        }
        public virtual List<T> Get_All()
        {
            return connection.GetAll<T>().ToList();
        }
    }
}
