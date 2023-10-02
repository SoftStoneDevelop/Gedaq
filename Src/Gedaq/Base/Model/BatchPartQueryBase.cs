using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Base.Model
{
    internal class BatchPart<T> : BatchPartBase where T : QueryBaseCommand
    {
        public BatchPart(T queryBase, int number) : base(queryBase, number)
        {
        }

        public T Query
        {
            get => (T)QueryBase;
        }
    }

    internal abstract class BatchPartBase
    {
        public BatchPartBase(QueryBaseCommand queryBase, int number)
        {
            QueryBase = queryBase;
            Number = number;
        }

        public QueryBaseCommand QueryBase
        {
            get;
            private set;
        }

        public int Number { get; private set; }

        public int Index { get; set; }

        public string VariableName(BaseParametr baseParametr, string postfix = default)
        {
            return $"{baseParametr.VariableName(postfix)}Batch{Number}";
        }

        public string FormatName(FormatParametr formatParametr)
        {
            return $"{formatParametr.Name}Batch{Number}";
        }
    }
}