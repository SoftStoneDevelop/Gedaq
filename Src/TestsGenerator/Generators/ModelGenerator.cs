using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TestsGenerator.Generators
{
    internal class ModelGenerator
    {
        private readonly StringBuilderArray.StringBuilderArray _stringBuilder = new StringBuilderArray.StringBuilderArray();

        public async Task Generate(List<Model.ModelType> models, string destinationFolder)
        {
            var directory = Directory.CreateDirectory($"{destinationFolder}/Model/");
            foreach (var file in directory.GetFiles())
            {
                File.Delete(file.FullName);
            }

            foreach (var model in models)
            {
                await Model(model, destinationFolder);
                await ModelInner(model.ModelInner, destinationFolder);
            }
        }

        private async Task Model(Model.ModelType model, string destinationFolder)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append($@"
namespace Tests
{{
    public class {model.ClassName}
    {{
        public {model.IdType} {model.IdName} {{ get; set; }}

        public {model.ValueType} {model.ValueName} {{ get; set; }}

        public {model.ModelInnerType} {model.ModelInnerName} {{ get; set; }}

        public {model.NullableValueType} {model.NullableValueName} {{ get; set; }}
    }}
}}

");
            await File.WriteAllTextAsync($"{destinationFolder}/Model/{model.ClassName}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }

        private async Task ModelInner(Model.ModelInnerType model, string destinationFolder)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append($@"
namespace Tests
{{
    public class {model.ClassName}
    {{
        public {model.IdType} {model.IdName} {{ get; set; }}

        public {model.ValueType} {model.ValueName} {{ get; set; }}

        public {model.NullableValueType} {model.NullableValueName} {{ get; set; }}
    }}
}}

");
            await File.WriteAllTextAsync($"{destinationFolder}/Model/{model.ClassName}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }
    }
}