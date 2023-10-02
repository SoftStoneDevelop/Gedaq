using System.Text;

namespace Gedaq.Base
{
    internal abstract class BaseGenerator
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
    }
}