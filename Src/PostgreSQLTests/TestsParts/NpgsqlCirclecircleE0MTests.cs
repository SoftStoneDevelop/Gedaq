

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
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7876075621516875d, y: 0.6823848602113941d), radius: 0.8971999642246223d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31345206010709337d, y: 0.7598295481596175d), radius: 0.26702699232819915d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25062594413999995d, y: 0.818941681194077d), radius: 0.43368970969081266d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34425000101092706d, y: 0.004667264742672206d), radius: 0.8481681349721428d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3710962977961094d, y: 0.8476422065458586d), radius: 0.04125661854369167d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09045907144893905d, y: 0.7574947841614645d), radius: 0.12490158057315859d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6544242528575479d, y: 0.36071526568272094d), radius: 0.9622382824815575d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47190808296053577d, y: 0.8589939644965614d), radius: 0.7920084751592386d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19364503022849133d, y: 0.493005940028445d), radius: 0.19734071260648356d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41642921259579535d, y: 0.03458273746484741d), radius: 0.516570636373937d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3415325646977796d, y: 0.9994304094600338d), radius: 0.09062825082969028d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16338299901857056d, y: 0.9860780053668643d), radius: 0.353453033930356d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47574300913043543d, y: 0.27012862460491605d), radius: 0.4409323495823124d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05195061003088286d, y: 0.27638014470486194d), radius: 0.9234835363764355d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5743063207437735d, y: 0.41914020698341103d), radius: 0.07978571311863825d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6721238786302217d, y: 0.7177422993788567d), radius: 0.7791260014244928d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7053593292982039d, y: 0.00022913897605514322d), radius: 0.3823584962595733d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357794589366751d, y: 0.19498916790564225d), radius: 0.6214905712958415d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7012893586686129d, y: 0.32357199295461236d), radius: 0.07053306578541507d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15761554562403923d, y: 0.2284877866552678d), radius: 0.11314664354970316d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2318878817918788d, y: 0.6101163973344513d), radius: 0.8817583412957793d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.683434022989001d, y: 0.45135898117374895d), radius: 0.844357448732347d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12078567552676378d, y: 0.849676639580518d), radius: 0.35750178400823784d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8317778167952073d, y: 0.5626372616003886d), radius: 0.43919213619753517d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5386499551650827d, y: 0.9619455827387647d), radius: 0.3659667385057044d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20761286533423495d, y: 0.036500436285812676d), radius: 0.010017242913853641d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41766337632628503d, y: 0.5472273687411389d), radius: 0.8756679003845926d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39398163968956423d, y: 0.7766756593443843d), radius: 0.46761327892895566d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42600203657412117d, y: 0.21315200619533092d), radius: 0.25895084382345646d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5791148159626941d, y: 0.020419565256076577d), radius: 0.9032462758077708d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4383829166248714d, y: 0.5811836016422544d), radius: 0.8975486919767933d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6310596921215105d, y: 0.1972724129328386d), radius: 0.11876921114324757d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23603122152229417d, y: 0.34516776368705804d), radius: 0.5135566238217599d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6480639430714761d, y: 0.3669761958920269d), radius: 0.9572620216484264d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28293978057944025d, y: 0.3696564392592927d), radius: 0.05602221800010676d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.85043200753359d, y: 0.7437623319638588d), radius: 0.18206336864949157d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02252840899116726d, y: 0.9399037770048402d), radius: 0.0019319293801367543d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45953024662412034d, y: 0.9547152505421204d), radius: 0.003943941591172395d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8746096647101653d, y: 0.2680013603420439d), radius: 0.24791518492154418d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4280108741104026d, y: 0.8346384938055093d), radius: 0.14394515933747842d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.305371103796636d, y: 0.9240986662470848d), radius: 0.24764429852182368d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6351471906356904d, y: 0.49362465296162117d), radius: 0.31134220618811115d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03345607591080746d, y: 0.45184520195513d), radius: 0.8432065990929287d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7994989903590849d, y: 0.7391909130073936d), radius: 0.06614335092499135d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17585829577720047d, y: 0.5699278451238626d), radius: 0.8296482526649895d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.314262923190885d, y: 0.9958202124055568d), radius: 0.508595151003615d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3570450959649102d, y: 0.18851773332785704d), radius: 0.8398088253122972d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0011280726526220475d, y: 0.7178010592147499d), radius: 0.6503269018239614d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04824681087756333d, y: 0.8399791850465215d), radius: 0.6885329177158596d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7297183980375372d, y: 0.30984366370325633d), radius: 0.24075375761087436d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7759379585588415d, y: 0.9721558299456682d), radius: 0.2825346374142258d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38621231008510726d, y: 0.8419843205512274d), radius: 0.9807171868486925d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0034748477557722257d, y: 0.18588853628260116d), radius: 0.21203102398201357d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12235330574598668d, y: 0.7836940206683706d), radius: 0.2080481822223904d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37174180035042226d, y: 0.7745541141165313d), radius: 0.017182217417884837d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33344461772662937d, y: 0.4503847166993641d), radius: 0.3228354240787985d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7437276917827659d, y: 0.23667289261316893d), radius: 0.39147521900569204d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5633755819051338d, y: 0.8947813937395732d), radius: 0.8959068493011111d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8073091273907386d, y: 0.7323038923366763d), radius: 0.37725602241321465d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6377400693549605d, y: 0.0403885438309306d), radius: 0.007904171798327031d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9978352806724108d, y: 0.93439756247966d), radius: 0.8138481451776702d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11320135303653378d, y: 0.948236311693982d), radius: 0.11516342960695924d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17306352136306624d, y: 0.2007843119283057d), radius: 0.9758986089506181d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4561995647693635d, y: 0.8044988587804948d), radius: 0.04275514728080809d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016551041724772286d, y: 0.19531480656282607d), radius: 0.18586280245850983d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5202208250739708d, y: 0.07522114664454227d), radius: 0.1347392392250777d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27727110369334795d, y: 0.8195292197763723d), radius: 0.2455138167952483d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6006717880262007d, y: 0.7578618739504117d), radius: 0.020979732211689917d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23255235851111922d, y: 0.06460450604405399d), radius: 0.03301807016514846d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4201880339632662d, y: 0.2952093355406885d), radius: 0.4321066123491464d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 169,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8782878572879934d, y: 0.45791177986848686d), radius: 0.9906132955564636d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 175,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9824069148181285d, y: 0.23520206616959827d), radius: 0.8904841662069722d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8867406058514216d, y: 0.8248873866579808d), radius: 0.9362952609805862d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08844667203208312d, y: 0.011105843272759097d), radius: 0.8967507715106279d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 180,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.918580524824213d, y: 0.5805447599463083d), radius: 0.3579227651603153d),
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41642921259579535d, y: 0.03458273746484741d), radius: 0.516570636373937d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05195061003088286d, y: 0.27638014470486194d), radius: 0.9234835363764355d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357794589366751d, y: 0.19498916790564225d), radius: 0.6214905712958415d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5386499551650827d, y: 0.9619455827387647d), radius: 0.3659667385057044d)));
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr1.Value = 148;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 147, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 70, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 147, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 146, query1, 146, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 125, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 153, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 72, query1, 88, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 148, 153))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 81, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[33],_testData[34], false);
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7876075621516875d, y: 0.6823848602113941d), radius: 0.8971999642246223d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31345206010709337d, y: 0.7598295481596175d), radius: 0.26702699232819915d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25062594413999995d, y: 0.818941681194077d), radius: 0.43368970969081266d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34425000101092706d, y: 0.004667264742672206d), radius: 0.8481681349721428d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3710962977961094d, y: 0.8476422065458586d), radius: 0.04125661854369167d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09045907144893905d, y: 0.7574947841614645d), radius: 0.12490158057315859d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6544242528575479d, y: 0.36071526568272094d), radius: 0.9622382824815575d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47190808296053577d, y: 0.8589939644965614d), radius: 0.7920084751592386d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19364503022849133d, y: 0.493005940028445d), radius: 0.19734071260648356d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41642921259579535d, y: 0.03458273746484741d), radius: 0.516570636373937d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3415325646977796d, y: 0.9994304094600338d), radius: 0.09062825082969028d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16338299901857056d, y: 0.9860780053668643d), radius: 0.353453033930356d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47574300913043543d, y: 0.27012862460491605d), radius: 0.4409323495823124d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05195061003088286d, y: 0.27638014470486194d), radius: 0.9234835363764355d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5743063207437735d, y: 0.41914020698341103d), radius: 0.07978571311863825d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6721238786302217d, y: 0.7177422993788567d), radius: 0.7791260014244928d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7053593292982039d, y: 0.00022913897605514322d), radius: 0.3823584962595733d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357794589366751d, y: 0.19498916790564225d), radius: 0.6214905712958415d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7012893586686129d, y: 0.32357199295461236d), radius: 0.07053306578541507d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15761554562403923d, y: 0.2284877866552678d), radius: 0.11314664354970316d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2318878817918788d, y: 0.6101163973344513d), radius: 0.8817583412957793d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.683434022989001d, y: 0.45135898117374895d), radius: 0.844357448732347d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12078567552676378d, y: 0.849676639580518d), radius: 0.35750178400823784d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8317778167952073d, y: 0.5626372616003886d), radius: 0.43919213619753517d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5386499551650827d, y: 0.9619455827387647d), radius: 0.3659667385057044d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20761286533423495d, y: 0.036500436285812676d), radius: 0.010017242913853641d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41766337632628503d, y: 0.5472273687411389d), radius: 0.8756679003845926d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39398163968956423d, y: 0.7766756593443843d), radius: 0.46761327892895566d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42600203657412117d, y: 0.21315200619533092d), radius: 0.25895084382345646d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5791148159626941d, y: 0.020419565256076577d), radius: 0.9032462758077708d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4383829166248714d, y: 0.5811836016422544d), radius: 0.8975486919767933d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6310596921215105d, y: 0.1972724129328386d), radius: 0.11876921114324757d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23603122152229417d, y: 0.34516776368705804d), radius: 0.5135566238217599d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6480639430714761d, y: 0.3669761958920269d), radius: 0.9572620216484264d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28293978057944025d, y: 0.3696564392592927d), radius: 0.05602221800010676d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.85043200753359d, y: 0.7437623319638588d), radius: 0.18206336864949157d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02252840899116726d, y: 0.9399037770048402d), radius: 0.0019319293801367543d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45953024662412034d, y: 0.9547152505421204d), radius: 0.003943941591172395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8746096647101653d, y: 0.2680013603420439d), radius: 0.24791518492154418d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4280108741104026d, y: 0.8346384938055093d), radius: 0.14394515933747842d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.305371103796636d, y: 0.9240986662470848d), radius: 0.24764429852182368d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6351471906356904d, y: 0.49362465296162117d), radius: 0.31134220618811115d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03345607591080746d, y: 0.45184520195513d), radius: 0.8432065990929287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7994989903590849d, y: 0.7391909130073936d), radius: 0.06614335092499135d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17585829577720047d, y: 0.5699278451238626d), radius: 0.8296482526649895d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.314262923190885d, y: 0.9958202124055568d), radius: 0.508595151003615d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3570450959649102d, y: 0.18851773332785704d), radius: 0.8398088253122972d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0011280726526220475d, y: 0.7178010592147499d), radius: 0.6503269018239614d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04824681087756333d, y: 0.8399791850465215d), radius: 0.6885329177158596d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7297183980375372d, y: 0.30984366370325633d), radius: 0.24075375761087436d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7759379585588415d, y: 0.9721558299456682d), radius: 0.2825346374142258d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38621231008510726d, y: 0.8419843205512274d), radius: 0.9807171868486925d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0034748477557722257d, y: 0.18588853628260116d), radius: 0.21203102398201357d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12235330574598668d, y: 0.7836940206683706d), radius: 0.2080481822223904d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37174180035042226d, y: 0.7745541141165313d), radius: 0.017182217417884837d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33344461772662937d, y: 0.4503847166993641d), radius: 0.3228354240787985d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7437276917827659d, y: 0.23667289261316893d), radius: 0.39147521900569204d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5633755819051338d, y: 0.8947813937395732d), radius: 0.8959068493011111d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8073091273907386d, y: 0.7323038923366763d), radius: 0.37725602241321465d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6377400693549605d, y: 0.0403885438309306d), radius: 0.007904171798327031d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9978352806724108d, y: 0.93439756247966d), radius: 0.8138481451776702d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11320135303653378d, y: 0.948236311693982d), radius: 0.11516342960695924d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17306352136306624d, y: 0.2007843119283057d), radius: 0.9758986089506181d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4561995647693635d, y: 0.8044988587804948d), radius: 0.04275514728080809d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016551041724772286d, y: 0.19531480656282607d), radius: 0.18586280245850983d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5202208250739708d, y: 0.07522114664454227d), radius: 0.1347392392250777d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27727110369334795d, y: 0.8195292197763723d), radius: 0.2455138167952483d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6006717880262007d, y: 0.7578618739504117d), radius: 0.020979732211689917d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23255235851111922d, y: 0.06460450604405399d), radius: 0.03301807016514846d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4201880339632662d, y: 0.2952093355406885d), radius: 0.4321066123491464d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8782878572879934d, y: 0.45791177986848686d), radius: 0.9906132955564636d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9824069148181285d, y: 0.23520206616959827d), radius: 0.8904841662069722d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8867406058514216d, y: 0.8248873866579808d), radius: 0.9362952609805862d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08844667203208312d, y: 0.011105843272759097d), radius: 0.8967507715106279d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.918580524824213d, y: 0.5805447599463083d), radius: 0.3579227651603153d))));//Value

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
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7876075621516875d, y: 0.6823848602113941d), radius: 0.8971999642246223d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31345206010709337d, y: 0.7598295481596175d), radius: 0.26702699232819915d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25062594413999995d, y: 0.818941681194077d), radius: 0.43368970969081266d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34425000101092706d, y: 0.004667264742672206d), radius: 0.8481681349721428d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3710962977961094d, y: 0.8476422065458586d), radius: 0.04125661854369167d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09045907144893905d, y: 0.7574947841614645d), radius: 0.12490158057315859d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6544242528575479d, y: 0.36071526568272094d), radius: 0.9622382824815575d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47190808296053577d, y: 0.8589939644965614d), radius: 0.7920084751592386d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19364503022849133d, y: 0.493005940028445d), radius: 0.19734071260648356d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41642921259579535d, y: 0.03458273746484741d), radius: 0.516570636373937d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3415325646977796d, y: 0.9994304094600338d), radius: 0.09062825082969028d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16338299901857056d, y: 0.9860780053668643d), radius: 0.353453033930356d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47574300913043543d, y: 0.27012862460491605d), radius: 0.4409323495823124d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05195061003088286d, y: 0.27638014470486194d), radius: 0.9234835363764355d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5743063207437735d, y: 0.41914020698341103d), radius: 0.07978571311863825d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6721238786302217d, y: 0.7177422993788567d), radius: 0.7791260014244928d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7053593292982039d, y: 0.00022913897605514322d), radius: 0.3823584962595733d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357794589366751d, y: 0.19498916790564225d), radius: 0.6214905712958415d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7012893586686129d, y: 0.32357199295461236d), radius: 0.07053306578541507d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15761554562403923d, y: 0.2284877866552678d), radius: 0.11314664354970316d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2318878817918788d, y: 0.6101163973344513d), radius: 0.8817583412957793d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.683434022989001d, y: 0.45135898117374895d), radius: 0.844357448732347d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12078567552676378d, y: 0.849676639580518d), radius: 0.35750178400823784d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8317778167952073d, y: 0.5626372616003886d), radius: 0.43919213619753517d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5386499551650827d, y: 0.9619455827387647d), radius: 0.3659667385057044d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20761286533423495d, y: 0.036500436285812676d), radius: 0.010017242913853641d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41766337632628503d, y: 0.5472273687411389d), radius: 0.8756679003845926d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39398163968956423d, y: 0.7766756593443843d), radius: 0.46761327892895566d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42600203657412117d, y: 0.21315200619533092d), radius: 0.25895084382345646d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5791148159626941d, y: 0.020419565256076577d), radius: 0.9032462758077708d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4383829166248714d, y: 0.5811836016422544d), radius: 0.8975486919767933d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6310596921215105d, y: 0.1972724129328386d), radius: 0.11876921114324757d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23603122152229417d, y: 0.34516776368705804d), radius: 0.5135566238217599d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6480639430714761d, y: 0.3669761958920269d), radius: 0.9572620216484264d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28293978057944025d, y: 0.3696564392592927d), radius: 0.05602221800010676d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.85043200753359d, y: 0.7437623319638588d), radius: 0.18206336864949157d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02252840899116726d, y: 0.9399037770048402d), radius: 0.0019319293801367543d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45953024662412034d, y: 0.9547152505421204d), radius: 0.003943941591172395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8746096647101653d, y: 0.2680013603420439d), radius: 0.24791518492154418d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4280108741104026d, y: 0.8346384938055093d), radius: 0.14394515933747842d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.305371103796636d, y: 0.9240986662470848d), radius: 0.24764429852182368d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6351471906356904d, y: 0.49362465296162117d), radius: 0.31134220618811115d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03345607591080746d, y: 0.45184520195513d), radius: 0.8432065990929287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7994989903590849d, y: 0.7391909130073936d), radius: 0.06614335092499135d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17585829577720047d, y: 0.5699278451238626d), radius: 0.8296482526649895d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.314262923190885d, y: 0.9958202124055568d), radius: 0.508595151003615d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3570450959649102d, y: 0.18851773332785704d), radius: 0.8398088253122972d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0011280726526220475d, y: 0.7178010592147499d), radius: 0.6503269018239614d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04824681087756333d, y: 0.8399791850465215d), radius: 0.6885329177158596d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7297183980375372d, y: 0.30984366370325633d), radius: 0.24075375761087436d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7759379585588415d, y: 0.9721558299456682d), radius: 0.2825346374142258d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38621231008510726d, y: 0.8419843205512274d), radius: 0.9807171868486925d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0034748477557722257d, y: 0.18588853628260116d), radius: 0.21203102398201357d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12235330574598668d, y: 0.7836940206683706d), radius: 0.2080481822223904d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37174180035042226d, y: 0.7745541141165313d), radius: 0.017182217417884837d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33344461772662937d, y: 0.4503847166993641d), radius: 0.3228354240787985d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7437276917827659d, y: 0.23667289261316893d), radius: 0.39147521900569204d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5633755819051338d, y: 0.8947813937395732d), radius: 0.8959068493011111d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8073091273907386d, y: 0.7323038923366763d), radius: 0.37725602241321465d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6377400693549605d, y: 0.0403885438309306d), radius: 0.007904171798327031d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9978352806724108d, y: 0.93439756247966d), radius: 0.8138481451776702d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11320135303653378d, y: 0.948236311693982d), radius: 0.11516342960695924d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17306352136306624d, y: 0.2007843119283057d), radius: 0.9758986089506181d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4561995647693635d, y: 0.8044988587804948d), radius: 0.04275514728080809d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016551041724772286d, y: 0.19531480656282607d), radius: 0.18586280245850983d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5202208250739708d, y: 0.07522114664454227d), radius: 0.1347392392250777d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27727110369334795d, y: 0.8195292197763723d), radius: 0.2455138167952483d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6006717880262007d, y: 0.7578618739504117d), radius: 0.020979732211689917d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23255235851111922d, y: 0.06460450604405399d), radius: 0.03301807016514846d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4201880339632662d, y: 0.2952093355406885d), radius: 0.4321066123491464d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8782878572879934d, y: 0.45791177986848686d), radius: 0.9906132955564636d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9824069148181285d, y: 0.23520206616959827d), radius: 0.8904841662069722d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8867406058514216d, y: 0.8248873866579808d), radius: 0.9362952609805862d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08844667203208312d, y: 0.011105843272759097d), radius: 0.8967507715106279d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.918580524824213d, y: 0.5805447599463083d), radius: 0.3579227651603153d))));//Value

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

