using Gedaq.TypeWrappers;

namespace Gedaq.Helpers
{
    internal static class ModelHelper
    {
        internal static void FillModel(in ModelWrapper model)
        {
            var attributes = model.Type.GetAttributes();
            var isNotValidClass = true;

            foreach (var attribute in attributes)
            {
                if (!attribute.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "TableAttribute"))
                {
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "NpgsqlTableAttribute"))
                {
                    isNotValidClass = false;
                    PostgresModelHelper.FillModel(in model, in attribute);
                    continue;
                }

                //TODO another dialect
            }

            if (isNotValidClass)
            {
                throw new System.Exception($"Is not valid model class: '{model.Type.Name}'. No sql dialect found.");
            }
        }
    }
}