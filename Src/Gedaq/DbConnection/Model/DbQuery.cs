using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.DbConnection.Model
{
    internal class DbQuery : QueryBase
    {
        public DbParametr[] Parametrs;
        public bool HaveParametrs()
        {
            return Parametrs != null;
        }
    }
}