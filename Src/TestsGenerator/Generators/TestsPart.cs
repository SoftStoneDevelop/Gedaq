using System.IO;
using System.Text;
using System.Threading.Tasks;
using TestsGenegator.Enums;
using TestsGenegator.Helpers;

namespace TestsGenegator.Generators
{
    internal class TestsPart
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public async Task Generate(Model.Model model, Database database, string destinationFolder)
        {
            _stringBuilder.Clear();
            Start(model, database);

            InsertModelInnerTest.Generate(0, _stringBuilder, model, database);

            End();

            Directory.CreateDirectory($"{destinationFolder}/TestsParts/");
            await File.WriteAllTextAsync($"{destinationFolder}/TestsParts/{model.ClassName}TestsPart.cs", _stringBuilder.ToString());
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
