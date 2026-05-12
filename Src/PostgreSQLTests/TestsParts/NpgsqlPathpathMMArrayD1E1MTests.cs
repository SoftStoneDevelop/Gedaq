

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
    internal partial interface INpgsqlPathMArraypathMMArrayD1
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD1 : INpgsqlPathMArraypathMMArrayD1
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD1E1M[] _testData = new NpgsqlPathpathMMArrayD1E1M[]
        {
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6365348487507206d, y: 0.6397282122877146d), new NpgsqlTypes.NpgsqlPoint(x: 0.803568187491772d, y: 0.6464385163172844d), new NpgsqlTypes.NpgsqlPoint(x: 0.28352857265884923d, y: 0.519002259441748d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8593577425198659d, y: 0.5857738900886426d), new NpgsqlTypes.NpgsqlPoint(x: 0.1129364499968808d, y: 0.6113548116203021d), new NpgsqlTypes.NpgsqlPoint(x: 0.28994557525142484d, y: 0.5878882942242647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5981654546712855d, y: 0.5169617858206516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046647854003163d, y: 0.3907470511726574d), new NpgsqlTypes.NpgsqlPoint(x: 0.4119975089782325d, y: 0.5859384338653525d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7779557786847776d, y: 0.9599417051147201d), new NpgsqlTypes.NpgsqlPoint(x: 0.32457159735359453d, y: 0.8730217051113125d), new NpgsqlTypes.NpgsqlPoint(x: 0.884850603620482d, y: 0.7329857996888114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5722053661606658d, y: 0.5169538063566494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418020638392919d, y: 0.8487364735954541d), new NpgsqlTypes.NpgsqlPoint(x: 0.837952169880496d, y: 0.2747139809721648d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7746227048144851d, y: 0.19824865407583814d), new NpgsqlTypes.NpgsqlPoint(x: 0.06655351754503402d, y: 0.31939782369128444d), new NpgsqlTypes.NpgsqlPoint(x: 0.29698469134584304d, y: 0.10084842552530571d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9112509776573818d, y: 0.7620339633995652d), new NpgsqlTypes.NpgsqlPoint(x: 0.10893524510131036d, y: 0.47356739007459303d), new NpgsqlTypes.NpgsqlPoint(x: 0.26487513786930783d, y: 0.9210564117738879d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.686136418844434d, y: 0.17968277146129252d), new NpgsqlTypes.NpgsqlPoint(x: 0.913482343415802d, y: 0.6392255234304115d), new NpgsqlTypes.NpgsqlPoint(x: 0.038161938623975655d, y: 0.2686805331217227d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7149194020648512d, y: 0.1231584398634662d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280183509467693d, y: 0.9076522815271961d), new NpgsqlTypes.NpgsqlPoint(x: 0.2806595175068908d, y: 0.5414378395990764d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7189262765053781d, y: 0.19785382930019257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7939468220162844d, y: 0.9998961048554607d), new NpgsqlTypes.NpgsqlPoint(x: 0.11596563613449984d, y: 0.8107330152329333d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7063450950183491d, y: 0.8077487993908536d), new NpgsqlTypes.NpgsqlPoint(x: 0.9666927431682351d, y: 0.042215548237589995d), new NpgsqlTypes.NpgsqlPoint(x: 0.5281623155895466d, y: 0.8457250461852366d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.974639532031656d, y: 0.09403597351207704d), new NpgsqlTypes.NpgsqlPoint(x: 0.2960393485483733d, y: 0.8823187373709035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291482031846089d, y: 0.05405630473496026d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.906193123943929d, y: 0.0775916956250996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9352237877080685d, y: 0.981487308407029d), new NpgsqlTypes.NpgsqlPoint(x: 0.42867684347681223d, y: 0.9629644256243778d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2847765866441653d, y: 0.4180061239694335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4026498573822299d, y: 0.560998828640962d), new NpgsqlTypes.NpgsqlPoint(x: 0.06964978545075795d, y: 0.2512402214984284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20279485204023484d, y: 0.44834854393461165d), new NpgsqlTypes.NpgsqlPoint(x: 0.3225706125924388d, y: 0.36186380698924836d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948531707606538d, y: 0.9906396440572585d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22910831460256464d, y: 0.23885963823436662d), new NpgsqlTypes.NpgsqlPoint(x: 0.2805401302001955d, y: 0.02465689125055115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9405123383757171d, y: 0.5118900594246064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9115820284788273d, y: 0.4399984797878207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601973409583286d, y: 0.8543257272227811d), new NpgsqlTypes.NpgsqlPoint(x: 0.2130003693935606d, y: 0.8919096230578071d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22840024735931785d, y: 0.9366681797584466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7352463673714951d, y: 0.175654570633747d), new NpgsqlTypes.NpgsqlPoint(x: 0.14571772792634174d, y: 0.6062893857406507d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8653267080540803d, y: 0.22853788478355586d), new NpgsqlTypes.NpgsqlPoint(x: 0.23289220104823938d, y: 0.4079485636312713d), new NpgsqlTypes.NpgsqlPoint(x: 0.13632448316780077d, y: 0.11237301188051652d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874343330560059d, y: 0.9143407320540757d), new NpgsqlTypes.NpgsqlPoint(x: 0.47832599420862554d, y: 0.6471215155394822d), new NpgsqlTypes.NpgsqlPoint(x: 0.10187351869749017d, y: 0.8732392233437312d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41404735655992486d, y: 0.9862691362975785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372557584260442d, y: 0.6922247873875247d), new NpgsqlTypes.NpgsqlPoint(x: 0.33348911482159627d, y: 0.2919729107188559d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8518127195470803d, y: 0.008279663044268304d), new NpgsqlTypes.NpgsqlPoint(x: 0.45357215566546394d, y: 0.07003738907052481d), new NpgsqlTypes.NpgsqlPoint(x: 0.20730569876224303d, y: 0.9470072507141422d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8820909513469442d, y: 0.14654956893247062d), new NpgsqlTypes.NpgsqlPoint(x: 0.9582778724696485d, y: 0.6512382280783532d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177076179658932d, y: 0.7501490066887061d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9227159735573357d, y: 0.37571874831640206d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761317435356176d, y: 0.7917530173817334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896194871924526d, y: 0.4267330354892793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7765413244836996d, y: 0.26864481102361115d), new NpgsqlTypes.NpgsqlPoint(x: 0.41005447873748224d, y: 0.8941804649901023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9931034831716644d, y: 0.6706382342797913d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8194559656509005d, y: 0.12464020742202953d), new NpgsqlTypes.NpgsqlPoint(x: 0.4552004986580548d, y: 0.18474474239626615d), new NpgsqlTypes.NpgsqlPoint(x: 0.2853792577774146d, y: 0.6764760746696583d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5859947049629146d, y: 0.09271710250898024d), new NpgsqlTypes.NpgsqlPoint(x: 0.26817834536046714d, y: 0.737560309631748d), new NpgsqlTypes.NpgsqlPoint(x: 0.5829617228566565d, y: 0.9203486118995138d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28981674143826286d, y: 0.8133202488659824d), new NpgsqlTypes.NpgsqlPoint(x: 0.693030800234446d, y: 0.061211091599464695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7071090065799845d, y: 0.3130171980958649d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8725635628945178d, y: 0.20694042730447126d), new NpgsqlTypes.NpgsqlPoint(x: 0.29056082002701455d, y: 0.2566302549848968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5825123567548253d, y: 0.4459958403419617d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8524933965630624d, y: 0.1454032357169336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645624886097092d, y: 0.1126064358426957d), new NpgsqlTypes.NpgsqlPoint(x: 0.09862029449521637d, y: 0.7575630910223556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4111171854275397d, y: 0.30826466167374134d), new NpgsqlTypes.NpgsqlPoint(x: 0.25520632320851155d, y: 0.5631824323505504d), new NpgsqlTypes.NpgsqlPoint(x: 0.4080741980223134d, y: 0.5415233352857176d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1562834286112207d, y: 0.10555428899414998d), new NpgsqlTypes.NpgsqlPoint(x: 0.32369468794601974d, y: 0.8421459586611317d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261930111175332d, y: 0.14115271058490508d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8755014371708277d, y: 0.7134986807120063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9535879825263208d, y: 0.870292821440137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6683534189272827d, y: 0.5044511115071296d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9853417812257496d, y: 0.8867051941257771d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371296600653613d, y: 0.997844886859391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9659505213170391d, y: 0.7368389917957904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4174047981423865d, y: 0.4246481806954986d), new NpgsqlTypes.NpgsqlPoint(x: 0.41321182337088436d, y: 0.5284015979788174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004784521008168d, y: 0.40393136363067983d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40595187759504814d, y: 0.910892887420261d), new NpgsqlTypes.NpgsqlPoint(x: 0.925960428235545d, y: 0.8461216772498286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957893549348614d, y: 0.35867586960688247d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6691009230126782d, y: 0.27945566082915374d), new NpgsqlTypes.NpgsqlPoint(x: 0.683277768935271d, y: 0.28583395556915214d), new NpgsqlTypes.NpgsqlPoint(x: 0.35136237324701813d, y: 0.24719250724682562d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7129811971839134d, y: 0.9954005401591476d), new NpgsqlTypes.NpgsqlPoint(x: 0.12514590705101059d, y: 0.2512337275650035d), new NpgsqlTypes.NpgsqlPoint(x: 0.9096630724443768d, y: 0.1464529716891838d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6929260863445956d, y: 0.34263180351792644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7670871813157434d, y: 0.17436150305041442d), new NpgsqlTypes.NpgsqlPoint(x: 0.697790315905711d, y: 0.5759644983996876d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37117594785192687d, y: 0.6083124521336366d), new NpgsqlTypes.NpgsqlPoint(x: 0.4470760741729405d, y: 0.8772911829903512d), new NpgsqlTypes.NpgsqlPoint(x: 0.47306802523695124d, y: 0.8170343925834957d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13102859243245468d, y: 0.46610591152402103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9024445494466354d, y: 0.9622183678977676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9007269226806817d, y: 0.36507082669456214d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27230071536913336d, y: 0.2905662904677342d), new NpgsqlTypes.NpgsqlPoint(x: 0.8162384100928709d, y: 0.18241344555299666d), new NpgsqlTypes.NpgsqlPoint(x: 0.18523821568983656d, y: 0.7358998275696645d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38397055476291164d, y: 0.28928081716342724d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156488780493711d, y: 0.431171720703474d), new NpgsqlTypes.NpgsqlPoint(x: 0.7780696746015953d, y: 0.16891661532432578d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5945411950568906d, y: 0.18148137617325555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6734161802599394d, y: 0.4865393756586315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7046047529419278d, y: 0.19124133079747851d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5010685952277789d, y: 0.5932389200632777d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005301245911499d, y: 0.40488728291903575d), new NpgsqlTypes.NpgsqlPoint(x: 0.14791932868813673d, y: 0.7971015468292572d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1459719947160989d, y: 0.11811674609823353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481631057996694d, y: 0.45107277387122047d), new NpgsqlTypes.NpgsqlPoint(x: 0.1803274131234952d, y: 0.9950123565842672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35576624372811083d, y: 0.7834617069050507d), new NpgsqlTypes.NpgsqlPoint(x: 0.6789808969882616d, y: 0.3627472234168123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7791608744168811d, y: 0.37904469583332756d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6799152495614225d, y: 0.6921214505499299d), new NpgsqlTypes.NpgsqlPoint(x: 0.31574240300260703d, y: 0.9856746640345173d), new NpgsqlTypes.NpgsqlPoint(x: 0.906668479436999d, y: 0.26022573277998473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006088462332369593d, y: 0.0927994762988954d), new NpgsqlTypes.NpgsqlPoint(x: 0.17616112089993252d, y: 0.9000757991957271d), new NpgsqlTypes.NpgsqlPoint(x: 0.885839006766683d, y: 0.8214507581055259d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048082548045874196d, y: 0.3391466209667654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7028646898032508d, y: 0.17377204667816504d), new NpgsqlTypes.NpgsqlPoint(x: 0.42818791052489935d, y: 0.6439116056139774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6143332254753379d, y: 0.8126977639805475d), new NpgsqlTypes.NpgsqlPoint(x: 0.20492490786376993d, y: 0.5201396112120755d), new NpgsqlTypes.NpgsqlPoint(x: 0.33433875211604447d, y: 0.99327684886467d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4320001549541794d, y: 0.9855499192601682d), new NpgsqlTypes.NpgsqlPoint(x: 0.23111534810955237d, y: 0.034066643917063155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6867763295211533d, y: 0.7963799580609692d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21601624175946355d, y: 0.6231876294024165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367213742658956d, y: 0.11891439024091455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4270429056960061d, y: 0.2984476618389381d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9309218059477256d, y: 0.9336056297929117d), new NpgsqlTypes.NpgsqlPoint(x: 0.26351010744113035d, y: 0.14688810801658825d), new NpgsqlTypes.NpgsqlPoint(x: 0.1304186002670874d, y: 0.7694161879264663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03657139413011212d, y: 0.9889830026163298d), new NpgsqlTypes.NpgsqlPoint(x: 0.8714971089775227d, y: 0.24090361794066928d), new NpgsqlTypes.NpgsqlPoint(x: 0.24225971785346312d, y: 0.8485289452978907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4373562039169847d, y: 0.45784339240910565d), new NpgsqlTypes.NpgsqlPoint(x: 0.38648835752171795d, y: 0.7110220329296666d), new NpgsqlTypes.NpgsqlPoint(x: 0.027797101151969428d, y: 0.4622825124485229d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08947582671612675d, y: 0.3118886069381196d), new NpgsqlTypes.NpgsqlPoint(x: 0.44730912188335115d, y: 0.37483760328823146d), new NpgsqlTypes.NpgsqlPoint(x: 0.7169318550097306d, y: 0.11105208537018474d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6982219262602082d, y: 0.6003643844959521d), new NpgsqlTypes.NpgsqlPoint(x: 0.4494825224851793d, y: 0.6330717744420981d), new NpgsqlTypes.NpgsqlPoint(x: 0.4773713011404185d, y: 0.11537650400459631d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.657023557261497d, y: 0.7881773825193914d), new NpgsqlTypes.NpgsqlPoint(x: 0.09599475392438783d, y: 0.6971825343958092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699911673636336d, y: 0.47014923966050903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7466949967204516d, y: 0.7834677158454801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5959847255603486d, y: 0.1950664191304986d), new NpgsqlTypes.NpgsqlPoint(x: 0.3290336996979477d, y: 0.22099717668197316d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9817151467424746d, y: 0.1621380961023685d), new NpgsqlTypes.NpgsqlPoint(x: 0.5069046925326524d, y: 0.3385757220639606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5139953678797206d, y: 0.3042927128167836d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29568427446101386d, y: 0.07151158190451345d), new NpgsqlTypes.NpgsqlPoint(x: 0.6786028829782851d, y: 0.7929144735271495d), new NpgsqlTypes.NpgsqlPoint(x: 0.357918930395696d, y: 0.1044554518115427d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.362617128447694d, y: 0.933754117017809d), new NpgsqlTypes.NpgsqlPoint(x: 0.4999605750675381d, y: 0.9097428220007294d), new NpgsqlTypes.NpgsqlPoint(x: 0.0679985329236924d, y: 0.36971813649276164d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06321253956333528d, y: 0.4018680598864979d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094003626043042d, y: 0.4982776807576911d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107518810295527d, y: 0.121622998792562d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8067277762276264d, y: 0.7761220638996622d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583755912300438d, y: 0.5623470030853096d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176074839103258d, y: 0.6797600116638358d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5245203370583954d, y: 0.37734727602003004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8130292571040326d, y: 0.7027944062977753d), new NpgsqlTypes.NpgsqlPoint(x: 0.7810212874884669d, y: 0.15273600475603755d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2037563000378002d, y: 0.013085794992121147d), new NpgsqlTypes.NpgsqlPoint(x: 0.36345648788351403d, y: 0.14444894185964952d), new NpgsqlTypes.NpgsqlPoint(x: 0.3297075312030484d, y: 0.8265911686676365d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44718808530639d, y: 0.6230693472059662d), new NpgsqlTypes.NpgsqlPoint(x: 0.13145835752423018d, y: 0.445677386142056d), new NpgsqlTypes.NpgsqlPoint(x: 0.17168602944554623d, y: 0.1794584990016459d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.701601273794466d, y: 0.995428549122693d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131048382732516d, y: 0.2777694227344014d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092552515402589d, y: 0.861982320695879d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8576383113569614d, y: 0.6025588757467674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477448741538402d, y: 0.669592054662876d), new NpgsqlTypes.NpgsqlPoint(x: 0.115760882941367d, y: 0.4264120723596023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08320998355355524d, y: 0.7607037448076157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573505577388757d, y: 0.1080247230027902d), new NpgsqlTypes.NpgsqlPoint(x: 0.46594688550519525d, y: 0.2633079352960115d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8688599700216445d, y: 0.6043461290000416d), new NpgsqlTypes.NpgsqlPoint(x: 0.35237761689492453d, y: 0.35313739344945083d), new NpgsqlTypes.NpgsqlPoint(x: 0.21714593114074476d, y: 0.5269327032066473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03919429328231072d, y: 0.7888765616185915d), new NpgsqlTypes.NpgsqlPoint(x: 0.24126192340743113d, y: 0.34376955079942406d), new NpgsqlTypes.NpgsqlPoint(x: 0.3430372041295495d, y: 0.7826540886114665d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48437237554819046d, y: 0.41604745590925774d), new NpgsqlTypes.NpgsqlPoint(x: 0.910302053041993d, y: 0.5056268204571641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5837344971683223d, y: 0.31467453202165185d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11574160361004016d, y: 0.9298450072236777d), new NpgsqlTypes.NpgsqlPoint(x: 0.388588555749778d, y: 0.42909279796412925d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541326528253693d, y: 0.8396508735366564d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8841364758772344d, y: 0.5350006803677199d), new NpgsqlTypes.NpgsqlPoint(x: 0.5752014700396323d, y: 0.9962438392333187d), new NpgsqlTypes.NpgsqlPoint(x: 0.17975294902835104d, y: 0.04080404326797549d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4154888761038076d, y: 0.5315831602579636d), new NpgsqlTypes.NpgsqlPoint(x: 0.6723078391058176d, y: 0.11203065431858594d), new NpgsqlTypes.NpgsqlPoint(x: 0.09438469234877134d, y: 0.811482298717242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5052290662785639d, y: 0.5467544070971656d), new NpgsqlTypes.NpgsqlPoint(x: 0.1591364056430543d, y: 0.639606624690606d), new NpgsqlTypes.NpgsqlPoint(x: 0.31424916249242263d, y: 0.06617252523052175d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12518736896085092d, y: 0.14447476730434738d), new NpgsqlTypes.NpgsqlPoint(x: 0.11115254202973646d, y: 0.4077857858027977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357265242182216d, y: 0.49764469762655883d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5780860540761367d, y: 0.07415339309166535d), new NpgsqlTypes.NpgsqlPoint(x: 0.309981371598673d, y: 0.720326995489305d), new NpgsqlTypes.NpgsqlPoint(x: 0.3265300130295906d, y: 0.1712773897617237d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5731763229586051d, y: 0.5822620147779052d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486988181798919d, y: 0.29179016962136917d), new NpgsqlTypes.NpgsqlPoint(x: 0.7565146550471424d, y: 0.21951618473263368d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43630707445689276d, y: 0.3044526268104609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6829996241310063d, y: 0.5388533961819069d), new NpgsqlTypes.NpgsqlPoint(x: 0.4280546966502732d, y: 0.9564094261563868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9801641853372046d, y: 0.34197020070070283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968770790433825d, y: 0.8228932877758749d), new NpgsqlTypes.NpgsqlPoint(x: 0.621757188216688d, y: 0.6306454306920852d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9439595066850448d, y: 0.4970289547253586d), new NpgsqlTypes.NpgsqlPoint(x: 0.12471416406331737d, y: 0.6382722987201919d), new NpgsqlTypes.NpgsqlPoint(x: 0.04552019255399298d, y: 0.6745661964737449d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6595363933433557d, y: 0.7539916072233458d), new NpgsqlTypes.NpgsqlPoint(x: 0.567439683276081d, y: 0.8155316485875892d), new NpgsqlTypes.NpgsqlPoint(x: 0.49623097539907757d, y: 0.2473495747568638d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45118370543350117d, y: 0.5772492191630908d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061899558936109d, y: 0.1886066511213279d), new NpgsqlTypes.NpgsqlPoint(x: 0.4657782822066233d, y: 0.026851411640646083d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018518185273970422d, y: 0.2802520053342199d), new NpgsqlTypes.NpgsqlPoint(x: 0.7589691471908464d, y: 0.045268275718221895d), new NpgsqlTypes.NpgsqlPoint(x: 0.12185520856949372d, y: 0.7143515024470145d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9845558041848758d, y: 0.17285081782046796d), new NpgsqlTypes.NpgsqlPoint(x: 0.19102718604176572d, y: 0.4106572904470043d), new NpgsqlTypes.NpgsqlPoint(x: 0.04320319637075676d, y: 0.1019515249188011d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7021633452779016d, y: 0.003932395313159587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583132175024724d, y: 0.20511223281512203d), new NpgsqlTypes.NpgsqlPoint(x: 0.1643980688359279d, y: 0.8551555832584292d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5790563174311878d, y: 0.5533666463591893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824436151054546d, y: 0.9013598094001292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9521836341672937d, y: 0.03406350563963778d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7163652707906797d, y: 0.5599944649302337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4970902515103971d, y: 0.7643761414470911d), new NpgsqlTypes.NpgsqlPoint(x: 0.32989055345575724d, y: 0.06864292862169574d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9923472569111844d, y: 0.1455583279230842d), new NpgsqlTypes.NpgsqlPoint(x: 0.3510138576009648d, y: 0.2670303991899916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6944405348502396d, y: 0.2649377200474202d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9507293653910717d, y: 0.9369304280907085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9718858826859289d, y: 0.9337127220740432d), new NpgsqlTypes.NpgsqlPoint(x: 0.17713147028271647d, y: 0.8967848270227495d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36915228280096746d, y: 0.7651424123484198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9310670865718317d, y: 0.46354020715129274d), new NpgsqlTypes.NpgsqlPoint(x: 0.856616939490608d, y: 0.6207862560895391d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8474675786766634d, y: 0.6172012883774534d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298848764766497d, y: 0.6717068326902182d), new NpgsqlTypes.NpgsqlPoint(x: 0.6296469604623631d, y: 0.6946864385387923d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.051083546531648705d, y: 0.8704800698372165d), new NpgsqlTypes.NpgsqlPoint(x: 0.16943213993255035d, y: 0.8734100609393238d), new NpgsqlTypes.NpgsqlPoint(x: 0.03570156621180265d, y: 0.2761264858897676d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6702562553675416d, y: 0.680287516687657d), new NpgsqlTypes.NpgsqlPoint(x: 0.50383154634475d, y: 0.9490751316651622d), new NpgsqlTypes.NpgsqlPoint(x: 0.005691015503517027d, y: 0.619087014792465d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3421013959295459d, y: 0.6220913343321242d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114635856435547d, y: 0.6518986743239155d), new NpgsqlTypes.NpgsqlPoint(x: 0.935906224007197d, y: 0.5161592884371455d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20361961472565848d, y: 0.21214181883164862d), new NpgsqlTypes.NpgsqlPoint(x: 0.3272537660164829d, y: 0.17677968738674876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085058661723937d, y: 0.6586366984687564d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6911625212899425d, y: 0.8972776617732137d), new NpgsqlTypes.NpgsqlPoint(x: 0.3126717923154114d, y: 0.5262158915586325d), new NpgsqlTypes.NpgsqlPoint(x: 0.7081325619768601d, y: 0.24789482567887067d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25188270007891855d, y: 0.43116099223821447d), new NpgsqlTypes.NpgsqlPoint(x: 0.7007079919693611d, y: 0.3816719909861026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6056848179201614d, y: 0.8298779720924504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9882478256853475d, y: 0.989555288398346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006595869285156d, y: 0.5358931833929372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3283614601746132d, y: 0.6742018658384042d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9524543965471618d, y: 0.4793381146081145d), new NpgsqlTypes.NpgsqlPoint(x: 0.3759132313776249d, y: 0.42882517920160423d), new NpgsqlTypes.NpgsqlPoint(x: 0.05440291422391663d, y: 0.34064063104269204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8072773555296721d, y: 0.3976148474574581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936351899536355d, y: 0.42063488073240096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3787159167100915d, y: 0.1685471345493974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8754054631260728d, y: 0.03933458230715192d), new NpgsqlTypes.NpgsqlPoint(x: 0.421168518890649d, y: 0.7318417953295319d), new NpgsqlTypes.NpgsqlPoint(x: 0.2507899939497411d, y: 0.9138684065602135d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30225479802595767d, y: 0.543243263593879d), new NpgsqlTypes.NpgsqlPoint(x: 0.7101462681889388d, y: 0.643271493043018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9580212020514186d, y: 0.8075650019999029d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07108618683880708d, y: 0.5933698567955711d), new NpgsqlTypes.NpgsqlPoint(x: 0.007376722418241499d, y: 0.9732433861287217d), new NpgsqlTypes.NpgsqlPoint(x: 0.667490841031685d, y: 0.2989304538611085d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9319210390029645d, y: 0.8777473303387403d), new NpgsqlTypes.NpgsqlPoint(x: 0.7126558558233086d, y: 0.27380550215903077d), new NpgsqlTypes.NpgsqlPoint(x: 0.227284953514717d, y: 0.17688791282933847d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16630503728483026d, y: 0.8404080327024486d), new NpgsqlTypes.NpgsqlPoint(x: 0.3901832187927248d, y: 0.20649467058423177d), new NpgsqlTypes.NpgsqlPoint(x: 0.3593393475852201d, y: 0.747730727390691d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5477303828132412d, y: 0.024174259098519557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6902346794869111d, y: 0.3351862752904894d), new NpgsqlTypes.NpgsqlPoint(x: 0.1427331121331168d, y: 0.9537166941882104d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16911866546862953d, y: 0.39448214014911875d), new NpgsqlTypes.NpgsqlPoint(x: 0.763515603947833d, y: 0.8515541045766545d), new NpgsqlTypes.NpgsqlPoint(x: 0.7115502420340082d, y: 0.9776250781707304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5630937797819604d, y: 0.42831413310071176d), new NpgsqlTypes.NpgsqlPoint(x: 0.1637767262476999d, y: 0.06313760626629661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430428396557567d, y: 0.15589482525179865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25481842701578816d, y: 0.6690354854516877d), new NpgsqlTypes.NpgsqlPoint(x: 0.48100235354235144d, y: 0.2105117872904303d), new NpgsqlTypes.NpgsqlPoint(x: 0.14236683481469037d, y: 0.4484819959350155d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4858166376110461d, y: 0.577430330702447d), new NpgsqlTypes.NpgsqlPoint(x: 0.20851074010373916d, y: 0.38844926980043326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9363773340903324d, y: 0.1320480261997492d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2866558449283585d, y: 0.2739729197484374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756711360638856d, y: 0.8402571184894259d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561725189855453d, y: 0.003010166174771456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49976026622641945d, y: 0.9513873482163605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821699798095639d, y: 0.47160159404015667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662817940231315d, y: 0.21305375818294847d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4524679204379275d, y: 0.37918888514462623d), new NpgsqlTypes.NpgsqlPoint(x: 0.2652253544028582d, y: 0.24459089000194423d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418628064297828d, y: 0.4037458942681921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2710281154389854d, y: 0.2696771572272889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8579754270309533d, y: 0.6244349674146268d), new NpgsqlTypes.NpgsqlPoint(x: 0.18855903205080637d, y: 0.2678804404961599d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47432534373052115d, y: 0.38428423797408107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6216138157498383d, y: 0.9282334823361181d), new NpgsqlTypes.NpgsqlPoint(x: 0.18059261644205649d, y: 0.5508457898297133d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2091335238145393d, y: 0.3918393983481415d), new NpgsqlTypes.NpgsqlPoint(x: 0.316665957663673d, y: 0.20554368749272844d), new NpgsqlTypes.NpgsqlPoint(x: 0.09660954897480445d, y: 0.6131290155171046d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40416478086182994d, y: 0.937324312582499d), new NpgsqlTypes.NpgsqlPoint(x: 0.9163377246398975d, y: 0.03555880517442789d), new NpgsqlTypes.NpgsqlPoint(x: 0.8946107954194379d, y: 0.3564157470414946d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7965744506918577d, y: 0.4588148104859433d), new NpgsqlTypes.NpgsqlPoint(x: 0.04732148208720954d, y: 0.3341488353927382d), new NpgsqlTypes.NpgsqlPoint(x: 0.2667206618856355d, y: 0.34724107121824643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9993600809279456d, y: 0.4766238509621835d), new NpgsqlTypes.NpgsqlPoint(x: 0.796880563331296d, y: 0.23821542267174511d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720380963231894d, y: 0.7152500026296261d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9685915193642778d, y: 0.5225563519927771d), new NpgsqlTypes.NpgsqlPoint(x: 0.20201901705798297d, y: 0.01898582633608137d), new NpgsqlTypes.NpgsqlPoint(x: 0.24183513127463319d, y: 0.6114268522584928d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8688898082632349d, y: 0.5385397505048518d), new NpgsqlTypes.NpgsqlPoint(x: 0.2463559329246846d, y: 0.06445427437016371d), new NpgsqlTypes.NpgsqlPoint(x: 0.8152530181956422d, y: 0.4659766936814945d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42209695512349454d, y: 0.2126174456513078d), new NpgsqlTypes.NpgsqlPoint(x: 0.1564547721390217d, y: 0.9299230714927892d), new NpgsqlTypes.NpgsqlPoint(x: 0.265698722596621d, y: 0.1236418764395768d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12364326902693668d, y: 0.8625891904103121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5905220016878189d, y: 0.4476385257569314d), new NpgsqlTypes.NpgsqlPoint(x: 0.43460560754815836d, y: 0.6647496000016523d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07668401104069389d, y: 0.0022758892060160685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554371542162361d, y: 0.8669328536862716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6919519199838641d, y: 0.7355902528217314d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6003253271326008d, y: 0.6062989936960914d), new NpgsqlTypes.NpgsqlPoint(x: 0.4746872752766452d, y: 0.583342844428922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9193985183439987d, y: 0.7423593305521594d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1346678619142847d, y: 0.24358396280496086d), new NpgsqlTypes.NpgsqlPoint(x: 0.23944215826838766d, y: 0.7627488257024284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3727733257333623d, y: 0.18166760877732735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4087963715311107d, y: 0.17087841562615969d), new NpgsqlTypes.NpgsqlPoint(x: 0.1733985670268583d, y: 0.5281628338532914d), new NpgsqlTypes.NpgsqlPoint(x: 0.02156196419927181d, y: 0.6830367499303229d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6384955767304206d, y: 0.3122944806396315d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449947192071659d, y: 0.9350248971987026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201234106508931d, y: 0.2984852183735036d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8429984205524808d, y: 0.9536399442244898d), new NpgsqlTypes.NpgsqlPoint(x: 0.014831742940163206d, y: 0.054556170725192366d), new NpgsqlTypes.NpgsqlPoint(x: 0.1580525268042292d, y: 0.2636814909816434d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30663256195559885d, y: 0.37562838236786344d), new NpgsqlTypes.NpgsqlPoint(x: 0.410810874253138d, y: 0.6479674295937299d), new NpgsqlTypes.NpgsqlPoint(x: 0.3414190122761941d, y: 0.3569058371709142d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9684848517443891d, y: 0.10309010752021952d), new NpgsqlTypes.NpgsqlPoint(x: 0.2705231713521089d, y: 0.7278188783768216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5543497874488288d, y: 0.5468382317915689d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44735411081589216d, y: 0.9866573859616953d), new NpgsqlTypes.NpgsqlPoint(x: 0.06490038320112335d, y: 0.7894739568680532d), new NpgsqlTypes.NpgsqlPoint(x: 0.49112505345624136d, y: 0.27232255813549344d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6321109724143459d, y: 0.013570053052184727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9586819597827321d, y: 0.9425701200109315d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039857885708169d, y: 0.5344019029540473d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.643838692926178d, y: 0.41458466433575814d), new NpgsqlTypes.NpgsqlPoint(x: 0.4754885654296409d, y: 0.9560580820905218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533245236463088d, y: 0.179878514500874d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5486239641593488d, y: 0.6610242098269227d), new NpgsqlTypes.NpgsqlPoint(x: 0.6657955655821883d, y: 0.608383180955157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136121064718319d, y: 0.681581256838634d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6086692210291743d, y: 0.36201908912831626d), new NpgsqlTypes.NpgsqlPoint(x: 0.06757733294566926d, y: 0.7028067048869981d), new NpgsqlTypes.NpgsqlPoint(x: 0.07318536540443232d, y: 0.5677406029868188d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5587674451362115d, y: 0.4770383881187761d), new NpgsqlTypes.NpgsqlPoint(x: 0.3191894506395837d, y: 0.6496488394988356d), new NpgsqlTypes.NpgsqlPoint(x: 0.08158280555959385d, y: 0.3729590659560269d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7640062299506819d, y: 0.2989696256956972d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734847626923806d, y: 0.7536281665567834d), new NpgsqlTypes.NpgsqlPoint(x: 0.5250759639244831d, y: 0.544137473623663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35093085470029084d, y: 0.3804325109571126d), new NpgsqlTypes.NpgsqlPoint(x: 0.21632142774174024d, y: 0.2846628717302535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7773174918822617d, y: 0.4978325696750846d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3742884528182854d, y: 0.5315824084382129d), new NpgsqlTypes.NpgsqlPoint(x: 0.3460961186867353d, y: 0.6871704484700918d), new NpgsqlTypes.NpgsqlPoint(x: 0.14102562207758396d, y: 0.8795352717645838d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0834458657369479d, y: 0.4346790696822693d), new NpgsqlTypes.NpgsqlPoint(x: 0.6186796411767153d, y: 0.7570183564860462d), new NpgsqlTypes.NpgsqlPoint(x: 0.5414342869808967d, y: 0.20706015241665976d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12092853093728739d, y: 0.6903756975408808d), new NpgsqlTypes.NpgsqlPoint(x: 0.6293955869736552d, y: 0.29060758784188223d), new NpgsqlTypes.NpgsqlPoint(x: 0.07930584427606469d, y: 0.20589518794517092d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.586284350277865d, y: 0.6334021813301661d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983251192249981d, y: 0.018921132451638956d), new NpgsqlTypes.NpgsqlPoint(x: 0.695983840776278d, y: 0.4752019861304482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6224340636160298d, y: 0.8780907340272522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5548804299572562d, y: 0.3378891131652958d), new NpgsqlTypes.NpgsqlPoint(x: 0.019570183641809846d, y: 0.049068392930934346d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2275422763714836d, y: 0.03862672171008208d), new NpgsqlTypes.NpgsqlPoint(x: 0.5453522017981486d, y: 0.9775902697578246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7556639211004289d, y: 0.46684076694139154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2319476324994576d, y: 0.6728613670026115d), new NpgsqlTypes.NpgsqlPoint(x: 0.4239791613280175d, y: 0.6771811854933637d), new NpgsqlTypes.NpgsqlPoint(x: 0.8336504767401717d, y: 0.6821966883023278d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3074465345719426d, y: 0.1908344435300715d), new NpgsqlTypes.NpgsqlPoint(x: 0.01860703645176065d, y: 0.4380737319791289d), new NpgsqlTypes.NpgsqlPoint(x: 0.2306019347934296d, y: 0.43327471224511327d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9130323882691331d, y: 0.11417029159458314d), new NpgsqlTypes.NpgsqlPoint(x: 0.3408375279380793d, y: 0.38209874292661616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932562848258464d, y: 0.38181728842467444d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11541262587191148d, y: 0.01504505481697982d), new NpgsqlTypes.NpgsqlPoint(x: 0.15524961640508061d, y: 0.4345488178583998d), new NpgsqlTypes.NpgsqlPoint(x: 0.5361535104974812d, y: 0.4939822611392404d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6061717469028515d, y: 0.3803146786563124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5016394389735143d, y: 0.5401870688781042d), new NpgsqlTypes.NpgsqlPoint(x: 0.895177102742009d, y: 0.9194088320383907d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7440933453551165d, y: 0.44905950081870605d), new NpgsqlTypes.NpgsqlPoint(x: 0.39022017512470997d, y: 0.8292800708667907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8081071460836725d, y: 0.9333410343412266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05645155534576263d, y: 0.05068005363955275d), new NpgsqlTypes.NpgsqlPoint(x: 0.04083482270006d, y: 0.5893369958380685d), new NpgsqlTypes.NpgsqlPoint(x: 0.04157044914463204d, y: 0.1657769092026783d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35982188035920515d, y: 0.7493479609822853d), new NpgsqlTypes.NpgsqlPoint(x: 0.04084951331338027d, y: 0.15483479782893084d), new NpgsqlTypes.NpgsqlPoint(x: 0.8237786200890634d, y: 0.49749539497787176d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1377880323625672d, y: 0.40413710658580115d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139701583458298d, y: 0.4377437163599436d), new NpgsqlTypes.NpgsqlPoint(x: 0.46155024325541394d, y: 0.533543460837871d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7725205092654797d, y: 0.43414055879273217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9314769796994081d, y: 0.08299474985669442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848919776507367d, y: 0.9104070161472856d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7205840822846195d, y: 0.7020884594267485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605030773280462d, y: 0.3259087179522633d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056079352560654d, y: 0.3502271415178815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9301534272463995d, y: 0.7538318579594029d), new NpgsqlTypes.NpgsqlPoint(x: 0.8021996767316569d, y: 0.11913237434869273d), new NpgsqlTypes.NpgsqlPoint(x: 0.733392303978139d, y: 0.8148018448876048d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43226018487474227d, y: 0.6567391047517013d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046662741814774d, y: 0.7021930492983146d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632166481875692d, y: 0.6142603871979418d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42596688145574846d, y: 0.12618890670698513d), new NpgsqlTypes.NpgsqlPoint(x: 0.18599869314342266d, y: 0.5140385286356449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274738315605129d, y: 0.6647346759865975d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07361434128343347d, y: 0.0742593592295504d), new NpgsqlTypes.NpgsqlPoint(x: 0.2756983036757613d, y: 0.4402098415093172d), new NpgsqlTypes.NpgsqlPoint(x: 0.17753314629104222d, y: 0.7769152048226629d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1963094566480661d, y: 0.5984781473665958d), new NpgsqlTypes.NpgsqlPoint(x: 0.8267523808692269d, y: 0.5831307560600318d), new NpgsqlTypes.NpgsqlPoint(x: 0.04816171365291033d, y: 0.9741238157534382d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512868849790972d, y: 0.8850874969347295d), new NpgsqlTypes.NpgsqlPoint(x: 0.38523158678550695d, y: 0.023806920581225133d), new NpgsqlTypes.NpgsqlPoint(x: 0.24608360976349974d, y: 0.31939858410948463d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3168812231167145d, y: 0.8978582863956546d), new NpgsqlTypes.NpgsqlPoint(x: 0.880231965552938d, y: 0.3191028631420101d), new NpgsqlTypes.NpgsqlPoint(x: 0.3008371808300677d, y: 0.3580067844655769d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6789752191843251d, y: 0.587771263833845d), new NpgsqlTypes.NpgsqlPoint(x: 0.6433565415012582d, y: 0.0434328007247089d), new NpgsqlTypes.NpgsqlPoint(x: 0.5796374238511528d, y: 0.40288921530613453d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.615935180908261d, y: 0.15041976184661154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9329507073714569d, y: 0.10905337844525087d), new NpgsqlTypes.NpgsqlPoint(x: 0.7189281338414365d, y: 0.7101618461801081d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7320795681984162d, y: 0.5650245409072756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9272708642461001d, y: 0.3047757753169663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9336824510605883d, y: 0.09264275219826368d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5687840755569049d, y: 0.035555526345646404d), new NpgsqlTypes.NpgsqlPoint(x: 0.07327172553111894d, y: 0.6516292563040966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181488940281898d, y: 0.16683353547765778d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03418670129983781d, y: 0.3289636488993395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846340645779401d, y: 0.1350774827293364d), new NpgsqlTypes.NpgsqlPoint(x: 0.2900926191270331d, y: 0.3538979987677777d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017269739349636604d, y: 0.513143148399015d), new NpgsqlTypes.NpgsqlPoint(x: 0.15228245507917937d, y: 0.6322017693406795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9394381821705109d, y: 0.2580814225215303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9170310354516168d, y: 0.5126276114823431d), new NpgsqlTypes.NpgsqlPoint(x: 0.20935945118695232d, y: 0.5651957109166064d), new NpgsqlTypes.NpgsqlPoint(x: 0.09649582240446408d, y: 0.1090870037461672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9120583227982515d, y: 0.9230319117677048d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748561799640421d, y: 0.4371373084593142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840359572946918d, y: 0.13513293995087017d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7308475566624522d, y: 0.08901887376247797d), new NpgsqlTypes.NpgsqlPoint(x: 0.053796867380738855d, y: 0.8793750911765913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6918509758022139d, y: 0.6363909465906431d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6266280048680453d, y: 0.0751782583524635d), new NpgsqlTypes.NpgsqlPoint(x: 0.761457796772123d, y: 0.9134424939662817d), new NpgsqlTypes.NpgsqlPoint(x: 0.030521477875454006d, y: 0.5695887617406012d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4836228513521301d, y: 0.3481146180430469d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986941669723028d, y: 0.0829786040606798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639551073111323d, y: 0.3678262121406285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8667653615773853d, y: 0.4753445377391764d), new NpgsqlTypes.NpgsqlPoint(x: 0.07750443718965794d, y: 0.22018217124174622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6864620729154824d, y: 0.6968098239389799d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09690861472136125d, y: 0.04090331895095023d), new NpgsqlTypes.NpgsqlPoint(x: 0.27828199757238914d, y: 0.9297470490833076d), new NpgsqlTypes.NpgsqlPoint(x: 0.2265001263923052d, y: 0.4855443599074324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2188719101343043d, y: 0.9876437597956592d), new NpgsqlTypes.NpgsqlPoint(x: 0.5582978565493459d, y: 0.07887958240580284d), new NpgsqlTypes.NpgsqlPoint(x: 0.22164473506237858d, y: 0.3436758649425665d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43533522203680275d, y: 0.14702974841914562d), new NpgsqlTypes.NpgsqlPoint(x: 0.7540847342023334d, y: 0.5523878174546532d), new NpgsqlTypes.NpgsqlPoint(x: 0.29704670263915045d, y: 0.14054924022497783d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6839911754353889d, y: 0.2841190172618657d), new NpgsqlTypes.NpgsqlPoint(x: 0.056131911245987265d, y: 0.735953428931436d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712566433382595d, y: 0.2249956820027078d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9023800880432276d, y: 0.9058739903744218d), new NpgsqlTypes.NpgsqlPoint(x: 0.547776129475123d, y: 0.40854559027628456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5398602565212133d, y: 0.01750054002816448d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2681061040562547d, y: 0.5123466759160292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149204058890642d, y: 0.7120884255841745d), new NpgsqlTypes.NpgsqlPoint(x: 0.33912081549714446d, y: 0.14397234428420447d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3411270027033625d, y: 0.9819095262014065d), new NpgsqlTypes.NpgsqlPoint(x: 0.2136693678312821d, y: 0.5690783076804303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8845621915680526d, y: 0.5257561348750526d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5862057811937245d, y: 0.9894852621364537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9703514686187249d, y: 0.22297459592969693d), new NpgsqlTypes.NpgsqlPoint(x: 0.42458501182010433d, y: 0.09710955272821253d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45280078036793525d, y: 0.8594663258543883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069517224432029d, y: 0.1869479232611635d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221570868491198d, y: 0.8372064621936435d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49037556398849313d, y: 0.9859665334315977d), new NpgsqlTypes.NpgsqlPoint(x: 0.05230229433356903d, y: 0.864337396609617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639110793279897d, y: 0.649905088257729d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3149802204512159d, y: 0.49282020348866773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5925084394971385d, y: 0.8299496417565122d), new NpgsqlTypes.NpgsqlPoint(x: 0.4108577593000594d, y: 0.5391806031442551d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2908235042144117d, y: 0.4283216395854882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5725125067632143d, y: 0.23551091029724047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356071369730832d, y: 0.3253249946372019d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7174130854659688d, y: 0.06788855619348999d), new NpgsqlTypes.NpgsqlPoint(x: 0.3001791932536605d, y: 0.7525812608965203d), new NpgsqlTypes.NpgsqlPoint(x: 0.6677193100457725d, y: 0.3496738745858766d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7150170587062993d, y: 0.7820949061477942d), new NpgsqlTypes.NpgsqlPoint(x: 0.9763162825832383d, y: 0.33198724875096797d), new NpgsqlTypes.NpgsqlPoint(x: 0.05898846600734786d, y: 0.9157783065582757d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6495502825561017d, y: 0.4960800285217367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5340811164588933d, y: 0.6397173337111485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8618715697750334d, y: 0.23372583913107015d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0390518641535208d, y: 0.9045430671243327d), new NpgsqlTypes.NpgsqlPoint(x: 0.23132122589867965d, y: 0.8308358101962036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488885294105577d, y: 0.770253035089542d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9288963885675011d, y: 0.3701417291161865d), new NpgsqlTypes.NpgsqlPoint(x: 0.12246115679247283d, y: 0.8232267464989707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409004461147465d, y: 0.3698893579213013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6391860886250605d, y: 0.3350058006663441d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403088822402454d, y: 0.9980157051849646d), new NpgsqlTypes.NpgsqlPoint(x: 0.26831112579095784d, y: 0.6794282514303583d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21792724954300713d, y: 0.030158063053635997d), new NpgsqlTypes.NpgsqlPoint(x: 0.16519187019236425d, y: 0.5800689124531372d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524112728363298d, y: 0.15471508883961127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1980390926153599d, y: 0.5077172537737139d), new NpgsqlTypes.NpgsqlPoint(x: 0.7929477789053784d, y: 0.558687668574077d), new NpgsqlTypes.NpgsqlPoint(x: 0.26633451135196673d, y: 0.08816296045470862d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9258825567836388d, y: 0.9787544974623673d), new NpgsqlTypes.NpgsqlPoint(x: 0.1515779612465602d, y: 0.5936554406941633d), new NpgsqlTypes.NpgsqlPoint(x: 0.7816957097766425d, y: 0.20108078089993742d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2856846352402136d, y: 0.23989091669968787d), new NpgsqlTypes.NpgsqlPoint(x: 0.054947568692990556d, y: 0.6078967481375507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5013694659891197d, y: 0.05238059293228703d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48212099708617506d, y: 0.16421274789031937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827708347084509d, y: 0.5797730477627617d), new NpgsqlTypes.NpgsqlPoint(x: 0.6408592139049835d, y: 0.21141100971359172d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.371577704618533d, y: 0.19039434279677847d), new NpgsqlTypes.NpgsqlPoint(x: 0.27972546824878886d, y: 0.7605265478801339d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161382065582395d, y: 0.46063720124064256d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0367200092492983d, y: 0.7097609922565975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5586912002638437d, y: 0.058708332863248835d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141165200865404d, y: 0.7474191619679796d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5119675257710902d, y: 0.826963791526732d), new NpgsqlTypes.NpgsqlPoint(x: 0.03538486484969661d, y: 0.9850076522682624d), new NpgsqlTypes.NpgsqlPoint(x: 0.37323199249051464d, y: 0.017002174043539875d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21792478460920162d, y: 0.8886248491411908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537199680991393d, y: 0.47682397627530804d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503645110695998d, y: 0.09089904313285324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6857716622630401d, y: 0.8597685462895538d), new NpgsqlTypes.NpgsqlPoint(x: 0.7230688128073175d, y: 0.6576922893870237d), new NpgsqlTypes.NpgsqlPoint(x: 0.07017707737723167d, y: 0.9566154165832943d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33296041045908287d, y: 0.9268980080411242d), new NpgsqlTypes.NpgsqlPoint(x: 0.42392552039788056d, y: 0.4627621628942691d), new NpgsqlTypes.NpgsqlPoint(x: 0.546758065668578d, y: 0.5873206071313516d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16287896227115384d, y: 0.8934687996583937d), new NpgsqlTypes.NpgsqlPoint(x: 0.42067453832597834d, y: 0.9047349836612245d), new NpgsqlTypes.NpgsqlPoint(x: 0.37794147005262513d, y: 0.8052120279574613d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7472220607373102d, y: 0.7839584888866225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9484924841351707d, y: 0.8140040995551168d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004209064631362d, y: 0.7481009062357887d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.723033751745105d, y: 0.049022502686591696d), new NpgsqlTypes.NpgsqlPoint(x: 0.2629836894303036d, y: 0.389133824982301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402105255303163d, y: 0.5512469063158493d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9787982171855583d, y: 0.0007236970525186237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794860508236862d, y: 0.7533264229405711d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512605930472563d, y: 0.8671226075780514d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0179610936667558d, y: 0.5720411619778273d), new NpgsqlTypes.NpgsqlPoint(x: 0.2971579277350318d, y: 0.9731283122678134d), new NpgsqlTypes.NpgsqlPoint(x: 0.44049503138956114d, y: 0.3737296497162218d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05557966749184484d, y: 0.5054367127322471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470529080647288d, y: 0.03363454547815947d), new NpgsqlTypes.NpgsqlPoint(x: 0.30428825239661417d, y: 0.6285850391948133d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19250430915204164d, y: 0.254336662169788d), new NpgsqlTypes.NpgsqlPoint(x: 0.4443210744427256d, y: 0.8678772215284547d), new NpgsqlTypes.NpgsqlPoint(x: 0.35248555919454494d, y: 0.1302656867228661d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3369542090095391d, y: 0.11161144754329233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3817721146864307d, y: 0.022708876232809816d), new NpgsqlTypes.NpgsqlPoint(x: 0.21923109950167718d, y: 0.6104593029248512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3697107864659479d, y: 0.9274763449922232d), new NpgsqlTypes.NpgsqlPoint(x: 0.6180658604201821d, y: 0.08293711441714424d), new NpgsqlTypes.NpgsqlPoint(x: 0.49502817864943727d, y: 0.26997564845866373d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46290505805964544d, y: 0.5785214727093411d), new NpgsqlTypes.NpgsqlPoint(x: 0.7440321421595921d, y: 0.07761248384245578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809254313740395d, y: 0.18236756846674596d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6733641702227443d, y: 0.948750259136503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7057430418631296d, y: 0.31674997118393766d), new NpgsqlTypes.NpgsqlPoint(x: 0.10127783818652081d, y: 0.23063382465391336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9812451699579792d, y: 0.2763730879661458d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699198281378237d, y: 0.44182261567353853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367404399376593d, y: 0.6375904723118608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8770796962664202d, y: 0.4175937881746614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833919144897279d, y: 0.5989229721313427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5090871809626235d, y: 0.995822668394547d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6889271778317254d, y: 0.5857375748951723d), new NpgsqlTypes.NpgsqlPoint(x: 0.41798145103325957d, y: 0.5560820494356296d), new NpgsqlTypes.NpgsqlPoint(x: 0.8341900944238644d, y: 0.45157397589003223d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19326486116336772d, y: 0.7703013194240936d), new NpgsqlTypes.NpgsqlPoint(x: 0.2965021491271921d, y: 0.8364529370880475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5060112977641504d, y: 0.13134940983146381d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43357606753786904d, y: 0.5728581693450578d), new NpgsqlTypes.NpgsqlPoint(x: 0.00046409520798229575d, y: 0.5198704523491956d), new NpgsqlTypes.NpgsqlPoint(x: 0.30542329315845185d, y: 0.8468262277856219d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5074158652972659d, y: 0.38384120894224083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6668829421559597d, y: 0.8028807615788934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866600880633331d, y: 0.5262689440122276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.206568674269756d, y: 0.4607986070174579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177435124798391d, y: 0.2566215978343632d), new NpgsqlTypes.NpgsqlPoint(x: 0.3074183279602427d, y: 0.7388782502148071d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5087743231298767d, y: 0.3882471892630499d), new NpgsqlTypes.NpgsqlPoint(x: 0.2277110909199198d, y: 0.905808819707139d), new NpgsqlTypes.NpgsqlPoint(x: 0.0013259475687906752d, y: 0.7819480546893384d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.034888719416493186d, y: 0.7554748433064127d), new NpgsqlTypes.NpgsqlPoint(x: 0.755143573225936d, y: 0.12684970307901344d), new NpgsqlTypes.NpgsqlPoint(x: 0.2767028206591372d, y: 0.5263640616731825d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10345895221018142d, y: 0.44020407481407076d), new NpgsqlTypes.NpgsqlPoint(x: 0.14356690404173356d, y: 0.37766187541707696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319717612280745d, y: 0.6745807818508036d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24036921265636557d, y: 0.12561011191538574d), new NpgsqlTypes.NpgsqlPoint(x: 0.2648500299637352d, y: 0.970388898889765d), new NpgsqlTypes.NpgsqlPoint(x: 0.4492500041984301d, y: 0.15076894505906924d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03168766064434447d, y: 0.39208904596613126d), new NpgsqlTypes.NpgsqlPoint(x: 0.33598379753051866d, y: 0.5061918322631631d), new NpgsqlTypes.NpgsqlPoint(x: 0.13325620485892065d, y: 0.6946458700812584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4102111424285714d, y: 0.8335596080711716d), new NpgsqlTypes.NpgsqlPoint(x: 0.85589479441554d, y: 0.07786353811441571d), new NpgsqlTypes.NpgsqlPoint(x: 0.5508032592232566d, y: 0.9351199238711825d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6602689632090847d, y: 0.08885309783383877d), new NpgsqlTypes.NpgsqlPoint(x: 0.9523137955039482d, y: 0.41424905787526334d), new NpgsqlTypes.NpgsqlPoint(x: 0.44518950050124395d, y: 0.7392224530923763d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7885688143715509d, y: 0.5999841189439733d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266948979798374d, y: 0.923370030719007d), new NpgsqlTypes.NpgsqlPoint(x: 0.6189590918813754d, y: 0.46932585244887537d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6278091791417896d, y: 0.1929296751505648d), new NpgsqlTypes.NpgsqlPoint(x: 0.549126355497847d, y: 0.27424085207529425d), new NpgsqlTypes.NpgsqlPoint(x: 0.4257441837247098d, y: 0.021010110117775427d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6893783449541769d, y: 0.9442244987558596d), new NpgsqlTypes.NpgsqlPoint(x: 0.8750314635657258d, y: 0.737829620504669d), new NpgsqlTypes.NpgsqlPoint(x: 0.08988004695059515d, y: 0.10346571889242151d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47671913727297366d, y: 0.12318578068575636d), new NpgsqlTypes.NpgsqlPoint(x: 0.21308317116168085d, y: 0.9173851104848065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024867000596361d, y: 0.09165390489845604d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06991943510314602d, y: 0.8774234943799868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286791078533058d, y: 0.4940551822883813d), new NpgsqlTypes.NpgsqlPoint(x: 0.486788379958074d, y: 0.6829155876640155d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43398473083560607d, y: 0.6672287377204247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8931806152060981d, y: 0.24612111279083226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058366303936777d, y: 0.13640138952006553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6046772049042822d, y: 0.6850621778305185d), new NpgsqlTypes.NpgsqlPoint(x: 0.07161700029194129d, y: 0.8295424111424159d), new NpgsqlTypes.NpgsqlPoint(x: 0.04901113624333642d, y: 0.4698812153487618d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7290477708244731d, y: 0.19553374539527502d), new NpgsqlTypes.NpgsqlPoint(x: 0.691104975836891d, y: 0.6180750427630434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7244517999354582d, y: 0.6819563628535952d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1062051944923813d, y: 0.2830265656515143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740848494118034d, y: 0.8644262485150139d), new NpgsqlTypes.NpgsqlPoint(x: 0.35838797974257375d, y: 0.943314690258747d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5865072754484015d, y: 0.8059097875847282d), new NpgsqlTypes.NpgsqlPoint(x: 0.34496815288516824d, y: 0.8853396509808407d), new NpgsqlTypes.NpgsqlPoint(x: 0.02014497978156915d, y: 0.038589920702507996d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5511809941409594d, y: 0.24118636277980554d), new NpgsqlTypes.NpgsqlPoint(x: 0.49812294027525805d, y: 0.13333019559812942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5366452130229231d, y: 0.5229835316485657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2972257928091737d, y: 0.6115269036324169d), new NpgsqlTypes.NpgsqlPoint(x: 0.0691419420290057d, y: 0.4439156980796083d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432720865320841d, y: 0.7828391822827685d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7303235506586808d, y: 0.20011015200935622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6207427929388701d, y: 0.7734129286720297d), new NpgsqlTypes.NpgsqlPoint(x: 0.017992086092341486d, y: 0.45680542873615104d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38873287776508114d, y: 0.7937968008372895d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583705910897915d, y: 0.03584051869597116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9565075697362186d, y: 0.7478142297853339d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31511273597347844d, y: 0.8602437506340643d), new NpgsqlTypes.NpgsqlPoint(x: 0.815540570731056d, y: 0.3913148258374005d), new NpgsqlTypes.NpgsqlPoint(x: 0.009019562840760997d, y: 0.5875429067818865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.878143833335933d, y: 0.13471673058265454d), new NpgsqlTypes.NpgsqlPoint(x: 0.250946849356005d, y: 0.03765214132173689d), new NpgsqlTypes.NpgsqlPoint(x: 0.03157348592497611d, y: 0.7340376901856098d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9945230269273054d, y: 0.014512622414328158d), new NpgsqlTypes.NpgsqlPoint(x: 0.7649108177998886d, y: 0.6672559479016628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573544415361088d, y: 0.6182640555552469d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1206464633870945d, y: 0.18367682389182471d), new NpgsqlTypes.NpgsqlPoint(x: 0.38083611263441575d, y: 0.7552041663499486d), new NpgsqlTypes.NpgsqlPoint(x: 0.7348838106626987d, y: 0.34959357467289387d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9787805736181325d, y: 0.7771334305025492d), new NpgsqlTypes.NpgsqlPoint(x: 0.4979886258089967d, y: 0.6542947724211038d), new NpgsqlTypes.NpgsqlPoint(x: 0.33926166439112593d, y: 0.8315005064424705d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8281606044286366d, y: 0.5709305330499269d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374956308090986d, y: 0.5430724670445315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7195391670477547d, y: 0.634439817549157d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9848600732031965d, y: 0.9900648386533936d), new NpgsqlTypes.NpgsqlPoint(x: 0.34851278818010056d, y: 0.8421390516043143d), new NpgsqlTypes.NpgsqlPoint(x: 0.03049674113288514d, y: 0.32944612228126324d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7438220783400096d, y: 0.8107969242189575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9165263770788148d, y: 0.2731328559267827d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550360497658522d, y: 0.05087542080768015d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6194214851698107d, y: 0.9306199981774614d), new NpgsqlTypes.NpgsqlPoint(x: 0.90929889010841d, y: 0.1871126411248184d), new NpgsqlTypes.NpgsqlPoint(x: 0.12925909990885331d, y: 0.7766187706225546d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2589620210208774d, y: 0.8093626542086627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4499941453826869d, y: 0.10167718039062346d), new NpgsqlTypes.NpgsqlPoint(x: 0.03762884386674947d, y: 0.19188614386808722d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6612258281807765d, y: 0.9483008886609098d), new NpgsqlTypes.NpgsqlPoint(x: 0.2683333580031503d, y: 0.7604715879782618d), new NpgsqlTypes.NpgsqlPoint(x: 0.6903667370913559d, y: 0.030037984122334938d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5194246681887601d, y: 0.9064014924352043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9773687544385209d, y: 0.41143322880897726d), new NpgsqlTypes.NpgsqlPoint(x: 0.43805072595041783d, y: 0.018045314325607076d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020409347274430445d, y: 0.13955619158091448d), new NpgsqlTypes.NpgsqlPoint(x: 0.47354194386469795d, y: 0.2520585548967814d), new NpgsqlTypes.NpgsqlPoint(x: 0.23840759197290762d, y: 0.7606663073541453d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4767904103978001d, y: 0.8923550105602591d), new NpgsqlTypes.NpgsqlPoint(x: 0.4383931286111029d, y: 0.8167923373945594d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180609656127541d, y: 0.1318135431410642d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5943631701067565d, y: 0.935621382998774d), new NpgsqlTypes.NpgsqlPoint(x: 0.42972070857607736d, y: 0.379078205921743d), new NpgsqlTypes.NpgsqlPoint(x: 0.24263415741874628d, y: 0.8647382720523894d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1008268497307655d, y: 0.7986454046147672d), new NpgsqlTypes.NpgsqlPoint(x: 0.9152213951234067d, y: 0.06913852652023d), new NpgsqlTypes.NpgsqlPoint(x: 0.12523248815433852d, y: 0.003214681691975696d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12236432384454454d, y: 0.09290198364088709d), new NpgsqlTypes.NpgsqlPoint(x: 0.08233750180148325d, y: 0.4302915250347552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888549494700269d, y: 0.6213833582266516d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7692464004937442d, y: 0.07228103723126256d), new NpgsqlTypes.NpgsqlPoint(x: 0.38889113406176423d, y: 0.7393458595834762d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595608704948243d, y: 0.13405626089506284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8491427408294983d, y: 0.05098024014776614d), new NpgsqlTypes.NpgsqlPoint(x: 0.21348020134637713d, y: 0.6353956942376652d), new NpgsqlTypes.NpgsqlPoint(x: 0.9874254426911107d, y: 0.9570530468805191d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5554387262239138d, y: 0.6338252167851914d), new NpgsqlTypes.NpgsqlPoint(x: 0.2946975904755139d, y: 0.968533513990399d), new NpgsqlTypes.NpgsqlPoint(x: 0.5751286788933212d, y: 0.9091432670746048d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38194832486867336d, y: 0.62004408650085d), new NpgsqlTypes.NpgsqlPoint(x: 0.23753708418507025d, y: 0.8577387708971553d), new NpgsqlTypes.NpgsqlPoint(x: 0.024145994095913115d, y: 0.21141236648652395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6386923550169972d, y: 0.10310112178997843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6693601376918064d, y: 0.9640974272206589d), new NpgsqlTypes.NpgsqlPoint(x: 0.8346145161257751d, y: 0.6968235529182248d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22120100380232854d, y: 0.17070576739010834d), new NpgsqlTypes.NpgsqlPoint(x: 0.22790786996514867d, y: 0.740045532982116d), new NpgsqlTypes.NpgsqlPoint(x: 0.016399366232014767d, y: 0.8638241701221996d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07834774122144983d, y: 0.4652703480263868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7944897350758253d, y: 0.3019879282451092d), new NpgsqlTypes.NpgsqlPoint(x: 0.608855261829976d, y: 0.19152453781306777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8164320717723829d, y: 0.8442255866162758d), new NpgsqlTypes.NpgsqlPoint(x: 0.5027734821415561d, y: 0.8788172114668333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142621128277089d, y: 0.5753387099799515d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2942753405484665d, y: 0.5537744132024167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6409834681155148d, y: 0.9161258064262242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663884530812922d, y: 0.07828836545156681d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8124939338322978d, y: 0.5655684911822928d), new NpgsqlTypes.NpgsqlPoint(x: 0.005310639430540998d, y: 0.09299923983530212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473977588385443d, y: 0.9009025171231702d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3181615250455089d, y: 0.6766482465388731d), new NpgsqlTypes.NpgsqlPoint(x: 0.03855476815474135d, y: 0.6030610470841863d), new NpgsqlTypes.NpgsqlPoint(x: 0.24232465107624246d, y: 0.6312950070669481d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7982122671843989d, y: 0.27147267322997304d), new NpgsqlTypes.NpgsqlPoint(x: 0.08524823244000268d, y: 0.8847346468412163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4217795238147798d, y: 0.6792557858351258d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8563894115377187d, y: 0.32659852792065425d), new NpgsqlTypes.NpgsqlPoint(x: 0.5552865809466742d, y: 0.6186319999669238d), new NpgsqlTypes.NpgsqlPoint(x: 0.7817324507860477d, y: 0.6591311054872934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8767187382373164d, y: 0.5537885696093905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3790708959064857d, y: 0.8235342844943045d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827078315237773d, y: 0.846644953520595d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5213365262279797d, y: 0.7670626865541028d), new NpgsqlTypes.NpgsqlPoint(x: 0.8316873505158991d, y: 0.06580242337919073d), new NpgsqlTypes.NpgsqlPoint(x: 0.08521311524428388d, y: 0.34499777298672096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6701245800437846d, y: 0.8651943273066142d), new NpgsqlTypes.NpgsqlPoint(x: 0.584054272352582d, y: 0.3904578405679192d), new NpgsqlTypes.NpgsqlPoint(x: 0.12020684520141167d, y: 0.5212668553025657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5776478067593506d, y: 0.944108411603553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5780115043075347d, y: 0.7849415626215294d), new NpgsqlTypes.NpgsqlPoint(x: 0.4718722895996662d, y: 0.09137473164463028d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23097053687331037d, y: 0.5717712873184275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372309102372854d, y: 0.385647824458792d), new NpgsqlTypes.NpgsqlPoint(x: 0.2918683364871262d, y: 0.9677473327977579d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38054094410170025d, y: 0.8574465763316393d), new NpgsqlTypes.NpgsqlPoint(x: 0.07831816915356538d, y: 0.7555938651235996d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383809633705999d, y: 0.8161341529775726d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5466942241665903d, y: 0.013035137584013978d), new NpgsqlTypes.NpgsqlPoint(x: 0.17238716166885182d, y: 0.9466229535393137d), new NpgsqlTypes.NpgsqlPoint(x: 0.39720231231233705d, y: 0.65487901030991d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.998959014429236d, y: 0.15196888191342106d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196057172185405d, y: 0.09730798837198984d), new NpgsqlTypes.NpgsqlPoint(x: 0.13698312712533d, y: 0.8394986503540058d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6501894441467935d, y: 0.2267917064505901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687725501093689d, y: 0.7011518191633695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169542434250777d, y: 0.6580708904271515d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9013195548722365d, y: 0.36884876056067906d), new NpgsqlTypes.NpgsqlPoint(x: 0.696725645476527d, y: 0.9887382828310695d), new NpgsqlTypes.NpgsqlPoint(x: 0.3871533905906197d, y: 0.18180587030279538d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8726417831727674d, y: 0.35509487095596626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013604753734964d, y: 0.039680538887642336d), new NpgsqlTypes.NpgsqlPoint(x: 0.39891326244519476d, y: 0.3267859150792135d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1717897740346338d, y: 0.04932711802535139d), new NpgsqlTypes.NpgsqlPoint(x: 0.07836575554808678d, y: 0.524719031118194d), new NpgsqlTypes.NpgsqlPoint(x: 0.24966354456213258d, y: 0.7288736786172946d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5045178137030677d, y: 0.7139702270096063d), new NpgsqlTypes.NpgsqlPoint(x: 0.5113287444413598d, y: 0.8272547937543288d), new NpgsqlTypes.NpgsqlPoint(x: 0.35794235303068667d, y: 0.8596453328861828d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17012515075239132d, y: 0.7729431010765188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9267107846414636d, y: 0.7415387895022065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9174223450801243d, y: 0.8397715473600051d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8516504130561988d, y: 0.29020770688827824d), new NpgsqlTypes.NpgsqlPoint(x: 0.03243746668491365d, y: 0.23356213343197563d), new NpgsqlTypes.NpgsqlPoint(x: 0.1843535128205297d, y: 0.6731147206963666d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048082548045874196d, y: 0.3391466209667654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7028646898032508d, y: 0.17377204667816504d), new NpgsqlTypes.NpgsqlPoint(x: 0.42818791052489935d, y: 0.6439116056139774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6143332254753379d, y: 0.8126977639805475d), new NpgsqlTypes.NpgsqlPoint(x: 0.20492490786376993d, y: 0.5201396112120755d), new NpgsqlTypes.NpgsqlPoint(x: 0.33433875211604447d, y: 0.99327684886467d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4320001549541794d, y: 0.9855499192601682d), new NpgsqlTypes.NpgsqlPoint(x: 0.23111534810955237d, y: 0.034066643917063155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6867763295211533d, y: 0.7963799580609692d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21601624175946355d, y: 0.6231876294024165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367213742658956d, y: 0.11891439024091455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4270429056960061d, y: 0.2984476618389381d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6982219262602082d, y: 0.6003643844959521d), new NpgsqlTypes.NpgsqlPoint(x: 0.4494825224851793d, y: 0.6330717744420981d), new NpgsqlTypes.NpgsqlPoint(x: 0.4773713011404185d, y: 0.11537650400459631d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.657023557261497d, y: 0.7881773825193914d), new NpgsqlTypes.NpgsqlPoint(x: 0.09599475392438783d, y: 0.6971825343958092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699911673636336d, y: 0.47014923966050903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7466949967204516d, y: 0.7834677158454801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5959847255603486d, y: 0.1950664191304986d), new NpgsqlTypes.NpgsqlPoint(x: 0.3290336996979477d, y: 0.22099717668197316d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.701601273794466d, y: 0.995428549122693d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131048382732516d, y: 0.2777694227344014d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092552515402589d, y: 0.861982320695879d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8576383113569614d, y: 0.6025588757467674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477448741538402d, y: 0.669592054662876d), new NpgsqlTypes.NpgsqlPoint(x: 0.115760882941367d, y: 0.4264120723596023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08320998355355524d, y: 0.7607037448076157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573505577388757d, y: 0.1080247230027902d), new NpgsqlTypes.NpgsqlPoint(x: 0.46594688550519525d, y: 0.2633079352960115d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8841364758772344d, y: 0.5350006803677199d), new NpgsqlTypes.NpgsqlPoint(x: 0.5752014700396323d, y: 0.9962438392333187d), new NpgsqlTypes.NpgsqlPoint(x: 0.17975294902835104d, y: 0.04080404326797549d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4154888761038076d, y: 0.5315831602579636d), new NpgsqlTypes.NpgsqlPoint(x: 0.6723078391058176d, y: 0.11203065431858594d), new NpgsqlTypes.NpgsqlPoint(x: 0.09438469234877134d, y: 0.811482298717242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5052290662785639d, y: 0.5467544070971656d), new NpgsqlTypes.NpgsqlPoint(x: 0.1591364056430543d, y: 0.639606624690606d), new NpgsqlTypes.NpgsqlPoint(x: 0.31424916249242263d, y: 0.06617252523052175d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12518736896085092d, y: 0.14447476730434738d), new NpgsqlTypes.NpgsqlPoint(x: 0.11115254202973646d, y: 0.4077857858027977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357265242182216d, y: 0.49764469762655883d)),
}));
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9524543965471618d, y: 0.4793381146081145d), new NpgsqlTypes.NpgsqlPoint(x: 0.3759132313776249d, y: 0.42882517920160423d), new NpgsqlTypes.NpgsqlPoint(x: 0.05440291422391663d, y: 0.34064063104269204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8072773555296721d, y: 0.3976148474574581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936351899536355d, y: 0.42063488073240096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3787159167100915d, y: 0.1685471345493974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8754054631260728d, y: 0.03933458230715192d), new NpgsqlTypes.NpgsqlPoint(x: 0.421168518890649d, y: 0.7318417953295319d), new NpgsqlTypes.NpgsqlPoint(x: 0.2507899939497411d, y: 0.9138684065602135d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30225479802595767d, y: 0.543243263593879d), new NpgsqlTypes.NpgsqlPoint(x: 0.7101462681889388d, y: 0.643271493043018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9580212020514186d, y: 0.8075650019999029d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 29, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 66, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 73, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 13, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 66, query1, 29, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 161, query1, 151, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 127, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 43, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
FROM public.binary_npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI), typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

