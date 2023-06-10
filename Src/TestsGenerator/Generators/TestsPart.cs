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
            var storage = InitStorage(model, 30);

            Start(model, database);

            StartRegion("InsertModel");
            InsertModelInnerTest.Generate(0, _stringBuilder, model, storage, database);
            EndRegion();

            StartRegion("InsertModelInner");
            InsertModelTest.Generate(1, _stringBuilder, model, storage, database);
            EndRegion();

            StartRegion("Select Models");
            SelectModelTest.Generate(2, _stringBuilder, model, storage, database);
            EndRegion();

            End();

            Directory.CreateDirectory($"{destinationFolder}/TestsParts/");
            await File.WriteAllTextAsync($"{destinationFolder}/TestsParts/{model.ClassName}TestsPart.cs", _stringBuilder.ToString());
        }

        private void StartRegion(string regionName)
        {
            _stringBuilder.Append($@"
#region {regionName}
");
        }
        
        private void EndRegion()
        {
            _stringBuilder.Append($@"
        #endregion
");
        }

        private ModelValueStorage InitStorage(Model.ModelType model, int valuesCount)
        {
            var storage = model.NewStorage();
            for (int i = 0; i < valuesCount; i++)
            {
                storage.AddNewValue();
            }

            return storage;
        }

        private void Start(Model.ModelType model, Database database)
        {
            _stringBuilder.AppendLine($@"
{database.ToUsings()}

using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
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
