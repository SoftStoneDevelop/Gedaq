using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TestsGenegator.Generators
{
    internal class ModelGenerator
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public async Task Generate(List<Model.Model> models, string destinationFolder)
        {
            foreach (var model in models)
            {
                await Model(model, destinationFolder);
                await ModelInner(model.ModelInner, destinationFolder);
            }
        }

        private async Task Model(Model.Model model, string destinationFolder)
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
            Directory.CreateDirectory($"{destinationFolder}/Model/");
            await File.WriteAllTextAsync($"{destinationFolder}/Model/{model.ClassName}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }

        private async Task ModelInner(Model.ModelInner model, string destinationFolder)
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
            Directory.CreateDirectory($"{destinationFolder}/Model/");
            await File.WriteAllTextAsync($"{destinationFolder}/Model/{model.ClassName}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }
    }
}