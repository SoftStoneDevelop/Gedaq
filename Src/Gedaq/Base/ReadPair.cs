using Gedaq.Base.Model;
using System.Collections.Generic;

namespace Gedaq.Base
{
    internal class ReadPair<Q, P> 
        where P : BaseParametr
        where Q : QueryBaseCommand
    {
        public Q Query { get; set; }
        public List<P> Parametrs { get; } = new List<P>();

        public List<FormatParametr> FormatParametrs { get; } = new List<FormatParametr>();

        public bool IsEmpty()
        {
            return Query == null && Parametrs.Count == 0;
        }
    }
}