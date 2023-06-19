using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal class ModelValueStorage
    {
        public ModelValueStorage(TypeInfo typeInfo, ValueHelper valueStorage)
        {
            _id = new Int32ValueHelper(Enums.EnumerableType.SingleType);
            Value = valueStorage.NewInstance();
            NullableValue = valueStorage.NewInstance();
            _typeInfo = typeInfo;
        }

        private readonly TypeInfo _typeInfo;

        private readonly Int32ValueHelper _id;

        private ValueHelper Value { get; }

        private ValueHelper NullableValue { get; }

        private List<ModelValue> _values = new();
        public ReadOnlyCollection<ModelValue> Values => _values.AsReadOnly();

        private bool NextNull()
        {
            return Random.Shared.Next(2) == 1;
        }

        private bool _nextInnerNull;
        private bool NextInnerNull()
        {
            _nextInnerNull = !_nextInnerNull;
            return _nextInnerNull;
        }

        private HashSet<int> _modelIds = new();
        private HashSet<int> _innerModelIds = new();

        private string GetNextModelId(out int idValue)
        {
            while (true)
            {
                var idStr = _id.NewValue(out idValue);
                if(_modelIds.Add(idValue))
                {
                    return idStr;
                }
            }
        }

        private string GetNextInnerModelId(out int idValue)
        {
            while (true)
            {
                var idStr = _id.NewValue(out idValue);
                if (_innerModelIds.Add(idValue))
                {
                    return idStr;
                }
            }
        }

        public ModelValue AddNewValue()
        {
            InnerModelValue newInnerValue;
            if(NextInnerNull())
            {
                newInnerValue = null;
            }
            else
            {
                newInnerValue = new InnerModelValue
                {
                    Id = GetNextInnerModelId(out var idInnerValue),
                    IdValue = idInnerValue,
                    Value = NextValue(false),
                    NullableValue = NextNull() ? ValueConstants.NullValue : NextValue(true)
                };
            }

            var newValue = new ModelValue
            {
                Id = GetNextModelId(out var idValue),
                IdValue = idValue,
                Value = NextValue(false),
                NullableValue = NextNull() ? ValueConstants.NullValue : NextValue(true),

                InnerModel = newInnerValue
            };

            _values.Add(newValue);
            return newValue;
        }

        private string NextValue(bool nullable)
        {
            switch (Value._enumerableType)
            {
                default:
                case EnumerableType.SingleType:
                {
                    return Value.NewSingleValue();
                }
                case EnumerableType.Array:
                {
                    var count = Random.Shared.Next(3, 5);
                    var builder = new StringBuilder();
                    builder.Append($@"
new {_typeInfo.ItemTypeFullName}[{count}]
{{");
                    for (int i = 0; i < count; i++)
                    {
                        builder.Append($@"
{(nullable? NullableValue.NewSingleValue() : Value.NewSingleValue())},
");
                    }
                    builder.Append($@"
}}");
                    return builder.ToString();
                }
                case EnumerableType.List:
                {
                    var count = Random.Shared.Next(3, 5);
                    var builder = new StringBuilder();
                    builder.Append($@"
new System.Collections.Generic.List<{_typeInfo.ItemTypeFullName}>({count})
{{");
                    for (int i = 0; i < count; i++)
                    {
                        builder.Append($@"
{(nullable ? NullableValue.NewSingleValue() : Value.NewSingleValue())},
");
                    }
                    builder.Append($@"
}}");
                    return builder.ToString();
                }
            }
        }
    }

    internal class ModelValue
    {
        public string Id { get; set; }

        public int IdValue { get; set; }

        public string Value { get; set; }

        public string NullableValue { get; set; }

        public InnerModelValue InnerModel { get; set; }
    }

    internal class InnerModelValue
    {
        public string Id { get; set; }

        public int IdValue { get; set; }

        public string Value { get; set; }

        public string NullableValue { get; set; }
    }
}
