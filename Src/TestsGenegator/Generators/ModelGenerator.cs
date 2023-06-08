using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TestsGenegator.Model;

namespace TestsGenegator.Generators
{
    internal class ModelGenerator
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public void Generate(List<Model.Model> models, SourceProductionContext context)
        {
            foreach (var model in models)
            {
                Model(model, context);
                ModelInner(model.ModelInner, context);
            }
        }

        private void Model(Model.Model model, SourceProductionContext context)
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
            context.AddSource($"{model.ClassName}.g.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }

        private void ModelInner(Model.ModelInner model, SourceProductionContext context)
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
            context.AddSource($"{model.ClassName}.g.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }
    }
}