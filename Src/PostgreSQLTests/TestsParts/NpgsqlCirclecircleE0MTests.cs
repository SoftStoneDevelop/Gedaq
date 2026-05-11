

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

        private readonly NpgsqlCirclecircleE0M[] _testData = new NpgsqlCirclecircleE0M[]
        {
            new NpgsqlCirclecircleE0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.647288252563515d, y: 0.09061325284647936d), radius: 0.4955435024530299d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7668379050864944d, y: 0.03119337948838663d), radius: 0.8993930475062756d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6191728825401505d, y: 0.42643470307209574d), radius: 0.2778654273027126d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2198704134758157d, y: 0.30092740738217116d), radius: 0.7882373481106086d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4089957904566677d, y: 0.7681051366981734d), radius: 0.7899578335576648d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6204159481751851d, y: 0.23483906675854727d), radius: 0.6496488918073222d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.500427327368988d, y: 0.8469309633610425d), radius: 0.6683208892050287d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2180445156985038d, y: 0.6024435612227043d), radius: 0.6232798993365506d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7716503471053004d, y: 0.9905272971630631d), radius: 0.9525758907132953d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25131759655823294d, y: 0.3786881424676696d), radius: 0.6932374269585119d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7947127622997031d, y: 0.17246291540004843d), radius: 0.7552901166180614d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9241377853283806d, y: 0.48561960727542297d), radius: 0.7454297953128239d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6337997627814588d, y: 0.36090700007113496d), radius: 0.7546426415929235d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3124359852605516d, y: 0.06468283040031952d), radius: 0.3969784355831891d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2573157587807132d, y: 0.19331488432260302d), radius: 0.46283568223588767d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04945589572398412d, y: 0.8145948355073284d), radius: 0.818905401827753d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3360098634057792d, y: 0.9736026480097881d), radius: 0.5049324383537831d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7881115528538025d, y: 0.35181817242124747d), radius: 0.8664168536681022d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1336340754655969d, y: 0.43957495122237766d), radius: 0.885789494545367d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37871840630460674d, y: 0.4483507713673638d), radius: 0.11291316684935693d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.59029638408896d, y: 0.8967903612153959d), radius: 0.8304067509853691d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6471904257547705d, y: 0.5635436892490403d), radius: 0.7840832845467188d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13303750150328308d, y: 0.6819314882281627d), radius: 0.15673364436396153d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.369079434391435d, y: 0.40217985038975523d), radius: 0.8715427327017707d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.836589923018421d, y: 0.8918101671159064d), radius: 0.0013649960383549375d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5262642245126803d, y: 0.72854849411567d), radius: 0.6421663832033161d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36156942526878355d, y: 0.3965087122290921d), radius: 0.9598887298470236d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7701736623024877d, y: 0.23806092939482382d), radius: 0.17391243282782198d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1711721169222753d, y: 0.9469481964500099d), radius: 0.5321824850498813d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8044695740165905d, y: 0.464702073629768d), radius: 0.49468893423909743d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3582425346234316d, y: 0.26129911041762566d), radius: 0.5938407981893912d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27699599064394165d, y: 0.06262027074422871d), radius: 0.3578570546731552d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.77144802347181d, y: 0.6439294161324971d), radius: 0.22592484475050278d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8733619170635378d, y: 0.14550658782415338d), radius: 0.9402493170693752d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7033118170565735d, y: 0.042618722894703365d), radius: 0.5918236472576437d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7078097194619667d, y: 0.9988933666398485d), radius: 0.050955199408184715d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5478260073787387d, y: 0.963753753251806d), radius: 0.48256048145575736d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11072765948602026d, y: 0.32105853726722733d), radius: 0.40859299204543276d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38569829664244293d, y: 0.009098183906317892d), radius: 0.6983585275666382d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12701271574063822d, y: 0.25698775034669774d), radius: 0.5292585881242733d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.825711377620531d, y: 0.23238694449287078d), radius: 0.7347215421209811d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7934058982839312d, y: 0.412743004925748d), radius: 0.4072564786441708d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7935740521382055d, y: 0.6942246399314118d), radius: 0.7427427240687277d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3453534298837746d, y: 0.7847735805739159d), radius: 0.8384366171867426d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7996223648374489d, y: 0.8591947474379589d), radius: 0.7150148119711869d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6916474426560573d, y: 0.2528508866629673d), radius: 0.7565527109542683d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2667844787172141d, y: 0.5816329609300491d), radius: 0.3770534471054382d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10330178889547847d, y: 0.797927604533068d), radius: 0.7408083607522477d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6708782967497514d, y: 0.2698234878213218d), radius: 0.6967955297104548d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6031888425860786d, y: 0.006030385987563891d), radius: 0.4151438386265721d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.230363005717533d, y: 0.9645516185595101d), radius: 0.893145813042214d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2850980968097925d, y: 0.10635350956842882d), radius: 0.8236776867743598d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18977823891737378d, y: 0.719827912224205d), radius: 0.7568041783201391d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9026297773613532d, y: 0.6492605371208692d), radius: 0.5411643070775705d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6853369606394323d, y: 0.42900443009103606d), radius: 0.734131626705958d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21051533747944973d, y: 0.6630687517724158d), radius: 0.17177976201179335d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2702292851631579d, y: 0.42008382059971583d), radius: 0.5716302490332835d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11429555816108106d, y: 0.41978133837547593d), radius: 0.05637681534451877d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09056852390704762d, y: 0.1977798028700095d), radius: 0.0004093921297960712d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7505043784309183d, y: 0.18028728366966917d), radius: 0.34626429278121307d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5777781946342545d, y: 0.9605323109689721d), radius: 0.08172930478294982d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9803507938023268d, y: 0.18747943522042232d), radius: 0.2880774704122957d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5938188519741116d, y: 0.704804916089507d), radius: 0.3041258465135954d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8095036691693008d, y: 0.23112536616180845d), radius: 0.6426391064226997d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4808977951207447d, y: 0.13907122600211863d), radius: 0.060599804222278064d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9832375163605722d, y: 0.97039744633335d), radius: 0.30628459655839824d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5829765893324736d, y: 0.06579507026632281d), radius: 0.044746407125269894d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28520130240360264d, y: 0.7424323943005363d), radius: 0.4710309007933451d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9774499657267842d, y: 0.44445235756536006d), radius: 0.32266430366664556d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06532045208652681d, y: 0.8942542905652927d), radius: 0.08170869790786228d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6390685710765982d, y: 0.5242943237464104d), radius: 0.11758861935380371d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19635375847333247d, y: 0.7312249453247133d), radius: 0.5810663752734819d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34941290916306633d, y: 0.24246521126616605d), radius: 0.7266881986179367d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9734353760477296d, y: 0.39312425434938203d), radius: 0.2687522454481266d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4200376894507881d, y: 0.7210503041089947d), radius: 0.06951814119736532d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1389373225112548d, y: 0.7859912740939664d), radius: 0.7543821523665628d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3368148206919054d, y: 0.5196223153437433d), radius: 0.5070260416332615d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0mi(
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
INSERT INTO public.npgsqlcirclecirclee0mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI)],
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
INSERT INTO public.npgsqlcirclecirclee0mi(
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
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
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
                methodParametrName: "npgsqlcirclecirclee0mi_id", 
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
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
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
    npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25131759655823294d, y: 0.3786881424676696d), radius: 0.6932374269585119d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3124359852605516d, y: 0.06468283040031952d), radius: 0.3969784355831891d)));
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
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
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
    npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
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
                methodParametrName: "npgsqlcirclecirclee0mi_id", 
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36156942526878355d, y: 0.3965087122290921d), radius: 0.9598887298470236d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleE0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleE0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecirclee0mi_id
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
                parametrName: "npgsqlcirclecirclee0mi_id", 
                methodParametrName: "npgsqlcirclecirclee0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
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
FROM public.npgsqlcirclecirclee0m m
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
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
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
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
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
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
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
FROM public.npgsqlcirclecirclee0m m
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
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
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
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[34], false);
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
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 16, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 66, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 33, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 111, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 121, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 47, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 121, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 64, query1, 5, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
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
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 33, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[34], false);
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
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 19, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[34], false);
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
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[11], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[12], false);
                NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[13], false);
                NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[14], false);
                NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[15], false);
                NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[16], false);
                NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[17], false);
                NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[18], false);
                NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[19], false);
                NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[20], false);
                NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[21], false);
                NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[22], false);
                NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[23], false);
                NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[24], false);
                NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[25], false);
                NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[26], false);
                NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[27], false);
                NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[28], false);
                NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[29], false);
                NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[30], false);
                NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[31], false);
                NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[32], false);
                NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[27], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[28], false);
                NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[29], false);
                NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[30], false);
                NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[31], false);
                NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[32], false);
                NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
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
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.647288252563515d, y: 0.09061325284647936d), radius: 0.4955435024530299d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7668379050864944d, y: 0.03119337948838663d), radius: 0.8993930475062756d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6191728825401505d, y: 0.42643470307209574d), radius: 0.2778654273027126d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2198704134758157d, y: 0.30092740738217116d), radius: 0.7882373481106086d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4089957904566677d, y: 0.7681051366981734d), radius: 0.7899578335576648d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6204159481751851d, y: 0.23483906675854727d), radius: 0.6496488918073222d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.500427327368988d, y: 0.8469309633610425d), radius: 0.6683208892050287d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2180445156985038d, y: 0.6024435612227043d), radius: 0.6232798993365506d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7716503471053004d, y: 0.9905272971630631d), radius: 0.9525758907132953d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25131759655823294d, y: 0.3786881424676696d), radius: 0.6932374269585119d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7947127622997031d, y: 0.17246291540004843d), radius: 0.7552901166180614d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9241377853283806d, y: 0.48561960727542297d), radius: 0.7454297953128239d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6337997627814588d, y: 0.36090700007113496d), radius: 0.7546426415929235d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3124359852605516d, y: 0.06468283040031952d), radius: 0.3969784355831891d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2573157587807132d, y: 0.19331488432260302d), radius: 0.46283568223588767d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04945589572398412d, y: 0.8145948355073284d), radius: 0.818905401827753d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3360098634057792d, y: 0.9736026480097881d), radius: 0.5049324383537831d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7881115528538025d, y: 0.35181817242124747d), radius: 0.8664168536681022d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1336340754655969d, y: 0.43957495122237766d), radius: 0.885789494545367d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37871840630460674d, y: 0.4483507713673638d), radius: 0.11291316684935693d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.59029638408896d, y: 0.8967903612153959d), radius: 0.8304067509853691d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6471904257547705d, y: 0.5635436892490403d), radius: 0.7840832845467188d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13303750150328308d, y: 0.6819314882281627d), radius: 0.15673364436396153d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.369079434391435d, y: 0.40217985038975523d), radius: 0.8715427327017707d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.836589923018421d, y: 0.8918101671159064d), radius: 0.0013649960383549375d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5262642245126803d, y: 0.72854849411567d), radius: 0.6421663832033161d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36156942526878355d, y: 0.3965087122290921d), radius: 0.9598887298470236d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7701736623024877d, y: 0.23806092939482382d), radius: 0.17391243282782198d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1711721169222753d, y: 0.9469481964500099d), radius: 0.5321824850498813d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8044695740165905d, y: 0.464702073629768d), radius: 0.49468893423909743d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3582425346234316d, y: 0.26129911041762566d), radius: 0.5938407981893912d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27699599064394165d, y: 0.06262027074422871d), radius: 0.3578570546731552d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.77144802347181d, y: 0.6439294161324971d), radius: 0.22592484475050278d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8733619170635378d, y: 0.14550658782415338d), radius: 0.9402493170693752d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7033118170565735d, y: 0.042618722894703365d), radius: 0.5918236472576437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7078097194619667d, y: 0.9988933666398485d), radius: 0.050955199408184715d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5478260073787387d, y: 0.963753753251806d), radius: 0.48256048145575736d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11072765948602026d, y: 0.32105853726722733d), radius: 0.40859299204543276d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38569829664244293d, y: 0.009098183906317892d), radius: 0.6983585275666382d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12701271574063822d, y: 0.25698775034669774d), radius: 0.5292585881242733d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.825711377620531d, y: 0.23238694449287078d), radius: 0.7347215421209811d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7934058982839312d, y: 0.412743004925748d), radius: 0.4072564786441708d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7935740521382055d, y: 0.6942246399314118d), radius: 0.7427427240687277d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3453534298837746d, y: 0.7847735805739159d), radius: 0.8384366171867426d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7996223648374489d, y: 0.8591947474379589d), radius: 0.7150148119711869d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6916474426560573d, y: 0.2528508866629673d), radius: 0.7565527109542683d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2667844787172141d, y: 0.5816329609300491d), radius: 0.3770534471054382d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10330178889547847d, y: 0.797927604533068d), radius: 0.7408083607522477d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6708782967497514d, y: 0.2698234878213218d), radius: 0.6967955297104548d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6031888425860786d, y: 0.006030385987563891d), radius: 0.4151438386265721d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.230363005717533d, y: 0.9645516185595101d), radius: 0.893145813042214d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2850980968097925d, y: 0.10635350956842882d), radius: 0.8236776867743598d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18977823891737378d, y: 0.719827912224205d), radius: 0.7568041783201391d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9026297773613532d, y: 0.6492605371208692d), radius: 0.5411643070775705d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6853369606394323d, y: 0.42900443009103606d), radius: 0.734131626705958d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21051533747944973d, y: 0.6630687517724158d), radius: 0.17177976201179335d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2702292851631579d, y: 0.42008382059971583d), radius: 0.5716302490332835d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11429555816108106d, y: 0.41978133837547593d), radius: 0.05637681534451877d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09056852390704762d, y: 0.1977798028700095d), radius: 0.0004093921297960712d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7505043784309183d, y: 0.18028728366966917d), radius: 0.34626429278121307d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5777781946342545d, y: 0.9605323109689721d), radius: 0.08172930478294982d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9803507938023268d, y: 0.18747943522042232d), radius: 0.2880774704122957d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5938188519741116d, y: 0.704804916089507d), radius: 0.3041258465135954d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8095036691693008d, y: 0.23112536616180845d), radius: 0.6426391064226997d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4808977951207447d, y: 0.13907122600211863d), radius: 0.060599804222278064d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9832375163605722d, y: 0.97039744633335d), radius: 0.30628459655839824d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5829765893324736d, y: 0.06579507026632281d), radius: 0.044746407125269894d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28520130240360264d, y: 0.7424323943005363d), radius: 0.4710309007933451d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9774499657267842d, y: 0.44445235756536006d), radius: 0.32266430366664556d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06532045208652681d, y: 0.8942542905652927d), radius: 0.08170869790786228d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6390685710765982d, y: 0.5242943237464104d), radius: 0.11758861935380371d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19635375847333247d, y: 0.7312249453247133d), radius: 0.5810663752734819d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34941290916306633d, y: 0.24246521126616605d), radius: 0.7266881986179367d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9734353760477296d, y: 0.39312425434938203d), radius: 0.2687522454481266d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4200376894507881d, y: 0.7210503041089947d), radius: 0.06951814119736532d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1389373225112548d, y: 0.7859912740939664d), radius: 0.7543821523665628d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3368148206919054d, y: 0.5196223153437433d), radius: 0.5070260416332615d))));

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
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.647288252563515d, y: 0.09061325284647936d), radius: 0.4955435024530299d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7668379050864944d, y: 0.03119337948838663d), radius: 0.8993930475062756d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6191728825401505d, y: 0.42643470307209574d), radius: 0.2778654273027126d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2198704134758157d, y: 0.30092740738217116d), radius: 0.7882373481106086d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4089957904566677d, y: 0.7681051366981734d), radius: 0.7899578335576648d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6204159481751851d, y: 0.23483906675854727d), radius: 0.6496488918073222d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.500427327368988d, y: 0.8469309633610425d), radius: 0.6683208892050287d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2180445156985038d, y: 0.6024435612227043d), radius: 0.6232798993365506d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7716503471053004d, y: 0.9905272971630631d), radius: 0.9525758907132953d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25131759655823294d, y: 0.3786881424676696d), radius: 0.6932374269585119d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7947127622997031d, y: 0.17246291540004843d), radius: 0.7552901166180614d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9241377853283806d, y: 0.48561960727542297d), radius: 0.7454297953128239d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6337997627814588d, y: 0.36090700007113496d), radius: 0.7546426415929235d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3124359852605516d, y: 0.06468283040031952d), radius: 0.3969784355831891d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2573157587807132d, y: 0.19331488432260302d), radius: 0.46283568223588767d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04945589572398412d, y: 0.8145948355073284d), radius: 0.818905401827753d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3360098634057792d, y: 0.9736026480097881d), radius: 0.5049324383537831d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7881115528538025d, y: 0.35181817242124747d), radius: 0.8664168536681022d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1336340754655969d, y: 0.43957495122237766d), radius: 0.885789494545367d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37871840630460674d, y: 0.4483507713673638d), radius: 0.11291316684935693d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.59029638408896d, y: 0.8967903612153959d), radius: 0.8304067509853691d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6471904257547705d, y: 0.5635436892490403d), radius: 0.7840832845467188d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13303750150328308d, y: 0.6819314882281627d), radius: 0.15673364436396153d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.369079434391435d, y: 0.40217985038975523d), radius: 0.8715427327017707d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.836589923018421d, y: 0.8918101671159064d), radius: 0.0013649960383549375d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5262642245126803d, y: 0.72854849411567d), radius: 0.6421663832033161d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36156942526878355d, y: 0.3965087122290921d), radius: 0.9598887298470236d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7701736623024877d, y: 0.23806092939482382d), radius: 0.17391243282782198d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1711721169222753d, y: 0.9469481964500099d), radius: 0.5321824850498813d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8044695740165905d, y: 0.464702073629768d), radius: 0.49468893423909743d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3582425346234316d, y: 0.26129911041762566d), radius: 0.5938407981893912d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27699599064394165d, y: 0.06262027074422871d), radius: 0.3578570546731552d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.77144802347181d, y: 0.6439294161324971d), radius: 0.22592484475050278d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8733619170635378d, y: 0.14550658782415338d), radius: 0.9402493170693752d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7033118170565735d, y: 0.042618722894703365d), radius: 0.5918236472576437d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7078097194619667d, y: 0.9988933666398485d), radius: 0.050955199408184715d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5478260073787387d, y: 0.963753753251806d), radius: 0.48256048145575736d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11072765948602026d, y: 0.32105853726722733d), radius: 0.40859299204543276d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38569829664244293d, y: 0.009098183906317892d), radius: 0.6983585275666382d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12701271574063822d, y: 0.25698775034669774d), radius: 0.5292585881242733d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.825711377620531d, y: 0.23238694449287078d), radius: 0.7347215421209811d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7934058982839312d, y: 0.412743004925748d), radius: 0.4072564786441708d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7935740521382055d, y: 0.6942246399314118d), radius: 0.7427427240687277d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3453534298837746d, y: 0.7847735805739159d), radius: 0.8384366171867426d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7996223648374489d, y: 0.8591947474379589d), radius: 0.7150148119711869d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6916474426560573d, y: 0.2528508866629673d), radius: 0.7565527109542683d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2667844787172141d, y: 0.5816329609300491d), radius: 0.3770534471054382d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10330178889547847d, y: 0.797927604533068d), radius: 0.7408083607522477d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6708782967497514d, y: 0.2698234878213218d), radius: 0.6967955297104548d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6031888425860786d, y: 0.006030385987563891d), radius: 0.4151438386265721d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.230363005717533d, y: 0.9645516185595101d), radius: 0.893145813042214d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2850980968097925d, y: 0.10635350956842882d), radius: 0.8236776867743598d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18977823891737378d, y: 0.719827912224205d), radius: 0.7568041783201391d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9026297773613532d, y: 0.6492605371208692d), radius: 0.5411643070775705d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6853369606394323d, y: 0.42900443009103606d), radius: 0.734131626705958d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21051533747944973d, y: 0.6630687517724158d), radius: 0.17177976201179335d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2702292851631579d, y: 0.42008382059971583d), radius: 0.5716302490332835d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11429555816108106d, y: 0.41978133837547593d), radius: 0.05637681534451877d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09056852390704762d, y: 0.1977798028700095d), radius: 0.0004093921297960712d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7505043784309183d, y: 0.18028728366966917d), radius: 0.34626429278121307d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5777781946342545d, y: 0.9605323109689721d), radius: 0.08172930478294982d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9803507938023268d, y: 0.18747943522042232d), radius: 0.2880774704122957d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5938188519741116d, y: 0.704804916089507d), radius: 0.3041258465135954d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8095036691693008d, y: 0.23112536616180845d), radius: 0.6426391064226997d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4808977951207447d, y: 0.13907122600211863d), radius: 0.060599804222278064d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9832375163605722d, y: 0.97039744633335d), radius: 0.30628459655839824d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5829765893324736d, y: 0.06579507026632281d), radius: 0.044746407125269894d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28520130240360264d, y: 0.7424323943005363d), radius: 0.4710309007933451d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9774499657267842d, y: 0.44445235756536006d), radius: 0.32266430366664556d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06532045208652681d, y: 0.8942542905652927d), radius: 0.08170869790786228d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6390685710765982d, y: 0.5242943237464104d), radius: 0.11758861935380371d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19635375847333247d, y: 0.7312249453247133d), radius: 0.5810663752734819d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34941290916306633d, y: 0.24246521126616605d), radius: 0.7266881986179367d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9734353760477296d, y: 0.39312425434938203d), radius: 0.2687522454481266d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4200376894507881d, y: 0.7210503041089947d), radius: 0.06951814119736532d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1389373225112548d, y: 0.7859912740939664d), radius: 0.7543821523665628d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3368148206919054d, y: 0.5196223153437433d), radius: 0.5070260416332615d))));

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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
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
            queryMapType: typeof(NpgsqlCirclecircleE0MIWA),
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
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
            queryMapType: typeof(NpgsqlCirclecircleE0MIWA),
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI)],
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
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MI),
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
                var importCollection = new List<NpgsqlCirclecircleE0MI>(2);
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
                    NpgsqlCirclecircleE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MI>(2);
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
                    NpgsqlCirclecircleE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
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
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MIWA),
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleE0M),
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
FROM public.binary_npgsqlcirclecirclee0m m
LEFT JOIN public.binary_npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
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
                var importCollection = new List<NpgsqlCirclecircleE0M>();
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
                    NpgsqlCirclecircleE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0M>();
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
                    NpgsqlCirclecircleE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
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
                    NpgsqlCirclecircleE0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlCirclecircleE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA), typeof(NpgsqlCirclecircleE0MIWA)],
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
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
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA), typeof(NpgsqlCirclecircleE0MIWA)],
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
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
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI), typeof(NpgsqlCirclecircleE0MI)],
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
                var models1 = new List<NpgsqlCirclecircleE0MI>();
                var models2 = new List<NpgsqlCirclecircleE0MI>();
                await ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MI>();
                var models2 = new List<NpgsqlCirclecircleE0MI>();
                ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI)],
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
                    NpgsqlCirclecircleE0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlCirclecircleE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA), typeof(NpgsqlCirclecircleE0MIWA)],
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

