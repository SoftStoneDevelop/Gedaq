

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
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6980644534546879d, y: 0.46238124081780885d), radius: 0.7883068702929266d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.421163974346066d, y: 0.3395090517292153d), radius: 0.5760868473650967d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8333273495392279d, y: 0.2597683143437871d), radius: 0.07350892196893244d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.795971832013143d, y: 0.0821783781048202d), radius: 0.7591063313067252d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9308013607768876d, y: 0.4675550800107271d), radius: 0.8832570851110958d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5538746551917318d, y: 0.3603811977409992d), radius: 0.0770398965823006d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5649050183898802d, y: 0.7808448387210742d), radius: 0.23327638490521185d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2612794321590588d, y: 0.9984919801173863d), radius: 0.43821651705277553d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9185024463208608d, y: 0.32884118090314884d), radius: 0.9679036788848918d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9583743437154164d, y: 0.4879619468287717d), radius: 0.9183763784907386d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14335901952386432d, y: 0.679366402417147d), radius: 0.7277548266940995d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5706288050948324d, y: 0.7805736942574104d), radius: 0.4160870045491807d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8215826535439492d, y: 0.9415501967320533d), radius: 0.19618611599483493d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7366568235799371d, y: 0.07502164365489139d), radius: 0.47859600553683823d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13793332265516633d, y: 0.819773112438694d), radius: 0.8119477238773828d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09374597764163672d, y: 0.4941826553019528d), radius: 0.30411964528995905d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48361251923333637d, y: 0.2462417045677231d), radius: 0.46856421352008704d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.865036453149867d, y: 0.42867531312848495d), radius: 0.7222474614223449d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2987664123440287d, y: 0.07173525405527448d), radius: 0.887205753984236d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6687273314892158d, y: 0.6173683563469545d), radius: 0.5854029411601845d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3486020434743158d, y: 0.6847894689007203d), radius: 0.9919077407175414d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21866699802149503d, y: 0.47851161455855296d), radius: 0.006654921512594725d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9666841159407441d, y: 0.5383358786259348d), radius: 0.35485022275479006d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4842165366874389d, y: 0.15997157617416635d), radius: 0.2555509945705118d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.053806940808431736d, y: 0.7893817680274873d), radius: 0.7440001229769564d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9146997065808141d, y: 0.7747809996561713d), radius: 0.03173319002495789d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17683774302978217d, y: 0.4245404274597179d), radius: 0.8356404697855752d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6815703554391634d, y: 0.6571695098463496d), radius: 0.7666914389770363d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6540844829055477d, y: 0.7468183827777743d), radius: 0.7942671690409734d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9881564369168815d, y: 0.7933615909041417d), radius: 0.1680322542221251d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22308531370613294d, y: 0.18091585024575307d), radius: 0.5585770596247145d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.760553334882753d, y: 0.1172545099931559d), radius: 0.39582626365091933d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9657519765910743d, y: 0.9978319926313587d), radius: 0.9645055775075826d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7216224417173204d, y: 0.2489298472178444d), radius: 0.7310862719773507d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.353932070853767d, y: 0.07712661976780433d), radius: 0.7350132278671292d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9032483137677693d, y: 0.6132877198612388d), radius: 0.13571375815157116d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025404564043446043d, y: 0.24206738339996947d), radius: 0.29836629833394446d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6444361583432466d, y: 0.48337032201817254d), radius: 0.4249779442020559d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9636328077925972d, y: 0.4482263352335899d), radius: 0.7445578034214456d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5782360147486603d, y: 0.39265401458720484d), radius: 0.7605693165505246d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12299611951128897d, y: 0.9895708485809279d), radius: 0.4249879646618878d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5069256485796888d, y: 0.8483327286566131d), radius: 0.20993936756690967d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3282678553172994d, y: 0.5345863295247878d), radius: 0.5551304327829535d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39748403980888003d, y: 0.3056877303114647d), radius: 0.7647497334193574d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.814907179284035d, y: 0.8552888074845019d), radius: 0.8810206206761277d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9509538732667475d, y: 0.41183230760309186d), radius: 0.4618270788470291d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3700103678505575d, y: 0.1807298931195631d), radius: 0.455770346615885d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2084656688837344d, y: 0.009626064525608102d), radius: 0.43129497823738205d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3882931655057613d, y: 0.29036737561830384d), radius: 0.030161573636658168d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8252368821457665d, y: 0.14286646561247673d), radius: 0.8991384497900525d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8616705330497743d, y: 0.11726073521329128d), radius: 0.4692102904726291d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8029453669804767d, y: 0.2749163097876054d), radius: 0.04092678400134109d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3680502879263944d, y: 0.3069483544301882d), radius: 0.14198809018728842d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3769632568501453d, y: 0.3220489841375552d), radius: 0.9334042587493915d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7136492972764215d, y: 0.829020774669617d), radius: 0.8113030131369307d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3921145865814518d, y: 0.7294690881637125d), radius: 0.6613366934211795d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9553699362911461d, y: 0.6732082007708757d), radius: 0.4799973273459194d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5637751718518774d, y: 0.0044162673771538374d), radius: 0.31683056020796174d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25248050092964935d, y: 0.04759975703007768d), radius: 0.623356125740057d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9222043807499041d, y: 0.3675158697140487d), radius: 0.839145481008041d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32099529811819383d, y: 0.8725363356399217d), radius: 0.10115347386317997d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05067707797618293d, y: 0.7247144810170196d), radius: 0.6785302122250528d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24616150728481279d, y: 0.8449985526757419d), radius: 0.3524757938947938d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.578323322906375d, y: 0.49206227091925325d), radius: 0.33618236653410793d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8494335565448551d, y: 0.8602823368929935d), radius: 0.9265821834540112d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7324102750395808d, y: 0.4955951799666817d), radius: 0.7078262522439633d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5550704181005511d, y: 0.7047527484938735d), radius: 0.0787329013104906d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38498669900289395d, y: 0.6585665350541379d), radius: 0.9089740789986281d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9299698569502266d, y: 0.5710609963172244d), radius: 0.3470614878071555d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10054630981936352d, y: 0.9362468949933599d), radius: 0.09112903189595001d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7921107135774491d, y: 0.6829914998290527d), radius: 0.7529804584755121d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1380958952266771d, y: 0.7653257190707583d), radius: 0.24040530320757003d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 176,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.529082360771979d, y: 0.9593097834713002d), radius: 0.2767478147120589d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 181,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8181206573390276d, y: 0.6242439386209602d), radius: 0.08801231664185627d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40329482898788027d, y: 0.9960004460650921d), radius: 0.2651597493480432d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 185,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6630729492295812d, y: 0.24166472033530628d), radius: 0.0574123137543211d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3846866888434328d, y: 0.9443232076830508d), radius: 0.687462886043626d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14335901952386432d, y: 0.679366402417147d), radius: 0.7277548266940995d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7366568235799371d, y: 0.07502164365489139d), radius: 0.47859600553683823d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09374597764163672d, y: 0.4941826553019528d), radius: 0.30411964528995905d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.053806940808431736d, y: 0.7893817680274873d), radius: 0.7440001229769564d)));
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 137, query1, 176, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 107, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[30],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[31],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 84, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[30],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 96, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 4, query1, 155, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[33],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 59, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 150, 79))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 84, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[34], false);
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
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 176);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[22], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[23], false);
                NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[24], false);
                NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[25], false);
                NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[26], false);
                NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[27], false);
                NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[28], false);
                NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[29], false);
                NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[30], false);
                NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[31], false);
                NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[32], false);
                NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6980644534546879d, y: 0.46238124081780885d), radius: 0.7883068702929266d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.421163974346066d, y: 0.3395090517292153d), radius: 0.5760868473650967d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8333273495392279d, y: 0.2597683143437871d), radius: 0.07350892196893244d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.795971832013143d, y: 0.0821783781048202d), radius: 0.7591063313067252d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9308013607768876d, y: 0.4675550800107271d), radius: 0.8832570851110958d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5538746551917318d, y: 0.3603811977409992d), radius: 0.0770398965823006d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5649050183898802d, y: 0.7808448387210742d), radius: 0.23327638490521185d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2612794321590588d, y: 0.9984919801173863d), radius: 0.43821651705277553d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9185024463208608d, y: 0.32884118090314884d), radius: 0.9679036788848918d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9583743437154164d, y: 0.4879619468287717d), radius: 0.9183763784907386d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14335901952386432d, y: 0.679366402417147d), radius: 0.7277548266940995d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5706288050948324d, y: 0.7805736942574104d), radius: 0.4160870045491807d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8215826535439492d, y: 0.9415501967320533d), radius: 0.19618611599483493d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7366568235799371d, y: 0.07502164365489139d), radius: 0.47859600553683823d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13793332265516633d, y: 0.819773112438694d), radius: 0.8119477238773828d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09374597764163672d, y: 0.4941826553019528d), radius: 0.30411964528995905d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48361251923333637d, y: 0.2462417045677231d), radius: 0.46856421352008704d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.865036453149867d, y: 0.42867531312848495d), radius: 0.7222474614223449d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2987664123440287d, y: 0.07173525405527448d), radius: 0.887205753984236d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6687273314892158d, y: 0.6173683563469545d), radius: 0.5854029411601845d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3486020434743158d, y: 0.6847894689007203d), radius: 0.9919077407175414d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21866699802149503d, y: 0.47851161455855296d), radius: 0.006654921512594725d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9666841159407441d, y: 0.5383358786259348d), radius: 0.35485022275479006d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4842165366874389d, y: 0.15997157617416635d), radius: 0.2555509945705118d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.053806940808431736d, y: 0.7893817680274873d), radius: 0.7440001229769564d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9146997065808141d, y: 0.7747809996561713d), radius: 0.03173319002495789d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17683774302978217d, y: 0.4245404274597179d), radius: 0.8356404697855752d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6815703554391634d, y: 0.6571695098463496d), radius: 0.7666914389770363d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6540844829055477d, y: 0.7468183827777743d), radius: 0.7942671690409734d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9881564369168815d, y: 0.7933615909041417d), radius: 0.1680322542221251d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22308531370613294d, y: 0.18091585024575307d), radius: 0.5585770596247145d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.760553334882753d, y: 0.1172545099931559d), radius: 0.39582626365091933d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9657519765910743d, y: 0.9978319926313587d), radius: 0.9645055775075826d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7216224417173204d, y: 0.2489298472178444d), radius: 0.7310862719773507d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.353932070853767d, y: 0.07712661976780433d), radius: 0.7350132278671292d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9032483137677693d, y: 0.6132877198612388d), radius: 0.13571375815157116d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025404564043446043d, y: 0.24206738339996947d), radius: 0.29836629833394446d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6444361583432466d, y: 0.48337032201817254d), radius: 0.4249779442020559d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9636328077925972d, y: 0.4482263352335899d), radius: 0.7445578034214456d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5782360147486603d, y: 0.39265401458720484d), radius: 0.7605693165505246d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12299611951128897d, y: 0.9895708485809279d), radius: 0.4249879646618878d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5069256485796888d, y: 0.8483327286566131d), radius: 0.20993936756690967d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3282678553172994d, y: 0.5345863295247878d), radius: 0.5551304327829535d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39748403980888003d, y: 0.3056877303114647d), radius: 0.7647497334193574d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.814907179284035d, y: 0.8552888074845019d), radius: 0.8810206206761277d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9509538732667475d, y: 0.41183230760309186d), radius: 0.4618270788470291d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3700103678505575d, y: 0.1807298931195631d), radius: 0.455770346615885d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2084656688837344d, y: 0.009626064525608102d), radius: 0.43129497823738205d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3882931655057613d, y: 0.29036737561830384d), radius: 0.030161573636658168d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8252368821457665d, y: 0.14286646561247673d), radius: 0.8991384497900525d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8616705330497743d, y: 0.11726073521329128d), radius: 0.4692102904726291d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8029453669804767d, y: 0.2749163097876054d), radius: 0.04092678400134109d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3680502879263944d, y: 0.3069483544301882d), radius: 0.14198809018728842d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3769632568501453d, y: 0.3220489841375552d), radius: 0.9334042587493915d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7136492972764215d, y: 0.829020774669617d), radius: 0.8113030131369307d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3921145865814518d, y: 0.7294690881637125d), radius: 0.6613366934211795d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9553699362911461d, y: 0.6732082007708757d), radius: 0.4799973273459194d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5637751718518774d, y: 0.0044162673771538374d), radius: 0.31683056020796174d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25248050092964935d, y: 0.04759975703007768d), radius: 0.623356125740057d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9222043807499041d, y: 0.3675158697140487d), radius: 0.839145481008041d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32099529811819383d, y: 0.8725363356399217d), radius: 0.10115347386317997d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05067707797618293d, y: 0.7247144810170196d), radius: 0.6785302122250528d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24616150728481279d, y: 0.8449985526757419d), radius: 0.3524757938947938d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.578323322906375d, y: 0.49206227091925325d), radius: 0.33618236653410793d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8494335565448551d, y: 0.8602823368929935d), radius: 0.9265821834540112d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7324102750395808d, y: 0.4955951799666817d), radius: 0.7078262522439633d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5550704181005511d, y: 0.7047527484938735d), radius: 0.0787329013104906d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38498669900289395d, y: 0.6585665350541379d), radius: 0.9089740789986281d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9299698569502266d, y: 0.5710609963172244d), radius: 0.3470614878071555d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10054630981936352d, y: 0.9362468949933599d), radius: 0.09112903189595001d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7921107135774491d, y: 0.6829914998290527d), radius: 0.7529804584755121d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1380958952266771d, y: 0.7653257190707583d), radius: 0.24040530320757003d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.529082360771979d, y: 0.9593097834713002d), radius: 0.2767478147120589d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8181206573390276d, y: 0.6242439386209602d), radius: 0.08801231664185627d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40329482898788027d, y: 0.9960004460650921d), radius: 0.2651597493480432d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6630729492295812d, y: 0.24166472033530628d), radius: 0.0574123137543211d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3846866888434328d, y: 0.9443232076830508d), radius: 0.687462886043626d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6980644534546879d, y: 0.46238124081780885d), radius: 0.7883068702929266d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.421163974346066d, y: 0.3395090517292153d), radius: 0.5760868473650967d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8333273495392279d, y: 0.2597683143437871d), radius: 0.07350892196893244d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.795971832013143d, y: 0.0821783781048202d), radius: 0.7591063313067252d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9308013607768876d, y: 0.4675550800107271d), radius: 0.8832570851110958d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5538746551917318d, y: 0.3603811977409992d), radius: 0.0770398965823006d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5649050183898802d, y: 0.7808448387210742d), radius: 0.23327638490521185d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2612794321590588d, y: 0.9984919801173863d), radius: 0.43821651705277553d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9185024463208608d, y: 0.32884118090314884d), radius: 0.9679036788848918d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9583743437154164d, y: 0.4879619468287717d), radius: 0.9183763784907386d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14335901952386432d, y: 0.679366402417147d), radius: 0.7277548266940995d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5706288050948324d, y: 0.7805736942574104d), radius: 0.4160870045491807d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8215826535439492d, y: 0.9415501967320533d), radius: 0.19618611599483493d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7366568235799371d, y: 0.07502164365489139d), radius: 0.47859600553683823d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13793332265516633d, y: 0.819773112438694d), radius: 0.8119477238773828d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09374597764163672d, y: 0.4941826553019528d), radius: 0.30411964528995905d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48361251923333637d, y: 0.2462417045677231d), radius: 0.46856421352008704d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.865036453149867d, y: 0.42867531312848495d), radius: 0.7222474614223449d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2987664123440287d, y: 0.07173525405527448d), radius: 0.887205753984236d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6687273314892158d, y: 0.6173683563469545d), radius: 0.5854029411601845d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3486020434743158d, y: 0.6847894689007203d), radius: 0.9919077407175414d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21866699802149503d, y: 0.47851161455855296d), radius: 0.006654921512594725d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9666841159407441d, y: 0.5383358786259348d), radius: 0.35485022275479006d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4842165366874389d, y: 0.15997157617416635d), radius: 0.2555509945705118d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.053806940808431736d, y: 0.7893817680274873d), radius: 0.7440001229769564d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9146997065808141d, y: 0.7747809996561713d), radius: 0.03173319002495789d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17683774302978217d, y: 0.4245404274597179d), radius: 0.8356404697855752d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6815703554391634d, y: 0.6571695098463496d), radius: 0.7666914389770363d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6540844829055477d, y: 0.7468183827777743d), radius: 0.7942671690409734d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9881564369168815d, y: 0.7933615909041417d), radius: 0.1680322542221251d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22308531370613294d, y: 0.18091585024575307d), radius: 0.5585770596247145d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.760553334882753d, y: 0.1172545099931559d), radius: 0.39582626365091933d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9657519765910743d, y: 0.9978319926313587d), radius: 0.9645055775075826d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7216224417173204d, y: 0.2489298472178444d), radius: 0.7310862719773507d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.353932070853767d, y: 0.07712661976780433d), radius: 0.7350132278671292d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9032483137677693d, y: 0.6132877198612388d), radius: 0.13571375815157116d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025404564043446043d, y: 0.24206738339996947d), radius: 0.29836629833394446d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6444361583432466d, y: 0.48337032201817254d), radius: 0.4249779442020559d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9636328077925972d, y: 0.4482263352335899d), radius: 0.7445578034214456d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5782360147486603d, y: 0.39265401458720484d), radius: 0.7605693165505246d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12299611951128897d, y: 0.9895708485809279d), radius: 0.4249879646618878d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5069256485796888d, y: 0.8483327286566131d), radius: 0.20993936756690967d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3282678553172994d, y: 0.5345863295247878d), radius: 0.5551304327829535d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39748403980888003d, y: 0.3056877303114647d), radius: 0.7647497334193574d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.814907179284035d, y: 0.8552888074845019d), radius: 0.8810206206761277d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9509538732667475d, y: 0.41183230760309186d), radius: 0.4618270788470291d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3700103678505575d, y: 0.1807298931195631d), radius: 0.455770346615885d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2084656688837344d, y: 0.009626064525608102d), radius: 0.43129497823738205d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3882931655057613d, y: 0.29036737561830384d), radius: 0.030161573636658168d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8252368821457665d, y: 0.14286646561247673d), radius: 0.8991384497900525d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8616705330497743d, y: 0.11726073521329128d), radius: 0.4692102904726291d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8029453669804767d, y: 0.2749163097876054d), radius: 0.04092678400134109d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3680502879263944d, y: 0.3069483544301882d), radius: 0.14198809018728842d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3769632568501453d, y: 0.3220489841375552d), radius: 0.9334042587493915d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7136492972764215d, y: 0.829020774669617d), radius: 0.8113030131369307d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3921145865814518d, y: 0.7294690881637125d), radius: 0.6613366934211795d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9553699362911461d, y: 0.6732082007708757d), radius: 0.4799973273459194d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5637751718518774d, y: 0.0044162673771538374d), radius: 0.31683056020796174d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25248050092964935d, y: 0.04759975703007768d), radius: 0.623356125740057d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9222043807499041d, y: 0.3675158697140487d), radius: 0.839145481008041d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32099529811819383d, y: 0.8725363356399217d), radius: 0.10115347386317997d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05067707797618293d, y: 0.7247144810170196d), radius: 0.6785302122250528d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24616150728481279d, y: 0.8449985526757419d), radius: 0.3524757938947938d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.578323322906375d, y: 0.49206227091925325d), radius: 0.33618236653410793d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8494335565448551d, y: 0.8602823368929935d), radius: 0.9265821834540112d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7324102750395808d, y: 0.4955951799666817d), radius: 0.7078262522439633d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5550704181005511d, y: 0.7047527484938735d), radius: 0.0787329013104906d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38498669900289395d, y: 0.6585665350541379d), radius: 0.9089740789986281d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9299698569502266d, y: 0.5710609963172244d), radius: 0.3470614878071555d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10054630981936352d, y: 0.9362468949933599d), radius: 0.09112903189595001d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7921107135774491d, y: 0.6829914998290527d), radius: 0.7529804584755121d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1380958952266771d, y: 0.7653257190707583d), radius: 0.24040530320757003d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.529082360771979d, y: 0.9593097834713002d), radius: 0.2767478147120589d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8181206573390276d, y: 0.6242439386209602d), radius: 0.08801231664185627d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40329482898788027d, y: 0.9960004460650921d), radius: 0.2651597493480432d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6630729492295812d, y: 0.24166472033530628d), radius: 0.0574123137543211d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3846866888434328d, y: 0.9443232076830508d), radius: 0.687462886043626d))));

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

