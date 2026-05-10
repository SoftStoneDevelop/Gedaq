

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
    internal partial interface INpgsqlBoxSingleTypebox
    {
    }
    
    internal partial class NpgsqlBoxSingleTypebox : INpgsqlBoxSingleTypebox
    {


#region TestData

        private readonly NpgsqlBoxbox0M[] _testData = new NpgsqlBoxbox0M[]
        {
            new NpgsqlBoxbox0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6343366575731414d,right: 0.6004304048869739d,bottom: 0.1398355674026438d,left: 0.02180903231142295d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6322038399643223d,right: 0.9273914654931925d,bottom: 0.1077528319814447d,left: 0.3113616484709848d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9898096566078173d,right: 0.9744260126139811d,bottom: 0.5835796730965819d,left: 0.7859682243882408d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5436195632529562d,right: 0.8444069591797545d,bottom: 0.5165911583608976d,left: 0.5973560219942542d),
},
            new NpgsqlBoxbox0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4907622744387037d,right: 0.3961258475962357d,bottom: 0.20303060824563524d,left: 0.10914769662734891d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6370552369365196d,right: 0.9420365539979786d,bottom: 0.22309335623370707d,left: 0.3478556158649151d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9540629780299826d,right: 0.5023584631492582d,bottom: 0.7121861364796653d,left: 0.2954718146227997d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9930053521084734d,right: 0.5015263572858994d,bottom: 0.7907248444834906d,left: 0.10145263134340232d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8940131202654262d,right: 0.4912431194781789d,bottom: 0.6212860717273924d,left: 0.2675827570962157d),
},
            new NpgsqlBoxbox0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9402116445583406d,right: 0.8534272181429761d,bottom: 0.8186933393201965d,left: 0.2749696134365318d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.34910859062637367d,right: 0.7605197770743536d,bottom: 0.06427590594485433d,left: 0.41691552523234043d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7238811063285264d,right: 0.5967858604637162d,bottom: 0.34398467609253514d,left: 0.020330377956691903d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9007285515303411d,right: 0.41186029573728966d,bottom: 0.011838303275397144d,left: 0.1704855136454808d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9300221727455937d,right: 0.21352809523074667d,bottom: 0.42089866132535236d,left: 0.033461345978837986d),
},
            new NpgsqlBoxbox0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8857009265068841d,right: 0.9216038590805934d,bottom: 0.3661717213894684d,left: 0.15584968060705484d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7066299053398939d,right: 0.9935256444439342d,bottom: 0.2657269046067742d,left: 0.7900868333951473d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9031699219833744d,right: 0.686152361424687d,bottom: 0.1319225255230806d,left: 0.48891386721375085d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.4628984602054328d,right: 0.917339981353363d,bottom: 0.35578276533141096d,left: 0.5652855169066558d),
},
            new NpgsqlBoxbox0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8525866003560768d,right: 0.9064187257859249d,bottom: 0.35604967229695694d,left: 0.5870140063399074d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.49941617435267693d,right: 0.7818901219491747d,bottom: 0.12636904051525832d,left: 0.2948135455886701d),
},
            new NpgsqlBoxbox0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9963922960366624d,right: 0.4879261309608336d,bottom: 0.31127076699209d,left: 0.4651111867901392d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6638215866789065d,right: 0.45946782525060503d,bottom: 0.24705942759780786d,left: 0.141376737555585d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6753489548432263d,right: 0.362568339394877d,bottom: 0.5964748298567639d,left: 0.02401437143463514d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.17254834252150753d,right: 0.5246669525355384d,bottom: 0.14325815089977867d,left: 0.08731723005990621d),
},
            new NpgsqlBoxbox0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7605445278227414d,right: 0.9203853841447582d,bottom: 0.29528880590479123d,left: 0.8907509746978235d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6516802743606136d,right: 0.8166453180725032d,bottom: 0.4587508604215885d,left: 0.1829397951171794d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8458193446184747d,right: 0.8978169964028978d,bottom: 0.043001055947569755d,left: 0.10954655733922258d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8909278376581016d,right: 0.4819615461731729d,bottom: 0.15615486661580003d,left: 0.192192383235383d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7313877315854949d,right: 0.4449614413229179d,bottom: 0.16119588987038957d,left: 0.20597379014982298d),
},
            new NpgsqlBoxbox0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9771017505884653d,right: 0.9595669401837199d,bottom: 0.45169757459611193d,left: 0.6852446597092492d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8949891705484074d,right: 0.7453983800244677d,bottom: 0.3127505129096335d,left: 0.665603398685155d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5275676381100779d,right: 0.8876146198086431d,bottom: 0.11989550803873184d,left: 0.5972461399223918d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5431943112642564d,right: 0.9486472513379789d,bottom: 0.22944446983092925d,left: 0.49649858175551975d),
},
            new NpgsqlBoxbox0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8576378863611015d,right: 0.06017433535952599d,bottom: 0.4904552980819986d,left: 0.003943673630545486d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.647390474438058d,right: 0.9347685438867034d,bottom: 0.23774751130102d,left: 0.665693943279521d),
},
            new NpgsqlBoxbox0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2412083504853283d,right: 0.920334861882291d,bottom: 0.207212508525897d,left: 0.14359691694496557d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9012738777228319d,right: 0.8637613471356816d,bottom: 0.31295350581862d,left: 0.5892689895164963d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9930727760643294d,right: 0.7447032605784923d,bottom: 0.8251394572746958d,left: 0.6863228013995182d),
},
            new NpgsqlBoxbox0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6694212059946975d,right: 0.3562719530785039d,bottom: 0.6222169092808276d,left: 0.2048587172807912d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4829805176908286d,right: 0.5303213577688123d,bottom: 0.409692636200093d,left: 0.12256657877476984d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.23832105739837628d,right: 0.8743647674392963d,bottom: 0.18860765725336526d,left: 0.8002168116780609d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6155529009100621d,right: 0.438873392630881d,bottom: 0.5604820394084994d,left: 0.15247376306948912d),
},
            new NpgsqlBoxbox0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7131221690623999d,right: 0.9103024016698456d,bottom: 0.32574263773572765d,left: 0.6675870463451015d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6942555861828859d,right: 0.4413525899199304d,bottom: 0.5672797373976918d,left: 0.1796960580575433d),
},
            new NpgsqlBoxbox0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8719922772649636d,right: 0.8533564361543504d,bottom: 0.18740277984415243d,left: 0.7445439966284749d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7334946053035236d,right: 0.18872221175722714d,bottom: 0.5576581819830345d,left: 0.11089631785457532d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3377935971548851d,right: 0.9793985787410151d,bottom: 0.23764527625996612d,left: 0.4137048776431854d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9532648106389031d,right: 0.9124562920951252d,bottom: 0.31853677853754325d,left: 0.5264066503985337d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8800302007597331d,right: 0.9618494432968562d,bottom: 0.3647627804315503d,left: 0.11176436058348116d),
},
            new NpgsqlBoxbox0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6802153763520533d,right: 0.3546419309629161d,bottom: 0.6704696318216123d,left: 0.012156930431619473d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5001618351971592d,right: 0.749742713853803d,bottom: 0.15951795163614313d,left: 0.09877904936744741d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9714487745171754d,right: 0.747034214761216d,bottom: 0.6988916602513818d,left: 0.0677616331726375d),
},
            new NpgsqlBoxbox0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.45333174591780745d,right: 0.6580152002307202d,bottom: 0.4014772531918056d,left: 0.18687369428084688d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4633640871677468d,right: 0.5774343302988146d,bottom: 0.3723985442219969d,left: 0.05824156269321157d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.908659290585235d,right: 0.5374839313012282d,bottom: 0.29293711716682347d,left: 0.3202773867885417d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.25908330436993665d,right: 0.6100164060066788d,bottom: 0.2506097366278356d,left: 0.10264356556514453d),
},
            new NpgsqlBoxbox0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3258156374727633d,right: 0.5538568637494407d,bottom: 0.3152323259900912d,left: 0.17176178330716252d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8730994171560615d,right: 0.284712451072075d,bottom: 0.7214871868988985d,left: 0.13482915944246077d),
},
            new NpgsqlBoxbox0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8519694093464867d,right: 0.9821436399239858d,bottom: 0.23582995449773447d,left: 0.5399570509762711d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7905580414922875d,right: 0.6457446726388788d,bottom: 0.040568148783767355d,left: 0.3113940241507571d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6285984713011646d,right: 0.9748534816005565d,bottom: 0.45699037009745846d,left: 0.015138699303792191d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8194738505341468d,right: 0.6300323783253172d,bottom: 0.4087454514659511d,left: 0.19416015046205326d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6680099524933764d,right: 0.5048323637228409d,bottom: 0.18825656520081424d,left: 0.22967079533240398d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5707657034575958d,right: 0.6816360054215104d,bottom: 0.1648659609643477d,left: 0.28664697717598453d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.31538940768513535d,right: 0.9364136635165465d,bottom: 0.2990504502140511d,left: 0.7852510697578952d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7260863318570094d,right: 0.7470734653733617d,bottom: 0.5530556112899199d,left: 0.07972833826936121d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7994945191591061d,right: 0.8867862510235207d,bottom: 0.42739143841825167d,left: 0.14117573433605157d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.915524238405391d,right: 0.659485631037995d,bottom: 0.7523218978306261d,left: 0.22273123542234696d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 174,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8254986423222085d,right: 0.6961689754799834d,bottom: 0.23962280620986476d,left: 0.3277239265311094d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5630860280032213d,right: 0.7582749271643789d,bottom: 0.28194035011759644d,left: 0.7312557529143947d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5071965806697977d,right: 0.7914010305449602d,bottom: 0.35085970288768975d,left: 0.46440327788682545d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9368247640428409d,right: 0.21888525931436975d,bottom: 0.30775822358971583d,left: 0.09576253196314333d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9773022586595449d,right: 0.2586012338572524d,bottom: 0.4613286983609768d,left: 0.21220531848198942d),
},
            new NpgsqlBoxbox0M
{
    Id = 186,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8264790326557558d,right: 0.6411464264846037d,bottom: 0.39335704959099127d,left: 0.4259332008677389d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 194,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3248190339548661d,right: 0.6017597012856968d,bottom: 0.07704269339226899d,left: 0.4207977025112022d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7154748077001607d,right: 0.9508778543673245d,bottom: 0.12606948648965655d,left: 0.6316630734387347d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8956194521461827d,right: 0.1675505430407943d,bottom: 0.573755905120581d,left: 0.10860251001673438d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 199,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5328105464308249d,right: 0.4499034258691178d,bottom: 0.3557484136022031d,left: 0.347640169039519d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9300221727455937d,right: 0.21352809523074667d,bottom: 0.42089866132535236d,left: 0.033461345978837986d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.4628984602054328d,right: 0.917339981353363d,bottom: 0.35578276533141096d,left: 0.5652855169066558d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.49941617435267693d,right: 0.7818901219491747d,bottom: 0.12636904051525832d,left: 0.2948135455886701d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.17254834252150753d,right: 0.5246669525355384d,bottom: 0.14325815089977867d,left: 0.08731723005990621d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7313877315854949d,right: 0.4449614413229179d,bottom: 0.16119588987038957d,left: 0.20597379014982298d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxbox0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlBox), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlboxbox0mi_id", 
                methodParametrName: "npgsqlboxbox0mi_id", 
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 65;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 186, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 4, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 53, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 65, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 110, query1, 166, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 179, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 150, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 150, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 179, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[30], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[31], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[32], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[33], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6343366575731414d,right: 0.6004304048869739d,bottom: 0.1398355674026438d,left: 0.02180903231142295d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6322038399643223d,right: 0.9273914654931925d,bottom: 0.1077528319814447d,left: 0.3113616484709848d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9898096566078173d,right: 0.9744260126139811d,bottom: 0.5835796730965819d,left: 0.7859682243882408d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5436195632529562d,right: 0.8444069591797545d,bottom: 0.5165911583608976d,left: 0.5973560219942542d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4907622744387037d,right: 0.3961258475962357d,bottom: 0.20303060824563524d,left: 0.10914769662734891d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6370552369365196d,right: 0.9420365539979786d,bottom: 0.22309335623370707d,left: 0.3478556158649151d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9540629780299826d,right: 0.5023584631492582d,bottom: 0.7121861364796653d,left: 0.2954718146227997d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9930053521084734d,right: 0.5015263572858994d,bottom: 0.7907248444834906d,left: 0.10145263134340232d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8940131202654262d,right: 0.4912431194781789d,bottom: 0.6212860717273924d,left: 0.2675827570962157d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9402116445583406d,right: 0.8534272181429761d,bottom: 0.8186933393201965d,left: 0.2749696134365318d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34910859062637367d,right: 0.7605197770743536d,bottom: 0.06427590594485433d,left: 0.41691552523234043d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7238811063285264d,right: 0.5967858604637162d,bottom: 0.34398467609253514d,left: 0.020330377956691903d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9007285515303411d,right: 0.41186029573728966d,bottom: 0.011838303275397144d,left: 0.1704855136454808d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9300221727455937d,right: 0.21352809523074667d,bottom: 0.42089866132535236d,left: 0.033461345978837986d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8857009265068841d,right: 0.9216038590805934d,bottom: 0.3661717213894684d,left: 0.15584968060705484d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7066299053398939d,right: 0.9935256444439342d,bottom: 0.2657269046067742d,left: 0.7900868333951473d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9031699219833744d,right: 0.686152361424687d,bottom: 0.1319225255230806d,left: 0.48891386721375085d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4628984602054328d,right: 0.917339981353363d,bottom: 0.35578276533141096d,left: 0.5652855169066558d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8525866003560768d,right: 0.9064187257859249d,bottom: 0.35604967229695694d,left: 0.5870140063399074d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49941617435267693d,right: 0.7818901219491747d,bottom: 0.12636904051525832d,left: 0.2948135455886701d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9963922960366624d,right: 0.4879261309608336d,bottom: 0.31127076699209d,left: 0.4651111867901392d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6638215866789065d,right: 0.45946782525060503d,bottom: 0.24705942759780786d,left: 0.141376737555585d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6753489548432263d,right: 0.362568339394877d,bottom: 0.5964748298567639d,left: 0.02401437143463514d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17254834252150753d,right: 0.5246669525355384d,bottom: 0.14325815089977867d,left: 0.08731723005990621d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7605445278227414d,right: 0.9203853841447582d,bottom: 0.29528880590479123d,left: 0.8907509746978235d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6516802743606136d,right: 0.8166453180725032d,bottom: 0.4587508604215885d,left: 0.1829397951171794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8458193446184747d,right: 0.8978169964028978d,bottom: 0.043001055947569755d,left: 0.10954655733922258d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8909278376581016d,right: 0.4819615461731729d,bottom: 0.15615486661580003d,left: 0.192192383235383d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7313877315854949d,right: 0.4449614413229179d,bottom: 0.16119588987038957d,left: 0.20597379014982298d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9771017505884653d,right: 0.9595669401837199d,bottom: 0.45169757459611193d,left: 0.6852446597092492d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8949891705484074d,right: 0.7453983800244677d,bottom: 0.3127505129096335d,left: 0.665603398685155d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5275676381100779d,right: 0.8876146198086431d,bottom: 0.11989550803873184d,left: 0.5972461399223918d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5431943112642564d,right: 0.9486472513379789d,bottom: 0.22944446983092925d,left: 0.49649858175551975d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8576378863611015d,right: 0.06017433535952599d,bottom: 0.4904552980819986d,left: 0.003943673630545486d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.647390474438058d,right: 0.9347685438867034d,bottom: 0.23774751130102d,left: 0.665693943279521d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2412083504853283d,right: 0.920334861882291d,bottom: 0.207212508525897d,left: 0.14359691694496557d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9012738777228319d,right: 0.8637613471356816d,bottom: 0.31295350581862d,left: 0.5892689895164963d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9930727760643294d,right: 0.7447032605784923d,bottom: 0.8251394572746958d,left: 0.6863228013995182d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6694212059946975d,right: 0.3562719530785039d,bottom: 0.6222169092808276d,left: 0.2048587172807912d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4829805176908286d,right: 0.5303213577688123d,bottom: 0.409692636200093d,left: 0.12256657877476984d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23832105739837628d,right: 0.8743647674392963d,bottom: 0.18860765725336526d,left: 0.8002168116780609d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6155529009100621d,right: 0.438873392630881d,bottom: 0.5604820394084994d,left: 0.15247376306948912d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7131221690623999d,right: 0.9103024016698456d,bottom: 0.32574263773572765d,left: 0.6675870463451015d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6942555861828859d,right: 0.4413525899199304d,bottom: 0.5672797373976918d,left: 0.1796960580575433d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8719922772649636d,right: 0.8533564361543504d,bottom: 0.18740277984415243d,left: 0.7445439966284749d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7334946053035236d,right: 0.18872221175722714d,bottom: 0.5576581819830345d,left: 0.11089631785457532d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3377935971548851d,right: 0.9793985787410151d,bottom: 0.23764527625996612d,left: 0.4137048776431854d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9532648106389031d,right: 0.9124562920951252d,bottom: 0.31853677853754325d,left: 0.5264066503985337d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8800302007597331d,right: 0.9618494432968562d,bottom: 0.3647627804315503d,left: 0.11176436058348116d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6802153763520533d,right: 0.3546419309629161d,bottom: 0.6704696318216123d,left: 0.012156930431619473d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5001618351971592d,right: 0.749742713853803d,bottom: 0.15951795163614313d,left: 0.09877904936744741d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9714487745171754d,right: 0.747034214761216d,bottom: 0.6988916602513818d,left: 0.0677616331726375d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45333174591780745d,right: 0.6580152002307202d,bottom: 0.4014772531918056d,left: 0.18687369428084688d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4633640871677468d,right: 0.5774343302988146d,bottom: 0.3723985442219969d,left: 0.05824156269321157d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.908659290585235d,right: 0.5374839313012282d,bottom: 0.29293711716682347d,left: 0.3202773867885417d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25908330436993665d,right: 0.6100164060066788d,bottom: 0.2506097366278356d,left: 0.10264356556514453d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3258156374727633d,right: 0.5538568637494407d,bottom: 0.3152323259900912d,left: 0.17176178330716252d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8730994171560615d,right: 0.284712451072075d,bottom: 0.7214871868988985d,left: 0.13482915944246077d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8519694093464867d,right: 0.9821436399239858d,bottom: 0.23582995449773447d,left: 0.5399570509762711d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7905580414922875d,right: 0.6457446726388788d,bottom: 0.040568148783767355d,left: 0.3113940241507571d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6285984713011646d,right: 0.9748534816005565d,bottom: 0.45699037009745846d,left: 0.015138699303792191d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8194738505341468d,right: 0.6300323783253172d,bottom: 0.4087454514659511d,left: 0.19416015046205326d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6680099524933764d,right: 0.5048323637228409d,bottom: 0.18825656520081424d,left: 0.22967079533240398d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5707657034575958d,right: 0.6816360054215104d,bottom: 0.1648659609643477d,left: 0.28664697717598453d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31538940768513535d,right: 0.9364136635165465d,bottom: 0.2990504502140511d,left: 0.7852510697578952d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7260863318570094d,right: 0.7470734653733617d,bottom: 0.5530556112899199d,left: 0.07972833826936121d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7994945191591061d,right: 0.8867862510235207d,bottom: 0.42739143841825167d,left: 0.14117573433605157d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.915524238405391d,right: 0.659485631037995d,bottom: 0.7523218978306261d,left: 0.22273123542234696d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8254986423222085d,right: 0.6961689754799834d,bottom: 0.23962280620986476d,left: 0.3277239265311094d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5630860280032213d,right: 0.7582749271643789d,bottom: 0.28194035011759644d,left: 0.7312557529143947d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5071965806697977d,right: 0.7914010305449602d,bottom: 0.35085970288768975d,left: 0.46440327788682545d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9368247640428409d,right: 0.21888525931436975d,bottom: 0.30775822358971583d,left: 0.09576253196314333d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9773022586595449d,right: 0.2586012338572524d,bottom: 0.4613286983609768d,left: 0.21220531848198942d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8264790326557558d,right: 0.6411464264846037d,bottom: 0.39335704959099127d,left: 0.4259332008677389d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3248190339548661d,right: 0.6017597012856968d,bottom: 0.07704269339226899d,left: 0.4207977025112022d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7154748077001607d,right: 0.9508778543673245d,bottom: 0.12606948648965655d,left: 0.6316630734387347d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8956194521461827d,right: 0.1675505430407943d,bottom: 0.573755905120581d,left: 0.10860251001673438d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5328105464308249d,right: 0.4499034258691178d,bottom: 0.3557484136022031d,left: 0.347640169039519d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6343366575731414d,right: 0.6004304048869739d,bottom: 0.1398355674026438d,left: 0.02180903231142295d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6322038399643223d,right: 0.9273914654931925d,bottom: 0.1077528319814447d,left: 0.3113616484709848d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9898096566078173d,right: 0.9744260126139811d,bottom: 0.5835796730965819d,left: 0.7859682243882408d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5436195632529562d,right: 0.8444069591797545d,bottom: 0.5165911583608976d,left: 0.5973560219942542d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4907622744387037d,right: 0.3961258475962357d,bottom: 0.20303060824563524d,left: 0.10914769662734891d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6370552369365196d,right: 0.9420365539979786d,bottom: 0.22309335623370707d,left: 0.3478556158649151d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9540629780299826d,right: 0.5023584631492582d,bottom: 0.7121861364796653d,left: 0.2954718146227997d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9930053521084734d,right: 0.5015263572858994d,bottom: 0.7907248444834906d,left: 0.10145263134340232d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8940131202654262d,right: 0.4912431194781789d,bottom: 0.6212860717273924d,left: 0.2675827570962157d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9402116445583406d,right: 0.8534272181429761d,bottom: 0.8186933393201965d,left: 0.2749696134365318d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.34910859062637367d,right: 0.7605197770743536d,bottom: 0.06427590594485433d,left: 0.41691552523234043d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7238811063285264d,right: 0.5967858604637162d,bottom: 0.34398467609253514d,left: 0.020330377956691903d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9007285515303411d,right: 0.41186029573728966d,bottom: 0.011838303275397144d,left: 0.1704855136454808d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9300221727455937d,right: 0.21352809523074667d,bottom: 0.42089866132535236d,left: 0.033461345978837986d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8857009265068841d,right: 0.9216038590805934d,bottom: 0.3661717213894684d,left: 0.15584968060705484d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7066299053398939d,right: 0.9935256444439342d,bottom: 0.2657269046067742d,left: 0.7900868333951473d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9031699219833744d,right: 0.686152361424687d,bottom: 0.1319225255230806d,left: 0.48891386721375085d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4628984602054328d,right: 0.917339981353363d,bottom: 0.35578276533141096d,left: 0.5652855169066558d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8525866003560768d,right: 0.9064187257859249d,bottom: 0.35604967229695694d,left: 0.5870140063399074d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49941617435267693d,right: 0.7818901219491747d,bottom: 0.12636904051525832d,left: 0.2948135455886701d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9963922960366624d,right: 0.4879261309608336d,bottom: 0.31127076699209d,left: 0.4651111867901392d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6638215866789065d,right: 0.45946782525060503d,bottom: 0.24705942759780786d,left: 0.141376737555585d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6753489548432263d,right: 0.362568339394877d,bottom: 0.5964748298567639d,left: 0.02401437143463514d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17254834252150753d,right: 0.5246669525355384d,bottom: 0.14325815089977867d,left: 0.08731723005990621d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7605445278227414d,right: 0.9203853841447582d,bottom: 0.29528880590479123d,left: 0.8907509746978235d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6516802743606136d,right: 0.8166453180725032d,bottom: 0.4587508604215885d,left: 0.1829397951171794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8458193446184747d,right: 0.8978169964028978d,bottom: 0.043001055947569755d,left: 0.10954655733922258d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8909278376581016d,right: 0.4819615461731729d,bottom: 0.15615486661580003d,left: 0.192192383235383d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7313877315854949d,right: 0.4449614413229179d,bottom: 0.16119588987038957d,left: 0.20597379014982298d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9771017505884653d,right: 0.9595669401837199d,bottom: 0.45169757459611193d,left: 0.6852446597092492d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8949891705484074d,right: 0.7453983800244677d,bottom: 0.3127505129096335d,left: 0.665603398685155d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5275676381100779d,right: 0.8876146198086431d,bottom: 0.11989550803873184d,left: 0.5972461399223918d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5431943112642564d,right: 0.9486472513379789d,bottom: 0.22944446983092925d,left: 0.49649858175551975d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8576378863611015d,right: 0.06017433535952599d,bottom: 0.4904552980819986d,left: 0.003943673630545486d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.647390474438058d,right: 0.9347685438867034d,bottom: 0.23774751130102d,left: 0.665693943279521d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2412083504853283d,right: 0.920334861882291d,bottom: 0.207212508525897d,left: 0.14359691694496557d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9012738777228319d,right: 0.8637613471356816d,bottom: 0.31295350581862d,left: 0.5892689895164963d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9930727760643294d,right: 0.7447032605784923d,bottom: 0.8251394572746958d,left: 0.6863228013995182d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6694212059946975d,right: 0.3562719530785039d,bottom: 0.6222169092808276d,left: 0.2048587172807912d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4829805176908286d,right: 0.5303213577688123d,bottom: 0.409692636200093d,left: 0.12256657877476984d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23832105739837628d,right: 0.8743647674392963d,bottom: 0.18860765725336526d,left: 0.8002168116780609d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6155529009100621d,right: 0.438873392630881d,bottom: 0.5604820394084994d,left: 0.15247376306948912d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7131221690623999d,right: 0.9103024016698456d,bottom: 0.32574263773572765d,left: 0.6675870463451015d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6942555861828859d,right: 0.4413525899199304d,bottom: 0.5672797373976918d,left: 0.1796960580575433d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8719922772649636d,right: 0.8533564361543504d,bottom: 0.18740277984415243d,left: 0.7445439966284749d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7334946053035236d,right: 0.18872221175722714d,bottom: 0.5576581819830345d,left: 0.11089631785457532d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3377935971548851d,right: 0.9793985787410151d,bottom: 0.23764527625996612d,left: 0.4137048776431854d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9532648106389031d,right: 0.9124562920951252d,bottom: 0.31853677853754325d,left: 0.5264066503985337d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8800302007597331d,right: 0.9618494432968562d,bottom: 0.3647627804315503d,left: 0.11176436058348116d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6802153763520533d,right: 0.3546419309629161d,bottom: 0.6704696318216123d,left: 0.012156930431619473d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5001618351971592d,right: 0.749742713853803d,bottom: 0.15951795163614313d,left: 0.09877904936744741d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9714487745171754d,right: 0.747034214761216d,bottom: 0.6988916602513818d,left: 0.0677616331726375d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45333174591780745d,right: 0.6580152002307202d,bottom: 0.4014772531918056d,left: 0.18687369428084688d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4633640871677468d,right: 0.5774343302988146d,bottom: 0.3723985442219969d,left: 0.05824156269321157d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.908659290585235d,right: 0.5374839313012282d,bottom: 0.29293711716682347d,left: 0.3202773867885417d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25908330436993665d,right: 0.6100164060066788d,bottom: 0.2506097366278356d,left: 0.10264356556514453d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3258156374727633d,right: 0.5538568637494407d,bottom: 0.3152323259900912d,left: 0.17176178330716252d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8730994171560615d,right: 0.284712451072075d,bottom: 0.7214871868988985d,left: 0.13482915944246077d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8519694093464867d,right: 0.9821436399239858d,bottom: 0.23582995449773447d,left: 0.5399570509762711d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7905580414922875d,right: 0.6457446726388788d,bottom: 0.040568148783767355d,left: 0.3113940241507571d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6285984713011646d,right: 0.9748534816005565d,bottom: 0.45699037009745846d,left: 0.015138699303792191d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8194738505341468d,right: 0.6300323783253172d,bottom: 0.4087454514659511d,left: 0.19416015046205326d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6680099524933764d,right: 0.5048323637228409d,bottom: 0.18825656520081424d,left: 0.22967079533240398d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5707657034575958d,right: 0.6816360054215104d,bottom: 0.1648659609643477d,left: 0.28664697717598453d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.31538940768513535d,right: 0.9364136635165465d,bottom: 0.2990504502140511d,left: 0.7852510697578952d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7260863318570094d,right: 0.7470734653733617d,bottom: 0.5530556112899199d,left: 0.07972833826936121d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7994945191591061d,right: 0.8867862510235207d,bottom: 0.42739143841825167d,left: 0.14117573433605157d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.915524238405391d,right: 0.659485631037995d,bottom: 0.7523218978306261d,left: 0.22273123542234696d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8254986423222085d,right: 0.6961689754799834d,bottom: 0.23962280620986476d,left: 0.3277239265311094d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5630860280032213d,right: 0.7582749271643789d,bottom: 0.28194035011759644d,left: 0.7312557529143947d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5071965806697977d,right: 0.7914010305449602d,bottom: 0.35085970288768975d,left: 0.46440327788682545d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9368247640428409d,right: 0.21888525931436975d,bottom: 0.30775822358971583d,left: 0.09576253196314333d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9773022586595449d,right: 0.2586012338572524d,bottom: 0.4613286983609768d,left: 0.21220531848198942d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8264790326557558d,right: 0.6411464264846037d,bottom: 0.39335704959099127d,left: 0.4259332008677389d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3248190339548661d,right: 0.6017597012856968d,bottom: 0.07704269339226899d,left: 0.4207977025112022d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7154748077001607d,right: 0.9508778543673245d,bottom: 0.12606948648965655d,left: 0.6316630734387347d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8956194521461827d,right: 0.1675505430407943d,bottom: 0.573755905120581d,left: 0.10860251001673438d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5328105464308249d,right: 0.4499034258691178d,bottom: 0.3557484136022031d,left: 0.347640169039519d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxbox0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxbox0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxbox0m m
LEFT JOIN public.binary_npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI), typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

