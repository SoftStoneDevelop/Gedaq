

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6862335921435314d,right: 0.8746377800256337d,bottom: 0.20888885854253936d,left: 0.5885225048169184d),
new NpgsqlTypes.NpgsqlBox(top: 0.5816412997662356d,right: 0.5920718116891621d,bottom: 0.06975602049724883d,left: 0.20433853543983405d),
new NpgsqlTypes.NpgsqlBox(top: 0.5417095329107127d,right: 0.46915625948664674d,bottom: 0.2625877883825577d,left: 0.3802943440997627d),
new NpgsqlTypes.NpgsqlBox(top: 0.390112599471533d,right: 0.9106120471302368d,bottom: 0.15052001641808344d,left: 0.5351388547147723d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9696807225129833d,right: 0.6013605644397114d,bottom: 0.9541016217520695d,left: 0.3117759956583811d),
new NpgsqlTypes.NpgsqlBox(top: 0.8159802664240172d,right: 0.7537358290990019d,bottom: 0.7250520747781932d,left: 0.649488447450268d),
new NpgsqlTypes.NpgsqlBox(top: 0.9984458480666737d,right: 0.8313951643092521d,bottom: 0.7125692251142843d,left: 0.6846044388465279d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9742087626601547d,right: 0.7773460442657373d,bottom: 0.12668689290166635d,left: 0.49099436655616546d),
new NpgsqlTypes.NpgsqlBox(top: 0.7352984187443403d,right: 0.7618545308569078d,bottom: 0.4342232094672731d,left: 0.06694205330941394d),
new NpgsqlTypes.NpgsqlBox(top: 0.8024262069118002d,right: 0.9511423205877633d,bottom: 0.1890175845662454d,left: 0.1799219097103717d),
new NpgsqlTypes.NpgsqlBox(top: 0.6807537559355642d,right: 0.8617633174842626d,bottom: 0.12714358096301426d,left: 0.08990813824633104d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3296938441672751d,right: 0.9437095128816937d,bottom: 0.15172494811678872d,left: 0.5846948315563514d),
new NpgsqlTypes.NpgsqlBox(top: 0.7954917266975186d,right: 0.7121330294505965d,bottom: 0.3383778731634691d,left: 0.035089481775632425d),
new NpgsqlTypes.NpgsqlBox(top: 0.34406712630856384d,right: 0.28769900888591615d,bottom: 0.20866111544714805d,left: 0.23441578172276922d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9764926877379526d,right: 0.5702064035076997d,bottom: 0.6162194969668316d,left: 0.5579344821934132d),
new NpgsqlTypes.NpgsqlBox(top: 0.30245943533566344d,right: 0.29449898193883806d,bottom: 0.1886201959224445d,left: 0.07262438125610493d),
new NpgsqlTypes.NpgsqlBox(top: 0.29357200757638324d,right: 0.8521503374896963d,bottom: 0.017542440968849826d,left: 0.6643233187701396d),
new NpgsqlTypes.NpgsqlBox(top: 0.8656774798624355d,right: 0.9271256650421913d,bottom: 0.2739723812436793d,left: 0.8531754879951264d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3825296338068558d,right: 0.9364094403127826d,bottom: 0.293062772892976d,left: 0.09053665841835778d),
new NpgsqlTypes.NpgsqlBox(top: 0.6188736677376601d,right: 0.7251323478874667d,bottom: 0.36154064230985394d,left: 0.4851713852700704d),
new NpgsqlTypes.NpgsqlBox(top: 0.19804761662000536d,right: 0.1782913448371919d,bottom: 0.1715931924749643d,left: 0.11585036316221375d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3504666450862347d,right: 0.9209278050247064d,bottom: 0.059039053545946185d,left: 0.7159960157393574d),
new NpgsqlTypes.NpgsqlBox(top: 0.9189547447267093d,right: 0.8759242181590627d,bottom: 0.17845715369526527d,left: 0.29392523237826873d),
new NpgsqlTypes.NpgsqlBox(top: 0.4412782959156649d,right: 0.3711550624160085d,bottom: 0.18706149330525046d,left: 0.22283616226027936d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8731518405904841d,right: 0.18254198798743393d,bottom: 0.42378354122844286d,left: 0.16755337522906355d),
new NpgsqlTypes.NpgsqlBox(top: 0.4799021783295674d,right: 0.15183133595191378d,bottom: 0.412288369912998d,left: 0.0021603688657217957d),
new NpgsqlTypes.NpgsqlBox(top: 0.4365346226947817d,right: 0.5802873337332405d,bottom: 0.11473022031906344d,left: 0.007818518965427956d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4335264493197445d,right: 0.3567589254421185d,bottom: 0.11281920546924884d,left: 0.04520135502746392d),
new NpgsqlTypes.NpgsqlBox(top: 0.6699816548121774d,right: 0.5742760479190404d,bottom: 0.09169731117775681d,left: 0.48443192817238223d),
new NpgsqlTypes.NpgsqlBox(top: 0.7806881066325038d,right: 0.9024999474121354d,bottom: 0.5000651245491662d,left: 0.7050302748656121d),
new NpgsqlTypes.NpgsqlBox(top: 0.3560903248155728d,right: 0.7691424467893205d,bottom: 0.10368566978993643d,left: 0.7333791334474555d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.24670786383573529d,right: 0.08320784581563112d,bottom: 0.17204542229381703d,left: 0.005170045565614956d),
new NpgsqlTypes.NpgsqlBox(top: 0.8984112411701918d,right: 0.7964718179735291d,bottom: 0.251308661522606d,left: 0.729579135776104d),
new NpgsqlTypes.NpgsqlBox(top: 0.7521658004666549d,right: 0.4435108330680345d,bottom: 0.12354968467646443d,left: 0.3855042068567326d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9858551109454967d,right: 0.9416973293829358d,bottom: 0.8170612376958399d,left: 0.5371748949998665d),
new NpgsqlTypes.NpgsqlBox(top: 0.5565067985994901d,right: 0.5656861576483029d,bottom: 0.05617899974512286d,left: 0.5460243361697791d),
new NpgsqlTypes.NpgsqlBox(top: 0.5171958184161459d,right: 0.5653579058775711d,bottom: 0.17964234528790202d,left: 0.0894545724100736d),
new NpgsqlTypes.NpgsqlBox(top: 0.7207346989489479d,right: 0.8480580511451054d,bottom: 0.15273795477875762d,left: 0.6752982060541448d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9306982806841326d,right: 0.6801575934382742d,bottom: 0.18457578865042779d,left: 0.6757822028113758d),
new NpgsqlTypes.NpgsqlBox(top: 0.5484909884089214d,right: 0.8568968329703263d,bottom: 0.10299382534794332d,left: 0.19545609044338075d),
new NpgsqlTypes.NpgsqlBox(top: 0.7029149044419573d,right: 0.7472577751442802d,bottom: 0.4223284533985552d,left: 0.5433205603767315d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5184395081694854d,right: 0.7941730612430159d,bottom: 0.16211426857018574d,left: 0.4344704292324263d),
new NpgsqlTypes.NpgsqlBox(top: 0.1692215033457498d,right: 0.8903832780532763d,bottom: 0.032695005233223884d,left: 0.5421314471314147d),
new NpgsqlTypes.NpgsqlBox(top: 0.4711521692203988d,right: 0.9935467736241628d,bottom: 0.311038729951435d,left: 0.16819830119321932d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7722989451808632d,right: 0.8878158595289197d,bottom: 0.745407450013455d,left: 0.8006749968780972d),
new NpgsqlTypes.NpgsqlBox(top: 0.9739413747803952d,right: 0.6601552503307809d,bottom: 0.06970948919334252d,left: 0.6412685034087794d),
new NpgsqlTypes.NpgsqlBox(top: 0.2770858793254065d,right: 0.8494308778984243d,bottom: 0.12882398933649097d,left: 0.0834255898999362d),
new NpgsqlTypes.NpgsqlBox(top: 0.317667867051748d,right: 0.8843177132594728d,bottom: 0.2557913536307953d,left: 0.6098696739520229d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8453439461812355d,right: 0.5895956005361764d,bottom: 0.5048766287266904d,left: 0.48765353477868856d),
new NpgsqlTypes.NpgsqlBox(top: 0.7076682908824551d,right: 0.40125323144074965d,bottom: 0.47295460064607575d,left: 0.35767071249994975d),
new NpgsqlTypes.NpgsqlBox(top: 0.09998039853034435d,right: 0.856001504050584d,bottom: 0.03407249596962458d,left: 0.14027315192166712d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8124291184688858d,right: 0.8420025416093807d,bottom: 0.43414918536991043d,left: 0.5053609690900133d),
new NpgsqlTypes.NpgsqlBox(top: 0.7714375092836735d,right: 0.8908613204719715d,bottom: 0.09984503702672654d,left: 0.5544172922460066d),
new NpgsqlTypes.NpgsqlBox(top: 0.7738760510301351d,right: 0.9075872657779573d,bottom: 0.39676537075541707d,left: 0.022039065263088853d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7639430053641605d,right: 0.7634948447949518d,bottom: 0.08330000662441372d,left: 0.4076445959526095d),
new NpgsqlTypes.NpgsqlBox(top: 0.8469060609398311d,right: 0.5774835813722029d,bottom: 0.11032301229131136d,left: 0.4582308224907481d),
new NpgsqlTypes.NpgsqlBox(top: 0.6800697247634694d,right: 0.9148873911095894d,bottom: 0.6299190003026692d,left: 0.6143765300945085d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7943453016715515d,right: 0.2744675782118955d,bottom: 0.4912635987794616d,left: 0.20910059177496076d),
new NpgsqlTypes.NpgsqlBox(top: 0.8460237413048323d,right: 0.7127835460826151d,bottom: 0.02013536710578856d,left: 0.047802680818074705d),
new NpgsqlTypes.NpgsqlBox(top: 0.5361037259768455d,right: 0.3767805493726216d,bottom: 0.14894805971713376d,left: 0.03195721419897424d),
new NpgsqlTypes.NpgsqlBox(top: 0.504679767824578d,right: 0.7206081472829028d,bottom: 0.30164686038137034d,left: 0.2714073496407995d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5870538572720911d,right: 0.2810358450193611d,bottom: 0.4644160974737199d,left: 0.03526844969103338d),
new NpgsqlTypes.NpgsqlBox(top: 0.992946945264478d,right: 0.4901454804967973d,bottom: 0.5883257582375573d,left: 0.26750150052529975d),
new NpgsqlTypes.NpgsqlBox(top: 0.5969308984467847d,right: 0.8838992581973927d,bottom: 0.3735520390745679d,left: 0.1345295155889341d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6779406175378356d,right: 0.9519387406317403d,bottom: 0.1799050050187485d,left: 0.011007409113232725d),
new NpgsqlTypes.NpgsqlBox(top: 0.8806197244063461d,right: 0.9950247540438897d,bottom: 0.12322522999022945d,left: 0.4593217066078188d),
new NpgsqlTypes.NpgsqlBox(top: 0.6634197937096803d,right: 0.2533444679864405d,bottom: 0.5089768733257761d,left: 0.10317785145519409d),
new NpgsqlTypes.NpgsqlBox(top: 0.9661075730718995d,right: 0.8534809386149139d,bottom: 0.2604680956234082d,left: 0.5197863979399417d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5918267127755382d,right: 0.5132808228390969d,bottom: 0.08034163473729938d,left: 0.27518550575941236d),
new NpgsqlTypes.NpgsqlBox(top: 0.9934538110610162d,right: 0.7185733189233723d,bottom: 0.41009491095492123d,left: 0.05711145394015715d),
new NpgsqlTypes.NpgsqlBox(top: 0.9067206431937336d,right: 0.9857493715984106d,bottom: 0.0715672298554757d,left: 0.4588460870454676d),
new NpgsqlTypes.NpgsqlBox(top: 0.8787633620502798d,right: 0.4217146197004207d,bottom: 0.7679636021418422d,left: 0.1129972058948272d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7080720077197505d,right: 0.6174921790345286d,bottom: 0.6626652112503464d,left: 0.28973153656856354d),
new NpgsqlTypes.NpgsqlBox(top: 0.7790784810795011d,right: 0.5056838936060668d,bottom: 0.33500758684703946d,left: 0.288421841835942d),
new NpgsqlTypes.NpgsqlBox(top: 0.5168957914330827d,right: 0.559323774169593d,bottom: 0.35781410514234113d,left: 0.2852483353891242d),
new NpgsqlTypes.NpgsqlBox(top: 0.3000223368184399d,right: 0.9672762728948743d,bottom: 0.1830819830302698d,left: 0.609718196252999d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.932916465990647d,right: 0.7929691357742576d,bottom: 0.1302899942185004d,left: 0.4689547382515743d),
new NpgsqlTypes.NpgsqlBox(top: 0.9041525119471022d,right: 0.8607542949925641d,bottom: 0.7799487363638905d,left: 0.20803674537495187d),
new NpgsqlTypes.NpgsqlBox(top: 0.9085572235477761d,right: 0.715232083168791d,bottom: 0.3455581787548575d,left: 0.08275822843128522d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4489486915431291d,right: 0.9528531278565718d,bottom: 0.06892844528888398d,left: 0.48379252948988505d),
new NpgsqlTypes.NpgsqlBox(top: 0.8917690839622046d,right: 0.5259388709110806d,bottom: 0.2987890657335217d,left: 0.04147572115624576d),
new NpgsqlTypes.NpgsqlBox(top: 0.6462459889726249d,right: 0.2391657372839625d,bottom: 0.4272365674123484d,left: 0.0950572991415557d),
new NpgsqlTypes.NpgsqlBox(top: 0.2240268213026828d,right: 0.20179123928929332d,bottom: 0.09721094229865346d,left: 0.14353882948739216d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7246849281315462d,right: 0.974502657397499d,bottom: 0.0866745854242853d,left: 0.5061437066800694d),
new NpgsqlTypes.NpgsqlBox(top: 0.3257773991514453d,right: 0.1716313868345023d,bottom: 0.21130809783161075d,left: 0.15899084882775383d),
new NpgsqlTypes.NpgsqlBox(top: 0.39478944258641535d,right: 0.7625069357211597d,bottom: 0.13083361625808532d,left: 0.2963215139699755d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3381889591063877d,right: 0.5105861197704002d,bottom: 0.25090632506091426d,left: 0.3509269902032002d),
new NpgsqlTypes.NpgsqlBox(top: 0.8351567375575164d,right: 0.9586587972859985d,bottom: 0.768707281866866d,left: 0.7620630866723361d),
new NpgsqlTypes.NpgsqlBox(top: 0.9624902027985952d,right: 0.6119915500312959d,bottom: 0.45129926657077024d,left: 0.06487793871286895d),
new NpgsqlTypes.NpgsqlBox(top: 0.7504391373069546d,right: 0.9177104882798053d,bottom: 0.701801165930545d,left: 0.28290954314974237d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9378235745697813d,right: 0.7239781810322814d,bottom: 0.19728202809265882d,left: 0.2348252328480639d),
new NpgsqlTypes.NpgsqlBox(top: 0.6614659899355144d,right: 0.9123462566798974d,bottom: 0.5115504448583016d,left: 0.03981659533546378d),
new NpgsqlTypes.NpgsqlBox(top: 0.9738117221534933d,right: 0.7571926570029853d,bottom: 0.31239033761360857d,left: 0.34446915493662733d),
new NpgsqlTypes.NpgsqlBox(top: 0.7098674608799492d,right: 0.922258989830834d,bottom: 0.04183191403330122d,left: 0.5206200163813682d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8562516360587743d,right: 0.9228127769779311d,bottom: 0.20746843448938457d,left: 0.5061571790210394d),
new NpgsqlTypes.NpgsqlBox(top: 0.6004567684946843d,right: 0.9954518908579233d,bottom: 0.1757893522909887d,left: 0.6570371180266263d),
new NpgsqlTypes.NpgsqlBox(top: 0.7904129025603864d,right: 0.8786537240304384d,bottom: 0.6527996247831395d,left: 0.011988578412447048d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5693193621263328d,right: 0.9642421614944647d,bottom: 0.2691686276693751d,left: 0.7148692115598886d),
new NpgsqlTypes.NpgsqlBox(top: 0.7714303299529823d,right: 0.5822642357197921d,bottom: 0.5394829319138704d,left: 0.5131479969913326d),
new NpgsqlTypes.NpgsqlBox(top: 0.7107326526289282d,right: 0.6199289880938031d,bottom: 0.3475344216359193d,left: 0.08956918629171207d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7950882688195979d,right: 0.9290291543512377d,bottom: 0.7435911015203991d,left: 0.1780856011912162d),
new NpgsqlTypes.NpgsqlBox(top: 0.07201628097262847d,right: 0.9675587425756963d,bottom: 0.052607644950366406d,left: 0.4791889474355082d),
new NpgsqlTypes.NpgsqlBox(top: 0.6061491779484575d,right: 0.5489143863262529d,bottom: 0.5744560722742839d,left: 0.012270296552975957d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.19657433810080638d,right: 0.7415109614782129d,bottom: 0.012701625464298205d,left: 0.4185340684709239d),
new NpgsqlTypes.NpgsqlBox(top: 0.4364622608511025d,right: 0.7513452914636519d,bottom: 0.16013445688817307d,left: 0.6415879754070373d),
new NpgsqlTypes.NpgsqlBox(top: 0.9108561455951304d,right: 0.9918217194153817d,bottom: 0.7858529426170168d,left: 0.05124669368903878d),
new NpgsqlTypes.NpgsqlBox(top: 0.9925329660603283d,right: 0.24984930833350327d,bottom: 0.8062048345674907d,left: 0.09780435454450942d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.957879448468032d,right: 0.818904476266668d,bottom: 0.14375624316856717d,left: 0.41741592896270696d),
new NpgsqlTypes.NpgsqlBox(top: 0.9058721289491809d,right: 0.5050460792160988d,bottom: 0.6115032044910752d,left: 0.16292664308638272d),
new NpgsqlTypes.NpgsqlBox(top: 0.4944062897855679d,right: 0.7714179713317579d,bottom: 0.3610065978328354d,left: 0.29967081214556635d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6636902920991509d,right: 0.786917542913819d,bottom: 0.1067461964230868d,left: 0.38148595891594617d),
new NpgsqlTypes.NpgsqlBox(top: 0.9275390106517916d,right: 0.3643560691005858d,bottom: 0.18444522031736799d,left: 0.3382881339524072d),
new NpgsqlTypes.NpgsqlBox(top: 0.747935779248713d,right: 0.7511307248980424d,bottom: 0.10132276453256439d,left: 0.7009942275391916d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5817931396632944d,right: 0.5625995198631937d,bottom: 0.130573821112153d,left: 0.12223593160593571d),
new NpgsqlTypes.NpgsqlBox(top: 0.9365624482061399d,right: 0.5446559077819008d,bottom: 0.7894264038212155d,left: 0.11981151358593689d),
new NpgsqlTypes.NpgsqlBox(top: 0.9874954918665984d,right: 0.6732073678049776d,bottom: 0.33449938102834154d,left: 0.21224936614047918d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5553121582151082d,right: 0.6554169320064334d,bottom: 0.34880118936401594d,left: 0.19987187137412465d),
new NpgsqlTypes.NpgsqlBox(top: 0.728446918981814d,right: 0.8825387339304751d,bottom: 0.5388347528668089d,left: 0.3817250874602772d),
new NpgsqlTypes.NpgsqlBox(top: 0.40103187725458667d,right: 0.16927113929829318d,bottom: 0.39708961361167605d,left: 0.04388347211840671d),
new NpgsqlTypes.NpgsqlBox(top: 0.5133908646026146d,right: 0.8489383530498567d,bottom: 0.4362693534934613d,left: 0.7820290956359027d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.681647527796951d,right: 0.7234199543724806d,bottom: 0.49357961691820595d,left: 0.12720055555223353d),
new NpgsqlTypes.NpgsqlBox(top: 0.9187208287632129d,right: 0.916325110266243d,bottom: 0.7143888958106033d,left: 0.76627541970951d),
new NpgsqlTypes.NpgsqlBox(top: 0.5962623958234574d,right: 0.5886369738100249d,bottom: 0.4579909270101338d,left: 0.05523095056209337d),
new NpgsqlTypes.NpgsqlBox(top: 0.7735629025579039d,right: 0.9893219800253776d,bottom: 0.148791174498079d,left: 0.27194124737211134d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6313531638495843d,right: 0.6398898234614139d,bottom: 0.38351388479653004d,left: 0.5897573615398501d),
new NpgsqlTypes.NpgsqlBox(top: 0.7552519402456083d,right: 0.5267033749390895d,bottom: 0.3583487902848048d,left: 0.402552239638833d),
new NpgsqlTypes.NpgsqlBox(top: 0.8729594973383484d,right: 0.3440303782809351d,bottom: 0.565201736037404d,left: 0.28369605386793384d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7453074057737218d,right: 0.9367436415107032d,bottom: 0.2991483882880672d,left: 0.2998519336331543d),
new NpgsqlTypes.NpgsqlBox(top: 0.16401612983446123d,right: 0.9021317261434573d,bottom: 0.07440647893444419d,left: 0.0663729179189313d),
new NpgsqlTypes.NpgsqlBox(top: 0.6383424549630232d,right: 0.721443862587529d,bottom: 0.33631314312757776d,left: 0.5146522992721223d),
new NpgsqlTypes.NpgsqlBox(top: 0.5054872791771883d,right: 0.6078974950508106d,bottom: 0.3554052602894734d,left: 0.4205974575152185d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8584199300829519d,right: 0.9664058608897707d,bottom: 0.14914354542097386d,left: 0.5900207232972848d),
new NpgsqlTypes.NpgsqlBox(top: 0.4717085023042752d,right: 0.7125125327623376d,bottom: 0.1723626777489401d,left: 0.06330010445279732d),
new NpgsqlTypes.NpgsqlBox(top: 0.8130588433417827d,right: 0.89871107804564d,bottom: 0.8105566708197767d,left: 0.08332228133479835d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5752174298299728d,right: 0.6732218547418833d,bottom: 0.4273015967051351d,left: 0.530828505591892d),
new NpgsqlTypes.NpgsqlBox(top: 0.9558427653195846d,right: 0.39643573166369483d,bottom: 0.5699921934811928d,left: 0.1344206064388187d),
new NpgsqlTypes.NpgsqlBox(top: 0.8891052556061685d,right: 0.3710161059625119d,bottom: 0.007616768620098968d,left: 0.3150556047083185d),
new NpgsqlTypes.NpgsqlBox(top: 0.9486675518173384d,right: 0.8423282502585897d,bottom: 0.7576823275659248d,left: 0.6502970398996901d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2758981461122191d,right: 0.8047460610077737d,bottom: 0.16744861032918823d,left: 0.27767776262065536d),
new NpgsqlTypes.NpgsqlBox(top: 0.48687746523054753d,right: 0.29900505886423d,bottom: 0.2347162700176605d,left: 0.03894542925141797d),
new NpgsqlTypes.NpgsqlBox(top: 0.9747528307592517d,right: 0.43974097816977364d,bottom: 0.6622616886634787d,left: 0.08914740390394227d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8989783411244986d,right: 0.5652327334712001d,bottom: 0.4037678776664171d,left: 0.30418842988603134d),
new NpgsqlTypes.NpgsqlBox(top: 0.7685351830547394d,right: 0.7980322036813267d,bottom: 0.11240006433999827d,left: 0.6535297898693168d),
new NpgsqlTypes.NpgsqlBox(top: 0.6571977623200242d,right: 0.9126615946200252d,bottom: 0.6221954167422268d,left: 0.005512861785839207d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.46869989592704187d,right: 0.10432462249266305d,bottom: 0.06461308074701977d,left: 0.07841495548378175d),
new NpgsqlTypes.NpgsqlBox(top: 0.3494256417314199d,right: 0.8973533937704247d,bottom: 0.1343222004401562d,left: 0.15342769723539074d),
new NpgsqlTypes.NpgsqlBox(top: 0.6500214534944382d,right: 0.8120846472876243d,bottom: 0.0068368006911158075d,left: 0.4155576272878878d),
new NpgsqlTypes.NpgsqlBox(top: 0.8626307582018125d,right: 0.8353175093023805d,bottom: 0.601163460345325d,left: 0.7972679000280702d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.913343337688708d,right: 0.3618104439479156d,bottom: 0.2980873277933187d,left: 0.29262308527131076d),
new NpgsqlTypes.NpgsqlBox(top: 0.8005507155163317d,right: 0.5679626478662853d,bottom: 0.09064824368785518d,left: 0.1990337588592016d),
new NpgsqlTypes.NpgsqlBox(top: 0.8935813408983103d,right: 0.9948879507157499d,bottom: 0.09568521804924934d,left: 0.3948015192729386d),
new NpgsqlTypes.NpgsqlBox(top: 0.6420186083886805d,right: 0.5519768069746899d,bottom: 0.3676836529851608d,left: 0.09536338520827514d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49423378477743507d,right: 0.6333076923053421d,bottom: 0.36719553049662546d,left: 0.12809363390168427d),
new NpgsqlTypes.NpgsqlBox(top: 0.47438824397507495d,right: 0.6016060870010506d,bottom: 0.4462822565516672d,left: 0.36385749841606996d),
new NpgsqlTypes.NpgsqlBox(top: 0.04692679014122181d,right: 0.28933777542554373d,bottom: 0.02676180558450736d,left: 0.14008724275987305d),
new NpgsqlTypes.NpgsqlBox(top: 0.7761822384472361d,right: 0.25806684292124116d,bottom: 0.6841968205659212d,left: 0.18261375602142327d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6430045151063646d,right: 0.460667578236141d,bottom: 0.6127898617128694d,left: 0.43957419923828867d),
new NpgsqlTypes.NpgsqlBox(top: 0.8989704017374117d,right: 0.9773051830272773d,bottom: 0.53814510508038d,left: 0.3145586549576982d),
new NpgsqlTypes.NpgsqlBox(top: 0.2764877139625326d,right: 0.5918293234169588d,bottom: 0.12374098321766147d,left: 0.53657349805087d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9627144048467144d,right: 0.9776923374258328d,bottom: 0.9215496124649021d,left: 0.11782874689182432d),
new NpgsqlTypes.NpgsqlBox(top: 0.6160981584770533d,right: 0.38989792236650145d,bottom: 0.12742770580251062d,left: 0.36106501735719054d),
new NpgsqlTypes.NpgsqlBox(top: 0.21771110236375713d,right: 0.8190861446674331d,bottom: 0.11995268981968399d,left: 0.028634063299071366d),
new NpgsqlTypes.NpgsqlBox(top: 0.6019276577864914d,right: 0.5966195064073281d,bottom: 0.5720640042523378d,left: 0.5132275600274326d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9892584711781d,right: 0.8979215190133902d,bottom: 0.5408615077795048d,left: 0.8369759708762768d),
new NpgsqlTypes.NpgsqlBox(top: 0.32529752838432524d,right: 0.8356179735404596d,bottom: 0.020030797830567826d,left: 0.3501932797803001d),
new NpgsqlTypes.NpgsqlBox(top: 0.8643210930855749d,right: 0.8695037675415471d,bottom: 0.5873261558540533d,left: 0.7857304505541906d),
new NpgsqlTypes.NpgsqlBox(top: 0.3208364901629439d,right: 0.770294968149136d,bottom: 0.18784514296075694d,left: 0.40881659612718113d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.46730834564347246d,right: 0.5311999180380376d,bottom: 0.3277559893954761d,left: 0.13042847456945017d),
new NpgsqlTypes.NpgsqlBox(top: 0.787798070610908d,right: 0.44073333703478d,bottom: 0.7803360264262964d,left: 0.3849371413815572d),
new NpgsqlTypes.NpgsqlBox(top: 0.32589600255806794d,right: 0.2632893665898548d,bottom: 0.04020216040351121d,left: 0.1121610930410385d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9422398254449394d,right: 0.6724238403975052d,bottom: 0.07668146886805016d,left: 0.43054834599486425d),
new NpgsqlTypes.NpgsqlBox(top: 0.3480279703826191d,right: 0.6741316238313619d,bottom: 0.1765807431166534d,left: 0.44913903707116554d),
new NpgsqlTypes.NpgsqlBox(top: 0.6165310203425117d,right: 0.9137742756557001d,bottom: 0.37320143125805005d,left: 0.7779180132789543d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8177733397271972d,right: 0.22236153253798618d,bottom: 0.24761755865074675d,left: 0.049630281828598855d),
new NpgsqlTypes.NpgsqlBox(top: 0.32771874449747274d,right: 0.6087265580827502d,bottom: 0.23067125436918234d,left: 0.538103786310281d),
new NpgsqlTypes.NpgsqlBox(top: 0.6642270978712345d,right: 0.47191211733268057d,bottom: 0.6605342989379172d,left: 0.3518051952868827d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.865777783486726d,right: 0.5965876009949402d,bottom: 0.33777468222926843d,left: 0.4146600244992621d),
new NpgsqlTypes.NpgsqlBox(top: 0.5189302868800852d,right: 0.6913986245466485d,bottom: 0.3775396102381797d,left: 0.6456314128672875d),
new NpgsqlTypes.NpgsqlBox(top: 0.7612851505590233d,right: 0.3238470035649499d,bottom: 0.010571667701922083d,left: 0.27115903025880217d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1728392435151287d,right: 0.798487156701d,bottom: 0.09742179750301139d,left: 0.42097004205159727d),
new NpgsqlTypes.NpgsqlBox(top: 0.9903429736596361d,right: 0.16409948069468627d,bottom: 0.862829834466987d,left: 0.02360695939378188d),
new NpgsqlTypes.NpgsqlBox(top: 0.6335995618124629d,right: 0.9639986036403799d,bottom: 0.3290032084080048d,left: 0.818173783124764d),
new NpgsqlTypes.NpgsqlBox(top: 0.19806887685013475d,right: 0.9169666596278895d,bottom: 0.11972495743106848d,left: 0.8509405021715463d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9170244930660232d,right: 0.4351634252355141d,bottom: 0.3142927656991197d,left: 0.11419452711467959d),
new NpgsqlTypes.NpgsqlBox(top: 0.6238151687832214d,right: 0.7742320089489145d,bottom: 0.23462733521286117d,left: 0.023877333223137565d),
new NpgsqlTypes.NpgsqlBox(top: 0.8021243756456032d,right: 0.5224153426970161d,bottom: 0.4426518154954907d,left: 0.46455664963313115d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9820781542992378d,right: 0.15825934444983925d,bottom: 0.05092077681655571d,left: 0.1507063741130733d),
new NpgsqlTypes.NpgsqlBox(top: 0.21143714083101983d,right: 0.7086581683519066d,bottom: 0.08493560194828231d,left: 0.02580589512261211d),
new NpgsqlTypes.NpgsqlBox(top: 0.8344131909804444d,right: 0.29095298270797854d,bottom: 0.30424956872184405d,left: 0.12038948876861921d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8514180138858576d,right: 0.6855232513710245d,bottom: 0.3444670944759127d,left: 0.045898928340074696d),
new NpgsqlTypes.NpgsqlBox(top: 0.4380994343970037d,right: 0.8279802900735533d,bottom: 0.05870060743461336d,left: 0.16342104404935032d),
new NpgsqlTypes.NpgsqlBox(top: 0.5299803720752824d,right: 0.4745815829583542d,bottom: 0.2737106790682642d,left: 0.3076309476044953d),
new NpgsqlTypes.NpgsqlBox(top: 0.9104080844349669d,right: 0.6280831474204718d,bottom: 0.6952111177417167d,left: 0.5274721619658318d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7213290419508047d,right: 0.7618742987706553d,bottom: 0.06926199869357064d,left: 0.41698766847652d),
new NpgsqlTypes.NpgsqlBox(top: 0.464750971373067d,right: 0.09406939999921304d,bottom: 0.3422518830808622d,left: 0.08801982194960145d),
new NpgsqlTypes.NpgsqlBox(top: 0.9152430292811846d,right: 0.7225977305405246d,bottom: 0.4016370633042581d,left: 0.17589947308481235d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.13780242773234963d,right: 0.8202444229291166d,bottom: 0.12765327581328412d,left: 0.6435673629151314d),
new NpgsqlTypes.NpgsqlBox(top: 0.503340887399148d,right: 0.7425079481888504d,bottom: 0.13665014402742848d,left: 0.653212882614499d),
new NpgsqlTypes.NpgsqlBox(top: 0.35611553006278096d,right: 0.3668126480197972d,bottom: 0.23082018267122184d,left: 0.0168256528202676d),
new NpgsqlTypes.NpgsqlBox(top: 0.9162149186275276d,right: 0.07386316697705408d,bottom: 0.22477834309872535d,left: 0.03857233184251929d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8989734308796048d,right: 0.6441153087262471d,bottom: 0.7291098711759519d,left: 0.5384925861074117d),
new NpgsqlTypes.NpgsqlBox(top: 0.8961463654714581d,right: 0.38388699467612286d,bottom: 0.2306422798651735d,left: 0.08864608283722575d),
new NpgsqlTypes.NpgsqlBox(top: 0.6400429698267951d,right: 0.23156805286604654d,bottom: 0.15978093099008328d,left: 0.07388852247070576d),
new NpgsqlTypes.NpgsqlBox(top: 0.944688740258067d,right: 0.6162169853952663d,bottom: 0.574183559061293d,left: 0.49723265417799056d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5701221485504652d,right: 0.694727676211134d,bottom: 0.27792043431483404d,left: 0.24457892559281746d),
new NpgsqlTypes.NpgsqlBox(top: 0.9171655951615496d,right: 0.8717955295907822d,bottom: 0.46804239742039033d,left: 0.4836232691143021d),
new NpgsqlTypes.NpgsqlBox(top: 0.32328730127665595d,right: 0.6581687468984544d,bottom: 0.2266628465869619d,left: 0.4473913244495298d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3025763473364268d,right: 0.08050985960033086d,bottom: 0.26554171377696145d,left: 0.027653092514210442d),
new NpgsqlTypes.NpgsqlBox(top: 0.8171442749819039d,right: 0.3827428293543388d,bottom: 0.35584571986583213d,left: 0.23670155954729766d),
new NpgsqlTypes.NpgsqlBox(top: 0.9703586251700917d,right: 0.8812075507365025d,bottom: 0.8321466631688228d,left: 0.21807287967165367d),
new NpgsqlTypes.NpgsqlBox(top: 0.9219859752640686d,right: 0.7982932192120445d,bottom: 0.4585311275231596d,left: 0.5400563698022582d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8381303225398445d,right: 0.9026713979561887d,bottom: 0.30044001371428075d,left: 0.7735535113773417d),
new NpgsqlTypes.NpgsqlBox(top: 0.6519863331437021d,right: 0.23168661811294866d,bottom: 0.06943990703550817d,left: 0.16328555609300677d),
new NpgsqlTypes.NpgsqlBox(top: 0.8287772145993033d,right: 0.9068517361357256d,bottom: 0.8192525997619989d,left: 0.2538751969284123d),
new NpgsqlTypes.NpgsqlBox(top: 0.6104187412381464d,right: 0.7803017657712347d,bottom: 0.6062103701485201d,left: 0.31311393585619607d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6420528301550109d,right: 0.6918578549302271d,bottom: 0.515796781167169d,left: 0.601512335858686d),
new NpgsqlTypes.NpgsqlBox(top: 0.4372780828800604d,right: 0.6197406880374953d,bottom: 0.3590631975891819d,left: 0.05643910175446032d),
new NpgsqlTypes.NpgsqlBox(top: 0.7097856848413625d,right: 0.5952662319280843d,bottom: 0.230832957522199d,left: 0.2670039350365787d),
new NpgsqlTypes.NpgsqlBox(top: 0.8243356687520775d,right: 0.8542055559855357d,bottom: 0.26167913298439993d,left: 0.6342261192324486d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4287721192230375d,right: 0.6341442704894116d,bottom: 0.22796617622604143d,left: 0.322247920467605d),
new NpgsqlTypes.NpgsqlBox(top: 0.27495804680858893d,right: 0.684803503797243d,bottom: 0.12443968879634437d,left: 0.1444309477656306d),
new NpgsqlTypes.NpgsqlBox(top: 0.7598387967745978d,right: 0.90984239820948d,bottom: 0.004601804600585568d,left: 0.20654100776813056d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9948820765131212d,right: 0.9608480627233348d,bottom: 0.44269213454940526d,left: 0.9007311207185945d),
new NpgsqlTypes.NpgsqlBox(top: 0.17785763079156358d,right: 0.8883804906367733d,bottom: 0.1281674867239203d,left: 0.13335958569036954d),
new NpgsqlTypes.NpgsqlBox(top: 0.32310340939751536d,right: 0.5282150981650459d,bottom: 0.02404277249893816d,left: 0.16603328698557684d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3525329794731368d,right: 0.2771913163248302d,bottom: 0.2634831729687611d,left: 0.10738818154526175d),
new NpgsqlTypes.NpgsqlBox(top: 0.9174556456514895d,right: 0.9739960437632507d,bottom: 0.011550147976211123d,left: 0.3780680139475012d),
new NpgsqlTypes.NpgsqlBox(top: 0.8832795884961235d,right: 0.3371542633064897d,bottom: 0.266626233160004d,left: 0.22267289414998948d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.653724112825636d,right: 0.5347759719445914d,bottom: 0.30074374025269535d,left: 0.044270121713812505d),
new NpgsqlTypes.NpgsqlBox(top: 0.9789198723176964d,right: 0.5530460256671229d,bottom: 0.8074654326517692d,left: 0.41155140065382845d),
new NpgsqlTypes.NpgsqlBox(top: 0.7584872448876075d,right: 0.699368050313137d,bottom: 0.11773361483563738d,left: 0.22128233641526585d),
new NpgsqlTypes.NpgsqlBox(top: 0.8424903828771056d,right: 0.14602798907229741d,bottom: 0.8094720509204849d,left: 0.11444985792175388d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.15704258337851307d,right: 0.7305708495472556d,bottom: 0.09504831019374138d,left: 0.6160218844029857d),
new NpgsqlTypes.NpgsqlBox(top: 0.9882785201409746d,right: 0.12904549325684234d,bottom: 0.38897088983544204d,left: 0.05593128785119483d),
new NpgsqlTypes.NpgsqlBox(top: 0.955334356032858d,right: 0.6728814704369674d,bottom: 0.013513764799029881d,left: 0.5246493583557486d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7660131482950043d,right: 0.7573772605167618d,bottom: 0.29809656618910263d,left: 0.15667260697733432d),
new NpgsqlTypes.NpgsqlBox(top: 0.4532814488439775d,right: 0.557570901082577d,bottom: 0.38540677976669657d,left: 0.23981623682670827d),
new NpgsqlTypes.NpgsqlBox(top: 0.7270308997311865d,right: 0.7444863201884658d,bottom: 0.4427154938037272d,left: 0.3054002826256198d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.45876970329203115d,right: 0.7773115278283003d,bottom: 0.22823301384046457d,left: 0.6563587538201276d),
new NpgsqlTypes.NpgsqlBox(top: 0.8738498316918993d,right: 0.8997925272192945d,bottom: 0.24915695851292596d,left: 0.1411064331098889d),
new NpgsqlTypes.NpgsqlBox(top: 0.13071394575781292d,right: 0.11590231173770982d,bottom: 0.016979417411727926d,left: 0.0659763108850212d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8367739705464649d,right: 0.5436355642312398d,bottom: 0.0006508239518295822d,left: 0.328638172206447d),
new NpgsqlTypes.NpgsqlBox(top: 0.866166644890344d,right: 0.4800880356650864d,bottom: 0.6567021449991092d,left: 0.13940781773600563d),
new NpgsqlTypes.NpgsqlBox(top: 0.9460614543218023d,right: 0.26945080023383616d,bottom: 0.18883698527288517d,left: 0.1804658254829572d),
new NpgsqlTypes.NpgsqlBox(top: 0.5851982319823716d,right: 0.5835159774680834d,bottom: 0.03862167486751178d,left: 0.4840065489612524d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.768105334755664d,right: 0.70381677079486d,bottom: 0.7463322352731209d,left: 0.03809927652872935d),
new NpgsqlTypes.NpgsqlBox(top: 0.8045919359891368d,right: 0.9991027441223097d,bottom: 0.15222926232343925d,left: 0.5840610495772779d),
new NpgsqlTypes.NpgsqlBox(top: 0.936888773210087d,right: 0.7609867000794328d,bottom: 0.009372424226895104d,left: 0.17904496668362302d),
new NpgsqlTypes.NpgsqlBox(top: 0.6820670161734749d,right: 0.48632069068545847d,bottom: 0.2106695952516715d,left: 0.11753313660871689d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.26646145372224483d,right: 0.386499043113388d,bottom: 0.134707332927132d,left: 0.31170508177897616d),
new NpgsqlTypes.NpgsqlBox(top: 0.45660202879811185d,right: 0.7339343775364767d,bottom: 0.1345741555732397d,left: 0.643473545061498d),
new NpgsqlTypes.NpgsqlBox(top: 0.2981280741932937d,right: 0.611894258416091d,bottom: 0.10496404882883614d,left: 0.47748588702099093d),
new NpgsqlTypes.NpgsqlBox(top: 0.5910899224516463d,right: 0.694081005319803d,bottom: 0.3097530994839104d,left: 0.5440183799998457d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9571690673212643d,right: 0.7991366999383561d,bottom: 0.28033678825006714d,left: 0.5324266767392741d),
new NpgsqlTypes.NpgsqlBox(top: 0.183291517282402d,right: 0.5493132559007909d,bottom: 0.02896371080673199d,left: 0.41994150185012824d),
new NpgsqlTypes.NpgsqlBox(top: 0.8843405179307473d,right: 0.3039487969140885d,bottom: 0.8131480344207351d,left: 0.26734741014015007d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.052120525960517194d,right: 0.6854389587209005d,bottom: 0.008589206166086605d,left: 0.40324667784986234d),
new NpgsqlTypes.NpgsqlBox(top: 0.7674818011869448d,right: 0.9150615938970607d,bottom: 0.22988308484929854d,left: 0.7037380764806866d),
new NpgsqlTypes.NpgsqlBox(top: 0.8329877445358599d,right: 0.23338306761407246d,bottom: 0.7793315336479126d,left: 0.004389919741624171d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.922633559295653d,right: 0.6705356766308835d,bottom: 0.7978586935406311d,left: 0.6283565234702893d),
new NpgsqlTypes.NpgsqlBox(top: 0.3543112373135219d,right: 0.6527571291403268d,bottom: 0.2660019275287282d,left: 0.4138769922867208d),
new NpgsqlTypes.NpgsqlBox(top: 0.8637014973321541d,right: 0.8216918240951995d,bottom: 0.8517851098780662d,left: 0.09133216270110012d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44255519621718575d,right: 0.8841388332913899d,bottom: 0.13392186347730894d,left: 0.33956531929656086d),
new NpgsqlTypes.NpgsqlBox(top: 0.368240013447828d,right: 0.1438308130751773d,bottom: 0.23584377585470218d,left: 0.034396804706664064d),
new NpgsqlTypes.NpgsqlBox(top: 0.49503532703781417d,right: 0.9860399211763207d,bottom: 0.03438571948282332d,left: 0.07031771122968289d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9477556643563405d,right: 0.28399442331376623d,bottom: 0.9028506870682851d,left: 0.09443211614187907d),
new NpgsqlTypes.NpgsqlBox(top: 0.5920200077314087d,right: 0.889149067016523d,bottom: 0.4231165757087255d,left: 0.3038358211911727d),
new NpgsqlTypes.NpgsqlBox(top: 0.8755655405849512d,right: 0.04630278858260395d,bottom: 0.7190122928796588d,left: 0.01549687584299142d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5918267127755382d,right: 0.5132808228390969d,bottom: 0.08034163473729938d,left: 0.27518550575941236d),
new NpgsqlTypes.NpgsqlBox(top: 0.9934538110610162d,right: 0.7185733189233723d,bottom: 0.41009491095492123d,left: 0.05711145394015715d),
new NpgsqlTypes.NpgsqlBox(top: 0.9067206431937336d,right: 0.9857493715984106d,bottom: 0.0715672298554757d,left: 0.4588460870454676d),
new NpgsqlTypes.NpgsqlBox(top: 0.8787633620502798d,right: 0.4217146197004207d,bottom: 0.7679636021418422d,left: 0.1129972058948272d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[34], false);
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
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 142;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 8, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 33, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 93, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 130, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 126, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 14, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 72, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 11, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI), typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                await ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxArrayboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

