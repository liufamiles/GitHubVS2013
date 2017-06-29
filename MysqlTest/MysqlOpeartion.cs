using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;

namespace MysqlTest
{
    public abstract class MysqlOpeartion
    {
        //数据库连接字符串
        public static string Conn = @"Database='wp';Data Source='localhost';User Id='root';
            Password='root';charset='utf8';pooling=true";

        // 用于缓存参数的HASH表
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());
        public MysqlOpeartion() { }



    }
}
