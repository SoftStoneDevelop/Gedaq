

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
    internal partial interface IDoubleListdouble_precisionListD1
    {
    }
    
    internal partial class DoubleListdouble_precisionListD1 : IDoubleListdouble_precisionListD1
    {


#region TestData

        private readonly Doubledouble_precisionListD1E2M[] _testData = new Doubledouble_precisionListD1E2M[]
        {
            new Doubledouble_precisionListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9168245397540762d,

0.12712629156577993d,

0.6995408080964703d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08275012104922763d,

0.18114521209861334d,

0.061145567627373665d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9313217408114717d,

0.4677595045031826d,

0.04046176928079037d,

0.3595716837843079d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.27664731521096464d,

0.7248456509935461d,

0.04001424356765615d,

0.91947644717155d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7633706153735578d,

0.4584337120203301d,

0.2867007038385414d,

0.23932621321640501d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.265272546208125d,

0.06192169577750695d,

0.9536118742968538d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5013500659711703d,

0.6249845991676343d,

0.5736252119083022d,

0.27523865937442293d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19067762211782902d,

0.9954160613890499d,

0.8888686118681974d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9030654258358896d,

0.12110858267983182d,

0.5502244973643577d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5364082434004762d,

0.19116650767066345d,

0.15930556938415585d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6305750659513418d,

0.9857907757131821d,

0.14483925833041833d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7562473858236959d,

0.737707671765189d,

0.7471975972791183d,

0.7585896682376156d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20929287378889627d,

0.5276119118806938d,

0.8530295234751071d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.05859079266699885d,

0.5335363001749343d,

0.22620399216521858d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6525080992753559d,

0.09244141331694444d,

0.07664342433462368d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3329938847590165d,

0.5742623493677562d,

0.2363873011314609d,

0.4807838701768439d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5882888732055335d,

0.378900766756056d,

0.9401496963517362d,

0.6703870623116059d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8560175086162086d,

0.7424148939124765d,

0.9054034157491403d,

0.6945492150238975d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.818583834543268d,

0.956625107196874d,

0.757417630316296d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1371186851764008d,

0.12924202521568562d,

0.49813904355707783d,

0.3837000154756893d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5121083835058727d,

0.4746670213258034d,

0.4779699152136857d,

0.10165108649322074d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5600862711117588d,

0.8970356390337446d,

0.9568324426465677d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1270584957175115d,

0.3895801136495094d,

0.5766226713007824d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3673383357197434d,

0.4340794709387251d,

0.6693708020806042d,

0.6719100590160565d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.37534396502568246d,

0.7053796938605885d,

0.9688001461479907d,

0.9062073059499758d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3691095871500185d,

0.3789289795252254d,

0.1852183479479761d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.28868705215866475d,

0.955153813479737d,

0.7555202946812983d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.42517967652971767d,

0.02738521511837466d,

0.9162971356318957d,

0.4798055475240153d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9435910410351683d,

0.33679915449777387d,

0.987372981370351d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4769457783468888d,

0.19675550302292122d,

0.4858090883045906d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4856966980418571d,

0.6809565904560267d,

0.516863037350701d,

0.9009874348130178d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.22826156832735933d,

0.754057544798972d,

0.05490762993339782d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5933774567502763d,

0.4653593677250547d,

0.3306232940858136d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.806278702537158d,

0.44296299878809675d,

0.4104369382850894d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8916400863017497d,

0.2376366148972996d,

0.17984527498229397d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7788548711521657d,

0.5526758459455985d,

0.6401944814984096d,

0.4277835442121033d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.20057075349399933d,

0.9924616226417836d,

0.49809903638192876d,

0.3161671984678456d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6928267908281095d,

0.204301342915592d,

0.35462449632304094d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3937354178390968d,

0.28881096689913877d,

0.9752475264466139d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9794889267253846d,

0.4039813468667963d,

0.2897340548073324d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9859302607807411d,

0.746810066077429d,

0.29857052174790655d,

0.3619942304863085d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.32775096588530483d,

0.8382771430566699d,

0.5400317137437652d,

0.44021238670840335d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.30218958339708435d,

0.377958463079226d,

0.4097606070487879d,

0.4419339057489765d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2730366885253048d,

0.9828313401030416d,

0.04475914147371496d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5501381367139142d,

0.17677680681971553d,

0.4122021759307518d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6304656781194731d,

0.4070074344278317d,

0.8841503264288091d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8143481512536556d,

0.9453503551127143d,

0.7979689625832863d,

0.023325051323632717d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6502989463427683d,

0.3542539621504055d,

0.6463453778579071d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.879528838037377d,

0.7522526588857011d,

0.14867357989648777d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9858917685990737d,

0.33007241701008416d,

0.29828405860193796d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09840575604923751d,

0.07204004157529209d,

0.494976426068245d,

0.7688537856590981d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9763129403883994d,

0.34083420948666343d,

0.20931654291690804d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08421396053543628d,

0.6338556849018057d,

0.6675094544733459d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3040426984869701d,

0.19490715022996485d,

0.1292621164950789d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7954796497156595d,

0.7050765426712794d,

0.04588990178503105d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8450079659424056d,

0.542346422679222d,

0.04797411889705139d,

0.428589614883494d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8973097431286462d,

0.8230772037525536d,

0.8703623472376295d,

0.5864839521548353d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07377491088808485d,

0.7882388306813896d,

0.9504074116001349d,

0.6385929391101288d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08143863650668581d,

0.27681477525747655d,

0.2774727215491535d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5723920490056188d,

0.2921847631342044d,

0.6250014318163972d,

0.41763756303296984d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19889272164495575d,

0.47277667363432685d,

0.9514767338266661d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4384558135152883d,

0.7792702544141121d,

0.5474595038354025d,

0.7882092650020445d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6329694497717856d,

0.4311019994000673d,

0.6214347574553538d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8743497350704162d,

0.20225508511974466d,

0.5086746166107183d,

0.9765155838125571d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9210773539800914d,

0.4239433657705517d,

0.14435296079353932d,

0.5781363037778203d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5888653857327429d,

0.7550281199263326d,

0.3770145622211146d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.38192008297992197d,

0.5402672775200983d,

0.9625460806896432d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.26331949902252827d,

0.7630412304609554d,

0.34357263500380497d,

0.8271696620977524d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.24298849364711206d,

0.5486305185487017d,

0.24610006075996205d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.45532117900984415d,

0.17634602229148832d,

0.5571018374937432d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.23130961215530899d,

0.6005662261796209d,

0.08059107359787732d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9869845769842946d,

0.4021687136572708d,

0.9169551426019574d,

0.281264847852284d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29788381732682123d,

0.5706658461506734d,

0.3608501324377297d,

0.4664367027730586d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05093164063840905d,

0.9620133164246952d,

0.6433879454150493d,

0.9215400321874505d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8887175874588412d,

0.09310601844717015d,

0.07117806306779284d,

0.8301167611055337d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7622172580832329d,

0.8355484522999306d,

0.6455146397697655d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9378264340112616d,

0.8443559475727637d,

0.18355883861059585d,

0.8652448386839078d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4038729375370823d,

0.5413049277279601d,

0.7563616990413993d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.20364559566261153d,

0.22831104357752552d,

0.9977718902304972d,

0.47846409965751824d,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
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

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionlistd1e2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
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
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
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
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionlistd1e2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionListD1E2M> models = null;

                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionListD1E2M> models = null;

                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 88;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 180;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 180;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 182;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 182;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 146, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 111, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 32, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 182, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 135, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 127, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 143, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 154, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatch(connection, 5, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[23], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[24], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[25], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models =  ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[18], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[19], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[20], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[21], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[22], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[23], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[24], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[25], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
FROM public.binary_doubledouble_precisionlistd1e2m m
LEFT JOIN public.binary_doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models =  ((IDoubleListdouble_precisionListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI), typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionListD1E2MI>();
                var models2 = new List<Doubledouble_precisionListD1E2MI>();
                await ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MI>();
                var models2 = new List<Doubledouble_precisionListD1E2MI>();
                ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleListdouble_precisionListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

