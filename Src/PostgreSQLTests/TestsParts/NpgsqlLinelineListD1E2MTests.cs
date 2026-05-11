

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
    internal partial interface INpgsqlLineListlineListD1
    {
    }
    
    internal partial class NpgsqlLineListlineListD1 : INpgsqlLineListlineListD1
    {


#region TestData

        private readonly NpgsqlLinelineListD1E2M[] _testData = new NpgsqlLinelineListD1E2M[]
        {
            new NpgsqlLinelineListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24975219820628347d, b: 0.8058336510831592d, c: 0.7725176017693193d),

new NpgsqlTypes.NpgsqlLine(a: 0.1083548361703911d, b: 0.5762346888589374d, c: 0.3098803682720723d),

new NpgsqlTypes.NpgsqlLine(a: 0.7409604020457936d, b: 0.012702789434557382d, c: 0.5943127710871489d),

new NpgsqlTypes.NpgsqlLine(a: 0.5583970318591986d, b: 0.17858425970793657d, c: 0.42615150652545697d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8884543069924197d, b: 0.8564330483382292d, c: 0.46400356945955146d),

new NpgsqlTypes.NpgsqlLine(a: 0.13937986053369844d, b: 0.7654222394090081d, c: 0.6984288312980027d),

new NpgsqlTypes.NpgsqlLine(a: 0.3938348563228373d, b: 0.4017562783396691d, c: 0.5223742537136339d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20522195820845213d, b: 0.3194087291092056d, c: 0.6550475177414431d),

new NpgsqlTypes.NpgsqlLine(a: 0.46665552785000386d, b: 0.6013169039326014d, c: 0.49996981482980796d),

new NpgsqlTypes.NpgsqlLine(a: 0.18143563847290878d, b: 0.5761429407743643d, c: 0.5597648622577156d),

new NpgsqlTypes.NpgsqlLine(a: 0.2880041413062203d, b: 0.9433279012585011d, c: 0.21888370472769425d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5052429912620162d, b: 0.05308254616208219d, c: 0.66361371798311d),

new NpgsqlTypes.NpgsqlLine(a: 0.89635396494777d, b: 0.6411962361927938d, c: 0.15327398168773387d),

new NpgsqlTypes.NpgsqlLine(a: 0.1468634681326667d, b: 0.1892513900252657d, c: 0.8668752607484159d),

new NpgsqlTypes.NpgsqlLine(a: 0.026904366413666114d, b: 0.6228738842379747d, c: 0.8367703609778074d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4210857699657665d, b: 0.464994879958992d, c: 0.2952600283813006d),

new NpgsqlTypes.NpgsqlLine(a: 0.43723733659720454d, b: 0.009369171314640545d, c: 0.8164096545205185d),

new NpgsqlTypes.NpgsqlLine(a: 0.38610042700224034d, b: 0.3535566675398206d, c: 0.13932194697933675d),

new NpgsqlTypes.NpgsqlLine(a: 0.9691977248032526d, b: 0.29402369685459084d, c: 0.6542503041205125d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9657091422615784d, b: 0.8041168938984247d, c: 0.3308641479120874d),

new NpgsqlTypes.NpgsqlLine(a: 0.2014454766950522d, b: 0.039119931109482864d, c: 0.642292662097173d),

new NpgsqlTypes.NpgsqlLine(a: 0.30170959153183774d, b: 0.5430172638134487d, c: 0.4715477497448808d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8870901788282711d, b: 0.04226285382761574d, c: 0.12083982097446844d),

new NpgsqlTypes.NpgsqlLine(a: 0.47070477978565184d, b: 0.6302172609332363d, c: 0.7508013770262479d),

new NpgsqlTypes.NpgsqlLine(a: 0.9003677580805319d, b: 0.7817618650588221d, c: 0.4763493289391232d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.439851511913962d, b: 0.23256658575732825d, c: 0.9895144949406015d),

new NpgsqlTypes.NpgsqlLine(a: 0.9995389268566144d, b: 0.6870265240885742d, c: 0.5825071050852986d),

new NpgsqlTypes.NpgsqlLine(a: 0.620174236150827d, b: 0.3689808990100991d, c: 0.5333341180933195d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.01854165281418252d, b: 0.8817513132430856d, c: 0.7195304528711449d),

new NpgsqlTypes.NpgsqlLine(a: 0.7112083797037531d, b: 0.8446335929280603d, c: 0.3808326096653558d),

new NpgsqlTypes.NpgsqlLine(a: 0.32449286843340597d, b: 0.8290168649137386d, c: 0.1906006749543514d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.945576632852915d, b: 0.2621709837794348d, c: 0.7278886146901593d),

new NpgsqlTypes.NpgsqlLine(a: 0.27187824396798177d, b: 0.6210357946573049d, c: 0.6082113347877711d),

new NpgsqlTypes.NpgsqlLine(a: 0.7431396253957063d, b: 0.9919087458727898d, c: 0.1897996828608315d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4816716602878157d, b: 0.9054505297599825d, c: 0.9248638062245497d),

new NpgsqlTypes.NpgsqlLine(a: 0.04631740783662597d, b: 0.6646148759141003d, c: 0.18592874057124242d),

new NpgsqlTypes.NpgsqlLine(a: 0.6109301664871047d, b: 0.8234665070739886d, c: 0.5559226033751081d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07839323429235201d, b: 0.9194766990833765d, c: 0.6542944674468177d),

new NpgsqlTypes.NpgsqlLine(a: 0.9571223600870613d, b: 0.33174957377998915d, c: 0.705107622120713d),

new NpgsqlTypes.NpgsqlLine(a: 0.5959568286525254d, b: 0.9809314082434332d, c: 0.00974651807921667d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8566262803862653d, b: 0.8285950061435435d, c: 0.03072210685374821d),

new NpgsqlTypes.NpgsqlLine(a: 0.29553067115683473d, b: 0.9760199344680681d, c: 0.3887865024228143d),

new NpgsqlTypes.NpgsqlLine(a: 0.35784914120595523d, b: 0.7327471584950948d, c: 0.9040708996204707d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3989942487105417d, b: 0.3010347914541093d, c: 0.2775681996321844d),

new NpgsqlTypes.NpgsqlLine(a: 0.8555451998235692d, b: 0.8114320935206429d, c: 0.12321145078908446d),

new NpgsqlTypes.NpgsqlLine(a: 0.37292522383557025d, b: 0.8488217344154897d, c: 0.9116019327441256d),

new NpgsqlTypes.NpgsqlLine(a: 0.5530085792713628d, b: 0.5956723098647938d, c: 0.509052783366366d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.515078882329137d, b: 0.5868718728702167d, c: 0.4188113780525937d),

new NpgsqlTypes.NpgsqlLine(a: 0.6973972053139142d, b: 0.41613268175960716d, c: 0.19195625628377044d),

new NpgsqlTypes.NpgsqlLine(a: 0.9325569959227143d, b: 0.07532267604355058d, c: 0.1068467816954336d),

new NpgsqlTypes.NpgsqlLine(a: 0.9146176030403227d, b: 0.20421718601491856d, c: 0.05674535718926821d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4906336151876375d, b: 0.7424358700928037d, c: 0.4212962175899272d),

new NpgsqlTypes.NpgsqlLine(a: 0.18005245496044775d, b: 0.2556321976141407d, c: 0.6101552239243838d),

new NpgsqlTypes.NpgsqlLine(a: 0.007119243543622478d, b: 0.8123219159480526d, c: 0.921713305825335d),

new NpgsqlTypes.NpgsqlLine(a: 0.044662765525565695d, b: 0.001901580557786886d, c: 0.3670563554590144d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20953422248541953d, b: 0.5483250133249089d, c: 0.599042658626685d),

new NpgsqlTypes.NpgsqlLine(a: 0.4224973657208173d, b: 0.5120565178525006d, c: 0.7599011632618458d),

new NpgsqlTypes.NpgsqlLine(a: 0.2857762767040992d, b: 0.5295522988482256d, c: 0.954308032993471d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03270499334043531d, b: 0.09178974863392009d, c: 0.6884431369637647d),

new NpgsqlTypes.NpgsqlLine(a: 0.8418420331744318d, b: 0.5247367245032445d, c: 0.12433251696439196d),

new NpgsqlTypes.NpgsqlLine(a: 0.4571555387386742d, b: 0.6696866494485573d, c: 0.37724521262737d),

new NpgsqlTypes.NpgsqlLine(a: 0.0493480408059187d, b: 0.6097219320467918d, c: 0.5111126813674997d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0617418242873079d, b: 0.22081272676150931d, c: 0.035618611144174084d),

new NpgsqlTypes.NpgsqlLine(a: 0.022576678170745823d, b: 0.6308359771944874d, c: 0.5154356831301821d),

new NpgsqlTypes.NpgsqlLine(a: 0.4968158427817049d, b: 0.5163463625854956d, c: 0.8393071900091392d),

new NpgsqlTypes.NpgsqlLine(a: 0.9261839264962907d, b: 0.4518727671378412d, c: 0.8086724856887366d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4922680599285678d, b: 0.6201433683348787d, c: 0.6332771040492332d),

new NpgsqlTypes.NpgsqlLine(a: 0.6684799641239191d, b: 0.013605140154754225d, c: 0.29352109737166143d),

new NpgsqlTypes.NpgsqlLine(a: 0.1371019082278604d, b: 0.3460737084101412d, c: 0.025256432117757743d),

new NpgsqlTypes.NpgsqlLine(a: 0.8757808028178411d, b: 0.6899630922162223d, c: 0.6642151188786763d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8836780050970633d, b: 0.692705618464053d, c: 0.16573207736864415d),

new NpgsqlTypes.NpgsqlLine(a: 0.935412498234419d, b: 0.27191550255241903d, c: 0.9742017957854084d),

new NpgsqlTypes.NpgsqlLine(a: 0.5800827410679981d, b: 0.21662277817277342d, c: 0.3076331727159396d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6966595817162163d, b: 0.8150223664656653d, c: 0.82219209549577d),

new NpgsqlTypes.NpgsqlLine(a: 0.29593960249475915d, b: 0.6886089269258623d, c: 0.06797775910179793d),

new NpgsqlTypes.NpgsqlLine(a: 0.8129021487563971d, b: 0.7062545043751864d, c: 0.7792598565072977d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628150661764276d, b: 0.6750612069590974d, c: 0.6904249066812868d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5021622546957655d, b: 0.10921298864086237d, c: 0.060456065152995064d),

new NpgsqlTypes.NpgsqlLine(a: 0.6070742839723151d, b: 0.6153321186050748d, c: 0.8154528317883968d),

new NpgsqlTypes.NpgsqlLine(a: 0.29780485398407797d, b: 0.3773078568256216d, c: 0.3020435157962177d),

new NpgsqlTypes.NpgsqlLine(a: 0.8254635707768255d, b: 0.9711050663157181d, c: 0.3401098456099306d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7351498811880705d, b: 0.5960597734817792d, c: 0.5159902599962113d),

new NpgsqlTypes.NpgsqlLine(a: 0.9075709929543165d, b: 0.26609414771273554d, c: 0.7607543077460093d),

new NpgsqlTypes.NpgsqlLine(a: 0.5243451680301554d, b: 0.4005034545773126d, c: 0.5466523590269035d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47247552651070746d, b: 0.9363359598004464d, c: 0.15220818201928943d),

new NpgsqlTypes.NpgsqlLine(a: 0.0860737564814934d, b: 0.019946711741184453d, c: 0.8674976568341367d),

new NpgsqlTypes.NpgsqlLine(a: 0.0655032455178165d, b: 0.6601455772664792d, c: 0.7810380519056532d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3267019175532916d, b: 0.6209744518780755d, c: 0.542867669276626d),

new NpgsqlTypes.NpgsqlLine(a: 0.35000664747163446d, b: 0.42191434593099053d, c: 0.2628300700390397d),

new NpgsqlTypes.NpgsqlLine(a: 0.30512551255182196d, b: 0.17554468472005402d, c: 0.5523355952364334d),

new NpgsqlTypes.NpgsqlLine(a: 0.017787210217379057d, b: 0.03632822646435441d, c: 0.12681279104009702d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6683890315737788d, b: 0.3624914452267751d, c: 0.6357682358305116d),

new NpgsqlTypes.NpgsqlLine(a: 0.4472497931157231d, b: 0.8167153648302575d, c: 0.7907056881818397d),

new NpgsqlTypes.NpgsqlLine(a: 0.29443287243562855d, b: 0.6508029920405183d, c: 0.13727640704578348d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11002116212089863d, b: 0.8485900598551634d, c: 0.9371355774844063d),

new NpgsqlTypes.NpgsqlLine(a: 0.47546886895862506d, b: 0.051947020456392434d, c: 0.8570208125613471d),

new NpgsqlTypes.NpgsqlLine(a: 0.9231901030504017d, b: 0.6558718079741761d, c: 0.9131579244908973d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8424436015968617d, b: 0.7676875121061684d, c: 0.33379810281471267d),

new NpgsqlTypes.NpgsqlLine(a: 0.0362588163108315d, b: 0.6078006516959322d, c: 0.8981824667713876d),

new NpgsqlTypes.NpgsqlLine(a: 0.43363341118590126d, b: 0.2802437904561761d, c: 0.7483439331516484d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.150473846470061d, b: 0.23727424204642322d, c: 0.7063821766857871d),

new NpgsqlTypes.NpgsqlLine(a: 0.19226014477903275d, b: 0.5639908447808166d, c: 0.9172006827305715d),

new NpgsqlTypes.NpgsqlLine(a: 0.6921434127946762d, b: 0.5222733649653886d, c: 0.39212094984849133d),

new NpgsqlTypes.NpgsqlLine(a: 0.9269334403426001d, b: 0.7455291421961003d, c: 0.15852400210938555d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7546782616467561d, b: 0.7660210045305608d, c: 0.002101256990528877d),

new NpgsqlTypes.NpgsqlLine(a: 0.7873198475504575d, b: 0.6562885223637778d, c: 0.4595257365895049d),

new NpgsqlTypes.NpgsqlLine(a: 0.13723224215765983d, b: 0.028189612067694325d, c: 0.5578908935745758d),

new NpgsqlTypes.NpgsqlLine(a: 0.3726051373379309d, b: 0.5584304932079498d, c: 0.1497065211391777d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2664294708435804d, b: 0.7275873091644987d, c: 0.4578964257737156d),

new NpgsqlTypes.NpgsqlLine(a: 0.11537698829065035d, b: 0.15597571625414164d, c: 0.25868776150687744d),

new NpgsqlTypes.NpgsqlLine(a: 0.7253272629148348d, b: 0.5103100528514511d, c: 0.6163630740104445d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22666559213907822d, b: 0.6690268161278828d, c: 0.5437083731343447d),

new NpgsqlTypes.NpgsqlLine(a: 0.6945745808186431d, b: 0.7779717114870395d, c: 0.6586523521615594d),

new NpgsqlTypes.NpgsqlLine(a: 0.9958776297426593d, b: 0.18723266020517848d, c: 0.5051893013133526d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8346215642002839d, b: 0.02501426927641104d, c: 0.18564255784328232d),

new NpgsqlTypes.NpgsqlLine(a: 0.9828018621735651d, b: 0.25982572500761425d, c: 0.48730939980762333d),

new NpgsqlTypes.NpgsqlLine(a: 0.8921096482465398d, b: 0.3115031257055042d, c: 0.7443097622974093d),

new NpgsqlTypes.NpgsqlLine(a: 0.5058545388616341d, b: 0.3608473823390823d, c: 0.9064931950216698d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7111028833142421d, b: 0.07649168876460144d, c: 0.16186859283775934d),

new NpgsqlTypes.NpgsqlLine(a: 0.2538518333691212d, b: 0.5070148421072984d, c: 0.18968045160227065d),

new NpgsqlTypes.NpgsqlLine(a: 0.3656386533738524d, b: 0.7788365310701038d, c: 0.9718441832953698d),

new NpgsqlTypes.NpgsqlLine(a: 0.19967568451201312d, b: 0.530099572244978d, c: 0.8126757924478049d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7037177896869284d, b: 0.02322822900087551d, c: 0.7033178061566374d),

new NpgsqlTypes.NpgsqlLine(a: 0.07179738564942528d, b: 0.03777130857354438d, c: 0.24798074983968577d),

new NpgsqlTypes.NpgsqlLine(a: 0.11452186346459237d, b: 0.6211168992356959d, c: 0.1793837926867281d),

new NpgsqlTypes.NpgsqlLine(a: 0.24470653277236498d, b: 0.5464060348410492d, c: 0.9834586430403435d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1028936339137344d, b: 0.12989002507739644d, c: 0.14578240478825233d),

new NpgsqlTypes.NpgsqlLine(a: 0.7247097006080054d, b: 0.9532957491601822d, c: 0.5128540545111154d),

new NpgsqlTypes.NpgsqlLine(a: 0.6373791615483126d, b: 0.6827604141398327d, c: 0.6777682496287261d),

new NpgsqlTypes.NpgsqlLine(a: 0.7812544390796282d, b: 0.5666043522586826d, c: 0.5815706209492969d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20092284938040195d, b: 0.09624377100930859d, c: 0.5929525954851357d),

new NpgsqlTypes.NpgsqlLine(a: 0.893405592734672d, b: 0.7594477244611234d, c: 0.9324187583126627d),

new NpgsqlTypes.NpgsqlLine(a: 0.34416382049030314d, b: 0.6007301008546471d, c: 0.5638618827720508d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6026262117461523d, b: 0.9357289889716729d, c: 0.38926061142099755d),

new NpgsqlTypes.NpgsqlLine(a: 0.336653211265747d, b: 0.5536447208121669d, c: 0.7975760486220468d),

new NpgsqlTypes.NpgsqlLine(a: 0.1667210725592576d, b: 0.48137148819087316d, c: 0.8932614952819234d),

new NpgsqlTypes.NpgsqlLine(a: 0.10651757867571032d, b: 0.05319150452453414d, c: 0.9540925577070479d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45114164272064916d, b: 0.3640021056250681d, c: 0.06612466584906607d),

new NpgsqlTypes.NpgsqlLine(a: 0.12267422086007618d, b: 0.9783273002319822d, c: 0.8018160516134648d),

new NpgsqlTypes.NpgsqlLine(a: 0.6089572684228425d, b: 0.524529489867832d, c: 0.23414301735355236d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1821914569717753d, b: 0.1532574471373891d, c: 0.9102290124652751d),

new NpgsqlTypes.NpgsqlLine(a: 0.3450648238731765d, b: 0.7910838061770656d, c: 0.8451939297679466d),

new NpgsqlTypes.NpgsqlLine(a: 0.2137548195052712d, b: 0.289043325998127d, c: 0.5372931087118668d),

new NpgsqlTypes.NpgsqlLine(a: 0.38522692820681714d, b: 0.8838062170823608d, c: 0.5079604541130842d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2745804711219225d, b: 0.8944087841330921d, c: 0.7663159401852855d),

new NpgsqlTypes.NpgsqlLine(a: 0.9161888189143363d, b: 0.5150930456711242d, c: 0.5740508770767264d),

new NpgsqlTypes.NpgsqlLine(a: 0.5300255415243937d, b: 0.5284028763383807d, c: 0.014787455645843939d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19630807184983767d, b: 0.4247214116492233d, c: 0.633211093433045d),

new NpgsqlTypes.NpgsqlLine(a: 0.8441155009867272d, b: 0.7726075696851754d, c: 0.6624616266680079d),

new NpgsqlTypes.NpgsqlLine(a: 0.4112131737945991d, b: 0.7661757246022709d, c: 0.5421071030699937d),

new NpgsqlTypes.NpgsqlLine(a: 0.5651222252017791d, b: 0.3603875813411229d, c: 0.17566601997436926d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7410505869070116d, b: 0.3396676017093643d, c: 0.712330620158309d),

new NpgsqlTypes.NpgsqlLine(a: 0.23950902457258905d, b: 0.08118504844134333d, c: 0.00892788545550538d),

new NpgsqlTypes.NpgsqlLine(a: 0.3884588017453421d, b: 0.4458248760467235d, c: 0.19568367111567508d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40676563111918296d, b: 0.7351374395234185d, c: 0.34404830535225306d),

new NpgsqlTypes.NpgsqlLine(a: 0.5409899081880192d, b: 0.41976447283900453d, c: 0.5635276662538831d),

new NpgsqlTypes.NpgsqlLine(a: 0.05592480431429314d, b: 0.2766133734579267d, c: 0.1345850264613654d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7206012762962524d, b: 0.32853567629337255d, c: 0.7429320671710088d),

new NpgsqlTypes.NpgsqlLine(a: 0.39436230046751497d, b: 0.6646880261892785d, c: 0.4991795189696834d),

new NpgsqlTypes.NpgsqlLine(a: 0.48630813269642115d, b: 0.500781468252822d, c: 0.9747343270125285d),

new NpgsqlTypes.NpgsqlLine(a: 0.29500614648517043d, b: 0.3499030535769203d, c: 0.551234809549377d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6683824014321497d, b: 0.8718254314526649d, c: 0.19658007244910203d),

new NpgsqlTypes.NpgsqlLine(a: 0.12343311164673121d, b: 0.29347792938322914d, c: 0.03892291068216669d),

new NpgsqlTypes.NpgsqlLine(a: 0.6649724197036363d, b: 0.7294848338555944d, c: 0.926518351338947d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.41362300428928955d, b: 0.34446577335630235d, c: 0.6763641715196294d),

new NpgsqlTypes.NpgsqlLine(a: 0.6161022247101586d, b: 0.8718165250283086d, c: 0.7995873113733849d),

new NpgsqlTypes.NpgsqlLine(a: 0.6671303618988665d, b: 0.7372804377748358d, c: 0.9806194355745406d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8711905810167682d, b: 0.6545981027747736d, c: 0.2569857192605216d),

new NpgsqlTypes.NpgsqlLine(a: 0.43379224711141495d, b: 0.2107404880057001d, c: 0.13202297739271163d),

new NpgsqlTypes.NpgsqlLine(a: 0.7464494308972753d, b: 0.1955980242586841d, c: 0.8854055797413397d),

new NpgsqlTypes.NpgsqlLine(a: 0.8087865256630317d, b: 0.31688083405126d, c: 0.4192260636730585d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6148475480942062d, b: 0.3191024172181366d, c: 0.28080894666701806d),

new NpgsqlTypes.NpgsqlLine(a: 0.5936913705601551d, b: 0.5649418619940886d, c: 0.5109184450055609d),

new NpgsqlTypes.NpgsqlLine(a: 0.5353318362144367d, b: 0.18463964745521633d, c: 0.4439848775402052d),

new NpgsqlTypes.NpgsqlLine(a: 0.6419697089206367d, b: 0.543368246012125d, c: 0.2981433145530421d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40550297985845973d, b: 0.42404834459637675d, c: 0.5397603372261518d),

new NpgsqlTypes.NpgsqlLine(a: 0.00433436200935533d, b: 0.7374235162880213d, c: 0.10401750832121837d),

new NpgsqlTypes.NpgsqlLine(a: 0.7745579327033668d, b: 0.5358707286042883d, c: 0.12557035704904185d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46051447240234533d, b: 0.6308715882515041d, c: 0.6374997456142869d),

new NpgsqlTypes.NpgsqlLine(a: 0.23016652612554478d, b: 0.7089071433015798d, c: 0.828905912224856d),

new NpgsqlTypes.NpgsqlLine(a: 0.712867680879279d, b: 0.7151088617370919d, c: 0.5852478746719916d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2793314199094088d, b: 0.9033295544637145d, c: 0.6683685008142427d),

new NpgsqlTypes.NpgsqlLine(a: 0.09524635045718266d, b: 0.8756058927006369d, c: 0.14411370177901772d),

new NpgsqlTypes.NpgsqlLine(a: 0.1504914357822481d, b: 0.041539686848553914d, c: 0.12358948280125182d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4244632568036447d, b: 0.8710878357224046d, c: 0.17970242048771012d),

new NpgsqlTypes.NpgsqlLine(a: 0.8610311067687735d, b: 0.5732357068916974d, c: 0.25229321534011384d),

new NpgsqlTypes.NpgsqlLine(a: 0.6776304004451967d, b: 0.34504687340577633d, c: 0.3604471845209115d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.020999519982818793d, b: 0.05591139084462249d, c: 0.9191024307925054d),

new NpgsqlTypes.NpgsqlLine(a: 0.2340575035062925d, b: 0.13969176615631163d, c: 0.5877615394298208d),

new NpgsqlTypes.NpgsqlLine(a: 0.7471988526025067d, b: 0.2990697054356496d, c: 0.4021592273372562d),

new NpgsqlTypes.NpgsqlLine(a: 0.7935558740409302d, b: 0.37247058759061624d, c: 0.6201495612240983d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3419154466025196d, b: 0.3902835089524319d, c: 0.009118797060644557d),

new NpgsqlTypes.NpgsqlLine(a: 0.8996047329323245d, b: 0.6728405226706186d, c: 0.024995376224118293d),

new NpgsqlTypes.NpgsqlLine(a: 0.9280846415022365d, b: 0.4570827993079616d, c: 0.2599187038742905d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5167239997382679d, b: 0.6393153924604263d, c: 0.8642722891570787d),

new NpgsqlTypes.NpgsqlLine(a: 0.5153282329803083d, b: 0.4472445634447648d, c: 0.5099702973068616d),

new NpgsqlTypes.NpgsqlLine(a: 0.3459122954807127d, b: 0.15657790718499442d, c: 0.927096272200434d),

new NpgsqlTypes.NpgsqlLine(a: 0.49850720504805945d, b: 0.3229663526637677d, c: 0.35131367543946246d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5575790936404824d, b: 0.45085150707318467d, c: 0.2670236315134793d),

new NpgsqlTypes.NpgsqlLine(a: 0.5315909267842498d, b: 0.40645400469374404d, c: 0.9683712189166175d),

new NpgsqlTypes.NpgsqlLine(a: 0.7402745779030462d, b: 0.705458809018456d, c: 0.515845887559195d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3447648778847465d, b: 0.2573139131286548d, c: 0.13733442349323566d),

new NpgsqlTypes.NpgsqlLine(a: 0.049864555869530314d, b: 0.319216742095785d, c: 0.7129512779795553d),

new NpgsqlTypes.NpgsqlLine(a: 0.5353459167700791d, b: 0.5000714178951784d, c: 0.2731379168299737d),

new NpgsqlTypes.NpgsqlLine(a: 0.46612913817666146d, b: 0.005904884823376144d, c: 0.033067554852866166d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7063128006183815d, b: 0.3527233962225158d, c: 0.7877783528137362d),

new NpgsqlTypes.NpgsqlLine(a: 0.08644851783573027d, b: 0.6079464888792728d, c: 0.9449164086510917d),

new NpgsqlTypes.NpgsqlLine(a: 0.3794720258169788d, b: 0.6308684019043954d, c: 0.4868599533501262d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5028001533082463d, b: 0.7312640063603563d, c: 0.5469718676044054d),

new NpgsqlTypes.NpgsqlLine(a: 0.48226670908265545d, b: 0.09846770149237438d, c: 0.32964501304984883d),

new NpgsqlTypes.NpgsqlLine(a: 0.3897554999289857d, b: 0.5754529716396097d, c: 0.4852540728783248d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4288419738735222d, b: 0.7152692579359623d, c: 0.34345939554244875d),

new NpgsqlTypes.NpgsqlLine(a: 0.029371145152227718d, b: 0.43160288801511315d, c: 0.9965015023555471d),

new NpgsqlTypes.NpgsqlLine(a: 0.38722572831085766d, b: 0.33635673139962696d, c: 0.48586173059565185d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14530259540262214d, b: 0.6534214402366229d, c: 0.39692831120080796d),

new NpgsqlTypes.NpgsqlLine(a: 0.8285412649673878d, b: 0.35459397011071503d, c: 0.06753460824152235d),

new NpgsqlTypes.NpgsqlLine(a: 0.27632688477229195d, b: 0.4555197801479519d, c: 0.25163307168339955d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7057945009966108d, b: 0.7870161472845582d, c: 0.3037355193670991d),

new NpgsqlTypes.NpgsqlLine(a: 0.9874922433579751d, b: 0.47170954047384994d, c: 0.901890992641644d),

new NpgsqlTypes.NpgsqlLine(a: 0.6641571691201463d, b: 0.7796175429156786d, c: 0.3064942392082708d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.477298059624252d, b: 0.8364078759857136d, c: 0.6552161815696294d),

new NpgsqlTypes.NpgsqlLine(a: 0.34787964504371305d, b: 0.6611749775056012d, c: 0.812267804514384d),

new NpgsqlTypes.NpgsqlLine(a: 0.9882617044705059d, b: 0.4388997016334839d, c: 0.9602764186556604d),

new NpgsqlTypes.NpgsqlLine(a: 0.16756291768058285d, b: 0.10127125093318068d, c: 0.07126053749639616d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12277606434103439d, b: 0.3162428062296707d, c: 0.20519343151268754d),

new NpgsqlTypes.NpgsqlLine(a: 0.03543814631079478d, b: 0.3526763527280752d, c: 0.4247175182361659d),

new NpgsqlTypes.NpgsqlLine(a: 0.8694684955594462d, b: 0.5907669599555234d, c: 0.6566275569851748d),

new NpgsqlTypes.NpgsqlLine(a: 0.6461647941029847d, b: 0.307885107220482d, c: 0.9473735634761387d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6109734580175415d, b: 0.5720109114169787d, c: 0.4621664306079323d),

new NpgsqlTypes.NpgsqlLine(a: 0.8742560506366649d, b: 0.5725246817668798d, c: 0.3997595890271267d),

new NpgsqlTypes.NpgsqlLine(a: 0.5942814248487779d, b: 0.44565669800816365d, c: 0.7068965300011736d),

new NpgsqlTypes.NpgsqlLine(a: 0.9751095505142641d, b: 0.2756005256965687d, c: 0.5730222093455198d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9669086376979116d, b: 0.02328819635451973d, c: 0.2714923753236892d),

new NpgsqlTypes.NpgsqlLine(a: 0.010618187140412516d, b: 0.6859273546250171d, c: 0.011363393163980273d),

new NpgsqlTypes.NpgsqlLine(a: 0.12645305254572403d, b: 0.7872200564658974d, c: 0.345132000351574d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3491436194861103d, b: 0.3820313879241085d, c: 0.10524960549153006d),

new NpgsqlTypes.NpgsqlLine(a: 0.8297289516537701d, b: 0.8439068907870083d, c: 0.22657745997298617d),

new NpgsqlTypes.NpgsqlLine(a: 0.9581506488662288d, b: 0.5762433691456507d, c: 0.17178362617906484d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.38891083139240534d, b: 0.4485505311440504d, c: 0.27640079582663146d),

new NpgsqlTypes.NpgsqlLine(a: 0.6411287914438751d, b: 0.28364233756968016d, c: 0.751182781755375d),

new NpgsqlTypes.NpgsqlLine(a: 0.009560665074768604d, b: 0.553223798385236d, c: 0.5201622032244952d),

new NpgsqlTypes.NpgsqlLine(a: 0.6880557187427462d, b: 0.4173986768931818d, c: 0.3185138188917419d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7471771526903455d, b: 0.33930172943786185d, c: 0.6135836187261556d),

new NpgsqlTypes.NpgsqlLine(a: 0.12343572959174698d, b: 0.44417627830871664d, c: 0.2572830630082681d),

new NpgsqlTypes.NpgsqlLine(a: 0.6277933780000955d, b: 0.6076335111613976d, c: 0.09215450671850112d),

new NpgsqlTypes.NpgsqlLine(a: 0.8325417099199107d, b: 0.43816377577403287d, c: 0.5053328830698915d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26012328382636374d, b: 0.24774240943044656d, c: 0.4277965519160235d),

new NpgsqlTypes.NpgsqlLine(a: 0.9615842752638437d, b: 0.4635222821811611d, c: 0.39820435977132007d),

new NpgsqlTypes.NpgsqlLine(a: 0.11628222800675436d, b: 0.8793881931831854d, c: 0.09504475184527539d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4416372814442212d, b: 0.6335683543744732d, c: 0.6539480585426147d),

new NpgsqlTypes.NpgsqlLine(a: 0.72644237976461d, b: 0.1943974433912573d, c: 0.11509274986222096d),

new NpgsqlTypes.NpgsqlLine(a: 0.8341119028531808d, b: 0.13403244133466174d, c: 0.7565166139800158d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1401853913243839d, b: 0.8290004659299172d, c: 0.4642544704845921d),

new NpgsqlTypes.NpgsqlLine(a: 0.5974551750500069d, b: 0.7863488795933176d, c: 0.7277023693086553d),

new NpgsqlTypes.NpgsqlLine(a: 0.8589902645625286d, b: 0.5203589378847697d, c: 0.10142492030247752d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9785217758295978d, b: 0.9699989498702912d, c: 0.6314973887538295d),

new NpgsqlTypes.NpgsqlLine(a: 0.16937412242352234d, b: 0.47425560534551636d, c: 0.6737650954464528d),

new NpgsqlTypes.NpgsqlLine(a: 0.7637806290849503d, b: 0.34921512502269836d, c: 0.8141936418588419d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7769196612666881d, b: 0.5705959783898219d, c: 0.8890478084528656d),

new NpgsqlTypes.NpgsqlLine(a: 0.2695302850118808d, b: 0.6123550205092538d, c: 0.9622094866918633d),

new NpgsqlTypes.NpgsqlLine(a: 0.5663417483924281d, b: 0.23251102975442817d, c: 0.15944326012109755d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6842376801644778d, b: 0.7833517583882461d, c: 0.4221737455799468d),

new NpgsqlTypes.NpgsqlLine(a: 0.2003992699356658d, b: 0.4089847917405047d, c: 0.15945229175850695d),

new NpgsqlTypes.NpgsqlLine(a: 0.6710395362392684d, b: 0.6828295561524905d, c: 0.9347789600515737d),

new NpgsqlTypes.NpgsqlLine(a: 0.6523130056424263d, b: 0.9897800346163698d, c: 0.20953091239728638d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27599603253495086d, b: 0.43117593950543953d, c: 0.24698940807539527d),

new NpgsqlTypes.NpgsqlLine(a: 0.021285246890556664d, b: 0.44125614455834816d, c: 0.2536396454905784d),

new NpgsqlTypes.NpgsqlLine(a: 0.8710132294644652d, b: 0.5003067633012064d, c: 0.4962709004986475d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15204918897553954d, b: 0.06362181621482399d, c: 0.13208321866212247d),

new NpgsqlTypes.NpgsqlLine(a: 0.8685633823686991d, b: 0.8263999989480488d, c: 0.3909623030948344d),

new NpgsqlTypes.NpgsqlLine(a: 0.6924962173053675d, b: 0.8252696376059736d, c: 0.759966399180199d),

new NpgsqlTypes.NpgsqlLine(a: 0.35267384665833745d, b: 0.5395386330744691d, c: 0.9564215384580056d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9949374637561964d, b: 0.09528454018595778d, c: 0.7651336351497553d),

new NpgsqlTypes.NpgsqlLine(a: 0.38521141912228374d, b: 0.3973890599211487d, c: 0.9307819841804813d),

new NpgsqlTypes.NpgsqlLine(a: 0.26018541599882083d, b: 0.3201633263489402d, c: 0.9415006530147302d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                List<NpgsqlLinelineListD1E2M> models = null;

                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineListD1E2M> models = null;

                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 69, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 18, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 86, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 100, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 65, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 43, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 100, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatch(connection, 43, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models = await ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[3], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[4], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[5], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[6], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[7], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[8], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[9], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[10], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[11], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[12], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[13], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[14], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[15], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[16], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[17], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models =  ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[9], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[10], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[11], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[12], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[13], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[14], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[15], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[16], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[17], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
FROM public.binary_npgsqllinelinelistd1e2m m
LEFT JOIN public.binary_npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineListlineListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI), typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                await ((INpgsqlLineListlineListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                ((INpgsqlLineListlineListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

