using Gedaq.Base.Model;
using System;
using System.Collections.Generic;
using System.Text;

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