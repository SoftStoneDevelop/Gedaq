

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
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.006544972054091658d, b: 0.26746478179423394d, c: 0.8014240839796063d),
new NpgsqlTypes.NpgsqlLine(a: 0.7865459290610811d, b: 0.031235476815103413d, c: 0.17439534825665204d),
new NpgsqlTypes.NpgsqlLine(a: 0.6667720873215539d, b: 0.28403668063860543d, c: 0.39831505472775597d),
new NpgsqlTypes.NpgsqlLine(a: 0.584098114375831d, b: 0.18925570162281558d, c: 0.13610275050494658d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8908591047080345d, b: 0.612928043049282d, c: 0.4592619433354027d),
new NpgsqlTypes.NpgsqlLine(a: 0.22909526131734215d, b: 0.0442187147980615d, c: 0.6707305969131391d),
new NpgsqlTypes.NpgsqlLine(a: 0.02535313890405222d, b: 0.8427180646725017d, c: 0.15986469422175076d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2605967887657087d, b: 0.4762274609615972d, c: 0.8484376436157913d),
new NpgsqlTypes.NpgsqlLine(a: 0.8154816568018801d, b: 0.5756853866876623d, c: 0.6119379614171304d),
new NpgsqlTypes.NpgsqlLine(a: 0.40292066141013005d, b: 0.5571715905762377d, c: 0.6753110127401583d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3960255520290926d, b: 0.08473805369287635d, c: 0.8215736840394162d),
new NpgsqlTypes.NpgsqlLine(a: 0.6526884184229689d, b: 0.46227320770824476d, c: 0.48977281377920245d),
new NpgsqlTypes.NpgsqlLine(a: 0.007757856555987708d, b: 0.3315744043404635d, c: 0.01127087810790095d),
new NpgsqlTypes.NpgsqlLine(a: 0.46774999012702967d, b: 0.40560107505897003d, c: 0.755522751517758d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39706903000886784d, b: 0.6961695630528564d, c: 0.3505691554786027d),
new NpgsqlTypes.NpgsqlLine(a: 0.32149317223464524d, b: 0.5804038071326441d, c: 0.19772433372806197d),
new NpgsqlTypes.NpgsqlLine(a: 0.38319875919603674d, b: 0.9910810478606984d, c: 0.41360828124590343d),
new NpgsqlTypes.NpgsqlLine(a: 0.7453961036613892d, b: 0.6815036683694261d, c: 0.09828406997065087d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3653288652283406d, b: 0.6554195938025836d, c: 0.5818156206454146d),
new NpgsqlTypes.NpgsqlLine(a: 0.41427345684777706d, b: 0.9201390473507304d, c: 0.8486424302764859d),
new NpgsqlTypes.NpgsqlLine(a: 0.7841156198979968d, b: 0.802301291005163d, c: 0.582930122453509d),
new NpgsqlTypes.NpgsqlLine(a: 0.5775774747464456d, b: 0.6481267318383783d, c: 0.7632342645704943d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0074685239016846205d, b: 0.8736915674996059d, c: 0.5241244283380803d),
new NpgsqlTypes.NpgsqlLine(a: 0.23126070560710943d, b: 0.8737017762028176d, c: 0.050621830962552905d),
new NpgsqlTypes.NpgsqlLine(a: 0.38935551348259634d, b: 0.39411913703902146d, c: 0.19054806705022387d),
new NpgsqlTypes.NpgsqlLine(a: 0.6239421708708001d, b: 0.7521876156723615d, c: 0.603593907855288d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.434356623662834d, b: 0.9351010274193756d, c: 0.03897152557990613d),
new NpgsqlTypes.NpgsqlLine(a: 0.047555181989245576d, b: 0.800513086424151d, c: 0.42442669144227885d),
new NpgsqlTypes.NpgsqlLine(a: 0.19934452660767754d, b: 0.7012535895887749d, c: 0.027956066788210943d),
new NpgsqlTypes.NpgsqlLine(a: 0.6223166472068518d, b: 0.7235229215211845d, c: 0.643676275232029d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8028220861555427d, b: 0.9494322489407386d, c: 0.6022660100828442d),
new NpgsqlTypes.NpgsqlLine(a: 0.2591467687357836d, b: 0.1465402999419363d, c: 0.5614725490595743d),
new NpgsqlTypes.NpgsqlLine(a: 0.5017588857620332d, b: 0.64932083206197d, c: 0.5274020282331888d),
new NpgsqlTypes.NpgsqlLine(a: 0.01951572275636737d, b: 0.4488457338955407d, c: 0.8153659744728435d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1475023701501521d, b: 0.07839693901803246d, c: 0.6197612151651488d),
new NpgsqlTypes.NpgsqlLine(a: 0.04867563955622811d, b: 0.7043380372553599d, c: 0.27316367782958084d),
new NpgsqlTypes.NpgsqlLine(a: 0.3298812333344161d, b: 0.5513851689058819d, c: 0.9803111740950857d),
new NpgsqlTypes.NpgsqlLine(a: 0.2845377654772968d, b: 0.9488016683078614d, c: 0.4534929763141913d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24105450638357884d, b: 0.3223381531705618d, c: 0.9229640400369717d),
new NpgsqlTypes.NpgsqlLine(a: 0.9335902494597891d, b: 0.24451603816581158d, c: 0.7121607629436691d),
new NpgsqlTypes.NpgsqlLine(a: 0.8971273211861527d, b: 0.9846894632354455d, c: 0.18323135263911816d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5093877047198669d, b: 0.9692436380023794d, c: 0.05055947591708232d),
new NpgsqlTypes.NpgsqlLine(a: 0.7018346724041947d, b: 0.17192894879315446d, c: 0.8468487281305584d),
new NpgsqlTypes.NpgsqlLine(a: 0.6220682540868484d, b: 0.33791888600356323d, c: 0.5025259923018933d),
new NpgsqlTypes.NpgsqlLine(a: 0.4448685401005097d, b: 0.14323414233363152d, c: 0.6861735665350245d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3459822060680867d, b: 0.1438080894687599d, c: 0.07296826398229217d),
new NpgsqlTypes.NpgsqlLine(a: 0.49484172862083275d, b: 0.8473948192740063d, c: 0.3243258980963998d),
new NpgsqlTypes.NpgsqlLine(a: 0.15393082221504006d, b: 0.7847217260610748d, c: 0.11482233437647404d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6238607990480838d, b: 0.26503333193900913d, c: 0.533181607244794d),
new NpgsqlTypes.NpgsqlLine(a: 0.23003084732206824d, b: 0.42726405943730594d, c: 0.595042122681519d),
new NpgsqlTypes.NpgsqlLine(a: 0.45586695716342174d, b: 0.4520573575378578d, c: 0.24800412749536227d),
new NpgsqlTypes.NpgsqlLine(a: 0.8411380326146293d, b: 0.14489939217502334d, c: 0.9562311125885121d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3592787873415344d, b: 0.10583072276781846d, c: 0.39721225424691975d),
new NpgsqlTypes.NpgsqlLine(a: 0.96367011982975d, b: 0.5366369240929881d, c: 0.8919127175478512d),
new NpgsqlTypes.NpgsqlLine(a: 0.4616727336125943d, b: 0.15753549614400275d, c: 0.6259781144965934d),
new NpgsqlTypes.NpgsqlLine(a: 0.3785964870749712d, b: 0.9832208974110875d, c: 0.8200155012070505d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5758357136429302d, b: 0.8155524521405018d, c: 0.058795169134659875d),
new NpgsqlTypes.NpgsqlLine(a: 0.3380249094594312d, b: 0.0676559117835801d, c: 0.707341362363196d),
new NpgsqlTypes.NpgsqlLine(a: 0.6569117481502343d, b: 0.8668670933017278d, c: 0.27951660703601755d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14737709599432902d, b: 0.5569934239673587d, c: 0.7767256886317985d),
new NpgsqlTypes.NpgsqlLine(a: 0.4705742138933604d, b: 0.6846957639040091d, c: 0.3884590073422356d),
new NpgsqlTypes.NpgsqlLine(a: 0.1943818832963896d, b: 0.559027001420076d, c: 0.24276741481492037d),
new NpgsqlTypes.NpgsqlLine(a: 0.8409913408388672d, b: 0.4019680484233913d, c: 0.941805128270463d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5176984897843587d, b: 0.4760928365948651d, c: 0.8561512395418843d),
new NpgsqlTypes.NpgsqlLine(a: 0.4336954766200374d, b: 0.08952048425743253d, c: 0.5036444440268986d),
new NpgsqlTypes.NpgsqlLine(a: 0.14920346596290845d, b: 0.7318590750053132d, c: 0.9391433302174207d),
new NpgsqlTypes.NpgsqlLine(a: 0.03073599426576079d, b: 0.860394326664416d, c: 0.4137981904171889d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.13506983497630043d, b: 0.7635921097840409d, c: 0.734942131240329d),
new NpgsqlTypes.NpgsqlLine(a: 0.12287828907867271d, b: 0.336217408293108d, c: 0.6757668485010555d),
new NpgsqlTypes.NpgsqlLine(a: 0.9084731798071919d, b: 0.653919524785344d, c: 0.23428575103028615d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9645380355329579d, b: 0.6369184068214955d, c: 0.38451029790314417d),
new NpgsqlTypes.NpgsqlLine(a: 0.30418395899471395d, b: 0.2986530356568212d, c: 0.3215229450684519d),
new NpgsqlTypes.NpgsqlLine(a: 0.45980338719851155d, b: 0.9413037396885867d, c: 0.7228681582972933d),
new NpgsqlTypes.NpgsqlLine(a: 0.44350491643400747d, b: 0.8258089924220232d, c: 0.7884734312459775d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8075279545109267d, b: 0.6110482051981883d, c: 0.4901717699628767d),
new NpgsqlTypes.NpgsqlLine(a: 0.6447730932693113d, b: 0.36603794382389054d, c: 0.9397633000559562d),
new NpgsqlTypes.NpgsqlLine(a: 0.44351395733461785d, b: 0.22662638196978802d, c: 0.13001715943613934d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33615871901494077d, b: 0.09657075083960054d, c: 0.22555700188190853d),
new NpgsqlTypes.NpgsqlLine(a: 0.7172210925445308d, b: 0.838751978597266d, c: 0.5054510240393623d),
new NpgsqlTypes.NpgsqlLine(a: 0.4046014149489653d, b: 0.14020882022942027d, c: 0.8749325698351568d),
new NpgsqlTypes.NpgsqlLine(a: 0.21187463820391528d, b: 0.09700986119095001d, c: 0.7639302711201165d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7404586982417309d, b: 0.6721243636003117d, c: 0.4262601067191203d),
new NpgsqlTypes.NpgsqlLine(a: 0.3399054480997068d, b: 0.001430971268653436d, c: 0.8632955289504872d),
new NpgsqlTypes.NpgsqlLine(a: 0.7268326067443106d, b: 0.5134736203673734d, c: 0.7676026435731284d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07261465692763525d, b: 0.6425583059572451d, c: 0.0021593282087093435d),
new NpgsqlTypes.NpgsqlLine(a: 0.9376327928520197d, b: 0.09886436539991728d, c: 0.6177936175337586d),
new NpgsqlTypes.NpgsqlLine(a: 0.33400746576070617d, b: 0.1554352802202451d, c: 0.5463814969635808d),
new NpgsqlTypes.NpgsqlLine(a: 0.4320903449388881d, b: 0.37454408430290165d, c: 0.4111071050073394d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32338680823523835d, b: 0.2842106433752627d, c: 0.7478968709859163d),
new NpgsqlTypes.NpgsqlLine(a: 0.3497195673078456d, b: 0.6409784264923666d, c: 0.5435131225538323d),
new NpgsqlTypes.NpgsqlLine(a: 0.2930570822730947d, b: 0.2034615579360629d, c: 0.492330116850784d),
new NpgsqlTypes.NpgsqlLine(a: 0.33467291111289577d, b: 0.9679764247766888d, c: 0.5436050414297914d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7450988214015158d, b: 0.6042432738308569d, c: 0.5292632648931679d),
new NpgsqlTypes.NpgsqlLine(a: 0.850646746038006d, b: 0.8925241211360834d, c: 0.28251882830545005d),
new NpgsqlTypes.NpgsqlLine(a: 0.6476009602970674d, b: 0.791765304636096d, c: 0.01732581790608767d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.673373476996991d, b: 0.9893640441403722d, c: 0.22733866566798921d),
new NpgsqlTypes.NpgsqlLine(a: 0.5923398924584719d, b: 0.21963583087359506d, c: 0.9865745642607179d),
new NpgsqlTypes.NpgsqlLine(a: 0.7635161654081873d, b: 0.6750145641202665d, c: 0.4454994793448056d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16165979662940577d, b: 0.29452003378657965d, c: 0.6479223326550385d),
new NpgsqlTypes.NpgsqlLine(a: 0.009796098558176647d, b: 0.04929828217948429d, c: 0.7094744292719829d),
new NpgsqlTypes.NpgsqlLine(a: 0.6845757592083296d, b: 0.2591109192365404d, c: 0.13056775848646718d),
new NpgsqlTypes.NpgsqlLine(a: 0.3657298966810253d, b: 0.23392510430795743d, c: 0.8726818323789676d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23606191034131807d, b: 0.28247599695520687d, c: 0.1980325113103233d),
new NpgsqlTypes.NpgsqlLine(a: 0.8618842663043311d, b: 0.9208304604401502d, c: 0.7705056204178908d),
new NpgsqlTypes.NpgsqlLine(a: 0.9293939931934683d, b: 0.9480023645189555d, c: 0.808188519268457d),
new NpgsqlTypes.NpgsqlLine(a: 0.7905742267264473d, b: 0.05326992802232433d, c: 0.0157400294742861d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08654917462092937d, b: 0.953715691517461d, c: 0.9374408004573762d),
new NpgsqlTypes.NpgsqlLine(a: 0.06564870962129166d, b: 0.9481422392553543d, c: 0.020197477777605388d),
new NpgsqlTypes.NpgsqlLine(a: 0.30102111752236915d, b: 0.03507180303218749d, c: 0.8781319664902085d),
new NpgsqlTypes.NpgsqlLine(a: 0.6640907678535372d, b: 0.2092865555405049d, c: 0.4625661129233163d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.34330967741102036d, b: 0.3843568222988414d, c: 0.7829225980599047d),
new NpgsqlTypes.NpgsqlLine(a: 0.8806715758418171d, b: 0.5545777530562123d, c: 0.4835084104438706d),
new NpgsqlTypes.NpgsqlLine(a: 0.7630946646996253d, b: 0.6609368393697108d, c: 0.92754183531778d),
new NpgsqlTypes.NpgsqlLine(a: 0.978520708688026d, b: 0.9836841509610418d, c: 0.6101735109716235d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.694664170974511d, b: 0.06749152715217666d, c: 0.6850433653389787d),
new NpgsqlTypes.NpgsqlLine(a: 0.5811890537185791d, b: 0.35973434014955374d, c: 0.691701315686575d),
new NpgsqlTypes.NpgsqlLine(a: 0.2692655313850556d, b: 0.8268558777093509d, c: 0.44334107200756945d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25967551093438823d, b: 0.057229030283021176d, c: 0.6002498713425789d),
new NpgsqlTypes.NpgsqlLine(a: 0.6012866669234602d, b: 0.10162654247888314d, c: 0.16118582144030147d),
new NpgsqlTypes.NpgsqlLine(a: 0.04244728005789977d, b: 0.36250388416772505d, c: 0.9039645440731184d),
new NpgsqlTypes.NpgsqlLine(a: 0.2578726004318985d, b: 0.7716288571956651d, c: 0.12269502568369473d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9071997570612124d, b: 0.7013423853466457d, c: 0.5569412248095391d),
new NpgsqlTypes.NpgsqlLine(a: 0.5746446419653297d, b: 0.32895352259006194d, c: 0.5810301519808118d),
new NpgsqlTypes.NpgsqlLine(a: 0.03256953315144251d, b: 0.7343754757760558d, c: 0.24233236742305087d),
new NpgsqlTypes.NpgsqlLine(a: 0.7271132539688339d, b: 0.11438719307714595d, c: 0.2944206972849086d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2773527056839188d, b: 0.9813596714426804d, c: 0.28070604752817263d),
new NpgsqlTypes.NpgsqlLine(a: 0.3788707631124638d, b: 0.3193810081591596d, c: 0.5563584876133262d),
new NpgsqlTypes.NpgsqlLine(a: 0.571616435750181d, b: 0.10040140467931569d, c: 0.11412833465897188d),
new NpgsqlTypes.NpgsqlLine(a: 0.062200136923611926d, b: 0.8542309220624579d, c: 0.4946964296557579d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08286955739859458d, b: 0.5648654198008397d, c: 0.972275358258361d),
new NpgsqlTypes.NpgsqlLine(a: 0.4881203155945303d, b: 0.7730747490061923d, c: 0.0714897732031684d),
new NpgsqlTypes.NpgsqlLine(a: 0.2064744951950852d, b: 0.4685882089399237d, c: 0.2980723176802942d),
new NpgsqlTypes.NpgsqlLine(a: 0.763241392208737d, b: 0.029940840588287165d, c: 0.7169545748366905d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5845055465091415d, b: 0.342636964500053d, c: 0.8327867072008837d),
new NpgsqlTypes.NpgsqlLine(a: 0.8505348038899241d, b: 0.3748713461439632d, c: 0.9673222454606074d),
new NpgsqlTypes.NpgsqlLine(a: 0.755436926420113d, b: 0.6064044721209356d, c: 0.1537534010940934d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9526301285589271d, b: 0.6217297184894799d, c: 0.34558510638088d),
new NpgsqlTypes.NpgsqlLine(a: 0.24427544041289517d, b: 0.4255062028129152d, c: 0.9027534558659525d),
new NpgsqlTypes.NpgsqlLine(a: 0.2588655720639562d, b: 0.08564979356471591d, c: 0.7461547359634924d),
new NpgsqlTypes.NpgsqlLine(a: 0.384098695369401d, b: 0.20166929869547956d, c: 0.5048674055014529d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7325357157643123d, b: 0.16431231380861167d, c: 0.7191483921924705d),
new NpgsqlTypes.NpgsqlLine(a: 0.998324749074145d, b: 0.5060557584605978d, c: 0.18529864755248027d),
new NpgsqlTypes.NpgsqlLine(a: 0.4649634908024076d, b: 0.23032335181446384d, c: 0.010131680817716426d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.314930057974005d, b: 0.40947952351910455d, c: 0.5285552446959387d),
new NpgsqlTypes.NpgsqlLine(a: 0.0725548916976484d, b: 0.02000434886593072d, c: 0.415381344529672d),
new NpgsqlTypes.NpgsqlLine(a: 0.9080981854913817d, b: 0.2709335410332476d, c: 0.18598479119511013d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3070075979545107d, b: 0.5079950074391272d, c: 0.33320976201467445d),
new NpgsqlTypes.NpgsqlLine(a: 0.6082229571265089d, b: 0.35533538593237535d, c: 0.34286739227954743d),
new NpgsqlTypes.NpgsqlLine(a: 0.5606851506458305d, b: 0.8410972509747611d, c: 0.36093391697514865d),
new NpgsqlTypes.NpgsqlLine(a: 0.8470380276653784d, b: 0.12174649482348376d, c: 0.37279816808235244d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3744954311911064d, b: 0.7516635513645453d, c: 0.8728418473291283d),
new NpgsqlTypes.NpgsqlLine(a: 0.08631709967647694d, b: 0.6757356276577641d, c: 0.0013445971950555302d),
new NpgsqlTypes.NpgsqlLine(a: 0.3548455726350527d, b: 0.02568525726973847d, c: 0.7974440922436038d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7061456469379784d, b: 0.7691699620548363d, c: 0.7218701418689999d),
new NpgsqlTypes.NpgsqlLine(a: 0.6475574339435709d, b: 0.9287857625010967d, c: 0.5863275906816448d),
new NpgsqlTypes.NpgsqlLine(a: 0.07055346046619104d, b: 0.2965653066369276d, c: 0.7113650720944312d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3763187916815569d, b: 0.22782534576060576d, c: 0.7214127566705372d),
new NpgsqlTypes.NpgsqlLine(a: 0.12789462205653102d, b: 0.20195363766331775d, c: 0.07407763597784989d),
new NpgsqlTypes.NpgsqlLine(a: 0.9696377282808294d, b: 0.9522652780863252d, c: 0.6060592671865603d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28924998093110343d, b: 0.6841947971498826d, c: 0.1278127118957728d),
new NpgsqlTypes.NpgsqlLine(a: 0.6431640538787634d, b: 0.06980332628438746d, c: 0.6617412520024238d),
new NpgsqlTypes.NpgsqlLine(a: 0.7973647793284302d, b: 0.5814332624419508d, c: 0.7069022317190777d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7008934612639857d, b: 0.7813578937742164d, c: 0.8299011519068267d),
new NpgsqlTypes.NpgsqlLine(a: 0.27035422492872085d, b: 0.6737999858600021d, c: 0.757587035993515d),
new NpgsqlTypes.NpgsqlLine(a: 0.2672774337922409d, b: 0.8521666941857675d, c: 0.662364468410422d),
new NpgsqlTypes.NpgsqlLine(a: 0.0843312844812254d, b: 0.7125146300678756d, c: 0.9590273497252031d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5527706210007534d, b: 0.4770031915250209d, c: 0.24289096555471523d),
new NpgsqlTypes.NpgsqlLine(a: 0.1787662545295342d, b: 0.9647975667011445d, c: 0.30725007843237073d),
new NpgsqlTypes.NpgsqlLine(a: 0.5779208093855058d, b: 0.16525264964116582d, c: 0.41309964803751975d),
new NpgsqlTypes.NpgsqlLine(a: 0.6306519427062903d, b: 0.04174582387518755d, c: 0.7903436775396744d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3864689770950823d, b: 0.7669942859810787d, c: 0.11901587149138793d),
new NpgsqlTypes.NpgsqlLine(a: 0.16162278141774722d, b: 0.8262102844285124d, c: 0.8711537968266807d),
new NpgsqlTypes.NpgsqlLine(a: 0.834631045888447d, b: 0.7551142723823506d, c: 0.6315451467613933d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23783833964716594d, b: 0.18840259467613285d, c: 0.38065449077062385d),
new NpgsqlTypes.NpgsqlLine(a: 0.5820806189377807d, b: 0.9087326841117063d, c: 0.9114464212192706d),
new NpgsqlTypes.NpgsqlLine(a: 0.6314909332904838d, b: 0.6399363084207442d, c: 0.3958980598451306d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.603109260347282d, b: 0.4357751784820453d, c: 0.34343797160193135d),
new NpgsqlTypes.NpgsqlLine(a: 0.4416198784591884d, b: 0.5261801936939441d, c: 0.8869674311695483d),
new NpgsqlTypes.NpgsqlLine(a: 0.5037965120007775d, b: 0.3466143180650195d, c: 0.4095595486582225d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2531309215385803d, b: 0.7229746251234593d, c: 0.24964952362388537d),
new NpgsqlTypes.NpgsqlLine(a: 0.910762301177569d, b: 0.30885955389618336d, c: 0.7845749325084656d),
new NpgsqlTypes.NpgsqlLine(a: 0.8357402270260332d, b: 0.2518264898255389d, c: 0.23766599213313366d),
new NpgsqlTypes.NpgsqlLine(a: 0.5454332481040827d, b: 0.0448695966497078d, c: 0.03417287807582914d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5305630406616749d, b: 0.22669401392873434d, c: 0.12174883839679596d),
new NpgsqlTypes.NpgsqlLine(a: 0.14387744860295415d, b: 0.7514139430320811d, c: 0.13888008869944857d),
new NpgsqlTypes.NpgsqlLine(a: 0.049308266953937085d, b: 0.027276462529497114d, c: 0.663505023922519d),
new NpgsqlTypes.NpgsqlLine(a: 0.6849468710347885d, b: 0.061314066373320264d, c: 0.12963417707885827d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32834912105162783d, b: 0.5899362888931362d, c: 0.015081730189112963d),
new NpgsqlTypes.NpgsqlLine(a: 0.7909572327488169d, b: 0.315964359040976d, c: 0.44401106835000415d),
new NpgsqlTypes.NpgsqlLine(a: 0.17149760944959935d, b: 0.0788425499437011d, c: 0.950732110135816d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5885420917762815d, b: 0.40295642929282294d, c: 0.3844176910754007d),
new NpgsqlTypes.NpgsqlLine(a: 0.6133666632461342d, b: 0.17986109532336914d, c: 0.9510103129846275d),
new NpgsqlTypes.NpgsqlLine(a: 0.7721275336620578d, b: 0.45727276313031306d, c: 0.11787362489917186d),
new NpgsqlTypes.NpgsqlLine(a: 0.6501285236624252d, b: 0.8655751788435777d, c: 0.05971643745903754d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08611345140804261d, b: 0.7681377667951899d, c: 0.043197581565673326d),
new NpgsqlTypes.NpgsqlLine(a: 0.37244771061553117d, b: 0.39121080856381085d, c: 0.5738179372733554d),
new NpgsqlTypes.NpgsqlLine(a: 0.04341217080570092d, b: 0.7086361105845769d, c: 0.5226669871601676d),
new NpgsqlTypes.NpgsqlLine(a: 0.023998977207030925d, b: 0.6936917746920962d, c: 0.2128693240781525d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2871789260988349d, b: 0.8055181494797043d, c: 0.7796548643922576d),
new NpgsqlTypes.NpgsqlLine(a: 0.43697467128321543d, b: 0.3389945000321606d, c: 0.21053904709635018d),
new NpgsqlTypes.NpgsqlLine(a: 0.21492894528797446d, b: 0.6070581158187022d, c: 0.2744906483514785d),
new NpgsqlTypes.NpgsqlLine(a: 0.9298547559341457d, b: 0.9371993421185996d, c: 0.7814600879062812d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5995555929973362d, b: 0.6472567209745206d, c: 0.9207346244632345d),
new NpgsqlTypes.NpgsqlLine(a: 0.718922691676769d, b: 0.22431744763549566d, c: 0.8263079362588143d),
new NpgsqlTypes.NpgsqlLine(a: 0.34547378376288707d, b: 0.6057574994842104d, c: 0.9652872585550825d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14721123144713255d, b: 0.35039494247388725d, c: 0.2916073499313012d),
new NpgsqlTypes.NpgsqlLine(a: 0.032358321243005306d, b: 0.09372272264084125d, c: 0.9581227369041344d),
new NpgsqlTypes.NpgsqlLine(a: 0.43755545683662067d, b: 0.6178542030655672d, c: 0.3696442075240829d),
new NpgsqlTypes.NpgsqlLine(a: 0.7864661252207762d, b: 0.6199596006864971d, c: 0.1674821108249649d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30046443687593105d, b: 0.6077626582625044d, c: 0.2661102088411924d),
new NpgsqlTypes.NpgsqlLine(a: 0.6643871581738303d, b: 0.11381182502092768d, c: 0.4325126679864695d),
new NpgsqlTypes.NpgsqlLine(a: 0.3243387036098013d, b: 0.27193833281985325d, c: 0.7678514157791062d),
new NpgsqlTypes.NpgsqlLine(a: 0.23733084420099737d, b: 0.23354316245458062d, c: 0.028665955205273153d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6067042798937763d, b: 0.43429789251487894d, c: 0.059768377750006985d),
new NpgsqlTypes.NpgsqlLine(a: 0.5718325444392591d, b: 0.36323161631882295d, c: 0.9083844045156423d),
new NpgsqlTypes.NpgsqlLine(a: 0.8523582005594768d, b: 0.6562900130706493d, c: 0.2752761826900383d),
new NpgsqlTypes.NpgsqlLine(a: 0.8190365485289006d, b: 0.2741634914483041d, c: 0.42071317670883945d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17794442539741007d, b: 0.8296647963342386d, c: 0.05468776508452999d),
new NpgsqlTypes.NpgsqlLine(a: 0.9451313288270793d, b: 0.6961971875423848d, c: 0.9105928980771371d),
new NpgsqlTypes.NpgsqlLine(a: 0.7353995757315026d, b: 0.3188475845455129d, c: 0.28975866535420347d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.698995374981078d, b: 0.8471871101665658d, c: 0.1957764273803212d),
new NpgsqlTypes.NpgsqlLine(a: 0.4149239229883873d, b: 0.22867496822384437d, c: 0.15728194200877899d),
new NpgsqlTypes.NpgsqlLine(a: 0.672366888795192d, b: 0.9748845241086194d, c: 0.06249199253824822d),
new NpgsqlTypes.NpgsqlLine(a: 0.30031388860626773d, b: 0.1145285247034965d, c: 0.07114365289236402d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2975029440054875d, b: 0.9962997124336268d, c: 0.5806421517212789d),
new NpgsqlTypes.NpgsqlLine(a: 0.538889756456929d, b: 0.9784165878423609d, c: 0.7428826084516816d),
new NpgsqlTypes.NpgsqlLine(a: 0.7738799266265501d, b: 0.25339639403710024d, c: 0.544943377927459d),
new NpgsqlTypes.NpgsqlLine(a: 0.8957275527937425d, b: 0.29944889734647984d, c: 0.6131507529171834d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14282725508128036d, b: 0.10793099637261805d, c: 0.43928076864095444d),
new NpgsqlTypes.NpgsqlLine(a: 0.44169535711276353d, b: 0.5867109651825797d, c: 0.3455220884428898d),
new NpgsqlTypes.NpgsqlLine(a: 0.5770495108858986d, b: 0.3839359082637629d, c: 0.4441849077568252d),
new NpgsqlTypes.NpgsqlLine(a: 0.6886862100027342d, b: 0.5686982646475567d, c: 0.7983846824379516d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.012553080509036363d, b: 0.8994704550069993d, c: 0.13972526260946094d),
new NpgsqlTypes.NpgsqlLine(a: 0.2952887838949021d, b: 0.29533540157327876d, c: 0.7274587449872719d),
new NpgsqlTypes.NpgsqlLine(a: 0.34557746334852046d, b: 0.8436208097985077d, c: 0.6858176685129589d),
new NpgsqlTypes.NpgsqlLine(a: 0.5998775568091158d, b: 0.17091660226987226d, c: 0.1644952166123942d),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5093877047198669d, b: 0.9692436380023794d, c: 0.05055947591708232d),
new NpgsqlTypes.NpgsqlLine(a: 0.7018346724041947d, b: 0.17192894879315446d, c: 0.8468487281305584d),
new NpgsqlTypes.NpgsqlLine(a: 0.6220682540868484d, b: 0.33791888600356323d, c: 0.5025259923018933d),
new NpgsqlTypes.NpgsqlLine(a: 0.4448685401005097d, b: 0.14323414233363152d, c: 0.6861735665350245d),
}));
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlLine(a: 0.5758357136429302d, b: 0.8155524521405018d, c: 0.058795169134659875d),
new NpgsqlTypes.NpgsqlLine(a: 0.3380249094594312d, b: 0.0676559117835801d, c: 0.707341362363196d),
new NpgsqlTypes.NpgsqlLine(a: 0.6569117481502343d, b: 0.8668670933017278d, c: 0.27951660703601755d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9645380355329579d, b: 0.6369184068214955d, c: 0.38451029790314417d),
new NpgsqlTypes.NpgsqlLine(a: 0.30418395899471395d, b: 0.2986530356568212d, c: 0.3215229450684519d),
new NpgsqlTypes.NpgsqlLine(a: 0.45980338719851155d, b: 0.9413037396885867d, c: 0.7228681582972933d),
new NpgsqlTypes.NpgsqlLine(a: 0.44350491643400747d, b: 0.8258089924220232d, c: 0.7884734312459775d),
}));
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[29], false);
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
                parametr1.Value = 31;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[30], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
                parametr1.Value = 10;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[30], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[30], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 50, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[30], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 4, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[29], false);
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 151, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[30], false);
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 151, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 10, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 16, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[30], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 143, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[29], false);
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 78, query1, 10, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[30], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 97))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 104, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
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

