

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
    internal partial interface IBigIntegerMArraynumericMMArrayD1
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD1 : IBigIntegerMArraynumericMMArrayD1
    {


#region TestData

        private readonly BigIntegernumericMMArrayD1E1M[] _testData = new BigIntegernumericMMArrayD1E1M[]
        {
            new BigIntegernumericMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2866829765901351472L),
new System.Numerics.BigInteger(2005427608950260581L),
new System.Numerics.BigInteger(5369147836373481949L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6385777762758968942L),
new System.Numerics.BigInteger(7819290425308486648L),
new System.Numerics.BigInteger(375694469264591519L),
new System.Numerics.BigInteger(8500819658142630007L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1372603053719850095L),
new System.Numerics.BigInteger(487596473511257912L),
new System.Numerics.BigInteger(989425976793130579L),
new System.Numerics.BigInteger(2904081049005023405L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8313915708577780524L),
new System.Numerics.BigInteger(963079714164721874L),
new System.Numerics.BigInteger(3490860689060664585L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9135028389891079121L),
new System.Numerics.BigInteger(3518117868308776134L),
new System.Numerics.BigInteger(6475785897003950970L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6640537594047727625L),
new System.Numerics.BigInteger(5191363814142527276L),
new System.Numerics.BigInteger(1946795001774313227L),
new System.Numerics.BigInteger(4452793329069038289L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3895691953389914681L),
new System.Numerics.BigInteger(2091019092062293670L),
new System.Numerics.BigInteger(499643045806403939L),
new System.Numerics.BigInteger(6962473958551596403L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8360095690425421529L),
new System.Numerics.BigInteger(1150352339214848550L),
new System.Numerics.BigInteger(8816005963842884164L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5677683552987482705L),
new System.Numerics.BigInteger(8190478903835302563L),
new System.Numerics.BigInteger(3611032216893425125L),
new System.Numerics.BigInteger(118703669848274353L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8580194370083425781L),
new System.Numerics.BigInteger(7031975295855551850L),
new System.Numerics.BigInteger(1754294278565606172L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1430849122024878489L),
new System.Numerics.BigInteger(7883649733277588871L),
new System.Numerics.BigInteger(7520159997449756782L),
new System.Numerics.BigInteger(2734112383098543738L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8878245752357975667L),
new System.Numerics.BigInteger(5594273200607640945L),
new System.Numerics.BigInteger(1098764989189435242L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4855979036415739487L),
new System.Numerics.BigInteger(1283118069622368708L),
new System.Numerics.BigInteger(4820620982999439146L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5926769699204005501L),
new System.Numerics.BigInteger(5714102965567090479L),
new System.Numerics.BigInteger(311319671327397216L),
new System.Numerics.BigInteger(116546664663580947L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4043650793595864972L),
new System.Numerics.BigInteger(3436764277678645674L),
new System.Numerics.BigInteger(5149048463481189269L),
new System.Numerics.BigInteger(5156166520878809827L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(528298902875002466L),
new System.Numerics.BigInteger(1219830039585137784L),
new System.Numerics.BigInteger(7743790298553116778L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6982191450459083540L),
new System.Numerics.BigInteger(2161259991777706583L),
new System.Numerics.BigInteger(3120384415972526741L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(385910380674059014L),
new System.Numerics.BigInteger(4488515509613736684L),
new System.Numerics.BigInteger(1156555885166131099L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1077979990471377987L),
new System.Numerics.BigInteger(3520343478939564040L),
new System.Numerics.BigInteger(7817197589596648020L),
new System.Numerics.BigInteger(5481160423925527825L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(345716833741977097L),
new System.Numerics.BigInteger(3802018809981051826L),
new System.Numerics.BigInteger(5575447524450786957L),
new System.Numerics.BigInteger(2536976337790783756L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(436060530483802401L),
new System.Numerics.BigInteger(8212691521455043380L),
new System.Numerics.BigInteger(606150100129126250L),
new System.Numerics.BigInteger(3447747979125835302L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3545098677099984638L),
new System.Numerics.BigInteger(6299623343797408630L),
new System.Numerics.BigInteger(1970692043273043622L),
new System.Numerics.BigInteger(4373479129612863336L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4237945679467838560L),
new System.Numerics.BigInteger(3700772567984927077L),
new System.Numerics.BigInteger(2621670669451903731L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5901831584031064612L),
new System.Numerics.BigInteger(8595230474037474812L),
new System.Numerics.BigInteger(781878798973098639L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 57,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5222816555446523190L),
new System.Numerics.BigInteger(899162150537721379L),
new System.Numerics.BigInteger(4565549831733115793L),
new System.Numerics.BigInteger(9025314557084811968L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3684632221778886205L),
new System.Numerics.BigInteger(6126100972270484723L),
new System.Numerics.BigInteger(693682697564683761L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6141928108298927811L),
new System.Numerics.BigInteger(72163839262806583L),
new System.Numerics.BigInteger(7595843357393543210L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2509831657297701004L),
new System.Numerics.BigInteger(8529159768614671384L),
new System.Numerics.BigInteger(5991857622820476383L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5992388917243624833L),
new System.Numerics.BigInteger(771735514536246179L),
new System.Numerics.BigInteger(5141781343034184873L),
new System.Numerics.BigInteger(5000612119591917406L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6145026896627482103L),
new System.Numerics.BigInteger(768120706202996313L),
new System.Numerics.BigInteger(3425670451512649158L),
new System.Numerics.BigInteger(6274432630861297980L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1546968769013714110L),
new System.Numerics.BigInteger(1385365278245107219L),
new System.Numerics.BigInteger(933875404567168720L),
new System.Numerics.BigInteger(2356694386403937289L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5975575938738579091L),
new System.Numerics.BigInteger(226294361094429923L),
new System.Numerics.BigInteger(2969120112086065295L),
new System.Numerics.BigInteger(44760675235136710L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6415177993831828673L),
new System.Numerics.BigInteger(8844573638642407581L),
new System.Numerics.BigInteger(7911959958223332129L),
new System.Numerics.BigInteger(835370134530695329L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2258779953672073759L),
new System.Numerics.BigInteger(3834753924090224444L),
new System.Numerics.BigInteger(2795239391267370021L),
new System.Numerics.BigInteger(4633110717898908301L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7927336009523312479L),
new System.Numerics.BigInteger(7774282132182821313L),
new System.Numerics.BigInteger(5480733831423123148L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8763889423639080526L),
new System.Numerics.BigInteger(4788639409008198573L),
new System.Numerics.BigInteger(6546836419385659344L),
new System.Numerics.BigInteger(7171782395722315088L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1399675056416373715L),
new System.Numerics.BigInteger(7655149898638447920L),
new System.Numerics.BigInteger(9109469896999346823L),
new System.Numerics.BigInteger(3885253879100750863L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6645057496238799568L),
new System.Numerics.BigInteger(712401763261600434L),
new System.Numerics.BigInteger(1245116790883748723L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1659646863310530812L),
new System.Numerics.BigInteger(6434141767861975345L),
new System.Numerics.BigInteger(956408731968199008L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3325894856508473204L),
new System.Numerics.BigInteger(176866169412715387L),
new System.Numerics.BigInteger(1981033530970821456L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8238770731033074270L),
new System.Numerics.BigInteger(8686673983614988468L),
new System.Numerics.BigInteger(7180599853928090424L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2045803844864443024L),
new System.Numerics.BigInteger(1548693352504387394L),
new System.Numerics.BigInteger(4301608729493410353L),
new System.Numerics.BigInteger(697325499979386525L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8952142280292332055L),
new System.Numerics.BigInteger(3080731336075707760L),
new System.Numerics.BigInteger(187272783664912733L),
new System.Numerics.BigInteger(8612971697161364007L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4966065056461123406L),
new System.Numerics.BigInteger(6043738821458888002L),
new System.Numerics.BigInteger(2126970621625685721L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3416154898842783724L),
new System.Numerics.BigInteger(1736097146957048796L),
new System.Numerics.BigInteger(1211990132805385357L),
new System.Numerics.BigInteger(8769347010826416652L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8092941816368854119L),
new System.Numerics.BigInteger(2592186836013521445L),
new System.Numerics.BigInteger(7159106859834926678L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3807817043277110623L),
new System.Numerics.BigInteger(5923658308184028878L),
new System.Numerics.BigInteger(7957903073805765651L),
new System.Numerics.BigInteger(1264051685169812356L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7509488021022733189L),
new System.Numerics.BigInteger(8832805253578465445L),
new System.Numerics.BigInteger(7845723632247705905L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(473716007275706615L),
new System.Numerics.BigInteger(7775411821881034232L),
new System.Numerics.BigInteger(1715574791063991852L),
new System.Numerics.BigInteger(8581979246357018116L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7507978395356817222L),
new System.Numerics.BigInteger(2673379547787050842L),
new System.Numerics.BigInteger(7310708107979117078L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(845416946108813420L),
new System.Numerics.BigInteger(6378308375185412728L),
new System.Numerics.BigInteger(6201923794683691502L),
new System.Numerics.BigInteger(544713295156912346L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7973602564447490236L),
new System.Numerics.BigInteger(5250258191130683851L),
new System.Numerics.BigInteger(4551436784855602424L),
new System.Numerics.BigInteger(5223891023985792185L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1675809265660074727L),
new System.Numerics.BigInteger(8559695363078263470L),
new System.Numerics.BigInteger(5369980003225716769L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3379232964163193510L),
new System.Numerics.BigInteger(900626941699349310L),
new System.Numerics.BigInteger(5638077409293659816L),
new System.Numerics.BigInteger(3225097176557955644L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3277976155787064451L),
new System.Numerics.BigInteger(6042291347036749766L),
new System.Numerics.BigInteger(511833117943353291L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5555321099322596563L),
new System.Numerics.BigInteger(4316634757369553625L),
new System.Numerics.BigInteger(8900554671942831370L),
new System.Numerics.BigInteger(2612995704207036422L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4510032145666634939L),
new System.Numerics.BigInteger(1557591581702075619L),
new System.Numerics.BigInteger(5631299742849642274L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1114244884945220293L),
new System.Numerics.BigInteger(3876269410980080817L),
new System.Numerics.BigInteger(2551093911227036663L),
new System.Numerics.BigInteger(2890404066072013682L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8621549312633306216L),
new System.Numerics.BigInteger(4412202812069058406L),
new System.Numerics.BigInteger(8013035927738399243L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(695654420339177555L),
new System.Numerics.BigInteger(8014632139072972744L),
new System.Numerics.BigInteger(1694750095941299932L),
new System.Numerics.BigInteger(8399208626080442235L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1973840178734913407L),
new System.Numerics.BigInteger(2180923572368968836L),
new System.Numerics.BigInteger(1716754066759398891L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5942117555273187894L),
new System.Numerics.BigInteger(5358191543356610064L),
new System.Numerics.BigInteger(8864160161558425517L),
new System.Numerics.BigInteger(2750010536371931212L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 108,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5828959953819348035L),
new System.Numerics.BigInteger(4288228628479493873L),
new System.Numerics.BigInteger(7752009722785978788L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7216064188645244549L),
new System.Numerics.BigInteger(7321744254018354760L),
new System.Numerics.BigInteger(600205338776926836L),
new System.Numerics.BigInteger(8649069700090382668L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5836824205222213961L),
new System.Numerics.BigInteger(461198643051625526L),
new System.Numerics.BigInteger(2666280610152453265L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3505824320225959515L),
new System.Numerics.BigInteger(199322226847806491L),
new System.Numerics.BigInteger(7027303511822377429L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4239668242806136344L),
new System.Numerics.BigInteger(6339471751940395202L),
new System.Numerics.BigInteger(1845146672792358762L),
new System.Numerics.BigInteger(4220893721733694170L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4340816290721324947L),
new System.Numerics.BigInteger(2819618502214664L),
new System.Numerics.BigInteger(3940161919271859577L),
new System.Numerics.BigInteger(1891054152925672896L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(170941210799619790L),
new System.Numerics.BigInteger(5870868509960483064L),
new System.Numerics.BigInteger(5084621321488248870L),
new System.Numerics.BigInteger(2475580235485353169L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9064060650123293574L),
new System.Numerics.BigInteger(1004904356070722795L),
new System.Numerics.BigInteger(3195301049768016494L),
new System.Numerics.BigInteger(1392343730650927517L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6289391886654998428L),
new System.Numerics.BigInteger(4146520246856166966L),
new System.Numerics.BigInteger(127130238338749307L),
new System.Numerics.BigInteger(3703011462401101129L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(938429668246797924L),
new System.Numerics.BigInteger(8132061516401601109L),
new System.Numerics.BigInteger(4356261682452419458L),
new System.Numerics.BigInteger(1995673240540382967L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8995083432476891642L),
new System.Numerics.BigInteger(7757724834948396683L),
new System.Numerics.BigInteger(1137504093034406006L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(920520138197771017L),
new System.Numerics.BigInteger(35761396930599410L),
new System.Numerics.BigInteger(796633603673190379L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9057116087603711901L),
new System.Numerics.BigInteger(500628768938013811L),
new System.Numerics.BigInteger(620319782926380472L),
new System.Numerics.BigInteger(8595680690917160782L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(66321139004565664L),
new System.Numerics.BigInteger(6835074477224453150L),
new System.Numerics.BigInteger(6680442780022248543L),
new System.Numerics.BigInteger(1073174009118708568L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3865864168106830847L),
new System.Numerics.BigInteger(4576516814713791124L),
new System.Numerics.BigInteger(3211724367118748745L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2383982554251251991L),
new System.Numerics.BigInteger(2458794396966671548L),
new System.Numerics.BigInteger(9150620772786585832L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1677149782271116546L),
new System.Numerics.BigInteger(6006415225678583845L),
new System.Numerics.BigInteger(5176526136742451100L),
new System.Numerics.BigInteger(1074653629871105677L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1043135237945572235L),
new System.Numerics.BigInteger(2817928435479062026L),
new System.Numerics.BigInteger(6752583317460625645L),
new System.Numerics.BigInteger(405068817185227690L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(716090732108119561L),
new System.Numerics.BigInteger(1200231052557404511L),
new System.Numerics.BigInteger(9122331032108257531L),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd1e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd1e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD1E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD1E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 140;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 124, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 73, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 56, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 65, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 140, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 133, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 91, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 108, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 26, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
FROM public.binary_bigintegernumericmmarrayd1e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IBigIntegerMArraynumericMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI), typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MI>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

