

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
    internal partial interface INpgsqlPolygonArraypolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonArraypolygonArray : INpgsqlPolygonArraypolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray1M[] _testData = new NpgsqlPolygonpolygonArray1M[]
        {
            new NpgsqlPolygonpolygonArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.852922309888824d, y: 0.6127284776885189d), new NpgsqlTypes.NpgsqlPoint(x: 0.25942899715132495d, y: 0.310123454181918d), new NpgsqlTypes.NpgsqlPoint(x: 0.6210383794819033d, y: 0.9850597722856155d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34015696245389127d, y: 0.18658685459074387d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978472723881633d, y: 0.7011847398029855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290146778832547d, y: 0.9454125830217078d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08359428827601345d, y: 0.20151331251689264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6740331221055499d, y: 0.14280018288883578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494098105922759d, y: 0.7640054301890258d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37416263241621617d, y: 0.14018519250335715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6755342422870086d, y: 0.12095865754461288d), new NpgsqlTypes.NpgsqlPoint(x: 0.040391043507912894d, y: 0.4685952586593165d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25873852623903826d, y: 0.042534172140435866d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833656431815073d, y: 0.016782021227939814d), new NpgsqlTypes.NpgsqlPoint(x: 0.31042216221650787d, y: 0.45146004972811116d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2893115497165758d, y: 0.8620595636139327d), new NpgsqlTypes.NpgsqlPoint(x: 0.4334820201109698d, y: 0.7523489038734629d), new NpgsqlTypes.NpgsqlPoint(x: 0.31766438056278945d, y: 0.31899545139659014d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49541511829711227d, y: 0.7804263821108578d), new NpgsqlTypes.NpgsqlPoint(x: 0.9269235889500372d, y: 0.9697147992997385d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974742118839224d, y: 0.08952664322357473d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7826235256271576d, y: 0.07492353258463014d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776051704342739d, y: 0.1908163509584414d), new NpgsqlTypes.NpgsqlPoint(x: 0.11797694075004428d, y: 0.13043053313526698d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14657195240728238d, y: 0.019054711872284136d), new NpgsqlTypes.NpgsqlPoint(x: 0.3704811006824583d, y: 0.4368624519046759d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285057585708451d, y: 0.697651927658083d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21492017949195608d, y: 0.8753468252223598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6244434918970934d, y: 0.23506328987424596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7429075546003712d, y: 0.17975254691346232d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4872144381615783d, y: 0.23781008436614448d), new NpgsqlTypes.NpgsqlPoint(x: 0.3104753336183639d, y: 0.728162314391968d), new NpgsqlTypes.NpgsqlPoint(x: 0.2403983356885001d, y: 0.6493992143211647d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5135622852522983d, y: 0.4031745801748837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8455732518729854d, y: 0.07449476165755042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677167438340824d, y: 0.6703859165259448d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39907089271799345d, y: 0.2532919923929463d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808984184285261d, y: 0.14246317740490322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6125466844802615d, y: 0.1537539084688232d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9966429023864888d, y: 0.9992853180379119d), new NpgsqlTypes.NpgsqlPoint(x: 0.30516451073299544d, y: 0.22894969059338977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9099657854640361d, y: 0.559849287527026d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.050085017316118474d, y: 0.9697756374872077d), new NpgsqlTypes.NpgsqlPoint(x: 0.4894365200450883d, y: 0.9976136649338795d), new NpgsqlTypes.NpgsqlPoint(x: 0.3367870484709955d, y: 0.7295026743769466d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9023644660814387d, y: 0.5875539589866048d), new NpgsqlTypes.NpgsqlPoint(x: 0.133632213879055d, y: 0.3266240917940868d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209891425452688d, y: 0.18476088010534808d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.96300631352953d, y: 0.9439737341421279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273591241712428d, y: 0.6410314218954591d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414320776978308d, y: 0.5136718448965982d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3156422337125713d, y: 0.2618141396107234d), new NpgsqlTypes.NpgsqlPoint(x: 0.46109704951228014d, y: 0.14070315239302744d), new NpgsqlTypes.NpgsqlPoint(x: 0.8578828066764776d, y: 0.9665361275262208d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20165032561981722d, y: 0.8786294185492879d), new NpgsqlTypes.NpgsqlPoint(x: 0.9635387069263649d, y: 0.6214842646777425d), new NpgsqlTypes.NpgsqlPoint(x: 0.10030175467921376d, y: 0.17025295738145163d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3784032743949691d, y: 0.13191987012709383d), new NpgsqlTypes.NpgsqlPoint(x: 0.3832211769291286d, y: 0.8141163866530428d), new NpgsqlTypes.NpgsqlPoint(x: 0.41641809309797917d, y: 0.8660871029892951d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8005839279296968d, y: 0.46505580998295537d), new NpgsqlTypes.NpgsqlPoint(x: 0.3193515268029866d, y: 0.788461204348074d), new NpgsqlTypes.NpgsqlPoint(x: 0.07684866522863609d, y: 0.9242812441150348d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8231416464564353d, y: 0.7506298883468565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452021903120488d, y: 0.1320958705704165d), new NpgsqlTypes.NpgsqlPoint(x: 0.44823537928351953d, y: 0.26843158938964073d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32921846469424154d, y: 0.429202312095755d), new NpgsqlTypes.NpgsqlPoint(x: 0.04245467835380945d, y: 0.6924882680491484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6146770584082846d, y: 0.24185926470757502d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5277886391352226d, y: 0.06057798759248112d), new NpgsqlTypes.NpgsqlPoint(x: 0.4356913206208305d, y: 0.03797138982336401d), new NpgsqlTypes.NpgsqlPoint(x: 0.29527580499437034d, y: 0.32008165688311185d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7286030849071196d, y: 0.06284267780943764d), new NpgsqlTypes.NpgsqlPoint(x: 0.562367416480295d, y: 0.7891909733130716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8958498504129855d, y: 0.3221524959133626d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7522997419829222d, y: 0.1486271812137434d), new NpgsqlTypes.NpgsqlPoint(x: 0.3275665997072934d, y: 0.6424929680210237d), new NpgsqlTypes.NpgsqlPoint(x: 0.3961498927460749d, y: 0.4735593310789762d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8601952519859445d, y: 0.040383158136437336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286783827420931d, y: 0.24850960961143576d), new NpgsqlTypes.NpgsqlPoint(x: 0.09698273427807724d, y: 0.40460330795273813d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9957105483219195d, y: 0.6136857329504813d), new NpgsqlTypes.NpgsqlPoint(x: 0.12789605945408833d, y: 0.9489136562568775d), new NpgsqlTypes.NpgsqlPoint(x: 0.5387103820266608d, y: 0.48187904962383143d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7197707443331101d, y: 0.7329570336191031d), new NpgsqlTypes.NpgsqlPoint(x: 0.619460511947262d, y: 0.22053204698139162d), new NpgsqlTypes.NpgsqlPoint(x: 0.35413669446547025d, y: 0.23684443381149745d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20126716146506785d, y: 0.6631574491886602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6216994301502211d, y: 0.8227256613386995d), new NpgsqlTypes.NpgsqlPoint(x: 0.02816872086583244d, y: 0.3194862973640631d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7493936594756664d, y: 0.3428375393977471d), new NpgsqlTypes.NpgsqlPoint(x: 0.582339727254153d, y: 0.5933333136364738d), new NpgsqlTypes.NpgsqlPoint(x: 0.07494533824159622d, y: 0.4547912371438443d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5831896885009431d, y: 0.5027028461204569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644273368249825d, y: 0.5079011802020743d), new NpgsqlTypes.NpgsqlPoint(x: 0.03713527947268824d, y: 0.16473395152931902d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7818178225590335d, y: 0.860518537791752d), new NpgsqlTypes.NpgsqlPoint(x: 0.42066179937299897d, y: 0.0452751902333941d), new NpgsqlTypes.NpgsqlPoint(x: 0.35709187798795394d, y: 0.12484582054746385d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9745954591297548d, y: 0.03900570842424489d), new NpgsqlTypes.NpgsqlPoint(x: 0.26123234721304367d, y: 0.2174755781401767d), new NpgsqlTypes.NpgsqlPoint(x: 0.32271904656960493d, y: 0.20530429452541066d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6970632568373418d, y: 0.46746628878263896d), new NpgsqlTypes.NpgsqlPoint(x: 0.07484878272164097d, y: 0.22083242745066822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570792713144547d, y: 0.5412823315325954d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19101675820868502d, y: 0.6869395626322233d), new NpgsqlTypes.NpgsqlPoint(x: 0.7304031638438505d, y: 0.358078820655946d), new NpgsqlTypes.NpgsqlPoint(x: 0.9094547557728757d, y: 0.3984114960104982d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35583906273386257d, y: 0.024179780368925208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6188642976303902d, y: 0.5616142493222434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107765182903534d, y: 0.8270308104710696d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3048907742625865d, y: 0.8757135604150073d), new NpgsqlTypes.NpgsqlPoint(x: 0.2708960652143867d, y: 0.8028123769091712d), new NpgsqlTypes.NpgsqlPoint(x: 0.9285573841867317d, y: 0.7444924055833926d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3386415881469086d, y: 0.7189822620328243d), new NpgsqlTypes.NpgsqlPoint(x: 0.004326557211497328d, y: 0.0529572144688385d), new NpgsqlTypes.NpgsqlPoint(x: 0.10028145745890149d, y: 0.0800414675836939d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5358325081220912d, y: 0.8098902800135647d), new NpgsqlTypes.NpgsqlPoint(x: 0.896719579729597d, y: 0.06833764206773751d), new NpgsqlTypes.NpgsqlPoint(x: 0.3168002524991175d, y: 0.9330336478418139d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18512593950182865d, y: 0.08785416650326006d), new NpgsqlTypes.NpgsqlPoint(x: 0.4840778513263857d, y: 0.7702190722786145d), new NpgsqlTypes.NpgsqlPoint(x: 0.4037613078667841d, y: 0.8483423113636296d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5726145378142018d, y: 0.31472884291802705d), new NpgsqlTypes.NpgsqlPoint(x: 0.19796539017884052d, y: 0.3243120007197202d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906272628953986d, y: 0.49636046363651687d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24724384821999978d, y: 0.8101763323542942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8749231028082126d, y: 0.7913096851300364d), new NpgsqlTypes.NpgsqlPoint(x: 0.3717424224278072d, y: 0.8379888037409623d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1982663404148709d, y: 0.4839750541778707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7171949151784373d, y: 0.1142971391607508d), new NpgsqlTypes.NpgsqlPoint(x: 0.17227106451546192d, y: 0.7531582988724674d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39855956563951145d, y: 0.5024075369939548d), new NpgsqlTypes.NpgsqlPoint(x: 0.18463443658703504d, y: 0.4355344725825798d), new NpgsqlTypes.NpgsqlPoint(x: 0.06215551200897773d, y: 0.9086716256038863d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3123130424735002d, y: 0.4781466442625877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306077279830063d, y: 0.7007190661598963d), new NpgsqlTypes.NpgsqlPoint(x: 0.625688273723416d, y: 0.1844164313197313d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3483886449046639d, y: 0.6263033212888837d), new NpgsqlTypes.NpgsqlPoint(x: 0.29076071276612037d, y: 0.5303552324238909d), new NpgsqlTypes.NpgsqlPoint(x: 0.4150742667744842d, y: 0.2690072485023668d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9267069895606622d, y: 0.49321688886525994d), new NpgsqlTypes.NpgsqlPoint(x: 0.48155769972437024d, y: 0.74338180325326d), new NpgsqlTypes.NpgsqlPoint(x: 0.40745228946539247d, y: 0.14255970126026674d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9651783952649793d, y: 0.6583355859517269d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855334790987959d, y: 0.9316083451627956d), new NpgsqlTypes.NpgsqlPoint(x: 0.357628571450893d, y: 0.7121516982149578d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8963337146110781d, y: 0.1210512065793834d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307134681776279d, y: 0.1454840012763563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8955680057179877d, y: 0.6794201701988763d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4605506039114171d, y: 0.5866025844967331d), new NpgsqlTypes.NpgsqlPoint(x: 0.48824588503944133d, y: 0.5003088067150564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7098335465591221d, y: 0.6812409786744932d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5115369842801327d, y: 0.672211822476594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217516488319172d, y: 0.2369704545745569d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342843981485623d, y: 0.822339914897816d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39789358813419384d, y: 0.8254781415261665d), new NpgsqlTypes.NpgsqlPoint(x: 0.26488013212212114d, y: 0.5899882492452394d), new NpgsqlTypes.NpgsqlPoint(x: 0.09773411656129594d, y: 0.42223962401487225d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45601275553433285d, y: 0.9531426449838752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5356307281841175d, y: 0.5057583479412667d), new NpgsqlTypes.NpgsqlPoint(x: 0.464853663914637d, y: 0.17993337235423834d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9829012802170622d, y: 0.8058373501218117d), new NpgsqlTypes.NpgsqlPoint(x: 0.3815897922706514d, y: 0.4905475439223256d), new NpgsqlTypes.NpgsqlPoint(x: 0.44502725817861966d, y: 0.799187748474036d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5399920303203409d, y: 0.5061245681639688d), new NpgsqlTypes.NpgsqlPoint(x: 0.8658961051629768d, y: 0.3032201059942693d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554842217098099d, y: 0.7249713949393033d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2840803566424386d, y: 0.8249662136174544d), new NpgsqlTypes.NpgsqlPoint(x: 0.641534874884922d, y: 0.2892266656197001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6017658932152754d, y: 0.898629899332821d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5040494161197564d, y: 0.6500909338898858d), new NpgsqlTypes.NpgsqlPoint(x: 0.06916410542088214d, y: 0.31013738578417716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8151082198041779d, y: 0.8514214990423019d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16976560856423495d, y: 0.18112443711954174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998040395385353d, y: 0.23938493545660577d), new NpgsqlTypes.NpgsqlPoint(x: 0.10796552404287796d, y: 0.4216533199213103d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3320659546296766d, y: 0.128407187372228d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853159919327974d, y: 0.636827312136372d), new NpgsqlTypes.NpgsqlPoint(x: 0.6643661803023413d, y: 0.9917905717208835d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32654239907869853d, y: 0.4614347382904572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158459131981709d, y: 0.12018120456788672d), new NpgsqlTypes.NpgsqlPoint(x: 0.36809375737672456d, y: 0.9141675248420019d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2142011958498572d, y: 0.9780590460375086d), new NpgsqlTypes.NpgsqlPoint(x: 0.21595513841158265d, y: 0.033416285531313705d), new NpgsqlTypes.NpgsqlPoint(x: 0.3247069770367853d, y: 0.21270576651241624d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6616808653550056d, y: 0.184806568025073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867506795989571d, y: 0.5085495125637812d), new NpgsqlTypes.NpgsqlPoint(x: 0.18827249861173168d, y: 0.30954185380028343d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5850106066013073d, y: 0.6694204981173162d), new NpgsqlTypes.NpgsqlPoint(x: 0.3830648646398571d, y: 0.27578943284573454d), new NpgsqlTypes.NpgsqlPoint(x: 0.5422283171755423d, y: 0.9586365894855023d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15448301632415828d, y: 0.6071237537070504d), new NpgsqlTypes.NpgsqlPoint(x: 0.7493591585417666d, y: 0.8147771703160869d), new NpgsqlTypes.NpgsqlPoint(x: 0.0026128351454801635d, y: 0.75609431455144d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4108855135273166d, y: 0.952129549709965d), new NpgsqlTypes.NpgsqlPoint(x: 0.25181016949154367d, y: 0.4481666158907549d), new NpgsqlTypes.NpgsqlPoint(x: 0.3533581419368742d, y: 0.9135251867496721d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8551495649006897d, y: 0.7205818516563194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8704985966320273d, y: 0.6570318560143091d), new NpgsqlTypes.NpgsqlPoint(x: 0.4822886562354577d, y: 0.8705279056533102d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8515143172410906d, y: 0.8551042653980085d), new NpgsqlTypes.NpgsqlPoint(x: 0.12210386435993958d, y: 0.6059910997196075d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746997318169954d, y: 0.8586766845185946d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23307226619681154d, y: 0.9277691504358684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180422269712797d, y: 0.10793294915373775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2655621754867281d, y: 0.45175556745822465d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6477381692430522d, y: 0.9595540015988143d), new NpgsqlTypes.NpgsqlPoint(x: 0.6282001450894603d, y: 0.26593537030654746d), new NpgsqlTypes.NpgsqlPoint(x: 0.9323805299732153d, y: 0.20185945689034024d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48292486906269394d, y: 0.6480621500061413d), new NpgsqlTypes.NpgsqlPoint(x: 0.04166660225174956d, y: 0.6075594369874263d), new NpgsqlTypes.NpgsqlPoint(x: 0.2981722490854295d, y: 0.023205338099829942d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3177910619741745d, y: 0.10248334126691305d), new NpgsqlTypes.NpgsqlPoint(x: 0.0217423546512312d, y: 0.06808500923313776d), new NpgsqlTypes.NpgsqlPoint(x: 0.2069113181342912d, y: 0.7895108687778217d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33993269057777253d, y: 0.4133174395106418d), new NpgsqlTypes.NpgsqlPoint(x: 0.1089792113621264d, y: 0.23270711990833803d), new NpgsqlTypes.NpgsqlPoint(x: 0.3086098009708921d, y: 0.3320800273436929d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5685939799110822d, y: 0.18689180381858983d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638662484406324d, y: 0.5130567006394299d), new NpgsqlTypes.NpgsqlPoint(x: 0.6640899429451456d, y: 0.1755421488359954d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6651302246204638d, y: 0.7098944905416394d), new NpgsqlTypes.NpgsqlPoint(x: 0.36542334954704736d, y: 0.08940801155527689d), new NpgsqlTypes.NpgsqlPoint(x: 0.24235496678057666d, y: 0.3112607243785146d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34517065009675774d, y: 0.16153776335692993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9615542641752566d, y: 0.541276985913679d), new NpgsqlTypes.NpgsqlPoint(x: 0.6285800910329761d, y: 0.22730439126023383d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.443977211529619d, y: 0.7812281334356751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9547121048636663d, y: 0.7831299142472994d), new NpgsqlTypes.NpgsqlPoint(x: 0.0007844689019581574d, y: 0.7423721682808244d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6924314146068634d, y: 0.891273032465916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8966776767810111d, y: 0.07763001958514426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932871423198397d, y: 0.6215103532537843d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13925460382094645d, y: 0.5189986435738161d), new NpgsqlTypes.NpgsqlPoint(x: 0.32373778516735596d, y: 0.9084203045712511d), new NpgsqlTypes.NpgsqlPoint(x: 0.09950145208867511d, y: 0.07213858924201488d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9334392901998319d, y: 0.4366951093786656d), new NpgsqlTypes.NpgsqlPoint(x: 0.45142342053931994d, y: 0.3540609005186729d), new NpgsqlTypes.NpgsqlPoint(x: 0.28005948928295266d, y: 0.7048115411087882d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2218906169580951d, y: 0.12826272810310568d), new NpgsqlTypes.NpgsqlPoint(x: 0.006075246715236404d, y: 0.027369324280451135d), new NpgsqlTypes.NpgsqlPoint(x: 0.9333155252987897d, y: 0.1870182653288347d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15232300487320694d, y: 0.6271637632352535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8424174995545249d, y: 0.8162655534360991d), new NpgsqlTypes.NpgsqlPoint(x: 0.27154090093593586d, y: 0.002838460055179959d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4939288037792777d, y: 0.13673043052009037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8177703102130613d, y: 0.15555931461616168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8200482527526282d, y: 0.22533777679177547d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22184043553542598d, y: 0.3950247585909562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9359392850428395d, y: 0.6581522454869297d), new NpgsqlTypes.NpgsqlPoint(x: 0.08497517584464154d, y: 0.43099483000035976d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5684165036928677d, y: 0.5230675470498012d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129938744245045d, y: 0.3641473304292705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352592793418589d, y: 0.23361257772371702d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40295825184089684d, y: 0.19010147976877745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8797642177385893d, y: 0.8218825883982522d), new NpgsqlTypes.NpgsqlPoint(x: 0.22668236415597098d, y: 0.5330425138152356d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13093088169141054d, y: 0.5652804067419713d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416317055978d, y: 0.4065424840447269d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964088324426317d, y: 0.18886989544192068d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03172752051502725d, y: 0.6595059769597178d), new NpgsqlTypes.NpgsqlPoint(x: 0.6844282144728993d, y: 0.2035632182177275d), new NpgsqlTypes.NpgsqlPoint(x: 0.4183754529897814d, y: 0.03985113579458943d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19148039147709572d, y: 0.7215302002117501d), new NpgsqlTypes.NpgsqlPoint(x: 0.8164460442880461d, y: 0.02266049935836667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7538874330448929d, y: 0.7186481200961472d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04217876268659293d, y: 0.9331108869967537d), new NpgsqlTypes.NpgsqlPoint(x: 0.03790117793921077d, y: 0.5638436739437115d), new NpgsqlTypes.NpgsqlPoint(x: 0.2589709914607137d, y: 0.9560689918351305d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21214948514498544d, y: 0.6231173454899418d), new NpgsqlTypes.NpgsqlPoint(x: 0.5330839646238663d, y: 0.3531049551967653d), new NpgsqlTypes.NpgsqlPoint(x: 0.09795306536431903d, y: 0.7581885007928495d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6065377876537461d, y: 0.011501542450807811d), new NpgsqlTypes.NpgsqlPoint(x: 0.83021224604288d, y: 0.24477897068839238d), new NpgsqlTypes.NpgsqlPoint(x: 0.007801972706841354d, y: 0.11608565956015138d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32610215884803073d, y: 0.3216299531958633d), new NpgsqlTypes.NpgsqlPoint(x: 0.497278707716418d, y: 0.8583843924886737d), new NpgsqlTypes.NpgsqlPoint(x: 0.06807742611668388d, y: 0.7092406240715687d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11162926445236165d, y: 0.9764211195117805d), new NpgsqlTypes.NpgsqlPoint(x: 0.4845089628626661d, y: 0.9614305759633026d), new NpgsqlTypes.NpgsqlPoint(x: 0.42504762709823873d, y: 0.5815806416244491d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8345913230085777d, y: 0.09991540621820161d), new NpgsqlTypes.NpgsqlPoint(x: 0.7641015816713667d, y: 0.35838778755066003d), new NpgsqlTypes.NpgsqlPoint(x: 0.3360667541961654d, y: 0.08462642653282071d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3642115774204272d, y: 0.2126593513576277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9671972902359011d, y: 0.4226029149630183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5441269970457674d, y: 0.48055504466269183d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9214278543788174d, y: 0.8912760644968422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6041783752350843d, y: 0.11006043826950129d), new NpgsqlTypes.NpgsqlPoint(x: 0.3971390471853359d, y: 0.4496474053087979d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3697463071282474d, y: 0.8939436284923451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7710433455511183d, y: 0.8477884097819214d), new NpgsqlTypes.NpgsqlPoint(x: 0.38845935503809714d, y: 0.5425885779968861d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7509113147029984d, y: 0.2121554890054188d), new NpgsqlTypes.NpgsqlPoint(x: 0.03031209159787085d, y: 0.31514555064006045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8666375977231046d, y: 0.23587538499083893d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09746414295753325d, y: 0.41926552784679705d), new NpgsqlTypes.NpgsqlPoint(x: 0.06629222675636981d, y: 0.17666476826603916d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014183172571475d, y: 0.3944803314980856d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9033779588377608d, y: 0.6239140977235257d), new NpgsqlTypes.NpgsqlPoint(x: 0.26628657314044046d, y: 0.4000981086078149d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147272418167157d, y: 0.3851692345228829d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5990212898833689d, y: 0.26819767732697763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381613690853216d, y: 0.184594193344791d), new NpgsqlTypes.NpgsqlPoint(x: 0.12771076900013445d, y: 0.5992764614952825d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6378258971716394d, y: 0.3689483046998203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802068475712425d, y: 0.7982038192291335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343359699462155d, y: 0.8898112967199222d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1349776544718606d, y: 0.9193185292109857d), new NpgsqlTypes.NpgsqlPoint(x: 0.2753241038440808d, y: 0.909593540894359d), new NpgsqlTypes.NpgsqlPoint(x: 0.7589661892820534d, y: 0.052250622977841776d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5090816946885746d, y: 0.9029977834865714d), new NpgsqlTypes.NpgsqlPoint(x: 0.8861244030399751d, y: 0.694519393931618d), new NpgsqlTypes.NpgsqlPoint(x: 0.7488852374292878d, y: 0.046821791529294776d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07482012945868743d, y: 0.437528320626272d), new NpgsqlTypes.NpgsqlPoint(x: 0.640001846957825d, y: 0.23763067123424564d), new NpgsqlTypes.NpgsqlPoint(x: 0.9819314518138471d, y: 0.4183410521086407d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.524638724142834d, y: 0.8855275848857859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7492558819720154d, y: 0.48738194427367965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9190416052468878d, y: 0.7134894192842509d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8120075115999418d, y: 0.47349288835610315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3448256059909235d, y: 0.23672334340515788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039088607535138d, y: 0.8823537240068652d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7855262490459449d, y: 0.2413127720395427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6176049993481852d, y: 0.4067831208191294d), new NpgsqlTypes.NpgsqlPoint(x: 0.48997866838062953d, y: 0.0779560829031406d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5695131118582224d, y: 0.4294585315103593d), new NpgsqlTypes.NpgsqlPoint(x: 0.10745425472666659d, y: 0.17341761695647262d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269240608057914d, y: 0.8610839322348732d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5920978080867333d, y: 0.497562044940959d), new NpgsqlTypes.NpgsqlPoint(x: 0.2722711740593201d, y: 0.33836434486748224d), new NpgsqlTypes.NpgsqlPoint(x: 0.3464879104218953d, y: 0.9882523951215539d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6673432794039122d, y: 0.923814991565386d), new NpgsqlTypes.NpgsqlPoint(x: 0.42707087361673024d, y: 0.059132345586743074d), new NpgsqlTypes.NpgsqlPoint(x: 0.2582509926053348d, y: 0.5203607139139689d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9792400762282624d, y: 0.9519260746201537d), new NpgsqlTypes.NpgsqlPoint(x: 0.08352123244352183d, y: 0.017250596395286366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5312034043610147d, y: 0.02989596821607099d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8292090552274072d, y: 0.9770788758378484d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103380552246135d, y: 0.23081962100625486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5905688548366671d, y: 0.2209866865334439d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18380235957396807d, y: 0.8164682592038964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4103311430882418d, y: 0.23683843326401333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846013778301968d, y: 0.3816338445734724d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27565246242325314d, y: 0.04122852161878998d), new NpgsqlTypes.NpgsqlPoint(x: 0.3327174359747238d, y: 0.13134670110361668d), new NpgsqlTypes.NpgsqlPoint(x: 0.18197945243909297d, y: 0.5986544757777809d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4067907063401741d, y: 0.12919859601744643d), new NpgsqlTypes.NpgsqlPoint(x: 0.17683719367262318d, y: 0.3773080606929732d), new NpgsqlTypes.NpgsqlPoint(x: 0.15268163347850017d, y: 0.14621806847957264d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5037934369489497d, y: 0.46581443447337945d), new NpgsqlTypes.NpgsqlPoint(x: 0.2742758357062226d, y: 0.11064213836665515d), new NpgsqlTypes.NpgsqlPoint(x: 0.051862058932957145d, y: 0.6348953512843154d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8951885871305296d, y: 0.8652322469067683d), new NpgsqlTypes.NpgsqlPoint(x: 0.9735700286364344d, y: 0.03810626236973991d), new NpgsqlTypes.NpgsqlPoint(x: 0.748706711624628d, y: 0.9154083319392999d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4121450204077557d, y: 0.2266223458942248d), new NpgsqlTypes.NpgsqlPoint(x: 0.3935854707389431d, y: 0.63350639520119d), new NpgsqlTypes.NpgsqlPoint(x: 0.19321321652627654d, y: 0.22516897164404448d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4490885255443755d, y: 0.6128729907252235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8165124045612145d, y: 0.1786536542080993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5224447690242472d, y: 0.38576771333299953d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6243168246255538d, y: 0.04594628318018146d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988745066243325d, y: 0.05444472297083014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600902369507751d, y: 0.6583560503588959d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05544997166167276d, y: 0.8756721652938338d), new NpgsqlTypes.NpgsqlPoint(x: 0.53509004116879d, y: 0.44931319159850325d), new NpgsqlTypes.NpgsqlPoint(x: 0.510630962258296d, y: 0.3746970495101213d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4120103010627061d, y: 0.7312204954180268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7040859653080878d, y: 0.07799460641093992d), new NpgsqlTypes.NpgsqlPoint(x: 0.8232715047138517d, y: 0.3760015503474047d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3107304477697046d, y: 0.3212392460141359d), new NpgsqlTypes.NpgsqlPoint(x: 0.5229762697983538d, y: 0.010398946767745998d), new NpgsqlTypes.NpgsqlPoint(x: 0.5911900931451354d, y: 0.8621429237016883d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6107878765334841d, y: 0.08961802374819161d), new NpgsqlTypes.NpgsqlPoint(x: 0.5448014225273118d, y: 0.6522543153237218d), new NpgsqlTypes.NpgsqlPoint(x: 0.6477957811448177d, y: 0.01931799603397577d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1263145776192437d, y: 0.3749341492338303d), new NpgsqlTypes.NpgsqlPoint(x: 0.4547294976970445d, y: 0.2798818508663623d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978003378274262d, y: 0.46884258244401067d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2619106621766112d, y: 0.9040405291080412d), new NpgsqlTypes.NpgsqlPoint(x: 0.1025069974739824d, y: 0.38884272743608694d), new NpgsqlTypes.NpgsqlPoint(x: 0.8038690826654887d, y: 0.24651118668872662d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7571076680912276d, y: 0.08228545962279155d), new NpgsqlTypes.NpgsqlPoint(x: 0.18982263176083614d, y: 0.21560331587322523d), new NpgsqlTypes.NpgsqlPoint(x: 0.1752804745896237d, y: 0.361688742208355d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9748529476139813d, y: 0.4455627115670745d), new NpgsqlTypes.NpgsqlPoint(x: 0.4347433949228683d, y: 0.14217472144584198d), new NpgsqlTypes.NpgsqlPoint(x: 0.85313458873705d, y: 0.7666279706857849d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7964497324625616d, y: 0.36336149118514094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682044528018772d, y: 0.10766332913976506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8893231324549511d, y: 0.12185041143339781d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7074270258861828d, y: 0.5618649229364023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9398924007652013d, y: 0.9201473460462879d), new NpgsqlTypes.NpgsqlPoint(x: 0.12358747057429065d, y: 0.5436422007492204d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9462029920840346d, y: 0.9031351509502037d), new NpgsqlTypes.NpgsqlPoint(x: 0.10798949827488558d, y: 0.42199736104957875d), new NpgsqlTypes.NpgsqlPoint(x: 0.8173124604232648d, y: 0.8482741991074902d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8776998107314371d, y: 0.7685199625096429d), new NpgsqlTypes.NpgsqlPoint(x: 0.2530598308021873d, y: 0.801447295757604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255122105086512d, y: 0.5706949130167772d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9105280708899933d, y: 0.35082404722471616d), new NpgsqlTypes.NpgsqlPoint(x: 0.054776972126896806d, y: 0.050738577920568906d), new NpgsqlTypes.NpgsqlPoint(x: 0.2823461392303973d, y: 0.6394601069309024d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.378213646160928d, y: 0.9262493802987295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358831156154958d, y: 0.3861637342306036d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623771549394506d, y: 0.9375790885708999d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8426117573959343d, y: 0.4353579964508464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6750394120019464d, y: 0.8304612546374838d), new NpgsqlTypes.NpgsqlPoint(x: 0.9272538395727488d, y: 0.9596688719225471d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18337611055994296d, y: 0.031770626853349526d), new NpgsqlTypes.NpgsqlPoint(x: 0.4246527796693814d, y: 0.3477467762636738d), new NpgsqlTypes.NpgsqlPoint(x: 0.060991584090151485d, y: 0.024160081474565387d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5662828080902711d, y: 0.7475168191227555d), new NpgsqlTypes.NpgsqlPoint(x: 0.014386919992492642d, y: 0.801726679839183d), new NpgsqlTypes.NpgsqlPoint(x: 0.34261518056332185d, y: 0.6619734778082643d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8419944539324342d, y: 0.9108529211493102d), new NpgsqlTypes.NpgsqlPoint(x: 0.14073141336697215d, y: 0.26769763735055385d), new NpgsqlTypes.NpgsqlPoint(x: 0.5970745945334417d, y: 0.9519703304595439d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8966564897901453d, y: 0.33024692324493643d), new NpgsqlTypes.NpgsqlPoint(x: 0.20723252256618974d, y: 0.6438840178838399d), new NpgsqlTypes.NpgsqlPoint(x: 0.15547140541164717d, y: 0.1287169904503741d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33409110184319746d, y: 0.8544592258245879d), new NpgsqlTypes.NpgsqlPoint(x: 0.2631257622556882d, y: 0.05487776836337177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8052133212404922d, y: 0.8337528001836415d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1346725901499234d, y: 0.1394868342978377d), new NpgsqlTypes.NpgsqlPoint(x: 0.455525037345767d, y: 0.4671897015856262d), new NpgsqlTypes.NpgsqlPoint(x: 0.08117786253740433d, y: 0.0772915076455497d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15638428148937966d, y: 0.8254096503601311d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682840121328169d, y: 0.046827073582611956d), new NpgsqlTypes.NpgsqlPoint(x: 0.7103351180353407d, y: 0.5913285950086996d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07641818363670672d, y: 0.22928009153808615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5642025136170336d, y: 0.7710479175757032d), new NpgsqlTypes.NpgsqlPoint(x: 0.37539086403322397d, y: 0.7906790650559291d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25040172251026416d, y: 0.07810714202437519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5527251978613238d, y: 0.7612190878016165d), new NpgsqlTypes.NpgsqlPoint(x: 0.23408900571917757d, y: 0.24992294226811718d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9232333957373139d, y: 0.46359480716358026d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371472846317761d, y: 0.8111049557930445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6081610732539787d, y: 0.6557301436641058d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47734154975854437d, y: 0.7402540907765667d), new NpgsqlTypes.NpgsqlPoint(x: 0.20493268076637505d, y: 0.7235138632811864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6894248091346021d, y: 0.07875927772747415d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008263038062507722d, y: 0.6362411833170407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8893297841364731d, y: 0.2849407809059523d), new NpgsqlTypes.NpgsqlPoint(x: 0.23534548980124126d, y: 0.44312414524359245d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6885291706330647d, y: 0.8258292662706846d), new NpgsqlTypes.NpgsqlPoint(x: 0.07336239628999153d, y: 0.7224076048226137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8864529283290106d, y: 0.2267321039453628d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9251526846866709d, y: 0.6920247184979521d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514699625405116d, y: 0.1468876710580529d), new NpgsqlTypes.NpgsqlPoint(x: 0.28486026340161363d, y: 0.7723020422112266d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8239741398568424d, y: 0.41744577718545595d), new NpgsqlTypes.NpgsqlPoint(x: 0.4865534733261877d, y: 0.04515010990040624d), new NpgsqlTypes.NpgsqlPoint(x: 0.34582462652879187d, y: 0.9997993372834995d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6008046847607562d, y: 0.6498093129280649d), new NpgsqlTypes.NpgsqlPoint(x: 0.5597894261933052d, y: 0.986110080065386d), new NpgsqlTypes.NpgsqlPoint(x: 0.04781860313488362d, y: 0.8666489594329313d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3369690104272368d, y: 0.4220815508573904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6700797137591337d, y: 0.18195862341341074d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421679849347809d, y: 0.7530619659854642d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5428936851284075d, y: 0.6634947582589477d), new NpgsqlTypes.NpgsqlPoint(x: 0.039546002912356326d, y: 0.645168977523934d), new NpgsqlTypes.NpgsqlPoint(x: 0.4411583414616317d, y: 0.5316926694021817d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.867875366747443d, y: 0.4127609302504208d), new NpgsqlTypes.NpgsqlPoint(x: 0.32890723180044557d, y: 0.33530420874590194d), new NpgsqlTypes.NpgsqlPoint(x: 0.708641312597078d, y: 0.011516031127927984d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6821940097290551d, y: 0.7078508717961864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084526425757332d, y: 0.3371105166548781d), new NpgsqlTypes.NpgsqlPoint(x: 0.9226781971804653d, y: 0.7697924351886959d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6140784795190495d, y: 0.0695797058281612d), new NpgsqlTypes.NpgsqlPoint(x: 0.867189450942266d, y: 0.3840597727930578d), new NpgsqlTypes.NpgsqlPoint(x: 0.9517620689893797d, y: 0.4887807217449812d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5034639760495626d, y: 0.7131488013252635d), new NpgsqlTypes.NpgsqlPoint(x: 0.320422695174189d, y: 0.6046161929968102d), new NpgsqlTypes.NpgsqlPoint(x: 0.4974282050750084d, y: 0.9817436705416368d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3908162802511638d, y: 0.990032721963334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7576470975362732d, y: 0.8590429087830355d), new NpgsqlTypes.NpgsqlPoint(x: 0.496707369877481d, y: 0.057450882483240484d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8076173155483981d, y: 0.7658794374185065d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197266611496586d, y: 0.8714109176165029d), new NpgsqlTypes.NpgsqlPoint(x: 0.8540929467869965d, y: 0.7478199168738152d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5066379179190532d, y: 0.14246892765181218d), new NpgsqlTypes.NpgsqlPoint(x: 0.3364324323037067d, y: 0.41473911856095447d), new NpgsqlTypes.NpgsqlPoint(x: 0.1969978154922557d, y: 0.7604580805244866d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8185569060794408d, y: 0.4101035927891902d), new NpgsqlTypes.NpgsqlPoint(x: 0.4747745700733431d, y: 0.036529567605617985d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815077916079966d, y: 0.4877552417228105d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7430640849032497d, y: 0.7032558238930949d), new NpgsqlTypes.NpgsqlPoint(x: 0.05139487683372779d, y: 0.7154271283867042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7701033556783362d, y: 0.3928823155673432d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9795969642027808d, y: 0.5605629214781569d), new NpgsqlTypes.NpgsqlPoint(x: 0.538995437594524d, y: 0.13279367802684128d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686928389819353d, y: 0.9725984139663364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3082043762810035d, y: 0.3557955430847579d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005443011277697085d, y: 0.8454719017134346d), new NpgsqlTypes.NpgsqlPoint(x: 0.232996220202342d, y: 0.03611230719106229d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2507892533277757d, y: 0.927392025708081d), new NpgsqlTypes.NpgsqlPoint(x: 0.672999984945766d, y: 0.0011678212502956864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913913713838932d, y: 0.268196010010362d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16221753941252626d, y: 0.9326335073175801d), new NpgsqlTypes.NpgsqlPoint(x: 0.42850297659560543d, y: 0.6775550029266862d), new NpgsqlTypes.NpgsqlPoint(x: 0.4728796240940255d, y: 0.45210517997095045d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9937668997986989d, y: 0.09597454360294844d), new NpgsqlTypes.NpgsqlPoint(x: 0.43055566372804377d, y: 0.7688677496754223d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418304715744042d, y: 0.7765018241887833d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9342656043780453d, y: 0.6677138813182761d), new NpgsqlTypes.NpgsqlPoint(x: 0.40110410471997204d, y: 0.7504207397811642d), new NpgsqlTypes.NpgsqlPoint(x: 0.31962414050373344d, y: 0.6660901330124702d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4861053667496529d, y: 0.15395524239193792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8054775350987289d, y: 0.2226477163543481d), new NpgsqlTypes.NpgsqlPoint(x: 0.21121088952639266d, y: 0.35839229311454457d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1376318890670517d, y: 0.6663273502171425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9233875692033781d, y: 0.9274493525396681d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838442238783267d, y: 0.9071633409943043d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9487272933452541d, y: 0.5366158412064816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5952532994501073d, y: 0.25825781290659355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6176712834322798d, y: 0.029511627556650266d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.772748589793386d, y: 0.7559153131053321d), new NpgsqlTypes.NpgsqlPoint(x: 0.20315480455406099d, y: 0.857319499370382d), new NpgsqlTypes.NpgsqlPoint(x: 0.03968628596445767d, y: 0.46635318242241663d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11169728447222549d, y: 0.35779046120200164d), new NpgsqlTypes.NpgsqlPoint(x: 0.949143625554787d, y: 0.041088234483152686d), new NpgsqlTypes.NpgsqlPoint(x: 0.47358917508665266d, y: 0.4170857648391444d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009447460636705984d, y: 0.8074576990417529d), new NpgsqlTypes.NpgsqlPoint(x: 0.039427697638651615d, y: 0.8185528959371571d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906946749186378d, y: 0.7859115550506065d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44731123779598814d, y: 0.06126982711651763d), new NpgsqlTypes.NpgsqlPoint(x: 0.35292257073165356d, y: 0.7879782650013655d), new NpgsqlTypes.NpgsqlPoint(x: 0.8044526937694737d, y: 0.1338091296742423d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3821302759155887d, y: 0.01016942775914187d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786937474452458d, y: 0.803587209619481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6276383135305683d, y: 0.2776340456053811d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.751822775080899d, y: 0.8542714723875928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8766801733067967d, y: 0.06233654496216745d), new NpgsqlTypes.NpgsqlPoint(x: 0.4061050398283754d, y: 0.3353512428039557d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19605024630424606d, y: 0.22207240347533952d), new NpgsqlTypes.NpgsqlPoint(x: 0.49126418882640677d, y: 0.3935464747171694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6241657044766614d, y: 0.17544920825010435d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2775185549122239d, y: 0.7719763291722358d), new NpgsqlTypes.NpgsqlPoint(x: 0.6303513558067267d, y: 0.7551782634564086d), new NpgsqlTypes.NpgsqlPoint(x: 0.2703580625784435d, y: 0.13584901661740312d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4916420256942421d, y: 0.39952368876532585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9131783117544211d, y: 0.9282442205635135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7782141124953659d, y: 0.7943330285127592d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24157026765884393d, y: 0.5901610715934857d), new NpgsqlTypes.NpgsqlPoint(x: 0.0475866678691359d, y: 0.6374424358087674d), new NpgsqlTypes.NpgsqlPoint(x: 0.4682511188697992d, y: 0.10010637745927742d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8180443443213761d, y: 0.2978576603155233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3557260076214108d, y: 0.04081463487881187d), new NpgsqlTypes.NpgsqlPoint(x: 0.4513272999255624d, y: 0.9252603405203589d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9045788910856511d, y: 0.8879302590415953d), new NpgsqlTypes.NpgsqlPoint(x: 0.3378514008149601d, y: 0.029515138965984122d), new NpgsqlTypes.NpgsqlPoint(x: 0.13086825739090457d, y: 0.13952936067559596d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5045675998474479d, y: 0.11852097375185333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7898715810872208d, y: 0.6406937644903693d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249807525441113d, y: 0.676211167700973d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5442386879219046d, y: 0.8706016459403905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8131988242911764d, y: 0.05682511630071685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4428381101942641d, y: 0.5485934251467519d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30354274012761717d, y: 0.9076212435918605d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218988496469304d, y: 0.34694974821386204d), new NpgsqlTypes.NpgsqlPoint(x: 0.10833385223531045d, y: 0.8174651420318416d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38262409173522016d, y: 0.6722154634072239d), new NpgsqlTypes.NpgsqlPoint(x: 0.22469474667862055d, y: 0.9646836796773908d), new NpgsqlTypes.NpgsqlPoint(x: 0.6697130708499853d, y: 0.41828228962546754d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6865062120924198d, y: 0.9773037960014949d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580131404492765d, y: 0.351974085013503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567178015778785d, y: 0.8655694507795466d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8481163398995185d, y: 0.7419339314816835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5606769664468779d, y: 0.7634669390873057d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705484735310709d, y: 0.9136276281398203d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.155129803038644d, y: 0.2286357002448457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7261636602631052d, y: 0.38657772729765116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449291188309779d, y: 0.6861675613498187d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5933900068460655d, y: 0.8958963835196703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5700333289608268d, y: 0.5905696873550457d), new NpgsqlTypes.NpgsqlPoint(x: 0.1312633915004393d, y: 0.3538986263728745d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46832182259446853d, y: 0.24162871760664395d), new NpgsqlTypes.NpgsqlPoint(x: 0.18829843308030414d, y: 0.6397622920507936d), new NpgsqlTypes.NpgsqlPoint(x: 0.930827237053828d, y: 0.7468015305290876d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8269172168721403d, y: 0.6041705306921564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6893660830671879d, y: 0.08720116058632599d), new NpgsqlTypes.NpgsqlPoint(x: 0.027712991964928713d, y: 0.388717637966033d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0006685285222028936d, y: 0.6759444401098579d), new NpgsqlTypes.NpgsqlPoint(x: 0.41703509443705866d, y: 0.902954994323155d), new NpgsqlTypes.NpgsqlPoint(x: 0.06307300370357083d, y: 0.21640963248582734d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3805422162736558d, y: 0.5276409938656264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9039097370609382d, y: 0.3956178773329846d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537300444230773d, y: 0.6352500934865543d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38974253622169774d, y: 0.4618898795903259d), new NpgsqlTypes.NpgsqlPoint(x: 0.6523989198740662d, y: 0.39077789526953344d), new NpgsqlTypes.NpgsqlPoint(x: 0.1549353750618806d, y: 0.2924046702131511d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8321843311292465d, y: 0.7278578619514243d), new NpgsqlTypes.NpgsqlPoint(x: 0.6042266247466342d, y: 0.39890577005036754d), new NpgsqlTypes.NpgsqlPoint(x: 0.48325205971890484d, y: 0.43205593688294397d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.585051414980857d, y: 0.7178450898757262d), new NpgsqlTypes.NpgsqlPoint(x: 0.05877615308403272d, y: 0.2955533861020525d), new NpgsqlTypes.NpgsqlPoint(x: 0.2967120660261142d, y: 0.8322706970402516d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7586145829792988d, y: 0.7268124637801311d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974441492481939d, y: 0.583431458877802d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828953792134735d, y: 0.595864837732961d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7901225579707679d, y: 0.44847037957730673d), new NpgsqlTypes.NpgsqlPoint(x: 0.22946038546835623d, y: 0.9419571437955159d), new NpgsqlTypes.NpgsqlPoint(x: 0.2184611483659903d, y: 0.49631816243318905d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6968728979880756d, y: 0.2575139896819052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7488253617224555d, y: 0.8219249735117476d), new NpgsqlTypes.NpgsqlPoint(x: 0.25224027502880964d, y: 0.06390633256290912d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09615986869738158d, y: 0.9940063516633132d), new NpgsqlTypes.NpgsqlPoint(x: 0.41871483765315953d, y: 0.813241986558327d), new NpgsqlTypes.NpgsqlPoint(x: 0.910478917908941d, y: 0.507892879895733d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24700891551773052d, y: 0.813461266664325d), new NpgsqlTypes.NpgsqlPoint(x: 0.8274955969568194d, y: 0.7188216253253106d), new NpgsqlTypes.NpgsqlPoint(x: 0.2598710765104223d, y: 0.9865923725880082d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11220628291273405d, y: 0.885383083142841d), new NpgsqlTypes.NpgsqlPoint(x: 0.14559878979465624d, y: 0.33320166908183624d), new NpgsqlTypes.NpgsqlPoint(x: 0.693161041824137d, y: 0.8089211918506982d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04996668620918687d, y: 0.2633284851872516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9623876976314054d, y: 0.7835712012456094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9840270548285212d, y: 0.7655803824102109d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18364165186372594d, y: 0.060243938702576716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705293818622856d, y: 0.9279032603705409d), new NpgsqlTypes.NpgsqlPoint(x: 0.6734127837641138d, y: 0.7877104758511173d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5408531998241849d, y: 0.9939009088178294d), new NpgsqlTypes.NpgsqlPoint(x: 0.10675612790860267d, y: 0.6087839391645896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138559861671114d, y: 0.9910048090737962d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2443462999802094d, y: 0.5140984042201298d), new NpgsqlTypes.NpgsqlPoint(x: 0.16260841391672687d, y: 0.21599420723608442d), new NpgsqlTypes.NpgsqlPoint(x: 0.08081456664525888d, y: 0.7802285919417187d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5170187653944076d, y: 0.3388168533726139d), new NpgsqlTypes.NpgsqlPoint(x: 0.25367437819344385d, y: 0.06665210831432677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8187299396622095d, y: 0.28858068528812497d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9298006314239359d, y: 0.7834895467202653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5451267373791181d, y: 0.8058264706568158d), new NpgsqlTypes.NpgsqlPoint(x: 0.40258298135783044d, y: 0.41278565352798224d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5426539179805834d, y: 0.14320198109476678d), new NpgsqlTypes.NpgsqlPoint(x: 0.865710780549941d, y: 0.6408570113754004d), new NpgsqlTypes.NpgsqlPoint(x: 0.018181207819949363d, y: 0.35987259686617d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9084905235461233d, y: 0.05324485306963844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610045896244579d, y: 0.17367460937487067d), new NpgsqlTypes.NpgsqlPoint(x: 0.34991658427667605d, y: 0.8058167912545986d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4068862470048171d, y: 0.6688898054992833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5229440280294517d, y: 0.995313165115767d), new NpgsqlTypes.NpgsqlPoint(x: 0.2919677571794237d, y: 0.1297026273202201d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27894790050811047d, y: 0.3523431359164533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6119374743875761d, y: 0.37842995007205504d), new NpgsqlTypes.NpgsqlPoint(x: 0.022634040042487258d, y: 0.26059093512171905d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15469257029080696d, y: 0.6222267041048298d), new NpgsqlTypes.NpgsqlPoint(x: 0.633151092462521d, y: 0.7357825657958621d), new NpgsqlTypes.NpgsqlPoint(x: 0.007228030777810646d, y: 0.862660100473835d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9840283799260817d, y: 0.7692280730008026d), new NpgsqlTypes.NpgsqlPoint(x: 0.986996066659794d, y: 0.6430430549078126d), new NpgsqlTypes.NpgsqlPoint(x: 0.22362538302112134d, y: 0.5435777589790997d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5435948334743487d, y: 0.5262795043171448d), new NpgsqlTypes.NpgsqlPoint(x: 0.726286397251635d, y: 0.6054870544637591d), new NpgsqlTypes.NpgsqlPoint(x: 0.45646298131939733d, y: 0.6941177494616583d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36822390402173455d, y: 0.47231384197143245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9904031329655483d, y: 0.4684235702663988d), new NpgsqlTypes.NpgsqlPoint(x: 0.45566557920674366d, y: 0.6052048558992985d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04821929395424429d, y: 0.25953982537470066d), new NpgsqlTypes.NpgsqlPoint(x: 0.32247880396803996d, y: 0.5056746713447814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487246605468424d, y: 0.1792760547003549d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5239778912411043d, y: 0.1827788286052623d), new NpgsqlTypes.NpgsqlPoint(x: 0.7007528789806134d, y: 0.5029254637039373d), new NpgsqlTypes.NpgsqlPoint(x: 0.6174738655916424d, y: 0.213949351795222d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22481965235700896d, y: 0.020435568362844325d), new NpgsqlTypes.NpgsqlPoint(x: 0.19345157259888757d, y: 0.644746143409081d), new NpgsqlTypes.NpgsqlPoint(x: 0.003130854499030389d, y: 0.6273868602002206d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5542066362148881d, y: 0.795956141030979d), new NpgsqlTypes.NpgsqlPoint(x: 0.38798039876301094d, y: 0.7653291172515225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726922701453318d, y: 0.9561574039738772d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2460622494738538d, y: 0.4647558262239857d), new NpgsqlTypes.NpgsqlPoint(x: 0.6991033269001785d, y: 0.7486351200936128d), new NpgsqlTypes.NpgsqlPoint(x: 0.997692439478618d, y: 0.775197268964919d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1363604651503464d, y: 0.25791987896854773d), new NpgsqlTypes.NpgsqlPoint(x: 0.7193979188441563d, y: 0.41335324978597565d), new NpgsqlTypes.NpgsqlPoint(x: 0.4341696150763763d, y: 0.12189878200615178d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09628129185834877d, y: 0.8272730413251539d), new NpgsqlTypes.NpgsqlPoint(x: 0.3417776286392368d, y: 0.9332815877218789d), new NpgsqlTypes.NpgsqlPoint(x: 0.22583037919598448d, y: 0.5563225871131828d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9976035305408459d, y: 0.027556042718474116d), new NpgsqlTypes.NpgsqlPoint(x: 0.471888728153798d, y: 0.5873375994296168d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347651650147875d, y: 0.8206780401096899d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49730659494406726d, y: 0.1956739283959068d), new NpgsqlTypes.NpgsqlPoint(x: 0.31527216308477257d, y: 0.32708102429610364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631066049914746d, y: 0.9930258161333666d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2932462620835804d, y: 0.523101842095192d), new NpgsqlTypes.NpgsqlPoint(x: 0.4939301029406199d, y: 0.48282020945886694d), new NpgsqlTypes.NpgsqlPoint(x: 0.31189640185212064d, y: 0.22617351005744057d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9707084566485941d, y: 0.7915811711376128d), new NpgsqlTypes.NpgsqlPoint(x: 0.5797470875729437d, y: 0.28773470498205445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923787633424885d, y: 0.6907155966924191d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44117142309629087d, y: 0.5627256133933718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8115250934055928d, y: 0.1680631836579788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633034535477967d, y: 0.0932544417711213d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6347118678732984d, y: 0.9715219908492151d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176314415512219d, y: 0.7547987053361848d), new NpgsqlTypes.NpgsqlPoint(x: 0.5412306661492405d, y: 0.5902269922095388d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36325649190326026d, y: 0.9157672668245009d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974379632310631d, y: 0.7198481809365331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5423252170133983d, y: 0.9979859146054659d)),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5831896885009431d, y: 0.5027028461204569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644273368249825d, y: 0.5079011802020743d), new NpgsqlTypes.NpgsqlPoint(x: 0.03713527947268824d, y: 0.16473395152931902d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7818178225590335d, y: 0.860518537791752d), new NpgsqlTypes.NpgsqlPoint(x: 0.42066179937299897d, y: 0.0452751902333941d), new NpgsqlTypes.NpgsqlPoint(x: 0.35709187798795394d, y: 0.12484582054746385d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9745954591297548d, y: 0.03900570842424489d), new NpgsqlTypes.NpgsqlPoint(x: 0.26123234721304367d, y: 0.2174755781401767d), new NpgsqlTypes.NpgsqlPoint(x: 0.32271904656960493d, y: 0.20530429452541066d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5726145378142018d, y: 0.31472884291802705d), new NpgsqlTypes.NpgsqlPoint(x: 0.19796539017884052d, y: 0.3243120007197202d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906272628953986d, y: 0.49636046363651687d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24724384821999978d, y: 0.8101763323542942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8749231028082126d, y: 0.7913096851300364d), new NpgsqlTypes.NpgsqlPoint(x: 0.3717424224278072d, y: 0.8379888037409623d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1982663404148709d, y: 0.4839750541778707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7171949151784373d, y: 0.1142971391607508d), new NpgsqlTypes.NpgsqlPoint(x: 0.17227106451546192d, y: 0.7531582988724674d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39855956563951145d, y: 0.5024075369939548d), new NpgsqlTypes.NpgsqlPoint(x: 0.18463443658703504d, y: 0.4355344725825798d), new NpgsqlTypes.NpgsqlPoint(x: 0.06215551200897773d, y: 0.9086716256038863d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8963337146110781d, y: 0.1210512065793834d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307134681776279d, y: 0.1454840012763563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8955680057179877d, y: 0.6794201701988763d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4605506039114171d, y: 0.5866025844967331d), new NpgsqlTypes.NpgsqlPoint(x: 0.48824588503944133d, y: 0.5003088067150564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7098335465591221d, y: 0.6812409786744932d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5115369842801327d, y: 0.672211822476594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217516488319172d, y: 0.2369704545745569d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342843981485623d, y: 0.822339914897816d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32654239907869853d, y: 0.4614347382904572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158459131981709d, y: 0.12018120456788672d), new NpgsqlTypes.NpgsqlPoint(x: 0.36809375737672456d, y: 0.9141675248420019d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2142011958498572d, y: 0.9780590460375086d), new NpgsqlTypes.NpgsqlPoint(x: 0.21595513841158265d, y: 0.033416285531313705d), new NpgsqlTypes.NpgsqlPoint(x: 0.3247069770367853d, y: 0.21270576651241624d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6616808653550056d, y: 0.184806568025073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867506795989571d, y: 0.5085495125637812d), new NpgsqlTypes.NpgsqlPoint(x: 0.18827249861173168d, y: 0.30954185380028343d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5850106066013073d, y: 0.6694204981173162d), new NpgsqlTypes.NpgsqlPoint(x: 0.3830648646398571d, y: 0.27578943284573454d), new NpgsqlTypes.NpgsqlPoint(x: 0.5422283171755423d, y: 0.9586365894855023d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23307226619681154d, y: 0.9277691504358684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180422269712797d, y: 0.10793294915373775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2655621754867281d, y: 0.45175556745822465d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6477381692430522d, y: 0.9595540015988143d), new NpgsqlTypes.NpgsqlPoint(x: 0.6282001450894603d, y: 0.26593537030654746d), new NpgsqlTypes.NpgsqlPoint(x: 0.9323805299732153d, y: 0.20185945689034024d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48292486906269394d, y: 0.6480621500061413d), new NpgsqlTypes.NpgsqlPoint(x: 0.04166660225174956d, y: 0.6075594369874263d), new NpgsqlTypes.NpgsqlPoint(x: 0.2981722490854295d, y: 0.023205338099829942d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3177910619741745d, y: 0.10248334126691305d), new NpgsqlTypes.NpgsqlPoint(x: 0.0217423546512312d, y: 0.06808500923313776d), new NpgsqlTypes.NpgsqlPoint(x: 0.2069113181342912d, y: 0.7895108687778217d)),
}));
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13925460382094645d, y: 0.5189986435738161d), new NpgsqlTypes.NpgsqlPoint(x: 0.32373778516735596d, y: 0.9084203045712511d), new NpgsqlTypes.NpgsqlPoint(x: 0.09950145208867511d, y: 0.07213858924201488d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9334392901998319d, y: 0.4366951093786656d), new NpgsqlTypes.NpgsqlPoint(x: 0.45142342053931994d, y: 0.3540609005186729d), new NpgsqlTypes.NpgsqlPoint(x: 0.28005948928295266d, y: 0.7048115411087882d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2218906169580951d, y: 0.12826272810310568d), new NpgsqlTypes.NpgsqlPoint(x: 0.006075246715236404d, y: 0.027369324280451135d), new NpgsqlTypes.NpgsqlPoint(x: 0.9333155252987897d, y: 0.1870182653288347d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15232300487320694d, y: 0.6271637632352535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8424174995545249d, y: 0.8162655534360991d), new NpgsqlTypes.NpgsqlPoint(x: 0.27154090093593586d, y: 0.002838460055179959d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32610215884803073d, y: 0.3216299531958633d), new NpgsqlTypes.NpgsqlPoint(x: 0.497278707716418d, y: 0.8583843924886737d), new NpgsqlTypes.NpgsqlPoint(x: 0.06807742611668388d, y: 0.7092406240715687d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11162926445236165d, y: 0.9764211195117805d), new NpgsqlTypes.NpgsqlPoint(x: 0.4845089628626661d, y: 0.9614305759633026d), new NpgsqlTypes.NpgsqlPoint(x: 0.42504762709823873d, y: 0.5815806416244491d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8345913230085777d, y: 0.09991540621820161d), new NpgsqlTypes.NpgsqlPoint(x: 0.7641015816713667d, y: 0.35838778755066003d), new NpgsqlTypes.NpgsqlPoint(x: 0.3360667541961654d, y: 0.08462642653282071d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3642115774204272d, y: 0.2126593513576277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9671972902359011d, y: 0.4226029149630183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5441269970457674d, y: 0.48055504466269183d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 83, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 109, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 83, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 69, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 10, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 65, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatch(connection, 83, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1M>(15);

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
                ((INpgsqlPolygonArraypolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

