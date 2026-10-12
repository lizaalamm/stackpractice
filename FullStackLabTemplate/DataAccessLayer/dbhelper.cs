using Npgsql;

namespace DataAccessLayer
{
    public class dbhelper
    {
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(
                "Host=aws-0-ap-northeast-2.pooler.supabase.com;" +
                "Port=6543;" +
                "Database=postgres;" +
                "Username=postgres.owquixbxhphzvihqzhpy;" +
                "Password=lizaalam123;" +
                "SSL Mode=Require;" +
                "Trust Server Certificate=true"
            );
        }
    }
}