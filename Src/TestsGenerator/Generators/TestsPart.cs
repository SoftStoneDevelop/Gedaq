using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestsGenerator.Enums;
using TestsGenerator.Generators.PostgreSQL;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal class TestsPart
    {
        public const string TestDataArrayName = "_testData";

        private readonly StringBuilderArray.StringBuilderArray _stringBuilder = new();

        public async Task Generate(Model.ModelType model, Database database, string destinationFolder)
        {
            _stringBuilder.Clear();
            var storage = InitStorage(model, 35);

            var interfaceTypeName = InterfaceName(model);
            Start(model, database);

            StartRegion("TestData");
            WriteTestDataArray(model, storage);
            EndRegion();

            StartRegion("InsertModelInner");
            InsertModelInnerTest.Generate(
                0, 
                _stringBuilder, 
                model, 
                storage, 
                database, 
                interfaceTypeName);
            EndRegion();

            StartRegion("InsertModel");
            InsertModelTest.Generate(
                1, 
                _stringBuilder, 
                model, 
                storage, 
                database, 
                interfaceTypeName);
            EndRegion();

            StartRegion("Select Models");
            SelectModelTest.Generate(
                2, 
                _stringBuilder, 
                model, 
                storage, 
                database, 
                interfaceTypeName);
            EndRegion();

            SpecialDatabaseTests(
                model, 
                database, 
                storage,
                interfaceTypeName);

            End();

            await File.WriteAllTextAsync($"{destinationFolder}/TestsParts/{model.ClassName(false)}Tests.cs", _stringBuilder.ToString());
        }

        private void SpecialDatabaseTests(
            Model.ModelType model, 
            Database database, 
            ModelValueStorage storage,
            string interfaceTypeName)
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    StartRegion("BinaryImportModelInner");
                    var order = 0;
                    BinaryImportModelInnerTest.Generate(
                        ref order, 
                        _stringBuilder, 
                        model, 
                        storage,
                        interfaceTypeName);
                    EndRegion();

                    StartRegion("BinaryImportModel");
                    order += 1;
                    BinaryImportModelTest.Generate(
                        ref order, 
                        _stringBuilder, 
                        model, 
                        storage,
                        interfaceTypeName);
                    EndRegion();

                    StartRegion("BinaryExportModel");
                    BinaryExportModelTest.Generate(
                        order + 2, 
                        _stringBuilder, 
                        model, 
                        storage,
                        interfaceTypeName);
                    EndRegion();

                    StartRegion("BinaryExportModelInner");
                    BinaryExportModelInnerTest.Generate(
                        order + 2, 
                        _stringBuilder, 
                        model,
                        interfaceTypeName);
                    EndRegion();
                    break;
                }
            }
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

        /// <summary>
        /// Create values for test cases
        /// </summary>
        private static ModelValueStorage InitStorage(Model.ModelType model, int valuesCount)
        {
            var storage = model.NewStorage();
            storage.StartInit();
            for (int i = 0; i < valuesCount; i++)
            {
                storage.AddNewValue();
            }
            storage.EndInit();

            return storage;
        }

        private void WriteTestDataArray(Model.ModelType model, ModelValueStorage dataStorage)
        {
            _stringBuilder.Append($@"
        private readonly {model.ClassName(false)}[] {TestDataArrayName} = new {model.ClassName(false)}[]
        {{");

            var orderedValues = dataStorage.Values.OrderBy(or => or.IdValue).ToArray();
            for (int i = 0; i < orderedValues.Length; i++)
            {
                ModelValue value = orderedValues[i];
                _stringBuilder.Append($@"
            {ModelGenerator.CreateNewModelInstance(model, value)},");
            }

            _stringBuilder.Append($@"
        }};
");
        }

        public static string ClassName(Model.ModelType model)
        {
            return 
                $@"{model.TypeInfo.ItemTypeName}{model.TypeInfo.EnumerableType}{model.TypeInfo.DbSqlTypeWithoutSpace()}";
        }

        private static string InterfaceName(Model.ModelType model)
        {
            return
                $@"I{ClassName(model)}";
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
    internal partial interface {InterfaceName(model)}
    {{
    }}
    
    internal partial class {ClassName(model)} : {InterfaceName(model)}
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
