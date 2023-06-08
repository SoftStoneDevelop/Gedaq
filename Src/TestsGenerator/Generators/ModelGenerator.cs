using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestsGenegator.Generators
{
    internal class ModelGenerator
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public void Generate(List<Model.Model> models, string destinationFolder)
        {
            foreach (var model in models)
            {
                Model(model, destinationFolder);
                ModelInner(model.ModelInner, destinationFolder);
            }
        }

        private void Model(Model.Model model, string destinationFolder)
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
            File.WriteAllText($"{destinationFolder}/Model/{model.ClassName}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }

        private void ModelInner(Model.ModelInner model, string destinationFolder)
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
            File.WriteAllText($"{destinationFolder}/Model/{model.ClassName}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }
    }
}