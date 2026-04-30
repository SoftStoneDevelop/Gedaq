

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9721495561891168d, y: 0.4672782171852702d), radius: 0.9789440401970912d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25699341376793683d, y: 0.7655333006882489d), radius: 0.8681761651000852d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4698848830975507d, y: 0.37746980122043794d), radius: 0.06878987890602728d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3916587800084743d, y: 0.4908551203172199d), radius: 0.6746218664257596d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5862709875605161d, y: 0.5588476222958545d), radius: 0.07361401568044168d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11033929343169258d, y: 0.2537531176000478d), radius: 0.9363218861367464d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11732725575684133d, y: 0.6069195541659551d), radius: 0.9447851900623968d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3590199840632039d, y: 0.29465234581327193d), radius: 0.8738130897044079d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04134565806605228d, y: 0.9435833139043492d), radius: 0.3553818374588549d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8407292083252791d, y: 0.8710364707910765d), radius: 0.8331651839563443d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8560853625633571d, y: 0.04139647144526182d), radius: 0.7663116537883974d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.897171017803255d, y: 0.6649906099508487d), radius: 0.5048524672496184d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44720628990142d, y: 0.2059975891995025d), radius: 0.8608213276250204d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5125796750816489d, y: 0.9432594315018287d), radius: 0.15228878933030954d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0956329395434129d, y: 0.8741130252576307d), radius: 0.6564405792629407d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7031826531974916d, y: 0.36359561159806775d), radius: 0.6159905161527313d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21824529334742238d, y: 0.5916984167675464d), radius: 0.05637197686417461d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9607378777189461d, y: 0.8870375768475178d), radius: 0.6817963906911514d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.384094264080608d, y: 0.5767385241887979d), radius: 0.9110964430860332d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6581652112956411d, y: 0.9286453333056334d), radius: 0.0732897339350439d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2610515450299711d, y: 0.8981326843558373d), radius: 0.5665980225184614d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5733217765628534d, y: 0.4427110885192348d), radius: 0.18769832749597648d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3423364333932013d, y: 0.9552773322667023d), radius: 0.17330406888816796d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1796040892949875d, y: 0.5086903693710193d), radius: 0.9971757209220747d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09210161981973197d, y: 0.34034764997161704d), radius: 0.8955235675039588d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1428219425854269d, y: 0.10287904110379065d), radius: 0.5711391389145491d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09329616620077774d, y: 0.18562434196419486d), radius: 0.5189630729334387d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8695932056981647d, y: 0.8197692960938431d), radius: 0.10864567533134017d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4218777888222466d, y: 0.6208667545920084d), radius: 0.4416446961509426d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41896022558137325d, y: 0.03966959494110678d), radius: 0.5294197884007417d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11616047620225545d, y: 0.9242391301314407d), radius: 0.5581691039896767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47114898224245894d, y: 0.21903505804673618d), radius: 0.5670242924291788d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.613152827718231d, y: 0.6200187964936165d), radius: 0.19481985703736582d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40687140165969693d, y: 0.3678343691089059d), radius: 0.7252793394839487d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6907992500724633d, y: 0.5926982294941893d), radius: 0.1780207486308477d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25713282832328166d, y: 0.7130274008348462d), radius: 0.5476716206291411d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09649117758561943d, y: 0.5588172218686234d), radius: 0.8503785135594202d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4530051242353318d, y: 0.1983215560407251d), radius: 0.8307715129474019d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37385519200191475d, y: 0.5849461848805952d), radius: 0.5288184720659066d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7806789076723839d, y: 0.4035804816166869d), radius: 0.08568818630074637d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36732057410005725d, y: 0.9343122056723915d), radius: 0.8032090267407987d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.720214073990872d, y: 0.3074341248532194d), radius: 0.0317041892959361d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7828416819493896d, y: 0.39433949085965425d), radius: 0.6575507024069716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5215033344878217d, y: 0.8690896848375128d), radius: 0.21913071183810406d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5922353122475773d, y: 0.7498546331586156d), radius: 0.07550281482045296d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7723929383637139d, y: 0.6528850260607538d), radius: 0.10164278869328225d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.77745203352752d, y: 0.047360865418058506d), radius: 0.5925764465572164d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5177532331817742d, y: 0.40382722128112747d), radius: 0.9340739659997682d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37568288352648727d, y: 0.956916189979491d), radius: 0.48749735476052103d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43807861448618857d, y: 0.9206961066330184d), radius: 0.8471958011322355d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7334498643419235d, y: 0.7811500257170021d), radius: 0.28658638117547497d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5008494973833858d, y: 0.30698961534049296d), radius: 0.25143255430420974d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5595025516097532d, y: 0.3641916629469373d), radius: 0.8000820516595369d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17939130748343135d, y: 0.38612025689875873d), radius: 0.5655063529494434d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35799475132253566d, y: 0.655641060955059d), radius: 0.5360268278887108d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5678771327471634d, y: 0.8956899958120615d), radius: 0.552237437247648d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11653836636532355d, y: 0.9369391556029316d), radius: 0.9356709259875975d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07444211467277473d, y: 0.564068287699627d), radius: 0.6414610624090564d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5754331812024577d, y: 0.603978420481034d), radius: 0.9197990840382684d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0010982977196477561d, y: 0.33441078131498236d), radius: 0.8180795615748633d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9179554297488378d, y: 0.5613241994198115d), radius: 0.23659332841154546d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44153925618959966d, y: 0.6574938520720127d), radius: 0.5859731392976759d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5211159366521098d, y: 0.2153717310162877d), radius: 0.7982501911601995d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3215568928835292d, y: 0.8207823463225307d), radius: 0.2095845137807224d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8357305967987807d, y: 0.8212855226432976d), radius: 0.1697738815826787d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33014609414393314d, y: 0.3309559601535653d), radius: 0.8786972656095647d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5846926097640816d, y: 0.46211779917644247d), radius: 0.9085082477058423d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7713710180243195d, y: 0.46606654408454606d), radius: 0.05233851682883173d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6567492634496498d, y: 0.11777835990274521d), radius: 0.0014163778422425777d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6337048435305455d, y: 0.34227869405766065d), radius: 0.11848061734311699d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9826354666585608d, y: 0.6789528474264487d), radius: 0.8765991331618236d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.408577975052821d, y: 0.9093553536907248d), radius: 0.9792277574123238d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020527308626755114d, y: 0.9764771953018514d), radius: 0.19324252512158246d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34059175732936575d, y: 0.6026521633843462d), radius: 0.2680357387746686d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10852880760782657d, y: 0.7622612740523d), radius: 0.8517460229081049d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8214202151584267d, y: 0.33408400826550155d), radius: 0.987547628860428d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8316845866673553d, y: 0.7805552350549099d), radius: 0.9623264662561267d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9851199976052506d, y: 0.9260558551342966d), radius: 0.10952194941304105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8483161903466375d, y: 0.39096547481161414d), radius: 0.683413000843669d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5224553023589034d, y: 0.5418285467897671d), radius: 0.6139587763436033d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3614012141032784d, y: 0.39720893533971413d), radius: 0.6864706779183878d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14292963379863977d, y: 0.033127511773692664d), radius: 0.5505041746050634d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9797951484334403d, y: 0.30763784485556d), radius: 0.24454869329090934d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2829388411893028d, y: 0.27491558801417004d), radius: 0.3781291049032366d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2953775049937297d, y: 0.13643296058465626d), radius: 0.12372216812474135d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2508187860774186d, y: 0.6440158349290303d), radius: 0.4816869131093586d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2837004746825079d, y: 0.23033270819166907d), radius: 0.06371640343068374d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6171907073641004d, y: 0.4180652594197707d), radius: 0.9753667823120228d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9906111660968916d, y: 0.46379177215449774d), radius: 0.43930335900394657d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9104243472838703d, y: 0.8174265121160934d), radius: 0.4100264362289955d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19543409712502402d, y: 0.6002365873968092d), radius: 0.3964384601133153d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.842163146619492d, y: 0.831471191692508d), radius: 0.40449572347327034d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8626281793904086d, y: 0.6748196794914529d), radius: 0.22205309441273924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5323780937672286d, y: 0.6241069226987818d), radius: 0.13551618329821558d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.708371363766605d, y: 0.9357658890610289d), radius: 0.2683943099574534d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6416735020668858d, y: 0.47886725352346327d), radius: 0.47655711398414313d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7890640341509063d, y: 0.0401173971681551d), radius: 0.1974240222344258d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12549454776938795d, y: 0.45779351248228084d), radius: 0.7376783651992231d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8267482534346777d, y: 0.8378094374239811d), radius: 0.38675825059056623d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8082665881145124d, y: 0.761728620580328d), radius: 0.17810773092589227d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.993581932399728d, y: 0.3833471337917066d), radius: 0.4954866541657068d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4735374598069998d, y: 0.15092481513465694d), radius: 0.4499037503431065d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7755939296514244d, y: 0.7183936745691045d), radius: 0.7903103388640026d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11700186860724626d, y: 0.6299127440730088d), radius: 0.5113454213949205d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8578199504181535d, y: 0.8940598629206531d), radius: 0.2609704616997487d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17115836545107688d, y: 0.9251669424819319d), radius: 0.16377063232141864d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7901044923826692d, y: 0.8764678589481493d), radius: 0.14644312661544145d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5299976566056016d, y: 0.1304159531598601d), radius: 0.2892743061014714d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6180634128308481d, y: 0.7854001132888743d), radius: 0.8220277037167754d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16937800869744057d, y: 0.2614829575641415d), radius: 0.9071167912284843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6254100382395547d, y: 0.3763366754575215d), radius: 0.08955769529316948d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024645674784433358d, y: 0.4330207850519342d), radius: 0.3572270585799088d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3756685338279153d, y: 0.9991783264597346d), radius: 0.5570301767045029d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7115647663704757d, y: 0.7220828058142388d), radius: 0.9371941326016965d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22968919509037689d, y: 0.13016762685471606d), radius: 0.8521138394162089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.196942265763124d, y: 0.4336002527454882d), radius: 0.22617155663883304d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3127318247994082d, y: 0.7590611327939962d), radius: 0.715554626194892d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6647994747782457d, y: 0.6338646263004724d), radius: 0.9039290090920401d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8364769185228387d, y: 0.38686756669529176d), radius: 0.658500986510491d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7403764784152554d, y: 0.21194796898659662d), radius: 0.028920034564576258d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4708974166881734d, y: 0.7585042084809512d), radius: 0.6611988720124464d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27292385662086016d, y: 0.5488281578825415d), radius: 0.2200821910195837d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5380477991033814d, y: 0.3304086910309122d), radius: 0.7481364257585925d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.547817488976319d, y: 0.47046042637732854d), radius: 0.654197612834731d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9394743263051561d, y: 0.27687239518210904d), radius: 0.4005116407644469d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35925901748292866d, y: 0.12386265959009546d), radius: 0.41674028627806625d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7142165484770382d, y: 0.16896377466035217d), radius: 0.586555863613967d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.294094776679801d, y: 0.9862545508164218d), radius: 0.30957123088866656d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2962150094707636d, y: 0.4971808839484536d), radius: 0.1564415412350585d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5664736794530997d, y: 0.24489205870421005d), radius: 0.7403537563113433d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39544879298618263d, y: 0.33814848486331894d), radius: 0.5009882821906966d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4268719478778601d, y: 0.3081457757011622d), radius: 0.8676363034080038d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9365627381408692d, y: 0.5015272704728664d), radius: 0.8211607657637595d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2507796013723014d, y: 0.15715719694445884d), radius: 0.8199479625966162d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36297758172112327d, y: 0.4006653247308477d), radius: 0.4431531754142437d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21379984260591212d, y: 0.06808389687099647d), radius: 0.05205298833742422d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7223754917298116d, y: 0.5693276635425d), radius: 0.6886564239915338d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4280546784465894d, y: 0.7840988898932928d), radius: 0.9141682062116175d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5152588903476031d, y: 0.9755708954100734d), radius: 0.20376225511500956d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.647714453040761d, y: 0.9087683756757844d), radius: 0.49815648696588655d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6711686016163295d, y: 0.3347218791538904d), radius: 0.4004047560257029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7515127707124307d, y: 0.321830714100948d), radius: 0.04340634063697846d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8199176471721503d, y: 0.6958473690852216d), radius: 0.028460948309394607d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06363150262190087d, y: 0.6614691255595d), radius: 0.952814075562485d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38743757385228617d, y: 0.1837397616509585d), radius: 0.449757011904092d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2384008042007698d, y: 0.21809192968738755d), radius: 0.4216292804196795d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3825965611126686d, y: 0.8493099032329334d), radius: 0.32637210179189735d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5365998035386329d, y: 0.6683439108867104d), radius: 0.6208799637627773d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10267080422664099d, y: 0.25729016229094337d), radius: 0.8820374714095993d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45526682187307166d, y: 0.48012750929763703d), radius: 0.2978726243578632d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8094372780607092d, y: 0.665661115694319d), radius: 0.5241467492695366d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7866556660502483d, y: 0.5514371476351075d), radius: 0.559540291210747d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49629180426925d, y: 0.6800202397984125d), radius: 0.38654010635602665d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0158484558905696d, y: 0.13419247884576657d), radius: 0.7593644914387327d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.878443564572288d, y: 0.2757742977582962d), radius: 0.19905051451554767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5124025600968426d, y: 0.07888691849388452d), radius: 0.860009981699124d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5825355460117533d, y: 0.9430259627953061d), radius: 0.22744626822992187d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3760440720638827d, y: 0.18952876931258988d), radius: 0.7149902373610465d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33371545307456174d, y: 0.7233369999750108d), radius: 0.9651798085772669d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.416173627795434d, y: 0.23378413516974494d), radius: 0.06685441676550563d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3710094359930748d, y: 0.5727167790376478d), radius: 0.00798643252954323d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6528678032786147d, y: 0.2588205174295758d), radius: 0.3042162451256639d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25807710117917826d, y: 0.4296319887064497d), radius: 0.1929249469713391d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8843254267777602d, y: 0.7524111157231971d), radius: 0.3375680243860637d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6647006512883299d, y: 0.9030919654139894d), radius: 0.7800585588356609d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04885327265621875d, y: 0.7830000226153956d), radius: 0.653640567241071d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9875715759598176d, y: 0.3498970696304293d), radius: 0.6788067793319856d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.047236237377258794d, y: 0.28050159465685176d), radius: 0.013144333917721296d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5576651666084242d, y: 0.7695628098717551d), radius: 0.4460578975439259d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29652012284630813d, y: 0.7372718026920482d), radius: 0.8196586467876757d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2725686484321942d, y: 0.010796292145605402d), radius: 0.5993675857977853d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5831968053988998d, y: 0.36217969524267624d), radius: 0.7409766577470747d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19867079973516766d, y: 0.13779986646824194d), radius: 0.9433471770667753d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4048471527231009d, y: 0.5415150901965982d), radius: 0.38763332941334727d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8800428105946441d, y: 0.8783569770423266d), radius: 0.1656614411076892d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15208271861731248d, y: 0.6930399827828282d), radius: 0.984409635707959d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8549047561984485d, y: 0.2835137424140012d), radius: 0.9783755756509566d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23999604764779636d, y: 0.7740108315947041d), radius: 0.7655522139200901d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3582029786148555d, y: 0.039165530414304706d), radius: 0.6040000542632699d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010026865537512752d, y: 0.5974922260523663d), radius: 0.3747494523747712d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.768332813983261d, y: 0.026092843148093015d), radius: 0.2617171440267413d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7513737323809575d, y: 0.44851665317713274d), radius: 0.7207375529020743d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7002500331128678d, y: 0.0523433972899614d), radius: 0.8932772196750164d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45178023304625115d, y: 0.7084244851018885d), radius: 0.34629028070962453d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5241494409658056d, y: 0.9246261118913721d), radius: 0.3173071152157755d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43177089373862787d, y: 0.8185105445736298d), radius: 0.7136180987053844d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5315810883487186d, y: 0.6612384199432982d), radius: 0.5256274838151771d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6000053068291789d, y: 0.1456328321675704d), radius: 0.6938379375265863d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7125021130188752d, y: 0.159088017351234d), radius: 0.6499252942491431d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07804422544197387d, y: 0.8776145763050989d), radius: 0.3320321911875296d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8602926248413876d, y: 0.6037580905573701d), radius: 0.3987247819086287d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41546011460398946d, y: 0.2280052078456284d), radius: 0.6286504710291065d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.795179750140572d, y: 0.11356774414797066d), radius: 0.2061001260613018d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7314040445093153d, y: 0.7415736350634847d), radius: 0.07128821857146783d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14098607934441199d, y: 0.31474905757533556d), radius: 0.43099408125656313d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21985731971246558d, y: 0.0001305944592600028d), radius: 0.017060540092929677d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6236606345626347d, y: 0.13802166759988355d), radius: 0.6414287975383047d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42656592522338466d, y: 0.8980889250827598d), radius: 0.9840760959607178d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39290792049383483d, y: 0.09269065798298426d), radius: 0.0025170195303355625d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2797053058565896d, y: 0.987648062929198d), radius: 0.610583680779571d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7105380277277745d, y: 0.6546085275164141d), radius: 0.08488073714964672d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09284895670884574d, y: 0.4424917673773343d), radius: 0.45810065284032475d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.550798094739171d, y: 0.1685766980739386d), radius: 0.09296662486849183d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8046716036474518d, y: 0.5902668179066882d), radius: 0.8588985566325344d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5834459532118024d, y: 0.7662468844435681d), radius: 0.991652342552369d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06531353862687928d, y: 0.9244674865663525d), radius: 0.8086499842521473d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6225091308005486d, y: 0.025084577334279046d), radius: 0.015093846524639631d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9532912776624173d, y: 0.3985222368989092d), radius: 0.07975343054853967d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8317909791073937d, y: 0.9445334182451742d), radius: 0.4421509024488476d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23375359619591185d, y: 0.9904498282610531d), radius: 0.5782544405194688d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6611286147480375d, y: 0.6838754574983021d), radius: 0.5168461880594233d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27458159802275073d, y: 0.5915101261253585d), radius: 0.7939343164294058d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3503836435109572d, y: 0.8118505204022559d), radius: 0.9177628410586655d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2864954997637077d, y: 0.8326838600802497d), radius: 0.38904470514069966d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9448541636683389d, y: 0.30039513879075186d), radius: 0.9634529145733187d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9237622064806725d, y: 0.5538521756036454d), radius: 0.3130435176325137d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02307568581272923d, y: 0.3591119005138048d), radius: 0.2011569332971923d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8076771002161963d, y: 0.1433583043468627d), radius: 0.4830277123564277d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4842837364885031d, y: 0.25847397158360164d), radius: 0.9497412590304658d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5635100652567622d, y: 0.5975141208882333d), radius: 0.4045728629925891d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7928289662415807d, y: 0.3069071307408995d), radius: 0.15962527225969114d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07788242126833556d, y: 0.01662163794203364d), radius: 0.24811396498092064d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6330571375367294d, y: 0.583065180767013d), radius: 0.6119038644828193d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2627576169928556d, y: 0.6020333148011048d), radius: 0.49910951282204064d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5402518517491304d, y: 0.9130435100073248d), radius: 0.7538424597819011d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.86410441411397d, y: 0.19503899065846664d), radius: 0.27367937145806276d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11733355790792466d, y: 0.3053650199021417d), radius: 0.03059634571122427d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22068357880057177d, y: 0.49635131028684487d), radius: 0.7724299339358872d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8214202151584267d, y: 0.33408400826550155d), radius: 0.987547628860428d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8316845866673553d, y: 0.7805552350549099d), radius: 0.9623264662561267d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9851199976052506d, y: 0.9260558551342966d), radius: 0.10952194941304105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8483161903466375d, y: 0.39096547481161414d), radius: 0.683413000843669d),
}));
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 66;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 59;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[29], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 88, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 45, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 120, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 59, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 14, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 120, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 136, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 124, 131))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 45, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[1], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[2], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[3], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[4], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[5], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[6], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[7], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[8], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[9], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[29], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

