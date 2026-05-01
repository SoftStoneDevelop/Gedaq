

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
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9708653379230033d, y: 0.7453872884959797d), radius: 0.49036523531204324d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2558697763594031d, y: 0.42746173512935937d), radius: 0.8117838863723266d),
},
            new NpgsqlCirclecircle0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.963558789043092d, y: 0.620742780436634d), radius: 0.8666551852676789d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.780604017244773d, y: 0.8004961335912498d), radius: 0.47405938966129935d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2477427263189662d, y: 0.2750835656670223d), radius: 0.7894910284754841d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5259483491351133d, y: 0.9161393094531323d), radius: 0.8327770872057908d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8207439753077416d, y: 0.7609766724633934d), radius: 0.4392740265222522d),
},
            new NpgsqlCirclecircle0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3727992856746877d, y: 0.1283325122295057d), radius: 0.8449566486441903d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09571382602911216d, y: 0.15480248334977598d), radius: 0.1928289704394911d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3710883577180102d, y: 0.8863623793613775d), radius: 0.19908530684640435d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8734324811390929d, y: 0.15629258887627384d), radius: 0.47675849768203105d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29368477297018036d, y: 0.4905833069838078d), radius: 0.4210441952624623d),
},
            new NpgsqlCirclecircle0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9969072708945972d, y: 0.5558983785570955d), radius: 0.27958424976243257d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2767936073801045d, y: 0.14668275855084156d), radius: 0.8615102744556128d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5024100451521794d, y: 0.9061258952773696d), radius: 0.19133005509323187d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12118051031822918d, y: 0.30902245671370443d), radius: 0.7970631606015973d),
},
            new NpgsqlCirclecircle0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8199446582182791d, y: 0.34197529523102843d), radius: 0.8674315491833804d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5147136014829458d, y: 0.16453159262624206d), radius: 0.4494893231903815d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8783327758155098d, y: 0.3885290887833952d), radius: 0.9459351567563341d),
},
            new NpgsqlCirclecircle0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3729710188148828d, y: 0.8311359763146089d), radius: 0.20645527326399393d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5402939208563258d, y: 0.02092624448392555d), radius: 0.14421288788330355d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.270088895079161d, y: 0.998926645556963d), radius: 0.20841802158298217d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8548270646766499d, y: 0.028202896333106353d), radius: 0.24490888949650236d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7569272587466935d, y: 0.4061308575392144d), radius: 0.02206430382810931d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7103800028074425d, y: 0.13131814328578106d), radius: 0.3748254368361259d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6198890912189496d, y: 0.02503124760082709d), radius: 0.7769968789611024d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7623189661848097d, y: 0.8464997584232363d), radius: 0.6676423743759663d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34238981000005186d, y: 0.7803588607605231d), radius: 0.38090333188934866d),
},
            new NpgsqlCirclecircle0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9679185080597996d, y: 0.5196630333311761d), radius: 0.9365693116525962d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24602873190528818d, y: 0.5396483026766046d), radius: 0.7507559253756864d),
},
            new NpgsqlCirclecircle0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.505281824865141d, y: 0.952620718021634d), radius: 0.6620479014954407d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7779933353572129d, y: 0.5945856111814319d), radius: 0.7022688563955798d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6873721826583217d, y: 0.3944003890009199d), radius: 0.09534448411530072d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45460879874733917d, y: 0.5314676523430188d), radius: 0.5325966152559283d),
},
            new NpgsqlCirclecircle0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7987908303263457d, y: 0.09381352035828494d), radius: 0.9227618188224039d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5732182559199898d, y: 0.23475839654107133d), radius: 0.12693298194404512d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37258359209292524d, y: 0.5455696485895952d), radius: 0.8820792589823736d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47955852403527344d, y: 0.7619195466651496d), radius: 0.3273983735860464d),
},
            new NpgsqlCirclecircle0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.606804900074749d, y: 0.4315887662875345d), radius: 0.770209059361695d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.843158447408196d, y: 0.7974104806646636d), radius: 0.8622012016197107d),
},
            new NpgsqlCirclecircle0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2062052606306356d, y: 0.2828557397542045d), radius: 0.7574286886340045d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6242347779675276d, y: 0.4774358774619919d), radius: 0.5731656803274464d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6488046231925546d, y: 0.37795581791682453d), radius: 0.8120961756363967d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7974245356149096d, y: 0.3361060572053203d), radius: 0.8509288966154328d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19251713775275237d, y: 0.16697113928060447d), radius: 0.9778367227539797d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4728588958672415d, y: 0.2452240271477366d), radius: 0.3516813465479032d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9922211638372811d, y: 0.6813367265006967d), radius: 0.9123166921245379d),
},
            new NpgsqlCirclecircle0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.65101728682412d, y: 0.6405991149486528d), radius: 0.09423985342286689d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7344843554743757d, y: 0.37751536356667326d), radius: 0.20570342914409256d),
},
            new NpgsqlCirclecircle0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9320418045260246d, y: 0.7729568716608655d), radius: 0.960221832359473d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2557873092820957d, y: 0.5653977010808199d), radius: 0.6491512194430917d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027720514397848173d, y: 0.844908569797016d), radius: 0.8957974965750435d),
},
            new NpgsqlCirclecircle0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14903756624384545d, y: 0.597844716597874d), radius: 0.05832849673479401d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6151414380716363d, y: 0.8951631098818194d), radius: 0.7833183366085247d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.631610768758196d, y: 0.14137363164658057d), radius: 0.9251987421869202d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5365586686483822d, y: 0.9678364029377129d), radius: 0.33045367573330164d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5859199856694739d, y: 0.8350877596662751d), radius: 0.3694774000801728d),
},
            new NpgsqlCirclecircle0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18280425952542168d, y: 0.9540942388018271d), radius: 0.958219369299743d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43959818177462695d, y: 0.5406000303968505d), radius: 0.3413025948988313d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24770067718959776d, y: 0.7396514084285676d), radius: 0.27091637673888436d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37669037672018535d, y: 0.8581110126025382d), radius: 0.4062909389895495d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5549516217792292d, y: 0.3934823571818301d), radius: 0.2570207227965091d),
},
            new NpgsqlCirclecircle0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04554040552261196d, y: 0.8464272693944371d), radius: 0.49667203927448444d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01840820717884628d, y: 0.43328923116255547d), radius: 0.36107825107689817d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357088336582297d, y: 0.1291586148416246d), radius: 0.14774121752598202d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4012964436552444d, y: 0.3531562476001253d), radius: 0.6926459601409618d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15901448682802877d, y: 0.14169342820233577d), radius: 0.9505068988910945d),
},
            new NpgsqlCirclecircle0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6867517943477972d, y: 0.09398362763464874d), radius: 0.28991420120167954d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27076442717586835d, y: 0.8888665327160775d), radius: 0.9938812917086894d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41015401289593423d, y: 0.6973813087505466d), radius: 0.14367161794074657d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32667154613653415d, y: 0.4702985747281532d), radius: 0.640878184531672d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7694688940861757d, y: 0.9034973952121502d), radius: 0.7243140940012989d),
},
            new NpgsqlCirclecircle0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2559413409127508d, y: 0.5563066122457279d), radius: 0.7900837742577206d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8582091937013199d, y: 0.4985476485479403d), radius: 0.6953997893774585d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.660941472939465d, y: 0.5983312690539742d), radius: 0.2857284564784951d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 178,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0795562406606175d, y: 0.5106127237208912d), radius: 0.04220737357729465d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 182,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4251258375697414d, y: 0.43654906250259884d), radius: 0.7714425158111846d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8578645600480511d, y: 0.5717491500839446d), radius: 0.6475302581460886d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 188,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7916643217304716d, y: 0.662307303914133d), radius: 0.022242556222375143d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.905324607864316d, y: 0.05739649786731604d), radius: 0.14610624792925708d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29368477297018036d, y: 0.4905833069838078d), radius: 0.4210441952624623d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12118051031822918d, y: 0.30902245671370443d), radius: 0.7970631606015973d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8783327758155098d, y: 0.3885290887833952d), radius: 0.9459351567563341d)));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34238981000005186d, y: 0.7803588607605231d), radius: 0.38090333188934866d)));
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 178;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[34], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 178;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 167, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 36, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 105, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 167, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 178, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 62, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 136, query1, 40, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 40, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 133, 171))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[34], false);
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
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 31);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[8], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[9], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[10], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[11], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[12], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[13], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[14], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[15], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[16], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[17], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[18], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[19], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[20], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[21], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[22], false);
                NpgsqlCirclecircle0M.AssertModel(models[15],_testData[23], false);
                NpgsqlCirclecircle0M.AssertModel(models[16],_testData[24], false);
                NpgsqlCirclecircle0M.AssertModel(models[17],_testData[25], false);
                NpgsqlCirclecircle0M.AssertModel(models[18],_testData[26], false);
                NpgsqlCirclecircle0M.AssertModel(models[19],_testData[27], false);
                NpgsqlCirclecircle0M.AssertModel(models[20],_testData[28], false);
                NpgsqlCirclecircle0M.AssertModel(models[21],_testData[29], false);
                NpgsqlCirclecircle0M.AssertModel(models[22],_testData[30], false);
                NpgsqlCirclecircle0M.AssertModel(models[23],_testData[31], false);
                NpgsqlCirclecircle0M.AssertModel(models[24],_testData[32], false);
                NpgsqlCirclecircle0M.AssertModel(models[25],_testData[33], false);
                NpgsqlCirclecircle0M.AssertModel(models[26],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9708653379230033d, y: 0.7453872884959797d), radius: 0.49036523531204324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2558697763594031d, y: 0.42746173512935937d), radius: 0.8117838863723266d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.963558789043092d, y: 0.620742780436634d), radius: 0.8666551852676789d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.780604017244773d, y: 0.8004961335912498d), radius: 0.47405938966129935d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2477427263189662d, y: 0.2750835656670223d), radius: 0.7894910284754841d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5259483491351133d, y: 0.9161393094531323d), radius: 0.8327770872057908d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8207439753077416d, y: 0.7609766724633934d), radius: 0.4392740265222522d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3727992856746877d, y: 0.1283325122295057d), radius: 0.8449566486441903d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09571382602911216d, y: 0.15480248334977598d), radius: 0.1928289704394911d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3710883577180102d, y: 0.8863623793613775d), radius: 0.19908530684640435d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8734324811390929d, y: 0.15629258887627384d), radius: 0.47675849768203105d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29368477297018036d, y: 0.4905833069838078d), radius: 0.4210441952624623d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9969072708945972d, y: 0.5558983785570955d), radius: 0.27958424976243257d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2767936073801045d, y: 0.14668275855084156d), radius: 0.8615102744556128d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5024100451521794d, y: 0.9061258952773696d), radius: 0.19133005509323187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12118051031822918d, y: 0.30902245671370443d), radius: 0.7970631606015973d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8199446582182791d, y: 0.34197529523102843d), radius: 0.8674315491833804d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5147136014829458d, y: 0.16453159262624206d), radius: 0.4494893231903815d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8783327758155098d, y: 0.3885290887833952d), radius: 0.9459351567563341d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3729710188148828d, y: 0.8311359763146089d), radius: 0.20645527326399393d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5402939208563258d, y: 0.02092624448392555d), radius: 0.14421288788330355d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.270088895079161d, y: 0.998926645556963d), radius: 0.20841802158298217d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8548270646766499d, y: 0.028202896333106353d), radius: 0.24490888949650236d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7569272587466935d, y: 0.4061308575392144d), radius: 0.02206430382810931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7103800028074425d, y: 0.13131814328578106d), radius: 0.3748254368361259d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6198890912189496d, y: 0.02503124760082709d), radius: 0.7769968789611024d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7623189661848097d, y: 0.8464997584232363d), radius: 0.6676423743759663d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34238981000005186d, y: 0.7803588607605231d), radius: 0.38090333188934866d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9679185080597996d, y: 0.5196630333311761d), radius: 0.9365693116525962d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24602873190528818d, y: 0.5396483026766046d), radius: 0.7507559253756864d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.505281824865141d, y: 0.952620718021634d), radius: 0.6620479014954407d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7779933353572129d, y: 0.5945856111814319d), radius: 0.7022688563955798d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6873721826583217d, y: 0.3944003890009199d), radius: 0.09534448411530072d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45460879874733917d, y: 0.5314676523430188d), radius: 0.5325966152559283d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7987908303263457d, y: 0.09381352035828494d), radius: 0.9227618188224039d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5732182559199898d, y: 0.23475839654107133d), radius: 0.12693298194404512d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37258359209292524d, y: 0.5455696485895952d), radius: 0.8820792589823736d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47955852403527344d, y: 0.7619195466651496d), radius: 0.3273983735860464d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.606804900074749d, y: 0.4315887662875345d), radius: 0.770209059361695d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.843158447408196d, y: 0.7974104806646636d), radius: 0.8622012016197107d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2062052606306356d, y: 0.2828557397542045d), radius: 0.7574286886340045d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6242347779675276d, y: 0.4774358774619919d), radius: 0.5731656803274464d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6488046231925546d, y: 0.37795581791682453d), radius: 0.8120961756363967d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7974245356149096d, y: 0.3361060572053203d), radius: 0.8509288966154328d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19251713775275237d, y: 0.16697113928060447d), radius: 0.9778367227539797d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4728588958672415d, y: 0.2452240271477366d), radius: 0.3516813465479032d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9922211638372811d, y: 0.6813367265006967d), radius: 0.9123166921245379d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.65101728682412d, y: 0.6405991149486528d), radius: 0.09423985342286689d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7344843554743757d, y: 0.37751536356667326d), radius: 0.20570342914409256d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9320418045260246d, y: 0.7729568716608655d), radius: 0.960221832359473d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2557873092820957d, y: 0.5653977010808199d), radius: 0.6491512194430917d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027720514397848173d, y: 0.844908569797016d), radius: 0.8957974965750435d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14903756624384545d, y: 0.597844716597874d), radius: 0.05832849673479401d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6151414380716363d, y: 0.8951631098818194d), radius: 0.7833183366085247d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.631610768758196d, y: 0.14137363164658057d), radius: 0.9251987421869202d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5365586686483822d, y: 0.9678364029377129d), radius: 0.33045367573330164d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5859199856694739d, y: 0.8350877596662751d), radius: 0.3694774000801728d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18280425952542168d, y: 0.9540942388018271d), radius: 0.958219369299743d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43959818177462695d, y: 0.5406000303968505d), radius: 0.3413025948988313d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24770067718959776d, y: 0.7396514084285676d), radius: 0.27091637673888436d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37669037672018535d, y: 0.8581110126025382d), radius: 0.4062909389895495d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5549516217792292d, y: 0.3934823571818301d), radius: 0.2570207227965091d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04554040552261196d, y: 0.8464272693944371d), radius: 0.49667203927448444d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01840820717884628d, y: 0.43328923116255547d), radius: 0.36107825107689817d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357088336582297d, y: 0.1291586148416246d), radius: 0.14774121752598202d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4012964436552444d, y: 0.3531562476001253d), radius: 0.6926459601409618d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15901448682802877d, y: 0.14169342820233577d), radius: 0.9505068988910945d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6867517943477972d, y: 0.09398362763464874d), radius: 0.28991420120167954d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27076442717586835d, y: 0.8888665327160775d), radius: 0.9938812917086894d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41015401289593423d, y: 0.6973813087505466d), radius: 0.14367161794074657d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32667154613653415d, y: 0.4702985747281532d), radius: 0.640878184531672d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7694688940861757d, y: 0.9034973952121502d), radius: 0.7243140940012989d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2559413409127508d, y: 0.5563066122457279d), radius: 0.7900837742577206d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8582091937013199d, y: 0.4985476485479403d), radius: 0.6953997893774585d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.660941472939465d, y: 0.5983312690539742d), radius: 0.2857284564784951d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0795562406606175d, y: 0.5106127237208912d), radius: 0.04220737357729465d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4251258375697414d, y: 0.43654906250259884d), radius: 0.7714425158111846d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8578645600480511d, y: 0.5717491500839446d), radius: 0.6475302581460886d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7916643217304716d, y: 0.662307303914133d), radius: 0.022242556222375143d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.905324607864316d, y: 0.05739649786731604d), radius: 0.14610624792925708d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9708653379230033d, y: 0.7453872884959797d), radius: 0.49036523531204324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2558697763594031d, y: 0.42746173512935937d), radius: 0.8117838863723266d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.963558789043092d, y: 0.620742780436634d), radius: 0.8666551852676789d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.780604017244773d, y: 0.8004961335912498d), radius: 0.47405938966129935d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2477427263189662d, y: 0.2750835656670223d), radius: 0.7894910284754841d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5259483491351133d, y: 0.9161393094531323d), radius: 0.8327770872057908d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8207439753077416d, y: 0.7609766724633934d), radius: 0.4392740265222522d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3727992856746877d, y: 0.1283325122295057d), radius: 0.8449566486441903d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09571382602911216d, y: 0.15480248334977598d), radius: 0.1928289704394911d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3710883577180102d, y: 0.8863623793613775d), radius: 0.19908530684640435d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8734324811390929d, y: 0.15629258887627384d), radius: 0.47675849768203105d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29368477297018036d, y: 0.4905833069838078d), radius: 0.4210441952624623d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9969072708945972d, y: 0.5558983785570955d), radius: 0.27958424976243257d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2767936073801045d, y: 0.14668275855084156d), radius: 0.8615102744556128d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5024100451521794d, y: 0.9061258952773696d), radius: 0.19133005509323187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12118051031822918d, y: 0.30902245671370443d), radius: 0.7970631606015973d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8199446582182791d, y: 0.34197529523102843d), radius: 0.8674315491833804d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5147136014829458d, y: 0.16453159262624206d), radius: 0.4494893231903815d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8783327758155098d, y: 0.3885290887833952d), radius: 0.9459351567563341d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3729710188148828d, y: 0.8311359763146089d), radius: 0.20645527326399393d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5402939208563258d, y: 0.02092624448392555d), radius: 0.14421288788330355d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.270088895079161d, y: 0.998926645556963d), radius: 0.20841802158298217d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8548270646766499d, y: 0.028202896333106353d), radius: 0.24490888949650236d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7569272587466935d, y: 0.4061308575392144d), radius: 0.02206430382810931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7103800028074425d, y: 0.13131814328578106d), radius: 0.3748254368361259d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6198890912189496d, y: 0.02503124760082709d), radius: 0.7769968789611024d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7623189661848097d, y: 0.8464997584232363d), radius: 0.6676423743759663d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34238981000005186d, y: 0.7803588607605231d), radius: 0.38090333188934866d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9679185080597996d, y: 0.5196630333311761d), radius: 0.9365693116525962d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24602873190528818d, y: 0.5396483026766046d), radius: 0.7507559253756864d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.505281824865141d, y: 0.952620718021634d), radius: 0.6620479014954407d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7779933353572129d, y: 0.5945856111814319d), radius: 0.7022688563955798d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6873721826583217d, y: 0.3944003890009199d), radius: 0.09534448411530072d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45460879874733917d, y: 0.5314676523430188d), radius: 0.5325966152559283d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7987908303263457d, y: 0.09381352035828494d), radius: 0.9227618188224039d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5732182559199898d, y: 0.23475839654107133d), radius: 0.12693298194404512d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37258359209292524d, y: 0.5455696485895952d), radius: 0.8820792589823736d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47955852403527344d, y: 0.7619195466651496d), radius: 0.3273983735860464d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.606804900074749d, y: 0.4315887662875345d), radius: 0.770209059361695d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.843158447408196d, y: 0.7974104806646636d), radius: 0.8622012016197107d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2062052606306356d, y: 0.2828557397542045d), radius: 0.7574286886340045d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6242347779675276d, y: 0.4774358774619919d), radius: 0.5731656803274464d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6488046231925546d, y: 0.37795581791682453d), radius: 0.8120961756363967d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7974245356149096d, y: 0.3361060572053203d), radius: 0.8509288966154328d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19251713775275237d, y: 0.16697113928060447d), radius: 0.9778367227539797d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4728588958672415d, y: 0.2452240271477366d), radius: 0.3516813465479032d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9922211638372811d, y: 0.6813367265006967d), radius: 0.9123166921245379d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.65101728682412d, y: 0.6405991149486528d), radius: 0.09423985342286689d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7344843554743757d, y: 0.37751536356667326d), radius: 0.20570342914409256d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9320418045260246d, y: 0.7729568716608655d), radius: 0.960221832359473d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2557873092820957d, y: 0.5653977010808199d), radius: 0.6491512194430917d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027720514397848173d, y: 0.844908569797016d), radius: 0.8957974965750435d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14903756624384545d, y: 0.597844716597874d), radius: 0.05832849673479401d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6151414380716363d, y: 0.8951631098818194d), radius: 0.7833183366085247d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.631610768758196d, y: 0.14137363164658057d), radius: 0.9251987421869202d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5365586686483822d, y: 0.9678364029377129d), radius: 0.33045367573330164d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5859199856694739d, y: 0.8350877596662751d), radius: 0.3694774000801728d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18280425952542168d, y: 0.9540942388018271d), radius: 0.958219369299743d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43959818177462695d, y: 0.5406000303968505d), radius: 0.3413025948988313d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24770067718959776d, y: 0.7396514084285676d), radius: 0.27091637673888436d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37669037672018535d, y: 0.8581110126025382d), radius: 0.4062909389895495d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5549516217792292d, y: 0.3934823571818301d), radius: 0.2570207227965091d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04554040552261196d, y: 0.8464272693944371d), radius: 0.49667203927448444d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01840820717884628d, y: 0.43328923116255547d), radius: 0.36107825107689817d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357088336582297d, y: 0.1291586148416246d), radius: 0.14774121752598202d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4012964436552444d, y: 0.3531562476001253d), radius: 0.6926459601409618d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15901448682802877d, y: 0.14169342820233577d), radius: 0.9505068988910945d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6867517943477972d, y: 0.09398362763464874d), radius: 0.28991420120167954d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27076442717586835d, y: 0.8888665327160775d), radius: 0.9938812917086894d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41015401289593423d, y: 0.6973813087505466d), radius: 0.14367161794074657d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32667154613653415d, y: 0.4702985747281532d), radius: 0.640878184531672d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7694688940861757d, y: 0.9034973952121502d), radius: 0.7243140940012989d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2559413409127508d, y: 0.5563066122457279d), radius: 0.7900837742577206d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8582091937013199d, y: 0.4985476485479403d), radius: 0.6953997893774585d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.660941472939465d, y: 0.5983312690539742d), radius: 0.2857284564784951d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0795562406606175d, y: 0.5106127237208912d), radius: 0.04220737357729465d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4251258375697414d, y: 0.43654906250259884d), radius: 0.7714425158111846d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8578645600480511d, y: 0.5717491500839446d), radius: 0.6475302581460886d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7916643217304716d, y: 0.662307303914133d), radius: 0.022242556222375143d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.905324607864316d, y: 0.05739649786731604d), radius: 0.14610624792925708d))));

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

