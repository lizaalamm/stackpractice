using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    internal class dbhelper
    {
        public static NpsqlConnection GetConnection()
        {
            return new NpsqlConnection("Host=aws-0-ap-northeast-2.pooler.supabase.com;Port=6543;Database=postgres;Username=postgres.owquixbxhphzvihqzhpy;Password=[YOUR-PASSWORD];SSL Mode=Require;Trust Server Certificate=true")
        }
    }
}
