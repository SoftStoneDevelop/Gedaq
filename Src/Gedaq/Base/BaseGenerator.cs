using Microsoft.CodeAnalysis;
using System.Text;

namespace Gedaq.Base
{
    internal abstract class BaseGenerator
    {
        protected StringBuilder _methodCode = new StringBuilder();
        protected readonly SourceProductionContext _context;

        protected BaseGenerator(SourceProductionContext context)
        {
            _context = context;
        }

        public string GetCode()
        {
            var code = _methodCode.ToString();
            return code;
        }

        protected void Reset()
        {
            _methodCode.Clear();
        }
    }
}