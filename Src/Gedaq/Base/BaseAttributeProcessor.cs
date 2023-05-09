using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Base
{
    internal class BaseAttributeProcessor
    {
        protected Dictionary<string, List<FormatParametr>> _formatsTemp = new Dictionary<string, List<FormatParametr>>();

        protected void AddFormatParametrs(QueryBaseCommand read)
        {
            var set = new HashSet<int>();
            if (_formatsTemp.TryGetValue(read.MethodName, out var parametrs))
            {
                parametrs = parametrs.OrderBy(or => or.Position).ToList();
                read.FormatParametrs = new FormatParametr[parametrs.Count];

                set.Clear();
                for (int i = 0; i < parametrs.Count; i++)
                {
                    var parametr = parametrs[i];
                    if (!set.Add(parametr.Position))
                    {
                        throw new Exception("Parametr position must be unique");
                    }

                    read.FormatParametrs[i] = parametr;
                }
            }
        }

        protected void ProcessAttribute(AttributeData attribute, INamedTypeSymbol containsType)
        {
            if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Common.Attributes", "QueryFormatAttribute"))
            {
                ProcessQueryFormat(attribute, containsType);
            }
        }

        private void ProcessQueryFormat(AttributeData formatAttribute, INamedTypeSymbol containsType)
        {
            if (!FormatParametr.CreateNew(formatAttribute.ConstructorArguments, containsType, out var format, out var methodName))
            {
                throw new Exception($"Unknown {nameof(FormatParametr)} constructor");
            }

            if (!_formatsTemp.ContainsKey(methodName))
            {
                var methods = new List<FormatParametr>();
                _formatsTemp.Add(methodName, methods);
            }

            _formatsTemp[methodName].Add(format);
        }
    }
}