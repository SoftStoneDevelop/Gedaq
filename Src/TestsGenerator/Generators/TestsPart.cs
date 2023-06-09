using System.IO;
using System.Text;
using System.Threading.Tasks;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal class TestsPart
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public async Task Generate(Model.ModelType model, Database database, string destinationFolder)
        {
            _stringBuilder.Clear();
            var storage = InitStorage(model);

            Start(model, database);

            InsertModelInnerTest.Generate(0, _stringBuilder, model, storage, database);
            InsertModelTest.Generate(1, _stringBuilder, model, storage, database);

            End();

            Directory.CreateDirectory($"{destinationFolder}/TestsParts/");
            await File.WriteAllTextAsync($"{destinationFolder}/TestsParts/{model.ClassName}TestsPart.cs", _stringBuilder.ToString());
        }

        private ModelValueStorage InitStorage(Model.ModelType model)
        {
            var storage = model.NewStorage();
            for (int i = 0; i < 12; i++)
            {
                storage.AddNewValue();
            }

            return storage;
        }

        private void Start(Model.ModelType model, Database database)
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
