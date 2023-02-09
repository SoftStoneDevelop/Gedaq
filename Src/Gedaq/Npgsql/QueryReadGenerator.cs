using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql
{
    internal class QueryReadGenerator
    {
        private List<string> _fildNames = new List<string>();
        private StringBuilder _methodCode = new StringBuilder();

        public string FileName
        {
            get; private set;
        }

        public string GetCode()
        {
            return _methodCode.ToString();
        }

        public void Reset()
        {
            _fildNames.Clear();
            _methodCode.Clear();
            FileName = null;
        }

        public void GenerateMethod(QueryReadNpgsql source)
        {
            Reset();

            //TODO
        }
    }
}