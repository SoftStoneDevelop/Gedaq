

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19920879568941785d, b: 0.40577529600022977d, c: 0.20722265407979645d),
new NpgsqlTypes.NpgsqlLine(a: 0.31678026919419533d, b: 0.8455342803396366d, c: 0.12422138745907996d),
new NpgsqlTypes.NpgsqlLine(a: 0.04750863721801368d, b: 0.22433190172246342d, c: 0.8795355076650744d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28470889065027416d, b: 0.882944664523063d, c: 0.8059067205143042d),
new NpgsqlTypes.NpgsqlLine(a: 0.8270107501454537d, b: 0.9882836477900835d, c: 0.8126458303348073d),
new NpgsqlTypes.NpgsqlLine(a: 0.8315447766070198d, b: 0.37564595468386186d, c: 0.5998863995513309d),
new NpgsqlTypes.NpgsqlLine(a: 0.05701094303624055d, b: 0.2712799497302999d, c: 0.1985874724345369d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10690124805950563d, b: 0.7384604368698235d, c: 0.7042518612590741d),
new NpgsqlTypes.NpgsqlLine(a: 0.10459553263332733d, b: 0.07751683443670243d, c: 0.5327147388903545d),
new NpgsqlTypes.NpgsqlLine(a: 0.7511834667736901d, b: 0.7650276790255649d, c: 0.24840899613404022d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12059717608945386d, b: 0.7117360139743004d, c: 0.7879687941183562d),
new NpgsqlTypes.NpgsqlLine(a: 0.4004580881745703d, b: 0.09581866609873613d, c: 0.3890897970954982d),
new NpgsqlTypes.NpgsqlLine(a: 0.5861220640727461d, b: 0.41669504606947494d, c: 0.5455362295678667d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08556744150167195d, b: 0.06297757358672751d, c: 0.7848194839675138d),
new NpgsqlTypes.NpgsqlLine(a: 0.09265563153699641d, b: 0.04907806138067827d, c: 0.31699351886150595d),
new NpgsqlTypes.NpgsqlLine(a: 0.6327533019468806d, b: 0.505705124417659d, c: 0.1088165239692227d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5818958672273428d, b: 0.9962294623544993d, c: 0.07915833479226853d),
new NpgsqlTypes.NpgsqlLine(a: 0.20752067257591988d, b: 0.049482129029119415d, c: 0.20324213779536704d),
new NpgsqlTypes.NpgsqlLine(a: 0.5063299691221972d, b: 0.3584545824443255d, c: 0.40982050814439297d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.42619492196840236d, b: 0.38887332085182436d, c: 0.10110927496469435d),
new NpgsqlTypes.NpgsqlLine(a: 0.1537964514855662d, b: 0.21154174520926738d, c: 0.11607781897198066d),
new NpgsqlTypes.NpgsqlLine(a: 0.39405534585926194d, b: 0.5969437889410818d, c: 0.9802772781788613d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1778492185657844d, b: 0.11758018370398127d, c: 0.5839367451147338d),
new NpgsqlTypes.NpgsqlLine(a: 0.5241143319999815d, b: 0.323172941758023d, c: 0.33413600778543506d),
new NpgsqlTypes.NpgsqlLine(a: 0.02044630290205951d, b: 0.6426026345470884d, c: 0.7785296544345155d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7878504644228743d, b: 0.6062116331318081d, c: 0.7296922076816427d),
new NpgsqlTypes.NpgsqlLine(a: 0.3705417749428872d, b: 0.6112347413330291d, c: 0.8697545611336346d),
new NpgsqlTypes.NpgsqlLine(a: 0.6732871153597282d, b: 0.6566414766667227d, c: 0.04789163737391511d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7637739088040486d, b: 0.4058544942792529d, c: 0.10031044865748517d),
new NpgsqlTypes.NpgsqlLine(a: 0.7268399205221405d, b: 0.8683463063213505d, c: 0.3476658496759647d),
new NpgsqlTypes.NpgsqlLine(a: 0.6286187529278023d, b: 0.1160804804191754d, c: 0.2585985045248982d),
new NpgsqlTypes.NpgsqlLine(a: 0.48115170399630336d, b: 0.8719253172799671d, c: 0.11814975026484897d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7961119689722047d, b: 0.09902871543369662d, c: 0.9743125761863219d),
new NpgsqlTypes.NpgsqlLine(a: 0.8247170671591564d, b: 0.8073255622638256d, c: 0.8529580424556827d),
new NpgsqlTypes.NpgsqlLine(a: 0.08514552748744997d, b: 0.29556863709384384d, c: 0.06979744463187909d),
new NpgsqlTypes.NpgsqlLine(a: 0.8956443078606594d, b: 0.28668691827302095d, c: 0.1309115363048463d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7891091805875513d, b: 0.6957003163660281d, c: 0.08182749423269453d),
new NpgsqlTypes.NpgsqlLine(a: 0.9007657586830584d, b: 0.9525045675555808d, c: 0.9027829910024794d),
new NpgsqlTypes.NpgsqlLine(a: 0.4844283946428535d, b: 0.5411951038130054d, c: 0.9451510877194329d),
new NpgsqlTypes.NpgsqlLine(a: 0.6970357179018143d, b: 0.5768873234541247d, c: 0.6789841270131088d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7772191042951547d, b: 0.9554999484185562d, c: 0.20717190847500544d),
new NpgsqlTypes.NpgsqlLine(a: 0.10036295782612425d, b: 0.2887355250548901d, c: 0.3093329080556506d),
new NpgsqlTypes.NpgsqlLine(a: 0.44475752422465054d, b: 0.08252851758853319d, c: 0.3285347519421239d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.26340856366208976d, b: 0.4583589392626003d, c: 0.10144256902686088d),
new NpgsqlTypes.NpgsqlLine(a: 0.7186768904482687d, b: 0.6540414876120557d, c: 0.8869707609433263d),
new NpgsqlTypes.NpgsqlLine(a: 0.28696493371254983d, b: 0.2992349918099536d, c: 0.1334520500602041d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29539891522527495d, b: 0.972209731335595d, c: 0.9487954360703914d),
new NpgsqlTypes.NpgsqlLine(a: 0.48453230566338445d, b: 0.23345166071933476d, c: 0.6978156945383678d),
new NpgsqlTypes.NpgsqlLine(a: 0.8334207455338181d, b: 0.9530757650819907d, c: 0.627133735592103d),
new NpgsqlTypes.NpgsqlLine(a: 0.9490858989576662d, b: 0.917903801057947d, c: 0.7385908412231402d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2806234265353026d, b: 0.06484193167200225d, c: 0.9383213127620709d),
new NpgsqlTypes.NpgsqlLine(a: 0.9413798546901825d, b: 0.2738779226143908d, c: 0.20436183331572555d),
new NpgsqlTypes.NpgsqlLine(a: 0.8901036054726154d, b: 0.5901638857562831d, c: 0.05933456628439604d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22705649820244167d, b: 0.7117238944551219d, c: 0.11197722823298639d),
new NpgsqlTypes.NpgsqlLine(a: 0.9943630455394611d, b: 0.7268381178120166d, c: 0.48315126181824053d),
new NpgsqlTypes.NpgsqlLine(a: 0.45309061193779554d, b: 0.7448032571665462d, c: 0.5436838717770048d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8950355142597296d, b: 0.7933974281432604d, c: 0.42062891910412725d),
new NpgsqlTypes.NpgsqlLine(a: 0.4679660542962736d, b: 0.6190761712963575d, c: 0.5416761752329537d),
new NpgsqlTypes.NpgsqlLine(a: 0.1241510066559266d, b: 0.347540691736982d, c: 0.5733384597979023d),
new NpgsqlTypes.NpgsqlLine(a: 0.8548334800527626d, b: 0.4370648037452798d, c: 0.1533018904668526d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2627540668415742d, b: 0.6911585299549817d, c: 0.15950445369992028d),
new NpgsqlTypes.NpgsqlLine(a: 0.012944185847669099d, b: 0.1726624912673268d, c: 0.4933634537711965d),
new NpgsqlTypes.NpgsqlLine(a: 0.5464521588858077d, b: 0.6668014709396117d, c: 0.6843557668329437d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.36793510066382307d, b: 0.31172893116801004d, c: 0.255134181914211d),
new NpgsqlTypes.NpgsqlLine(a: 0.050385353013788214d, b: 0.627751772553029d, c: 0.24507748416086717d),
new NpgsqlTypes.NpgsqlLine(a: 0.5659080446955258d, b: 0.21781026761328415d, c: 0.010650535125033112d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7642570878244634d, b: 0.7046821645043249d, c: 0.028127840768942258d),
new NpgsqlTypes.NpgsqlLine(a: 0.8469685938420837d, b: 0.5129664426670065d, c: 0.3192617485146575d),
new NpgsqlTypes.NpgsqlLine(a: 0.11897297580565003d, b: 0.427887222721948d, c: 0.07939883225104549d),
new NpgsqlTypes.NpgsqlLine(a: 0.12513032819714265d, b: 0.18590314262566288d, c: 0.9023796025495772d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15601213011428905d, b: 0.7110526158243793d, c: 0.27503836222127553d),
new NpgsqlTypes.NpgsqlLine(a: 0.5242129888552237d, b: 0.5947634122929722d, c: 0.8450433354192832d),
new NpgsqlTypes.NpgsqlLine(a: 0.2762366582467737d, b: 0.6293036874736556d, c: 0.8143303907224987d),
new NpgsqlTypes.NpgsqlLine(a: 0.35210681729099647d, b: 0.33116883815044285d, c: 0.4142005184796421d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7409680316884601d, b: 0.9416602682729638d, c: 0.5292995959829695d),
new NpgsqlTypes.NpgsqlLine(a: 0.46924409465940586d, b: 0.2760633897195913d, c: 0.829009362340261d),
new NpgsqlTypes.NpgsqlLine(a: 0.40238987428985606d, b: 0.9920261154690432d, c: 0.8631440717122525d),
new NpgsqlTypes.NpgsqlLine(a: 0.3590278931893761d, b: 0.8306540479431245d, c: 0.9737923401751816d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48549865389532054d, b: 0.832576016915673d, c: 0.23751837037265322d),
new NpgsqlTypes.NpgsqlLine(a: 0.7077214040317286d, b: 0.41289255502001565d, c: 0.5694629808102359d),
new NpgsqlTypes.NpgsqlLine(a: 0.24608314212855564d, b: 0.2140298180131195d, c: 0.9210053758425303d),
new NpgsqlTypes.NpgsqlLine(a: 0.5936706995285634d, b: 0.8353431093920393d, c: 0.6378326957168788d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5106103552350425d, b: 0.7755056552847625d, c: 0.17191275715932552d),
new NpgsqlTypes.NpgsqlLine(a: 0.0476015477806353d, b: 0.41475329084716883d, c: 0.8832819833937197d),
new NpgsqlTypes.NpgsqlLine(a: 0.06674923975884217d, b: 0.6940614759013696d, c: 0.39490408316773074d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8085849155439867d, b: 0.05542850535727539d, c: 0.19641988944254674d),
new NpgsqlTypes.NpgsqlLine(a: 0.7222988140489758d, b: 0.2763719229547784d, c: 0.2810954416347792d),
new NpgsqlTypes.NpgsqlLine(a: 0.16751833814307415d, b: 0.44125767950622197d, c: 0.09629730905941347d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4804170328526628d, b: 0.47094600845905865d, c: 0.46121910063557914d),
new NpgsqlTypes.NpgsqlLine(a: 0.047680739209772116d, b: 0.5738033981661079d, c: 0.8785571663103623d),
new NpgsqlTypes.NpgsqlLine(a: 0.9295677839358719d, b: 0.04102475952121265d, c: 0.02971657922460036d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.535103102311382d, b: 0.3370988489102177d, c: 0.9417732479955164d),
new NpgsqlTypes.NpgsqlLine(a: 0.6329517164315771d, b: 0.23979549507963538d, c: 0.8360471825420509d),
new NpgsqlTypes.NpgsqlLine(a: 0.07703070084120112d, b: 0.4566117490431255d, c: 0.6206247582524703d),
new NpgsqlTypes.NpgsqlLine(a: 0.5578783361701752d, b: 0.57769151142618d, c: 0.7710384521724918d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01228621626304971d, b: 0.12058117507379629d, c: 0.37273791654767263d),
new NpgsqlTypes.NpgsqlLine(a: 0.04609453505590766d, b: 0.9722528645866382d, c: 0.08462361542034402d),
new NpgsqlTypes.NpgsqlLine(a: 0.9236119299910379d, b: 0.719848511573594d, c: 0.3329367115917362d),
new NpgsqlTypes.NpgsqlLine(a: 0.12810577544173007d, b: 0.39594138506654786d, c: 0.881520016003992d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8154548710893419d, b: 0.7966684555019933d, c: 0.03207269336453811d),
new NpgsqlTypes.NpgsqlLine(a: 0.044373775161894446d, b: 0.7033746283462239d, c: 0.9927232011309528d),
new NpgsqlTypes.NpgsqlLine(a: 0.5915768866206009d, b: 0.27123209443745144d, c: 0.534057509238089d),
new NpgsqlTypes.NpgsqlLine(a: 0.5100849668024218d, b: 0.9086312382550349d, c: 0.9131716323032131d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8043858658325875d, b: 0.9167618772346352d, c: 0.7571415630829768d),
new NpgsqlTypes.NpgsqlLine(a: 0.7183039480069507d, b: 0.5916289710427839d, c: 0.19178136832213843d),
new NpgsqlTypes.NpgsqlLine(a: 0.9535756301570218d, b: 0.928699534519572d, c: 0.43084378245476773d),
new NpgsqlTypes.NpgsqlLine(a: 0.5769531939598345d, b: 0.9382951079456872d, c: 0.5287086268023169d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20341707810128862d, b: 0.6140716845210656d, c: 0.6570013799073108d),
new NpgsqlTypes.NpgsqlLine(a: 0.37892331792848843d, b: 0.052246732926604866d, c: 0.5188189508124181d),
new NpgsqlTypes.NpgsqlLine(a: 0.2041667018827843d, b: 0.23680479175275881d, c: 0.18177797213796731d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7128521556611337d, b: 0.9992469239116761d, c: 0.9978603384093581d),
new NpgsqlTypes.NpgsqlLine(a: 0.10076286393505862d, b: 0.7882238763129167d, c: 0.5000600784722528d),
new NpgsqlTypes.NpgsqlLine(a: 0.8414601293368495d, b: 0.21011042118256595d, c: 0.8871105853698807d),
new NpgsqlTypes.NpgsqlLine(a: 0.46684398301151053d, b: 0.13502535289066186d, c: 0.6352253316160426d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05451298159237894d, b: 0.29181332503518986d, c: 0.4303794031822302d),
new NpgsqlTypes.NpgsqlLine(a: 0.6081007389980402d, b: 0.9827836573634476d, c: 0.1425167838832334d),
new NpgsqlTypes.NpgsqlLine(a: 0.6457990662889054d, b: 0.30925279183777254d, c: 0.18321975694355852d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10872329500794342d, b: 0.3936678307639646d, c: 0.1334218811255532d),
new NpgsqlTypes.NpgsqlLine(a: 0.11680394256080062d, b: 0.9293381156950326d, c: 0.46228611012314524d),
new NpgsqlTypes.NpgsqlLine(a: 0.6679241182068555d, b: 0.3791066642681358d, c: 0.14603270012122582d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8046002445504298d, b: 0.9443636897796015d, c: 0.5730603934856527d),
new NpgsqlTypes.NpgsqlLine(a: 0.7855069144242144d, b: 0.16212082015816764d, c: 0.3032735002465249d),
new NpgsqlTypes.NpgsqlLine(a: 0.19263832421940752d, b: 0.04713995374694735d, c: 0.730753525926318d),
new NpgsqlTypes.NpgsqlLine(a: 0.19567035411998424d, b: 0.21104537258607725d, c: 0.534406769622169d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7152237428006083d, b: 0.008120027531330787d, c: 0.8086467052309135d),
new NpgsqlTypes.NpgsqlLine(a: 0.1782425967431429d, b: 0.2001853464584875d, c: 0.9478301537037375d),
new NpgsqlTypes.NpgsqlLine(a: 0.5383158376589394d, b: 0.8593414312270257d, c: 0.7300875071920064d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.44100439460757823d, b: 0.8377137853646843d, c: 0.317432687723435d),
new NpgsqlTypes.NpgsqlLine(a: 0.14587152327372999d, b: 0.4832338941239769d, c: 0.42282654159769584d),
new NpgsqlTypes.NpgsqlLine(a: 0.4429249570274154d, b: 0.5864504994198793d, c: 0.9089626067455903d),
new NpgsqlTypes.NpgsqlLine(a: 0.4973134843595901d, b: 0.9159356831303046d, c: 0.01156782011529589d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4335667005607218d, b: 0.9712034539100617d, c: 0.6322595809016466d),
new NpgsqlTypes.NpgsqlLine(a: 0.6281622578849901d, b: 0.1967238323282109d, c: 0.6090227507959841d),
new NpgsqlTypes.NpgsqlLine(a: 0.8150646457864517d, b: 0.9505214270637948d, c: 0.6915395666835442d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8007194421836352d, b: 0.9285178639324422d, c: 0.14625060217381491d),
new NpgsqlTypes.NpgsqlLine(a: 0.8944829514860914d, b: 0.8097403964655471d, c: 0.21807045181589846d),
new NpgsqlTypes.NpgsqlLine(a: 0.5722764096981529d, b: 0.6315986260737787d, c: 0.2641959277087206d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07624900490030861d, b: 0.08938038355310862d, c: 0.2193600931089511d),
new NpgsqlTypes.NpgsqlLine(a: 0.6342387698483797d, b: 0.5579886864233432d, c: 0.08326180344660583d),
new NpgsqlTypes.NpgsqlLine(a: 0.0372775605152702d, b: 0.3150969337494266d, c: 0.3865506884175607d),
new NpgsqlTypes.NpgsqlLine(a: 0.7607738339265607d, b: 0.04316518364432731d, c: 0.9267970767999625d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6884319958981687d, b: 0.1786125893851941d, c: 0.3753593843073795d),
new NpgsqlTypes.NpgsqlLine(a: 0.028403991132736506d, b: 0.08279690235498338d, c: 0.10735973395058906d),
new NpgsqlTypes.NpgsqlLine(a: 0.7096216431097081d, b: 0.5896157009586942d, c: 0.7200338714560748d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4273547031875412d, b: 0.5359976698770658d, c: 0.6298780628681594d),
new NpgsqlTypes.NpgsqlLine(a: 0.28033645969481025d, b: 0.7397857970306606d, c: 0.730253287587789d),
new NpgsqlTypes.NpgsqlLine(a: 0.39655032840849525d, b: 0.6822789494378182d, c: 0.6629605556395557d),
new NpgsqlTypes.NpgsqlLine(a: 0.8578002553595354d, b: 0.7321616380911414d, c: 0.5094609220814988d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23490887719050824d, b: 0.6134360356367575d, c: 0.08596789457818244d),
new NpgsqlTypes.NpgsqlLine(a: 0.3657429275201537d, b: 0.30759279759305524d, c: 0.3200963880814317d),
new NpgsqlTypes.NpgsqlLine(a: 0.9755343570098621d, b: 0.005595833412903151d, c: 0.3738952242472068d),
new NpgsqlTypes.NpgsqlLine(a: 0.23700111567829352d, b: 0.03084659826949787d, c: 0.7966708188228597d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6509772920898386d, b: 0.9323770722500699d, c: 0.5675437963763833d),
new NpgsqlTypes.NpgsqlLine(a: 0.4303088992608681d, b: 0.44956711980787734d, c: 0.6362528816167997d),
new NpgsqlTypes.NpgsqlLine(a: 0.5014789977692835d, b: 0.6798074930219379d, c: 0.5203827262309352d),
new NpgsqlTypes.NpgsqlLine(a: 0.8658792919517466d, b: 0.5520905452142174d, c: 0.614113495240114d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16006177687504242d, b: 0.06647030729361414d, c: 0.657358125840853d),
new NpgsqlTypes.NpgsqlLine(a: 0.8658478418942933d, b: 0.4495682825294306d, c: 0.22620546628524507d),
new NpgsqlTypes.NpgsqlLine(a: 0.7190452498150534d, b: 0.46497846306197654d, c: 0.5480649033954695d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7070772469490478d, b: 0.8970546122026647d, c: 0.4558456740799224d),
new NpgsqlTypes.NpgsqlLine(a: 0.7517150785664596d, b: 0.9782349507170535d, c: 0.9644338000549383d),
new NpgsqlTypes.NpgsqlLine(a: 0.20564199118334203d, b: 0.8543544347608328d, c: 0.005237620416402744d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8908575088983673d, b: 0.9073760995661665d, c: 0.5468707948041029d),
new NpgsqlTypes.NpgsqlLine(a: 0.283362206303301d, b: 0.29692066295050246d, c: 0.22198060205235504d),
new NpgsqlTypes.NpgsqlLine(a: 0.48066519821261133d, b: 0.8734222526860169d, c: 0.06828715478195513d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9483128357263135d, b: 0.26470832831033386d, c: 0.5967357156767081d),
new NpgsqlTypes.NpgsqlLine(a: 0.30967376685613834d, b: 0.9773006800702134d, c: 0.5032510016211492d),
new NpgsqlTypes.NpgsqlLine(a: 0.11751292155611037d, b: 0.40116886660888906d, c: 0.11404467112859262d),
new NpgsqlTypes.NpgsqlLine(a: 0.26291795418167785d, b: 0.8180747334799695d, c: 0.7353895651450595d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5765512956987463d, b: 0.3156577045438246d, c: 0.5292465202054613d),
new NpgsqlTypes.NpgsqlLine(a: 0.36811059506270516d, b: 0.3006769716819405d, c: 0.7124064668759315d),
new NpgsqlTypes.NpgsqlLine(a: 0.021184202507707917d, b: 0.5160269764432099d, c: 0.6152394753751962d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8076182989158253d, b: 0.5414023771310151d, c: 0.16811686796142356d),
new NpgsqlTypes.NpgsqlLine(a: 0.1655992223796401d, b: 0.12032114555570772d, c: 0.18262161229918072d),
new NpgsqlTypes.NpgsqlLine(a: 0.5251536372423016d, b: 0.14527155911170564d, c: 0.1302175109382756d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6197951836351712d, b: 0.2667204137902359d, c: 0.41550559309297463d),
new NpgsqlTypes.NpgsqlLine(a: 0.17720059317357617d, b: 0.9434907272614056d, c: 0.7368072250360825d),
new NpgsqlTypes.NpgsqlLine(a: 0.4499491279096969d, b: 0.15370622981601867d, c: 0.6881736597046454d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4776377099112197d, b: 0.9704118898921165d, c: 0.7544650715737999d),
new NpgsqlTypes.NpgsqlLine(a: 0.9443284929855116d, b: 0.9061826134872766d, c: 0.5773574245409523d),
new NpgsqlTypes.NpgsqlLine(a: 0.4709567102299239d, b: 0.3244831662179575d, c: 0.1302478827688327d),
new NpgsqlTypes.NpgsqlLine(a: 0.1444917780782774d, b: 0.6616533294213489d, c: 0.521202888079168d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9831205040851908d, b: 0.6967733569274347d, c: 0.5639428666801806d),
new NpgsqlTypes.NpgsqlLine(a: 0.24217411928444155d, b: 0.6755375767495416d, c: 0.9091879734744617d),
new NpgsqlTypes.NpgsqlLine(a: 0.4794573280666844d, b: 0.5314662877908666d, c: 0.8206143562992658d),
new NpgsqlTypes.NpgsqlLine(a: 0.08955703730521813d, b: 0.5068063386562517d, c: 0.17449781553956967d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25856989212399795d, b: 0.13492778422768048d, c: 0.5528053194423187d),
new NpgsqlTypes.NpgsqlLine(a: 0.7848239546691503d, b: 0.9825188681622047d, c: 0.5148504400926297d),
new NpgsqlTypes.NpgsqlLine(a: 0.30713679898496626d, b: 0.09077785102573732d, c: 0.4423565447882114d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5434222963885984d, b: 0.12220660202650846d, c: 0.9867718809411504d),
new NpgsqlTypes.NpgsqlLine(a: 0.027261016918777692d, b: 0.29096976208671566d, c: 0.2665795069084905d),
new NpgsqlTypes.NpgsqlLine(a: 0.5854215514929079d, b: 0.12588889634779854d, c: 0.32923721765051084d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5927587626842397d, b: 0.9425685770898897d, c: 0.8326093713450821d),
new NpgsqlTypes.NpgsqlLine(a: 0.21455573757522006d, b: 0.4057538040812134d, c: 0.6040620968806242d),
new NpgsqlTypes.NpgsqlLine(a: 0.06632704387723976d, b: 0.6181334286094254d, c: 0.810144648054218d),
new NpgsqlTypes.NpgsqlLine(a: 0.8259383540224332d, b: 0.15347267513739526d, c: 0.26853448387345114d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7467297931268158d, b: 0.17451251832089076d, c: 0.9044770859018181d),
new NpgsqlTypes.NpgsqlLine(a: 0.7575826874890561d, b: 0.553124989143137d, c: 0.7295679596023985d),
new NpgsqlTypes.NpgsqlLine(a: 0.2308505243940775d, b: 0.026231214371865597d, c: 0.06223920253146864d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8899585959665808d, b: 0.04835775625138361d, c: 0.7818975229343207d),
new NpgsqlTypes.NpgsqlLine(a: 0.35297670128699776d, b: 0.6273905262549692d, c: 0.6989349278753972d),
new NpgsqlTypes.NpgsqlLine(a: 0.7476616101839368d, b: 0.01542185399004814d, c: 0.39227001407880113d),
new NpgsqlTypes.NpgsqlLine(a: 0.9107637199575794d, b: 0.6145208567023748d, c: 0.9859880400262617d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.012921244700656365d, b: 0.24063580370649373d, c: 0.6171461572016208d),
new NpgsqlTypes.NpgsqlLine(a: 0.8398640834662721d, b: 0.9652728705330255d, c: 0.18578586738374725d),
new NpgsqlTypes.NpgsqlLine(a: 0.3177631023330054d, b: 0.9110315677470168d, c: 0.7194792597809786d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17323301837984528d, b: 0.9427213442206615d, c: 0.8950326065903833d),
new NpgsqlTypes.NpgsqlLine(a: 0.09746988517854338d, b: 0.18843052225222545d, c: 0.10304482713619934d),
new NpgsqlTypes.NpgsqlLine(a: 0.12455003664388009d, b: 0.7627648282670768d, c: 0.4327361253920553d),
new NpgsqlTypes.NpgsqlLine(a: 0.32510076338902927d, b: 0.5433741450231444d, c: 0.825598647159229d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8783085895489445d, b: 0.3520741072062099d, c: 0.9191006590632965d),
new NpgsqlTypes.NpgsqlLine(a: 0.755782901055147d, b: 0.34723189536164323d, c: 0.04607575167621536d),
new NpgsqlTypes.NpgsqlLine(a: 0.7453796402061377d, b: 0.4384611507852375d, c: 0.8594302162137317d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2626950758729766d, b: 0.5718958717891722d, c: 0.835258102119506d),
new NpgsqlTypes.NpgsqlLine(a: 0.15084591164729866d, b: 0.25188893671458945d, c: 0.7861949442032341d),
new NpgsqlTypes.NpgsqlLine(a: 0.693275313868503d, b: 0.20521298781668673d, c: 0.16441059051618623d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7961119689722047d, b: 0.09902871543369662d, c: 0.9743125761863219d),
new NpgsqlTypes.NpgsqlLine(a: 0.8247170671591564d, b: 0.8073255622638256d, c: 0.8529580424556827d),
new NpgsqlTypes.NpgsqlLine(a: 0.08514552748744997d, b: 0.29556863709384384d, c: 0.06979744463187909d),
new NpgsqlTypes.NpgsqlLine(a: 0.8956443078606594d, b: 0.28668691827302095d, c: 0.1309115363048463d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8950355142597296d, b: 0.7933974281432604d, c: 0.42062891910412725d),
new NpgsqlTypes.NpgsqlLine(a: 0.4679660542962736d, b: 0.6190761712963575d, c: 0.5416761752329537d),
new NpgsqlTypes.NpgsqlLine(a: 0.1241510066559266d, b: 0.347540691736982d, c: 0.5733384597979023d),
new NpgsqlTypes.NpgsqlLine(a: 0.8548334800527626d, b: 0.4370648037452798d, c: 0.1533018904668526d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.36793510066382307d, b: 0.31172893116801004d, c: 0.255134181914211d),
new NpgsqlTypes.NpgsqlLine(a: 0.050385353013788214d, b: 0.627751772553029d, c: 0.24507748416086717d),
new NpgsqlTypes.NpgsqlLine(a: 0.5659080446955258d, b: 0.21781026761328415d, c: 0.010650535125033112d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48549865389532054d, b: 0.832576016915673d, c: 0.23751837037265322d),
new NpgsqlTypes.NpgsqlLine(a: 0.7077214040317286d, b: 0.41289255502001565d, c: 0.5694629808102359d),
new NpgsqlTypes.NpgsqlLine(a: 0.24608314212855564d, b: 0.2140298180131195d, c: 0.9210053758425303d),
new NpgsqlTypes.NpgsqlLine(a: 0.5936706995285634d, b: 0.8353431093920393d, c: 0.6378326957168788d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
                parametr1.Value = 102;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 43;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 70, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 81, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 102, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 55, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 43, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 14, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 101, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 134, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 29, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1M>(15);

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
                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

