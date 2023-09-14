using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;

namespace Gedaq.Base
{
    internal abstract class BaseAttributeProcessor
    {
        public abstract void ProcessAttributes(
            SyntaxList<AttributeListSyntax> attributes,
            Compilation compilation, 
            INamedTypeSymbol containsType,
            CancellationToken cancellationToken
            );

        public abstract void CompleteProcessContainTypes();

        public abstract void GenerateAndSaveMethods(
            SourceProductionContext context,
            CancellationToken cancellationToken
            );

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

        protected void ProcessAttribute(
            AttributeData attribute,
            INamedTypeSymbol containsType, 
            List<FormatParametr> formatParametrs
            )
        {
            if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Common.Attributes", "QueryFormatAttribute"))
            {
                ProcessQueryFormat(attribute, containsType, formatParametrs);
            }
        }

        private void ProcessQueryFormat(AttributeData formatAttribute, INamedTypeSymbol containsType, List<FormatParametr> formatParametrs)
        {
            if (!FormatParametr.CreateNew(formatAttribute.ConstructorArguments, containsType, out var format, out var methodName))
            {
                throw new Exception($"Unknown {nameof(FormatParametr)} constructor");
            }

            formatParametrs.Add(format);
        }
    }
}