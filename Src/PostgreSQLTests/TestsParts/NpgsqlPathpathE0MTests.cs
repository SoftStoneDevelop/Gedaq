

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpathE0M[] _testData = new NpgsqlPathpathE0M[]
        {
            new NpgsqlPathpathE0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7805678421287474d, y: 0.9946367989700513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5860423541186619d, y: 0.19345453194748297d), new NpgsqlTypes.NpgsqlPoint(x: 0.436146427325269d, y: 0.9943750124857347d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2495738424064614d, y: 0.8296163194434842d), new NpgsqlTypes.NpgsqlPoint(x: 0.20933899221143992d, y: 0.8029212886204813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722335944606463d, y: 0.9230541998266526d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.309647568729326d, y: 0.8079632858113969d), new NpgsqlTypes.NpgsqlPoint(x: 0.9806757937536066d, y: 0.7777774895556511d), new NpgsqlTypes.NpgsqlPoint(x: 0.89139346275617d, y: 0.36800859188086943d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4546583588515295d, y: 0.3971405333050454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4789624623878437d, y: 0.6707169174619896d), new NpgsqlTypes.NpgsqlPoint(x: 0.36275010461743806d, y: 0.810209548820241d)),
},
            new NpgsqlPathpathE0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21211120305869957d, y: 0.00459990213402417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972697015227648d, y: 0.6674529325391961d), new NpgsqlTypes.NpgsqlPoint(x: 0.502815401381173d, y: 0.7538324641504878d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8140284869595201d, y: 0.8879740922308539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404525589539523d, y: 0.5144950444484901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5007134385875875d, y: 0.39838761081762475d)),
},
            new NpgsqlPathpathE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45686051027863384d, y: 0.6747242873673436d), new NpgsqlTypes.NpgsqlPoint(x: 0.49788734408208324d, y: 0.6405747643465294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9169505666396525d, y: 0.03421831477920123d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17864456091755132d, y: 0.7078337962246044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452372992792961d, y: 0.5951040779136663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009553678010506d, y: 0.04300975083203917d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10497391401116052d, y: 0.7280169475260428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441794258197379d, y: 0.5038733476908646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439590404977406d, y: 0.9076114730178882d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058840118270987674d, y: 0.06252067923860194d), new NpgsqlTypes.NpgsqlPoint(x: 0.6952572676476547d, y: 0.4619114386912999d), new NpgsqlTypes.NpgsqlPoint(x: 0.773392918425869d, y: 0.6669549653668019d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6678897739109402d, y: 0.7813093262388923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880837670703066d, y: 0.11377723642869042d), new NpgsqlTypes.NpgsqlPoint(x: 0.09379795427474225d, y: 0.0849364537944669d)),
},
            new NpgsqlPathpathE0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35959007230190043d, y: 0.05872360665154319d), new NpgsqlTypes.NpgsqlPoint(x: 0.3933110453532984d, y: 0.1877051186835169d), new NpgsqlTypes.NpgsqlPoint(x: 0.5685041342161232d, y: 0.5925791360081171d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4436694832856376d, y: 0.6484341950296145d), new NpgsqlTypes.NpgsqlPoint(x: 0.658456179601883d, y: 0.6141897288129547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852846860350659d, y: 0.7412650849729543d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5198094590432335d, y: 0.2187717686456908d), new NpgsqlTypes.NpgsqlPoint(x: 0.35040574619417963d, y: 0.6800210158004167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706810791008987d, y: 0.9656883684981513d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1350491967858234d, y: 0.18335106410440294d), new NpgsqlTypes.NpgsqlPoint(x: 0.0768122898670961d, y: 0.22128821880332084d), new NpgsqlTypes.NpgsqlPoint(x: 0.03935533372483857d, y: 0.4446893337281662d)),
},
            new NpgsqlPathpathE0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20359745130158025d, y: 0.35363857873435156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8004226406410455d, y: 0.4368378679473047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273661562650154d, y: 0.24951238743697302d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9424952918523009d, y: 0.19507249378813174d), new NpgsqlTypes.NpgsqlPoint(x: 0.4406083888727549d, y: 0.8706190765890066d), new NpgsqlTypes.NpgsqlPoint(x: 0.2333050236866554d, y: 0.8340390545533941d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8824092960505511d, y: 0.13628908908803328d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483849664232903d, y: 0.032353976095214065d), new NpgsqlTypes.NpgsqlPoint(x: 0.761178795573137d, y: 0.2979337092586395d)),
},
            new NpgsqlPathpathE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22964835601610856d, y: 0.36064543473060073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5496329336834186d, y: 0.3152942495543657d), new NpgsqlTypes.NpgsqlPoint(x: 0.43227527190529536d, y: 0.28424426665574287d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7993528427454218d, y: 0.25626678087290655d), new NpgsqlTypes.NpgsqlPoint(x: 0.4549087580917256d, y: 0.03383241274459925d), new NpgsqlTypes.NpgsqlPoint(x: 0.21055266675978224d, y: 0.7735427334966918d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9273809676800415d, y: 0.5880876024099706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8977856201124347d, y: 0.041816465421325666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095913499359294d, y: 0.7039394132682602d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3632524053274184d, y: 0.11991091983565982d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376852007007664d, y: 0.9944524213623457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936160000352757d, y: 0.8011125809865065d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5413097718782492d, y: 0.6756051843706182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2889844175605347d, y: 0.4487342750213653d), new NpgsqlTypes.NpgsqlPoint(x: 0.4665784426229145d, y: 0.9252920339852585d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3532943432527803d, y: 0.7619892869872802d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653410643962103d, y: 0.1918791243075224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4227633075993311d, y: 0.9566332198822671d)),
},
            new NpgsqlPathpathE0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9040551859664665d, y: 0.9953849666942163d), new NpgsqlTypes.NpgsqlPoint(x: 0.18700208499100834d, y: 0.8757805966755623d), new NpgsqlTypes.NpgsqlPoint(x: 0.45931189902909475d, y: 0.8057117526261024d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5752840694698274d, y: 0.36331034691720554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837427788931891d, y: 0.28139777797094456d), new NpgsqlTypes.NpgsqlPoint(x: 0.1436015475614304d, y: 0.45543043175048525d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6571889653215064d, y: 0.18675277984893235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040696924163142d, y: 0.04009720100602465d), new NpgsqlTypes.NpgsqlPoint(x: 0.844254891214068d, y: 0.9609294330758014d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5976166614634939d, y: 0.4497778193533245d), new NpgsqlTypes.NpgsqlPoint(x: 0.7913655571139421d, y: 0.2859912576584698d), new NpgsqlTypes.NpgsqlPoint(x: 0.4294403839041748d, y: 0.21878687567995725d)),
},
            new NpgsqlPathpathE0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7464038631082018d, y: 0.8920244777343582d), new NpgsqlTypes.NpgsqlPoint(x: 0.911678969700112d, y: 0.8368048603206811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8174217523065319d, y: 0.9670238238676857d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7516397854779477d, y: 0.28578501765829434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4563440876960214d, y: 0.5218558234676285d), new NpgsqlTypes.NpgsqlPoint(x: 0.42097772486338336d, y: 0.6933278756278896d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8168700502715339d, y: 0.40604161440136677d), new NpgsqlTypes.NpgsqlPoint(x: 0.1608216877964329d, y: 0.8490227361463263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129511019703682d, y: 0.198825673374195d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8357262299886614d, y: 0.7936113770213066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182706099238441d, y: 0.39191038259043187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5834813003801883d, y: 0.25904386475840735d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6770360013499042d, y: 0.7812897255513831d), new NpgsqlTypes.NpgsqlPoint(x: 0.2254332255974114d, y: 0.6722441396549762d), new NpgsqlTypes.NpgsqlPoint(x: 0.09170301769603517d, y: 0.4530385981620213d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6347831141584293d, y: 0.940838490939078d), new NpgsqlTypes.NpgsqlPoint(x: 0.1436237876452553d, y: 0.6181402210260707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8707335867798669d, y: 0.021080293135145922d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4255754257316511d, y: 0.6618141117929003d), new NpgsqlTypes.NpgsqlPoint(x: 0.1309708363187494d, y: 0.44128781844871356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216450578297422d, y: 0.9967805854633144d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.758994394993652d, y: 0.13949376933527757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7370699940382497d, y: 0.6300216755642496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9537840185775588d, y: 0.14128688903346787d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.988295920156021d, y: 0.7076449821715993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068918739609504d, y: 0.03498684947331665d), new NpgsqlTypes.NpgsqlPoint(x: 0.44589611088642744d, y: 0.20971590075764912d)),
},
            new NpgsqlPathpathE0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1475474569029872d, y: 0.24807388956982923d), new NpgsqlTypes.NpgsqlPoint(x: 0.05260719685676174d, y: 0.2890252756099838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5706037197347374d, y: 0.8146738744909895d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3848578110450932d, y: 0.9841466988680889d), new NpgsqlTypes.NpgsqlPoint(x: 0.24100090727072665d, y: 0.9374764999900427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568918683738338d, y: 0.9164268408685345d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08102603370044392d, y: 0.6353002744283706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018003516926925d, y: 0.8251274843440324d), new NpgsqlTypes.NpgsqlPoint(x: 0.02575415506732559d, y: 0.9594908416290946d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4640577377151591d, y: 0.08320225443159368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817946946522842d, y: 0.2501230751637914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901287230880148d, y: 0.3240018572352964d)),
},
            new NpgsqlPathpathE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7172277968664448d, y: 0.1830072099211706d), new NpgsqlTypes.NpgsqlPoint(x: 0.25898511591478535d, y: 0.07162898573992582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252968412467138d, y: 0.24516654956117845d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14980542118464157d, y: 0.6465680353577846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924606692374441d, y: 0.7484147932218084d), new NpgsqlTypes.NpgsqlPoint(x: 0.055062252920051846d, y: 0.44326210723199133d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4898835288699033d, y: 0.3258762608879444d), new NpgsqlTypes.NpgsqlPoint(x: 0.26791492636672465d, y: 0.2707623090661564d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601062717752551d, y: 0.5765512259383861d)),
},
            new NpgsqlPathpathE0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12652948974224498d, y: 0.8727314895008873d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232727321270297d, y: 0.7111439059249229d), new NpgsqlTypes.NpgsqlPoint(x: 0.2606192771621847d, y: 0.625248174202381d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4651135656564782d, y: 0.3519144060724666d), new NpgsqlTypes.NpgsqlPoint(x: 0.011144090523746875d, y: 0.68519250808141d), new NpgsqlTypes.NpgsqlPoint(x: 0.44054865580154057d, y: 0.9055832615335975d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18964072485894756d, y: 0.29477441063158194d), new NpgsqlTypes.NpgsqlPoint(x: 0.4402835563999413d, y: 0.814590280360034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5242058032249636d, y: 0.5633242544088869d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.884466584731049d, y: 0.728356959090348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468957454669312d, y: 0.5183554344227576d), new NpgsqlTypes.NpgsqlPoint(x: 0.44755926459122164d, y: 0.13349433716053338d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8507059714403239d, y: 0.7979849869059235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6839330419532517d, y: 0.9785401430152083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5373506654958403d, y: 0.6122785579352183d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5430652172611231d, y: 0.3679790640723175d), new NpgsqlTypes.NpgsqlPoint(x: 0.15073506327550168d, y: 0.04187928354761805d), new NpgsqlTypes.NpgsqlPoint(x: 0.04425298756162366d, y: 0.781533918615595d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7452643383524722d, y: 0.4399196819291772d), new NpgsqlTypes.NpgsqlPoint(x: 0.29453133400427056d, y: 0.8530677480549599d), new NpgsqlTypes.NpgsqlPoint(x: 0.28471696252983936d, y: 0.6997562318755166d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30520803157119947d, y: 0.5102645221790721d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268139833237782d, y: 0.9880892979023851d), new NpgsqlTypes.NpgsqlPoint(x: 0.00849651158044118d, y: 0.23019163328525893d)),
},
            new NpgsqlPathpathE0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01621915035469146d, y: 0.18125810112353935d), new NpgsqlTypes.NpgsqlPoint(x: 0.16217030654831288d, y: 0.43651771903966285d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005497068560824d, y: 0.1217350775864563d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9603988382013622d, y: 0.00662089620539652d), new NpgsqlTypes.NpgsqlPoint(x: 0.37896285836893395d, y: 0.892313044812811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8843836081681279d, y: 0.47936595248975866d)),
},
            new NpgsqlPathpathE0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15185337047457892d, y: 0.5872527122898861d), new NpgsqlTypes.NpgsqlPoint(x: 0.08136308353958221d, y: 0.7681184380855803d), new NpgsqlTypes.NpgsqlPoint(x: 0.010933105854015746d, y: 0.643309713815162d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8464105769174644d, y: 0.9762564239324816d), new NpgsqlTypes.NpgsqlPoint(x: 0.06264741311048261d, y: 0.860307431316267d), new NpgsqlTypes.NpgsqlPoint(x: 0.34732533243210406d, y: 0.5848978815966954d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13107252607044684d, y: 0.7598075349999566d), new NpgsqlTypes.NpgsqlPoint(x: 0.11190439446393041d, y: 0.06405404792547309d), new NpgsqlTypes.NpgsqlPoint(x: 0.30772284325025356d, y: 0.4211605566537452d)),
},
            new NpgsqlPathpathE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9154655145485366d, y: 0.3102784381555226d), new NpgsqlTypes.NpgsqlPoint(x: 0.3331148752622288d, y: 0.4847818941296159d), new NpgsqlTypes.NpgsqlPoint(x: 0.977607173894711d, y: 0.003987975909234276d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7486746208252909d, y: 0.5245250956539933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8344816870856995d, y: 0.9049896806238567d), new NpgsqlTypes.NpgsqlPoint(x: 0.7479427207541213d, y: 0.8470858070093952d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6728115402296435d, y: 0.2512830003879415d), new NpgsqlTypes.NpgsqlPoint(x: 0.4507213341899877d, y: 0.4645869695445779d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606614019391738d, y: 0.11128611203271954d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6174148831590591d, y: 0.8991088579112287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331629642983782d, y: 0.6059767962249527d), new NpgsqlTypes.NpgsqlPoint(x: 0.2660290704586007d, y: 0.757249180783954d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6123542683656363d, y: 0.30305241078092426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3826694596854363d, y: 0.7430214008200489d), new NpgsqlTypes.NpgsqlPoint(x: 0.20963322292314457d, y: 0.8341765460494989d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8144006576233105d, y: 0.20797998237551352d), new NpgsqlTypes.NpgsqlPoint(x: 0.2764633788139844d, y: 0.04272290736485418d), new NpgsqlTypes.NpgsqlPoint(x: 0.37960645221092704d, y: 0.7758842502268636d)),
},
            new NpgsqlPathpathE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6793919187267643d, y: 0.05234418165218213d), new NpgsqlTypes.NpgsqlPoint(x: 0.4797449405464077d, y: 0.680388540150929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293818815609614d, y: 0.7470248045133544d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49829041859283774d, y: 0.8524497271507129d), new NpgsqlTypes.NpgsqlPoint(x: 0.49669946448723956d, y: 0.7484277767751382d), new NpgsqlTypes.NpgsqlPoint(x: 0.08959755091442068d, y: 0.5085723610924668d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17632323536504801d, y: 0.3956479841557955d), new NpgsqlTypes.NpgsqlPoint(x: 0.10058960348969048d, y: 0.1547750858497402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5416218818563644d, y: 0.16325659215083d)),
},
            new NpgsqlPathpathE0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4315429749194326d, y: 0.6602883976351313d), new NpgsqlTypes.NpgsqlPoint(x: 0.0869386963365274d, y: 0.10282856813872054d), new NpgsqlTypes.NpgsqlPoint(x: 0.49517441043046917d, y: 0.42091844014378843d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49208268639216024d, y: 0.8422924291826678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205650520016283d, y: 0.9801704909726742d), new NpgsqlTypes.NpgsqlPoint(x: 0.005793425783417683d, y: 0.827744881260204d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4106648871612547d, y: 0.8994175921715363d), new NpgsqlTypes.NpgsqlPoint(x: 0.163486476154029d, y: 0.9270955299305299d), new NpgsqlTypes.NpgsqlPoint(x: 0.516053781533496d, y: 0.41575930113684856d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9862594163853206d, y: 0.5864343007358699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8223876013785778d, y: 0.34332671817823424d), new NpgsqlTypes.NpgsqlPoint(x: 0.44614508563128275d, y: 0.9039345406401239d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9795398528101648d, y: 0.849579499204895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252441972634424d, y: 0.5770488200917772d), new NpgsqlTypes.NpgsqlPoint(x: 0.4961762051413474d, y: 0.25375806299303993d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5716664855496877d, y: 0.7721004700853292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168735655648181d, y: 0.6901374386162608d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086600877896454d, y: 0.39504723073776304d)),
},
            new NpgsqlPathpathE0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9583796562445357d, y: 0.4399150266238012d), new NpgsqlTypes.NpgsqlPoint(x: 0.06714427194972394d, y: 0.3470780009717981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9354477363929057d, y: 0.6921759514539351d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5255841422976222d, y: 0.8841571636008451d), new NpgsqlTypes.NpgsqlPoint(x: 0.08746512228162084d, y: 0.8975423510880401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5792220656349166d, y: 0.5719567652556813d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6917863714725131d, y: 0.4462784683949492d), new NpgsqlTypes.NpgsqlPoint(x: 0.0064196945993479915d, y: 0.7858940379322992d), new NpgsqlTypes.NpgsqlPoint(x: 0.2694330864835446d, y: 0.7161889015395205d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7360817845084343d, y: 0.5991065357559379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727711981127105d, y: 0.14057552754613023d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434967922615024d, y: 0.7998641723379294d)),
},
            new NpgsqlPathpathE0M
{
    Id = 164,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.306597232358898d, y: 0.064363729865202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7661028507938831d, y: 0.7834409543863139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726248623353854d, y: 0.6393991794441258d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6678897739109402d, y: 0.7813093262388923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880837670703066d, y: 0.11377723642869042d), new NpgsqlTypes.NpgsqlPoint(x: 0.09379795427474225d, y: 0.0849364537944669d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1350491967858234d, y: 0.18335106410440294d), new NpgsqlTypes.NpgsqlPoint(x: 0.0768122898670961d, y: 0.22128821880332084d), new NpgsqlTypes.NpgsqlPoint(x: 0.03935533372483857d, y: 0.4446893337281662d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8824092960505511d, y: 0.13628908908803328d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483849664232903d, y: 0.032353976095214065d), new NpgsqlTypes.NpgsqlPoint(x: 0.761178795573137d, y: 0.2979337092586395d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3532943432527803d, y: 0.7619892869872802d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653410643962103d, y: 0.1918791243075224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4227633075993311d, y: 0.9566332198822671d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpathe0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpathe0mi_id", 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 22, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 76, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 143, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 61, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 54, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 140, query1, 76, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 53, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 49))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 40, 110))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[9], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[10], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[11], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[12], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[13], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[14], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[20],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[21],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[22],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[23],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[24],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[11], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[12], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[13], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[14], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[20],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[21],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[22],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7805678421287474d, y: 0.9946367989700513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5860423541186619d, y: 0.19345453194748297d), new NpgsqlTypes.NpgsqlPoint(x: 0.436146427325269d, y: 0.9943750124857347d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2495738424064614d, y: 0.8296163194434842d), new NpgsqlTypes.NpgsqlPoint(x: 0.20933899221143992d, y: 0.8029212886204813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722335944606463d, y: 0.9230541998266526d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.309647568729326d, y: 0.8079632858113969d), new NpgsqlTypes.NpgsqlPoint(x: 0.9806757937536066d, y: 0.7777774895556511d), new NpgsqlTypes.NpgsqlPoint(x: 0.89139346275617d, y: 0.36800859188086943d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4546583588515295d, y: 0.3971405333050454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4789624623878437d, y: 0.6707169174619896d), new NpgsqlTypes.NpgsqlPoint(x: 0.36275010461743806d, y: 0.810209548820241d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21211120305869957d, y: 0.00459990213402417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972697015227648d, y: 0.6674529325391961d), new NpgsqlTypes.NpgsqlPoint(x: 0.502815401381173d, y: 0.7538324641504878d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8140284869595201d, y: 0.8879740922308539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404525589539523d, y: 0.5144950444484901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5007134385875875d, y: 0.39838761081762475d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45686051027863384d, y: 0.6747242873673436d), new NpgsqlTypes.NpgsqlPoint(x: 0.49788734408208324d, y: 0.6405747643465294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9169505666396525d, y: 0.03421831477920123d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17864456091755132d, y: 0.7078337962246044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452372992792961d, y: 0.5951040779136663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009553678010506d, y: 0.04300975083203917d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10497391401116052d, y: 0.7280169475260428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441794258197379d, y: 0.5038733476908646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439590404977406d, y: 0.9076114730178882d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058840118270987674d, y: 0.06252067923860194d), new NpgsqlTypes.NpgsqlPoint(x: 0.6952572676476547d, y: 0.4619114386912999d), new NpgsqlTypes.NpgsqlPoint(x: 0.773392918425869d, y: 0.6669549653668019d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6678897739109402d, y: 0.7813093262388923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880837670703066d, y: 0.11377723642869042d), new NpgsqlTypes.NpgsqlPoint(x: 0.09379795427474225d, y: 0.0849364537944669d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35959007230190043d, y: 0.05872360665154319d), new NpgsqlTypes.NpgsqlPoint(x: 0.3933110453532984d, y: 0.1877051186835169d), new NpgsqlTypes.NpgsqlPoint(x: 0.5685041342161232d, y: 0.5925791360081171d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4436694832856376d, y: 0.6484341950296145d), new NpgsqlTypes.NpgsqlPoint(x: 0.658456179601883d, y: 0.6141897288129547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852846860350659d, y: 0.7412650849729543d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5198094590432335d, y: 0.2187717686456908d), new NpgsqlTypes.NpgsqlPoint(x: 0.35040574619417963d, y: 0.6800210158004167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706810791008987d, y: 0.9656883684981513d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1350491967858234d, y: 0.18335106410440294d), new NpgsqlTypes.NpgsqlPoint(x: 0.0768122898670961d, y: 0.22128821880332084d), new NpgsqlTypes.NpgsqlPoint(x: 0.03935533372483857d, y: 0.4446893337281662d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20359745130158025d, y: 0.35363857873435156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8004226406410455d, y: 0.4368378679473047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273661562650154d, y: 0.24951238743697302d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9424952918523009d, y: 0.19507249378813174d), new NpgsqlTypes.NpgsqlPoint(x: 0.4406083888727549d, y: 0.8706190765890066d), new NpgsqlTypes.NpgsqlPoint(x: 0.2333050236866554d, y: 0.8340390545533941d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8824092960505511d, y: 0.13628908908803328d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483849664232903d, y: 0.032353976095214065d), new NpgsqlTypes.NpgsqlPoint(x: 0.761178795573137d, y: 0.2979337092586395d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22964835601610856d, y: 0.36064543473060073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5496329336834186d, y: 0.3152942495543657d), new NpgsqlTypes.NpgsqlPoint(x: 0.43227527190529536d, y: 0.28424426665574287d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7993528427454218d, y: 0.25626678087290655d), new NpgsqlTypes.NpgsqlPoint(x: 0.4549087580917256d, y: 0.03383241274459925d), new NpgsqlTypes.NpgsqlPoint(x: 0.21055266675978224d, y: 0.7735427334966918d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9273809676800415d, y: 0.5880876024099706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8977856201124347d, y: 0.041816465421325666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095913499359294d, y: 0.7039394132682602d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3632524053274184d, y: 0.11991091983565982d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376852007007664d, y: 0.9944524213623457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936160000352757d, y: 0.8011125809865065d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5413097718782492d, y: 0.6756051843706182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2889844175605347d, y: 0.4487342750213653d), new NpgsqlTypes.NpgsqlPoint(x: 0.4665784426229145d, y: 0.9252920339852585d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3532943432527803d, y: 0.7619892869872802d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653410643962103d, y: 0.1918791243075224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4227633075993311d, y: 0.9566332198822671d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9040551859664665d, y: 0.9953849666942163d), new NpgsqlTypes.NpgsqlPoint(x: 0.18700208499100834d, y: 0.8757805966755623d), new NpgsqlTypes.NpgsqlPoint(x: 0.45931189902909475d, y: 0.8057117526261024d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5752840694698274d, y: 0.36331034691720554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837427788931891d, y: 0.28139777797094456d), new NpgsqlTypes.NpgsqlPoint(x: 0.1436015475614304d, y: 0.45543043175048525d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6571889653215064d, y: 0.18675277984893235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040696924163142d, y: 0.04009720100602465d), new NpgsqlTypes.NpgsqlPoint(x: 0.844254891214068d, y: 0.9609294330758014d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5976166614634939d, y: 0.4497778193533245d), new NpgsqlTypes.NpgsqlPoint(x: 0.7913655571139421d, y: 0.2859912576584698d), new NpgsqlTypes.NpgsqlPoint(x: 0.4294403839041748d, y: 0.21878687567995725d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7464038631082018d, y: 0.8920244777343582d), new NpgsqlTypes.NpgsqlPoint(x: 0.911678969700112d, y: 0.8368048603206811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8174217523065319d, y: 0.9670238238676857d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7516397854779477d, y: 0.28578501765829434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4563440876960214d, y: 0.5218558234676285d), new NpgsqlTypes.NpgsqlPoint(x: 0.42097772486338336d, y: 0.6933278756278896d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8168700502715339d, y: 0.40604161440136677d), new NpgsqlTypes.NpgsqlPoint(x: 0.1608216877964329d, y: 0.8490227361463263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129511019703682d, y: 0.198825673374195d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8357262299886614d, y: 0.7936113770213066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182706099238441d, y: 0.39191038259043187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5834813003801883d, y: 0.25904386475840735d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6770360013499042d, y: 0.7812897255513831d), new NpgsqlTypes.NpgsqlPoint(x: 0.2254332255974114d, y: 0.6722441396549762d), new NpgsqlTypes.NpgsqlPoint(x: 0.09170301769603517d, y: 0.4530385981620213d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6347831141584293d, y: 0.940838490939078d), new NpgsqlTypes.NpgsqlPoint(x: 0.1436237876452553d, y: 0.6181402210260707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8707335867798669d, y: 0.021080293135145922d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4255754257316511d, y: 0.6618141117929003d), new NpgsqlTypes.NpgsqlPoint(x: 0.1309708363187494d, y: 0.44128781844871356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216450578297422d, y: 0.9967805854633144d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.758994394993652d, y: 0.13949376933527757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7370699940382497d, y: 0.6300216755642496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9537840185775588d, y: 0.14128688903346787d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.988295920156021d, y: 0.7076449821715993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068918739609504d, y: 0.03498684947331665d), new NpgsqlTypes.NpgsqlPoint(x: 0.44589611088642744d, y: 0.20971590075764912d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1475474569029872d, y: 0.24807388956982923d), new NpgsqlTypes.NpgsqlPoint(x: 0.05260719685676174d, y: 0.2890252756099838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5706037197347374d, y: 0.8146738744909895d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3848578110450932d, y: 0.9841466988680889d), new NpgsqlTypes.NpgsqlPoint(x: 0.24100090727072665d, y: 0.9374764999900427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568918683738338d, y: 0.9164268408685345d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08102603370044392d, y: 0.6353002744283706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018003516926925d, y: 0.8251274843440324d), new NpgsqlTypes.NpgsqlPoint(x: 0.02575415506732559d, y: 0.9594908416290946d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4640577377151591d, y: 0.08320225443159368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817946946522842d, y: 0.2501230751637914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901287230880148d, y: 0.3240018572352964d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7172277968664448d, y: 0.1830072099211706d), new NpgsqlTypes.NpgsqlPoint(x: 0.25898511591478535d, y: 0.07162898573992582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252968412467138d, y: 0.24516654956117845d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14980542118464157d, y: 0.6465680353577846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924606692374441d, y: 0.7484147932218084d), new NpgsqlTypes.NpgsqlPoint(x: 0.055062252920051846d, y: 0.44326210723199133d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4898835288699033d, y: 0.3258762608879444d), new NpgsqlTypes.NpgsqlPoint(x: 0.26791492636672465d, y: 0.2707623090661564d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601062717752551d, y: 0.5765512259383861d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12652948974224498d, y: 0.8727314895008873d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232727321270297d, y: 0.7111439059249229d), new NpgsqlTypes.NpgsqlPoint(x: 0.2606192771621847d, y: 0.625248174202381d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4651135656564782d, y: 0.3519144060724666d), new NpgsqlTypes.NpgsqlPoint(x: 0.011144090523746875d, y: 0.68519250808141d), new NpgsqlTypes.NpgsqlPoint(x: 0.44054865580154057d, y: 0.9055832615335975d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18964072485894756d, y: 0.29477441063158194d), new NpgsqlTypes.NpgsqlPoint(x: 0.4402835563999413d, y: 0.814590280360034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5242058032249636d, y: 0.5633242544088869d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.884466584731049d, y: 0.728356959090348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468957454669312d, y: 0.5183554344227576d), new NpgsqlTypes.NpgsqlPoint(x: 0.44755926459122164d, y: 0.13349433716053338d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8507059714403239d, y: 0.7979849869059235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6839330419532517d, y: 0.9785401430152083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5373506654958403d, y: 0.6122785579352183d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5430652172611231d, y: 0.3679790640723175d), new NpgsqlTypes.NpgsqlPoint(x: 0.15073506327550168d, y: 0.04187928354761805d), new NpgsqlTypes.NpgsqlPoint(x: 0.04425298756162366d, y: 0.781533918615595d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7452643383524722d, y: 0.4399196819291772d), new NpgsqlTypes.NpgsqlPoint(x: 0.29453133400427056d, y: 0.8530677480549599d), new NpgsqlTypes.NpgsqlPoint(x: 0.28471696252983936d, y: 0.6997562318755166d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30520803157119947d, y: 0.5102645221790721d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268139833237782d, y: 0.9880892979023851d), new NpgsqlTypes.NpgsqlPoint(x: 0.00849651158044118d, y: 0.23019163328525893d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01621915035469146d, y: 0.18125810112353935d), new NpgsqlTypes.NpgsqlPoint(x: 0.16217030654831288d, y: 0.43651771903966285d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005497068560824d, y: 0.1217350775864563d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9603988382013622d, y: 0.00662089620539652d), new NpgsqlTypes.NpgsqlPoint(x: 0.37896285836893395d, y: 0.892313044812811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8843836081681279d, y: 0.47936595248975866d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15185337047457892d, y: 0.5872527122898861d), new NpgsqlTypes.NpgsqlPoint(x: 0.08136308353958221d, y: 0.7681184380855803d), new NpgsqlTypes.NpgsqlPoint(x: 0.010933105854015746d, y: 0.643309713815162d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8464105769174644d, y: 0.9762564239324816d), new NpgsqlTypes.NpgsqlPoint(x: 0.06264741311048261d, y: 0.860307431316267d), new NpgsqlTypes.NpgsqlPoint(x: 0.34732533243210406d, y: 0.5848978815966954d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13107252607044684d, y: 0.7598075349999566d), new NpgsqlTypes.NpgsqlPoint(x: 0.11190439446393041d, y: 0.06405404792547309d), new NpgsqlTypes.NpgsqlPoint(x: 0.30772284325025356d, y: 0.4211605566537452d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9154655145485366d, y: 0.3102784381555226d), new NpgsqlTypes.NpgsqlPoint(x: 0.3331148752622288d, y: 0.4847818941296159d), new NpgsqlTypes.NpgsqlPoint(x: 0.977607173894711d, y: 0.003987975909234276d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7486746208252909d, y: 0.5245250956539933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8344816870856995d, y: 0.9049896806238567d), new NpgsqlTypes.NpgsqlPoint(x: 0.7479427207541213d, y: 0.8470858070093952d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6728115402296435d, y: 0.2512830003879415d), new NpgsqlTypes.NpgsqlPoint(x: 0.4507213341899877d, y: 0.4645869695445779d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606614019391738d, y: 0.11128611203271954d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6174148831590591d, y: 0.8991088579112287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331629642983782d, y: 0.6059767962249527d), new NpgsqlTypes.NpgsqlPoint(x: 0.2660290704586007d, y: 0.757249180783954d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6123542683656363d, y: 0.30305241078092426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3826694596854363d, y: 0.7430214008200489d), new NpgsqlTypes.NpgsqlPoint(x: 0.20963322292314457d, y: 0.8341765460494989d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8144006576233105d, y: 0.20797998237551352d), new NpgsqlTypes.NpgsqlPoint(x: 0.2764633788139844d, y: 0.04272290736485418d), new NpgsqlTypes.NpgsqlPoint(x: 0.37960645221092704d, y: 0.7758842502268636d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6793919187267643d, y: 0.05234418165218213d), new NpgsqlTypes.NpgsqlPoint(x: 0.4797449405464077d, y: 0.680388540150929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293818815609614d, y: 0.7470248045133544d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49829041859283774d, y: 0.8524497271507129d), new NpgsqlTypes.NpgsqlPoint(x: 0.49669946448723956d, y: 0.7484277767751382d), new NpgsqlTypes.NpgsqlPoint(x: 0.08959755091442068d, y: 0.5085723610924668d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17632323536504801d, y: 0.3956479841557955d), new NpgsqlTypes.NpgsqlPoint(x: 0.10058960348969048d, y: 0.1547750858497402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5416218818563644d, y: 0.16325659215083d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4315429749194326d, y: 0.6602883976351313d), new NpgsqlTypes.NpgsqlPoint(x: 0.0869386963365274d, y: 0.10282856813872054d), new NpgsqlTypes.NpgsqlPoint(x: 0.49517441043046917d, y: 0.42091844014378843d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49208268639216024d, y: 0.8422924291826678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205650520016283d, y: 0.9801704909726742d), new NpgsqlTypes.NpgsqlPoint(x: 0.005793425783417683d, y: 0.827744881260204d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4106648871612547d, y: 0.8994175921715363d), new NpgsqlTypes.NpgsqlPoint(x: 0.163486476154029d, y: 0.9270955299305299d), new NpgsqlTypes.NpgsqlPoint(x: 0.516053781533496d, y: 0.41575930113684856d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9862594163853206d, y: 0.5864343007358699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8223876013785778d, y: 0.34332671817823424d), new NpgsqlTypes.NpgsqlPoint(x: 0.44614508563128275d, y: 0.9039345406401239d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9795398528101648d, y: 0.849579499204895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252441972634424d, y: 0.5770488200917772d), new NpgsqlTypes.NpgsqlPoint(x: 0.4961762051413474d, y: 0.25375806299303993d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5716664855496877d, y: 0.7721004700853292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168735655648181d, y: 0.6901374386162608d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086600877896454d, y: 0.39504723073776304d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9583796562445357d, y: 0.4399150266238012d), new NpgsqlTypes.NpgsqlPoint(x: 0.06714427194972394d, y: 0.3470780009717981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9354477363929057d, y: 0.6921759514539351d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5255841422976222d, y: 0.8841571636008451d), new NpgsqlTypes.NpgsqlPoint(x: 0.08746512228162084d, y: 0.8975423510880401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5792220656349166d, y: 0.5719567652556813d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6917863714725131d, y: 0.4462784683949492d), new NpgsqlTypes.NpgsqlPoint(x: 0.0064196945993479915d, y: 0.7858940379322992d), new NpgsqlTypes.NpgsqlPoint(x: 0.2694330864835446d, y: 0.7161889015395205d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7360817845084343d, y: 0.5991065357559379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727711981127105d, y: 0.14057552754613023d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434967922615024d, y: 0.7998641723379294d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.306597232358898d, y: 0.064363729865202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7661028507938831d, y: 0.7834409543863139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726248623353854d, y: 0.6393991794441258d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7805678421287474d, y: 0.9946367989700513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5860423541186619d, y: 0.19345453194748297d), new NpgsqlTypes.NpgsqlPoint(x: 0.436146427325269d, y: 0.9943750124857347d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2495738424064614d, y: 0.8296163194434842d), new NpgsqlTypes.NpgsqlPoint(x: 0.20933899221143992d, y: 0.8029212886204813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722335944606463d, y: 0.9230541998266526d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.309647568729326d, y: 0.8079632858113969d), new NpgsqlTypes.NpgsqlPoint(x: 0.9806757937536066d, y: 0.7777774895556511d), new NpgsqlTypes.NpgsqlPoint(x: 0.89139346275617d, y: 0.36800859188086943d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4546583588515295d, y: 0.3971405333050454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4789624623878437d, y: 0.6707169174619896d), new NpgsqlTypes.NpgsqlPoint(x: 0.36275010461743806d, y: 0.810209548820241d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21211120305869957d, y: 0.00459990213402417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972697015227648d, y: 0.6674529325391961d), new NpgsqlTypes.NpgsqlPoint(x: 0.502815401381173d, y: 0.7538324641504878d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8140284869595201d, y: 0.8879740922308539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404525589539523d, y: 0.5144950444484901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5007134385875875d, y: 0.39838761081762475d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45686051027863384d, y: 0.6747242873673436d), new NpgsqlTypes.NpgsqlPoint(x: 0.49788734408208324d, y: 0.6405747643465294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9169505666396525d, y: 0.03421831477920123d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17864456091755132d, y: 0.7078337962246044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452372992792961d, y: 0.5951040779136663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009553678010506d, y: 0.04300975083203917d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10497391401116052d, y: 0.7280169475260428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441794258197379d, y: 0.5038733476908646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439590404977406d, y: 0.9076114730178882d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058840118270987674d, y: 0.06252067923860194d), new NpgsqlTypes.NpgsqlPoint(x: 0.6952572676476547d, y: 0.4619114386912999d), new NpgsqlTypes.NpgsqlPoint(x: 0.773392918425869d, y: 0.6669549653668019d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6678897739109402d, y: 0.7813093262388923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880837670703066d, y: 0.11377723642869042d), new NpgsqlTypes.NpgsqlPoint(x: 0.09379795427474225d, y: 0.0849364537944669d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35959007230190043d, y: 0.05872360665154319d), new NpgsqlTypes.NpgsqlPoint(x: 0.3933110453532984d, y: 0.1877051186835169d), new NpgsqlTypes.NpgsqlPoint(x: 0.5685041342161232d, y: 0.5925791360081171d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4436694832856376d, y: 0.6484341950296145d), new NpgsqlTypes.NpgsqlPoint(x: 0.658456179601883d, y: 0.6141897288129547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852846860350659d, y: 0.7412650849729543d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5198094590432335d, y: 0.2187717686456908d), new NpgsqlTypes.NpgsqlPoint(x: 0.35040574619417963d, y: 0.6800210158004167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706810791008987d, y: 0.9656883684981513d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1350491967858234d, y: 0.18335106410440294d), new NpgsqlTypes.NpgsqlPoint(x: 0.0768122898670961d, y: 0.22128821880332084d), new NpgsqlTypes.NpgsqlPoint(x: 0.03935533372483857d, y: 0.4446893337281662d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20359745130158025d, y: 0.35363857873435156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8004226406410455d, y: 0.4368378679473047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273661562650154d, y: 0.24951238743697302d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9424952918523009d, y: 0.19507249378813174d), new NpgsqlTypes.NpgsqlPoint(x: 0.4406083888727549d, y: 0.8706190765890066d), new NpgsqlTypes.NpgsqlPoint(x: 0.2333050236866554d, y: 0.8340390545533941d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8824092960505511d, y: 0.13628908908803328d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483849664232903d, y: 0.032353976095214065d), new NpgsqlTypes.NpgsqlPoint(x: 0.761178795573137d, y: 0.2979337092586395d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22964835601610856d, y: 0.36064543473060073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5496329336834186d, y: 0.3152942495543657d), new NpgsqlTypes.NpgsqlPoint(x: 0.43227527190529536d, y: 0.28424426665574287d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7993528427454218d, y: 0.25626678087290655d), new NpgsqlTypes.NpgsqlPoint(x: 0.4549087580917256d, y: 0.03383241274459925d), new NpgsqlTypes.NpgsqlPoint(x: 0.21055266675978224d, y: 0.7735427334966918d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9273809676800415d, y: 0.5880876024099706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8977856201124347d, y: 0.041816465421325666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095913499359294d, y: 0.7039394132682602d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3632524053274184d, y: 0.11991091983565982d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376852007007664d, y: 0.9944524213623457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936160000352757d, y: 0.8011125809865065d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5413097718782492d, y: 0.6756051843706182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2889844175605347d, y: 0.4487342750213653d), new NpgsqlTypes.NpgsqlPoint(x: 0.4665784426229145d, y: 0.9252920339852585d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3532943432527803d, y: 0.7619892869872802d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653410643962103d, y: 0.1918791243075224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4227633075993311d, y: 0.9566332198822671d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9040551859664665d, y: 0.9953849666942163d), new NpgsqlTypes.NpgsqlPoint(x: 0.18700208499100834d, y: 0.8757805966755623d), new NpgsqlTypes.NpgsqlPoint(x: 0.45931189902909475d, y: 0.8057117526261024d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5752840694698274d, y: 0.36331034691720554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837427788931891d, y: 0.28139777797094456d), new NpgsqlTypes.NpgsqlPoint(x: 0.1436015475614304d, y: 0.45543043175048525d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6571889653215064d, y: 0.18675277984893235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040696924163142d, y: 0.04009720100602465d), new NpgsqlTypes.NpgsqlPoint(x: 0.844254891214068d, y: 0.9609294330758014d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5976166614634939d, y: 0.4497778193533245d), new NpgsqlTypes.NpgsqlPoint(x: 0.7913655571139421d, y: 0.2859912576584698d), new NpgsqlTypes.NpgsqlPoint(x: 0.4294403839041748d, y: 0.21878687567995725d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7464038631082018d, y: 0.8920244777343582d), new NpgsqlTypes.NpgsqlPoint(x: 0.911678969700112d, y: 0.8368048603206811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8174217523065319d, y: 0.9670238238676857d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7516397854779477d, y: 0.28578501765829434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4563440876960214d, y: 0.5218558234676285d), new NpgsqlTypes.NpgsqlPoint(x: 0.42097772486338336d, y: 0.6933278756278896d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8168700502715339d, y: 0.40604161440136677d), new NpgsqlTypes.NpgsqlPoint(x: 0.1608216877964329d, y: 0.8490227361463263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129511019703682d, y: 0.198825673374195d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8357262299886614d, y: 0.7936113770213066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182706099238441d, y: 0.39191038259043187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5834813003801883d, y: 0.25904386475840735d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6770360013499042d, y: 0.7812897255513831d), new NpgsqlTypes.NpgsqlPoint(x: 0.2254332255974114d, y: 0.6722441396549762d), new NpgsqlTypes.NpgsqlPoint(x: 0.09170301769603517d, y: 0.4530385981620213d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6347831141584293d, y: 0.940838490939078d), new NpgsqlTypes.NpgsqlPoint(x: 0.1436237876452553d, y: 0.6181402210260707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8707335867798669d, y: 0.021080293135145922d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4255754257316511d, y: 0.6618141117929003d), new NpgsqlTypes.NpgsqlPoint(x: 0.1309708363187494d, y: 0.44128781844871356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216450578297422d, y: 0.9967805854633144d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.758994394993652d, y: 0.13949376933527757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7370699940382497d, y: 0.6300216755642496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9537840185775588d, y: 0.14128688903346787d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.988295920156021d, y: 0.7076449821715993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068918739609504d, y: 0.03498684947331665d), new NpgsqlTypes.NpgsqlPoint(x: 0.44589611088642744d, y: 0.20971590075764912d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1475474569029872d, y: 0.24807388956982923d), new NpgsqlTypes.NpgsqlPoint(x: 0.05260719685676174d, y: 0.2890252756099838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5706037197347374d, y: 0.8146738744909895d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3848578110450932d, y: 0.9841466988680889d), new NpgsqlTypes.NpgsqlPoint(x: 0.24100090727072665d, y: 0.9374764999900427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568918683738338d, y: 0.9164268408685345d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08102603370044392d, y: 0.6353002744283706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018003516926925d, y: 0.8251274843440324d), new NpgsqlTypes.NpgsqlPoint(x: 0.02575415506732559d, y: 0.9594908416290946d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4640577377151591d, y: 0.08320225443159368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817946946522842d, y: 0.2501230751637914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901287230880148d, y: 0.3240018572352964d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7172277968664448d, y: 0.1830072099211706d), new NpgsqlTypes.NpgsqlPoint(x: 0.25898511591478535d, y: 0.07162898573992582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252968412467138d, y: 0.24516654956117845d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14980542118464157d, y: 0.6465680353577846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924606692374441d, y: 0.7484147932218084d), new NpgsqlTypes.NpgsqlPoint(x: 0.055062252920051846d, y: 0.44326210723199133d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4898835288699033d, y: 0.3258762608879444d), new NpgsqlTypes.NpgsqlPoint(x: 0.26791492636672465d, y: 0.2707623090661564d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601062717752551d, y: 0.5765512259383861d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12652948974224498d, y: 0.8727314895008873d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232727321270297d, y: 0.7111439059249229d), new NpgsqlTypes.NpgsqlPoint(x: 0.2606192771621847d, y: 0.625248174202381d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4651135656564782d, y: 0.3519144060724666d), new NpgsqlTypes.NpgsqlPoint(x: 0.011144090523746875d, y: 0.68519250808141d), new NpgsqlTypes.NpgsqlPoint(x: 0.44054865580154057d, y: 0.9055832615335975d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18964072485894756d, y: 0.29477441063158194d), new NpgsqlTypes.NpgsqlPoint(x: 0.4402835563999413d, y: 0.814590280360034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5242058032249636d, y: 0.5633242544088869d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.884466584731049d, y: 0.728356959090348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468957454669312d, y: 0.5183554344227576d), new NpgsqlTypes.NpgsqlPoint(x: 0.44755926459122164d, y: 0.13349433716053338d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8507059714403239d, y: 0.7979849869059235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6839330419532517d, y: 0.9785401430152083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5373506654958403d, y: 0.6122785579352183d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5430652172611231d, y: 0.3679790640723175d), new NpgsqlTypes.NpgsqlPoint(x: 0.15073506327550168d, y: 0.04187928354761805d), new NpgsqlTypes.NpgsqlPoint(x: 0.04425298756162366d, y: 0.781533918615595d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7452643383524722d, y: 0.4399196819291772d), new NpgsqlTypes.NpgsqlPoint(x: 0.29453133400427056d, y: 0.8530677480549599d), new NpgsqlTypes.NpgsqlPoint(x: 0.28471696252983936d, y: 0.6997562318755166d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30520803157119947d, y: 0.5102645221790721d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268139833237782d, y: 0.9880892979023851d), new NpgsqlTypes.NpgsqlPoint(x: 0.00849651158044118d, y: 0.23019163328525893d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01621915035469146d, y: 0.18125810112353935d), new NpgsqlTypes.NpgsqlPoint(x: 0.16217030654831288d, y: 0.43651771903966285d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005497068560824d, y: 0.1217350775864563d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9603988382013622d, y: 0.00662089620539652d), new NpgsqlTypes.NpgsqlPoint(x: 0.37896285836893395d, y: 0.892313044812811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8843836081681279d, y: 0.47936595248975866d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15185337047457892d, y: 0.5872527122898861d), new NpgsqlTypes.NpgsqlPoint(x: 0.08136308353958221d, y: 0.7681184380855803d), new NpgsqlTypes.NpgsqlPoint(x: 0.010933105854015746d, y: 0.643309713815162d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8464105769174644d, y: 0.9762564239324816d), new NpgsqlTypes.NpgsqlPoint(x: 0.06264741311048261d, y: 0.860307431316267d), new NpgsqlTypes.NpgsqlPoint(x: 0.34732533243210406d, y: 0.5848978815966954d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13107252607044684d, y: 0.7598075349999566d), new NpgsqlTypes.NpgsqlPoint(x: 0.11190439446393041d, y: 0.06405404792547309d), new NpgsqlTypes.NpgsqlPoint(x: 0.30772284325025356d, y: 0.4211605566537452d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9154655145485366d, y: 0.3102784381555226d), new NpgsqlTypes.NpgsqlPoint(x: 0.3331148752622288d, y: 0.4847818941296159d), new NpgsqlTypes.NpgsqlPoint(x: 0.977607173894711d, y: 0.003987975909234276d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7486746208252909d, y: 0.5245250956539933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8344816870856995d, y: 0.9049896806238567d), new NpgsqlTypes.NpgsqlPoint(x: 0.7479427207541213d, y: 0.8470858070093952d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6728115402296435d, y: 0.2512830003879415d), new NpgsqlTypes.NpgsqlPoint(x: 0.4507213341899877d, y: 0.4645869695445779d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606614019391738d, y: 0.11128611203271954d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6174148831590591d, y: 0.8991088579112287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331629642983782d, y: 0.6059767962249527d), new NpgsqlTypes.NpgsqlPoint(x: 0.2660290704586007d, y: 0.757249180783954d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6123542683656363d, y: 0.30305241078092426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3826694596854363d, y: 0.7430214008200489d), new NpgsqlTypes.NpgsqlPoint(x: 0.20963322292314457d, y: 0.8341765460494989d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8144006576233105d, y: 0.20797998237551352d), new NpgsqlTypes.NpgsqlPoint(x: 0.2764633788139844d, y: 0.04272290736485418d), new NpgsqlTypes.NpgsqlPoint(x: 0.37960645221092704d, y: 0.7758842502268636d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6793919187267643d, y: 0.05234418165218213d), new NpgsqlTypes.NpgsqlPoint(x: 0.4797449405464077d, y: 0.680388540150929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293818815609614d, y: 0.7470248045133544d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49829041859283774d, y: 0.8524497271507129d), new NpgsqlTypes.NpgsqlPoint(x: 0.49669946448723956d, y: 0.7484277767751382d), new NpgsqlTypes.NpgsqlPoint(x: 0.08959755091442068d, y: 0.5085723610924668d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17632323536504801d, y: 0.3956479841557955d), new NpgsqlTypes.NpgsqlPoint(x: 0.10058960348969048d, y: 0.1547750858497402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5416218818563644d, y: 0.16325659215083d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4315429749194326d, y: 0.6602883976351313d), new NpgsqlTypes.NpgsqlPoint(x: 0.0869386963365274d, y: 0.10282856813872054d), new NpgsqlTypes.NpgsqlPoint(x: 0.49517441043046917d, y: 0.42091844014378843d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49208268639216024d, y: 0.8422924291826678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205650520016283d, y: 0.9801704909726742d), new NpgsqlTypes.NpgsqlPoint(x: 0.005793425783417683d, y: 0.827744881260204d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4106648871612547d, y: 0.8994175921715363d), new NpgsqlTypes.NpgsqlPoint(x: 0.163486476154029d, y: 0.9270955299305299d), new NpgsqlTypes.NpgsqlPoint(x: 0.516053781533496d, y: 0.41575930113684856d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9862594163853206d, y: 0.5864343007358699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8223876013785778d, y: 0.34332671817823424d), new NpgsqlTypes.NpgsqlPoint(x: 0.44614508563128275d, y: 0.9039345406401239d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9795398528101648d, y: 0.849579499204895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252441972634424d, y: 0.5770488200917772d), new NpgsqlTypes.NpgsqlPoint(x: 0.4961762051413474d, y: 0.25375806299303993d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5716664855496877d, y: 0.7721004700853292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168735655648181d, y: 0.6901374386162608d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086600877896454d, y: 0.39504723073776304d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9583796562445357d, y: 0.4399150266238012d), new NpgsqlTypes.NpgsqlPoint(x: 0.06714427194972394d, y: 0.3470780009717981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9354477363929057d, y: 0.6921759514539351d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5255841422976222d, y: 0.8841571636008451d), new NpgsqlTypes.NpgsqlPoint(x: 0.08746512228162084d, y: 0.8975423510880401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5792220656349166d, y: 0.5719567652556813d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6917863714725131d, y: 0.4462784683949492d), new NpgsqlTypes.NpgsqlPoint(x: 0.0064196945993479915d, y: 0.7858940379322992d), new NpgsqlTypes.NpgsqlPoint(x: 0.2694330864835446d, y: 0.7161889015395205d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7360817845084343d, y: 0.5991065357559379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727711981127105d, y: 0.14057552754613023d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434967922615024d, y: 0.7998641723379294d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.306597232358898d, y: 0.064363729865202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7661028507938831d, y: 0.7834409543863139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726248623353854d, y: 0.6393991794441258d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpathe0m m
LEFT JOIN public.binary_npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI), typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

