

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IUInt64SingleTypeUInt64
    {
    }
    
    internal partial class UInt64SingleTypeUInt64 : IUInt64SingleTypeUInt64
    {


#region TestData

        private readonly UInt64UInt64E0M[] _testData = new UInt64UInt64E0M[]
        {
            new UInt64UInt64E0M
{
    Id = 8,
    Value = 3668535508754415991L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 5,
    Value = 3909333779746794601L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 12,
    Value = 3498365482120854091L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 6,
    Value = 7559137673101765853L,
    NullableValue = 6443713010517374442L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 15,
    Value = 4463553000060224506L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 7,
    Value = 7420699834992796265L,
    NullableValue = null,
},
    NullableValue = 2122799687067824829L,
},
            new UInt64UInt64E0M
{
    Id = 24,
    Value = 608127325026040273L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 10,
    Value = 6594837475875901207L,
    NullableValue = null,
},
    NullableValue = 2737684437227190620L,
},
            new UInt64UInt64E0M
{
    Id = 33,
    Value = 1497493127826685625L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 15,
    Value = 1850819258066697426L,
    NullableValue = 6195541730004939144L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 39,
    Value = 8343660293306827289L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 18,
    Value = 6627386479932604005L,
    NullableValue = 8521423887900094322L,
},
    NullableValue = 8249197163922022415L,
},
            new UInt64UInt64E0M
{
    Id = 48,
    Value = 6117676008613461010L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 26,
    Value = 4698446493097830795L,
    NullableValue = 8474615331672945652L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 56,
    Value = 3444491396664302389L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 33,
    Value = 1813003070274986635L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 59,
    Value = 1356406950239403837L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 41,
    Value = 4998553666740944662L,
    NullableValue = 8479453540319343672L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 65,
    Value = 7074294954076564945L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 45,
    Value = 6858447574792197821L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 73,
    Value = 4436573269384115501L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 49,
    Value = 6501245380679463983L,
    NullableValue = 7398530015339291265L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 74,
    Value = 7609759172815251107L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 50,
    Value = 367131109049875795L,
    NullableValue = null,
},
    NullableValue = 2382876708081007067L,
},
            new UInt64UInt64E0M
{
    Id = 82,
    Value = 7210668299536122639L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 56,
    Value = 8853679752767231728L,
    NullableValue = 9169064890406456000L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 89,
    Value = 8279046532928252468L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 57,
    Value = 4696333054954965287L,
    NullableValue = 2244374122178270062L,
},
    NullableValue = 6119226549509728789L,
},
            new UInt64UInt64E0M
{
    Id = 97,
    Value = 7768931058882389974L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 61,
    Value = 4362056801262437492L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 103,
    Value = 809081810720252304L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 66,
    Value = 4846095985436073106L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 112,
    Value = 6005118716283226061L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 75,
    Value = 3018153715908450666L,
    NullableValue = 6303744321815686210L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 113,
    Value = 8139174730596486405L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 77,
    Value = 4892508957535088386L,
    NullableValue = 137203029810485912L,
},
    NullableValue = 2847038077403590181L,
},
            new UInt64UInt64E0M
{
    Id = 120,
    Value = 3840240393877693964L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 82,
    Value = 3610912400697954048L,
    NullableValue = 2209054953382275230L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 121,
    Value = 290169556734810097L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 87,
    Value = 1926796010622059435L,
    NullableValue = 4187024368516543313L,
},
    NullableValue = 1786906438861997087L,
},
            new UInt64UInt64E0M
{
    Id = 123,
    Value = 2535867832391256132L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 88,
    Value = 5712023385636431266L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 129,
    Value = 2249946726384372012L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 94,
    Value = 964166448332008179L,
    NullableValue = null,
},
    NullableValue = 8721300987678591191L,
},
            new UInt64UInt64E0M
{
    Id = 138,
    Value = 5446410979149090901L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 99,
    Value = 5825468734948026943L,
    NullableValue = 3099235925730767289L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 142,
    Value = 2815679461330997811L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 102,
    Value = 4568725193300737925L,
    NullableValue = 7641393555691263971L,
},
    NullableValue = 8640879057440618727L,
},
            new UInt64UInt64E0M
{
    Id = 144,
    Value = 5923025361999568057L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 105,
    Value = 7108294776769182401L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 149,
    Value = 4433232982055078867L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 109,
    Value = 8023599903501815565L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 150,
    Value = 468939167239811712L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 117,
    Value = 2988963835189010426L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 156,
    Value = 155656255724303993L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 125,
    Value = 4860219847855263904L,
    NullableValue = 5429513747245481386L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 161,
    Value = 2635829662916335471L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 134,
    Value = 1304458991070490391L,
    NullableValue = null,
},
    NullableValue = 2282382213501453826L,
},
            new UInt64UInt64E0M
{
    Id = 166,
    Value = 3802804986967105761L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 136,
    Value = 8147656573324841942L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 168,
    Value = 1017017307338341827L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 139,
    Value = 6495110579547238315L,
    NullableValue = 2550680937672057772L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 174,
    Value = 241757005495295347L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 143,
    Value = 4288301080608730962L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 179,
    Value = 7847805059768374724L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 152,
    Value = 4655885802164112838L,
    NullableValue = 8078863878560231997L,
},
    NullableValue = 8527472916433157558L,
},
            new UInt64UInt64E0M
{
    Id = 181,
    Value = 8984979139171245459L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 153,
    Value = 6693999851959833102L,
    NullableValue = 5879483312356157964L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 188,
    Value = 5108757761188793306L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 157,
    Value = 3977477163086080090L,
    NullableValue = null,
},
    NullableValue = 4566097851087208035L,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64uint64e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt64}, 
    {mi_id:Int32},
    {mi_value:UInt64}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypeUInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IUInt64SingleTypeUInt64)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IUInt64SingleTypeUInt64)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.uint64uint64e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64UInt64E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypeUInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IUInt64SingleTypeUInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64UInt64E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IUInt64SingleTypeUInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64UInt64E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

