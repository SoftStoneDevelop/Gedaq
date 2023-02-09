using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;

namespace Gedaq
{
    [Generator]
    public partial class Gedaq : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            //System.Diagnostics.Debugger.Launch();

            var c = (CSharpCompilation)context.Compilation;

            var processor = new AttributeProcessor();
            FillTypes(c.Assembly.GlobalNamespace, processor);
            processor.GenerateAndSaveMethods(context);
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }

        private void FillTypes(INamespaceOrTypeSymbol symbol, AttributeProcessor processor)
        {
            var queue = new Queue<INamespaceOrTypeSymbol>();
            queue.Enqueue(symbol);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (current is INamedTypeSymbol type)
                {
                    processor.TryFillFrom(type);
                }

                foreach (var child in current.GetMembers())
                {
                    if (child is INamespaceOrTypeSymbol symbolChild)
                    {
                        queue.Enqueue(symbolChild);
                    }
                }
            }
        }
    }
}