using Gedaq.Base.Model;

namespace Gedaq.Npgsql.Model
{
    internal class NpgsqlFieldInfo : FieldInfo
    {
        public NpgsqlFieldInfo(int npgsqlDbType)
        {
            NpgsqlDbType = npgsqlDbType;
        }

        public int NpgsqlDbType { get; private set; }
    }
}