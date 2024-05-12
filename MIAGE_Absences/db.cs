using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace MIAGE_Absences
{
    class db
    {
        public static MySqlConnection cn = new MySqlConnection("server=192.168.15.31;uid=root;pwd=Miage2023*;database=miage;CHARSET=utf8");
    }
}
