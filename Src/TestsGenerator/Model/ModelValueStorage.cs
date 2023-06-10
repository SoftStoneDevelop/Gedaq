using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestsGenerator.Constants;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal class ModelValueStorage
    {
        public ModelValueStorage(ValueHelper valueStorage)
        {
            Id = new Int32ValueHelper();
            Value = valueStorage.NewInstance();
            NullableValue = valueStorage.NewInstance();
        }

        private Int32ValueHelper Id { get; }

        private ValueHelper Value { get; }

        private ValueHelper NullableValue { get; }

        private List<ModelValue> _values = new();
        public ReadOnlyCollection<ModelValue> Values => _values.AsReadOnly();

        private bool NextNull()
        {
            return Random.Shared.Next(2) == 1;
        }

        private HashSet<int> _modelIds = new();
        private HashSet<int> _innerModelIds = new();

        private string GetNextModelId(out int idValue)
        {
            while (true)
            {
                var idStr = Id.NewValue(out idValue);
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
                var idStr = Id.NewValue(out idValue);
                if (_innerModelIds.Add(idValue))
                {
                    return idStr;
                }
            }
        }

        public ModelValue AddNewValue()
        {
            InnerModelValue newInnerValue;
            if(NextNull())
            {
                newInnerValue = null;
            }
            else
            {
                newInnerValue = new InnerModelValue
                {
                    Id = GetNextInnerModelId(out var idInnerValue),
                    IdValue = idInnerValue,
                    Value = Value.NewValue(),
                    NullableValue = NextNull() ? ValueConstants.NullValue : NullableValue.NewValue()
                };
            }

            var newValue = new ModelValue
            {
                Id = GetNextModelId(out var idValue),
                IdValue = idValue,
                Value = Value.NewValue(),
                NullableValue = NextNull() ? ValueConstants.NullValue : NullableValue.NewValue(),

                InnerModel = newInnerValue
            };

            _values.Add(newValue);
            return newValue;
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
