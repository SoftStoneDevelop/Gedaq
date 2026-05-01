

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
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12557671514914326d, y: 0.758719741882041d), radius: 0.4259616572054573d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31720765184137467d, y: 0.1049819142008569d), radius: 0.3946707796183263d),
},
            new NpgsqlCirclecircle0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8562034947637813d, y: 0.8968928181940352d), radius: 0.08937991366190223d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3189046610448215d, y: 0.7627579904507666d), radius: 0.2987052784483869d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33517201800373697d, y: 0.9028806493711912d), radius: 0.0712424296266303d),
},
            new NpgsqlCirclecircle0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33766252010168574d, y: 0.05790090718286223d), radius: 0.41011676661977936d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7729287963859944d, y: 0.7970210270517523d), radius: 0.7664620439267115d),
},
            new NpgsqlCirclecircle0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1600941816387491d, y: 0.7070050423835859d), radius: 0.11627116172165086d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024239398305281434d, y: 0.5697894381955609d), radius: 0.07052939629933541d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5838249615259805d, y: 0.16091652981698013d), radius: 0.7794076272346909d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06363633948299985d, y: 0.5993849643517108d), radius: 0.05820306334782044d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3901642238408828d, y: 0.8679312772750882d), radius: 0.9396309016936029d),
},
            new NpgsqlCirclecircle0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5174404063956417d, y: 0.7795389330522764d), radius: 0.6619280695366232d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.384287367946879d, y: 0.27320846082965833d), radius: 0.4857735309060919d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.783044446151521d, y: 0.7828601006253532d), radius: 0.0768283222683277d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9130344031439236d, y: 0.14720162967511063d), radius: 0.33836236308814527d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6332538424306278d, y: 0.8787165840563885d), radius: 0.282372014721447d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5009423423084615d, y: 0.18549807577738053d), radius: 0.6191745307979253d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8216806707618419d, y: 0.20909975302946915d), radius: 0.7364871742678877d),
},
            new NpgsqlCirclecircle0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17141661041635747d, y: 0.3359152184022385d), radius: 0.8128798619381522d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1526274976129145d, y: 0.3311864821169881d), radius: 0.6597402102389421d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38817069088161216d, y: 0.7650727943543671d), radius: 0.6321090628272907d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23086166740024827d, y: 0.8538573315834441d), radius: 0.9352030735044868d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.918689675510101d, y: 0.8517024057275304d), radius: 0.06669161739632867d),
},
            new NpgsqlCirclecircle0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06534694824199117d, y: 0.3088842018254675d), radius: 0.48279576559381154d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3299693186342795d, y: 0.9055140432729375d), radius: 0.34696177235980397d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09996289023665728d, y: 0.10748022823068681d), radius: 0.22743006557413536d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667025362483886d, y: 0.8939467463087569d), radius: 0.8397161107645033d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 8.354791371290027E-06d, y: 0.24964257116986543d), radius: 0.17750989443187182d),
},
            new NpgsqlCirclecircle0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33535974397474233d, y: 0.2759045279483938d), radius: 0.15067021805689906d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7403973756200588d, y: 0.8188817099582385d), radius: 0.9599230988644428d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5120657242493819d, y: 0.22369820525445283d), radius: 0.8905941791112343d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5484590909186193d, y: 0.4248821807504888d), radius: 0.5634177171445075d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9101497738342456d, y: 0.8493555122563562d), radius: 0.22061623455243018d),
},
            new NpgsqlCirclecircle0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6499638853445505d, y: 0.15617705514256552d), radius: 0.0758192318255444d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4494683288200878d, y: 0.6749514273118651d), radius: 0.5737761539121066d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20239031336746127d, y: 0.3242487710206159d), radius: 0.3311453465367171d),
},
            new NpgsqlCirclecircle0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8103445117608238d, y: 0.827572587394061d), radius: 0.16521273214479792d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8483199064164562d, y: 0.8383969222223036d), radius: 0.30017883128522416d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9448522951265966d, y: 0.4372714830561444d), radius: 0.7939659112454062d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9354099861845594d, y: 0.23111302401134703d), radius: 0.733601525579131d),
},
            new NpgsqlCirclecircle0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9795215663316552d, y: 0.16147178388744798d), radius: 0.9552194785748858d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4180704661479965d, y: 0.09838827946643491d), radius: 0.13842385926966871d),
},
            new NpgsqlCirclecircle0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09424033189317249d, y: 0.7850537396176306d), radius: 0.18814739054101304d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44588630574403043d, y: 0.7509480460526174d), radius: 0.9657124948520481d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09387636386823484d, y: 0.21370481952401021d), radius: 0.902228602632008d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6202842984996855d, y: 0.8146639264861676d), radius: 0.6760692702325914d),
},
            new NpgsqlCirclecircle0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9209124944711169d, y: 0.41151761182757063d), radius: 0.4538468101587253d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7878390443984358d, y: 0.48921415360004306d), radius: 0.8079508020563353d),
},
            new NpgsqlCirclecircle0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5932328552295362d, y: 0.7048218651210418d), radius: 0.3527600538870398d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48461376197037453d, y: 0.8632380914686231d), radius: 0.28025773323310266d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12550512881802123d, y: 0.6889724169952266d), radius: 0.688045623681448d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.903103364896015d, y: 0.6076130706703289d), radius: 0.8161819603605922d),
},
            new NpgsqlCirclecircle0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14449087414373518d, y: 0.4204888210716361d), radius: 0.3035596704554355d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.631626762325655d, y: 0.8223971918443146d), radius: 0.5553666660203368d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11498638877279321d, y: 0.9059463259636139d), radius: 0.3813918168422561d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5693979216039016d, y: 0.1909380670980707d), radius: 0.4309174918763048d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7437549800233528d, y: 0.42281775854511017d), radius: 0.595870301487696d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5307285674711502d, y: 0.35895588684385815d), radius: 0.5987079150780468d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08180717189529085d, y: 0.7210159116052347d), radius: 0.01630403892326271d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11731064950327519d, y: 0.28021992842640675d), radius: 0.4366326255658882d),
},
            new NpgsqlCirclecircle0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17783481903806497d, y: 0.25655983920450764d), radius: 0.5009088116685511d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6542415993956433d, y: 0.959928879992208d), radius: 0.274904843774719d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8741067157860277d, y: 0.14390558356382277d), radius: 0.8968170057952514d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26441526446247565d, y: 0.0997759370962259d), radius: 0.5323281729491637d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41323767669073985d, y: 0.1168619334114015d), radius: 0.6832728197615617d),
},
            new NpgsqlCirclecircle0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15677023379699173d, y: 0.11956674721286764d), radius: 0.6078284001086495d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4689321248502828d, y: 0.9720148037242134d), radius: 0.5059952968088377d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9180503854857297d, y: 0.3163954791683662d), radius: 0.34256403445326133d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6209170706607179d, y: 0.22862473104405845d), radius: 0.4360506809851604d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09156514974858854d, y: 0.47239532787834715d), radius: 0.3454767827285098d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 164,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08379132583623805d, y: 0.6807852449621133d), radius: 0.30600592522911907d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4999282502813869d, y: 0.19156045996815263d), radius: 0.9265764625364393d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8545769999703942d, y: 0.2468994588905079d), radius: 0.39503178454548593d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18185661431190958d, y: 0.8427394616345758d), radius: 0.49028040228692915d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 176,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12116596425666692d, y: 0.30881792871214553d), radius: 0.6058849831411929d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5667982189802362d, y: 0.7302736243777045d), radius: 0.23529982986121412d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7140066879269977d, y: 0.43441542025226487d), radius: 0.5895249528745674d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5148393343885639d, y: 0.42640158289669283d), radius: 0.7301383792910824d),
},
            new NpgsqlCirclecircle0M
{
    Id = 182,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49497278330565475d, y: 0.04031725847723355d), radius: 0.5245911017147935d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7833406449651247d, y: 0.008052245487675247d), radius: 0.5052958386939367d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3901642238408828d, y: 0.8679312772750882d), radius: 0.9396309016936029d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8216806707618419d, y: 0.20909975302946915d), radius: 0.7364871742678877d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.918689675510101d, y: 0.8517024057275304d), radius: 0.06669161739632867d)));
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 172, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 135, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 87, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[29],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 164, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 70, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 20, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 115, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 144, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 28, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[34], false);
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
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12557671514914326d, y: 0.758719741882041d), radius: 0.4259616572054573d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31720765184137467d, y: 0.1049819142008569d), radius: 0.3946707796183263d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8562034947637813d, y: 0.8968928181940352d), radius: 0.08937991366190223d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3189046610448215d, y: 0.7627579904507666d), radius: 0.2987052784483869d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33517201800373697d, y: 0.9028806493711912d), radius: 0.0712424296266303d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33766252010168574d, y: 0.05790090718286223d), radius: 0.41011676661977936d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7729287963859944d, y: 0.7970210270517523d), radius: 0.7664620439267115d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1600941816387491d, y: 0.7070050423835859d), radius: 0.11627116172165086d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024239398305281434d, y: 0.5697894381955609d), radius: 0.07052939629933541d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5838249615259805d, y: 0.16091652981698013d), radius: 0.7794076272346909d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06363633948299985d, y: 0.5993849643517108d), radius: 0.05820306334782044d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3901642238408828d, y: 0.8679312772750882d), radius: 0.9396309016936029d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5174404063956417d, y: 0.7795389330522764d), radius: 0.6619280695366232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.384287367946879d, y: 0.27320846082965833d), radius: 0.4857735309060919d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.783044446151521d, y: 0.7828601006253532d), radius: 0.0768283222683277d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9130344031439236d, y: 0.14720162967511063d), radius: 0.33836236308814527d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6332538424306278d, y: 0.8787165840563885d), radius: 0.282372014721447d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5009423423084615d, y: 0.18549807577738053d), radius: 0.6191745307979253d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8216806707618419d, y: 0.20909975302946915d), radius: 0.7364871742678877d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17141661041635747d, y: 0.3359152184022385d), radius: 0.8128798619381522d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1526274976129145d, y: 0.3311864821169881d), radius: 0.6597402102389421d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38817069088161216d, y: 0.7650727943543671d), radius: 0.6321090628272907d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23086166740024827d, y: 0.8538573315834441d), radius: 0.9352030735044868d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.918689675510101d, y: 0.8517024057275304d), radius: 0.06669161739632867d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06534694824199117d, y: 0.3088842018254675d), radius: 0.48279576559381154d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3299693186342795d, y: 0.9055140432729375d), radius: 0.34696177235980397d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09996289023665728d, y: 0.10748022823068681d), radius: 0.22743006557413536d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667025362483886d, y: 0.8939467463087569d), radius: 0.8397161107645033d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 8.354791371290027E-06d, y: 0.24964257116986543d), radius: 0.17750989443187182d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33535974397474233d, y: 0.2759045279483938d), radius: 0.15067021805689906d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7403973756200588d, y: 0.8188817099582385d), radius: 0.9599230988644428d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5120657242493819d, y: 0.22369820525445283d), radius: 0.8905941791112343d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5484590909186193d, y: 0.4248821807504888d), radius: 0.5634177171445075d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9101497738342456d, y: 0.8493555122563562d), radius: 0.22061623455243018d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6499638853445505d, y: 0.15617705514256552d), radius: 0.0758192318255444d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4494683288200878d, y: 0.6749514273118651d), radius: 0.5737761539121066d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20239031336746127d, y: 0.3242487710206159d), radius: 0.3311453465367171d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8103445117608238d, y: 0.827572587394061d), radius: 0.16521273214479792d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8483199064164562d, y: 0.8383969222223036d), radius: 0.30017883128522416d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9448522951265966d, y: 0.4372714830561444d), radius: 0.7939659112454062d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9354099861845594d, y: 0.23111302401134703d), radius: 0.733601525579131d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9795215663316552d, y: 0.16147178388744798d), radius: 0.9552194785748858d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4180704661479965d, y: 0.09838827946643491d), radius: 0.13842385926966871d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09424033189317249d, y: 0.7850537396176306d), radius: 0.18814739054101304d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44588630574403043d, y: 0.7509480460526174d), radius: 0.9657124948520481d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09387636386823484d, y: 0.21370481952401021d), radius: 0.902228602632008d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6202842984996855d, y: 0.8146639264861676d), radius: 0.6760692702325914d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9209124944711169d, y: 0.41151761182757063d), radius: 0.4538468101587253d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7878390443984358d, y: 0.48921415360004306d), radius: 0.8079508020563353d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5932328552295362d, y: 0.7048218651210418d), radius: 0.3527600538870398d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48461376197037453d, y: 0.8632380914686231d), radius: 0.28025773323310266d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12550512881802123d, y: 0.6889724169952266d), radius: 0.688045623681448d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.903103364896015d, y: 0.6076130706703289d), radius: 0.8161819603605922d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14449087414373518d, y: 0.4204888210716361d), radius: 0.3035596704554355d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.631626762325655d, y: 0.8223971918443146d), radius: 0.5553666660203368d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11498638877279321d, y: 0.9059463259636139d), radius: 0.3813918168422561d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5693979216039016d, y: 0.1909380670980707d), radius: 0.4309174918763048d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7437549800233528d, y: 0.42281775854511017d), radius: 0.595870301487696d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5307285674711502d, y: 0.35895588684385815d), radius: 0.5987079150780468d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08180717189529085d, y: 0.7210159116052347d), radius: 0.01630403892326271d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11731064950327519d, y: 0.28021992842640675d), radius: 0.4366326255658882d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17783481903806497d, y: 0.25655983920450764d), radius: 0.5009088116685511d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6542415993956433d, y: 0.959928879992208d), radius: 0.274904843774719d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8741067157860277d, y: 0.14390558356382277d), radius: 0.8968170057952514d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26441526446247565d, y: 0.0997759370962259d), radius: 0.5323281729491637d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41323767669073985d, y: 0.1168619334114015d), radius: 0.6832728197615617d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15677023379699173d, y: 0.11956674721286764d), radius: 0.6078284001086495d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4689321248502828d, y: 0.9720148037242134d), radius: 0.5059952968088377d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9180503854857297d, y: 0.3163954791683662d), radius: 0.34256403445326133d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6209170706607179d, y: 0.22862473104405845d), radius: 0.4360506809851604d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09156514974858854d, y: 0.47239532787834715d), radius: 0.3454767827285098d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08379132583623805d, y: 0.6807852449621133d), radius: 0.30600592522911907d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4999282502813869d, y: 0.19156045996815263d), radius: 0.9265764625364393d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8545769999703942d, y: 0.2468994588905079d), radius: 0.39503178454548593d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18185661431190958d, y: 0.8427394616345758d), radius: 0.49028040228692915d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12116596425666692d, y: 0.30881792871214553d), radius: 0.6058849831411929d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5667982189802362d, y: 0.7302736243777045d), radius: 0.23529982986121412d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7140066879269977d, y: 0.43441542025226487d), radius: 0.5895249528745674d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5148393343885639d, y: 0.42640158289669283d), radius: 0.7301383792910824d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49497278330565475d, y: 0.04031725847723355d), radius: 0.5245911017147935d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7833406449651247d, y: 0.008052245487675247d), radius: 0.5052958386939367d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12557671514914326d, y: 0.758719741882041d), radius: 0.4259616572054573d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31720765184137467d, y: 0.1049819142008569d), radius: 0.3946707796183263d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8562034947637813d, y: 0.8968928181940352d), radius: 0.08937991366190223d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3189046610448215d, y: 0.7627579904507666d), radius: 0.2987052784483869d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33517201800373697d, y: 0.9028806493711912d), radius: 0.0712424296266303d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33766252010168574d, y: 0.05790090718286223d), radius: 0.41011676661977936d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7729287963859944d, y: 0.7970210270517523d), radius: 0.7664620439267115d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1600941816387491d, y: 0.7070050423835859d), radius: 0.11627116172165086d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024239398305281434d, y: 0.5697894381955609d), radius: 0.07052939629933541d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5838249615259805d, y: 0.16091652981698013d), radius: 0.7794076272346909d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06363633948299985d, y: 0.5993849643517108d), radius: 0.05820306334782044d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3901642238408828d, y: 0.8679312772750882d), radius: 0.9396309016936029d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5174404063956417d, y: 0.7795389330522764d), radius: 0.6619280695366232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.384287367946879d, y: 0.27320846082965833d), radius: 0.4857735309060919d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.783044446151521d, y: 0.7828601006253532d), radius: 0.0768283222683277d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9130344031439236d, y: 0.14720162967511063d), radius: 0.33836236308814527d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6332538424306278d, y: 0.8787165840563885d), radius: 0.282372014721447d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5009423423084615d, y: 0.18549807577738053d), radius: 0.6191745307979253d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8216806707618419d, y: 0.20909975302946915d), radius: 0.7364871742678877d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17141661041635747d, y: 0.3359152184022385d), radius: 0.8128798619381522d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1526274976129145d, y: 0.3311864821169881d), radius: 0.6597402102389421d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38817069088161216d, y: 0.7650727943543671d), radius: 0.6321090628272907d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23086166740024827d, y: 0.8538573315834441d), radius: 0.9352030735044868d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.918689675510101d, y: 0.8517024057275304d), radius: 0.06669161739632867d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06534694824199117d, y: 0.3088842018254675d), radius: 0.48279576559381154d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3299693186342795d, y: 0.9055140432729375d), radius: 0.34696177235980397d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09996289023665728d, y: 0.10748022823068681d), radius: 0.22743006557413536d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667025362483886d, y: 0.8939467463087569d), radius: 0.8397161107645033d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 8.354791371290027E-06d, y: 0.24964257116986543d), radius: 0.17750989443187182d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33535974397474233d, y: 0.2759045279483938d), radius: 0.15067021805689906d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7403973756200588d, y: 0.8188817099582385d), radius: 0.9599230988644428d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5120657242493819d, y: 0.22369820525445283d), radius: 0.8905941791112343d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5484590909186193d, y: 0.4248821807504888d), radius: 0.5634177171445075d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9101497738342456d, y: 0.8493555122563562d), radius: 0.22061623455243018d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6499638853445505d, y: 0.15617705514256552d), radius: 0.0758192318255444d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4494683288200878d, y: 0.6749514273118651d), radius: 0.5737761539121066d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20239031336746127d, y: 0.3242487710206159d), radius: 0.3311453465367171d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8103445117608238d, y: 0.827572587394061d), radius: 0.16521273214479792d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8483199064164562d, y: 0.8383969222223036d), radius: 0.30017883128522416d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9448522951265966d, y: 0.4372714830561444d), radius: 0.7939659112454062d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9354099861845594d, y: 0.23111302401134703d), radius: 0.733601525579131d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9795215663316552d, y: 0.16147178388744798d), radius: 0.9552194785748858d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4180704661479965d, y: 0.09838827946643491d), radius: 0.13842385926966871d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09424033189317249d, y: 0.7850537396176306d), radius: 0.18814739054101304d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44588630574403043d, y: 0.7509480460526174d), radius: 0.9657124948520481d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09387636386823484d, y: 0.21370481952401021d), radius: 0.902228602632008d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6202842984996855d, y: 0.8146639264861676d), radius: 0.6760692702325914d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9209124944711169d, y: 0.41151761182757063d), radius: 0.4538468101587253d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7878390443984358d, y: 0.48921415360004306d), radius: 0.8079508020563353d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5932328552295362d, y: 0.7048218651210418d), radius: 0.3527600538870398d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48461376197037453d, y: 0.8632380914686231d), radius: 0.28025773323310266d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12550512881802123d, y: 0.6889724169952266d), radius: 0.688045623681448d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.903103364896015d, y: 0.6076130706703289d), radius: 0.8161819603605922d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14449087414373518d, y: 0.4204888210716361d), radius: 0.3035596704554355d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.631626762325655d, y: 0.8223971918443146d), radius: 0.5553666660203368d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11498638877279321d, y: 0.9059463259636139d), radius: 0.3813918168422561d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5693979216039016d, y: 0.1909380670980707d), radius: 0.4309174918763048d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7437549800233528d, y: 0.42281775854511017d), radius: 0.595870301487696d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5307285674711502d, y: 0.35895588684385815d), radius: 0.5987079150780468d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08180717189529085d, y: 0.7210159116052347d), radius: 0.01630403892326271d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11731064950327519d, y: 0.28021992842640675d), radius: 0.4366326255658882d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17783481903806497d, y: 0.25655983920450764d), radius: 0.5009088116685511d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6542415993956433d, y: 0.959928879992208d), radius: 0.274904843774719d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8741067157860277d, y: 0.14390558356382277d), radius: 0.8968170057952514d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26441526446247565d, y: 0.0997759370962259d), radius: 0.5323281729491637d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41323767669073985d, y: 0.1168619334114015d), radius: 0.6832728197615617d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15677023379699173d, y: 0.11956674721286764d), radius: 0.6078284001086495d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4689321248502828d, y: 0.9720148037242134d), radius: 0.5059952968088377d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9180503854857297d, y: 0.3163954791683662d), radius: 0.34256403445326133d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6209170706607179d, y: 0.22862473104405845d), radius: 0.4360506809851604d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09156514974858854d, y: 0.47239532787834715d), radius: 0.3454767827285098d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08379132583623805d, y: 0.6807852449621133d), radius: 0.30600592522911907d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4999282502813869d, y: 0.19156045996815263d), radius: 0.9265764625364393d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8545769999703942d, y: 0.2468994588905079d), radius: 0.39503178454548593d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18185661431190958d, y: 0.8427394616345758d), radius: 0.49028040228692915d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12116596425666692d, y: 0.30881792871214553d), radius: 0.6058849831411929d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5667982189802362d, y: 0.7302736243777045d), radius: 0.23529982986121412d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7140066879269977d, y: 0.43441542025226487d), radius: 0.5895249528745674d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5148393343885639d, y: 0.42640158289669283d), radius: 0.7301383792910824d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49497278330565475d, y: 0.04031725847723355d), radius: 0.5245911017147935d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7833406449651247d, y: 0.008052245487675247d), radius: 0.5052958386939367d))));

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

