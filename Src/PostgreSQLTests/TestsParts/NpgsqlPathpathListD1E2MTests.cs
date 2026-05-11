

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
    internal partial interface INpgsqlPathListpathListD1
    {
    }
    
    internal partial class NpgsqlPathListpathListD1 : INpgsqlPathListpathListD1
    {


#region TestData

        private readonly NpgsqlPathpathListD1E2M[] _testData = new NpgsqlPathpathListD1E2M[]
        {
            new NpgsqlPathpathListD1E2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2543514087838189d, y: 0.656935412025934d), new NpgsqlTypes.NpgsqlPoint(x: 0.012381322378550497d, y: 0.7326255610622753d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351340952086127d, y: 0.6356010531591323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005886152218118945d, y: 0.7092672424434845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486582292930338d, y: 0.1813177263682596d), new NpgsqlTypes.NpgsqlPoint(x: 0.14187238016116688d, y: 0.6673219777821648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5550469453502813d, y: 0.08217332358537499d), new NpgsqlTypes.NpgsqlPoint(x: 0.6148777482632403d, y: 0.5770799008101165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6484757449006597d, y: 0.9368621869142327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7843566890616385d, y: 0.3049013405103487d), new NpgsqlTypes.NpgsqlPoint(x: 0.3797976277256654d, y: 0.8612156209258022d), new NpgsqlTypes.NpgsqlPoint(x: 0.6293099118322435d, y: 0.0019344282574375038d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.961400429534927d, y: 0.7227044706338952d), new NpgsqlTypes.NpgsqlPoint(x: 0.10058935800865332d, y: 0.23788579685579392d), new NpgsqlTypes.NpgsqlPoint(x: 0.07372876755036362d, y: 0.9623747854750434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5712295878224536d, y: 0.1646411056757877d), new NpgsqlTypes.NpgsqlPoint(x: 0.819646557077286d, y: 0.8529947952729491d), new NpgsqlTypes.NpgsqlPoint(x: 0.1558258519330029d, y: 0.43729332195638804d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1419650472798808d, y: 0.9595791014481312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6118239906929084d, y: 0.24934329099293395d), new NpgsqlTypes.NpgsqlPoint(x: 0.19575005146070856d, y: 0.15002007648930116d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04503379220952641d, y: 0.16909886772764093d), new NpgsqlTypes.NpgsqlPoint(x: 0.03392922882360294d, y: 0.6912256990979163d), new NpgsqlTypes.NpgsqlPoint(x: 0.06585145668435344d, y: 0.12434590652428901d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0470778252523979d, y: 0.2299139843862542d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852274483517982d, y: 0.49268844711297755d), new NpgsqlTypes.NpgsqlPoint(x: 0.4281818831409223d, y: 0.0057091865123723995d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6220026935493952d, y: 0.34581261807364494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441414396362128d, y: 0.5843323939253523d), new NpgsqlTypes.NpgsqlPoint(x: 0.46667311333291994d, y: 0.8490814082209118d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14717157210594234d, y: 0.7008306584735128d), new NpgsqlTypes.NpgsqlPoint(x: 0.6334705996956977d, y: 0.8062223225063543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7667464394649545d, y: 0.5739718793699017d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32630650265931127d, y: 0.6846905897199027d), new NpgsqlTypes.NpgsqlPoint(x: 0.07035941641143628d, y: 0.6967568518125142d), new NpgsqlTypes.NpgsqlPoint(x: 0.7730434471238532d, y: 0.1250500923200626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37018858594624326d, y: 0.9942615127728784d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694100648305475d, y: 0.9985627040751598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273104477020055d, y: 0.861256033846653d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9804341164815167d, y: 0.509042931089924d), new NpgsqlTypes.NpgsqlPoint(x: 0.17324316574811172d, y: 0.9335201014140656d), new NpgsqlTypes.NpgsqlPoint(x: 0.42832761471412517d, y: 0.21023625028064485d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4231197472110466d, y: 0.8921297586102008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810096667368954d, y: 0.9083621538656512d), new NpgsqlTypes.NpgsqlPoint(x: 0.8685429681806331d, y: 0.3394579220675056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2569925017533672d, y: 0.013485050596329984d), new NpgsqlTypes.NpgsqlPoint(x: 0.40130622493246815d, y: 0.14630757098719105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4769349468650065d, y: 0.402313819196349d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6266604631923048d, y: 0.5974744055885773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9542957673643324d, y: 0.16398038548088967d), new NpgsqlTypes.NpgsqlPoint(x: 0.41325466430555025d, y: 0.2928492609257961d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9156229608970979d, y: 0.22695345667023836d), new NpgsqlTypes.NpgsqlPoint(x: 0.23409511926103643d, y: 0.6314276784818961d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738902035347785d, y: 0.963724142488016d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05805656293924888d, y: 0.24056702456017642d), new NpgsqlTypes.NpgsqlPoint(x: 0.17946168905091064d, y: 0.042829180788425014d), new NpgsqlTypes.NpgsqlPoint(x: 0.30995770709248693d, y: 0.5827698379478848d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9917825828000509d, y: 0.8473155318317984d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693404315309923d, y: 0.044355647054635905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403817695682921d, y: 0.8802056370688482d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21803034378594788d, y: 0.9883684434832218d), new NpgsqlTypes.NpgsqlPoint(x: 0.04845607836878374d, y: 0.055207999057399704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205206175944323d, y: 0.433548120136514d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9969541889168699d, y: 0.5834020292031764d), new NpgsqlTypes.NpgsqlPoint(x: 0.4850963910634579d, y: 0.8143628525543819d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545109179478575d, y: 0.39087283069222556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29205778605650634d, y: 0.499435939713644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572670254474147d, y: 0.4437614156278702d), new NpgsqlTypes.NpgsqlPoint(x: 0.0559699755048263d, y: 0.6940071343224036d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2335479200692615d, y: 0.6318250537947244d), new NpgsqlTypes.NpgsqlPoint(x: 0.45834653290913985d, y: 0.17457639071267983d), new NpgsqlTypes.NpgsqlPoint(x: 0.8287488074222955d, y: 0.49310458954633163d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1559246211892954d, y: 0.16147579418141556d), new NpgsqlTypes.NpgsqlPoint(x: 0.3038564117067909d, y: 0.2935447296122018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8438530232120206d, y: 0.11692093478359689d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5626283715144327d, y: 0.46708699036864354d), new NpgsqlTypes.NpgsqlPoint(x: 0.19087316686140476d, y: 0.20359388327911843d), new NpgsqlTypes.NpgsqlPoint(x: 0.3028787253955887d, y: 0.011211879339468656d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.98437558905029d, y: 0.5541258350354292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734839758004557d, y: 0.921772615249371d), new NpgsqlTypes.NpgsqlPoint(x: 0.9562863047775851d, y: 0.28024043475702676d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5526290377946701d, y: 0.562659166250961d), new NpgsqlTypes.NpgsqlPoint(x: 0.35362840283917707d, y: 0.42487254627502513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5689088652537383d, y: 0.5335871261964795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9677668052803214d, y: 0.44246422774978966d), new NpgsqlTypes.NpgsqlPoint(x: 0.08310647355786538d, y: 0.7975147765382189d), new NpgsqlTypes.NpgsqlPoint(x: 0.564487163796736d, y: 0.6595109140874189d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6239473237899827d, y: 0.32863335287413864d), new NpgsqlTypes.NpgsqlPoint(x: 0.3848695279078216d, y: 0.5871317660327744d), new NpgsqlTypes.NpgsqlPoint(x: 0.3635647594540772d, y: 0.005773935143357001d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9490548323962278d, y: 0.09060238472837556d), new NpgsqlTypes.NpgsqlPoint(x: 0.4737939947534824d, y: 0.27850507241460654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616610972865437d, y: 0.9655462810420248d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27356959887244325d, y: 0.2528888652209892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9893546782905568d, y: 0.9936341667276855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088848948153136d, y: 0.9163884754148317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8595585063864616d, y: 0.027649458261987614d), new NpgsqlTypes.NpgsqlPoint(x: 0.19311067750877076d, y: 0.36123565810728897d), new NpgsqlTypes.NpgsqlPoint(x: 0.44831724943268825d, y: 0.7141733356494843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8955477049876702d, y: 0.9703774687219251d), new NpgsqlTypes.NpgsqlPoint(x: 0.1694566976351365d, y: 0.035891554520892766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794958065495852d, y: 0.35964030717562245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3386646126866769d, y: 0.45803565509893407d), new NpgsqlTypes.NpgsqlPoint(x: 0.49202853027317806d, y: 0.34936062833572945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8657367806041681d, y: 0.7529984742222782d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42796530609378436d, y: 0.7999500530380326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379772834805232d, y: 0.13720495179703063d), new NpgsqlTypes.NpgsqlPoint(x: 0.029063281864053492d, y: 0.718096811653674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7669948273365684d, y: 0.4598169708274803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460985292489943d, y: 0.9920447149512197d), new NpgsqlTypes.NpgsqlPoint(x: 0.7173365413405796d, y: 0.5413119137120134d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35806267027515815d, y: 0.8323575019292064d), new NpgsqlTypes.NpgsqlPoint(x: 0.29888405842049504d, y: 0.06962142522759296d), new NpgsqlTypes.NpgsqlPoint(x: 0.09981001877435558d, y: 0.6575363776777708d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8630395789652925d, y: 0.08155958272775787d), new NpgsqlTypes.NpgsqlPoint(x: 0.41416616763910763d, y: 0.5646672053665295d), new NpgsqlTypes.NpgsqlPoint(x: 0.4736415799547359d, y: 0.4327429485006532d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9004387472909552d, y: 0.17451197133282392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7591644350796846d, y: 0.1923112642477075d), new NpgsqlTypes.NpgsqlPoint(x: 0.1421999394334338d, y: 0.1011006509496345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4665258508569714d, y: 0.3050764070244242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668960050276788d, y: 0.7861777411356191d), new NpgsqlTypes.NpgsqlPoint(x: 0.591888123470484d, y: 0.6811434984019605d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8480185542432527d, y: 0.6375060422193509d), new NpgsqlTypes.NpgsqlPoint(x: 0.3224089755691969d, y: 0.38382860888060055d), new NpgsqlTypes.NpgsqlPoint(x: 0.8134378643026969d, y: 0.8097289648874139d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9269533527240089d, y: 0.9174310437370863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7454025027072788d, y: 0.7793167413100001d), new NpgsqlTypes.NpgsqlPoint(x: 0.12332187168873854d, y: 0.8868843157829776d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45974491938213846d, y: 0.8188957138680414d), new NpgsqlTypes.NpgsqlPoint(x: 0.8826335552972302d, y: 0.2444158375944806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3748489979536891d, y: 0.9662795854917742d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7091136117620632d, y: 0.31212542965785206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6599383189492286d, y: 0.8251018206154969d), new NpgsqlTypes.NpgsqlPoint(x: 0.21574321005173402d, y: 0.5239673189152002d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23900951696828376d, y: 0.9673221306155032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6649892929131812d, y: 0.8113713052997498d), new NpgsqlTypes.NpgsqlPoint(x: 0.9132194078472975d, y: 0.21296942601455027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08290844253099283d, y: 0.4287504905177989d), new NpgsqlTypes.NpgsqlPoint(x: 0.4728211942557221d, y: 0.8855172296316823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8229470294695459d, y: 0.7179919189042338d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47726580828041565d, y: 0.22233897073326003d), new NpgsqlTypes.NpgsqlPoint(x: 0.49502876411969143d, y: 0.5020761052865589d), new NpgsqlTypes.NpgsqlPoint(x: 0.29685468983052943d, y: 0.8011289090959016d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3163830768881253d, y: 0.7737336914351345d), new NpgsqlTypes.NpgsqlPoint(x: 0.16686697269485173d, y: 0.8638211206388342d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877739281070008d, y: 0.4237587425884284d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.540417970792832d, y: 0.45311062188523765d), new NpgsqlTypes.NpgsqlPoint(x: 0.12873134676024078d, y: 0.135136892934817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3585159545929433d, y: 0.6785212063630135d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08369594967233451d, y: 0.9474541479196145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6237065138055419d, y: 0.391971189452765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8653371490592862d, y: 0.5582270326851602d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935958914438005d, y: 0.7881271300564396d), new NpgsqlTypes.NpgsqlPoint(x: 0.4555456003871273d, y: 0.37434354450457485d), new NpgsqlTypes.NpgsqlPoint(x: 0.3452560017896922d, y: 0.763872011094186d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.680512889077181d, y: 0.3046746741534234d), new NpgsqlTypes.NpgsqlPoint(x: 0.13904988663118467d, y: 0.06040430492533089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822189759017292d, y: 0.6254452289561906d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8785517158320143d, y: 0.6823655103422132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7600428957133646d, y: 0.7012006457157562d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531872699307391d, y: 0.7874136789096723d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.975697979690266d, y: 0.5811869640919988d), new NpgsqlTypes.NpgsqlPoint(x: 0.0007715577944407137d, y: 0.2422328613342054d), new NpgsqlTypes.NpgsqlPoint(x: 0.739774468698831d, y: 0.5379182163187946d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37342377875482646d, y: 0.5032051687471102d), new NpgsqlTypes.NpgsqlPoint(x: 0.14473583297011894d, y: 0.8938886270917857d), new NpgsqlTypes.NpgsqlPoint(x: 0.39582234426321006d, y: 0.3395211714809738d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7085536114314774d, y: 0.3236087080654185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050159228529548d, y: 0.8535104031498322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9314315465172046d, y: 0.25873329533281786d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1392499374560605d, y: 0.3444875248879681d), new NpgsqlTypes.NpgsqlPoint(x: 0.41824239053100143d, y: 0.8058057754847155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8156413562343712d, y: 0.2879952501765042d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7995670787780148d, y: 0.10407899961758893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6025251013842782d, y: 0.8181133752335746d), new NpgsqlTypes.NpgsqlPoint(x: 0.12805177419719316d, y: 0.5343373131864907d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7811512169400024d, y: 0.1541925157414914d), new NpgsqlTypes.NpgsqlPoint(x: 0.19482631658977878d, y: 0.5833124118878117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6686616530607536d, y: 0.7879287641427528d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4021126830776558d, y: 0.8006215018621776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708001179343582d, y: 0.17915123354275542d), new NpgsqlTypes.NpgsqlPoint(x: 0.10670573151755514d, y: 0.7100920056623281d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1657968117915376d, y: 0.6942789906122745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531869011311959d, y: 0.5502518454942409d), new NpgsqlTypes.NpgsqlPoint(x: 0.36533772807544984d, y: 0.3543124822186633d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7139037646726377d, y: 0.3586795831078565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041728898514103d, y: 0.14265976285778603d), new NpgsqlTypes.NpgsqlPoint(x: 0.3900945450267781d, y: 0.8640091392599902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06073623184170207d, y: 0.38736304738296057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5548767693048788d, y: 0.23396859986838814d), new NpgsqlTypes.NpgsqlPoint(x: 0.838582302929972d, y: 0.7672296546004721d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4039067505813241d, y: 0.434587635840205d), new NpgsqlTypes.NpgsqlPoint(x: 0.44186914546884626d, y: 0.4743906367449988d), new NpgsqlTypes.NpgsqlPoint(x: 0.07911055079800045d, y: 0.35292471830998595d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5968224374365916d, y: 0.5910600772801506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9240945655217315d, y: 0.5299560294285394d), new NpgsqlTypes.NpgsqlPoint(x: 0.24462866088920976d, y: 0.3454253461303529d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8463271274956162d, y: 0.6769287885667103d), new NpgsqlTypes.NpgsqlPoint(x: 0.40352164915518074d, y: 0.016676045547974194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5498546521513016d, y: 0.15336457461780983d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5002266913418523d, y: 0.9926092998772981d), new NpgsqlTypes.NpgsqlPoint(x: 0.15485800599506627d, y: 0.11411112011939939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6298878730967401d, y: 0.45082789131234235d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.481683185119261d, y: 0.44644609742329266d), new NpgsqlTypes.NpgsqlPoint(x: 0.3117579618468713d, y: 0.5559548914546033d), new NpgsqlTypes.NpgsqlPoint(x: 0.449095991016498d, y: 0.523721191674976d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04303929737629075d, y: 0.8327598365890506d), new NpgsqlTypes.NpgsqlPoint(x: 0.34871310652244114d, y: 0.21777103952858357d), new NpgsqlTypes.NpgsqlPoint(x: 0.4064723362561308d, y: 0.10251049333811413d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9232977705645248d, y: 0.1274754299134525d), new NpgsqlTypes.NpgsqlPoint(x: 0.7090295765641302d, y: 0.12409945006651979d), new NpgsqlTypes.NpgsqlPoint(x: 0.8330492025979237d, y: 0.9453589962959531d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08316738947479274d, y: 0.8545615893319941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7946118614772595d, y: 0.3621558480533421d), new NpgsqlTypes.NpgsqlPoint(x: 0.4936363439963436d, y: 0.2662494368262237d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8753548688737042d, y: 0.23768681268005953d), new NpgsqlTypes.NpgsqlPoint(x: 0.411680346211885d, y: 0.754009620281275d), new NpgsqlTypes.NpgsqlPoint(x: 0.06697038199768957d, y: 0.7569365808152021d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6954156680720177d, y: 0.79824531661137d), new NpgsqlTypes.NpgsqlPoint(x: 0.30666951234302664d, y: 0.6062290576889601d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880243355555967d, y: 0.06333993526017268d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19099414707828388d, y: 0.0627442163156754d), new NpgsqlTypes.NpgsqlPoint(x: 0.3679639491008909d, y: 0.41890269816759496d), new NpgsqlTypes.NpgsqlPoint(x: 0.28933869375964294d, y: 0.7237615852930811d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3073279934366612d, y: 0.5175689205680604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9319285139519625d, y: 0.3151484351071957d), new NpgsqlTypes.NpgsqlPoint(x: 0.06460032927446124d, y: 0.8286150789416923d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4937133391751197d, y: 0.5580926564084513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8837938379734626d, y: 0.6996101279966027d), new NpgsqlTypes.NpgsqlPoint(x: 0.30388944097434567d, y: 0.37309837084323205d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3709249387396685d, y: 0.3390806357934719d), new NpgsqlTypes.NpgsqlPoint(x: 0.6296597417940104d, y: 0.19851268917939446d), new NpgsqlTypes.NpgsqlPoint(x: 0.9178149869788773d, y: 0.39613489930884394d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5083774495648411d, y: 0.1645078422269609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6789620757322187d, y: 0.16173111179206545d), new NpgsqlTypes.NpgsqlPoint(x: 0.240874496172503d, y: 0.41701882300933013d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14245057187039045d, y: 0.025815902134921465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632165963296765d, y: 0.32722079906082435d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042469084330396d, y: 0.016752968419659786d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5279566894907092d, y: 0.599239092085436d), new NpgsqlTypes.NpgsqlPoint(x: 0.27595199226648703d, y: 0.5121816744257919d), new NpgsqlTypes.NpgsqlPoint(x: 0.17317866245373614d, y: 0.041531643376368166d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5872413707531863d, y: 0.697287444139876d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525509105713761d, y: 0.07029487636208931d), new NpgsqlTypes.NpgsqlPoint(x: 0.746570076856613d, y: 0.5255372792500846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7077710351812254d, y: 0.786149749866486d), new NpgsqlTypes.NpgsqlPoint(x: 0.10475175390354441d, y: 0.7908971950060123d), new NpgsqlTypes.NpgsqlPoint(x: 0.461323239770449d, y: 0.08893283471659763d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13493390585901122d, y: 0.9797253469640012d), new NpgsqlTypes.NpgsqlPoint(x: 0.09116824266291712d, y: 0.029398340020348912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486374296274114d, y: 0.19103996714862992d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3174208076310465d, y: 0.9066996707344553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5825357226582342d, y: 0.5967985320695672d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938957839198257d, y: 0.7863189592352853d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22429166887885643d, y: 0.1477244530003421d), new NpgsqlTypes.NpgsqlPoint(x: 0.8616250819738702d, y: 0.5553027702630644d), new NpgsqlTypes.NpgsqlPoint(x: 0.3019882427793056d, y: 0.48639605459753776d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6711222716046512d, y: 0.22853020183869888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9542781501369761d, y: 0.6409723961778465d), new NpgsqlTypes.NpgsqlPoint(x: 0.10344438302697001d, y: 0.05602849683662914d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05790058392325215d, y: 0.07616763594733833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8000909399516309d, y: 0.8189416563034237d), new NpgsqlTypes.NpgsqlPoint(x: 0.08529246969863902d, y: 0.5989327623123241d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.056016854038360986d, y: 0.2699212330945143d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910790092775306d, y: 0.7608026714127376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9099739259685055d, y: 0.9162606649703484d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1514338967634783d, y: 0.40873033997510966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6114286220095293d, y: 0.4675620582111001d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739694614251221d, y: 0.7243957807931721d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19695133285898048d, y: 0.39865792151700585d), new NpgsqlTypes.NpgsqlPoint(x: 0.3520875820316116d, y: 0.465597281269003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450591756908491d, y: 0.5640532247219975d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22548863907745065d, y: 0.3002550980085782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075821643851727d, y: 0.08062490503442965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6409433914195817d, y: 0.5224192483811975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3665819475499825d, y: 0.015222541972669479d), new NpgsqlTypes.NpgsqlPoint(x: 0.6884864787384626d, y: 0.7550953489936589d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079766215713151d, y: 0.16489102749760465d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.158471366658824d, y: 0.6649094199538331d), new NpgsqlTypes.NpgsqlPoint(x: 0.8646223686699126d, y: 0.03834375541871815d), new NpgsqlTypes.NpgsqlPoint(x: 0.7849030582043457d, y: 0.8889501708314014d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9537993542625185d, y: 0.5442780344701131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9675927231444207d, y: 0.808448846570985d), new NpgsqlTypes.NpgsqlPoint(x: 0.786479776931984d, y: 0.4618796344273238d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7866671916417999d, y: 0.15022944815505956d), new NpgsqlTypes.NpgsqlPoint(x: 0.48600995477774667d, y: 0.21610719809796808d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330613718209734d, y: 0.8584412435514652d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18940028166610978d, y: 0.4283857522286252d), new NpgsqlTypes.NpgsqlPoint(x: 0.017958235255926325d, y: 0.6815376390128248d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184715816963469d, y: 0.23500327672747234d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.357646405946627d, y: 0.7235196652441447d), new NpgsqlTypes.NpgsqlPoint(x: 0.3429331747221598d, y: 0.8560029144192486d), new NpgsqlTypes.NpgsqlPoint(x: 0.13432000893780616d, y: 0.9509322449551553d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14670917768672853d, y: 0.7235316975098858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147686758910706d, y: 0.558637649042232d), new NpgsqlTypes.NpgsqlPoint(x: 0.04993907151586663d, y: 0.9699000801638205d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7912278937234862d, y: 0.3871125882494707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514167037687463d, y: 0.48420780850599343d), new NpgsqlTypes.NpgsqlPoint(x: 0.777045943055549d, y: 0.7561146714706194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.001595253739584357d, y: 0.41400771355791877d), new NpgsqlTypes.NpgsqlPoint(x: 0.524703304120267d, y: 0.36911117672689375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8627154464643169d, y: 0.5890477922657086d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15538784379017723d, y: 0.6543593623724677d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590519411086578d, y: 0.40107716980805397d), new NpgsqlTypes.NpgsqlPoint(x: 0.15994653252279467d, y: 0.4551854758924553d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5286828885862693d, y: 0.3875718409525598d), new NpgsqlTypes.NpgsqlPoint(x: 0.05182239144607026d, y: 0.5044094866234069d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756283701168974d, y: 0.6339268198814151d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30883935441986965d, y: 0.6690671368989783d), new NpgsqlTypes.NpgsqlPoint(x: 0.4573566714985232d, y: 0.5264963086858283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9043753441054125d, y: 0.5249591987369684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6501784764781509d, y: 0.6511876706760443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673732303943191d, y: 0.8603259003703293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9227911067728444d, y: 0.4577187400137148d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003526532323989473d, y: 0.3324279481700805d), new NpgsqlTypes.NpgsqlPoint(x: 0.7235121074192734d, y: 0.19225531515293692d), new NpgsqlTypes.NpgsqlPoint(x: 0.17995181647270808d, y: 0.11262556329985396d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3017832555103609d, y: 0.6239428659209706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7238953366909009d, y: 0.9268864959830345d), new NpgsqlTypes.NpgsqlPoint(x: 0.3676853735972583d, y: 0.6636122218830844d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23462395535758562d, y: 0.6855873741042663d), new NpgsqlTypes.NpgsqlPoint(x: 0.13082114044764137d, y: 0.8379209339390671d), new NpgsqlTypes.NpgsqlPoint(x: 0.31522876036968284d, y: 0.42137058303021435d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26323285496686455d, y: 0.551978737219287d), new NpgsqlTypes.NpgsqlPoint(x: 0.04110005975958575d, y: 0.45483973372352515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8897880589834781d, y: 0.5241266335034711d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7252191244574879d, y: 0.8547895709166566d), new NpgsqlTypes.NpgsqlPoint(x: 0.9136532940544656d, y: 0.5405058398168383d), new NpgsqlTypes.NpgsqlPoint(x: 0.801473204686723d, y: 0.5647817684994818d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6358868224351742d, y: 0.8334823204829449d), new NpgsqlTypes.NpgsqlPoint(x: 0.1405663967604156d, y: 0.37123006203341735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673105262855951d, y: 0.594432244890027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7880263222592175d, y: 0.9160986083507884d), new NpgsqlTypes.NpgsqlPoint(x: 0.012462751628767088d, y: 0.6464863427417626d), new NpgsqlTypes.NpgsqlPoint(x: 0.39815366823748144d, y: 0.7939769403352915d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9344844724179404d, y: 0.6907566988355134d), new NpgsqlTypes.NpgsqlPoint(x: 0.18608504204574827d, y: 0.7786912452635659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7818760654434055d, y: 0.9329265315537625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24224015188389636d, y: 0.8451934734449259d), new NpgsqlTypes.NpgsqlPoint(x: 0.21495316482168525d, y: 0.8487012515427212d), new NpgsqlTypes.NpgsqlPoint(x: 0.20272863157416576d, y: 0.5145442556626643d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5907029810946061d, y: 0.18275360665542273d), new NpgsqlTypes.NpgsqlPoint(x: 0.06250075538138311d, y: 0.0312449498290841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8693583648468958d, y: 0.4061455126110649d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8823993599534508d, y: 0.2547996429656981d), new NpgsqlTypes.NpgsqlPoint(x: 0.12343550199037945d, y: 0.7521511197785449d), new NpgsqlTypes.NpgsqlPoint(x: 0.47894818145288265d, y: 0.3982662047526122d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8769122162902513d, y: 0.3576224201780023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9949619397457727d, y: 0.6214957808005549d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296147764094391d, y: 0.9553660395089497d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6458067851014434d, y: 0.23923066052092345d), new NpgsqlTypes.NpgsqlPoint(x: 0.07662943038187442d, y: 0.513215613575642d), new NpgsqlTypes.NpgsqlPoint(x: 0.8732750560892564d, y: 0.4743555072630954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16358803472693217d, y: 0.36411027061735934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9000274639376402d, y: 0.030379056779420877d), new NpgsqlTypes.NpgsqlPoint(x: 0.9396727445104304d, y: 0.32308412226954863d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788684811336811d, y: 0.5890243606500287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5329084206812624d, y: 0.7069975934874216d), new NpgsqlTypes.NpgsqlPoint(x: 0.2625442916041707d, y: 0.7907112502287349d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2628191258210676d, y: 0.7886753205396462d), new NpgsqlTypes.NpgsqlPoint(x: 0.2972865268311622d, y: 0.42703496314771683d), new NpgsqlTypes.NpgsqlPoint(x: 0.37383334169047666d, y: 0.5529949639274281d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8389983244930628d, y: 0.27895398620160683d), new NpgsqlTypes.NpgsqlPoint(x: 0.9423774463944665d, y: 0.24632654247970553d), new NpgsqlTypes.NpgsqlPoint(x: 0.12948741468724123d, y: 0.7219882070194045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11395136996424649d, y: 0.4416824254630144d), new NpgsqlTypes.NpgsqlPoint(x: 0.06752786226621843d, y: 0.07367996250629871d), new NpgsqlTypes.NpgsqlPoint(x: 0.930671026925432d, y: 0.44460611578643106d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21729058060454953d, y: 0.17888430586044146d), new NpgsqlTypes.NpgsqlPoint(x: 0.10078142369482024d, y: 0.6749308235076091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6216792356573161d, y: 0.6229819735917322d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9840295137047547d, y: 0.8823754353593705d), new NpgsqlTypes.NpgsqlPoint(x: 0.6552641501595288d, y: 0.24341865367037452d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754975073794137d, y: 0.14499299946363498d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5834586168149447d, y: 0.743467304305695d), new NpgsqlTypes.NpgsqlPoint(x: 0.8850440074485204d, y: 0.4787583694147045d), new NpgsqlTypes.NpgsqlPoint(x: 0.11863942021670393d, y: 0.6493303288631781d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46890517314597924d, y: 0.9281556828024297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8495218775348811d, y: 0.6343799757614238d), new NpgsqlTypes.NpgsqlPoint(x: 0.7994067180695098d, y: 0.3318911836011528d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4317494946433992d, y: 0.3923423076117821d), new NpgsqlTypes.NpgsqlPoint(x: 0.5563264867502231d, y: 0.5475851898744782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7564595638111459d, y: 0.4755746574109907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5276144151932363d, y: 0.39697277338416403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183442101976003d, y: 0.09174799888250906d), new NpgsqlTypes.NpgsqlPoint(x: 0.1100809136458436d, y: 0.07905672575723821d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4680779793537384d, y: 0.681083968246036d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180200790980947d, y: 0.5484025909823057d), new NpgsqlTypes.NpgsqlPoint(x: 0.34952130439466d, y: 0.749089518465183d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3051300534783593d, y: 0.3544615709486284d), new NpgsqlTypes.NpgsqlPoint(x: 0.1562715026813548d, y: 0.1551209103960498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8991727219325967d, y: 0.5973777095546883d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9818374721723161d, y: 0.5606000966585812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3893355658364851d, y: 0.4913618085883066d), new NpgsqlTypes.NpgsqlPoint(x: 0.2965659000999966d, y: 0.3699772196590839d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7248164399031053d, y: 0.6827932556097568d), new NpgsqlTypes.NpgsqlPoint(x: 0.3643835534099127d, y: 0.5163346925870476d), new NpgsqlTypes.NpgsqlPoint(x: 0.17738185115110394d, y: 0.3021724050547864d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6584540410454975d, y: 0.6452705800149516d), new NpgsqlTypes.NpgsqlPoint(x: 0.16322844764827849d, y: 0.3426280663229099d), new NpgsqlTypes.NpgsqlPoint(x: 0.4862473601065339d, y: 0.3068516934111054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4731762101829451d, y: 0.251760895387356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9840121763649018d, y: 0.39001012797668877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7204824784876069d, y: 0.11254126769680894d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07473346954751381d, y: 0.3272860554204924d), new NpgsqlTypes.NpgsqlPoint(x: 0.4274555265385491d, y: 0.21807302863048017d), new NpgsqlTypes.NpgsqlPoint(x: 0.561842201673093d, y: 0.5180346730680438d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9428061789036546d, y: 0.9399939889412989d), new NpgsqlTypes.NpgsqlPoint(x: 0.3432833650602273d, y: 0.17777556555623186d), new NpgsqlTypes.NpgsqlPoint(x: 0.022814972110796528d, y: 0.7606076677505035d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9106171891877667d, y: 0.9479523024042256d), new NpgsqlTypes.NpgsqlPoint(x: 0.17088107729861124d, y: 0.9122120951358833d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120465119152753d, y: 0.1886051604375939d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3581810817481442d, y: 0.19959590381822567d), new NpgsqlTypes.NpgsqlPoint(x: 0.22948189166868216d, y: 0.7924326304932455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4948050117115609d, y: 0.9829539344193168d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8081379613186132d, y: 0.24104215577743726d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818901129654204d, y: 0.9033520523230243d), new NpgsqlTypes.NpgsqlPoint(x: 0.20294949438949628d, y: 0.7614502550360137d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.951016996437833d, y: 0.4593192658562556d), new NpgsqlTypes.NpgsqlPoint(x: 0.7716029522520443d, y: 0.8152898825497642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6390505805530645d, y: 0.19201156585788548d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5278992671436377d, y: 0.722213007569506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604910601711898d, y: 0.5757301195089303d), new NpgsqlTypes.NpgsqlPoint(x: 0.28306397066916245d, y: 0.8226772227392056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04451702825292758d, y: 0.3777122183341982d), new NpgsqlTypes.NpgsqlPoint(x: 0.15485509011585652d, y: 0.959425936276467d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686224694970737d, y: 0.6637039212130753d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8163320678895966d, y: 0.9924351522279761d), new NpgsqlTypes.NpgsqlPoint(x: 0.10893123918603931d, y: 0.5749716135813371d), new NpgsqlTypes.NpgsqlPoint(x: 0.6332108027025886d, y: 0.22342597273817344d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.946046638766055d, y: 0.6007609599815561d), new NpgsqlTypes.NpgsqlPoint(x: 0.0739745689414345d, y: 0.5808368397120536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473083644810703d, y: 0.3768686685987539d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48131092286570565d, y: 0.8607329639082844d), new NpgsqlTypes.NpgsqlPoint(x: 0.17689312096922538d, y: 0.40049186377673374d), new NpgsqlTypes.NpgsqlPoint(x: 0.695636987251179d, y: 0.6819139447600425d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2788176298004845d, y: 0.6225930958391367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7675336417063123d, y: 0.6271278989750987d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862425695538681d, y: 0.4272539673084531d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8697977588756436d, y: 0.3153904662709982d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342171395924068d, y: 0.9162166538774078d), new NpgsqlTypes.NpgsqlPoint(x: 0.5818282160952652d, y: 0.8957625774945734d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0837101779918834d, y: 0.6185256687263988d), new NpgsqlTypes.NpgsqlPoint(x: 0.07673173822183343d, y: 0.3515500566520404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4191469483520287d, y: 0.6724593960790741d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4046742319864257d, y: 0.4099389300944809d), new NpgsqlTypes.NpgsqlPoint(x: 0.4827251946183695d, y: 0.48954555039435976d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147663202306086d, y: 0.2445719637109991d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9221859295783298d, y: 0.6731117874867578d), new NpgsqlTypes.NpgsqlPoint(x: 0.9865378499146348d, y: 0.3478608607474747d), new NpgsqlTypes.NpgsqlPoint(x: 0.6293934698091818d, y: 0.19329417976352736d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34539689922729555d, y: 0.4776137364528764d), new NpgsqlTypes.NpgsqlPoint(x: 0.2453045993429529d, y: 0.00413832073116549d), new NpgsqlTypes.NpgsqlPoint(x: 0.1732429156809051d, y: 0.9497909964362901d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9410636034022843d, y: 0.8007664543564593d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342117353118858d, y: 0.0955680421160785d), new NpgsqlTypes.NpgsqlPoint(x: 0.10844091967878655d, y: 0.2917242249904983d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4171110782855312d, y: 0.43758169103501854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322051421636577d, y: 0.07444688140679134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841121821125927d, y: 0.7142628140770145d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9867391010351402d, y: 0.43163558332348173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8879964343600294d, y: 0.4928427164337492d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180793944029735d, y: 0.01964527930473492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5016527877492618d, y: 0.13783610703189975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6513554565606361d, y: 0.4459952503878779d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374939198506331d, y: 0.999856047456218d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4137221518480967d, y: 0.8320441289862868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4126480754673355d, y: 0.6886830573485482d), new NpgsqlTypes.NpgsqlPoint(x: 0.42791603179946147d, y: 0.5802573648443268d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3064803894259207d, y: 0.07720779111188258d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887797463213154d, y: 0.9375407083988703d), new NpgsqlTypes.NpgsqlPoint(x: 0.017205000654268776d, y: 0.5853381135960823d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8416227122512953d, y: 0.5257070175376771d), new NpgsqlTypes.NpgsqlPoint(x: 0.29613875983964655d, y: 0.777736701457427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8759795201139d, y: 0.5960650031991556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26405328639550385d, y: 0.22698603367392856d), new NpgsqlTypes.NpgsqlPoint(x: 0.555163419585327d, y: 0.607808251024839d), new NpgsqlTypes.NpgsqlPoint(x: 0.4246636278987397d, y: 0.794749601114202d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29357335576756294d, y: 0.36260092801886923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6548599001906975d, y: 0.7577428163010351d), new NpgsqlTypes.NpgsqlPoint(x: 0.43200101252954737d, y: 0.8778902242056196d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39580604537807773d, y: 0.7937821198499443d), new NpgsqlTypes.NpgsqlPoint(x: 0.2720558487918695d, y: 0.3635982058619268d), new NpgsqlTypes.NpgsqlPoint(x: 0.4902842267055565d, y: 0.5663944073448148d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4775653370618521d, y: 0.05993780237573543d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986548073947154d, y: 0.384416788576152d), new NpgsqlTypes.NpgsqlPoint(x: 0.23139976586688926d, y: 0.21325544673850827d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49897224877919466d, y: 0.4280038199701969d), new NpgsqlTypes.NpgsqlPoint(x: 0.4520491805268638d, y: 0.23168562185234653d), new NpgsqlTypes.NpgsqlPoint(x: 0.38324276712717975d, y: 0.9675570325633904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7387679924086312d, y: 0.8410716772546504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382017283102315d, y: 0.6166288742188006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8578620073588821d, y: 0.7856784259308957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5978569451525814d, y: 0.16904060118114295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101329376717887d, y: 0.6233864431273292d), new NpgsqlTypes.NpgsqlPoint(x: 0.8651720913450078d, y: 0.4232011003238727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8493247575911744d, y: 0.04406084517064213d), new NpgsqlTypes.NpgsqlPoint(x: 0.1456565060864935d, y: 0.9270941090536429d), new NpgsqlTypes.NpgsqlPoint(x: 0.9715897394541835d, y: 0.4877714645180592d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7157114364315607d, y: 0.8806907987559366d), new NpgsqlTypes.NpgsqlPoint(x: 0.3916382044670942d, y: 0.6438265182070371d), new NpgsqlTypes.NpgsqlPoint(x: 0.13679761744784702d, y: 0.8608722019074967d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29745908183310765d, y: 0.713313668178234d), new NpgsqlTypes.NpgsqlPoint(x: 0.20285365814169598d, y: 0.3214231917576895d), new NpgsqlTypes.NpgsqlPoint(x: 0.38115417511485916d, y: 0.663527066475801d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7755965036606707d, y: 0.5987685250682664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739849508785721d, y: 0.054742602961812326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6390565691495078d, y: 0.09561359401035252d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4157282811530729d, y: 0.8235917930395091d), new NpgsqlTypes.NpgsqlPoint(x: 0.27206933599742666d, y: 0.8910173093895088d), new NpgsqlTypes.NpgsqlPoint(x: 0.0925446294191119d, y: 0.5130597274348115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7040734640013715d, y: 0.1735427141104775d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861978444720828d, y: 0.31319945021139595d), new NpgsqlTypes.NpgsqlPoint(x: 0.10047039230082289d, y: 0.5990042229528273d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23759377480084987d, y: 0.800597338132084d), new NpgsqlTypes.NpgsqlPoint(x: 0.4781348297193111d, y: 0.44816721508906543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671312212423269d, y: 0.9622084704256446d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37631066507414546d, y: 0.059796601792802884d), new NpgsqlTypes.NpgsqlPoint(x: 0.3359484205094626d, y: 0.1327323912840429d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890983324017903d, y: 0.5557677149633082d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5579648464180499d, y: 0.8146157836519436d), new NpgsqlTypes.NpgsqlPoint(x: 0.16539184723633948d, y: 0.8451476998603837d), new NpgsqlTypes.NpgsqlPoint(x: 0.29871122397254324d, y: 0.2359308455844783d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9949127180261477d, y: 0.16682561736286228d), new NpgsqlTypes.NpgsqlPoint(x: 0.32658332959374914d, y: 0.4592739830432929d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389639664634466d, y: 0.47546046597811353d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05486758666421765d, y: 0.5901960866199403d), new NpgsqlTypes.NpgsqlPoint(x: 0.1405246897478467d, y: 0.306713429630604d), new NpgsqlTypes.NpgsqlPoint(x: 0.2927295414180635d, y: 0.34908827006905485d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7748447015284695d, y: 0.8967622392416138d), new NpgsqlTypes.NpgsqlPoint(x: 0.40464353778427586d, y: 0.15675121005632198d), new NpgsqlTypes.NpgsqlPoint(x: 0.4669849307521836d, y: 0.2744431168112028d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44525287919902934d, y: 0.28975773628075085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617269510556587d, y: 0.11800504484691299d), new NpgsqlTypes.NpgsqlPoint(x: 0.46521332544615457d, y: 0.7135431473733497d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12345075967789598d, y: 0.10555067950471064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815773981572006d, y: 0.1475731154346288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515591000736882d, y: 0.19378830312454642d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19261409954316577d, y: 0.33071053933858363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011528573155889d, y: 0.20898955457293267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9153663884433024d, y: 0.09104971716940702d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6362606256256814d, y: 0.8303383603731828d), new NpgsqlTypes.NpgsqlPoint(x: 0.03946765560015264d, y: 0.9688348554863894d), new NpgsqlTypes.NpgsqlPoint(x: 0.803064422511332d, y: 0.6500535804927124d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1033179193745638d, y: 0.41675655933148104d), new NpgsqlTypes.NpgsqlPoint(x: 0.9545004581778583d, y: 0.11261990256460619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269040057135707d, y: 0.989412499412341d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05787114370517299d, y: 0.7528666839950446d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679574737225352d, y: 0.7193277124678861d), new NpgsqlTypes.NpgsqlPoint(x: 0.06240162661144788d, y: 0.8650453995869599d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3856003066136571d, y: 0.14163127794347452d), new NpgsqlTypes.NpgsqlPoint(x: 0.02245435365455173d, y: 0.0034355423518986905d), new NpgsqlTypes.NpgsqlPoint(x: 0.34599000770683996d, y: 0.02987426551210204d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25646535046976937d, y: 0.21003535489614622d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572557118403546d, y: 0.03971667376776922d), new NpgsqlTypes.NpgsqlPoint(x: 0.4542037914269561d, y: 0.7001647524677828d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8038213330335661d, y: 0.4694280401776989d), new NpgsqlTypes.NpgsqlPoint(x: 0.318263942437078d, y: 0.7435966443872413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608264885716827d, y: 0.9821149293416966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4261313421756726d, y: 0.6715422748979896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993319214791413d, y: 0.29219036961360434d), new NpgsqlTypes.NpgsqlPoint(x: 0.06673708538789269d, y: 0.8881610858147566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0838819849331095d, y: 0.723183953192256d), new NpgsqlTypes.NpgsqlPoint(x: 0.36562819882417585d, y: 0.6191896996065804d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389773508129189d, y: 0.5849806769265771d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5871863689394482d, y: 0.955194648470527d), new NpgsqlTypes.NpgsqlPoint(x: 0.9587397075890516d, y: 0.9421949881351174d), new NpgsqlTypes.NpgsqlPoint(x: 0.01760459758156896d, y: 0.15446115265310612d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.512911177024423d, y: 0.47968624525047576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5568503297073882d, y: 0.7930433174720516d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322038668561014d, y: 0.5084719691340581d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.051449118540933814d, y: 0.6746625717948628d), new NpgsqlTypes.NpgsqlPoint(x: 0.009915454468438778d, y: 0.35751007199394924d), new NpgsqlTypes.NpgsqlPoint(x: 0.6722739755900365d, y: 0.02431851546552566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5395637023820044d, y: 0.6516870722549587d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855257452251357d, y: 0.5021895636124435d), new NpgsqlTypes.NpgsqlPoint(x: 0.41127184118423965d, y: 0.7379837318973657d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3964759608153403d, y: 0.5452676248550141d), new NpgsqlTypes.NpgsqlPoint(x: 0.47250325665173665d, y: 0.12469258656266358d), new NpgsqlTypes.NpgsqlPoint(x: 0.021582997939877058d, y: 0.19315735301738124d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13188497800434063d, y: 0.3849698949046353d), new NpgsqlTypes.NpgsqlPoint(x: 0.32895665957109277d, y: 0.2957254279151996d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197873624531034d, y: 0.19428587158054111d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4322551690968047d, y: 0.6706829844904868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6811880168851728d, y: 0.8601917004382177d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286290351408321d, y: 0.4228654433958321d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42189526744685735d, y: 0.20322045889843665d), new NpgsqlTypes.NpgsqlPoint(x: 0.0711718318043042d, y: 0.04055534723346743d), new NpgsqlTypes.NpgsqlPoint(x: 0.32579370207767444d, y: 0.06590834369257537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24716888478421384d, y: 0.2619970299817388d), new NpgsqlTypes.NpgsqlPoint(x: 0.49551160244525116d, y: 0.6399420073874647d), new NpgsqlTypes.NpgsqlPoint(x: 0.2154637426235677d, y: 0.8484756550042324d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9679720758788662d, y: 0.1388359745853197d), new NpgsqlTypes.NpgsqlPoint(x: 0.886335457414121d, y: 0.3035088574738487d), new NpgsqlTypes.NpgsqlPoint(x: 0.053089666838598615d, y: 0.25138341048308466d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.525765500635344d, y: 0.34625894582452765d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044950079982896d, y: 0.5404106387215545d), new NpgsqlTypes.NpgsqlPoint(x: 0.16554408118340747d, y: 0.25840285811365526d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34272412628355964d, y: 0.803122488824033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9994083677653578d, y: 0.044472073228517206d), new NpgsqlTypes.NpgsqlPoint(x: 0.04205828247854915d, y: 0.5684345542059206d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7631594976192743d, y: 0.24942686950221404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6034723213619364d, y: 0.9911516986411979d), new NpgsqlTypes.NpgsqlPoint(x: 0.23774536714564098d, y: 0.2392645263969082d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06389979034688731d, y: 0.7772327802064676d), new NpgsqlTypes.NpgsqlPoint(x: 0.08696724839937431d, y: 0.4064696899873347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5460068225360425d, y: 0.2878124270986504d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050874861535092464d, y: 0.2370215008234171d), new NpgsqlTypes.NpgsqlPoint(x: 0.9908716826860424d, y: 0.2814259992861504d), new NpgsqlTypes.NpgsqlPoint(x: 0.8014634301253493d, y: 0.47648724611477467d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.774371048968015d, y: 0.09550508462072183d), new NpgsqlTypes.NpgsqlPoint(x: 0.43291998549177924d, y: 0.640469641709687d), new NpgsqlTypes.NpgsqlPoint(x: 0.9825337543701897d, y: 0.11860919129373637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6015401331267333d, y: 0.020484933752963896d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937528464855948d, y: 0.7624830270063261d), new NpgsqlTypes.NpgsqlPoint(x: 0.4410022186565329d, y: 0.04585959748245594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12783500870828146d, y: 0.16390867688483535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3721077504547301d, y: 0.724204252496286d), new NpgsqlTypes.NpgsqlPoint(x: 0.4082880956584477d, y: 0.21176226726192282d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04866216427204195d, y: 0.8873499279543635d), new NpgsqlTypes.NpgsqlPoint(x: 0.40186850899366733d, y: 0.04164485170346133d), new NpgsqlTypes.NpgsqlPoint(x: 0.09941515967229075d, y: 0.11512920332215293d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25320679988436523d, y: 0.9279406749908855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131444180669853d, y: 0.012081058416724133d), new NpgsqlTypes.NpgsqlPoint(x: 0.5599624071098711d, y: 0.2761516518468643d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9840923196549338d, y: 0.12665867431525668d), new NpgsqlTypes.NpgsqlPoint(x: 0.18384537853851635d, y: 0.752211197131057d), new NpgsqlTypes.NpgsqlPoint(x: 0.8427013726539291d, y: 0.9619594233234513d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2256001177467063d, y: 0.3667782580342722d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808510474374964d, y: 0.9359699172941119d), new NpgsqlTypes.NpgsqlPoint(x: 0.18689355254097673d, y: 0.7619936635673897d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18964757786556496d, y: 0.412188812923866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4604777220444045d, y: 0.2944200417734837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5386725263377532d, y: 0.3183130686778626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.727647679840874d, y: 0.8062875308023719d), new NpgsqlTypes.NpgsqlPoint(x: 0.1149717061946347d, y: 0.10701652699982889d), new NpgsqlTypes.NpgsqlPoint(x: 0.7616165393598511d, y: 0.2811738214588424d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20465129371628155d, y: 0.9849983724063295d), new NpgsqlTypes.NpgsqlPoint(x: 0.45281063090962237d, y: 0.03167791576113965d), new NpgsqlTypes.NpgsqlPoint(x: 0.3960817844192319d, y: 0.44161038530778207d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06162743648258051d, y: 0.7030539233002716d), new NpgsqlTypes.NpgsqlPoint(x: 0.3599703529971313d, y: 0.304261191690961d), new NpgsqlTypes.NpgsqlPoint(x: 0.6042782846411253d, y: 0.3328457251488881d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6268367114048513d, y: 0.24581808723705134d), new NpgsqlTypes.NpgsqlPoint(x: 0.34745679983513067d, y: 0.8110087999626808d), new NpgsqlTypes.NpgsqlPoint(x: 0.9676381321552198d, y: 0.17272223671459896d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8276371215882108d, y: 0.44266170200395505d), new NpgsqlTypes.NpgsqlPoint(x: 0.14476264200436506d, y: 0.4507460293518716d), new NpgsqlTypes.NpgsqlPoint(x: 0.92362147190922d, y: 0.40019054203584337d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4906405268340639d, y: 0.14325361425284333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2863028900742072d, y: 0.9077291107472562d), new NpgsqlTypes.NpgsqlPoint(x: 0.3394429458924674d, y: 0.6802859193316942d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28067418149366785d, y: 0.5922177153207505d), new NpgsqlTypes.NpgsqlPoint(x: 0.3186344436578893d, y: 0.15181837252729236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7549171458555569d, y: 0.7535541510696534d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5047422319642163d, y: 0.3671770113456616d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209197131631492d, y: 0.22610511847216896d), new NpgsqlTypes.NpgsqlPoint(x: 0.5423950372821064d, y: 0.00798629925459704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8734079446203209d, y: 0.3521944545146951d), new NpgsqlTypes.NpgsqlPoint(x: 0.23544604338464659d, y: 0.9950397684111788d), new NpgsqlTypes.NpgsqlPoint(x: 0.05688087858611912d, y: 0.7936436856370785d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9414932104003534d, y: 0.618823324108941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433209575639185d, y: 0.2200728617434915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6746843065048381d, y: 0.8325791179866393d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5414671228495848d, y: 0.7891523870310189d), new NpgsqlTypes.NpgsqlPoint(x: 0.6910927507399914d, y: 0.8950743691749228d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823928987381826d, y: 0.783115202370833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.83340838493866d, y: 0.38551598084540784d), new NpgsqlTypes.NpgsqlPoint(x: 0.8582199577855589d, y: 0.21147279507062378d), new NpgsqlTypes.NpgsqlPoint(x: 0.05452827692595519d, y: 0.837428410816337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3667637276146317d, y: 0.5191978653892774d), new NpgsqlTypes.NpgsqlPoint(x: 0.6887700416126441d, y: 0.8346107304607668d), new NpgsqlTypes.NpgsqlPoint(x: 0.32619909575250605d, y: 0.04900934409566515d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31996188948463933d, y: 0.5666213954536051d), new NpgsqlTypes.NpgsqlPoint(x: 0.3478909529093237d, y: 0.447736351179583d), new NpgsqlTypes.NpgsqlPoint(x: 0.3568162321067493d, y: 0.2574131099099338d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3000551011822319d, y: 0.7342957398195045d), new NpgsqlTypes.NpgsqlPoint(x: 0.0887024236462629d, y: 0.08787436707966834d), new NpgsqlTypes.NpgsqlPoint(x: 0.32483364569120377d, y: 0.24996342544122752d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.425613426878231d, y: 0.6136067433531093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4986656242730829d, y: 0.8635038634172288d), new NpgsqlTypes.NpgsqlPoint(x: 0.39999297563677216d, y: 0.3160732844308046d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7464479709653116d, y: 0.986053066556392d), new NpgsqlTypes.NpgsqlPoint(x: 0.3289863273625022d, y: 0.31808554676247636d), new NpgsqlTypes.NpgsqlPoint(x: 0.22563013564858148d, y: 0.9887144609517879d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05511888102182505d, y: 0.4818526971391942d), new NpgsqlTypes.NpgsqlPoint(x: 0.6698363301511855d, y: 0.9273646868257168d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350734465363661d, y: 0.5137132779050392d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.76706748318686d, y: 0.4061870223221946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8077950400033181d, y: 0.3386386478951987d), new NpgsqlTypes.NpgsqlPoint(x: 0.07420873494742941d, y: 0.8991497016827114d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8834872970399191d, y: 0.7530094804277425d), new NpgsqlTypes.NpgsqlPoint(x: 0.23325795747304034d, y: 0.926447350241891d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433476972013466d, y: 0.1286225547596367d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6018806631911364d, y: 0.6549292302425082d), new NpgsqlTypes.NpgsqlPoint(x: 0.2759650841826108d, y: 0.32921695293816744d), new NpgsqlTypes.NpgsqlPoint(x: 0.26938057711312413d, y: 0.027982560727177863d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05518546541931324d, y: 0.3171151142971349d), new NpgsqlTypes.NpgsqlPoint(x: 0.3223889209491896d, y: 0.272580988020128d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974583072020596d, y: 0.42401075132033406d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6353141407924893d, y: 0.6710771125203542d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469876992936156d, y: 0.7427134152305028d), new NpgsqlTypes.NpgsqlPoint(x: 0.30397163442980624d, y: 0.8292335654596984d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7854024071708138d, y: 0.9749596723213283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7262413517805703d, y: 0.8022176831982178d), new NpgsqlTypes.NpgsqlPoint(x: 0.7556552993183697d, y: 0.183710280538132d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42983817962023263d, y: 0.034770678671387056d), new NpgsqlTypes.NpgsqlPoint(x: 0.5883797853195776d, y: 0.4827584033632245d), new NpgsqlTypes.NpgsqlPoint(x: 0.21197945212514402d, y: 0.10102903436137134d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19490296560220532d, y: 0.8936491848916066d), new NpgsqlTypes.NpgsqlPoint(x: 0.009306555538151184d, y: 0.6593133844324034d), new NpgsqlTypes.NpgsqlPoint(x: 0.4534183034906277d, y: 0.7795019739602567d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16759475151539016d, y: 0.8522121177086107d), new NpgsqlTypes.NpgsqlPoint(x: 0.23631620275358634d, y: 0.6870002171471175d), new NpgsqlTypes.NpgsqlPoint(x: 0.884524802342229d, y: 0.8235342541753051d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4636359891611813d, y: 0.3479344729735997d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368493031716059d, y: 0.3478807515731692d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779988803081234d, y: 0.8118653693585991d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7640815292156623d, y: 0.8921428566038216d), new NpgsqlTypes.NpgsqlPoint(x: 0.8173350059515628d, y: 0.5182083419850414d), new NpgsqlTypes.NpgsqlPoint(x: 0.8521086429629511d, y: 0.8444411750283376d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.500343598281681d, y: 0.6875475181192157d), new NpgsqlTypes.NpgsqlPoint(x: 0.2655367559530223d, y: 0.5661291737934058d), new NpgsqlTypes.NpgsqlPoint(x: 0.11577543589300865d, y: 0.1812127020772395d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6194711020793489d, y: 0.5247431327597197d), new NpgsqlTypes.NpgsqlPoint(x: 0.4458169027652107d, y: 0.15789435321893586d), new NpgsqlTypes.NpgsqlPoint(x: 0.8177256922296012d, y: 0.16143763446947035d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5013149907140059d, y: 0.45659790234482145d), new NpgsqlTypes.NpgsqlPoint(x: 0.793399796242219d, y: 0.2631558137841894d), new NpgsqlTypes.NpgsqlPoint(x: 0.05493641542593786d, y: 0.8924816247347387d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20426457324031788d, y: 0.005087316133194575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8909745115106923d, y: 0.16632337181484202d), new NpgsqlTypes.NpgsqlPoint(x: 0.1367926226628563d, y: 0.28065765055320424d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8355228381785708d, y: 0.4557460959804577d), new NpgsqlTypes.NpgsqlPoint(x: 0.1433073295393209d, y: 0.773917394948139d), new NpgsqlTypes.NpgsqlPoint(x: 0.20373146788561902d, y: 0.4977543456485356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11066300690839026d, y: 0.8120896290706529d), new NpgsqlTypes.NpgsqlPoint(x: 0.1994639870622943d, y: 0.6640151956374329d), new NpgsqlTypes.NpgsqlPoint(x: 0.2830112683768633d, y: 0.6257206501254794d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8318058306681825d, y: 0.14469430752072732d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875952756616912d, y: 0.2320262001944532d), new NpgsqlTypes.NpgsqlPoint(x: 0.7730325946902755d, y: 0.7389493537052693d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4632660944831287d, y: 0.60760391660214d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728401254297601d, y: 0.990063319331732d), new NpgsqlTypes.NpgsqlPoint(x: 0.154265981266266d, y: 0.13930060987268167d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8441069670075678d, y: 0.5130812880339961d), new NpgsqlTypes.NpgsqlPoint(x: 0.6114024520903931d, y: 0.6189696608701521d), new NpgsqlTypes.NpgsqlPoint(x: 0.8517358502307564d, y: 0.36851692267639413d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5241264882928302d, y: 0.21277676434498805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381069815803063d, y: 0.9571154181197065d), new NpgsqlTypes.NpgsqlPoint(x: 0.3770958420099654d, y: 0.5870501459264366d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4495463171217374d, y: 0.414387510943958d), new NpgsqlTypes.NpgsqlPoint(x: 0.788746225676789d, y: 0.6094980516262455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7530427466644349d, y: 0.42432255683576503d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31494224775247115d, y: 0.7459168897482661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5995422951053804d, y: 0.594187948430412d), new NpgsqlTypes.NpgsqlPoint(x: 0.07868864075495774d, y: 0.9964944402281067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6993935255051035d, y: 0.6270843376341759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890924056115688d, y: 0.644052384786325d), new NpgsqlTypes.NpgsqlPoint(x: 0.32732148604703515d, y: 0.21517272424798806d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4757293255597401d, y: 0.370322504153098d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731385118193186d, y: 0.8910138417298546d), new NpgsqlTypes.NpgsqlPoint(x: 0.4557277453931745d, y: 0.4037885110878352d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9198731315397353d, y: 0.6748217131285722d), new NpgsqlTypes.NpgsqlPoint(x: 0.4972050136341175d, y: 0.09366011618934811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7729860071423373d, y: 0.6483017485824876d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28195448325390515d, y: 0.5159850093088314d), new NpgsqlTypes.NpgsqlPoint(x: 0.8066713085957389d, y: 0.6409006459631714d), new NpgsqlTypes.NpgsqlPoint(x: 0.17825422952002834d, y: 0.5565488617837757d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3414282945715609d, y: 0.767838191510304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536311772744369d, y: 0.027306842670566378d), new NpgsqlTypes.NpgsqlPoint(x: 0.39674197806217804d, y: 0.3980033728585922d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06345749538895229d, y: 0.8688717168671775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2916457858006829d, y: 0.9710682076976381d), new NpgsqlTypes.NpgsqlPoint(x: 0.845212550782184d, y: 0.12811258852857843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20690597757727314d, y: 0.6440846708936513d), new NpgsqlTypes.NpgsqlPoint(x: 0.9602304480114268d, y: 0.664160237099142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5538760525449796d, y: 0.10041670659883317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5135411273402097d, y: 0.13710003061332554d), new NpgsqlTypes.NpgsqlPoint(x: 0.22759588061271074d, y: 0.02624142254694284d), new NpgsqlTypes.NpgsqlPoint(x: 0.07662108421208325d, y: 0.10216046078240404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4361637689195098d, y: 0.8269199727728112d), new NpgsqlTypes.NpgsqlPoint(x: 0.4527410560754431d, y: 0.5144714072681712d), new NpgsqlTypes.NpgsqlPoint(x: 0.48590492253034256d, y: 0.204786781367705d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2152184301070017d, y: 0.3222160239371682d), new NpgsqlTypes.NpgsqlPoint(x: 0.7066120510104889d, y: 0.09234425928795909d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921808065780809d, y: 0.12117357969287612d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19432711489283683d, y: 0.5961529596375471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016634522348254d, y: 0.546693634924638d), new NpgsqlTypes.NpgsqlPoint(x: 0.39284528648027683d, y: 0.29682588665411713d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38279702510467484d, y: 0.8272935181992749d), new NpgsqlTypes.NpgsqlPoint(x: 0.6782690644145958d, y: 0.6898407841479287d), new NpgsqlTypes.NpgsqlPoint(x: 0.710481227580856d, y: 0.9959986092279646d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9950835649547893d, y: 0.19659537293097828d), new NpgsqlTypes.NpgsqlPoint(x: 0.12189681698010979d, y: 0.8150067734291303d), new NpgsqlTypes.NpgsqlPoint(x: 0.08842734121230034d, y: 0.21552452154950286d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5483663649531197d, y: 0.3625907222014306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7102589768335982d, y: 0.05759315900714723d), new NpgsqlTypes.NpgsqlPoint(x: 0.24825900407916535d, y: 0.2972555359436174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6003316035422361d, y: 0.0020302218619430157d), new NpgsqlTypes.NpgsqlPoint(x: 0.12173820402806801d, y: 0.3506897686817235d), new NpgsqlTypes.NpgsqlPoint(x: 0.2576760322983278d, y: 0.7156857273740042d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1496188796673209d, y: 0.6670698358934254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841133671702607d, y: 0.300024406931909d), new NpgsqlTypes.NpgsqlPoint(x: 0.026429168834695815d, y: 0.6232157369313516d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8658918539721595d, y: 0.3667503755145127d), new NpgsqlTypes.NpgsqlPoint(x: 0.4540653937758691d, y: 0.3951239968268144d), new NpgsqlTypes.NpgsqlPoint(x: 0.3825676421411631d, y: 0.5355002660827098d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20245667301163062d, y: 0.747070517771063d), new NpgsqlTypes.NpgsqlPoint(x: 0.07086024823330705d, y: 0.156163195653379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9385852530096928d, y: 0.2925626890346449d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8368812788438917d, y: 0.8422567931417315d), new NpgsqlTypes.NpgsqlPoint(x: 0.26340340928502504d, y: 0.9142241614212135d), new NpgsqlTypes.NpgsqlPoint(x: 0.16750942704891447d, y: 0.9557129607125942d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03497579412864815d, y: 0.8660200301316868d), new NpgsqlTypes.NpgsqlPoint(x: 0.27728884327192704d, y: 0.8022246274900239d), new NpgsqlTypes.NpgsqlPoint(x: 0.2293595324368044d, y: 0.8756050009833317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43007063240040655d, y: 0.6708442168663845d), new NpgsqlTypes.NpgsqlPoint(x: 0.39397088865742225d, y: 0.5709302158351539d), new NpgsqlTypes.NpgsqlPoint(x: 0.5892760024077668d, y: 0.07291329364935428d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8655117981397076d, y: 0.3601459591256395d), new NpgsqlTypes.NpgsqlPoint(x: 0.46338815627434293d, y: 0.8908810966482117d), new NpgsqlTypes.NpgsqlPoint(x: 0.2430044530457769d, y: 0.13050800932307505d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 5.02185810132838E-05d, y: 0.17158722089696188d), new NpgsqlTypes.NpgsqlPoint(x: 0.05437380092917199d, y: 0.9472867747139749d), new NpgsqlTypes.NpgsqlPoint(x: 0.30015853389075364d, y: 0.3973484874871387d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16444116581620272d, y: 0.9444861816819393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7064839207136147d, y: 0.2000115509901007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350833099367745d, y: 0.9056306252022243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15225688360540868d, y: 0.3364000882244438d), new NpgsqlTypes.NpgsqlPoint(x: 0.26647823702719364d, y: 0.24872022112951753d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927033425865821d, y: 0.9884513677306523d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.769774412132936d, y: 0.49600333187138d), new NpgsqlTypes.NpgsqlPoint(x: 0.7623315697061662d, y: 0.6149811835997159d), new NpgsqlTypes.NpgsqlPoint(x: 0.20116932608709404d, y: 0.7584444755929298d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2981175749838355d, y: 0.059976720043284915d), new NpgsqlTypes.NpgsqlPoint(x: 0.42301397119575057d, y: 0.1885807697114894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5787554263916346d, y: 0.42505362715622474d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6523411444415425d, y: 0.9779244096787608d), new NpgsqlTypes.NpgsqlPoint(x: 0.17110027688802765d, y: 0.7877059717336313d), new NpgsqlTypes.NpgsqlPoint(x: 0.3333669793319489d, y: 0.8354309614036265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3014305511489782d, y: 0.41948577917051344d), new NpgsqlTypes.NpgsqlPoint(x: 0.737601956425287d, y: 0.668593996174296d), new NpgsqlTypes.NpgsqlPoint(x: 0.19060674537615463d, y: 0.7821002316690611d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5800205176449863d, y: 0.7565895264010036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2818154881528362d, y: 0.9452326903753961d), new NpgsqlTypes.NpgsqlPoint(x: 0.3871574818123139d, y: 0.3790132185066114d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6654466748392462d, y: 0.7800155076114204d), new NpgsqlTypes.NpgsqlPoint(x: 0.0695572341503472d, y: 0.30540699204886024d), new NpgsqlTypes.NpgsqlPoint(x: 0.14500652463507957d, y: 0.9018337331713245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3898501041941439d, y: 0.7568968990281947d), new NpgsqlTypes.NpgsqlPoint(x: 0.0786726041388055d, y: 0.49131913254928383d), new NpgsqlTypes.NpgsqlPoint(x: 0.03941171746965022d, y: 0.7721367770176549d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                List<NpgsqlPathpathListD1E2M> models = null;

                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathListD1E2M> models = null;

                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 121;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 24, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 112, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 44, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 11, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 44, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatch(connection, 100, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models = await ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[10], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[11], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[12], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[13], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[14], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[15], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[16], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[17], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[18], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[19], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[20], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[21], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[22], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[23], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[24], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[25], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[10], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[11], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[12], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[13], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[14], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[15], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[16], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[17], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[18], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[19], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[20], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[21], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[22], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[23], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[24], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[25], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
FROM public.binary_npgsqlpathpathlistd1e2m m
LEFT JOIN public.binary_npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathListpathListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI), typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                await ((INpgsqlPathListpathListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                ((INpgsqlPathListpathListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

