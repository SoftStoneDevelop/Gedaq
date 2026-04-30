using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Base
{
    internal abstract class BaseAttributeProcessor
    {
        protected readonly SourceProductionContext _context;

        protected BaseAttributeProcessor(SourceProductionContext context)
        {
            _context = context;
        }

        public abstract void ProcessAttributes(
            SyntaxList<AttributeListSyntax> attributes,
            Compilation compilation, 
            INamedTypeSymbol containsType);

        public abstract void CompleteProcessContainTypes();

        public abstract void GenerateAndSaveMethods();

        protected void AddFormatParametrs(QueryBaseCommand read, List<FormatParametr> formatParametrs)
        {
            if (formatParametrs.Count == 0)
            {
                return;
            }

            if (read == null)
            {
                return;
            }

            var set = new HashSet<int>();
            var parametrs = formatParametrs.OrderBy(or => or.Position).ToList();
            read.FormatParametrs = new FormatParametr[parametrs.Count];

            for (int i = 0; i < parametrs.Count; i++)
            {
                var parametr = parametrs[i];
                if (!set.Add(parametr.Position))
                {
                    throw new Exception("Parametr position must be unique");
                }

                parametr.CalculateDatas(i);
                read.FormatParametrs[i] = parametr;
            }
        }

        protected void ProcessAttribute(
            AttributeData attribute,
            List<FormatParametr> formatParametrs)
        {
            if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Common.Attributes", "QueryFormatAttribute"))
            {
                ProcessQueryFormat(attribute, formatParametrs);
            }
        }

        private void ProcessQueryFormat(
            AttributeData formatAttribute,
            List<FormatParametr> formatParametrs)
        {
            if (!FormatParametr.CreateNew(
                _context,
                formatAttribute.ConstructorArguments,
                out var format))
            {
                return;
            }

            formatParametrs.Add(format);
        }
    }
}