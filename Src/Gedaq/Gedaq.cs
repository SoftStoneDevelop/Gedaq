using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Gedaq
{
    [Generator]
    public class Gedaq : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var c = (CSharpCompilation)context.Compilation;
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }
    }
}