using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using System.Text;

namespace Gedaq.DbConnection.Generators
{
    internal class DbBatchCommand : BatchCommandBase
    {
        private readonly DbBatchCommon _batchCommon = new DbBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;

        protected override void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            var parametr = (DbParametr)baseParametr;
            builder.Append($@"
                var parametr{index} = fakeCommand.CreateParameter();

            ");

            if (parametr.HaveDbType)
            {
                builder.Append($@"
                parametr{index}.DbType = (System.Data.DbType){parametr.DbType};
");
            }

            if (parametr.HaveName)
            {
                builder.Append($@"
                parametr{index}.ParameterName = ""{parametr.Name}"";
");
            }

            if (parametr.HaveSize)
            {
                builder.Append($@"
                parametr{index}.Size = {parametr.Size};
");
            }

            if (parametr.Nullable)
            {
                builder.Append($@"
                parametr
                {index}.IsNullable = true;

                ");
            }

            if (parametr.Direction != System.Data.ParameterDirection.Input)
            {
                builder.Append($@"
                parametr{index}.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
            }

            builder.Append($@"
                command.Parameters.Add(parametr{index});
");
        }

        protected override void CreateFakeCommand(string sourceParametrName, StringBuilder builder)
        {
            builder.Append($@"
            var fakeCommand = {sourceParametrName}.CreateCommand();
");
        }

        protected override void DisposeFakeCommand(MethodType methodType, StringBuilder builder)
        {
            if (methodType == MethodType.Async)
            {
                builder.Append($@"
            await fakeCommand.DisposeAsync(cancellationToken).ConfigureAwait(false);
");
            }
            else
            {
                builder.Append($@"
            fakeCommand.Dispose();
");
            }
        }
    }
}