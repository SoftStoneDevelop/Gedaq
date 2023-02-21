using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.DbConnection.Helpers;
using Gedaq.SqlClient.Helpers;
using System.Text;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientCommandGenerator : CommandGeneratorBase
    {
        private readonly SqlClientQueryCommon _queryCommon = new SqlClientQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;

        protected override void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            SqlClientGeneratorHelper.CreateParametr(baseParametr, index, builder);
        }
    }
}