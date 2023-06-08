using Microsoft.CodeAnalysis;
using System.Text;
using TestsGenegator.Enums;
using TestsGenegator.Helpers;

namespace TestsGenegator.Generators
{
    internal class TestsPart
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public void Generate(Model.Model model, Database database, SourceProductionContext context)
        {
            _stringBuilder.Clear();
            Start(model, database);

            InsertModelInnerTest.Generate(0, _stringBuilder, model, database);

            End();

            context.AddSource($"{model.ClassName}TestsPart.g.cs", _stringBuilder.ToString());
        }

        private void Start(Model.Model model, Database database)
        {
            _stringBuilder.AppendLine($@"
{database.ToUsings()}

using NUnit.Framework;
using System.Data.Common;
using System.Threading.Tasks;

namespace Tests
{{
    internal partial class Tests{model.TypeInfo.TypeName}
    {{
");
        }

        private void End()
        {
            _stringBuilder.AppendLine($@"
    }}
}}
");
        }
    }
}
