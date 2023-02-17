using Gedaq.DbConnection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.DbConnection
{
    internal class QueryBatch : BaseGenerateItem
    {
        public bool AllSameTypes = true;
        public bool HaveParametrs;
    }
}