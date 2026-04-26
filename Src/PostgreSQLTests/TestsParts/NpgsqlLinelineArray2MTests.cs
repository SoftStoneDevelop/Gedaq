

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.304990029576117d, b: 0.33170650488564535d, c: 0.19024605894994517d),

new NpgsqlTypes.NpgsqlLine(a: 0.16193743567804908d, b: 0.08527911521929699d, c: 0.24093722795593275d),

new NpgsqlTypes.NpgsqlLine(a: 0.5668512964543825d, b: 0.556693012578733d, c: 0.8411125336837945d),

new NpgsqlTypes.NpgsqlLine(a: 0.09772816888054503d, b: 0.07590721363149344d, c: 0.5016850214719709d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07617664768302868d, b: 0.9103962362784506d, c: 0.035819574597095394d),

new NpgsqlTypes.NpgsqlLine(a: 0.30111410255518334d, b: 0.07882798077199948d, c: 0.6871276656875167d),

new NpgsqlTypes.NpgsqlLine(a: 0.41447189486472125d, b: 0.9849611210727449d, c: 0.004789421117652237d),

new NpgsqlTypes.NpgsqlLine(a: 0.765830232081711d, b: 0.011247353933179105d, c: 0.37066918460262777d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22874743529421393d, b: 0.7378295936269701d, c: 0.0031237712625348246d),

new NpgsqlTypes.NpgsqlLine(a: 0.5000237076386892d, b: 0.21050807405856975d, c: 0.43098296577732953d),

new NpgsqlTypes.NpgsqlLine(a: 0.6575698552618077d, b: 0.5302949158318334d, c: 0.9704617323484257d),

new NpgsqlTypes.NpgsqlLine(a: 0.2573527883180762d, b: 0.2697926938524008d, c: 0.09762813418719463d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3398032149261758d, b: 0.23634116315773213d, c: 0.82780652770456d),

new NpgsqlTypes.NpgsqlLine(a: 0.566756607695015d, b: 0.4640777978762959d, c: 0.11892249439438796d),

new NpgsqlTypes.NpgsqlLine(a: 0.07461369863229372d, b: 0.9561296841926793d, c: 0.9279491307283874d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48472372245964634d, b: 0.9231875264769931d, c: 0.8335103557328949d),

new NpgsqlTypes.NpgsqlLine(a: 0.666565072077587d, b: 0.35710120884081387d, c: 0.40405630934247494d),

new NpgsqlTypes.NpgsqlLine(a: 0.5934454483016771d, b: 0.7566799525632243d, c: 0.24225626878777706d),

new NpgsqlTypes.NpgsqlLine(a: 0.7686854135801638d, b: 0.13192868605962016d, c: 0.2860647333618006d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05066284890826034d, b: 0.26083430304553856d, c: 0.46852180681375977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5430858448240359d, b: 0.5988495138150197d, c: 0.565246460565324d),

new NpgsqlTypes.NpgsqlLine(a: 0.9003769639176581d, b: 0.26669258538135854d, c: 0.04886939830162518d),

new NpgsqlTypes.NpgsqlLine(a: 0.18183869045851075d, b: 0.859039715778026d, c: 0.08527166000159825d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47092589452832356d, b: 0.6187527374195717d, c: 0.9760704237132223d),

new NpgsqlTypes.NpgsqlLine(a: 0.8399072355874759d, b: 0.5304084728166945d, c: 0.6440153515969049d),

new NpgsqlTypes.NpgsqlLine(a: 0.2856971738156956d, b: 0.08842902235231764d, c: 0.27014133926301553d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5470805895105297d, b: 0.9971063009084872d, c: 0.38077529728044146d),

new NpgsqlTypes.NpgsqlLine(a: 0.5360198825449176d, b: 0.13195922010820504d, c: 0.06998609530706479d),

new NpgsqlTypes.NpgsqlLine(a: 0.18825146528320968d, b: 0.034833626062701795d, c: 0.5349526472839713d),

new NpgsqlTypes.NpgsqlLine(a: 0.2067159171872216d, b: 0.9130066414350961d, c: 0.20681825786838282d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5731236331688087d, b: 0.8436552884752024d, c: 0.5555366436946036d),

new NpgsqlTypes.NpgsqlLine(a: 0.2823627738816197d, b: 0.010475630873859165d, c: 0.7472292654885526d),

new NpgsqlTypes.NpgsqlLine(a: 0.8861227085099682d, b: 0.27962439736764155d, c: 0.29396253623725777d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0011869090753717781d, b: 0.9079944120896974d, c: 0.6032764500892436d),

new NpgsqlTypes.NpgsqlLine(a: 0.8495854193473019d, b: 0.8690293389405845d, c: 0.31257444390999745d),

new NpgsqlTypes.NpgsqlLine(a: 0.7148354629097428d, b: 0.29971146377576285d, c: 0.23974119490100343d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5606209419493471d, b: 0.1904993999891491d, c: 0.6089672174677222d),

new NpgsqlTypes.NpgsqlLine(a: 0.6168166292239108d, b: 0.5820484066404645d, c: 0.8736025631223518d),

new NpgsqlTypes.NpgsqlLine(a: 0.6367359455223258d, b: 0.8594579816348881d, c: 0.1902509237179869d),

new NpgsqlTypes.NpgsqlLine(a: 0.39699518093868336d, b: 0.47426171141147033d, c: 0.5300803875516991d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5316196960710553d, b: 0.7114903866723356d, c: 0.33466595829077084d),

new NpgsqlTypes.NpgsqlLine(a: 0.8206006187435518d, b: 0.31847679431910203d, c: 0.5200374383104609d),

new NpgsqlTypes.NpgsqlLine(a: 0.820513410410112d, b: 0.21605146632891348d, c: 0.0865564809094207d),

new NpgsqlTypes.NpgsqlLine(a: 0.593987903003328d, b: 0.6585094003014321d, c: 0.46901927256636744d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7598574401225359d, b: 0.6213404599696064d, c: 0.9780868472038154d),

new NpgsqlTypes.NpgsqlLine(a: 0.8068328632733416d, b: 0.39282779889602704d, c: 0.394056103194812d),

new NpgsqlTypes.NpgsqlLine(a: 0.772488359129835d, b: 0.21790587450932042d, c: 0.8911943045177865d),

new NpgsqlTypes.NpgsqlLine(a: 0.3476686327624843d, b: 0.5537068561215039d, c: 0.06991791584206153d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07482794171854656d, b: 0.15353894115473643d, c: 0.5307032231912101d),

new NpgsqlTypes.NpgsqlLine(a: 0.7719312709509368d, b: 0.7855967735823663d, c: 0.6459147029983583d),

new NpgsqlTypes.NpgsqlLine(a: 0.7990243873673146d, b: 0.43783882143289377d, c: 0.7919407634329992d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.056293771299376516d, b: 0.31131366577363284d, c: 0.3860798068147885d),

new NpgsqlTypes.NpgsqlLine(a: 0.9796109269589188d, b: 0.3798374271525615d, c: 0.3061010269096862d),

new NpgsqlTypes.NpgsqlLine(a: 0.9965626646216d, b: 0.6206194708449216d, c: 0.15347101541984143d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.958973440623664d, b: 0.005591449687904149d, c: 0.5030987543458703d),

new NpgsqlTypes.NpgsqlLine(a: 0.024779326378397193d, b: 0.7230726545625782d, c: 0.8807981453095939d),

new NpgsqlTypes.NpgsqlLine(a: 0.3495379333652805d, b: 0.595592917080899d, c: 0.8505941960145759d),

new NpgsqlTypes.NpgsqlLine(a: 0.21676071014432752d, b: 0.30370338860278756d, c: 0.7967479214561681d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.422693586736674d, b: 0.9220241917559278d, c: 0.41127436986008026d),

new NpgsqlTypes.NpgsqlLine(a: 0.17975919424346265d, b: 0.2190927833388847d, c: 0.6754553532479831d),

new NpgsqlTypes.NpgsqlLine(a: 0.42610194290898373d, b: 0.2636492710216166d, c: 0.5355840387159659d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.33376220209904495d, b: 0.9029129821046509d, c: 0.37035070554514793d),

new NpgsqlTypes.NpgsqlLine(a: 0.47240704563009117d, b: 0.7861484519233176d, c: 0.3434082583289393d),

new NpgsqlTypes.NpgsqlLine(a: 0.5378344724325705d, b: 0.5509309061687637d, c: 0.6162354016303498d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5438366674017948d, b: 0.5310519881343257d, c: 0.8139971829939248d),

new NpgsqlTypes.NpgsqlLine(a: 0.9039652020561356d, b: 0.47029209847105624d, c: 0.40205670787296655d),

new NpgsqlTypes.NpgsqlLine(a: 0.2970524210038339d, b: 0.9717676677778705d, c: 0.2532604058492618d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2143397126109805d, b: 0.08052185480344398d, c: 0.9003878197893977d),

new NpgsqlTypes.NpgsqlLine(a: 0.8916809014754618d, b: 0.9130642595661193d, c: 0.09593586507392116d),

new NpgsqlTypes.NpgsqlLine(a: 0.5662786965725971d, b: 0.2555348869608498d, c: 0.7378876711655542d),

new NpgsqlTypes.NpgsqlLine(a: 0.8198279157575892d, b: 0.8841296009948771d, c: 0.9182254903751214d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8743759993961238d, b: 0.6616861222311731d, c: 0.6537447246351603d),

new NpgsqlTypes.NpgsqlLine(a: 0.3159905187237648d, b: 0.23323617246711537d, c: 0.43920835322356444d),

new NpgsqlTypes.NpgsqlLine(a: 0.3812186553688912d, b: 0.3728932367834743d, c: 0.7345664768520996d),

new NpgsqlTypes.NpgsqlLine(a: 0.17797036445137793d, b: 0.45554079823662685d, c: 0.9599182646361765d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.322208749089427d, b: 0.6969548520730827d, c: 0.36668237289129624d),

new NpgsqlTypes.NpgsqlLine(a: 0.8446403226807196d, b: 0.783671537132989d, c: 0.49295687523497156d),

new NpgsqlTypes.NpgsqlLine(a: 0.8763554660766111d, b: 0.08706410332749626d, c: 0.4551412114475101d),

new NpgsqlTypes.NpgsqlLine(a: 0.7819459441152973d, b: 0.20252217945207995d, c: 0.22163123256862383d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6508954359128472d, b: 0.9542890642397723d, c: 0.01666865321991451d),

new NpgsqlTypes.NpgsqlLine(a: 0.07983730736003825d, b: 0.08450567369282158d, c: 0.24600796069484898d),

new NpgsqlTypes.NpgsqlLine(a: 0.051698783424392714d, b: 0.14328537931836272d, c: 0.20601447182591714d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18003329078720454d, b: 0.8701751204721715d, c: 0.42702193540415956d),

new NpgsqlTypes.NpgsqlLine(a: 0.5934015096582543d, b: 0.6557899246271613d, c: 0.9668357498752133d),

new NpgsqlTypes.NpgsqlLine(a: 0.5356428557398873d, b: 0.6257818407484528d, c: 0.38408654087382443d),

new NpgsqlTypes.NpgsqlLine(a: 0.445884852543767d, b: 0.26644812395920503d, c: 0.4953167386912751d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27965521413512684d, b: 0.8871560131308464d, c: 0.29711829861584627d),

new NpgsqlTypes.NpgsqlLine(a: 0.6546224842098713d, b: 0.04391778253809675d, c: 0.4888855607926381d),

new NpgsqlTypes.NpgsqlLine(a: 0.08733756896758249d, b: 0.8700394053832453d, c: 0.7107048709739856d),

new NpgsqlTypes.NpgsqlLine(a: 0.8046427662509479d, b: 0.8830921834132146d, c: 0.9415496659502404d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03556477451233231d, b: 0.6784720368674283d, c: 0.5601430572044073d),

new NpgsqlTypes.NpgsqlLine(a: 0.7792314248163034d, b: 0.492767270567427d, c: 0.34310747574851963d),

new NpgsqlTypes.NpgsqlLine(a: 0.8156319084148358d, b: 0.998173643403525d, c: 0.38358455629173016d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8564842672443896d, b: 0.7664263976431087d, c: 0.32824670186855087d),

new NpgsqlTypes.NpgsqlLine(a: 0.9394464327932218d, b: 0.1452747077411941d, c: 0.09444658897000047d),

new NpgsqlTypes.NpgsqlLine(a: 0.3825356994885183d, b: 0.21766042102104455d, c: 0.7852293921076059d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16504646591796646d, b: 0.14108553497033394d, c: 0.1332199853004884d),

new NpgsqlTypes.NpgsqlLine(a: 0.19496881759379137d, b: 0.5455997778520938d, c: 0.2639992903845574d),

new NpgsqlTypes.NpgsqlLine(a: 0.6220087369711724d, b: 0.9888640588502404d, c: 0.08562186040014963d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7449771808695993d, b: 0.3999171764906252d, c: 0.9641963419182661d),

new NpgsqlTypes.NpgsqlLine(a: 0.22158313370584293d, b: 0.7479137432042795d, c: 0.9500813860722733d),

new NpgsqlTypes.NpgsqlLine(a: 0.23484536504934905d, b: 0.09654253234897536d, c: 0.6188405900285453d),

new NpgsqlTypes.NpgsqlLine(a: 0.22743705987140916d, b: 0.7947688205414676d, c: 0.41240762555461086d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26166086314871784d, b: 0.8791708822751539d, c: 0.20384303762535105d),

new NpgsqlTypes.NpgsqlLine(a: 0.6105441447967034d, b: 0.828317952179792d, c: 0.9104243576242578d),

new NpgsqlTypes.NpgsqlLine(a: 0.11793658940566332d, b: 0.9102324016363211d, c: 0.3222676530700843d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.016640565644957972d, b: 0.626497306648229d, c: 0.9086239767270875d),

new NpgsqlTypes.NpgsqlLine(a: 0.43210064154431715d, b: 0.08047363459926182d, c: 0.17371335781276487d),

new NpgsqlTypes.NpgsqlLine(a: 0.8428686597130055d, b: 0.14722170142464552d, c: 0.0748617627765148d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.683440396904801d, b: 0.32340789753641663d, c: 0.7080833705939101d),

new NpgsqlTypes.NpgsqlLine(a: 0.05022530978022255d, b: 0.455015656906379d, c: 0.41100322609757123d),

new NpgsqlTypes.NpgsqlLine(a: 0.2862297589817975d, b: 0.4860354443915358d, c: 0.1560026158358777d),

new NpgsqlTypes.NpgsqlLine(a: 0.17135290715648477d, b: 0.07704933411353365d, c: 0.29240124456435257d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17820587995502668d, b: 0.07938414313003173d, c: 0.593057476377368d),

new NpgsqlTypes.NpgsqlLine(a: 0.02596668993430984d, b: 0.7102972780489745d, c: 0.4099529863021061d),

new NpgsqlTypes.NpgsqlLine(a: 0.9622257027113982d, b: 0.7401503986434241d, c: 0.4590026969805133d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17983720756047394d, b: 0.5006479871103967d, c: 0.3301074117856121d),

new NpgsqlTypes.NpgsqlLine(a: 0.46874892999015194d, b: 0.8981710396724859d, c: 0.9895826873991476d),

new NpgsqlTypes.NpgsqlLine(a: 0.7737485671203486d, b: 0.5292138285624631d, c: 0.21937351688081053d),

new NpgsqlTypes.NpgsqlLine(a: 0.1260423960249405d, b: 0.9283691479533173d, c: 0.759423954503263d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5493809949195483d, b: 0.011815495951458255d, c: 0.08725070597291695d),

new NpgsqlTypes.NpgsqlLine(a: 0.6585496548287598d, b: 0.8360852147121098d, c: 0.8103196463007225d),

new NpgsqlTypes.NpgsqlLine(a: 0.8937711246232444d, b: 0.013170572188909602d, c: 0.41939717282208777d),

new NpgsqlTypes.NpgsqlLine(a: 0.212543320070253d, b: 0.3627367097453167d, c: 0.2909626187364218d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08496556767198982d, b: 0.32020767877333034d, c: 0.7713313236813967d),

new NpgsqlTypes.NpgsqlLine(a: 0.5029101005962746d, b: 0.18342938019802502d, c: 0.8245457359675575d),

new NpgsqlTypes.NpgsqlLine(a: 0.8708577892811971d, b: 0.8362228143557179d, c: 0.659180496241494d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0536157402134656d, b: 0.5731484845849747d, c: 0.9394933671250414d),

new NpgsqlTypes.NpgsqlLine(a: 0.5150164413630244d, b: 0.020457201556095428d, c: 0.37162627540526116d),

new NpgsqlTypes.NpgsqlLine(a: 0.7464257946605662d, b: 0.08732041251441991d, c: 0.5181577281768786d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5923462967354699d, b: 0.7217116372965356d, c: 0.6745176458207722d),

new NpgsqlTypes.NpgsqlLine(a: 0.1618113878021621d, b: 0.10433161750774755d, c: 0.08847467490631467d),

new NpgsqlTypes.NpgsqlLine(a: 0.01337596036792299d, b: 0.7929417663163689d, c: 0.12378722266559894d),

new NpgsqlTypes.NpgsqlLine(a: 0.9221172710430929d, b: 0.7764601520976637d, c: 0.20532213372132968d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3934105930521401d, b: 0.24300452664772576d, c: 0.23653440778888024d),

new NpgsqlTypes.NpgsqlLine(a: 0.581297287072002d, b: 0.14461919257435296d, c: 0.7763841520100305d),

new NpgsqlTypes.NpgsqlLine(a: 0.8388978271047351d, b: 0.6922898065560947d, c: 0.7377008318737127d),

new NpgsqlTypes.NpgsqlLine(a: 0.96350727888252d, b: 0.9929705059247552d, c: 0.7558855423344895d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15198627967919853d, b: 0.10230140948309108d, c: 0.06319431273850562d),

new NpgsqlTypes.NpgsqlLine(a: 0.4217282204767471d, b: 0.48164114989095363d, c: 0.5730351097547661d),

new NpgsqlTypes.NpgsqlLine(a: 0.9696439258989206d, b: 0.6189649586513731d, c: 0.760387664058748d),

new NpgsqlTypes.NpgsqlLine(a: 0.34059551812506916d, b: 0.7777126162659534d, c: 0.785418114182396d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2327805620081309d, b: 0.049053275308739264d, c: 0.12038855309963026d),

new NpgsqlTypes.NpgsqlLine(a: 0.8421672999961906d, b: 0.6532221131413006d, c: 0.10431719144488039d),

new NpgsqlTypes.NpgsqlLine(a: 0.6071194279621454d, b: 0.13656753710957537d, c: 0.8192121590220303d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6005145228048767d, b: 0.3194422540129792d, c: 0.40127443088062276d),

new NpgsqlTypes.NpgsqlLine(a: 0.9681760930876938d, b: 0.3914586520721819d, c: 0.6170924405650078d),

new NpgsqlTypes.NpgsqlLine(a: 0.06464360911206246d, b: 0.3890059032739469d, c: 0.7882278871589332d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3627333284801122d, b: 0.8144857181534491d, c: 0.19951001177190442d),

new NpgsqlTypes.NpgsqlLine(a: 0.6759875052886654d, b: 0.6765668282223254d, c: 0.7837108258706841d),

new NpgsqlTypes.NpgsqlLine(a: 0.393164620800725d, b: 0.5465081465242542d, c: 0.8273119911395936d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6727079507087621d, b: 0.7776996014485629d, c: 0.13915535163048465d),

new NpgsqlTypes.NpgsqlLine(a: 0.10731084452479556d, b: 0.22390743733817264d, c: 0.5424342965329632d),

new NpgsqlTypes.NpgsqlLine(a: 0.5272319159379878d, b: 0.1408236455133478d, c: 0.9325716973505167d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04068985660177993d, b: 0.5114586943708406d, c: 0.06033223409665267d),

new NpgsqlTypes.NpgsqlLine(a: 0.2218523519753861d, b: 0.7843199715387997d, c: 0.6373933674508919d),

new NpgsqlTypes.NpgsqlLine(a: 0.6795085969382748d, b: 0.622403068424981d, c: 0.5113732765398836d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5262382816743834d, b: 0.13573598359209604d, c: 0.6506668034282095d),

new NpgsqlTypes.NpgsqlLine(a: 0.416645239788214d, b: 0.013860108170247187d, c: 0.8093065417921591d),

new NpgsqlTypes.NpgsqlLine(a: 0.6306424418422035d, b: 0.04347066202716199d, c: 0.37517850100331074d),

new NpgsqlTypes.NpgsqlLine(a: 0.018079722275698873d, b: 0.49025298769036374d, c: 0.8342557861559227d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8333093908599046d, b: 0.564180051745924d, c: 0.4918723860959656d),

new NpgsqlTypes.NpgsqlLine(a: 0.03113428237420235d, b: 0.512101467059504d, c: 0.9002658214001127d),

new NpgsqlTypes.NpgsqlLine(a: 0.5680483540139881d, b: 0.37851193394372673d, c: 0.741376944847754d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.37163303274432935d, b: 0.3504875791770359d, c: 0.8593127222539176d),

new NpgsqlTypes.NpgsqlLine(a: 0.05671451548273132d, b: 0.2677922195411926d, c: 0.6217568205722585d),

new NpgsqlTypes.NpgsqlLine(a: 0.24550530763133505d, b: 0.16310630184329966d, c: 0.12941098865917644d),

new NpgsqlTypes.NpgsqlLine(a: 0.5391152925023193d, b: 0.25865115959805196d, c: 0.476872690758946d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7639152868554322d, b: 0.8581376647190778d, c: 0.44092705449510394d),

new NpgsqlTypes.NpgsqlLine(a: 0.13871694543861013d, b: 0.8154405555040721d, c: 0.9177135169800319d),

new NpgsqlTypes.NpgsqlLine(a: 0.6832687289720443d, b: 0.9045097813234814d, c: 0.10910129495753396d),

new NpgsqlTypes.NpgsqlLine(a: 0.13000005379428559d, b: 0.5837736649261371d, c: 0.38584570877560687d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10514699976442132d, b: 0.9155069869825098d, c: 0.24215734897907726d),

new NpgsqlTypes.NpgsqlLine(a: 0.587978764082613d, b: 0.5430768451428393d, c: 0.15465486663555483d),

new NpgsqlTypes.NpgsqlLine(a: 0.32997255449841456d, b: 0.7668665108374051d, c: 0.4027179311429858d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9887062306501446d, b: 0.026380288687253173d, c: 0.8539464942719465d),

new NpgsqlTypes.NpgsqlLine(a: 0.8014931876082085d, b: 0.5490344841072913d, c: 0.6961970485584381d),

new NpgsqlTypes.NpgsqlLine(a: 0.01779875635160566d, b: 0.09437112815591342d, c: 0.4580379541736508d),

new NpgsqlTypes.NpgsqlLine(a: 0.4907666403035422d, b: 0.7396301836261376d, c: 0.4864243530324981d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31755458372858925d, b: 0.6131658487675605d, c: 0.1201895033425655d),

new NpgsqlTypes.NpgsqlLine(a: 0.43635980453987067d, b: 0.8715109043538389d, c: 0.456043427462559d),

new NpgsqlTypes.NpgsqlLine(a: 0.001741001407201903d, b: 0.2652448245854463d, c: 0.315371270371698d),

new NpgsqlTypes.NpgsqlLine(a: 0.3401365642578258d, b: 0.33566144982809076d, c: 0.45851528842717104d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5973631989138248d, b: 0.37340727355658276d, c: 0.8859616942628324d),

new NpgsqlTypes.NpgsqlLine(a: 0.9950632289994416d, b: 0.9109114663460246d, c: 0.5313852126039863d),

new NpgsqlTypes.NpgsqlLine(a: 0.5169750524340114d, b: 0.36143512081343876d, c: 0.7872183411861748d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5616049406347503d, b: 0.664322444120164d, c: 0.13822564063570253d),

new NpgsqlTypes.NpgsqlLine(a: 0.9607269892968981d, b: 0.28456316659468206d, c: 0.9834628755098704d),

new NpgsqlTypes.NpgsqlLine(a: 0.8411960921371774d, b: 0.13023485098696097d, c: 0.7031111863588076d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9700811015367571d, b: 0.5000672717361317d, c: 0.3235626164758222d),

new NpgsqlTypes.NpgsqlLine(a: 0.4814046928010115d, b: 0.033735473957549056d, c: 0.29514155966060995d),

new NpgsqlTypes.NpgsqlLine(a: 0.2979547780383387d, b: 0.4451661323494003d, c: 0.9122865425862937d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9796200586534085d, b: 0.8569344805580197d, c: 0.36942694579999213d),

new NpgsqlTypes.NpgsqlLine(a: 0.05496271099682837d, b: 0.27117134563794d, c: 0.6062575109520318d),

new NpgsqlTypes.NpgsqlLine(a: 0.1282520642925976d, b: 0.7411802002989948d, c: 0.5444887763300745d),

new NpgsqlTypes.NpgsqlLine(a: 0.07653684321262022d, b: 0.5716603416585687d, c: 0.13663121664988753d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9448037581811078d, b: 0.15202980900835628d, c: 0.23828811655067372d),

new NpgsqlTypes.NpgsqlLine(a: 0.246302239352302d, b: 0.6220698561791467d, c: 0.23944207733886835d),

new NpgsqlTypes.NpgsqlLine(a: 0.2847243344703867d, b: 0.6181357950796338d, c: 0.48347901403940063d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04209950063987766d, b: 0.6987044203924414d, c: 0.03375033935768457d),

new NpgsqlTypes.NpgsqlLine(a: 0.23045543905050214d, b: 0.9662061621856199d, c: 0.2349551480849884d),

new NpgsqlTypes.NpgsqlLine(a: 0.5348767686574633d, b: 0.42703003562359d, c: 0.2786006481828496d),

new NpgsqlTypes.NpgsqlLine(a: 0.29717222535946364d, b: 0.07942692161799303d, c: 0.3490012601234176d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4831219084447226d, b: 0.09051581884734572d, c: 0.36709103504952845d),

new NpgsqlTypes.NpgsqlLine(a: 0.3306914838753259d, b: 0.540924527215016d, c: 0.18291754304466645d),

new NpgsqlTypes.NpgsqlLine(a: 0.0673082403697357d, b: 0.5918092419993259d, c: 0.015538496173476357d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.796627429680366d, b: 0.10524037498328487d, c: 0.4980772024823006d),

new NpgsqlTypes.NpgsqlLine(a: 0.19017066281512662d, b: 0.7471828448592448d, c: 0.16430839656507856d),

new NpgsqlTypes.NpgsqlLine(a: 0.34158908812186495d, b: 0.5069400931502515d, c: 0.8062754998095726d),

new NpgsqlTypes.NpgsqlLine(a: 0.17644339595104097d, b: 0.0636700981929541d, c: 0.25816115624804403d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23021147890784455d, b: 0.9735256485133765d, c: 0.05698127462224167d),

new NpgsqlTypes.NpgsqlLine(a: 0.24614562946947005d, b: 0.21273665623734705d, c: 0.31186099508075726d),

new NpgsqlTypes.NpgsqlLine(a: 0.4291448275151126d, b: 0.08089723451620634d, c: 0.8626619354537274d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5492791797065807d, b: 0.0007077758200905171d, c: 0.07762225338051731d),

new NpgsqlTypes.NpgsqlLine(a: 0.6674731936452383d, b: 0.16269812940828743d, c: 0.3579672718309491d),

new NpgsqlTypes.NpgsqlLine(a: 0.847168853328229d, b: 0.6682552869139744d, c: 0.6596875729544138d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4036002478542786d, b: 0.8954551925600991d, c: 0.04556539739329157d),

new NpgsqlTypes.NpgsqlLine(a: 0.5867203823381397d, b: 0.1563434060440838d, c: 0.9254968520832617d),

new NpgsqlTypes.NpgsqlLine(a: 0.8036577454491377d, b: 0.15701502288263292d, c: 0.40401933040538385d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15705969774801676d, b: 0.9667479364645676d, c: 0.24953976315546234d),

new NpgsqlTypes.NpgsqlLine(a: 0.7294326132545879d, b: 0.9903042555341177d, c: 0.2801584520827807d),

new NpgsqlTypes.NpgsqlLine(a: 0.6255862029992403d, b: 0.9031012111389384d, c: 0.3964917729364109d),

new NpgsqlTypes.NpgsqlLine(a: 0.6753123296963431d, b: 0.22627217029819535d, c: 0.42922393452238194d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9811027775720043d, b: 0.3565771444430822d, c: 0.24932530413057719d),

new NpgsqlTypes.NpgsqlLine(a: 0.8181047964586783d, b: 0.25924505537516973d, c: 0.3413556421986438d),

new NpgsqlTypes.NpgsqlLine(a: 0.26151244799382467d, b: 0.8232845600690226d, c: 0.657541631885113d),

new NpgsqlTypes.NpgsqlLine(a: 0.3528766184744536d, b: 0.331539439078838d, c: 0.5204399167969553d),

},
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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
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
                parametr2.Value = 17;
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
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
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 137, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
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
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatchAsync(connection, 97, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
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
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatch(connection, 115, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
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

