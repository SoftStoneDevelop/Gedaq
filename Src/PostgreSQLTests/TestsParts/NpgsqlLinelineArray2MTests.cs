

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11050135357671986d, b: 0.19763222711541384d, c: 0.8180802599997481d),

new NpgsqlTypes.NpgsqlLine(a: 0.5099467170628075d, b: 0.059353876592388555d, c: 0.2932052927091354d),

new NpgsqlTypes.NpgsqlLine(a: 0.9600124086786508d, b: 0.8702166929804849d, c: 0.9173115284970368d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3238264379278154d, b: 0.9085305466448447d, c: 0.4032544631892312d),

new NpgsqlTypes.NpgsqlLine(a: 0.4072742270323718d, b: 0.3724315923637356d, c: 0.38223654035847676d),

new NpgsqlTypes.NpgsqlLine(a: 0.5324424363508163d, b: 0.623467856181112d, c: 0.8460763545018317d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05191242829199094d, b: 0.31346343355605943d, c: 0.40758638806962866d),

new NpgsqlTypes.NpgsqlLine(a: 0.5282923443313764d, b: 0.4956382483875116d, c: 0.8007851770334996d),

new NpgsqlTypes.NpgsqlLine(a: 0.10305400528677289d, b: 0.6214676386962116d, c: 0.8186692542979054d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36692242834415023d, b: 0.24564848918880322d, c: 0.17836599275964526d),

new NpgsqlTypes.NpgsqlLine(a: 0.9758369896804346d, b: 0.7684301884727586d, c: 0.008469684281775414d),

new NpgsqlTypes.NpgsqlLine(a: 0.03346972893002775d, b: 0.41142098161869745d, c: 0.5124430315569486d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12840010587523298d, b: 0.6017711173965612d, c: 0.34022117007850017d),

new NpgsqlTypes.NpgsqlLine(a: 0.2290917569142048d, b: 0.6122839371876434d, c: 0.8577399653186086d),

new NpgsqlTypes.NpgsqlLine(a: 0.9453182439982525d, b: 0.26928741067765527d, c: 0.404736739117203d),

new NpgsqlTypes.NpgsqlLine(a: 0.7139011064611763d, b: 0.5898959515949262d, c: 0.1932106724469428d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06109745852636017d, b: 0.3738274072609701d, c: 0.5963079677030723d),

new NpgsqlTypes.NpgsqlLine(a: 0.2747977478057495d, b: 0.08184524718953112d, c: 0.35846744356505d),

new NpgsqlTypes.NpgsqlLine(a: 0.5959452052513297d, b: 0.7943753127674141d, c: 0.8466117239453315d),

new NpgsqlTypes.NpgsqlLine(a: 0.020110675650898857d, b: 0.8075885073922189d, c: 0.17964035095758546d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5667520066784403d, b: 0.33299084099330223d, c: 0.26186216637135207d),

new NpgsqlTypes.NpgsqlLine(a: 0.20829153509973064d, b: 0.13071111671811797d, c: 0.8086082056240302d),

new NpgsqlTypes.NpgsqlLine(a: 0.3684633676040765d, b: 0.691923195051225d, c: 0.5640066024812316d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.340029913199305d, b: 0.05694159842637714d, c: 0.6624317648281522d),

new NpgsqlTypes.NpgsqlLine(a: 0.33163399519059633d, b: 0.6960311412579797d, c: 0.14402119949253145d),

new NpgsqlTypes.NpgsqlLine(a: 0.09277938624148518d, b: 0.19309212435597634d, c: 0.9634166898837613d),

new NpgsqlTypes.NpgsqlLine(a: 0.9941486896557785d, b: 0.9638748631837795d, c: 0.353144687201951d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7301650135723484d, b: 0.5405428483450798d, c: 0.4438546823374454d),

new NpgsqlTypes.NpgsqlLine(a: 0.1137143775244861d, b: 0.19647931011949926d, c: 0.5421324529701452d),

new NpgsqlTypes.NpgsqlLine(a: 0.21233218567832235d, b: 0.862037769265356d, c: 0.6668781563376893d),

new NpgsqlTypes.NpgsqlLine(a: 0.21441019261074057d, b: 0.8748611125503053d, c: 0.14712432933973874d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2719147460994985d, b: 0.8138135725654413d, c: 0.7438343928092025d),

new NpgsqlTypes.NpgsqlLine(a: 0.204886143951578d, b: 0.837604950961206d, c: 0.027135611411472027d),

new NpgsqlTypes.NpgsqlLine(a: 0.24187930390029888d, b: 0.17868475102750092d, c: 0.6334953902447853d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.557456437149429d, b: 0.6817530789818742d, c: 0.6332540476741877d),

new NpgsqlTypes.NpgsqlLine(a: 0.4947273992035204d, b: 0.7976821823095539d, c: 0.5307616390733799d),

new NpgsqlTypes.NpgsqlLine(a: 0.7316229735777386d, b: 0.48962375358487653d, c: 0.6188974192456281d),

new NpgsqlTypes.NpgsqlLine(a: 0.9185077929582278d, b: 0.9060420043352224d, c: 0.7048265404789829d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5277878703611455d, b: 0.6340337653427368d, c: 0.0789787295298654d),

new NpgsqlTypes.NpgsqlLine(a: 0.8152834476026642d, b: 0.584807033274386d, c: 0.3666815494341107d),

new NpgsqlTypes.NpgsqlLine(a: 0.9895060213252829d, b: 0.8806041778889401d, c: 0.9659325420786758d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.90195962847299d, b: 0.18586845024978949d, c: 0.63912581287863d),

new NpgsqlTypes.NpgsqlLine(a: 0.8608622398672938d, b: 0.017064356056429975d, c: 0.29631688665914147d),

new NpgsqlTypes.NpgsqlLine(a: 0.34438030519986107d, b: 0.6102234743532727d, c: 0.25505025953835125d),

new NpgsqlTypes.NpgsqlLine(a: 0.3196189247892893d, b: 0.6755533638627225d, c: 0.7459256715140006d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.38567555752136273d, b: 0.893294062456787d, c: 0.9408753356918143d),

new NpgsqlTypes.NpgsqlLine(a: 0.05852957672123715d, b: 0.25933949512390964d, c: 0.36114751350209673d),

new NpgsqlTypes.NpgsqlLine(a: 0.633049257551352d, b: 0.1408460594080435d, c: 0.7172696556220755d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9151414644951533d, b: 0.5142341033748056d, c: 0.2865974239186778d),

new NpgsqlTypes.NpgsqlLine(a: 0.6978843771046636d, b: 0.6663239393966082d, c: 0.8063127706871522d),

new NpgsqlTypes.NpgsqlLine(a: 0.377173782430988d, b: 0.3188008358497856d, c: 0.6687783866683861d),

new NpgsqlTypes.NpgsqlLine(a: 0.25874676976604827d, b: 0.7861477158448787d, c: 0.7791120075418195d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.371743874529036d, b: 0.8862566074245017d, c: 0.6275646519056279d),

new NpgsqlTypes.NpgsqlLine(a: 0.07057605727255134d, b: 0.8469738146286553d, c: 0.9891926297567395d),

new NpgsqlTypes.NpgsqlLine(a: 0.5159086738570542d, b: 0.9860474389683542d, c: 0.05260801994671771d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26995042880627795d, b: 0.735140069169524d, c: 0.1270017553340128d),

new NpgsqlTypes.NpgsqlLine(a: 0.3919217144583428d, b: 0.46281279879532555d, c: 0.8690851503786672d),

new NpgsqlTypes.NpgsqlLine(a: 0.3491953270311765d, b: 0.4632562647794958d, c: 0.1034869737714047d),

new NpgsqlTypes.NpgsqlLine(a: 0.8233377518471408d, b: 0.22016772903251425d, c: 0.2847044826412143d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46266950101183235d, b: 0.47784356219867075d, c: 0.0833255216088904d),

new NpgsqlTypes.NpgsqlLine(a: 0.5204319897419409d, b: 0.48688603727872104d, c: 0.3690359234588726d),

new NpgsqlTypes.NpgsqlLine(a: 0.8362737717709899d, b: 0.5123143568406202d, c: 0.5441207803445647d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6371027408155354d, b: 0.6388397551906022d, c: 0.7385601396343345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6600063499753537d, b: 0.09071749399206208d, c: 0.7460057569970432d),

new NpgsqlTypes.NpgsqlLine(a: 0.5727789638521465d, b: 0.24216160442450219d, c: 0.32989416368102054d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.043841949066258934d, b: 0.6446540459303245d, c: 0.34289310573111065d),

new NpgsqlTypes.NpgsqlLine(a: 0.12975406523411281d, b: 0.2514144198607289d, c: 0.19859296929229275d),

new NpgsqlTypes.NpgsqlLine(a: 0.7736928113020205d, b: 0.8171249704826726d, c: 0.6630402846087771d),

new NpgsqlTypes.NpgsqlLine(a: 0.029797932518596304d, b: 0.46772715591585123d, c: 0.3192209453517727d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06241654155437726d, b: 0.9624340482221347d, c: 0.9199926106867086d),

new NpgsqlTypes.NpgsqlLine(a: 0.6740997061036881d, b: 0.7118972527514477d, c: 0.21236569389377902d),

new NpgsqlTypes.NpgsqlLine(a: 0.577362479353685d, b: 0.19107840870926307d, c: 0.2338538856920146d),

new NpgsqlTypes.NpgsqlLine(a: 0.16597446904937208d, b: 0.9960586434572618d, c: 0.09200098597683037d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08633043221002024d, b: 0.6806693620811346d, c: 0.15732546599274866d),

new NpgsqlTypes.NpgsqlLine(a: 0.07681081255545075d, b: 0.2344558737245801d, c: 0.7587967576416341d),

new NpgsqlTypes.NpgsqlLine(a: 0.17452247909247853d, b: 0.8979815036661422d, c: 0.8170842812979477d),

new NpgsqlTypes.NpgsqlLine(a: 0.8947387457123595d, b: 0.4326565183767481d, c: 0.634095929723904d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06680025064909845d, b: 0.06667621937282919d, c: 0.8826920895369073d),

new NpgsqlTypes.NpgsqlLine(a: 0.41203798873272335d, b: 0.794537203310671d, c: 0.44147894600145254d),

new NpgsqlTypes.NpgsqlLine(a: 0.7001555348923635d, b: 0.23925013318739896d, c: 0.4201633319909751d),

new NpgsqlTypes.NpgsqlLine(a: 0.09046122630799747d, b: 0.5869885567211329d, c: 0.6727752203156709d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3549313854362043d, b: 0.2420247116920372d, c: 0.9805689116721181d),

new NpgsqlTypes.NpgsqlLine(a: 0.04320736183552809d, b: 0.8646613667939713d, c: 0.475560661391498d),

new NpgsqlTypes.NpgsqlLine(a: 0.024946032810281182d, b: 0.23184870629616205d, c: 0.03521153426564516d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4945424349954126d, b: 0.3588395776886385d, c: 0.2228608873509348d),

new NpgsqlTypes.NpgsqlLine(a: 0.09377675524657247d, b: 0.8099887764910676d, c: 0.12778026742169224d),

new NpgsqlTypes.NpgsqlLine(a: 0.9562116866205628d, b: 0.5396935985222625d, c: 0.9518045905516317d),

new NpgsqlTypes.NpgsqlLine(a: 0.8719055971267617d, b: 0.5555354932614155d, c: 0.6475168186066406d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4714471881338015d, b: 0.04437922263206118d, c: 0.05192764479274281d),

new NpgsqlTypes.NpgsqlLine(a: 0.30719060704718837d, b: 0.016759366325400538d, c: 0.7229940078968512d),

new NpgsqlTypes.NpgsqlLine(a: 0.12371308305303652d, b: 0.31757732096914515d, c: 0.47909184920304215d),

new NpgsqlTypes.NpgsqlLine(a: 0.2552854976813189d, b: 0.778844239373431d, c: 0.09091427468470203d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7308607821349379d, b: 0.7414685780863105d, c: 0.9606252025260631d),

new NpgsqlTypes.NpgsqlLine(a: 0.9265276768146771d, b: 0.8654163607084939d, c: 0.5828685028304088d),

new NpgsqlTypes.NpgsqlLine(a: 0.7855627390551264d, b: 0.5517197352391149d, c: 0.8265459926478574d),

new NpgsqlTypes.NpgsqlLine(a: 0.24380989182375157d, b: 0.3938195525104511d, c: 0.8991861660271121d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1171143236026273d, b: 0.5072533401229139d, c: 0.9957527623167622d),

new NpgsqlTypes.NpgsqlLine(a: 0.13624396643172398d, b: 0.3779869341435588d, c: 0.5920311725976328d),

new NpgsqlTypes.NpgsqlLine(a: 0.9732157994693609d, b: 0.08338409957509019d, c: 0.2129626294502629d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31766746437306326d, b: 0.4801661928015729d, c: 0.16348195967192747d),

new NpgsqlTypes.NpgsqlLine(a: 0.04335978851332567d, b: 0.6541960384168889d, c: 0.7586073170155357d),

new NpgsqlTypes.NpgsqlLine(a: 0.15975574779183943d, b: 0.11171670133367873d, c: 0.9693853297605245d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10085482417985725d, b: 0.22613673922560473d, c: 0.7285302320418457d),

new NpgsqlTypes.NpgsqlLine(a: 0.9944748439097059d, b: 0.4620241978165991d, c: 0.6476981607217002d),

new NpgsqlTypes.NpgsqlLine(a: 0.016546619053393052d, b: 0.367000694789834d, c: 0.6934991924315071d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17382658703030507d, b: 0.9157655523332436d, c: 0.6130321759512012d),

new NpgsqlTypes.NpgsqlLine(a: 0.5843845477861629d, b: 0.9786081107118698d, c: 0.15525807318068763d),

new NpgsqlTypes.NpgsqlLine(a: 0.4998457744408248d, b: 0.4700233476615624d, c: 0.19175786151313978d),

new NpgsqlTypes.NpgsqlLine(a: 0.4711982542243529d, b: 0.29818042632913533d, c: 0.3251329784218462d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5803460277989446d, b: 0.7317476783257564d, c: 0.05199742305305455d),

new NpgsqlTypes.NpgsqlLine(a: 0.6981594264679458d, b: 0.5303371639171501d, c: 0.30388490221443254d),

new NpgsqlTypes.NpgsqlLine(a: 0.34968555843494875d, b: 0.07897962998111163d, c: 0.43472104818890267d),

new NpgsqlTypes.NpgsqlLine(a: 0.3040429240672641d, b: 0.25214399454987324d, c: 0.4261115812727789d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8859064010944829d, b: 0.9265066920991876d, c: 0.5115041694954586d),

new NpgsqlTypes.NpgsqlLine(a: 0.7314127994746428d, b: 0.08051026884201351d, c: 0.4374200165950639d),

new NpgsqlTypes.NpgsqlLine(a: 0.23273313426483433d, b: 0.3524521805384958d, c: 0.9873565817361223d),

new NpgsqlTypes.NpgsqlLine(a: 0.5077209833445051d, b: 0.7876080715906121d, c: 0.8424974161646112d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4023604265783143d, b: 0.02844441405486786d, c: 0.8111903565219947d),

new NpgsqlTypes.NpgsqlLine(a: 0.9321559222118796d, b: 0.8663139990697897d, c: 0.544475654324445d),

new NpgsqlTypes.NpgsqlLine(a: 0.47924823413826356d, b: 0.6225672513855874d, c: 0.7600589571516484d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7617268280207117d, b: 0.010628479580997885d, c: 0.9612914441623605d),

new NpgsqlTypes.NpgsqlLine(a: 0.774417697745578d, b: 0.10950387926941474d, c: 0.5497786578280308d),

new NpgsqlTypes.NpgsqlLine(a: 0.3737825014740034d, b: 0.9665316747728401d, c: 0.06513705088067123d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6170255095989335d, b: 0.8416958859957152d, c: 0.038247950776271966d),

new NpgsqlTypes.NpgsqlLine(a: 0.7633125883813612d, b: 0.6407726459369609d, c: 0.17517191708463464d),

new NpgsqlTypes.NpgsqlLine(a: 0.42259799075961013d, b: 0.24843053373219348d, c: 0.4004897648182979d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5897680822022865d, b: 0.13995963119468935d, c: 0.30582689245536276d),

new NpgsqlTypes.NpgsqlLine(a: 0.2666979669840064d, b: 0.727347326206714d, c: 0.7567702088778794d),

new NpgsqlTypes.NpgsqlLine(a: 0.4047989699869248d, b: 0.8806725148489073d, c: 0.47670295460397905d),

new NpgsqlTypes.NpgsqlLine(a: 0.8001125343028905d, b: 0.9403990041380175d, c: 0.9876677150819835d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.845195969292075d, b: 0.5094851019288297d, c: 0.4919243883538409d),

new NpgsqlTypes.NpgsqlLine(a: 0.10142219666204955d, b: 0.30824550935520256d, c: 0.12797229172479985d),

new NpgsqlTypes.NpgsqlLine(a: 0.7244939868147725d, b: 0.039122333738848214d, c: 0.9105734689375385d),

new NpgsqlTypes.NpgsqlLine(a: 0.33660606273533333d, b: 0.7111580372859804d, c: 0.08008729155984051d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3451532052059132d, b: 0.06514242786036106d, c: 0.7242676854848653d),

new NpgsqlTypes.NpgsqlLine(a: 0.45293009996582567d, b: 0.1459023673125286d, c: 0.7593729880381536d),

new NpgsqlTypes.NpgsqlLine(a: 0.9461706827102977d, b: 0.9617625331725659d, c: 0.8983599848818234d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07959414360551365d, b: 0.5483962234178296d, c: 0.5913373984346995d),

new NpgsqlTypes.NpgsqlLine(a: 0.382675393667262d, b: 0.7967854961966243d, c: 0.809888955844571d),

new NpgsqlTypes.NpgsqlLine(a: 0.040403737353110314d, b: 0.8983373881794745d, c: 0.6255888912519416d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5097947217756142d, b: 0.5907837622440155d, c: 0.7545452005909322d),

new NpgsqlTypes.NpgsqlLine(a: 0.42035242577677145d, b: 0.8885608927094802d, c: 0.3167923847992312d),

new NpgsqlTypes.NpgsqlLine(a: 0.647372817127511d, b: 0.9872780761687884d, c: 0.8816264379040775d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9245435421381817d, b: 0.41903166626968125d, c: 0.018733819290964182d),

new NpgsqlTypes.NpgsqlLine(a: 0.7241087811856309d, b: 0.7742565265751097d, c: 0.7474082961114032d),

new NpgsqlTypes.NpgsqlLine(a: 0.9203573622198015d, b: 0.8972515974040445d, c: 0.5521476013101672d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7597907823696262d, b: 0.33526848523263775d, c: 0.2713685034248883d),

new NpgsqlTypes.NpgsqlLine(a: 0.315836697270071d, b: 0.5393698587823683d, c: 0.3547690529950297d),

new NpgsqlTypes.NpgsqlLine(a: 0.2177531659849461d, b: 0.17556360190299292d, c: 0.1081927083240184d),

new NpgsqlTypes.NpgsqlLine(a: 0.4347048434101376d, b: 0.7760338065686507d, c: 0.61461079970489d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36136703660417047d, b: 0.756327787756806d, c: 0.18608229992229863d),

new NpgsqlTypes.NpgsqlLine(a: 0.5333577639770947d, b: 0.5273009488173084d, c: 0.7468813994235116d),

new NpgsqlTypes.NpgsqlLine(a: 0.46202504108692466d, b: 0.7592909603603462d, c: 0.793172068388345d),

new NpgsqlTypes.NpgsqlLine(a: 0.6468388073916199d, b: 0.9098787596146114d, c: 0.2797180453440591d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15718115670110144d, b: 0.7799676282499408d, c: 0.4867105780545077d),

new NpgsqlTypes.NpgsqlLine(a: 0.458842272224139d, b: 0.8452285766910539d, c: 0.05565473722759484d),

new NpgsqlTypes.NpgsqlLine(a: 0.7785567817284703d, b: 0.6985487187142803d, c: 0.5890020720124849d),

new NpgsqlTypes.NpgsqlLine(a: 0.4564549734365235d, b: 0.027912037213151608d, c: 0.5106651339717089d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14704568838127108d, b: 0.4732944963123893d, c: 0.005119067143951717d),

new NpgsqlTypes.NpgsqlLine(a: 0.6020869370252087d, b: 0.33430441250033005d, c: 0.481396477132623d),

new NpgsqlTypes.NpgsqlLine(a: 0.3970321902636966d, b: 0.06807217078656302d, c: 0.24501373819041783d),

new NpgsqlTypes.NpgsqlLine(a: 0.2963152213651301d, b: 0.8403992515197389d, c: 0.8340582303429138d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6653564259493644d, b: 0.08455144634148593d, c: 0.33934871722567206d),

new NpgsqlTypes.NpgsqlLine(a: 0.2546038229560691d, b: 0.25378644654529925d, c: 0.434654023496019d),

new NpgsqlTypes.NpgsqlLine(a: 0.234846725223254d, b: 0.19692405642757915d, c: 0.11826224221047377d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7588204088489039d, b: 0.1356345696589477d, c: 0.009822169359748112d),

new NpgsqlTypes.NpgsqlLine(a: 0.8418505996794633d, b: 0.47189408091748364d, c: 0.6862737700330555d),

new NpgsqlTypes.NpgsqlLine(a: 0.20525849659358808d, b: 0.7766187524849244d, c: 0.45056417551018935d),

new NpgsqlTypes.NpgsqlLine(a: 0.48309664490214543d, b: 0.75321710499735d, c: 0.7064315694181417d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7702520358217008d, b: 0.5052920143861102d, c: 0.3715477563195664d),

new NpgsqlTypes.NpgsqlLine(a: 0.47541489559804095d, b: 0.7250226554190281d, c: 0.44668372152537317d),

new NpgsqlTypes.NpgsqlLine(a: 0.3022228655008822d, b: 0.7451918692217555d, c: 0.03411193260051537d),

new NpgsqlTypes.NpgsqlLine(a: 0.8671804046558668d, b: 0.5551336220866695d, c: 0.306317605690157d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48838923298687587d, b: 0.5510729791195266d, c: 0.7557650123077407d),

new NpgsqlTypes.NpgsqlLine(a: 0.7359643877238136d, b: 0.11806200135840894d, c: 0.18736116012065673d),

new NpgsqlTypes.NpgsqlLine(a: 0.38653702900775855d, b: 0.8113985192494209d, c: 0.38229058147197215d),

new NpgsqlTypes.NpgsqlLine(a: 0.8873664885254103d, b: 0.3817536591115833d, c: 0.7930103354976498d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3760421484642713d, b: 0.48394606314292576d, c: 0.8518524938108132d),

new NpgsqlTypes.NpgsqlLine(a: 0.989375910176267d, b: 0.6028583694318944d, c: 0.09271230304914779d),

new NpgsqlTypes.NpgsqlLine(a: 0.8529826570017119d, b: 0.6296514940738153d, c: 0.7608210195042032d),

new NpgsqlTypes.NpgsqlLine(a: 0.24800839850822676d, b: 0.8696846011951219d, c: 0.7840462277858744d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4480016761732061d, b: 0.2728621238495461d, c: 0.7024438357774886d),

new NpgsqlTypes.NpgsqlLine(a: 0.7465490074032405d, b: 0.6733761518033425d, c: 0.1741933407501488d),

new NpgsqlTypes.NpgsqlLine(a: 0.16606407483012187d, b: 0.8945117501373772d, c: 0.8020647488908995d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9520535060159633d, b: 0.715067277861769d, c: 0.8148343129892818d),

new NpgsqlTypes.NpgsqlLine(a: 0.858443854923401d, b: 0.8729702494425833d, c: 0.8978322322850906d),

new NpgsqlTypes.NpgsqlLine(a: 0.28949611858305135d, b: 0.7050314903181788d, c: 0.6816969522609253d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1091113341952551d, b: 0.8641709727401067d, c: 0.7767967055767308d),

new NpgsqlTypes.NpgsqlLine(a: 0.6607318895635239d, b: 0.9630228546048023d, c: 0.37439164694732163d),

new NpgsqlTypes.NpgsqlLine(a: 0.28195843937043463d, b: 0.013664120564193083d, c: 0.2609675650697474d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23139083437942476d, b: 0.9487085992549862d, c: 0.8094725907654141d),

new NpgsqlTypes.NpgsqlLine(a: 0.9617860920530662d, b: 0.0674190594702413d, c: 0.03290176784235721d),

new NpgsqlTypes.NpgsqlLine(a: 0.7998013684362298d, b: 0.9489110270220574d, c: 0.8725506688476209d),

new NpgsqlTypes.NpgsqlLine(a: 0.053744548873607356d, b: 0.08455742455426618d, c: 0.8189191908846813d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8567135998770995d, b: 0.9016598333759506d, c: 0.13564012465917796d),

new NpgsqlTypes.NpgsqlLine(a: 0.09611865082842708d, b: 0.8281952989346804d, c: 0.015362092409779926d),

new NpgsqlTypes.NpgsqlLine(a: 0.9775991325423887d, b: 0.3576966719522925d, c: 0.85804166130511d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6634557047197952d, b: 0.6271715366006608d, c: 0.6681881366856367d),

new NpgsqlTypes.NpgsqlLine(a: 0.5853686066086361d, b: 0.09251206811891155d, c: 0.378234267564567d),

new NpgsqlTypes.NpgsqlLine(a: 0.2841054905486956d, b: 0.08664299578253853d, c: 0.6664758168081737d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9566168786948134d, b: 0.4754129648221672d, c: 0.9165709661054536d),

new NpgsqlTypes.NpgsqlLine(a: 0.906486559241483d, b: 0.14946933330352685d, c: 0.019185163471541755d),

new NpgsqlTypes.NpgsqlLine(a: 0.021413432262195387d, b: 0.9917968341633367d, c: 0.8252529486410546d),

new NpgsqlTypes.NpgsqlLine(a: 0.4955613585371226d, b: 0.9290514348411654d, c: 0.30456092517574307d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8951714511667546d, b: 0.9107904788351705d, c: 0.2154319658449999d),

new NpgsqlTypes.NpgsqlLine(a: 0.5977228290711013d, b: 0.8189704413736241d, c: 0.5938657744145542d),

new NpgsqlTypes.NpgsqlLine(a: 0.5123105582611462d, b: 0.04812982822970724d, c: 0.3479400998971537d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24631647947046265d, b: 0.032342898476501514d, c: 0.443912103092434d),

new NpgsqlTypes.NpgsqlLine(a: 0.6036264176341929d, b: 0.24146232297537185d, c: 0.7714367517441294d),

new NpgsqlTypes.NpgsqlLine(a: 0.933289272780934d, b: 0.4145322861619112d, c: 0.043343466407805065d),

new NpgsqlTypes.NpgsqlLine(a: 0.6866510003309176d, b: 0.06646662429908401d, c: 0.4103711495957383d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.34260425154406704d, b: 0.775989933567389d, c: 0.855177231843872d),

new NpgsqlTypes.NpgsqlLine(a: 0.4993900143369082d, b: 0.11941894454781266d, c: 0.6441520401415662d),

new NpgsqlTypes.NpgsqlLine(a: 0.11587853045225716d, b: 0.14371001754667379d, c: 0.239086082760274d),

new NpgsqlTypes.NpgsqlLine(a: 0.18127116695425038d, b: 0.5548095819477988d, c: 0.36721738619174427d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.788406987676372d, b: 0.1862406945919699d, c: 0.8413202347114713d),

new NpgsqlTypes.NpgsqlLine(a: 0.27068192966524407d, b: 0.46499645364908304d, c: 0.4854819101207347d),

new NpgsqlTypes.NpgsqlLine(a: 0.006738090680653452d, b: 0.682751936637267d, c: 0.5938145210565655d),

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
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
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[30], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 4;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[30], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[30], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 25, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[30], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 107, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 32, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[30], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 83, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 5, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 4, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[30], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 26, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 32, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[30], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 33, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 107, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2M>(15);

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
                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

