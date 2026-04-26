

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
new NpgsqlTypes.NpgsqlLine(a: 0.35289743124269246d, b: 0.48296391104297653d, c: 0.9540285488566065d),

new NpgsqlTypes.NpgsqlLine(a: 0.4899074652233464d, b: 0.5249198139887286d, c: 0.7382042112442498d),

new NpgsqlTypes.NpgsqlLine(a: 0.5777827963916944d, b: 0.8752391573086319d, c: 0.3309433033142276d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5219512091302526d, b: 0.24623146921570138d, c: 0.004628626088257315d),

new NpgsqlTypes.NpgsqlLine(a: 0.3517182477080003d, b: 0.7457765740599427d, c: 0.24315556425899287d),

new NpgsqlTypes.NpgsqlLine(a: 0.37197258862120475d, b: 0.5840451407161404d, c: 0.5489331563146225d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22338665999567842d, b: 0.11817802107886766d, c: 0.0889650218021818d),

new NpgsqlTypes.NpgsqlLine(a: 0.3352988524359659d, b: 0.46024248715575855d, c: 0.7165400477628735d),

new NpgsqlTypes.NpgsqlLine(a: 0.4534082258678859d, b: 0.8540495717789022d, c: 0.4003668344660297d),

new NpgsqlTypes.NpgsqlLine(a: 0.8819399592545127d, b: 0.04708819909390116d, c: 0.7208185208681435d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5743642630426055d, b: 0.4444523853164414d, c: 0.25583008787783046d),

new NpgsqlTypes.NpgsqlLine(a: 0.5268143874254456d, b: 0.5517198508180294d, c: 0.7647936658558477d),

new NpgsqlTypes.NpgsqlLine(a: 0.5310200101452717d, b: 0.9710141245959337d, c: 0.33237910219941236d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9141362660124682d, b: 0.5442897993457384d, c: 0.498093052985743d),

new NpgsqlTypes.NpgsqlLine(a: 0.9928536113795662d, b: 0.05960582689881411d, c: 0.18943229890437085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5529290366409805d, b: 0.20355171323808507d, c: 0.7149590977288065d),

new NpgsqlTypes.NpgsqlLine(a: 0.25413995909369014d, b: 0.8904278582102235d, c: 0.9487012390018398d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49521665445625773d, b: 0.16444292406400918d, c: 0.7413495126633434d),

new NpgsqlTypes.NpgsqlLine(a: 0.705303222193226d, b: 0.5255296930488266d, c: 0.14108518984487695d),

new NpgsqlTypes.NpgsqlLine(a: 0.7175346564459678d, b: 0.6075154866191711d, c: 0.2111785505599486d),

new NpgsqlTypes.NpgsqlLine(a: 0.9551502303873046d, b: 0.02584627398189876d, c: 0.1501188703332168d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5466374482069633d, b: 0.08729129096497878d, c: 0.3252487204772123d),

new NpgsqlTypes.NpgsqlLine(a: 0.20910004767744172d, b: 0.5839173256606993d, c: 0.5294697889059393d),

new NpgsqlTypes.NpgsqlLine(a: 0.3594585257529993d, b: 0.7833662449590902d, c: 0.6978434059572951d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26682376348131387d, b: 0.07237630436215714d, c: 0.568241369443766d),

new NpgsqlTypes.NpgsqlLine(a: 0.19095099879597055d, b: 0.5057255195511808d, c: 0.07571941658397108d),

new NpgsqlTypes.NpgsqlLine(a: 0.19303414924803242d, b: 0.8144864448969433d, c: 0.8743492943031227d),

new NpgsqlTypes.NpgsqlLine(a: 0.44354016009605557d, b: 0.0952789533920102d, c: 0.7046687508960366d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5717862040428937d, b: 0.004676566293360662d, c: 0.49232609099218905d),

new NpgsqlTypes.NpgsqlLine(a: 0.4607808895373199d, b: 0.5394658445033703d, c: 0.043913512540324606d),

new NpgsqlTypes.NpgsqlLine(a: 0.4081106848961592d, b: 0.3482390204895065d, c: 0.29723904624756026d),

new NpgsqlTypes.NpgsqlLine(a: 0.658598989518622d, b: 0.16221368025462057d, c: 0.03878642004354793d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03703051913153743d, b: 0.47981560544644264d, c: 0.6805391131835422d),

new NpgsqlTypes.NpgsqlLine(a: 0.672949518322724d, b: 0.28743836666702327d, c: 0.6323533874443236d),

new NpgsqlTypes.NpgsqlLine(a: 0.6956360128925713d, b: 0.9107708754515013d, c: 0.9155268235242371d),

new NpgsqlTypes.NpgsqlLine(a: 0.534558857321205d, b: 0.7387213441970955d, c: 0.5736637700752508d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7995372685915972d, b: 0.7050926391045818d, c: 0.013514398665889327d),

new NpgsqlTypes.NpgsqlLine(a: 0.22424076547908323d, b: 0.5111697499502069d, c: 0.6652366200461963d),

new NpgsqlTypes.NpgsqlLine(a: 0.6955798028673993d, b: 0.6574576037782869d, c: 0.09350049461851528d),

new NpgsqlTypes.NpgsqlLine(a: 0.7623726969604772d, b: 0.8725762394607268d, c: 0.70792228170551d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2563811280105933d, b: 0.5105088751792317d, c: 0.51233103000856d),

new NpgsqlTypes.NpgsqlLine(a: 0.6961468445242199d, b: 0.8973165323145299d, c: 0.831923157965927d),

new NpgsqlTypes.NpgsqlLine(a: 0.37418444920817395d, b: 0.11458112732514947d, c: 0.2272465202466296d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5058971184201206d, b: 0.9849439948844966d, c: 0.6249219042518025d),

new NpgsqlTypes.NpgsqlLine(a: 0.12056907437913778d, b: 0.8366404105598013d, c: 0.8483962948474117d),

new NpgsqlTypes.NpgsqlLine(a: 0.8118799645455741d, b: 0.16115292340164444d, c: 0.04026911939872768d),

new NpgsqlTypes.NpgsqlLine(a: 0.19676455588122588d, b: 0.24494230435781406d, c: 0.2379582893688026d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5686259231680535d, b: 0.23888638505277127d, c: 0.6669056857660927d),

new NpgsqlTypes.NpgsqlLine(a: 0.46139037076145784d, b: 0.9469463405216008d, c: 0.860091074132205d),

new NpgsqlTypes.NpgsqlLine(a: 0.6471105878641131d, b: 0.3685188669780225d, c: 0.2641274633569123d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21603171574642444d, b: 0.03146022105607038d, c: 0.8343158147683136d),

new NpgsqlTypes.NpgsqlLine(a: 0.8867097849273965d, b: 0.7356943503143953d, c: 0.47430006070788744d),

new NpgsqlTypes.NpgsqlLine(a: 0.7180536649321152d, b: 0.8156992842411515d, c: 0.9433220728106081d),

new NpgsqlTypes.NpgsqlLine(a: 0.9844918304078875d, b: 0.7271248590227937d, c: 0.704292515842454d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2867861705274498d, b: 0.24760000773208823d, c: 0.18776758795048476d),

new NpgsqlTypes.NpgsqlLine(a: 0.44586351865161433d, b: 0.40703161771852314d, c: 0.07661129679825485d),

new NpgsqlTypes.NpgsqlLine(a: 0.4109530046624167d, b: 0.7349488491855456d, c: 0.7391334117684437d),

new NpgsqlTypes.NpgsqlLine(a: 0.007387541338143677d, b: 0.16334310271544228d, c: 0.41844203899370613d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5670933707282346d, b: 0.23596518142212874d, c: 0.22255470857011173d),

new NpgsqlTypes.NpgsqlLine(a: 0.5229578252946151d, b: 0.6021676992220101d, c: 0.19103725561180984d),

new NpgsqlTypes.NpgsqlLine(a: 0.46765084954731806d, b: 0.1467213893579169d, c: 0.07891346471250449d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9503033143014181d, b: 0.41404145806535175d, c: 0.5345745250561997d),

new NpgsqlTypes.NpgsqlLine(a: 0.4993059039111346d, b: 0.2296936625197069d, c: 0.7025444922859534d),

new NpgsqlTypes.NpgsqlLine(a: 0.7272442227834995d, b: 0.3169403495040445d, c: 0.5341651451625585d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.950218144134207d, b: 0.34295652138009736d, c: 0.9252225841753964d),

new NpgsqlTypes.NpgsqlLine(a: 0.4882153938236392d, b: 0.7278941356559111d, c: 0.6554643252277101d),

new NpgsqlTypes.NpgsqlLine(a: 0.4466547567854695d, b: 0.10661763928512735d, c: 0.25753626121966255d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.402354223410447d, b: 0.7321392461769828d, c: 0.5403235237923227d),

new NpgsqlTypes.NpgsqlLine(a: 0.5619108275276011d, b: 0.5022801366269772d, c: 0.6665251405376938d),

new NpgsqlTypes.NpgsqlLine(a: 0.5167365638254415d, b: 0.01075415604184149d, c: 0.7095457456423142d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14447071281580237d, b: 0.1186552561165869d, c: 0.8953816596355949d),

new NpgsqlTypes.NpgsqlLine(a: 0.5597400227536158d, b: 0.7292695351268772d, c: 0.199178636160254d),

new NpgsqlTypes.NpgsqlLine(a: 0.011039644557519268d, b: 0.8515970978280545d, c: 0.4914829345345947d),

new NpgsqlTypes.NpgsqlLine(a: 0.27574599694049073d, b: 0.18009242587091645d, c: 0.9248490089527422d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30866227801718127d, b: 0.028406727986871383d, c: 0.34235071294802377d),

new NpgsqlTypes.NpgsqlLine(a: 0.9003989280336295d, b: 0.982420287627893d, c: 0.8603311334289475d),

new NpgsqlTypes.NpgsqlLine(a: 0.003532213758892788d, b: 0.4493646830632567d, c: 0.6771246505365479d),

new NpgsqlTypes.NpgsqlLine(a: 0.5022129400157879d, b: 0.5369074924882168d, c: 0.8813168493150473d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23378332318011397d, b: 0.8980353793082331d, c: 0.4071008029584262d),

new NpgsqlTypes.NpgsqlLine(a: 0.9816204628342655d, b: 0.9925287094382499d, c: 0.7848745632700312d),

new NpgsqlTypes.NpgsqlLine(a: 0.2953858404119508d, b: 0.20982715990406275d, c: 0.7724111641125424d),

new NpgsqlTypes.NpgsqlLine(a: 0.48557960260548505d, b: 0.5350791497913159d, c: 0.9773904239360066d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9770436046502041d, b: 0.9765161562925322d, c: 0.5527147082347931d),

new NpgsqlTypes.NpgsqlLine(a: 0.24723585986685837d, b: 0.44477784781178376d, c: 0.07919994233270722d),

new NpgsqlTypes.NpgsqlLine(a: 0.26727805532201d, b: 0.32093252934654526d, c: 0.7811469935927148d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32977998912175743d, b: 0.9539832064648902d, c: 0.5307581769640715d),

new NpgsqlTypes.NpgsqlLine(a: 0.4953736472571125d, b: 0.1452929329113547d, c: 0.42437837322418637d),

new NpgsqlTypes.NpgsqlLine(a: 0.9579015471312293d, b: 0.49857779834511984d, c: 0.2074528617949486d),

new NpgsqlTypes.NpgsqlLine(a: 0.499032478406394d, b: 0.0225332092171745d, c: 0.2515831179993697d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6746019700356053d, b: 0.9495454103481615d, c: 0.8692052260698443d),

new NpgsqlTypes.NpgsqlLine(a: 0.37923239099187744d, b: 0.1494986792397045d, c: 0.7633361517057001d),

new NpgsqlTypes.NpgsqlLine(a: 0.2152771207686034d, b: 0.16512191500724527d, c: 0.1658615617773005d),

new NpgsqlTypes.NpgsqlLine(a: 0.09599699024116193d, b: 0.3646395735974921d, c: 0.4999724028801523d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.810702962584784d, b: 0.15458091062384216d, c: 0.8094379280670019d),

new NpgsqlTypes.NpgsqlLine(a: 0.7039559115325644d, b: 0.6982572233262571d, c: 0.5317772757487125d),

new NpgsqlTypes.NpgsqlLine(a: 0.9598291212712441d, b: 0.7422368721676317d, c: 0.31970981530087894d),

new NpgsqlTypes.NpgsqlLine(a: 0.56229117862735d, b: 0.11624019187633472d, c: 0.7429662468239903d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.37552747880695037d, b: 0.846432958672323d, c: 0.6415882053800595d),

new NpgsqlTypes.NpgsqlLine(a: 0.8415184703400345d, b: 0.9998281459610882d, c: 0.19281063973266876d),

new NpgsqlTypes.NpgsqlLine(a: 0.9421512504159207d, b: 0.12327406952010145d, c: 0.6285516928019802d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.01943073986034627d, b: 0.5216606160679386d, c: 0.9204670363140336d),

new NpgsqlTypes.NpgsqlLine(a: 0.6760862152826481d, b: 0.7103717366541751d, c: 0.8009362077130402d),

new NpgsqlTypes.NpgsqlLine(a: 0.838733938760377d, b: 0.967856738449652d, c: 0.9595554687717632d),

new NpgsqlTypes.NpgsqlLine(a: 0.9600818341114844d, b: 0.31840571220536507d, c: 0.18366212021299577d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4781200305514346d, b: 0.05036702805898796d, c: 0.13911208651673312d),

new NpgsqlTypes.NpgsqlLine(a: 0.4180682234965374d, b: 0.2210382761128279d, c: 0.2640671713113161d),

new NpgsqlTypes.NpgsqlLine(a: 0.8665393197550699d, b: 0.531336603860819d, c: 0.33230093328696764d),

new NpgsqlTypes.NpgsqlLine(a: 0.12321123927919453d, b: 0.07066887965315183d, c: 0.8983350036646285d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4789883457266533d, b: 0.8479720651781151d, c: 0.3618629801443711d),

new NpgsqlTypes.NpgsqlLine(a: 0.8045206817886825d, b: 0.4525979985900275d, c: 0.5987409751878884d),

new NpgsqlTypes.NpgsqlLine(a: 0.5659269522790734d, b: 0.6003507077651635d, c: 0.17360103228674484d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7575408425454238d, b: 0.45630184214239444d, c: 0.6558804844384579d),

new NpgsqlTypes.NpgsqlLine(a: 0.12420770281295945d, b: 0.3613886716360559d, c: 0.11660233073946591d),

new NpgsqlTypes.NpgsqlLine(a: 0.32784653736421565d, b: 0.40841265928267445d, c: 0.76245998904059d),

new NpgsqlTypes.NpgsqlLine(a: 0.9892865326772496d, b: 0.972302367196866d, c: 0.8006093109043652d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23325212431914755d, b: 0.2690902445267709d, c: 0.04989092775995818d),

new NpgsqlTypes.NpgsqlLine(a: 0.49617180665218485d, b: 0.08958266939296844d, c: 0.30480144018314437d),

new NpgsqlTypes.NpgsqlLine(a: 0.7950387962849637d, b: 0.5391756667130029d, c: 0.2897341784834191d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5789939049901305d, b: 0.3493864897947748d, c: 0.8232987057327333d),

new NpgsqlTypes.NpgsqlLine(a: 0.17027257264456686d, b: 0.48406595216336734d, c: 0.03004920514359055d),

new NpgsqlTypes.NpgsqlLine(a: 0.6873693469416593d, b: 0.60034158124714d, c: 0.8408422287205862d),

new NpgsqlTypes.NpgsqlLine(a: 0.3043058902687942d, b: 0.24619485777065708d, c: 0.7393142532451957d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5707299655637867d, b: 0.25172250657276474d, c: 0.15744020551869287d),

new NpgsqlTypes.NpgsqlLine(a: 0.9691016065224866d, b: 0.3300179683406247d, c: 0.984053024200001d),

new NpgsqlTypes.NpgsqlLine(a: 0.04923129702119233d, b: 0.7535877934437109d, c: 0.7389032998314871d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03154666503337822d, b: 0.18781261046541087d, c: 0.8276494501381261d),

new NpgsqlTypes.NpgsqlLine(a: 0.9736441800436005d, b: 0.9797923330016353d, c: 0.39922092769450845d),

new NpgsqlTypes.NpgsqlLine(a: 0.37316078725407487d, b: 0.8382988581235024d, c: 0.62634521011726d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15349248023044715d, b: 0.3784565361015765d, c: 0.6124987737323048d),

new NpgsqlTypes.NpgsqlLine(a: 0.03248467048188397d, b: 0.8065498421052956d, c: 0.7546420358614883d),

new NpgsqlTypes.NpgsqlLine(a: 0.8362478985012228d, b: 0.7295224676488554d, c: 0.40981914178013046d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5104769742865027d, b: 0.2184687003656366d, c: 0.004085965572443229d),

new NpgsqlTypes.NpgsqlLine(a: 0.1783305625597259d, b: 0.5446249838711589d, c: 0.8602360922001903d),

new NpgsqlTypes.NpgsqlLine(a: 0.054360945469544175d, b: 0.5931168580268097d, c: 0.7723827835652489d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2874418421280813d, b: 0.01788207104711914d, c: 0.816871084049106d),

new NpgsqlTypes.NpgsqlLine(a: 0.01479164948354561d, b: 0.8545308433383025d, c: 0.7119778558759081d),

new NpgsqlTypes.NpgsqlLine(a: 0.13366508403314104d, b: 0.38613362358369563d, c: 0.2549949024627559d),

new NpgsqlTypes.NpgsqlLine(a: 0.995368307965067d, b: 0.04654400734546171d, c: 0.43579057866429416d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.33562426506545784d, b: 0.4399448228476962d, c: 0.430267986104239d),

new NpgsqlTypes.NpgsqlLine(a: 0.898731640585921d, b: 0.2615183181434705d, c: 0.40148951513593745d),

new NpgsqlTypes.NpgsqlLine(a: 0.9101975103942991d, b: 0.27777167136658176d, c: 0.9269554194974844d),

new NpgsqlTypes.NpgsqlLine(a: 0.7470930766284258d, b: 0.4088439998435005d, c: 0.8271360560677093d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23627733211823376d, b: 0.9066994292470023d, c: 0.7352026232666887d),

new NpgsqlTypes.NpgsqlLine(a: 0.41770365093834827d, b: 0.411158220741083d, c: 0.07867544402556714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5844057236400126d, b: 0.3142315791564201d, c: 0.49617201282880696d),

new NpgsqlTypes.NpgsqlLine(a: 0.6079148872291431d, b: 0.16336306204376538d, c: 0.5375837899042687d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39487034319581527d, b: 0.00019562721540700156d, c: 0.3065580307290434d),

new NpgsqlTypes.NpgsqlLine(a: 0.48848247341961526d, b: 0.45506175503942914d, c: 0.6222342108400164d),

new NpgsqlTypes.NpgsqlLine(a: 0.4675632549138349d, b: 0.5960764154630737d, c: 0.06416039644722937d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.635215708826988d, b: 0.3749079329403374d, c: 0.5183300748474868d),

new NpgsqlTypes.NpgsqlLine(a: 0.7919732956334758d, b: 0.25737509665826785d, c: 0.9428289607486381d),

new NpgsqlTypes.NpgsqlLine(a: 0.9361014018198658d, b: 0.8587663115141877d, c: 0.6555415435597869d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.33071605945173166d, b: 0.5360148185694078d, c: 0.40706392353184195d),

new NpgsqlTypes.NpgsqlLine(a: 0.05244075636210166d, b: 0.5787139690252041d, c: 0.9424717610335231d),

new NpgsqlTypes.NpgsqlLine(a: 0.6800911671248786d, b: 0.1783527216871993d, c: 0.49757112992135755d),

new NpgsqlTypes.NpgsqlLine(a: 0.7470858317606582d, b: 0.9298424736821493d, c: 0.22381811530662554d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5976886382771112d, b: 0.7015285024140897d, c: 0.8287589036117528d),

new NpgsqlTypes.NpgsqlLine(a: 0.0191297339341735d, b: 0.9799110194489185d, c: 0.24291641290911614d),

new NpgsqlTypes.NpgsqlLine(a: 0.8885261233355295d, b: 0.8965911458136081d, c: 0.609465581860552d),

new NpgsqlTypes.NpgsqlLine(a: 0.42822027576957666d, b: 0.5711033347104892d, c: 0.8382071019355496d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4187301829265656d, b: 0.5738429721893054d, c: 0.9549939950581482d),

new NpgsqlTypes.NpgsqlLine(a: 0.9489243653729608d, b: 0.9248195872696842d, c: 0.4174282439923467d),

new NpgsqlTypes.NpgsqlLine(a: 0.8551434231426208d, b: 0.5978864976046054d, c: 0.8219483693799002d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3728949076254181d, b: 0.09067772230234561d, c: 0.8697260102910761d),

new NpgsqlTypes.NpgsqlLine(a: 0.1675112048875751d, b: 0.8476564301902123d, c: 0.8498248737147281d),

new NpgsqlTypes.NpgsqlLine(a: 0.40844952262938716d, b: 0.10256642458148735d, c: 0.3104988721392945d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6835745327894878d, b: 0.47226904465146513d, c: 0.25284658282123673d),

new NpgsqlTypes.NpgsqlLine(a: 0.3987203680197814d, b: 0.5864147169247804d, c: 0.11980404309819093d),

new NpgsqlTypes.NpgsqlLine(a: 0.7529397595400971d, b: 0.3083560062424402d, c: 0.049735212073526824d),

new NpgsqlTypes.NpgsqlLine(a: 0.3973662777908571d, b: 0.46116441168723643d, c: 0.6691484282179319d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15658711816955295d, b: 0.9938643140957091d, c: 0.4475705538326967d),

new NpgsqlTypes.NpgsqlLine(a: 0.9523181843619342d, b: 0.8148957778326391d, c: 0.5429467149296622d),

new NpgsqlTypes.NpgsqlLine(a: 0.6349210866935641d, b: 0.20888418357918093d, c: 0.20242023766609574d),

new NpgsqlTypes.NpgsqlLine(a: 0.6085069313478234d, b: 0.05674248618263111d, c: 0.12564519524679363d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2618482011696338d, b: 0.5933310413330799d, c: 0.3475943662268055d),

new NpgsqlTypes.NpgsqlLine(a: 0.4327318469784761d, b: 0.38947388160191765d, c: 0.20141588469513916d),

new NpgsqlTypes.NpgsqlLine(a: 0.7022286124941672d, b: 0.061894112083631936d, c: 0.0009510592105195226d),

new NpgsqlTypes.NpgsqlLine(a: 0.41342586923694513d, b: 0.15100272763795453d, c: 0.5729820673717629d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20966367120355556d, b: 0.7988567438820593d, c: 0.7645591307196843d),

new NpgsqlTypes.NpgsqlLine(a: 0.4808948544924291d, b: 0.9967248986757999d, c: 0.09575134314596334d),

new NpgsqlTypes.NpgsqlLine(a: 0.08222140881530893d, b: 0.426473765461729d, c: 0.8526431875958483d),

new NpgsqlTypes.NpgsqlLine(a: 0.31704306859139064d, b: 0.32444145408352576d, c: 0.17136943881911626d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7456926206490184d, b: 0.8250907377647024d, c: 0.7221065162413451d),

new NpgsqlTypes.NpgsqlLine(a: 0.31802968014662625d, b: 0.08710432325311257d, c: 0.5520096356751266d),

new NpgsqlTypes.NpgsqlLine(a: 0.5892752214433989d, b: 0.8938463064344135d, c: 0.2196743601843668d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8626463136450175d, b: 0.7262557992667846d, c: 0.3930133253477337d),

new NpgsqlTypes.NpgsqlLine(a: 0.43508244212333547d, b: 0.14718417431372688d, c: 0.4580581695571917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6920442332508658d, b: 0.8829309548290497d, c: 0.8842176073909637d),

new NpgsqlTypes.NpgsqlLine(a: 0.8459912688098913d, b: 0.9283848648242506d, c: 0.6258861804691535d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7853875536473348d, b: 0.016467900563741034d, c: 0.5654975264935156d),

new NpgsqlTypes.NpgsqlLine(a: 0.18147180175518118d, b: 0.7305898038109703d, c: 0.5271388820491805d),

new NpgsqlTypes.NpgsqlLine(a: 0.27435118300685735d, b: 0.746685217133279d, c: 0.1733372117394517d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19329332050149772d, b: 0.22579291893348385d, c: 0.9339902682540302d),

new NpgsqlTypes.NpgsqlLine(a: 0.8253768701059995d, b: 0.3929430399167225d, c: 0.6236800632922553d),

new NpgsqlTypes.NpgsqlLine(a: 0.9672552698417304d, b: 0.2848617188640352d, c: 0.043338407135361745d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9709371785218183d, b: 0.9570925500742131d, c: 0.3395957291473781d),

new NpgsqlTypes.NpgsqlLine(a: 0.9451976456597581d, b: 0.7169662152599664d, c: 0.4517417542269231d),

new NpgsqlTypes.NpgsqlLine(a: 0.3471359641054548d, b: 0.3999932264268675d, c: 0.4224349744132144d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26084137470300806d, b: 0.26446183221635566d, c: 0.14364794315214957d),

new NpgsqlTypes.NpgsqlLine(a: 0.2881542614739975d, b: 0.4576317626112941d, c: 0.8784192550993722d),

new NpgsqlTypes.NpgsqlLine(a: 0.46444541490565816d, b: 0.9955138134933832d, c: 0.8631669342136782d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8316335173344619d, b: 0.9628115394586314d, c: 0.3377115226882419d),

new NpgsqlTypes.NpgsqlLine(a: 0.19159156834864943d, b: 0.08158853597074378d, c: 0.3720146639674565d),

new NpgsqlTypes.NpgsqlLine(a: 0.18768115165211974d, b: 0.5856177883218283d, c: 0.1638720768522791d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9777831602381348d, b: 0.8308762241614728d, c: 0.9055794185553425d),

new NpgsqlTypes.NpgsqlLine(a: 0.9258452154960396d, b: 0.7980471012757664d, c: 0.10860876761801475d),

new NpgsqlTypes.NpgsqlLine(a: 0.15856199136468652d, b: 0.7992484085244411d, c: 0.6819661665540134d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8708109607543907d, b: 0.5209977581031134d, c: 0.16365999154242838d),

new NpgsqlTypes.NpgsqlLine(a: 0.6877246192095154d, b: 0.47947126743334867d, c: 0.6565455207220924d),

new NpgsqlTypes.NpgsqlLine(a: 0.5038499736604495d, b: 0.751845612549216d, c: 0.09627354465655835d),

new NpgsqlTypes.NpgsqlLine(a: 0.7421914373525981d, b: 0.6663711109117927d, c: 0.7561236226973432d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12918893444174862d, b: 0.8772530336517008d, c: 0.3660763072164377d),

new NpgsqlTypes.NpgsqlLine(a: 0.8089133661454323d, b: 0.42699782224342253d, c: 0.21990767839951153d),

new NpgsqlTypes.NpgsqlLine(a: 0.7765345943398394d, b: 0.9088866671346721d, c: 0.31379306110835536d),

new NpgsqlTypes.NpgsqlLine(a: 0.8698598228757849d, b: 0.6684468225306617d, c: 0.4915364913412098d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5101116608728025d, b: 0.3466416208580241d, c: 0.19953618870882728d),

new NpgsqlTypes.NpgsqlLine(a: 0.9606916643669434d, b: 0.9086032763871504d, c: 0.06081970609002685d),

new NpgsqlTypes.NpgsqlLine(a: 0.9968114171635786d, b: 0.3178887839117497d, c: 0.6370005758319819d),

new NpgsqlTypes.NpgsqlLine(a: 0.0909901777463642d, b: 0.026928303412963372d, c: 0.48323276180638863d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8674854766172142d, b: 0.1445037694671213d, c: 0.20298528199308585d),

new NpgsqlTypes.NpgsqlLine(a: 0.47667813118132873d, b: 0.6326029816259386d, c: 0.4208524575684248d),

new NpgsqlTypes.NpgsqlLine(a: 0.9217216518068767d, b: 0.5713421561771996d, c: 0.1318648169788591d),

new NpgsqlTypes.NpgsqlLine(a: 0.8627357146942858d, b: 0.22629292646222232d, c: 0.13443884503377423d),

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
                parametr1.Value = 127;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                parametr1.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[29], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[29], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 114, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 82, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[29], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 138, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 114, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 68, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 88, query1, 146, query2))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 88, 4))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 4, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
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

