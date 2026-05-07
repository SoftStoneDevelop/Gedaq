

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface INpgsqlCircleSingleTypecircle
    {
    }
    
    internal partial class NpgsqlCircleSingleTypecircle : INpgsqlCircleSingleTypecircle
    {


#region TestData

        private readonly NpgsqlCirclecircle0M[] _testData = new NpgsqlCirclecircle0M[]
        {
            new NpgsqlCirclecircle0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6568748911783344d, y: 0.2581601726865964d), radius: 0.4097048072746402d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6592289328283848d, y: 0.8749138557512827d), radius: 0.29470403004427403d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26624313865877725d, y: 0.8557615089528148d), radius: 0.46034557471827d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31171649237625254d, y: 0.897520051872195d), radius: 0.5854976246806248d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6784397894477431d, y: 0.8896366788539704d), radius: 0.9843061346297345d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9519442474571548d, y: 0.05573134158848836d), radius: 0.5484387142204635d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35246201109841135d, y: 0.932267231025526d), radius: 0.10673936567168285d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07885091612374628d, y: 0.9598149044376943d), radius: 0.25235547658687374d),
},
            new NpgsqlCirclecircle0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7117259606968143d, y: 0.7993908235974354d), radius: 0.12147698380404637d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9941818696859203d, y: 0.7564754661927889d), radius: 0.9571243104764512d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1629190567504163d, y: 0.7951184612671804d), radius: 0.08484466956789771d),
},
            new NpgsqlCirclecircle0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47547836962225354d, y: 0.03412657362038096d), radius: 0.16497892923979152d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9938256227448331d, y: 0.1806491453217809d), radius: 0.27309291201082253d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9986747117910568d, y: 0.19757459379551245d), radius: 0.615491343373238d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5830241480444833d, y: 0.4286149228182903d), radius: 0.7826882802921142d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.929208349313246d, y: 0.07096722979763104d), radius: 0.12913487593932038d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22617640153598917d, y: 0.36621190321814834d), radius: 0.28670347239059757d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9688023534996248d, y: 0.5590529813102961d), radius: 0.5033262467187015d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23196198000641854d, y: 0.8859196230709724d), radius: 0.06413351399555411d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6921220227038819d, y: 0.2417279681438761d), radius: 0.08409216364059524d),
},
            new NpgsqlCirclecircle0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7208851984408619d, y: 0.5204670281162697d), radius: 0.06709432464176579d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4085866695258943d, y: 0.367935251615672d), radius: 0.5036107023811619d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42559911700030095d, y: 0.7490392227652791d), radius: 0.20191117898330035d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8021933105644891d, y: 0.3159610928487889d), radius: 0.8540653839931315d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5379228569380231d, y: 0.6559628246190049d), radius: 0.34184751777447675d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7941839548379659d, y: 0.6508992155701775d), radius: 0.7053820242209529d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08682101868162417d, y: 0.6547608532390409d), radius: 0.01852195701566073d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9943410527966747d, y: 0.44597369817663124d), radius: 0.41004781818454783d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4608638387723083d, y: 0.7456514746015817d), radius: 0.6513342660144738d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3318816732044314d, y: 0.29295211614845096d), radius: 0.4989360560237708d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5450287843498371d, y: 0.9606994513137243d), radius: 0.3698017108435778d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1981774888178799d, y: 0.6742661113602917d), radius: 0.600559656727786d),
},
            new NpgsqlCirclecircle0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07530545178030801d, y: 0.011629302945006748d), radius: 0.7511059016480507d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.893386513023824d, y: 0.5825552351486497d), radius: 0.7871573365473736d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8600395849904923d, y: 0.7091647071899516d), radius: 0.0789428852356141d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.520930166080232d, y: 0.5711391043533899d), radius: 0.6375691132890615d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962494248913751d, y: 0.011915936838300945d), radius: 0.8897848015048089d),
},
            new NpgsqlCirclecircle0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46445455535412483d, y: 0.4381046517438617d), radius: 0.9047923148017476d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4272158787369801d, y: 0.2416721825086492d), radius: 0.03527352025258401d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5944923403649552d, y: 0.5111233655548343d), radius: 0.5535639449918643d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1434204680095773d, y: 0.33292626654986845d), radius: 0.7534094887727739d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5477889906013002d, y: 0.26146063075615267d), radius: 0.3912400845099401d),
},
            new NpgsqlCirclecircle0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7561277853261598d, y: 0.09568624531275516d), radius: 0.5891175136150938d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011636474281817577d, y: 0.3231977987991119d), radius: 0.15161517991313433d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7610111447860715d, y: 0.28832905449024193d), radius: 0.3066455171372271d),
},
            new NpgsqlCirclecircle0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9352926930266032d, y: 0.15399940082351082d), radius: 0.37619655651254214d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45268353906842895d, y: 0.07959091053728196d), radius: 0.4855147138246556d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1614794863692105d, y: 0.10368838332650487d), radius: 0.7565767045370546d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33908836299840384d, y: 0.6298563078884447d), radius: 0.15639517225469046d),
},
            new NpgsqlCirclecircle0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.610952562758134d, y: 0.5954362814353085d), radius: 0.17237913514205616d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9811657117810809d, y: 0.3088266407602591d), radius: 0.7444409294145037d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020006874695152388d, y: 0.691362568078212d), radius: 0.7447059969609254d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22401376802194584d, y: 0.895404031522818d), radius: 0.46103474631132835d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33704674486391273d, y: 0.874081348011089d), radius: 0.9612633607340167d),
},
            new NpgsqlCirclecircle0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3164624896296955d, y: 0.42195277047719815d), radius: 0.9500073271879069d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10233127634873773d, y: 0.4275392318841198d), radius: 0.2543288278906083d),
},
            new NpgsqlCirclecircle0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17823912790390928d, y: 0.6548996164124641d), radius: 0.3434450172937855d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9646429574550163d, y: 0.49533628267420127d), radius: 0.8404077471356542d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3961078570182459d, y: 0.8217012326306252d), radius: 0.06440406276643906d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1288541397091465d, y: 0.559775175022024d), radius: 0.08341019706816344d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.525762002045947d, y: 0.7915929433136145d), radius: 0.9501187220758986d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9330944084712266d, y: 0.07209995156169346d), radius: 0.6366622850057453d),
},
            new NpgsqlCirclecircle0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9482290401369255d, y: 0.7210275801322891d), radius: 0.5076845500026673d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4380757043380127d, y: 0.925200327158899d), radius: 0.3419811689008606d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.757634642301661d, y: 0.804093042487217d), radius: 0.25846592121597534d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6385058197097165d, y: 0.030153022846577393d), radius: 0.9034304922167008d),
},
            new NpgsqlCirclecircle0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46971853565368105d, y: 0.06074919022106229d), radius: 0.32221630913341204d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7079897657994325d, y: 0.41356473546139405d), radius: 0.13740870828635232d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.345751557333403d, y: 0.8454256359446131d), radius: 0.6868612029433347d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6854618674007541d, y: 0.14445427727293747d), radius: 0.03920772795100369d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3924594583394704d, y: 0.2843562485101392d), radius: 0.11308138846227589d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07885091612374628d, y: 0.9598149044376943d), radius: 0.25235547658687374d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1629190567504163d, y: 0.7951184612671804d), radius: 0.08484466956789771d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6921220227038819d, y: 0.2417279681438761d), radius: 0.08409216364059524d)));
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecircle0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlCircle), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlcirclecircle0mi_id", 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 14, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 39, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 39, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 163, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 17, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 14, query1, 158, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 5, query1, 168, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 163, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 126, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[27], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[28], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[29], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[30], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[31], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[32], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[33], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[15], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[16], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[17], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[18], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[19], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[20], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[21], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[22], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[23], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[24], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[25], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[26], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[27], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[28], false);
                NpgsqlCirclecircle0M.AssertModel(models[15],_testData[29], false);
                NpgsqlCirclecircle0M.AssertModel(models[16],_testData[30], false);
                NpgsqlCirclecircle0M.AssertModel(models[17],_testData[31], false);
                NpgsqlCirclecircle0M.AssertModel(models[18],_testData[32], false);
                NpgsqlCirclecircle0M.AssertModel(models[19],_testData[33], false);
                NpgsqlCirclecircle0M.AssertModel(models[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6568748911783344d, y: 0.2581601726865964d), radius: 0.4097048072746402d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6592289328283848d, y: 0.8749138557512827d), radius: 0.29470403004427403d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26624313865877725d, y: 0.8557615089528148d), radius: 0.46034557471827d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31171649237625254d, y: 0.897520051872195d), radius: 0.5854976246806248d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6784397894477431d, y: 0.8896366788539704d), radius: 0.9843061346297345d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9519442474571548d, y: 0.05573134158848836d), radius: 0.5484387142204635d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35246201109841135d, y: 0.932267231025526d), radius: 0.10673936567168285d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07885091612374628d, y: 0.9598149044376943d), radius: 0.25235547658687374d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7117259606968143d, y: 0.7993908235974354d), radius: 0.12147698380404637d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9941818696859203d, y: 0.7564754661927889d), radius: 0.9571243104764512d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1629190567504163d, y: 0.7951184612671804d), radius: 0.08484466956789771d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47547836962225354d, y: 0.03412657362038096d), radius: 0.16497892923979152d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9938256227448331d, y: 0.1806491453217809d), radius: 0.27309291201082253d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9986747117910568d, y: 0.19757459379551245d), radius: 0.615491343373238d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5830241480444833d, y: 0.4286149228182903d), radius: 0.7826882802921142d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.929208349313246d, y: 0.07096722979763104d), radius: 0.12913487593932038d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22617640153598917d, y: 0.36621190321814834d), radius: 0.28670347239059757d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9688023534996248d, y: 0.5590529813102961d), radius: 0.5033262467187015d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23196198000641854d, y: 0.8859196230709724d), radius: 0.06413351399555411d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6921220227038819d, y: 0.2417279681438761d), radius: 0.08409216364059524d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7208851984408619d, y: 0.5204670281162697d), radius: 0.06709432464176579d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4085866695258943d, y: 0.367935251615672d), radius: 0.5036107023811619d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42559911700030095d, y: 0.7490392227652791d), radius: 0.20191117898330035d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8021933105644891d, y: 0.3159610928487889d), radius: 0.8540653839931315d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5379228569380231d, y: 0.6559628246190049d), radius: 0.34184751777447675d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7941839548379659d, y: 0.6508992155701775d), radius: 0.7053820242209529d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08682101868162417d, y: 0.6547608532390409d), radius: 0.01852195701566073d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9943410527966747d, y: 0.44597369817663124d), radius: 0.41004781818454783d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4608638387723083d, y: 0.7456514746015817d), radius: 0.6513342660144738d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3318816732044314d, y: 0.29295211614845096d), radius: 0.4989360560237708d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5450287843498371d, y: 0.9606994513137243d), radius: 0.3698017108435778d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1981774888178799d, y: 0.6742661113602917d), radius: 0.600559656727786d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07530545178030801d, y: 0.011629302945006748d), radius: 0.7511059016480507d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.893386513023824d, y: 0.5825552351486497d), radius: 0.7871573365473736d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8600395849904923d, y: 0.7091647071899516d), radius: 0.0789428852356141d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.520930166080232d, y: 0.5711391043533899d), radius: 0.6375691132890615d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962494248913751d, y: 0.011915936838300945d), radius: 0.8897848015048089d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46445455535412483d, y: 0.4381046517438617d), radius: 0.9047923148017476d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4272158787369801d, y: 0.2416721825086492d), radius: 0.03527352025258401d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5944923403649552d, y: 0.5111233655548343d), radius: 0.5535639449918643d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1434204680095773d, y: 0.33292626654986845d), radius: 0.7534094887727739d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5477889906013002d, y: 0.26146063075615267d), radius: 0.3912400845099401d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7561277853261598d, y: 0.09568624531275516d), radius: 0.5891175136150938d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011636474281817577d, y: 0.3231977987991119d), radius: 0.15161517991313433d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7610111447860715d, y: 0.28832905449024193d), radius: 0.3066455171372271d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9352926930266032d, y: 0.15399940082351082d), radius: 0.37619655651254214d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45268353906842895d, y: 0.07959091053728196d), radius: 0.4855147138246556d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1614794863692105d, y: 0.10368838332650487d), radius: 0.7565767045370546d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33908836299840384d, y: 0.6298563078884447d), radius: 0.15639517225469046d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.610952562758134d, y: 0.5954362814353085d), radius: 0.17237913514205616d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9811657117810809d, y: 0.3088266407602591d), radius: 0.7444409294145037d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020006874695152388d, y: 0.691362568078212d), radius: 0.7447059969609254d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22401376802194584d, y: 0.895404031522818d), radius: 0.46103474631132835d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33704674486391273d, y: 0.874081348011089d), radius: 0.9612633607340167d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3164624896296955d, y: 0.42195277047719815d), radius: 0.9500073271879069d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10233127634873773d, y: 0.4275392318841198d), radius: 0.2543288278906083d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17823912790390928d, y: 0.6548996164124641d), radius: 0.3434450172937855d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9646429574550163d, y: 0.49533628267420127d), radius: 0.8404077471356542d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3961078570182459d, y: 0.8217012326306252d), radius: 0.06440406276643906d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1288541397091465d, y: 0.559775175022024d), radius: 0.08341019706816344d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.525762002045947d, y: 0.7915929433136145d), radius: 0.9501187220758986d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9330944084712266d, y: 0.07209995156169346d), radius: 0.6366622850057453d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9482290401369255d, y: 0.7210275801322891d), radius: 0.5076845500026673d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4380757043380127d, y: 0.925200327158899d), radius: 0.3419811689008606d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.757634642301661d, y: 0.804093042487217d), radius: 0.25846592121597534d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6385058197097165d, y: 0.030153022846577393d), radius: 0.9034304922167008d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46971853565368105d, y: 0.06074919022106229d), radius: 0.32221630913341204d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7079897657994325d, y: 0.41356473546139405d), radius: 0.13740870828635232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.345751557333403d, y: 0.8454256359446131d), radius: 0.6868612029433347d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6854618674007541d, y: 0.14445427727293747d), radius: 0.03920772795100369d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3924594583394704d, y: 0.2843562485101392d), radius: 0.11308138846227589d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6568748911783344d, y: 0.2581601726865964d), radius: 0.4097048072746402d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6592289328283848d, y: 0.8749138557512827d), radius: 0.29470403004427403d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26624313865877725d, y: 0.8557615089528148d), radius: 0.46034557471827d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31171649237625254d, y: 0.897520051872195d), radius: 0.5854976246806248d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6784397894477431d, y: 0.8896366788539704d), radius: 0.9843061346297345d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9519442474571548d, y: 0.05573134158848836d), radius: 0.5484387142204635d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35246201109841135d, y: 0.932267231025526d), radius: 0.10673936567168285d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07885091612374628d, y: 0.9598149044376943d), radius: 0.25235547658687374d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7117259606968143d, y: 0.7993908235974354d), radius: 0.12147698380404637d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9941818696859203d, y: 0.7564754661927889d), radius: 0.9571243104764512d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1629190567504163d, y: 0.7951184612671804d), radius: 0.08484466956789771d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47547836962225354d, y: 0.03412657362038096d), radius: 0.16497892923979152d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9938256227448331d, y: 0.1806491453217809d), radius: 0.27309291201082253d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9986747117910568d, y: 0.19757459379551245d), radius: 0.615491343373238d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5830241480444833d, y: 0.4286149228182903d), radius: 0.7826882802921142d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.929208349313246d, y: 0.07096722979763104d), radius: 0.12913487593932038d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22617640153598917d, y: 0.36621190321814834d), radius: 0.28670347239059757d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9688023534996248d, y: 0.5590529813102961d), radius: 0.5033262467187015d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23196198000641854d, y: 0.8859196230709724d), radius: 0.06413351399555411d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6921220227038819d, y: 0.2417279681438761d), radius: 0.08409216364059524d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7208851984408619d, y: 0.5204670281162697d), radius: 0.06709432464176579d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4085866695258943d, y: 0.367935251615672d), radius: 0.5036107023811619d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42559911700030095d, y: 0.7490392227652791d), radius: 0.20191117898330035d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8021933105644891d, y: 0.3159610928487889d), radius: 0.8540653839931315d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5379228569380231d, y: 0.6559628246190049d), radius: 0.34184751777447675d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7941839548379659d, y: 0.6508992155701775d), radius: 0.7053820242209529d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08682101868162417d, y: 0.6547608532390409d), radius: 0.01852195701566073d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9943410527966747d, y: 0.44597369817663124d), radius: 0.41004781818454783d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4608638387723083d, y: 0.7456514746015817d), radius: 0.6513342660144738d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3318816732044314d, y: 0.29295211614845096d), radius: 0.4989360560237708d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5450287843498371d, y: 0.9606994513137243d), radius: 0.3698017108435778d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1981774888178799d, y: 0.6742661113602917d), radius: 0.600559656727786d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07530545178030801d, y: 0.011629302945006748d), radius: 0.7511059016480507d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.893386513023824d, y: 0.5825552351486497d), radius: 0.7871573365473736d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8600395849904923d, y: 0.7091647071899516d), radius: 0.0789428852356141d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.520930166080232d, y: 0.5711391043533899d), radius: 0.6375691132890615d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962494248913751d, y: 0.011915936838300945d), radius: 0.8897848015048089d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46445455535412483d, y: 0.4381046517438617d), radius: 0.9047923148017476d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4272158787369801d, y: 0.2416721825086492d), radius: 0.03527352025258401d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5944923403649552d, y: 0.5111233655548343d), radius: 0.5535639449918643d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1434204680095773d, y: 0.33292626654986845d), radius: 0.7534094887727739d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5477889906013002d, y: 0.26146063075615267d), radius: 0.3912400845099401d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7561277853261598d, y: 0.09568624531275516d), radius: 0.5891175136150938d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011636474281817577d, y: 0.3231977987991119d), radius: 0.15161517991313433d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7610111447860715d, y: 0.28832905449024193d), radius: 0.3066455171372271d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9352926930266032d, y: 0.15399940082351082d), radius: 0.37619655651254214d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45268353906842895d, y: 0.07959091053728196d), radius: 0.4855147138246556d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1614794863692105d, y: 0.10368838332650487d), radius: 0.7565767045370546d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33908836299840384d, y: 0.6298563078884447d), radius: 0.15639517225469046d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.610952562758134d, y: 0.5954362814353085d), radius: 0.17237913514205616d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9811657117810809d, y: 0.3088266407602591d), radius: 0.7444409294145037d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020006874695152388d, y: 0.691362568078212d), radius: 0.7447059969609254d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22401376802194584d, y: 0.895404031522818d), radius: 0.46103474631132835d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33704674486391273d, y: 0.874081348011089d), radius: 0.9612633607340167d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3164624896296955d, y: 0.42195277047719815d), radius: 0.9500073271879069d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10233127634873773d, y: 0.4275392318841198d), radius: 0.2543288278906083d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17823912790390928d, y: 0.6548996164124641d), radius: 0.3434450172937855d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9646429574550163d, y: 0.49533628267420127d), radius: 0.8404077471356542d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3961078570182459d, y: 0.8217012326306252d), radius: 0.06440406276643906d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1288541397091465d, y: 0.559775175022024d), radius: 0.08341019706816344d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.525762002045947d, y: 0.7915929433136145d), radius: 0.9501187220758986d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9330944084712266d, y: 0.07209995156169346d), radius: 0.6366622850057453d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9482290401369255d, y: 0.7210275801322891d), radius: 0.5076845500026673d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4380757043380127d, y: 0.925200327158899d), radius: 0.3419811689008606d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.757634642301661d, y: 0.804093042487217d), radius: 0.25846592121597534d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6385058197097165d, y: 0.030153022846577393d), radius: 0.9034304922167008d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46971853565368105d, y: 0.06074919022106229d), radius: 0.32221630913341204d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7079897657994325d, y: 0.41356473546139405d), radius: 0.13740870828635232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.345751557333403d, y: 0.8454256359446131d), radius: 0.6868612029433347d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6854618674007541d, y: 0.14445427727293747d), radius: 0.03920772795100369d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3924594583394704d, y: 0.2843562485101392d), radius: 0.11308138846227589d))));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_npgsqlcirclecircle0m m
LEFT JOIN public.binary_npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircle0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircle0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircle0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA), typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA), typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI), typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlCirclecircle0MI>();
                var models2 = new List<NpgsqlCirclecircle0MI>();
                await ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlCirclecircle0MI>();
                var models2 = new List<NpgsqlCirclecircle0MI>();
                ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlCircleSingleTypecircle)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlCircleSingleTypecircle)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA), typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlCircleSingleTypecircle)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

