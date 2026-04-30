

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
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7286607846070422d, y: 0.01039126798141976d), radius: 0.006165198503536362d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9328932062401507d, y: 0.4773719741891306d), radius: 0.14861872821336375d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12838215344970239d, y: 0.43796939773681354d), radius: 0.8777301839927067d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7132082776898258d, y: 0.07867967370847206d), radius: 0.7565823906734096d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5497477073348052d, y: 0.8663691213259526d), radius: 0.9004625664175203d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9511064832959012d, y: 0.8328815318273592d), radius: 0.43735922533970606d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24962438192803482d, y: 0.20702495423436684d), radius: 0.9158487331573334d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4595783353456171d, y: 0.8922237799730878d), radius: 0.40294987428910634d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42036733299057083d, y: 0.18741503261271197d), radius: 0.30343889074888664d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4615988845140603d, y: 0.33003029969186937d), radius: 0.4034162850958697d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3410539039240217d, y: 0.562583319281604d), radius: 0.5792371650594529d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36786652989429725d, y: 0.3933434244019426d), radius: 0.40416617061477245d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10757126643398562d, y: 0.047203453580477395d), radius: 0.5898298209511353d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35196630616985203d, y: 0.31383532747909815d), radius: 0.26580710665413154d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11592351653956023d, y: 0.8523391693961968d), radius: 0.5292827709831986d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9942183099808618d, y: 0.6785790647318722d), radius: 0.23482451786331637d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.210238559541293d, y: 0.28807353554194304d), radius: 0.019071673215713236d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7031042893192532d, y: 0.800368098100226d), radius: 0.7214546331833297d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0006157281506435908d, y: 0.5431735908062549d), radius: 0.9334367526957179d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3136919608427793d, y: 0.11969715783677215d), radius: 0.09885080048696093d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5068026452069955d, y: 0.3908430102629713d), radius: 0.8988489356459964d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6174488799083072d, y: 0.0639045142443122d), radius: 0.06872682153823151d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13212855863464656d, y: 0.9569821708724996d), radius: 0.1982405012443491d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9243053771210138d, y: 0.07922972071145418d), radius: 0.1490111130596038d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6440582507024066d, y: 0.6963319598173797d), radius: 0.2603023068183783d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7701633179391681d, y: 0.36049035964320353d), radius: 0.858403985208839d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7456453394232319d, y: 0.38872852269116476d), radius: 0.6564514161062985d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9096866169713689d, y: 0.8143510241781898d), radius: 0.2775682753716122d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21371134783679735d, y: 0.9054090829793627d), radius: 0.0653378619508076d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7724441819247357d, y: 0.31638810180461674d), radius: 0.7492541775413045d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05201540599731036d, y: 0.6370975700029735d), radius: 0.692247982692053d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8887618456975706d, y: 0.5050155481242217d), radius: 0.8508237929628888d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8737935152881205d, y: 0.21387650345699338d), radius: 0.8608128968766795d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8499582352554569d, y: 0.9209387713841696d), radius: 0.01157069958626089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00889750820307278d, y: 0.502274976604584d), radius: 0.6110105267558341d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6598579009029867d, y: 0.4578770585701447d), radius: 0.2701526708344628d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09402222565852503d, y: 0.6583572994518091d), radius: 0.20509313850276323d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15772295338919273d, y: 0.5152525211043645d), radius: 0.8555777405763283d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8119192757551857d, y: 0.3944766174416863d), radius: 0.14741600653136966d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05209044228717441d, y: 0.7982030050060669d), radius: 0.44236942779618604d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.035025398493609416d, y: 0.702233151790619d), radius: 0.016793481485897876d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2671333668112402d, y: 0.9647660363048638d), radius: 0.9352115866713571d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9278978587675707d, y: 0.7966848035793452d), radius: 0.02138632140061658d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9085702589607875d, y: 0.45354801081484764d), radius: 0.08272971443176391d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.488273845969439d, y: 0.567021746279379d), radius: 0.6688189482596757d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6784027893827098d, y: 0.8470738678242101d), radius: 0.8556763065913023d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26347610379725694d, y: 0.638691914454952d), radius: 0.7163603922640918d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6391633352612114d, y: 0.5935774300727548d), radius: 0.782643558427288d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16767381245219415d, y: 0.2000820901793645d), radius: 0.25487359593337033d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7978069196703238d, y: 0.8348902776947595d), radius: 0.11302261641656952d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03547292781266731d, y: 0.37305729665332266d), radius: 0.2479173533744109d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2651085629683455d, y: 0.45368163430469155d), radius: 0.46076602139932077d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012059855377097861d, y: 0.9982987870965975d), radius: 0.04803050847730461d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9609176838157337d, y: 0.6862865337081978d), radius: 0.5262291142443687d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6807123293669196d, y: 0.40589237377121845d), radius: 0.8574715508848776d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0011699798327970967d, y: 0.9792900379571077d), radius: 0.5101473045642602d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7934521749732336d, y: 0.039096630896924944d), radius: 0.4561263787237819d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3686718835680328d, y: 0.31250797525316465d), radius: 0.2287435678020704d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6912071997126925d, y: 0.8287533736773344d), radius: 0.7778333820513674d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7632311057495518d, y: 0.7213076788719438d), radius: 0.7291388088223792d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24244572961653632d, y: 0.6191687945568842d), radius: 0.253369591821322d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6432030961845082d, y: 0.14200906436294003d), radius: 0.9803950158019119d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13715120732818875d, y: 0.8541129171760846d), radius: 0.9599014452073661d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15426464932708295d, y: 0.535051111068028d), radius: 0.18635014694435748d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44893741874802584d, y: 0.7961690197977491d), radius: 0.21196623755922628d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3896954660972797d, y: 0.04344950958782268d), radius: 0.052453263068930056d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9244700250428236d, y: 0.4140193903496404d), radius: 0.09540293240700504d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36818387429998034d, y: 0.7087270400531375d), radius: 0.21149527640602717d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5034168825437785d, y: 0.39067534663631254d), radius: 0.305770235452555d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11064192123448213d, y: 0.8961517764221576d), radius: 0.35076730443278703d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17874286858261823d, y: 0.9401605772742027d), radius: 0.8624970352728776d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4075230016179121d, y: 0.2715170348372925d), radius: 0.7457740311020031d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7867488076483832d, y: 0.6286676414727247d), radius: 0.41982333051933274d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0946864145481735d, y: 0.3211218905078177d), radius: 0.646374985809189d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17303741304228082d, y: 0.6329307207246501d), radius: 0.6719800073535905d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9130946147993749d, y: 0.6788468673593095d), radius: 0.8912430319530303d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7339975195136116d, y: 0.4229130408940003d), radius: 0.2997403058915762d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013150963258078519d, y: 0.8318358614213448d), radius: 0.3177981554082676d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5851718789403964d, y: 0.9950078545301092d), radius: 0.8050146585841147d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9628832400886105d, y: 0.8617362236311373d), radius: 0.2920244762645885d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8768511945190511d, y: 0.28743718795579276d), radius: 0.13956727820183146d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9503005940786565d, y: 0.854097979246427d), radius: 0.37398613554863047d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7351384606776161d, y: 0.9464016439470102d), radius: 0.47578463316311803d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027081101033425425d, y: 0.08785565339642698d), radius: 0.9092069415749483d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10283571188116492d, y: 0.8997234374592231d), radius: 0.08898281770579786d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7242384032486652d, y: 0.2675520190223061d), radius: 0.9992935436046813d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6742732939856299d, y: 0.8600646770299288d), radius: 0.6708933242100223d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3483102130533057d, y: 0.19204213323518504d), radius: 0.7716586662779057d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03505377295528589d, y: 0.54370820959615d), radius: 0.06123790658400119d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08857487976036926d, y: 0.781883224144638d), radius: 0.7948277496994752d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8531258562003267d, y: 0.0032715455878459254d), radius: 0.2833002165712667d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9905137469753879d, y: 0.4667163784391598d), radius: 0.192997562357765d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9072111969870541d, y: 0.8957092269567448d), radius: 0.6395720938534549d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5575580848083919d, y: 0.8779203789014622d), radius: 0.9397456128522089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1443381128114385d, y: 0.15029905356504314d), radius: 0.95242822660889d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6381544211050844d, y: 0.18651051318361578d), radius: 0.3343602640023269d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8170315883231583d, y: 0.7029905746054421d), radius: 0.9294206693759848d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3024426880648665d, y: 0.7298581332070075d), radius: 0.18519219513034224d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7407107057415873d, y: 0.17217350657142994d), radius: 0.6206160468583614d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49755038081919223d, y: 0.8906727000863577d), radius: 0.6023558809102729d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05133348969551732d, y: 0.06596125001452935d), radius: 0.49432758418543876d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7998346378431598d, y: 0.9297072960677909d), radius: 0.17601429848735484d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8866852573199612d, y: 0.40463352565251864d), radius: 0.22213173140117093d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42512580902458363d, y: 0.12350774225153416d), radius: 0.06604946394359168d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30032496076988535d, y: 0.8549572039884114d), radius: 0.7580274506465098d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3875025039681015d, y: 0.040985624793031916d), radius: 0.9994818550907006d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4873386498574991d, y: 0.2718293828545757d), radius: 0.3890718477159987d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3589758218821638d, y: 0.9630580216048377d), radius: 0.9019257528367637d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9620248407616898d, y: 0.842252381426268d), radius: 0.460802490705041d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44010876301962654d, y: 0.26500593578724074d), radius: 0.7716171138192889d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3540756935243784d, y: 0.7856526883600756d), radius: 0.06086922926540561d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7588491148560292d, y: 0.4965376532559449d), radius: 0.6716578651190109d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3660369537696132d, y: 0.05552043229591186d), radius: 0.5209591335896321d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2642375976325734d, y: 0.02643601071633994d), radius: 0.6564505307126747d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8706179932082203d, y: 0.7955096056035497d), radius: 0.06379863412336517d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6225447671169532d, y: 0.2110923860410845d), radius: 0.19088804340632948d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7836649801836304d, y: 0.45600535127800024d), radius: 0.897117557644651d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009791597715207323d, y: 0.06024864826456322d), radius: 0.7216194968574581d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00032322408070584174d, y: 0.6027099251442309d), radius: 0.4938664670458923d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44544981550924556d, y: 0.06446567710137618d), radius: 0.7020359458597121d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41201367326991356d, y: 0.7703844144607361d), radius: 0.5862037447497203d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23074409626371406d, y: 0.5078511356761917d), radius: 0.17400442803264815d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6873014542302814d, y: 0.95188569141178d), radius: 0.7467845100938504d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8345935659796607d, y: 0.26667862324210645d), radius: 0.10673962458704889d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7912069848055373d, y: 0.7845092868985052d), radius: 0.14847603759762695d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9573653022865249d, y: 0.8204002423166668d), radius: 0.6017010256510941d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25042029201528604d, y: 0.258142397085777d), radius: 0.6302795169503299d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8270237419311823d, y: 0.29450564395098866d), radius: 0.9454749878710088d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02727252883082021d, y: 0.39208278826192033d), radius: 0.33782208696660754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2614878930221832d, y: 0.1298245169750879d), radius: 0.09805984591663552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7783386795639788d, y: 0.058754471370676464d), radius: 0.20818070340961925d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9897830300493612d, y: 0.13914436446835032d), radius: 0.631924787567497d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11581349102645688d, y: 0.8617088111067795d), radius: 0.8631525777274428d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7067645055567148d, y: 0.5639217596644213d), radius: 0.8964673450955696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9123565797306318d, y: 0.7254663311815213d), radius: 0.6667314080611143d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7636851985249145d, y: 0.7903249274672536d), radius: 0.00623468907507585d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38982946490467085d, y: 0.29394426063644297d), radius: 0.6487223872260123d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9775881702679639d, y: 0.5481697266987744d), radius: 0.46255716925655566d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6579577734608417d, y: 0.38386480490902275d), radius: 0.8669184399589646d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5753375541417962d, y: 0.8888981355657135d), radius: 0.8575823319834877d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021127004513502246d, y: 0.6059603510284666d), radius: 0.7139676224046001d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.046698135267117635d, y: 0.08633837432648406d), radius: 0.45983527389147527d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.040411806620884616d, y: 0.8596685861802078d), radius: 0.5822543038426238d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6758638784356102d, y: 0.12822044869922855d), radius: 0.08731862071811047d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.494953671373344d, y: 0.7567115559890838d), radius: 0.7641670117601236d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5519533934574806d, y: 0.8855422348777917d), radius: 0.7399832037614588d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5915125283528221d, y: 0.3944951248600631d), radius: 0.025566013773913654d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.756474236489291d, y: 0.6771199797839519d), radius: 0.6746275449878407d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8139127774382735d, y: 0.9961359040213674d), radius: 0.10375495494728426d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36338231358385653d, y: 0.3995694448527084d), radius: 0.8633660299422354d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2257725639949757d, y: 0.20067126670530722d), radius: 0.004252759546195306d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8849384645094435d, y: 0.29229735635050325d), radius: 0.10773070488352399d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33571961674898987d, y: 0.8239126270527601d), radius: 0.4128700843552031d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9598969135456857d, y: 0.07707588030071777d), radius: 0.8176413626956148d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17719262435743777d, y: 0.3340187927355416d), radius: 0.7463278195785858d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09740976936971868d, y: 0.40114686168482827d), radius: 0.12416146967694597d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2689003399244675d, y: 0.7873451079604789d), radius: 0.6235918783643141d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5353218012251438d, y: 0.8683369581865299d), radius: 0.15720473802276314d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9007064175960353d, y: 0.9668917357778548d), radius: 0.6501344650734149d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44700106193530953d, y: 0.4777355708791905d), radius: 0.8942223915559278d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7925421670954593d, y: 0.3166710662081673d), radius: 0.7062317395952226d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3678517041300644d, y: 0.9288156550867146d), radius: 0.4402371492941598d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6991954491207801d, y: 0.816115237857568d), radius: 0.3069976133521757d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5228956551107655d, y: 0.6503381504977888d), radius: 0.6808686214207015d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.736353301752201d, y: 0.6146929064512554d), radius: 0.5852079770196936d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5048854648041614d, y: 0.27671166924128077d), radius: 0.9646574948563091d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9714045489407327d, y: 0.3704227899722107d), radius: 0.5658680641733866d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6268416131768147d, y: 0.13750652519159456d), radius: 0.7831070777735466d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39547273631525626d, y: 0.2764845684155778d), radius: 0.07353531580961048d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13679456998626516d, y: 0.36797176238060336d), radius: 0.9756654793905272d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8348987152968526d, y: 0.7657516374189713d), radius: 0.7092420066184438d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7038955568385938d, y: 0.988578253577359d), radius: 0.5704419477247629d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31445065299046826d, y: 0.38702287528126234d), radius: 0.9049275279417566d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9744114075851362d, y: 0.20696372129577256d), radius: 0.9940737952532439d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6735889904141701d, y: 0.628516615944491d), radius: 0.015844382013106117d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28424358460808785d, y: 0.28493090328896853d), radius: 0.717812889401388d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6726074480758292d, y: 0.4417655599666396d), radius: 0.2898999455467469d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3072613960026257d, y: 0.6391115365224765d), radius: 0.04429928140713668d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015758073030335717d, y: 0.06013892401130294d), radius: 0.16310799589075908d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7694963402203799d, y: 0.78847516305204d), radius: 0.021743053051734185d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7131170513214381d, y: 0.2558425126418503d), radius: 0.5196830861675091d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23100195719559302d, y: 0.9550162698612054d), radius: 0.14849272589448503d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23454873433574186d, y: 0.9393361688067783d), radius: 0.13228380620895508d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9409510492548498d, y: 0.5954156538052496d), radius: 0.8656341954149794d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015188338835735227d, y: 0.6983132006593451d), radius: 0.33257622952580246d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11971669319826306d, y: 0.20935170914912948d), radius: 0.876178028808303d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7009052562192918d, y: 0.09191560286682832d), radius: 0.4477897048877383d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2709722125926074d, y: 0.1201948921991961d), radius: 0.7325691186399266d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7411772328347411d, y: 0.25983533033290895d), radius: 0.6281767272434791d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8527739000400688d, y: 0.8007353961151927d), radius: 0.6097652899174454d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.929676831159457d, y: 0.0433363252100647d), radius: 0.42241962090209073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7405240347899685d, y: 0.6944329267816114d), radius: 0.3755488348374503d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23317224661126312d, y: 0.5498021139607107d), radius: 0.4558538139217263d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9577373136179331d, y: 0.10654956925780301d), radius: 0.814167558190905d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7771977386334865d, y: 0.8282656438311439d), radius: 0.041059643230863085d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.790366915346681d, y: 0.5018510380433747d), radius: 0.21515412465390427d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11550512079609865d, y: 0.6836536680092674d), radius: 0.6674240675635241d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3043291186632824d, y: 0.3082167604092291d), radius: 0.9745510708555971d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962517789823379d, y: 0.5947271921537864d), radius: 0.6913169257370215d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9708616011476723d, y: 0.6609814932332202d), radius: 0.8241769359605797d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3822396916516998d, y: 0.10831532608030192d), radius: 0.1034087516815595d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4628695607414486d, y: 0.950148970375463d), radius: 0.3397200129753668d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9539501118820354d, y: 0.09132451714836853d), radius: 0.6822569922111941d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9101453127315297d, y: 0.2957839473879288d), radius: 0.8716211118960682d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.838688745804437d, y: 0.05687900620964248d), radius: 0.6751410105251716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6681554559620544d, y: 0.5551821904210696d), radius: 0.9210255711745912d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9108033828551563d, y: 0.7514312376433362d), radius: 0.34949045452924243d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6611953825947494d, y: 0.01715288830178252d), radius: 0.6589036120503d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06840971187796374d, y: 0.34909099491489615d), radius: 0.831930055125802d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6762891475530827d, y: 0.294768287455766d), radius: 0.8499342914379178d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31453779808738014d, y: 0.7069041738693642d), radius: 0.0023201650088182646d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7649603233723772d, y: 0.8815270276412801d), radius: 0.9958038578519885d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.390540326061675d, y: 0.44783734827951915d), radius: 0.20734759229340904d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5637232380393665d, y: 0.16886003663962534d), radius: 0.11357509906137297d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6383144802350645d, y: 0.9560092519884836d), radius: 0.8726080756213747d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.312374454037626d, y: 0.6382363519949793d), radius: 0.5657384519341166d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7379838897839851d, y: 0.5739957024125601d), radius: 0.12810879928398688d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.501666711845012d, y: 0.378934640766591d), radius: 0.39540590031749534d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3194299925365208d, y: 0.905443387588597d), radius: 0.3177689148559101d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3476423552441289d, y: 0.9495646603195024d), radius: 0.5544018685758815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24251250444452954d, y: 0.48619296290245406d), radius: 0.09458143895207471d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3786781111982821d, y: 0.5322271249031678d), radius: 0.87895346244601d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5987895808000196d, y: 0.7104964917571979d), radius: 0.3587179155737512d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7785302129738416d, y: 0.46836903420465403d), radius: 0.7382383095589392d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4885417736086086d, y: 0.0013797766036479642d), radius: 0.17360876232876155d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03842525610082925d, y: 0.7265264911370733d), radius: 0.05472560213002997d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7416446170413544d, y: 0.04866497447783025d), radius: 0.9697861516081437d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7569870461345908d, y: 0.026457961919927442d), radius: 0.03700763443889599d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9714912657817318d, y: 0.8833320628414896d), radius: 0.1736408898797399d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3095697146236964d, y: 0.028384278454420042d), radius: 0.22589683859797383d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21394519071384488d, y: 0.011124409571582672d), radius: 0.9285398079219149d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9979672293264572d, y: 0.34038243300259585d), radius: 0.3565309682914558d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9442826023147127d, y: 0.27600927152107857d), radius: 0.10416665611054532d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32164424231397426d, y: 0.37279959861191303d), radius: 0.26375166790446036d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5613083098933003d, y: 0.15048522726003544d), radius: 0.29761921779620104d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3507163895713763d, y: 0.6588796584197355d), radius: 0.27309884114756566d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3318057916552777d, y: 0.34424903656003814d), radius: 0.22467478494367465d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18450804448642733d, y: 0.8629203330534778d), radius: 0.06006593493623513d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5628618427473069d, y: 0.12021128705810313d), radius: 0.778393269601393d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8771347077424515d, y: 0.2564208447222004d), radius: 0.6761888769440332d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4323744483001285d, y: 0.2108871553990519d), radius: 0.5106541051756481d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29065730247561816d, y: 0.8854181749219127d), radius: 0.7000945362494201d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18019232958771025d, y: 0.1700626310839033d), radius: 0.23361735823117502d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4694510029396335d, y: 0.3054109708455778d), radius: 0.5053332778808888d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08289933568169805d, y: 0.741418309511338d), radius: 0.6825776082003054d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7795888103252598d, y: 0.9660277597325441d), radius: 0.8228944046017205d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2843756247729716d, y: 0.9160104732401875d), radius: 0.42955997206425844d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3013498811419252d, y: 0.34538417364515195d), radius: 0.7019546829537251d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06643258918694828d, y: 0.6992573408936292d), radius: 0.651763958534447d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8847418990418964d, y: 0.9532869201744303d), radius: 0.7880108686261343d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5818666267616274d, y: 0.05234882982165845d), radius: 0.5491828459739321d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4930119665765802d, y: 0.6932277770215414d), radius: 0.1727527895991433d),
},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8499582352554569d, y: 0.9209387713841696d), radius: 0.01157069958626089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00889750820307278d, y: 0.502274976604584d), radius: 0.6110105267558341d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6598579009029867d, y: 0.4578770585701447d), radius: 0.2701526708344628d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9085702589607875d, y: 0.45354801081484764d), radius: 0.08272971443176391d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.488273845969439d, y: 0.567021746279379d), radius: 0.6688189482596757d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6784027893827098d, y: 0.8470738678242101d), radius: 0.8556763065913023d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7978069196703238d, y: 0.8348902776947595d), radius: 0.11302261641656952d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03547292781266731d, y: 0.37305729665332266d), radius: 0.2479173533744109d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2651085629683455d, y: 0.45368163430469155d), radius: 0.46076602139932077d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7632311057495518d, y: 0.7213076788719438d), radius: 0.7291388088223792d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24244572961653632d, y: 0.6191687945568842d), radius: 0.253369591821322d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6432030961845082d, y: 0.14200906436294003d), radius: 0.9803950158019119d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13715120732818875d, y: 0.8541129171760846d), radius: 0.9599014452073661d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36818387429998034d, y: 0.7087270400531375d), radius: 0.21149527640602717d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5034168825437785d, y: 0.39067534663631254d), radius: 0.305770235452555d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11064192123448213d, y: 0.8961517764221576d), radius: 0.35076730443278703d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17874286858261823d, y: 0.9401605772742027d), radius: 0.8624970352728776d),
}));
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
                Assert.That(nullable, Is.Null);
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
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[34], false);
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
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 115, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 29, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 136, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 3, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 98, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[34], false);
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 2, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 136, query1, 39, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[34], false);
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 10, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 70, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 64, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[34], false);
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
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[32], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[33], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[30], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[31], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[32], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[33], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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

