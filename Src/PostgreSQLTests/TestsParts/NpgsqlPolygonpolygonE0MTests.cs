

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygonE0M[] _testData = new NpgsqlPolygonpolygonE0M[]
        {
            new NpgsqlPolygonpolygonE0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5980574113929973d, y: 0.385766924550485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379270927799647d, y: 0.8096282517936184d), new NpgsqlTypes.NpgsqlPoint(x: 0.27305423846354726d, y: 0.35842795427693486d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10121912422970514d, y: 0.040227554169329216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6138760908370734d, y: 0.42526468380867233d), new NpgsqlTypes.NpgsqlPoint(x: 0.07508879865598894d, y: 0.270159974251867d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9618069349808808d, y: 0.14216853646376015d), new NpgsqlTypes.NpgsqlPoint(x: 0.650877746737044d, y: 0.4563620404454507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216627843364824d, y: 0.9215655295032863d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9113120747548149d, y: 0.31261665612596823d), new NpgsqlTypes.NpgsqlPoint(x: 0.4233075860002562d, y: 0.910779628452176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482091911892899d, y: 0.502624029563162d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06395618199138842d, y: 0.3297427333537758d), new NpgsqlTypes.NpgsqlPoint(x: 0.4839585856174782d, y: 0.33257220777754504d), new NpgsqlTypes.NpgsqlPoint(x: 0.3159142360947965d, y: 0.009955258742253559d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29658366859904095d, y: 0.6058632257206177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604271373316251d, y: 0.2930748812898205d), new NpgsqlTypes.NpgsqlPoint(x: 0.07706747128258107d, y: 0.21904588860010643d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31026395971698906d, y: 0.507398895399681d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213644318812664d, y: 0.36117707310729674d), new NpgsqlTypes.NpgsqlPoint(x: 0.2168254438572581d, y: 0.8364008396950278d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22390064516486674d, y: 0.6449942248649049d), new NpgsqlTypes.NpgsqlPoint(x: 0.46108911738817016d, y: 0.003274287251671004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8755514140991774d, y: 0.5631417729226522d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5531201300612044d, y: 0.06380851327546333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454825697521666d, y: 0.5819190239611255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782685804216616d, y: 0.9931596309329329d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4779060013068406d, y: 0.9951839929703884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566349889347624d, y: 0.48315627553520135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7290468388942687d, y: 0.22028137391153169d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.914482603508153d, y: 0.009832627197799648d), new NpgsqlTypes.NpgsqlPoint(x: 0.08295290018246637d, y: 0.3571573626955268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569888630714077d, y: 0.3201044015006921d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.927873587625292d, y: 0.8331470962945449d), new NpgsqlTypes.NpgsqlPoint(x: 0.24241665788459932d, y: 0.449340835888704d), new NpgsqlTypes.NpgsqlPoint(x: 0.44348526672889443d, y: 0.918937299446635d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46630840749810243d, y: 0.5953940692553328d), new NpgsqlTypes.NpgsqlPoint(x: 0.17980828788065117d, y: 0.44172800148445435d), new NpgsqlTypes.NpgsqlPoint(x: 0.021714088852444746d, y: 0.050227462977966764d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5682955300354822d, y: 0.988490872377232d), new NpgsqlTypes.NpgsqlPoint(x: 0.2509840158512108d, y: 0.7673468146812757d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986734196464561d, y: 0.5749009156353676d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10323193989748658d, y: 0.987173943444797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617717417297401d, y: 0.8744631886519378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3609494244457343d, y: 0.35557469628223204d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6463393484449792d, y: 0.5299935355860173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105133522166273d, y: 0.5754478466928044d), new NpgsqlTypes.NpgsqlPoint(x: 0.24167933249202922d, y: 0.9794733353549248d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4209037547304234d, y: 0.2772877197486311d), new NpgsqlTypes.NpgsqlPoint(x: 0.23839527066121358d, y: 0.6569357012545406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374262439845278d, y: 0.41622065246725437d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7244418700003552d, y: 0.7843404368777723d), new NpgsqlTypes.NpgsqlPoint(x: 0.21214839380455908d, y: 0.19767392555692287d), new NpgsqlTypes.NpgsqlPoint(x: 0.01407853893444333d, y: 0.7421089605502165d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011102711465100112d, y: 0.024533087081160865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619699598046427d, y: 0.6758237807382701d), new NpgsqlTypes.NpgsqlPoint(x: 0.0677433714711746d, y: 0.6952213520585462d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07585068695971231d, y: 0.8106853311560462d), new NpgsqlTypes.NpgsqlPoint(x: 0.15650180058064256d, y: 0.003606678350583148d), new NpgsqlTypes.NpgsqlPoint(x: 0.626090462258837d, y: 0.5049008445118139d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6834331096813658d, y: 0.5089953981439336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6224902609989535d, y: 0.7032770781379265d), new NpgsqlTypes.NpgsqlPoint(x: 0.38208320631538906d, y: 0.16304742736124433d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1304027625139883d, y: 0.5292778472164965d), new NpgsqlTypes.NpgsqlPoint(x: 0.45389907207936253d, y: 0.8854300289906751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5502123246169124d, y: 0.14539605662084654d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9897067820714298d, y: 0.4038859450219897d), new NpgsqlTypes.NpgsqlPoint(x: 0.38390691320878634d, y: 0.32759185797477264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3368076459529723d, y: 0.14045955488270623d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11689280400189361d, y: 0.10570619521255609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822063228793331d, y: 0.44299102990651684d), new NpgsqlTypes.NpgsqlPoint(x: 0.2759708132622267d, y: 0.729208017406944d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41376244121085715d, y: 0.9892301061615031d), new NpgsqlTypes.NpgsqlPoint(x: 0.06498895044116182d, y: 0.931906060854572d), new NpgsqlTypes.NpgsqlPoint(x: 0.47492144563331196d, y: 0.16577273231871992d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5007594968567148d, y: 0.34449998081288147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5301651663687584d, y: 0.1037913275589818d), new NpgsqlTypes.NpgsqlPoint(x: 0.0075898998989120114d, y: 0.7157529840830489d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8794956342523508d, y: 0.9903848967804053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6041249499222934d, y: 0.5594312818794078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738662247370407d, y: 0.43363539722386024d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8655602041667428d, y: 0.7212630465801314d), new NpgsqlTypes.NpgsqlPoint(x: 0.40475561705926666d, y: 0.7283594878083932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204881359063652d, y: 0.9167764019017788d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9572910031125242d, y: 0.7001385968436183d), new NpgsqlTypes.NpgsqlPoint(x: 0.345761401858516d, y: 0.9710276742690737d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923197337353681d, y: 0.09563574021936416d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7837077153974836d, y: 0.801967472465659d), new NpgsqlTypes.NpgsqlPoint(x: 0.16826471903574447d, y: 0.4551771805314929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333927558557008d, y: 0.8299163156478325d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13749952400498333d, y: 0.8394271524837595d), new NpgsqlTypes.NpgsqlPoint(x: 0.8997727535525173d, y: 0.254568178691156d), new NpgsqlTypes.NpgsqlPoint(x: 0.422957886576975d, y: 0.74650579800172d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8271807699321825d, y: 0.8565626046829378d), new NpgsqlTypes.NpgsqlPoint(x: 0.16530409908313903d, y: 0.5256967908203836d), new NpgsqlTypes.NpgsqlPoint(x: 0.949611889866512d, y: 0.6619347115822539d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2047500605770073d, y: 0.0004660374611525908d), new NpgsqlTypes.NpgsqlPoint(x: 0.2888690739383801d, y: 0.14624050519700293d), new NpgsqlTypes.NpgsqlPoint(x: 0.19714611436580998d, y: 0.1486170505688702d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5852211457454095d, y: 0.5663768006174127d), new NpgsqlTypes.NpgsqlPoint(x: 0.26114408436615d, y: 0.6431677399103347d), new NpgsqlTypes.NpgsqlPoint(x: 0.3898682065123865d, y: 0.47440541976348716d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22387313039838885d, y: 0.44089045976766406d), new NpgsqlTypes.NpgsqlPoint(x: 0.15879849190952333d, y: 0.19724414110524868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9195895940232144d, y: 0.30796030175144606d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41825398151147886d, y: 0.5752164765224086d), new NpgsqlTypes.NpgsqlPoint(x: 0.3518719933361071d, y: 0.7780052788263188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9849141605364565d, y: 0.952397250322284d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29034221553679285d, y: 0.7802070168838141d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730940068252274d, y: 0.748404182733922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025872348240364d, y: 0.8404183551198868d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9515669001879214d, y: 0.30180064937269746d), new NpgsqlTypes.NpgsqlPoint(x: 0.9181513762132527d, y: 0.1760267867247608d), new NpgsqlTypes.NpgsqlPoint(x: 0.22617483207159228d, y: 0.2473143562684712d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5536643714521331d, y: 0.6264833523574663d), new NpgsqlTypes.NpgsqlPoint(x: 0.851109855588335d, y: 0.6301258248790254d), new NpgsqlTypes.NpgsqlPoint(x: 0.10161377387953341d, y: 0.31070813058156477d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.420947246033583d, y: 0.5234772312453444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663319338713687d, y: 0.21736836080801447d), new NpgsqlTypes.NpgsqlPoint(x: 0.29907782386824533d, y: 0.41187674126503204d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26015946224595987d, y: 0.1427946974249782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584901901659893d, y: 0.22439438427768976d), new NpgsqlTypes.NpgsqlPoint(x: 0.0731266831434132d, y: 0.7182173557587102d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3917802522598969d, y: 0.44595746314285156d), new NpgsqlTypes.NpgsqlPoint(x: 0.4590974492732989d, y: 0.9280385119961846d), new NpgsqlTypes.NpgsqlPoint(x: 0.08644964173652647d, y: 0.6541547111878623d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8850864881174477d, y: 0.9059189981624346d), new NpgsqlTypes.NpgsqlPoint(x: 0.31455459484581483d, y: 0.5193044222233734d), new NpgsqlTypes.NpgsqlPoint(x: 0.12389361597667092d, y: 0.5371052036922771d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6542999415595596d, y: 0.3208819371736501d), new NpgsqlTypes.NpgsqlPoint(x: 0.36718060319012447d, y: 0.8791686311630753d), new NpgsqlTypes.NpgsqlPoint(x: 0.24936674962868455d, y: 0.15661707181695517d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9560488402987922d, y: 0.3497343841530268d), new NpgsqlTypes.NpgsqlPoint(x: 0.21354080806696585d, y: 0.776372390374598d), new NpgsqlTypes.NpgsqlPoint(x: 0.728751563308514d, y: 0.6938389390249683d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9650557976622725d, y: 0.1886185701223725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2795766915193535d, y: 0.7251911855214607d), new NpgsqlTypes.NpgsqlPoint(x: 0.558913689835209d, y: 0.07385819056359633d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41543023454951244d, y: 0.8344858824302002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9856694780246233d, y: 0.5123772155625881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468981551949868d, y: 0.5933506095409132d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09842561952980577d, y: 0.5263278668706587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5854447666485358d, y: 0.2060890749366392d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527363285559022d, y: 0.879608160987421d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24285070017291044d, y: 0.6685091209262206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8222950834772481d, y: 0.03268747586464127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9732091029919503d, y: 0.5029536599909696d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1810585554580083d, y: 0.9580365879497108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837125723561914d, y: 0.4474710529950511d), new NpgsqlTypes.NpgsqlPoint(x: 0.3336048010794809d, y: 0.9755115011510573d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3533392378105572d, y: 0.9548311035960866d), new NpgsqlTypes.NpgsqlPoint(x: 0.26087730782948537d, y: 0.1548898366093373d), new NpgsqlTypes.NpgsqlPoint(x: 0.4738513965188096d, y: 0.17192186669476683d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26044246076504474d, y: 0.9082108500226197d), new NpgsqlTypes.NpgsqlPoint(x: 0.18614674669247278d, y: 0.1736056901948395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7059511708803168d, y: 0.39153999860119604d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5762765161951258d, y: 0.2333956151094988d), new NpgsqlTypes.NpgsqlPoint(x: 0.464390390929758d, y: 0.7888643143192458d), new NpgsqlTypes.NpgsqlPoint(x: 0.13849116719963295d, y: 0.002731772829106971d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39589865920511724d, y: 0.6575125369305399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8605157944036954d, y: 0.11576684879621646d), new NpgsqlTypes.NpgsqlPoint(x: 0.469617640436062d, y: 0.006369659102225866d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4001666676637746d, y: 0.06549836941220444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239332921249297d, y: 0.1421331096211077d), new NpgsqlTypes.NpgsqlPoint(x: 0.08658419227536918d, y: 0.3083697828319517d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9358676774576509d, y: 0.7606729570782389d), new NpgsqlTypes.NpgsqlPoint(x: 0.269014414286456d, y: 0.9925271325672753d), new NpgsqlTypes.NpgsqlPoint(x: 0.5795630764329389d, y: 0.4428535004897508d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3413021185557211d, y: 0.8352567341211687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869425097886397d, y: 0.24170971260728147d), new NpgsqlTypes.NpgsqlPoint(x: 0.059320924259443464d, y: 0.03049634947541624d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31033283386711674d, y: 0.922976776067734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093810817158138d, y: 0.05606135131894141d), new NpgsqlTypes.NpgsqlPoint(x: 0.3471373567545226d, y: 0.20958523428733766d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28955496415419546d, y: 0.44263315222997734d), new NpgsqlTypes.NpgsqlPoint(x: 0.2398841472774712d, y: 0.5403617851419975d), new NpgsqlTypes.NpgsqlPoint(x: 0.030414238102016933d, y: 0.48476610517522645d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20549583956395523d, y: 0.45337352854753565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3796379349171325d, y: 0.9516878243757061d), new NpgsqlTypes.NpgsqlPoint(x: 0.0026214736788373605d, y: 0.7906661874759382d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6351340418032393d, y: 0.9550170780968357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130988378796427d, y: 0.5845143460104668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988785266344944d, y: 0.3586619155972587d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7012948143740321d, y: 0.7834796162663082d), new NpgsqlTypes.NpgsqlPoint(x: 0.680011524156263d, y: 0.1496054315702795d), new NpgsqlTypes.NpgsqlPoint(x: 0.37034452807216434d, y: 0.9512690980952383d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34014062284258617d, y: 0.7667969858644677d), new NpgsqlTypes.NpgsqlPoint(x: 0.016813093524329026d, y: 0.6287341655559603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5614056426339409d, y: 0.4773572943521398d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.254729675349326d, y: 0.9355452303146735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7860344753106718d, y: 0.4887369464600614d), new NpgsqlTypes.NpgsqlPoint(x: 0.08300088343659728d, y: 0.599032472682749d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4964492760092667d, y: 0.1803857940721597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243245477608191d, y: 0.8659985835993596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440394325109427d, y: 0.8941792659924385d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5497301164705019d, y: 0.24393691717680965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9707776552711829d, y: 0.5439572679306401d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642171030918913d, y: 0.23389824271446857d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8876164846996073d, y: 0.3631334402792098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4320943678474769d, y: 0.08612235619882358d), new NpgsqlTypes.NpgsqlPoint(x: 0.7487744425391831d, y: 0.38471256359741446d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5281184552929372d, y: 0.5157897331542906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246768194826343d, y: 0.7797556852008829d), new NpgsqlTypes.NpgsqlPoint(x: 0.6223621795826088d, y: 0.1457773107224516d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7877621449243988d, y: 0.14990321719737476d), new NpgsqlTypes.NpgsqlPoint(x: 0.041345181018744404d, y: 0.3708417503602157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159539785246938d, y: 0.5645435091739672d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3332163594185208d, y: 0.9477795401980992d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487004604763159d, y: 0.6214880280552415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574423620432772d, y: 0.7073508040494044d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10799397097484653d, y: 0.47056417991751975d), new NpgsqlTypes.NpgsqlPoint(x: 0.0002661333604216942d, y: 0.8303927516936068d), new NpgsqlTypes.NpgsqlPoint(x: 0.3156535927227774d, y: 0.1478814791116656d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9970756944458837d, y: 0.5466820104793195d), new NpgsqlTypes.NpgsqlPoint(x: 0.17615811914024937d, y: 0.27609011643446546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112392214388656d, y: 0.39120541506535955d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18511286454935194d, y: 0.05691566585265928d), new NpgsqlTypes.NpgsqlPoint(x: 0.16123018122864197d, y: 0.8342398047707426d), new NpgsqlTypes.NpgsqlPoint(x: 0.16234252447887088d, y: 0.1117236097980091d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9540160065631438d, y: 0.6009716682101032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324694746564931d, y: 0.5049687744693373d), new NpgsqlTypes.NpgsqlPoint(x: 0.3148546763620973d, y: 0.025086774674019874d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22037850226920186d, y: 0.903483787221338d), new NpgsqlTypes.NpgsqlPoint(x: 0.09728298935886259d, y: 0.8846108107531995d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675976351651892d, y: 0.8532490356043021d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9492895867727332d, y: 0.023795268799605807d), new NpgsqlTypes.NpgsqlPoint(x: 0.521163671728748d, y: 0.18388808400668688d), new NpgsqlTypes.NpgsqlPoint(x: 0.06887255986254903d, y: 0.23236876562623965d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.033587041416717534d, y: 0.3480957800538681d), new NpgsqlTypes.NpgsqlPoint(x: 0.3930370101495315d, y: 0.6287740295138002d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799081694031863d, y: 0.15846519564385386d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36705405057716767d, y: 0.39440394951768765d), new NpgsqlTypes.NpgsqlPoint(x: 0.31387072608763233d, y: 0.3559866489722999d), new NpgsqlTypes.NpgsqlPoint(x: 0.24662333452338958d, y: 0.01952969942714511d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23433505193135384d, y: 0.7564792181810862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239364016708668d, y: 0.9989285250594461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439286870390097d, y: 0.7016753298562132d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42609629437314944d, y: 0.62683735489905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416302382488913d, y: 0.285913249412308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351233003749531d, y: 0.3493071917145032d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4779060013068406d, y: 0.9951839929703884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566349889347624d, y: 0.48315627553520135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7290468388942687d, y: 0.22028137391153169d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46630840749810243d, y: 0.5953940692553328d), new NpgsqlTypes.NpgsqlPoint(x: 0.17980828788065117d, y: 0.44172800148445435d), new NpgsqlTypes.NpgsqlPoint(x: 0.021714088852444746d, y: 0.050227462977966764d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10323193989748658d, y: 0.987173943444797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617717417297401d, y: 0.8744631886519378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3609494244457343d, y: 0.35557469628223204d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7244418700003552d, y: 0.7843404368777723d), new NpgsqlTypes.NpgsqlPoint(x: 0.21214839380455908d, y: 0.19767392555692287d), new NpgsqlTypes.NpgsqlPoint(x: 0.01407853893444333d, y: 0.7421089605502165d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1304027625139883d, y: 0.5292778472164965d), new NpgsqlTypes.NpgsqlPoint(x: 0.45389907207936253d, y: 0.8854300289906751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5502123246169124d, y: 0.14539605662084654d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11689280400189361d, y: 0.10570619521255609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822063228793331d, y: 0.44299102990651684d), new NpgsqlTypes.NpgsqlPoint(x: 0.2759708132622267d, y: 0.729208017406944d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8655602041667428d, y: 0.7212630465801314d), new NpgsqlTypes.NpgsqlPoint(x: 0.40475561705926666d, y: 0.7283594878083932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204881359063652d, y: 0.9167764019017788d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygone0mi_id", 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 37, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 153, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 44, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 95, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 81, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 102, query1, 157, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 100, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 157, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 82, 156))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[3], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[4], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[5], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[6], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[7], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[8], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[9], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[10], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[11], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[12], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[13], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[14], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[15], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[16], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[17], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[18], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[19], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[20], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[21], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[22], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[23], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[24], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[5], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[6], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[7], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[8], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[9], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[10], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[11], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[12], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[13], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[14], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[15], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[16], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[17], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[18], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[19], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[20], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[21], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[22], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[23], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[24], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5980574113929973d, y: 0.385766924550485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379270927799647d, y: 0.8096282517936184d), new NpgsqlTypes.NpgsqlPoint(x: 0.27305423846354726d, y: 0.35842795427693486d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10121912422970514d, y: 0.040227554169329216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6138760908370734d, y: 0.42526468380867233d), new NpgsqlTypes.NpgsqlPoint(x: 0.07508879865598894d, y: 0.270159974251867d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9618069349808808d, y: 0.14216853646376015d), new NpgsqlTypes.NpgsqlPoint(x: 0.650877746737044d, y: 0.4563620404454507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216627843364824d, y: 0.9215655295032863d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9113120747548149d, y: 0.31261665612596823d), new NpgsqlTypes.NpgsqlPoint(x: 0.4233075860002562d, y: 0.910779628452176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482091911892899d, y: 0.502624029563162d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06395618199138842d, y: 0.3297427333537758d), new NpgsqlTypes.NpgsqlPoint(x: 0.4839585856174782d, y: 0.33257220777754504d), new NpgsqlTypes.NpgsqlPoint(x: 0.3159142360947965d, y: 0.009955258742253559d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29658366859904095d, y: 0.6058632257206177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604271373316251d, y: 0.2930748812898205d), new NpgsqlTypes.NpgsqlPoint(x: 0.07706747128258107d, y: 0.21904588860010643d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31026395971698906d, y: 0.507398895399681d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213644318812664d, y: 0.36117707310729674d), new NpgsqlTypes.NpgsqlPoint(x: 0.2168254438572581d, y: 0.8364008396950278d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22390064516486674d, y: 0.6449942248649049d), new NpgsqlTypes.NpgsqlPoint(x: 0.46108911738817016d, y: 0.003274287251671004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8755514140991774d, y: 0.5631417729226522d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5531201300612044d, y: 0.06380851327546333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454825697521666d, y: 0.5819190239611255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782685804216616d, y: 0.9931596309329329d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4779060013068406d, y: 0.9951839929703884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566349889347624d, y: 0.48315627553520135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7290468388942687d, y: 0.22028137391153169d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.914482603508153d, y: 0.009832627197799648d), new NpgsqlTypes.NpgsqlPoint(x: 0.08295290018246637d, y: 0.3571573626955268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569888630714077d, y: 0.3201044015006921d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.927873587625292d, y: 0.8331470962945449d), new NpgsqlTypes.NpgsqlPoint(x: 0.24241665788459932d, y: 0.449340835888704d), new NpgsqlTypes.NpgsqlPoint(x: 0.44348526672889443d, y: 0.918937299446635d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46630840749810243d, y: 0.5953940692553328d), new NpgsqlTypes.NpgsqlPoint(x: 0.17980828788065117d, y: 0.44172800148445435d), new NpgsqlTypes.NpgsqlPoint(x: 0.021714088852444746d, y: 0.050227462977966764d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5682955300354822d, y: 0.988490872377232d), new NpgsqlTypes.NpgsqlPoint(x: 0.2509840158512108d, y: 0.7673468146812757d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986734196464561d, y: 0.5749009156353676d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10323193989748658d, y: 0.987173943444797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617717417297401d, y: 0.8744631886519378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3609494244457343d, y: 0.35557469628223204d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6463393484449792d, y: 0.5299935355860173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105133522166273d, y: 0.5754478466928044d), new NpgsqlTypes.NpgsqlPoint(x: 0.24167933249202922d, y: 0.9794733353549248d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4209037547304234d, y: 0.2772877197486311d), new NpgsqlTypes.NpgsqlPoint(x: 0.23839527066121358d, y: 0.6569357012545406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374262439845278d, y: 0.41622065246725437d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7244418700003552d, y: 0.7843404368777723d), new NpgsqlTypes.NpgsqlPoint(x: 0.21214839380455908d, y: 0.19767392555692287d), new NpgsqlTypes.NpgsqlPoint(x: 0.01407853893444333d, y: 0.7421089605502165d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011102711465100112d, y: 0.024533087081160865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619699598046427d, y: 0.6758237807382701d), new NpgsqlTypes.NpgsqlPoint(x: 0.0677433714711746d, y: 0.6952213520585462d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07585068695971231d, y: 0.8106853311560462d), new NpgsqlTypes.NpgsqlPoint(x: 0.15650180058064256d, y: 0.003606678350583148d), new NpgsqlTypes.NpgsqlPoint(x: 0.626090462258837d, y: 0.5049008445118139d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6834331096813658d, y: 0.5089953981439336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6224902609989535d, y: 0.7032770781379265d), new NpgsqlTypes.NpgsqlPoint(x: 0.38208320631538906d, y: 0.16304742736124433d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1304027625139883d, y: 0.5292778472164965d), new NpgsqlTypes.NpgsqlPoint(x: 0.45389907207936253d, y: 0.8854300289906751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5502123246169124d, y: 0.14539605662084654d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9897067820714298d, y: 0.4038859450219897d), new NpgsqlTypes.NpgsqlPoint(x: 0.38390691320878634d, y: 0.32759185797477264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3368076459529723d, y: 0.14045955488270623d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11689280400189361d, y: 0.10570619521255609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822063228793331d, y: 0.44299102990651684d), new NpgsqlTypes.NpgsqlPoint(x: 0.2759708132622267d, y: 0.729208017406944d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41376244121085715d, y: 0.9892301061615031d), new NpgsqlTypes.NpgsqlPoint(x: 0.06498895044116182d, y: 0.931906060854572d), new NpgsqlTypes.NpgsqlPoint(x: 0.47492144563331196d, y: 0.16577273231871992d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5007594968567148d, y: 0.34449998081288147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5301651663687584d, y: 0.1037913275589818d), new NpgsqlTypes.NpgsqlPoint(x: 0.0075898998989120114d, y: 0.7157529840830489d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8794956342523508d, y: 0.9903848967804053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6041249499222934d, y: 0.5594312818794078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738662247370407d, y: 0.43363539722386024d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8655602041667428d, y: 0.7212630465801314d), new NpgsqlTypes.NpgsqlPoint(x: 0.40475561705926666d, y: 0.7283594878083932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204881359063652d, y: 0.9167764019017788d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9572910031125242d, y: 0.7001385968436183d), new NpgsqlTypes.NpgsqlPoint(x: 0.345761401858516d, y: 0.9710276742690737d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923197337353681d, y: 0.09563574021936416d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7837077153974836d, y: 0.801967472465659d), new NpgsqlTypes.NpgsqlPoint(x: 0.16826471903574447d, y: 0.4551771805314929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333927558557008d, y: 0.8299163156478325d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13749952400498333d, y: 0.8394271524837595d), new NpgsqlTypes.NpgsqlPoint(x: 0.8997727535525173d, y: 0.254568178691156d), new NpgsqlTypes.NpgsqlPoint(x: 0.422957886576975d, y: 0.74650579800172d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8271807699321825d, y: 0.8565626046829378d), new NpgsqlTypes.NpgsqlPoint(x: 0.16530409908313903d, y: 0.5256967908203836d), new NpgsqlTypes.NpgsqlPoint(x: 0.949611889866512d, y: 0.6619347115822539d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2047500605770073d, y: 0.0004660374611525908d), new NpgsqlTypes.NpgsqlPoint(x: 0.2888690739383801d, y: 0.14624050519700293d), new NpgsqlTypes.NpgsqlPoint(x: 0.19714611436580998d, y: 0.1486170505688702d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5852211457454095d, y: 0.5663768006174127d), new NpgsqlTypes.NpgsqlPoint(x: 0.26114408436615d, y: 0.6431677399103347d), new NpgsqlTypes.NpgsqlPoint(x: 0.3898682065123865d, y: 0.47440541976348716d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22387313039838885d, y: 0.44089045976766406d), new NpgsqlTypes.NpgsqlPoint(x: 0.15879849190952333d, y: 0.19724414110524868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9195895940232144d, y: 0.30796030175144606d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41825398151147886d, y: 0.5752164765224086d), new NpgsqlTypes.NpgsqlPoint(x: 0.3518719933361071d, y: 0.7780052788263188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9849141605364565d, y: 0.952397250322284d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29034221553679285d, y: 0.7802070168838141d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730940068252274d, y: 0.748404182733922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025872348240364d, y: 0.8404183551198868d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9515669001879214d, y: 0.30180064937269746d), new NpgsqlTypes.NpgsqlPoint(x: 0.9181513762132527d, y: 0.1760267867247608d), new NpgsqlTypes.NpgsqlPoint(x: 0.22617483207159228d, y: 0.2473143562684712d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5536643714521331d, y: 0.6264833523574663d), new NpgsqlTypes.NpgsqlPoint(x: 0.851109855588335d, y: 0.6301258248790254d), new NpgsqlTypes.NpgsqlPoint(x: 0.10161377387953341d, y: 0.31070813058156477d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.420947246033583d, y: 0.5234772312453444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663319338713687d, y: 0.21736836080801447d), new NpgsqlTypes.NpgsqlPoint(x: 0.29907782386824533d, y: 0.41187674126503204d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26015946224595987d, y: 0.1427946974249782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584901901659893d, y: 0.22439438427768976d), new NpgsqlTypes.NpgsqlPoint(x: 0.0731266831434132d, y: 0.7182173557587102d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3917802522598969d, y: 0.44595746314285156d), new NpgsqlTypes.NpgsqlPoint(x: 0.4590974492732989d, y: 0.9280385119961846d), new NpgsqlTypes.NpgsqlPoint(x: 0.08644964173652647d, y: 0.6541547111878623d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8850864881174477d, y: 0.9059189981624346d), new NpgsqlTypes.NpgsqlPoint(x: 0.31455459484581483d, y: 0.5193044222233734d), new NpgsqlTypes.NpgsqlPoint(x: 0.12389361597667092d, y: 0.5371052036922771d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6542999415595596d, y: 0.3208819371736501d), new NpgsqlTypes.NpgsqlPoint(x: 0.36718060319012447d, y: 0.8791686311630753d), new NpgsqlTypes.NpgsqlPoint(x: 0.24936674962868455d, y: 0.15661707181695517d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9560488402987922d, y: 0.3497343841530268d), new NpgsqlTypes.NpgsqlPoint(x: 0.21354080806696585d, y: 0.776372390374598d), new NpgsqlTypes.NpgsqlPoint(x: 0.728751563308514d, y: 0.6938389390249683d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9650557976622725d, y: 0.1886185701223725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2795766915193535d, y: 0.7251911855214607d), new NpgsqlTypes.NpgsqlPoint(x: 0.558913689835209d, y: 0.07385819056359633d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41543023454951244d, y: 0.8344858824302002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9856694780246233d, y: 0.5123772155625881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468981551949868d, y: 0.5933506095409132d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09842561952980577d, y: 0.5263278668706587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5854447666485358d, y: 0.2060890749366392d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527363285559022d, y: 0.879608160987421d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24285070017291044d, y: 0.6685091209262206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8222950834772481d, y: 0.03268747586464127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9732091029919503d, y: 0.5029536599909696d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1810585554580083d, y: 0.9580365879497108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837125723561914d, y: 0.4474710529950511d), new NpgsqlTypes.NpgsqlPoint(x: 0.3336048010794809d, y: 0.9755115011510573d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3533392378105572d, y: 0.9548311035960866d), new NpgsqlTypes.NpgsqlPoint(x: 0.26087730782948537d, y: 0.1548898366093373d), new NpgsqlTypes.NpgsqlPoint(x: 0.4738513965188096d, y: 0.17192186669476683d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26044246076504474d, y: 0.9082108500226197d), new NpgsqlTypes.NpgsqlPoint(x: 0.18614674669247278d, y: 0.1736056901948395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7059511708803168d, y: 0.39153999860119604d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5762765161951258d, y: 0.2333956151094988d), new NpgsqlTypes.NpgsqlPoint(x: 0.464390390929758d, y: 0.7888643143192458d), new NpgsqlTypes.NpgsqlPoint(x: 0.13849116719963295d, y: 0.002731772829106971d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39589865920511724d, y: 0.6575125369305399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8605157944036954d, y: 0.11576684879621646d), new NpgsqlTypes.NpgsqlPoint(x: 0.469617640436062d, y: 0.006369659102225866d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4001666676637746d, y: 0.06549836941220444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239332921249297d, y: 0.1421331096211077d), new NpgsqlTypes.NpgsqlPoint(x: 0.08658419227536918d, y: 0.3083697828319517d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9358676774576509d, y: 0.7606729570782389d), new NpgsqlTypes.NpgsqlPoint(x: 0.269014414286456d, y: 0.9925271325672753d), new NpgsqlTypes.NpgsqlPoint(x: 0.5795630764329389d, y: 0.4428535004897508d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3413021185557211d, y: 0.8352567341211687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869425097886397d, y: 0.24170971260728147d), new NpgsqlTypes.NpgsqlPoint(x: 0.059320924259443464d, y: 0.03049634947541624d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31033283386711674d, y: 0.922976776067734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093810817158138d, y: 0.05606135131894141d), new NpgsqlTypes.NpgsqlPoint(x: 0.3471373567545226d, y: 0.20958523428733766d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28955496415419546d, y: 0.44263315222997734d), new NpgsqlTypes.NpgsqlPoint(x: 0.2398841472774712d, y: 0.5403617851419975d), new NpgsqlTypes.NpgsqlPoint(x: 0.030414238102016933d, y: 0.48476610517522645d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20549583956395523d, y: 0.45337352854753565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3796379349171325d, y: 0.9516878243757061d), new NpgsqlTypes.NpgsqlPoint(x: 0.0026214736788373605d, y: 0.7906661874759382d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6351340418032393d, y: 0.9550170780968357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130988378796427d, y: 0.5845143460104668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988785266344944d, y: 0.3586619155972587d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7012948143740321d, y: 0.7834796162663082d), new NpgsqlTypes.NpgsqlPoint(x: 0.680011524156263d, y: 0.1496054315702795d), new NpgsqlTypes.NpgsqlPoint(x: 0.37034452807216434d, y: 0.9512690980952383d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34014062284258617d, y: 0.7667969858644677d), new NpgsqlTypes.NpgsqlPoint(x: 0.016813093524329026d, y: 0.6287341655559603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5614056426339409d, y: 0.4773572943521398d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.254729675349326d, y: 0.9355452303146735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7860344753106718d, y: 0.4887369464600614d), new NpgsqlTypes.NpgsqlPoint(x: 0.08300088343659728d, y: 0.599032472682749d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4964492760092667d, y: 0.1803857940721597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243245477608191d, y: 0.8659985835993596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440394325109427d, y: 0.8941792659924385d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5497301164705019d, y: 0.24393691717680965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9707776552711829d, y: 0.5439572679306401d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642171030918913d, y: 0.23389824271446857d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8876164846996073d, y: 0.3631334402792098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4320943678474769d, y: 0.08612235619882358d), new NpgsqlTypes.NpgsqlPoint(x: 0.7487744425391831d, y: 0.38471256359741446d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5281184552929372d, y: 0.5157897331542906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246768194826343d, y: 0.7797556852008829d), new NpgsqlTypes.NpgsqlPoint(x: 0.6223621795826088d, y: 0.1457773107224516d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7877621449243988d, y: 0.14990321719737476d), new NpgsqlTypes.NpgsqlPoint(x: 0.041345181018744404d, y: 0.3708417503602157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159539785246938d, y: 0.5645435091739672d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3332163594185208d, y: 0.9477795401980992d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487004604763159d, y: 0.6214880280552415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574423620432772d, y: 0.7073508040494044d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10799397097484653d, y: 0.47056417991751975d), new NpgsqlTypes.NpgsqlPoint(x: 0.0002661333604216942d, y: 0.8303927516936068d), new NpgsqlTypes.NpgsqlPoint(x: 0.3156535927227774d, y: 0.1478814791116656d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9970756944458837d, y: 0.5466820104793195d), new NpgsqlTypes.NpgsqlPoint(x: 0.17615811914024937d, y: 0.27609011643446546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112392214388656d, y: 0.39120541506535955d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18511286454935194d, y: 0.05691566585265928d), new NpgsqlTypes.NpgsqlPoint(x: 0.16123018122864197d, y: 0.8342398047707426d), new NpgsqlTypes.NpgsqlPoint(x: 0.16234252447887088d, y: 0.1117236097980091d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9540160065631438d, y: 0.6009716682101032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324694746564931d, y: 0.5049687744693373d), new NpgsqlTypes.NpgsqlPoint(x: 0.3148546763620973d, y: 0.025086774674019874d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22037850226920186d, y: 0.903483787221338d), new NpgsqlTypes.NpgsqlPoint(x: 0.09728298935886259d, y: 0.8846108107531995d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675976351651892d, y: 0.8532490356043021d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9492895867727332d, y: 0.023795268799605807d), new NpgsqlTypes.NpgsqlPoint(x: 0.521163671728748d, y: 0.18388808400668688d), new NpgsqlTypes.NpgsqlPoint(x: 0.06887255986254903d, y: 0.23236876562623965d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.033587041416717534d, y: 0.3480957800538681d), new NpgsqlTypes.NpgsqlPoint(x: 0.3930370101495315d, y: 0.6287740295138002d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799081694031863d, y: 0.15846519564385386d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36705405057716767d, y: 0.39440394951768765d), new NpgsqlTypes.NpgsqlPoint(x: 0.31387072608763233d, y: 0.3559866489722999d), new NpgsqlTypes.NpgsqlPoint(x: 0.24662333452338958d, y: 0.01952969942714511d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23433505193135384d, y: 0.7564792181810862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239364016708668d, y: 0.9989285250594461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439286870390097d, y: 0.7016753298562132d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42609629437314944d, y: 0.62683735489905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416302382488913d, y: 0.285913249412308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351233003749531d, y: 0.3493071917145032d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5980574113929973d, y: 0.385766924550485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379270927799647d, y: 0.8096282517936184d), new NpgsqlTypes.NpgsqlPoint(x: 0.27305423846354726d, y: 0.35842795427693486d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10121912422970514d, y: 0.040227554169329216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6138760908370734d, y: 0.42526468380867233d), new NpgsqlTypes.NpgsqlPoint(x: 0.07508879865598894d, y: 0.270159974251867d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9618069349808808d, y: 0.14216853646376015d), new NpgsqlTypes.NpgsqlPoint(x: 0.650877746737044d, y: 0.4563620404454507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216627843364824d, y: 0.9215655295032863d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9113120747548149d, y: 0.31261665612596823d), new NpgsqlTypes.NpgsqlPoint(x: 0.4233075860002562d, y: 0.910779628452176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482091911892899d, y: 0.502624029563162d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06395618199138842d, y: 0.3297427333537758d), new NpgsqlTypes.NpgsqlPoint(x: 0.4839585856174782d, y: 0.33257220777754504d), new NpgsqlTypes.NpgsqlPoint(x: 0.3159142360947965d, y: 0.009955258742253559d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29658366859904095d, y: 0.6058632257206177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604271373316251d, y: 0.2930748812898205d), new NpgsqlTypes.NpgsqlPoint(x: 0.07706747128258107d, y: 0.21904588860010643d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31026395971698906d, y: 0.507398895399681d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213644318812664d, y: 0.36117707310729674d), new NpgsqlTypes.NpgsqlPoint(x: 0.2168254438572581d, y: 0.8364008396950278d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22390064516486674d, y: 0.6449942248649049d), new NpgsqlTypes.NpgsqlPoint(x: 0.46108911738817016d, y: 0.003274287251671004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8755514140991774d, y: 0.5631417729226522d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5531201300612044d, y: 0.06380851327546333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454825697521666d, y: 0.5819190239611255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782685804216616d, y: 0.9931596309329329d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4779060013068406d, y: 0.9951839929703884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566349889347624d, y: 0.48315627553520135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7290468388942687d, y: 0.22028137391153169d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.914482603508153d, y: 0.009832627197799648d), new NpgsqlTypes.NpgsqlPoint(x: 0.08295290018246637d, y: 0.3571573626955268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569888630714077d, y: 0.3201044015006921d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.927873587625292d, y: 0.8331470962945449d), new NpgsqlTypes.NpgsqlPoint(x: 0.24241665788459932d, y: 0.449340835888704d), new NpgsqlTypes.NpgsqlPoint(x: 0.44348526672889443d, y: 0.918937299446635d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46630840749810243d, y: 0.5953940692553328d), new NpgsqlTypes.NpgsqlPoint(x: 0.17980828788065117d, y: 0.44172800148445435d), new NpgsqlTypes.NpgsqlPoint(x: 0.021714088852444746d, y: 0.050227462977966764d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5682955300354822d, y: 0.988490872377232d), new NpgsqlTypes.NpgsqlPoint(x: 0.2509840158512108d, y: 0.7673468146812757d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986734196464561d, y: 0.5749009156353676d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10323193989748658d, y: 0.987173943444797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617717417297401d, y: 0.8744631886519378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3609494244457343d, y: 0.35557469628223204d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6463393484449792d, y: 0.5299935355860173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105133522166273d, y: 0.5754478466928044d), new NpgsqlTypes.NpgsqlPoint(x: 0.24167933249202922d, y: 0.9794733353549248d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4209037547304234d, y: 0.2772877197486311d), new NpgsqlTypes.NpgsqlPoint(x: 0.23839527066121358d, y: 0.6569357012545406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374262439845278d, y: 0.41622065246725437d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7244418700003552d, y: 0.7843404368777723d), new NpgsqlTypes.NpgsqlPoint(x: 0.21214839380455908d, y: 0.19767392555692287d), new NpgsqlTypes.NpgsqlPoint(x: 0.01407853893444333d, y: 0.7421089605502165d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011102711465100112d, y: 0.024533087081160865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619699598046427d, y: 0.6758237807382701d), new NpgsqlTypes.NpgsqlPoint(x: 0.0677433714711746d, y: 0.6952213520585462d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07585068695971231d, y: 0.8106853311560462d), new NpgsqlTypes.NpgsqlPoint(x: 0.15650180058064256d, y: 0.003606678350583148d), new NpgsqlTypes.NpgsqlPoint(x: 0.626090462258837d, y: 0.5049008445118139d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6834331096813658d, y: 0.5089953981439336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6224902609989535d, y: 0.7032770781379265d), new NpgsqlTypes.NpgsqlPoint(x: 0.38208320631538906d, y: 0.16304742736124433d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1304027625139883d, y: 0.5292778472164965d), new NpgsqlTypes.NpgsqlPoint(x: 0.45389907207936253d, y: 0.8854300289906751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5502123246169124d, y: 0.14539605662084654d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9897067820714298d, y: 0.4038859450219897d), new NpgsqlTypes.NpgsqlPoint(x: 0.38390691320878634d, y: 0.32759185797477264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3368076459529723d, y: 0.14045955488270623d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11689280400189361d, y: 0.10570619521255609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822063228793331d, y: 0.44299102990651684d), new NpgsqlTypes.NpgsqlPoint(x: 0.2759708132622267d, y: 0.729208017406944d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41376244121085715d, y: 0.9892301061615031d), new NpgsqlTypes.NpgsqlPoint(x: 0.06498895044116182d, y: 0.931906060854572d), new NpgsqlTypes.NpgsqlPoint(x: 0.47492144563331196d, y: 0.16577273231871992d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5007594968567148d, y: 0.34449998081288147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5301651663687584d, y: 0.1037913275589818d), new NpgsqlTypes.NpgsqlPoint(x: 0.0075898998989120114d, y: 0.7157529840830489d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8794956342523508d, y: 0.9903848967804053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6041249499222934d, y: 0.5594312818794078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738662247370407d, y: 0.43363539722386024d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8655602041667428d, y: 0.7212630465801314d), new NpgsqlTypes.NpgsqlPoint(x: 0.40475561705926666d, y: 0.7283594878083932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204881359063652d, y: 0.9167764019017788d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9572910031125242d, y: 0.7001385968436183d), new NpgsqlTypes.NpgsqlPoint(x: 0.345761401858516d, y: 0.9710276742690737d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923197337353681d, y: 0.09563574021936416d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7837077153974836d, y: 0.801967472465659d), new NpgsqlTypes.NpgsqlPoint(x: 0.16826471903574447d, y: 0.4551771805314929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333927558557008d, y: 0.8299163156478325d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13749952400498333d, y: 0.8394271524837595d), new NpgsqlTypes.NpgsqlPoint(x: 0.8997727535525173d, y: 0.254568178691156d), new NpgsqlTypes.NpgsqlPoint(x: 0.422957886576975d, y: 0.74650579800172d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8271807699321825d, y: 0.8565626046829378d), new NpgsqlTypes.NpgsqlPoint(x: 0.16530409908313903d, y: 0.5256967908203836d), new NpgsqlTypes.NpgsqlPoint(x: 0.949611889866512d, y: 0.6619347115822539d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2047500605770073d, y: 0.0004660374611525908d), new NpgsqlTypes.NpgsqlPoint(x: 0.2888690739383801d, y: 0.14624050519700293d), new NpgsqlTypes.NpgsqlPoint(x: 0.19714611436580998d, y: 0.1486170505688702d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5852211457454095d, y: 0.5663768006174127d), new NpgsqlTypes.NpgsqlPoint(x: 0.26114408436615d, y: 0.6431677399103347d), new NpgsqlTypes.NpgsqlPoint(x: 0.3898682065123865d, y: 0.47440541976348716d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22387313039838885d, y: 0.44089045976766406d), new NpgsqlTypes.NpgsqlPoint(x: 0.15879849190952333d, y: 0.19724414110524868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9195895940232144d, y: 0.30796030175144606d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41825398151147886d, y: 0.5752164765224086d), new NpgsqlTypes.NpgsqlPoint(x: 0.3518719933361071d, y: 0.7780052788263188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9849141605364565d, y: 0.952397250322284d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29034221553679285d, y: 0.7802070168838141d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730940068252274d, y: 0.748404182733922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025872348240364d, y: 0.8404183551198868d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9515669001879214d, y: 0.30180064937269746d), new NpgsqlTypes.NpgsqlPoint(x: 0.9181513762132527d, y: 0.1760267867247608d), new NpgsqlTypes.NpgsqlPoint(x: 0.22617483207159228d, y: 0.2473143562684712d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5536643714521331d, y: 0.6264833523574663d), new NpgsqlTypes.NpgsqlPoint(x: 0.851109855588335d, y: 0.6301258248790254d), new NpgsqlTypes.NpgsqlPoint(x: 0.10161377387953341d, y: 0.31070813058156477d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.420947246033583d, y: 0.5234772312453444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663319338713687d, y: 0.21736836080801447d), new NpgsqlTypes.NpgsqlPoint(x: 0.29907782386824533d, y: 0.41187674126503204d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26015946224595987d, y: 0.1427946974249782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584901901659893d, y: 0.22439438427768976d), new NpgsqlTypes.NpgsqlPoint(x: 0.0731266831434132d, y: 0.7182173557587102d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3917802522598969d, y: 0.44595746314285156d), new NpgsqlTypes.NpgsqlPoint(x: 0.4590974492732989d, y: 0.9280385119961846d), new NpgsqlTypes.NpgsqlPoint(x: 0.08644964173652647d, y: 0.6541547111878623d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8850864881174477d, y: 0.9059189981624346d), new NpgsqlTypes.NpgsqlPoint(x: 0.31455459484581483d, y: 0.5193044222233734d), new NpgsqlTypes.NpgsqlPoint(x: 0.12389361597667092d, y: 0.5371052036922771d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6542999415595596d, y: 0.3208819371736501d), new NpgsqlTypes.NpgsqlPoint(x: 0.36718060319012447d, y: 0.8791686311630753d), new NpgsqlTypes.NpgsqlPoint(x: 0.24936674962868455d, y: 0.15661707181695517d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9560488402987922d, y: 0.3497343841530268d), new NpgsqlTypes.NpgsqlPoint(x: 0.21354080806696585d, y: 0.776372390374598d), new NpgsqlTypes.NpgsqlPoint(x: 0.728751563308514d, y: 0.6938389390249683d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9650557976622725d, y: 0.1886185701223725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2795766915193535d, y: 0.7251911855214607d), new NpgsqlTypes.NpgsqlPoint(x: 0.558913689835209d, y: 0.07385819056359633d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41543023454951244d, y: 0.8344858824302002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9856694780246233d, y: 0.5123772155625881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468981551949868d, y: 0.5933506095409132d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09842561952980577d, y: 0.5263278668706587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5854447666485358d, y: 0.2060890749366392d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527363285559022d, y: 0.879608160987421d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24285070017291044d, y: 0.6685091209262206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8222950834772481d, y: 0.03268747586464127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9732091029919503d, y: 0.5029536599909696d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1810585554580083d, y: 0.9580365879497108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837125723561914d, y: 0.4474710529950511d), new NpgsqlTypes.NpgsqlPoint(x: 0.3336048010794809d, y: 0.9755115011510573d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3533392378105572d, y: 0.9548311035960866d), new NpgsqlTypes.NpgsqlPoint(x: 0.26087730782948537d, y: 0.1548898366093373d), new NpgsqlTypes.NpgsqlPoint(x: 0.4738513965188096d, y: 0.17192186669476683d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26044246076504474d, y: 0.9082108500226197d), new NpgsqlTypes.NpgsqlPoint(x: 0.18614674669247278d, y: 0.1736056901948395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7059511708803168d, y: 0.39153999860119604d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5762765161951258d, y: 0.2333956151094988d), new NpgsqlTypes.NpgsqlPoint(x: 0.464390390929758d, y: 0.7888643143192458d), new NpgsqlTypes.NpgsqlPoint(x: 0.13849116719963295d, y: 0.002731772829106971d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39589865920511724d, y: 0.6575125369305399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8605157944036954d, y: 0.11576684879621646d), new NpgsqlTypes.NpgsqlPoint(x: 0.469617640436062d, y: 0.006369659102225866d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4001666676637746d, y: 0.06549836941220444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239332921249297d, y: 0.1421331096211077d), new NpgsqlTypes.NpgsqlPoint(x: 0.08658419227536918d, y: 0.3083697828319517d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9358676774576509d, y: 0.7606729570782389d), new NpgsqlTypes.NpgsqlPoint(x: 0.269014414286456d, y: 0.9925271325672753d), new NpgsqlTypes.NpgsqlPoint(x: 0.5795630764329389d, y: 0.4428535004897508d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3413021185557211d, y: 0.8352567341211687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869425097886397d, y: 0.24170971260728147d), new NpgsqlTypes.NpgsqlPoint(x: 0.059320924259443464d, y: 0.03049634947541624d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31033283386711674d, y: 0.922976776067734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093810817158138d, y: 0.05606135131894141d), new NpgsqlTypes.NpgsqlPoint(x: 0.3471373567545226d, y: 0.20958523428733766d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28955496415419546d, y: 0.44263315222997734d), new NpgsqlTypes.NpgsqlPoint(x: 0.2398841472774712d, y: 0.5403617851419975d), new NpgsqlTypes.NpgsqlPoint(x: 0.030414238102016933d, y: 0.48476610517522645d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20549583956395523d, y: 0.45337352854753565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3796379349171325d, y: 0.9516878243757061d), new NpgsqlTypes.NpgsqlPoint(x: 0.0026214736788373605d, y: 0.7906661874759382d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6351340418032393d, y: 0.9550170780968357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130988378796427d, y: 0.5845143460104668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988785266344944d, y: 0.3586619155972587d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7012948143740321d, y: 0.7834796162663082d), new NpgsqlTypes.NpgsqlPoint(x: 0.680011524156263d, y: 0.1496054315702795d), new NpgsqlTypes.NpgsqlPoint(x: 0.37034452807216434d, y: 0.9512690980952383d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34014062284258617d, y: 0.7667969858644677d), new NpgsqlTypes.NpgsqlPoint(x: 0.016813093524329026d, y: 0.6287341655559603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5614056426339409d, y: 0.4773572943521398d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.254729675349326d, y: 0.9355452303146735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7860344753106718d, y: 0.4887369464600614d), new NpgsqlTypes.NpgsqlPoint(x: 0.08300088343659728d, y: 0.599032472682749d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4964492760092667d, y: 0.1803857940721597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243245477608191d, y: 0.8659985835993596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440394325109427d, y: 0.8941792659924385d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5497301164705019d, y: 0.24393691717680965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9707776552711829d, y: 0.5439572679306401d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642171030918913d, y: 0.23389824271446857d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8876164846996073d, y: 0.3631334402792098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4320943678474769d, y: 0.08612235619882358d), new NpgsqlTypes.NpgsqlPoint(x: 0.7487744425391831d, y: 0.38471256359741446d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5281184552929372d, y: 0.5157897331542906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246768194826343d, y: 0.7797556852008829d), new NpgsqlTypes.NpgsqlPoint(x: 0.6223621795826088d, y: 0.1457773107224516d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7877621449243988d, y: 0.14990321719737476d), new NpgsqlTypes.NpgsqlPoint(x: 0.041345181018744404d, y: 0.3708417503602157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159539785246938d, y: 0.5645435091739672d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3332163594185208d, y: 0.9477795401980992d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487004604763159d, y: 0.6214880280552415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574423620432772d, y: 0.7073508040494044d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10799397097484653d, y: 0.47056417991751975d), new NpgsqlTypes.NpgsqlPoint(x: 0.0002661333604216942d, y: 0.8303927516936068d), new NpgsqlTypes.NpgsqlPoint(x: 0.3156535927227774d, y: 0.1478814791116656d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9970756944458837d, y: 0.5466820104793195d), new NpgsqlTypes.NpgsqlPoint(x: 0.17615811914024937d, y: 0.27609011643446546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112392214388656d, y: 0.39120541506535955d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18511286454935194d, y: 0.05691566585265928d), new NpgsqlTypes.NpgsqlPoint(x: 0.16123018122864197d, y: 0.8342398047707426d), new NpgsqlTypes.NpgsqlPoint(x: 0.16234252447887088d, y: 0.1117236097980091d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9540160065631438d, y: 0.6009716682101032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324694746564931d, y: 0.5049687744693373d), new NpgsqlTypes.NpgsqlPoint(x: 0.3148546763620973d, y: 0.025086774674019874d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22037850226920186d, y: 0.903483787221338d), new NpgsqlTypes.NpgsqlPoint(x: 0.09728298935886259d, y: 0.8846108107531995d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675976351651892d, y: 0.8532490356043021d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9492895867727332d, y: 0.023795268799605807d), new NpgsqlTypes.NpgsqlPoint(x: 0.521163671728748d, y: 0.18388808400668688d), new NpgsqlTypes.NpgsqlPoint(x: 0.06887255986254903d, y: 0.23236876562623965d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.033587041416717534d, y: 0.3480957800538681d), new NpgsqlTypes.NpgsqlPoint(x: 0.3930370101495315d, y: 0.6287740295138002d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799081694031863d, y: 0.15846519564385386d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36705405057716767d, y: 0.39440394951768765d), new NpgsqlTypes.NpgsqlPoint(x: 0.31387072608763233d, y: 0.3559866489722999d), new NpgsqlTypes.NpgsqlPoint(x: 0.24662333452338958d, y: 0.01952969942714511d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23433505193135384d, y: 0.7564792181810862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239364016708668d, y: 0.9989285250594461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439286870390097d, y: 0.7016753298562132d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42609629437314944d, y: 0.62683735489905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416302382488913d, y: 0.285913249412308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351233003749531d, y: 0.3493071917145032d)))));

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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygone0m m
LEFT JOIN public.binary_npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI), typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygonE0MI>();
                var models2 = new List<NpgsqlPolygonpolygonE0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MI>();
                var models2 = new List<NpgsqlPolygonpolygonE0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

