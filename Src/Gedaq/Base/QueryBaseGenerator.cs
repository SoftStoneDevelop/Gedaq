using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.Base
{
    internal abstract class QueryBaseGenerator
    {
        protected StringBuilder _methodCode = new StringBuilder();

        public string GetCode()
        {
            var code = _methodCode.ToString();
            return code;
        }

        protected void Reset()
        {
            _methodCode.Clear();
        }

        protected void End()
        {
            _methodCode.Append($@"
    }}
}}
");
        }
    }
}