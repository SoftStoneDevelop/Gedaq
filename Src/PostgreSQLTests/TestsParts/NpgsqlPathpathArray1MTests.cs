

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6552458789845289d, y: 0.7525232794682207d), new NpgsqlTypes.NpgsqlPoint(x: 0.6817159697861265d, y: 0.0036994104876978406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896745860999802d, y: 0.6788447495848998d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.206154592068035d, y: 0.8459229638140038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617650619443445d, y: 0.09305507509182698d), new NpgsqlTypes.NpgsqlPoint(x: 0.14699491368459916d, y: 0.030475250033826673d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5639582284992437d, y: 0.339586639753643d), new NpgsqlTypes.NpgsqlPoint(x: 0.31645539945787593d, y: 0.4983489318493376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369758108018505d, y: 0.08278535187263958d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8895150857951606d, y: 0.05040137632461206d), new NpgsqlTypes.NpgsqlPoint(x: 0.03131736338607505d, y: 0.7275835545999151d), new NpgsqlTypes.NpgsqlPoint(x: 0.3115993230495445d, y: 0.7678005044514125d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8120102655431748d, y: 0.43377144515814736d), new NpgsqlTypes.NpgsqlPoint(x: 0.03263038216178216d, y: 0.5207384498643659d), new NpgsqlTypes.NpgsqlPoint(x: 0.034778106540963916d, y: 0.7592044464521052d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027533173590631566d, y: 0.5289917318143632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7657335756894076d, y: 0.910145123278345d), new NpgsqlTypes.NpgsqlPoint(x: 0.13201990658268004d, y: 0.8406529687012456d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9533611028682134d, y: 0.01938506586884925d), new NpgsqlTypes.NpgsqlPoint(x: 0.521008557313728d, y: 0.7002676048518416d), new NpgsqlTypes.NpgsqlPoint(x: 0.21217521323013222d, y: 0.2752805466985532d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111539284451726d, y: 0.600151026945175d), new NpgsqlTypes.NpgsqlPoint(x: 0.10653079300032053d, y: 0.24280138642231253d), new NpgsqlTypes.NpgsqlPoint(x: 0.917349741925934d, y: 0.44307397909298474d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46749826699823427d, y: 0.19952015965737435d), new NpgsqlTypes.NpgsqlPoint(x: 0.470231991444397d, y: 0.5181456460638723d), new NpgsqlTypes.NpgsqlPoint(x: 0.2397485198683752d, y: 0.012537254644857998d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37235847806677413d, y: 0.07306636060907656d), new NpgsqlTypes.NpgsqlPoint(x: 0.07112730302507253d, y: 0.4461138162520536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8996356680317418d, y: 0.44460769192548977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4093563802540572d, y: 0.08122523717389873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815511165351378d, y: 0.9203136592574787d), new NpgsqlTypes.NpgsqlPoint(x: 0.20346034400556323d, y: 0.6543301915139647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5537353173483333d, y: 0.987318756940006d), new NpgsqlTypes.NpgsqlPoint(x: 0.364596388995689d, y: 0.5141127430147034d), new NpgsqlTypes.NpgsqlPoint(x: 0.37463335464276726d, y: 0.09377508165490711d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7570726704865239d, y: 0.2974663075217162d), new NpgsqlTypes.NpgsqlPoint(x: 0.08490129750036157d, y: 0.6073884069356585d), new NpgsqlTypes.NpgsqlPoint(x: 0.32412161463561606d, y: 0.529907054842999d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09746696643582087d, y: 0.6782932875601313d), new NpgsqlTypes.NpgsqlPoint(x: 0.12280279022954876d, y: 0.5192246543245872d), new NpgsqlTypes.NpgsqlPoint(x: 0.3641432254338083d, y: 0.7515858610810555d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8011278328522461d, y: 0.6136264661002745d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686013079232121d, y: 0.7259762845727014d), new NpgsqlTypes.NpgsqlPoint(x: 0.46736713103047656d, y: 0.2701334078515004d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8815750076861035d, y: 0.5787394734339446d), new NpgsqlTypes.NpgsqlPoint(x: 0.34377143838440927d, y: 0.3840292284617255d), new NpgsqlTypes.NpgsqlPoint(x: 0.06632001068169768d, y: 0.6763161262956241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.935997739332212d, y: 0.9780806349440948d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774969046800722d, y: 0.07749335776361643d), new NpgsqlTypes.NpgsqlPoint(x: 0.36524728604543544d, y: 0.34195410329934695d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42769137090408693d, y: 0.1546373467342832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8028003231069617d, y: 0.554324465631087d), new NpgsqlTypes.NpgsqlPoint(x: 0.8691988665622861d, y: 0.8658284566200969d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32231589733585275d, y: 0.07871289602076414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393596941116553d, y: 0.6557855444770412d), new NpgsqlTypes.NpgsqlPoint(x: 0.5095174455479224d, y: 0.5700740495233177d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7444930190942446d, y: 0.7105299172710913d), new NpgsqlTypes.NpgsqlPoint(x: 0.12312580465644785d, y: 0.3124359107282494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9512184711767105d, y: 0.833810812945005d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9870226077142484d, y: 0.053262389978347535d), new NpgsqlTypes.NpgsqlPoint(x: 0.5916122921276696d, y: 0.4721635751784339d), new NpgsqlTypes.NpgsqlPoint(x: 0.17671636903723653d, y: 0.2545334883776468d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4039045630285407d, y: 0.16415280858228398d), new NpgsqlTypes.NpgsqlPoint(x: 0.4803547512272942d, y: 0.3221148866725717d), new NpgsqlTypes.NpgsqlPoint(x: 0.02424962751317794d, y: 0.34115982812858103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9894307070012212d, y: 0.863078056581d), new NpgsqlTypes.NpgsqlPoint(x: 0.08580743013795922d, y: 0.27781452296954434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298309067723161d, y: 0.7151939242399938d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2632063129856538d, y: 0.2938279804974271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7573346159232629d, y: 0.3723028937302091d), new NpgsqlTypes.NpgsqlPoint(x: 0.9056875395418436d, y: 0.4736968536235504d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8164618341414847d, y: 0.8405216008798982d), new NpgsqlTypes.NpgsqlPoint(x: 0.184736812245338d, y: 0.6236743398125794d), new NpgsqlTypes.NpgsqlPoint(x: 0.2564732065649623d, y: 0.3639308359841036d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2691584407588614d, y: 0.7560228272710375d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164984198880618d, y: 0.1393434027087067d), new NpgsqlTypes.NpgsqlPoint(x: 0.45416595378756464d, y: 0.5963282012844692d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11565692547285478d, y: 0.1720193887860022d), new NpgsqlTypes.NpgsqlPoint(x: 0.5108264362527005d, y: 0.29574220565305576d), new NpgsqlTypes.NpgsqlPoint(x: 0.8386728955525908d, y: 0.49322033329861836d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5384590602352661d, y: 0.37981793357927895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6330150847216569d, y: 0.9125849086824187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484637344447604d, y: 0.9593183924849449d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3319920064201244d, y: 0.5481294110081674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396281259462761d, y: 0.9560431945295844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989777910356779d, y: 0.21962204445831934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.055719683316092894d, y: 0.019708557481188604d), new NpgsqlTypes.NpgsqlPoint(x: 0.11454632920103935d, y: 0.8398934833571543d), new NpgsqlTypes.NpgsqlPoint(x: 0.3644001479098735d, y: 0.245691358132183d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1694531515333586d, y: 0.3172161831491722d), new NpgsqlTypes.NpgsqlPoint(x: 0.2800325727002301d, y: 0.9124887206265061d), new NpgsqlTypes.NpgsqlPoint(x: 0.6462364445706132d, y: 0.4999514939083234d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37128991144846235d, y: 0.7768730896995166d), new NpgsqlTypes.NpgsqlPoint(x: 0.28158341492221683d, y: 0.6012060466345601d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298210952819653d, y: 0.49515284073120447d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5329427065280093d, y: 0.16722412820141086d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789525518880785d, y: 0.6645159068628845d), new NpgsqlTypes.NpgsqlPoint(x: 0.37330270523741826d, y: 0.8797600305738297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5800729502777155d, y: 0.9997163804615299d), new NpgsqlTypes.NpgsqlPoint(x: 0.3710333001594114d, y: 0.41632579565961103d), new NpgsqlTypes.NpgsqlPoint(x: 0.21765196512734009d, y: 0.5327400046919416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7597410534453901d, y: 0.5259029205911587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076373996178867d, y: 0.6508943475494097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9965413277208455d, y: 0.33296724943478806d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13380945180142634d, y: 0.9038134787720349d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567749510565546d, y: 0.8037097425250066d), new NpgsqlTypes.NpgsqlPoint(x: 0.1910065716631526d, y: 0.5395961594297798d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9096442048950608d, y: 0.24521314064499689d), new NpgsqlTypes.NpgsqlPoint(x: 0.6991127384842175d, y: 0.3494645648815631d), new NpgsqlTypes.NpgsqlPoint(x: 0.5449286271641052d, y: 0.5974570334940694d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4294445453579516d, y: 0.6434846056576834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6176165240583803d, y: 0.3100197286286366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5918739187152204d, y: 0.444893005682682d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18082388456762244d, y: 0.9895545045446342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286189947447949d, y: 0.2031050759314348d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243084164688d, y: 0.9145550182444904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9946639234938931d, y: 0.6199569597237379d), new NpgsqlTypes.NpgsqlPoint(x: 0.0055804211579103535d, y: 0.6406579073988875d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216717847598736d, y: 0.8578495607714154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7968925474791765d, y: 0.26201908429394216d), new NpgsqlTypes.NpgsqlPoint(x: 0.53984409274396d, y: 0.3368569849880112d), new NpgsqlTypes.NpgsqlPoint(x: 0.11851712558908678d, y: 0.7042153003413723d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7438672081201456d, y: 0.9863576865155904d), new NpgsqlTypes.NpgsqlPoint(x: 0.2865959995839744d, y: 0.9684650460062756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080140229521972d, y: 0.15603415627620942d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8399485111657637d, y: 0.3070212631181932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7117535276610929d, y: 0.8131867201110256d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541693685790032d, y: 0.49283892106548177d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010113388739720008d, y: 0.8493732219091491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8231854827585416d, y: 0.14251895527706737d), new NpgsqlTypes.NpgsqlPoint(x: 0.7575284252364848d, y: 0.553672459380096d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2512880368598205d, y: 0.8922322666873646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377046927906868d, y: 0.21162932650541877d), new NpgsqlTypes.NpgsqlPoint(x: 0.6046792833295217d, y: 0.8874154454622064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06573952199946109d, y: 0.5324175605261d), new NpgsqlTypes.NpgsqlPoint(x: 0.6088564085520923d, y: 0.22210837965891872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674850686437037d, y: 0.6268484801093528d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40827398737628817d, y: 0.2146706042801031d), new NpgsqlTypes.NpgsqlPoint(x: 0.7497131631493901d, y: 0.8659543015388355d), new NpgsqlTypes.NpgsqlPoint(x: 0.04089905937288385d, y: 0.46181856026684864d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7877547290396525d, y: 0.5353064011173831d), new NpgsqlTypes.NpgsqlPoint(x: 0.23303341752815798d, y: 0.8650618940920894d), new NpgsqlTypes.NpgsqlPoint(x: 0.8321391408710546d, y: 0.9782779111031905d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5345894156015815d, y: 0.46793598779750223d), new NpgsqlTypes.NpgsqlPoint(x: 0.33992081481572634d, y: 0.15962781493370148d), new NpgsqlTypes.NpgsqlPoint(x: 0.5226591079168235d, y: 0.9660378282221947d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33644140512022847d, y: 0.30922675189886484d), new NpgsqlTypes.NpgsqlPoint(x: 0.1645035328400054d, y: 0.0687299352370011d), new NpgsqlTypes.NpgsqlPoint(x: 0.12683495651954935d, y: 0.4998775783624114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17651046995199537d, y: 0.8653273721764996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9107442703388708d, y: 0.7957605028786923d), new NpgsqlTypes.NpgsqlPoint(x: 0.08276146408433938d, y: 0.07549517790601656d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1486827904430913d, y: 0.9166379121106715d), new NpgsqlTypes.NpgsqlPoint(x: 0.931380994462064d, y: 0.9672998748726424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6731057335965384d, y: 0.09123294160283701d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8133188739614188d, y: 0.6767931849221208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7149964284987249d, y: 0.10841289363571538d), new NpgsqlTypes.NpgsqlPoint(x: 0.24869816412521406d, y: 0.9918544036823389d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48048238683682465d, y: 0.8230207898269624d), new NpgsqlTypes.NpgsqlPoint(x: 0.23457644268815137d, y: 0.2954881884528271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832148253206426d, y: 0.615301070793515d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22523782512713064d, y: 0.6556053530280499d), new NpgsqlTypes.NpgsqlPoint(x: 0.2925498502348751d, y: 0.7623416359980385d), new NpgsqlTypes.NpgsqlPoint(x: 0.5718356024166563d, y: 0.8780022438984789d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7810963699058046d, y: 0.04916218064529587d), new NpgsqlTypes.NpgsqlPoint(x: 0.009124376745636709d, y: 0.01463733967429759d), new NpgsqlTypes.NpgsqlPoint(x: 0.2860634344866556d, y: 0.4929594082877672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11982026097108911d, y: 0.8496611480535704d), new NpgsqlTypes.NpgsqlPoint(x: 0.4185003423780763d, y: 0.7117825141551464d), new NpgsqlTypes.NpgsqlPoint(x: 0.35030072065661566d, y: 0.9648951989052517d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4186213382903827d, y: 0.9543746834160244d), new NpgsqlTypes.NpgsqlPoint(x: 0.31518186510418456d, y: 0.44569754894632574d), new NpgsqlTypes.NpgsqlPoint(x: 0.49154802435507583d, y: 0.5292795762249285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06797175741940265d, y: 0.803641733119315d), new NpgsqlTypes.NpgsqlPoint(x: 0.04580861254574409d, y: 0.8626609099920273d), new NpgsqlTypes.NpgsqlPoint(x: 0.20126475685464207d, y: 0.4462092754748135d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6706291887074817d, y: 0.7117417839927402d), new NpgsqlTypes.NpgsqlPoint(x: 0.8939574512436287d, y: 0.665834790639046d), new NpgsqlTypes.NpgsqlPoint(x: 0.8560108182659568d, y: 0.8489776958695177d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19721651922640882d, y: 0.1531817689871926d), new NpgsqlTypes.NpgsqlPoint(x: 0.5027013944632471d, y: 0.509214387310835d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087496905099377d, y: 0.1114795786756736d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20293817612055454d, y: 0.20995006079655798d), new NpgsqlTypes.NpgsqlPoint(x: 0.21091498978329126d, y: 0.7266821096920101d), new NpgsqlTypes.NpgsqlPoint(x: 0.3344424235747765d, y: 0.1456927661570464d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24661603599548587d, y: 0.0459957981358029d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402296957793245d, y: 0.46712538185337327d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270707704781998d, y: 0.42548883292909434d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6335652993510175d, y: 0.6332524170840769d), new NpgsqlTypes.NpgsqlPoint(x: 0.09365652191004115d, y: 0.5034569273222541d), new NpgsqlTypes.NpgsqlPoint(x: 0.7000668962178012d, y: 0.8186131110787805d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13254541443464263d, y: 0.7042772113287d), new NpgsqlTypes.NpgsqlPoint(x: 0.2502678447132961d, y: 0.776858047235058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6801621819721567d, y: 0.5082765859349223d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2789414149963295d, y: 0.1203484771361728d), new NpgsqlTypes.NpgsqlPoint(x: 0.2798754151217697d, y: 0.3840100799314169d), new NpgsqlTypes.NpgsqlPoint(x: 0.6164578558723408d, y: 0.21575570015383483d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5893979991124833d, y: 0.25105656515216757d), new NpgsqlTypes.NpgsqlPoint(x: 0.14442667874104476d, y: 0.46091808392347344d), new NpgsqlTypes.NpgsqlPoint(x: 0.05066827869161128d, y: 0.8734634275692398d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8938096496424285d, y: 0.6927832306644233d), new NpgsqlTypes.NpgsqlPoint(x: 0.17918991340386015d, y: 0.9328610748097347d), new NpgsqlTypes.NpgsqlPoint(x: 0.18257410154245923d, y: 0.25005723071638597d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8139091695020053d, y: 0.4071772489228702d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132798562241043d, y: 0.8180183804775343d), new NpgsqlTypes.NpgsqlPoint(x: 0.023722795735774405d, y: 0.04526265143910102d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5155348069865897d, y: 0.37767035047424635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958575661894541d, y: 0.8214569453202335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3583042988612375d, y: 0.33299196814600285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7142435662849312d, y: 0.008831771082123963d), new NpgsqlTypes.NpgsqlPoint(x: 0.27368587023907376d, y: 0.30944449377825556d), new NpgsqlTypes.NpgsqlPoint(x: 0.1335767256470063d, y: 0.9032568796246812d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49326657997739254d, y: 0.9365106074850306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853079898314615d, y: 0.12751111838133844d), new NpgsqlTypes.NpgsqlPoint(x: 0.5893571597927575d, y: 0.15235049784812504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9778446704004368d, y: 0.7853079963599358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402175715698567d, y: 0.9761366695653473d), new NpgsqlTypes.NpgsqlPoint(x: 0.23060472724044678d, y: 0.22842633926714573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.776557274366397d, y: 0.486702773451677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601483914113655d, y: 0.0672896303630276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442525484940929d, y: 0.01890684927393893d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8696301161711899d, y: 0.45245578178118484d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693376131769827d, y: 0.5344050075961468d), new NpgsqlTypes.NpgsqlPoint(x: 0.39247122421495184d, y: 0.08074950661011537d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26030667363966253d, y: 0.0661269067964344d), new NpgsqlTypes.NpgsqlPoint(x: 0.4363713820778874d, y: 0.10220882221779048d), new NpgsqlTypes.NpgsqlPoint(x: 0.07475455774370088d, y: 0.5736458322221739d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07529967909770663d, y: 0.5965950070094846d), new NpgsqlTypes.NpgsqlPoint(x: 0.013149482072174257d, y: 0.9289347186937629d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017525588996831765d, y: 0.6478331143191937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2318110851735684d, y: 0.2463436065445067d), new NpgsqlTypes.NpgsqlPoint(x: 0.2685231045232789d, y: 0.9562770925054672d), new NpgsqlTypes.NpgsqlPoint(x: 0.21606253618324966d, y: 0.16807392190975834d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6125124442719045d, y: 0.8882507404057615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209996041719159d, y: 0.49823269959597183d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536579351717191d, y: 0.6375808959665586d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9746446273089433d, y: 0.6267837646031468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574622634098292d, y: 0.9211742126043327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288260039840867d, y: 0.021884889433116395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2342039802967517d, y: 0.1464253944986419d), new NpgsqlTypes.NpgsqlPoint(x: 0.652188110143679d, y: 0.44155746558565945d), new NpgsqlTypes.NpgsqlPoint(x: 0.31535121301770175d, y: 0.49636274087527643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8868870333872974d, y: 0.6969902206854733d), new NpgsqlTypes.NpgsqlPoint(x: 0.010575975087392608d, y: 0.1536868543304587d), new NpgsqlTypes.NpgsqlPoint(x: 0.38727961555290136d, y: 0.3132925097070127d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8794714620656172d, y: 0.11470417972072766d), new NpgsqlTypes.NpgsqlPoint(x: 0.42698350739117286d, y: 0.47773489368682676d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045954872137065d, y: 0.6660643605731251d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3824455102305677d, y: 0.8044135716676271d), new NpgsqlTypes.NpgsqlPoint(x: 0.560744933364586d, y: 0.7302520877586955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5191903278108576d, y: 0.8413567000192498d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8943518290219423d, y: 0.05196733096531214d), new NpgsqlTypes.NpgsqlPoint(x: 0.13555977506735617d, y: 0.1274847733509299d), new NpgsqlTypes.NpgsqlPoint(x: 0.47836987227748284d, y: 0.8223155594917548d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9952270243467628d, y: 0.7188087546497924d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012948620547880152d, y: 0.9966035170580372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166280307322413d, y: 0.37301273225807474d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7796526027932175d, y: 0.5144145124337569d), new NpgsqlTypes.NpgsqlPoint(x: 0.842780561429541d, y: 0.49540365442949597d), new NpgsqlTypes.NpgsqlPoint(x: 0.35555243091647337d, y: 0.11016011501076706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4156322881348796d, y: 0.1592989127116743d), new NpgsqlTypes.NpgsqlPoint(x: 0.2587739696198371d, y: 0.6721533695677842d), new NpgsqlTypes.NpgsqlPoint(x: 0.34548269535829035d, y: 0.2901153006554461d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18463917416061004d, y: 0.9586584881967003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180632119215655d, y: 0.05397396188215908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5738470645758931d, y: 0.643438270254981d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05045217322628559d, y: 0.27060327719261446d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887764270128858d, y: 0.10090036111886935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7660307127627569d, y: 0.48766449634201403d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19685494309970508d, y: 0.2904275312441995d), new NpgsqlTypes.NpgsqlPoint(x: 0.16162235281232362d, y: 0.6059718071161756d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278475030274608d, y: 0.46608623418210804d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6589993892311491d, y: 0.08469489721689694d), new NpgsqlTypes.NpgsqlPoint(x: 0.8294731537434723d, y: 0.7507560403591265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196263235936472d, y: 0.9519963517153017d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7950301102520237d, y: 0.4560067635801335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6054377634715781d, y: 0.1702254578986656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4138898536590079d, y: 0.9553827617601081d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12230900239875409d, y: 0.8930362256049957d), new NpgsqlTypes.NpgsqlPoint(x: 0.33458594340175607d, y: 0.16387216534288374d), new NpgsqlTypes.NpgsqlPoint(x: 0.22265896629434478d, y: 0.17554626885571412d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17597853970667965d, y: 0.23831584325033062d), new NpgsqlTypes.NpgsqlPoint(x: 0.38208036456808814d, y: 0.1442645162507351d), new NpgsqlTypes.NpgsqlPoint(x: 0.47184954215181485d, y: 0.8551630754736648d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21030477376015566d, y: 0.49485587626543215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241598592966239d, y: 0.008494774019980111d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051309709675252d, y: 0.4905363763135321d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6922361221381188d, y: 0.7311052151414384d), new NpgsqlTypes.NpgsqlPoint(x: 0.050853614414899106d, y: 0.8711821620303724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5206113430886417d, y: 0.26475183317718587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5493266001346904d, y: 0.2963147030543295d), new NpgsqlTypes.NpgsqlPoint(x: 0.4421871536166895d, y: 0.9017703871392944d), new NpgsqlTypes.NpgsqlPoint(x: 0.949423714855919d, y: 0.28586823725125476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8501725010533757d, y: 0.03916063918027246d), new NpgsqlTypes.NpgsqlPoint(x: 0.1913922947521629d, y: 0.2685133190720924d), new NpgsqlTypes.NpgsqlPoint(x: 0.006485568333687297d, y: 0.3608034563740413d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17775558797442836d, y: 0.2903692279959269d), new NpgsqlTypes.NpgsqlPoint(x: 0.7264946045909583d, y: 0.9321747186553874d), new NpgsqlTypes.NpgsqlPoint(x: 0.49447677891217856d, y: 0.6518574623031441d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6149671452696894d, y: 0.06865599699879299d), new NpgsqlTypes.NpgsqlPoint(x: 0.26848596257784996d, y: 0.7668732393221066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8598959346612038d, y: 0.43117997512997397d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9174476358761431d, y: 0.3096159394680257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944524540499438d, y: 0.7674545629214391d), new NpgsqlTypes.NpgsqlPoint(x: 0.8846457656297648d, y: 0.5317609492864392d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6748008512140907d, y: 0.8656366794277037d), new NpgsqlTypes.NpgsqlPoint(x: 0.30687168043223534d, y: 0.4416655518182395d), new NpgsqlTypes.NpgsqlPoint(x: 0.02709392244592268d, y: 0.7767485336424165d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.618915697395407d, y: 0.8584670668033823d), new NpgsqlTypes.NpgsqlPoint(x: 0.46789562716909006d, y: 0.977508405275517d), new NpgsqlTypes.NpgsqlPoint(x: 0.8044501797483775d, y: 0.02041476930387187d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46785017319276534d, y: 0.04609720384335736d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411234348190258d, y: 0.05497092141342608d), new NpgsqlTypes.NpgsqlPoint(x: 0.16774555171335126d, y: 0.6125190883237462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44142706359353845d, y: 0.6054977162889839d), new NpgsqlTypes.NpgsqlPoint(x: 0.6064373453135931d, y: 0.6766650415524685d), new NpgsqlTypes.NpgsqlPoint(x: 0.3337260178569621d, y: 0.04785372873107396d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25838812914327147d, y: 0.6162922201422517d), new NpgsqlTypes.NpgsqlPoint(x: 0.1582690817460124d, y: 0.36636441779984197d), new NpgsqlTypes.NpgsqlPoint(x: 0.2911086657009474d, y: 0.49946651452416024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06923700860108828d, y: 0.9021810461072972d), new NpgsqlTypes.NpgsqlPoint(x: 0.9073498840015203d, y: 0.6402489100455165d), new NpgsqlTypes.NpgsqlPoint(x: 0.3819239204984879d, y: 0.41502817819394067d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.437246876029035d, y: 0.7597472549387736d), new NpgsqlTypes.NpgsqlPoint(x: 0.7932991117375175d, y: 0.45163923586075194d), new NpgsqlTypes.NpgsqlPoint(x: 0.005729353927922287d, y: 0.20356826967904074d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6037210307173473d, y: 0.14777168540207242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4599229736100704d, y: 0.24389443846901038d), new NpgsqlTypes.NpgsqlPoint(x: 0.17820588249558722d, y: 0.705732834524127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.527123869127835d, y: 0.9348466953145367d), new NpgsqlTypes.NpgsqlPoint(x: 0.28172870668999395d, y: 0.28579862244881327d), new NpgsqlTypes.NpgsqlPoint(x: 0.04276267249373078d, y: 0.5622021187936308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47058619308945226d, y: 0.4261994326360071d), new NpgsqlTypes.NpgsqlPoint(x: 0.3267206133700714d, y: 0.4427980958458092d), new NpgsqlTypes.NpgsqlPoint(x: 0.35128525437396474d, y: 0.26744920520110627d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.258963668262727d, y: 0.4558019466905826d), new NpgsqlTypes.NpgsqlPoint(x: 0.33491629641550735d, y: 0.12362502995238722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8011115577108184d, y: 0.7976235378983717d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9333046824267018d, y: 0.35575988458250996d), new NpgsqlTypes.NpgsqlPoint(x: 0.42703009277236736d, y: 0.8245960192053331d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032938104539801d, y: 0.7993319847196663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34464866048790355d, y: 0.5176524084864591d), new NpgsqlTypes.NpgsqlPoint(x: 0.21118632924579472d, y: 0.14997103266973266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9119963179992039d, y: 0.011893128063826253d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7864001898667197d, y: 0.06698674693735351d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863354825844634d, y: 0.28521617442076797d), new NpgsqlTypes.NpgsqlPoint(x: 0.03499605366719072d, y: 0.27836053301160213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014103925545690621d, y: 0.7704950039939545d), new NpgsqlTypes.NpgsqlPoint(x: 0.34329811589646864d, y: 0.1818681605818575d), new NpgsqlTypes.NpgsqlPoint(x: 0.05297416468229699d, y: 0.3772199391463703d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025429492476264137d, y: 0.0059034092124370385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8284480496152713d, y: 0.4737915907683051d), new NpgsqlTypes.NpgsqlPoint(x: 0.3706448209190799d, y: 0.2975569525119217d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43017164230849847d, y: 0.9189608721520223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442122572055863d, y: 0.054547522866559284d), new NpgsqlTypes.NpgsqlPoint(x: 0.027642647447087443d, y: 0.18375847397612954d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23939672084086394d, y: 0.34749749824255727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9921996730551687d, y: 0.5288665290098117d), new NpgsqlTypes.NpgsqlPoint(x: 0.15526377771898037d, y: 0.36946158859906253d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8139568028594237d, y: 0.6523863934201363d), new NpgsqlTypes.NpgsqlPoint(x: 0.5453257831266626d, y: 0.11386782329602574d), new NpgsqlTypes.NpgsqlPoint(x: 0.6801108698237845d, y: 0.14833395907073066d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6705604027436959d, y: 0.367228455971497d), new NpgsqlTypes.NpgsqlPoint(x: 0.3447048177159193d, y: 0.5548565942505801d), new NpgsqlTypes.NpgsqlPoint(x: 0.01983386791551167d, y: 0.18094896346392741d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5462896301388868d, y: 0.835241560162223d), new NpgsqlTypes.NpgsqlPoint(x: 0.34699604356071123d, y: 0.6077041314490862d), new NpgsqlTypes.NpgsqlPoint(x: 0.22973399385977689d, y: 0.2525141106695932d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2289758879418713d, y: 0.07599121166463174d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617642691507308d, y: 0.3650200975555866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810912245691956d, y: 0.0504243426597174d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09490648328178342d, y: 0.04313881970685274d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331927265685002d, y: 0.9326667683922427d), new NpgsqlTypes.NpgsqlPoint(x: 0.048700920411156035d, y: 0.03448070079721166d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43620892462010197d, y: 0.3952585488538335d), new NpgsqlTypes.NpgsqlPoint(x: 0.009299910899108199d, y: 0.5787844574859107d), new NpgsqlTypes.NpgsqlPoint(x: 0.07837957720589517d, y: 0.9841465109604456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9464541471546898d, y: 0.45847285400205673d), new NpgsqlTypes.NpgsqlPoint(x: 0.10672866108320023d, y: 0.3147671278072681d), new NpgsqlTypes.NpgsqlPoint(x: 0.4940400210782935d, y: 0.2598684260041981d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30829235963383406d, y: 0.9156679462339012d), new NpgsqlTypes.NpgsqlPoint(x: 0.3632532697257934d, y: 0.8535755701009111d), new NpgsqlTypes.NpgsqlPoint(x: 0.23596242772050535d, y: 0.3092027965606835d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4621438936519944d, y: 0.41591759539859685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4702199063049127d, y: 0.5151652421327929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9618837564282269d, y: 0.8386002794507715d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0690565225264721d, y: 0.27266192756935836d), new NpgsqlTypes.NpgsqlPoint(x: 0.07068531477227347d, y: 0.6409183942225881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622499924118309d, y: 0.9356578115420414d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9572466944129913d, y: 0.8255293754846276d), new NpgsqlTypes.NpgsqlPoint(x: 0.3807247476428184d, y: 0.03753397541202874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456060463639688d, y: 0.5917163224927633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9945883860381152d, y: 0.24199261253714055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7199529317454627d, y: 0.006642194916731459d), new NpgsqlTypes.NpgsqlPoint(x: 0.1920997190837611d, y: 0.4125348390918415d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9241647071620444d, y: 0.9686245359949949d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823603479779869d, y: 0.22873189867412058d), new NpgsqlTypes.NpgsqlPoint(x: 0.2911775870793253d, y: 0.5338320606957521d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38461783043696673d, y: 0.5951340061278017d), new NpgsqlTypes.NpgsqlPoint(x: 0.591444606704499d, y: 0.9452161458225997d), new NpgsqlTypes.NpgsqlPoint(x: 0.22851098731917463d, y: 0.10883160601617947d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3038472523192104d, y: 0.5683815151312109d), new NpgsqlTypes.NpgsqlPoint(x: 0.2657817978696454d, y: 0.4025864296648759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840473982511583d, y: 0.5546503932677279d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8450727267147083d, y: 0.409028289467675d), new NpgsqlTypes.NpgsqlPoint(x: 0.20985117589454716d, y: 0.2569281767186128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761112437610381d, y: 0.6449411679468221d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49452893484717975d, y: 0.9026550075783655d), new NpgsqlTypes.NpgsqlPoint(x: 0.31163846485506397d, y: 0.11943573175528222d), new NpgsqlTypes.NpgsqlPoint(x: 0.5366616190250735d, y: 0.49794070484942665d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05167235082866761d, y: 0.3134361173429715d), new NpgsqlTypes.NpgsqlPoint(x: 0.11658995709526476d, y: 0.9389333418478267d), new NpgsqlTypes.NpgsqlPoint(x: 0.40790498757380955d, y: 0.9937569546861005d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22153914364131277d, y: 0.368907034994867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6550945065191308d, y: 0.6027530107640919d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670038688503138d, y: 0.33005127848126836d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4794072327124629d, y: 0.6082002423327394d), new NpgsqlTypes.NpgsqlPoint(x: 0.9145565581686672d, y: 0.5557220852129071d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205028759846326d, y: 0.6844676977604246d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006718660535649512d, y: 0.9258761705964234d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642794930331373d, y: 0.3110788842931257d), new NpgsqlTypes.NpgsqlPoint(x: 0.39533888531467876d, y: 0.072267440189277d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5138751546988367d, y: 0.10758644658960836d), new NpgsqlTypes.NpgsqlPoint(x: 0.8784919631188255d, y: 0.9038643646598322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9981144532625635d, y: 0.3030954582877492d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.754022733633905d, y: 0.9619398997854267d), new NpgsqlTypes.NpgsqlPoint(x: 0.555195184680546d, y: 0.8805253972741255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5970308815444801d, y: 0.7094429947146795d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42823882435097493d, y: 0.4318100977571474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8063311619183048d, y: 0.9218898461821285d), new NpgsqlTypes.NpgsqlPoint(x: 0.5838471250638176d, y: 0.0428040787356333d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9083142655473613d, y: 0.9756646103305184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3019761024923595d, y: 0.31655846073850713d), new NpgsqlTypes.NpgsqlPoint(x: 0.37352140030763703d, y: 0.7878571508638819d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9474108538694719d, y: 0.5340429671623356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8785070890484122d, y: 0.23868574767671047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820753071999546d, y: 0.6748227062056704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19834208517678098d, y: 0.5831815475424736d), new NpgsqlTypes.NpgsqlPoint(x: 0.3990636248735705d, y: 0.0645010409133242d), new NpgsqlTypes.NpgsqlPoint(x: 0.38841227129149125d, y: 0.3748445213686219d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1900389733454294d, y: 0.6167742032172068d), new NpgsqlTypes.NpgsqlPoint(x: 0.35922578167089037d, y: 0.8197391057559085d), new NpgsqlTypes.NpgsqlPoint(x: 0.011987038630969393d, y: 0.3790085848284608d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1431896710233972d, y: 0.004900831032697228d), new NpgsqlTypes.NpgsqlPoint(x: 0.7174231197943206d, y: 0.32864573717586176d), new NpgsqlTypes.NpgsqlPoint(x: 0.15036530375792945d, y: 0.6154499954699895d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12405530627982808d, y: 0.8859589361791286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9562648173882828d, y: 0.28490494341593287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882815290061141d, y: 0.619103482182865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0774569336940677d, y: 0.9459565146347463d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388931087937807d, y: 0.2927143828190102d), new NpgsqlTypes.NpgsqlPoint(x: 0.15004892344360188d, y: 0.35096368853796267d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5684359015990037d, y: 0.22788080661698384d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479694974334516d, y: 0.6351527980815632d), new NpgsqlTypes.NpgsqlPoint(x: 0.4836279395331924d, y: 0.3550173455908595d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9002218620036617d, y: 0.056772530311555824d), new NpgsqlTypes.NpgsqlPoint(x: 0.12448549171353329d, y: 0.4439459499198586d), new NpgsqlTypes.NpgsqlPoint(x: 0.595321788444575d, y: 0.26034320603752603d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03159547638030513d, y: 0.7866919057252395d), new NpgsqlTypes.NpgsqlPoint(x: 0.22591407693223864d, y: 0.9373843912787756d), new NpgsqlTypes.NpgsqlPoint(x: 0.8049230469415988d, y: 0.20857365037365616d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2610331025442003d, y: 0.3549701392561978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9415373363516336d, y: 0.2637306460589728d), new NpgsqlTypes.NpgsqlPoint(x: 0.08038352147489414d, y: 0.32405506275509943d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09843823575016797d, y: 0.8708954795029581d), new NpgsqlTypes.NpgsqlPoint(x: 0.643175516909845d, y: 0.7183056283968483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179030941498114d, y: 0.26048937034608766d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723168185747211d, y: 0.32510124317451117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060699249042166d, y: 0.5344057907160992d), new NpgsqlTypes.NpgsqlPoint(x: 0.10220842323701584d, y: 0.35390439607393487d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4977524329798879d, y: 0.11940104103003468d), new NpgsqlTypes.NpgsqlPoint(x: 0.7419521529394828d, y: 0.8650313035269543d), new NpgsqlTypes.NpgsqlPoint(x: 0.4000790032963033d, y: 0.6204998405033273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39127284623608505d, y: 0.9265497110526619d), new NpgsqlTypes.NpgsqlPoint(x: 0.5637099500662855d, y: 0.3006447508188501d), new NpgsqlTypes.NpgsqlPoint(x: 0.13105460390928192d, y: 0.6518331311737027d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8578244990089517d, y: 0.5049060846338678d), new NpgsqlTypes.NpgsqlPoint(x: 0.6444336297850991d, y: 0.5410411313662873d), new NpgsqlTypes.NpgsqlPoint(x: 0.18344507305987334d, y: 0.7181462286384325d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9073551548576799d, y: 0.1102715343022046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6642052779535078d, y: 0.9023813490639941d), new NpgsqlTypes.NpgsqlPoint(x: 0.31704826653156026d, y: 0.9370067430225762d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7370020215542517d, y: 0.5332349110647253d), new NpgsqlTypes.NpgsqlPoint(x: 0.7028249255106075d, y: 0.46720588754768866d), new NpgsqlTypes.NpgsqlPoint(x: 0.764029790847655d, y: 0.10151715735512468d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41202517357587365d, y: 0.10369938215828467d), new NpgsqlTypes.NpgsqlPoint(x: 0.22282513914201774d, y: 0.6466799067306895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9749531196866849d, y: 0.259336127153864d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8654566567738929d, y: 0.7748057846606087d), new NpgsqlTypes.NpgsqlPoint(x: 0.37909314415898365d, y: 0.6539190800196051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7317770464516292d, y: 0.30193875994168906d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7437348768317976d, y: 0.4406098587408456d), new NpgsqlTypes.NpgsqlPoint(x: 0.8719966908916544d, y: 0.9601223004051217d), new NpgsqlTypes.NpgsqlPoint(x: 0.754000768571823d, y: 0.21530292774002124d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6284040127846932d, y: 0.6992519826269029d), new NpgsqlTypes.NpgsqlPoint(x: 0.5683470852946473d, y: 0.6182153331782178d), new NpgsqlTypes.NpgsqlPoint(x: 0.18052250659404556d, y: 0.34037324422987114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0026399062364743653d, y: 0.055135535887855025d), new NpgsqlTypes.NpgsqlPoint(x: 0.08369998156855762d, y: 0.4631441197432936d), new NpgsqlTypes.NpgsqlPoint(x: 0.14741247412254543d, y: 0.5527314577359447d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26655837651695913d, y: 0.2577314249820398d), new NpgsqlTypes.NpgsqlPoint(x: 0.4377808598238915d, y: 0.44899178597254763d), new NpgsqlTypes.NpgsqlPoint(x: 0.1099040562750998d, y: 0.249560385085152d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6702406757567831d, y: 0.5773501370281877d), new NpgsqlTypes.NpgsqlPoint(x: 0.003743065477845753d, y: 0.3860840174187341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5152494835921926d, y: 0.7370125020254393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21535700183338347d, y: 0.5080430311491559d), new NpgsqlTypes.NpgsqlPoint(x: 0.04244583667095203d, y: 0.4690855206211765d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141981182785453d, y: 0.8284337818875838d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8357018495239599d, y: 0.6883597659656654d), new NpgsqlTypes.NpgsqlPoint(x: 0.1956256698224269d, y: 0.5626490371080368d), new NpgsqlTypes.NpgsqlPoint(x: 0.3683487600907338d, y: 0.03876614019325997d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3868530615930885d, y: 0.784149927121102d), new NpgsqlTypes.NpgsqlPoint(x: 0.42336057030867846d, y: 0.6717161845107283d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103227652726384d, y: 0.5971615057753329d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7123982623686227d, y: 0.2827987966381732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4760126393645213d, y: 0.7333351775551216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7858869509613197d, y: 0.5592382315683486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28299989835980854d, y: 0.18174923000738852d), new NpgsqlTypes.NpgsqlPoint(x: 0.6172902530435547d, y: 0.7515987498950282d), new NpgsqlTypes.NpgsqlPoint(x: 0.18470807218139795d, y: 0.33623656520029555d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24037503182093733d, y: 0.7904693113739361d), new NpgsqlTypes.NpgsqlPoint(x: 0.3732960931136926d, y: 0.08291286165216305d), new NpgsqlTypes.NpgsqlPoint(x: 0.4314441572714338d, y: 0.8773766940921587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15559266818358608d, y: 0.20582780363009867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3258225309740712d, y: 0.3983827477765445d), new NpgsqlTypes.NpgsqlPoint(x: 0.19922506488141922d, y: 0.3053946402586416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5451141049448556d, y: 0.2947816784807765d), new NpgsqlTypes.NpgsqlPoint(x: 0.17226935885689365d, y: 0.9766680288716101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820072550093438d, y: 0.7061712572952327d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8884541878367422d, y: 0.5202851472086406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5332452712544232d, y: 0.9345616994651076d), new NpgsqlTypes.NpgsqlPoint(x: 0.8289949831999319d, y: 0.7022070143189194d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5102324279196383d, y: 0.5453013020994214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400631099331546d, y: 0.08993384778750635d), new NpgsqlTypes.NpgsqlPoint(x: 0.4596730423755576d, y: 0.3931397566462689d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35589812506655305d, y: 0.24533806250329115d), new NpgsqlTypes.NpgsqlPoint(x: 0.17258588297134236d, y: 0.13616657824713274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5111796832717156d, y: 0.4163187147430888d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14558793705026019d, y: 0.24033950139282012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093674685249904d, y: 0.7655736025846952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9096582238437237d, y: 0.9803120071694537d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19488695611460094d, y: 0.5091379183512238d), new NpgsqlTypes.NpgsqlPoint(x: 0.19670828953940622d, y: 0.45081458384182094d), new NpgsqlTypes.NpgsqlPoint(x: 0.695626617213308d, y: 0.803087096014897d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36470818108380443d, y: 0.9814838489601745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8109991025180827d, y: 0.7851697778848868d), new NpgsqlTypes.NpgsqlPoint(x: 0.13036787503665426d, y: 0.7575795169832436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27682084817676156d, y: 0.29767605709758527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734848043766395d, y: 0.8559242928577386d), new NpgsqlTypes.NpgsqlPoint(x: 0.10096449463216384d, y: 0.28109706818054314d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6168142072168296d, y: 0.5276253905239455d), new NpgsqlTypes.NpgsqlPoint(x: 0.3670891893100635d, y: 0.13340704221199673d), new NpgsqlTypes.NpgsqlPoint(x: 0.24700928218209983d, y: 0.8358665660235948d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39718772711474615d, y: 0.5223098450927769d), new NpgsqlTypes.NpgsqlPoint(x: 0.7557233479769597d, y: 0.5448415223880414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4743106286943295d, y: 0.6869708924090315d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38540854830662985d, y: 0.2607664719843993d), new NpgsqlTypes.NpgsqlPoint(x: 0.4871828768784511d, y: 0.3973526855812526d), new NpgsqlTypes.NpgsqlPoint(x: 0.1528196041906169d, y: 0.5718521164534859d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30457071325598073d, y: 0.8149148287128277d), new NpgsqlTypes.NpgsqlPoint(x: 0.32059496457743564d, y: 0.5038044390516241d), new NpgsqlTypes.NpgsqlPoint(x: 0.12379755290799743d, y: 0.12479415394562121d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5484134572535241d, y: 0.12030373112928938d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017567556390875039d, y: 0.2690271803073785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7821425249044079d, y: 0.9977767744437229d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38110445829057316d, y: 0.9742326180132962d), new NpgsqlTypes.NpgsqlPoint(x: 0.05520524391601178d, y: 0.9011790331974842d), new NpgsqlTypes.NpgsqlPoint(x: 0.23556536775699488d, y: 0.031209170482972448d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0294403321228639d, y: 0.3275617454289804d), new NpgsqlTypes.NpgsqlPoint(x: 0.7828583527371461d, y: 0.6524998527807646d), new NpgsqlTypes.NpgsqlPoint(x: 0.4718585828447195d, y: 0.21707531754115073d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8640470753389363d, y: 0.828768387387474d), new NpgsqlTypes.NpgsqlPoint(x: 0.2714651485470292d, y: 0.9441857043800841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459012835168095d, y: 0.34950966855099086d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3341455501998287d, y: 0.2312346022604569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6295788502619689d, y: 0.0024986393761878833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309750455181723d, y: 0.48567326280200374d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4834948685535967d, y: 0.8258711168392449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537595920146895d, y: 0.2797061667908527d), new NpgsqlTypes.NpgsqlPoint(x: 0.535330061082936d, y: 0.637632091447428d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8989668651780092d, y: 0.7312990978534855d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824337037855204d, y: 0.31974724869064797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7710840519816787d, y: 0.46135145742859607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.284952967446622d, y: 0.003426471345683857d), new NpgsqlTypes.NpgsqlPoint(x: 0.6038172901955935d, y: 0.6589736095093824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9995894529626265d, y: 0.03916680137822948d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9745410885664901d, y: 0.3041125554969679d), new NpgsqlTypes.NpgsqlPoint(x: 0.07701098934405792d, y: 0.9548869795612822d), new NpgsqlTypes.NpgsqlPoint(x: 0.8427549795262501d, y: 0.9104831221151257d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9867449043801912d, y: 0.16988023740094504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5230333039646802d, y: 0.2378363804826199d), new NpgsqlTypes.NpgsqlPoint(x: 0.7451343153996621d, y: 0.4858351511698278d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16043537370900907d, y: 0.781659439616127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450898044262134d, y: 0.43645350506468117d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686774295496881d, y: 0.5519615569490705d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17794219151284174d, y: 0.463328591525193d), new NpgsqlTypes.NpgsqlPoint(x: 0.4272474228994039d, y: 0.04866280356410302d), new NpgsqlTypes.NpgsqlPoint(x: 0.34894614635380583d, y: 0.10989725716037091d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12737623220302552d, y: 0.15610629974783807d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739984071681958d, y: 0.36558269735999505d), new NpgsqlTypes.NpgsqlPoint(x: 0.12195573705534846d, y: 0.057126179618196105d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3958739922203841d, y: 0.7829780605476079d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838961195341002d, y: 0.34081129883123695d), new NpgsqlTypes.NpgsqlPoint(x: 0.41235117986668723d, y: 0.7417153961291503d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3968486941061671d, y: 0.18953468560571052d), new NpgsqlTypes.NpgsqlPoint(x: 0.03542642631917603d, y: 0.48589801415943257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095681513884939d, y: 0.21484254778457923d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0559802873643539d, y: 0.487079654310426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8870592835362769d, y: 0.31173726586844064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882217900812597d, y: 0.015560746779695656d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.403114553950389d, y: 0.18941999869041648d), new NpgsqlTypes.NpgsqlPoint(x: 0.34477284212643267d, y: 0.7226659403022379d), new NpgsqlTypes.NpgsqlPoint(x: 0.57152010467671d, y: 0.4924936237191462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18814301221862229d, y: 0.510161198511132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180501609266221d, y: 0.3511401136571649d), new NpgsqlTypes.NpgsqlPoint(x: 0.0927840831447746d, y: 0.19124588994624436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3276621381297997d, y: 0.09399280769885476d), new NpgsqlTypes.NpgsqlPoint(x: 0.8893882315094909d, y: 0.32045096032239584d), new NpgsqlTypes.NpgsqlPoint(x: 0.46068007665966804d, y: 0.4701181263990001d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9066466244049649d, y: 0.12237476282434867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005064219301671d, y: 0.061090284086511404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7617837244467724d, y: 0.27354389639838783d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7248429719830493d, y: 0.8562727987889788d), new NpgsqlTypes.NpgsqlPoint(x: 0.1855615367635024d, y: 0.18748201616618387d), new NpgsqlTypes.NpgsqlPoint(x: 0.6458547167543678d, y: 0.922122443002154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3735960360732955d, y: 0.044195976300932416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445646356030354d, y: 0.5485029473871827d), new NpgsqlTypes.NpgsqlPoint(x: 0.23411115246601022d, y: 0.45509558948448947d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6164080136679119d, y: 0.6649090707216623d), new NpgsqlTypes.NpgsqlPoint(x: 0.8682721655052055d, y: 0.39985700700820237d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593013803257221d, y: 0.8675283927413391d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6313860183885889d, y: 0.2154053637023433d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126764226176781d, y: 0.40559269642427764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940776171095187d, y: 0.18531213717075556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8221498273501514d, y: 0.35291870122430824d), new NpgsqlTypes.NpgsqlPoint(x: 0.3038028112264928d, y: 0.7411661281916402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002481278671981d, y: 0.9440237579453893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47752081436975236d, y: 0.5655177586810646d), new NpgsqlTypes.NpgsqlPoint(x: 0.25611879727150644d, y: 0.295623777569881d), new NpgsqlTypes.NpgsqlPoint(x: 0.8876410501662815d, y: 0.13346905854560376d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5322165045022036d, y: 0.22808167410306945d), new NpgsqlTypes.NpgsqlPoint(x: 0.3522312493667792d, y: 0.9739608894247128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9908677819709037d, y: 0.6817634611426905d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5401555074087467d, y: 0.07145458458376164d), new NpgsqlTypes.NpgsqlPoint(x: 0.4664690389228555d, y: 0.474339175551333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5663578770378714d, y: 0.2484035296536784d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2548850433489006d, y: 0.5165943258584521d), new NpgsqlTypes.NpgsqlPoint(x: 0.6133847220576522d, y: 6.9915538772225E-05d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248687288624095d, y: 0.7638875097753063d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5592218135511186d, y: 0.34477179681855297d), new NpgsqlTypes.NpgsqlPoint(x: 0.4305551843545039d, y: 0.31689961411738965d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180802396547756d, y: 0.35534275006591254d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03143925046166107d, y: 0.6748744435898582d), new NpgsqlTypes.NpgsqlPoint(x: 0.06673659379121666d, y: 0.9202847601391667d), new NpgsqlTypes.NpgsqlPoint(x: 0.2203150758666813d, y: 0.749455525422336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48272038205176004d, y: 0.518491133920274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5175456207465493d, y: 0.06191390301695876d), new NpgsqlTypes.NpgsqlPoint(x: 0.08880022452765546d, y: 0.20509004175039847d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5509294846204242d, y: 0.814106201097109d), new NpgsqlTypes.NpgsqlPoint(x: 0.2350711539804473d, y: 0.7138559803379239d), new NpgsqlTypes.NpgsqlPoint(x: 0.003583642066060211d, y: 0.9267513310411997d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1832647562547689d, y: 0.7601230794478728d), new NpgsqlTypes.NpgsqlPoint(x: 0.75362521174457d, y: 0.8530463038809719d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122615113825033d, y: 0.6350067431673718d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5976682735542972d, y: 0.6993086673997227d), new NpgsqlTypes.NpgsqlPoint(x: 0.43343335945107153d, y: 0.6229682304508731d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920844956913592d, y: 0.8207094796639216d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6477740162871206d, y: 0.008805440937280307d), new NpgsqlTypes.NpgsqlPoint(x: 0.35758058083265243d, y: 0.5608238799487262d), new NpgsqlTypes.NpgsqlPoint(x: 0.17238851692296842d, y: 0.7548177897835d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19478468578351682d, y: 0.55933091832176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928868900477693d, y: 0.7388418617983582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6574073551018781d, y: 0.21849933550794376d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7537625426133195d, y: 0.7655266436362798d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236095449357896d, y: 0.5111737803935232d), new NpgsqlTypes.NpgsqlPoint(x: 0.665834283058838d, y: 0.814240446646279d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8329788222356102d, y: 0.6748104019063209d), new NpgsqlTypes.NpgsqlPoint(x: 0.31920482801435923d, y: 0.3151880634837676d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618734085476808d, y: 0.982034452182334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2652746604575664d, y: 0.5614916424114387d), new NpgsqlTypes.NpgsqlPoint(x: 0.18214803173054628d, y: 0.9642474506262879d), new NpgsqlTypes.NpgsqlPoint(x: 0.37510013732809566d, y: 0.32603356480662815d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7624726859732005d, y: 0.6308628772357903d), new NpgsqlTypes.NpgsqlPoint(x: 0.44789232837425674d, y: 0.7454324167722767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083367305512282d, y: 0.9701339200529225d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7309378043079546d, y: 0.7127694327117546d), new NpgsqlTypes.NpgsqlPoint(x: 0.923123563055578d, y: 0.8622037447444154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426962769628333d, y: 0.9524467653514942d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006498489618082193d, y: 0.9317249595529268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816280792005255d, y: 0.2509308348099156d), new NpgsqlTypes.NpgsqlPoint(x: 0.05710149848115942d, y: 0.46334173653267485d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6602252512684107d, y: 0.39155166961112964d), new NpgsqlTypes.NpgsqlPoint(x: 0.2760734853611235d, y: 0.2337207479624075d), new NpgsqlTypes.NpgsqlPoint(x: 0.06695393586348464d, y: 0.9958796585728653d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8096344870841726d, y: 0.44516550504599095d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510154855115404d, y: 0.6906558470794454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3360098531994141d, y: 0.7398881795885289d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42788488626456433d, y: 0.49484390186619165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142614232573951d, y: 0.07497211355939626d), new NpgsqlTypes.NpgsqlPoint(x: 0.4688016166852679d, y: 0.5415487091852518d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5762362572253589d, y: 0.9044549766160136d), new NpgsqlTypes.NpgsqlPoint(x: 0.373666093153879d, y: 0.18938214952504906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7735785067069115d, y: 0.5869914085059035d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2141432413242137d, y: 0.4124697357649153d), new NpgsqlTypes.NpgsqlPoint(x: 0.452252686774968d, y: 0.16446117531417437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7683564884554035d, y: 0.9378328425432496d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.448233288068538d, y: 0.06461235294634748d), new NpgsqlTypes.NpgsqlPoint(x: 0.5188910909477019d, y: 0.8154492891276455d), new NpgsqlTypes.NpgsqlPoint(x: 0.14405294885052655d, y: 0.16765398345466698d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19053205213884983d, y: 0.14024019669232768d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141847435462947d, y: 0.11076307240261996d), new NpgsqlTypes.NpgsqlPoint(x: 0.1719134085459918d, y: 0.14377465472038276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15808184046375107d, y: 0.18500074440443137d), new NpgsqlTypes.NpgsqlPoint(x: 0.32093127017831924d, y: 0.1953616519143252d), new NpgsqlTypes.NpgsqlPoint(x: 0.5545015737124411d, y: 0.19728199574065297d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09849811134889153d, y: 0.6660331026737282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9098184718073471d, y: 0.6267533029305036d), new NpgsqlTypes.NpgsqlPoint(x: 0.36425073257767926d, y: 0.003882191660066203d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5902536212624108d, y: 0.35738035139462876d), new NpgsqlTypes.NpgsqlPoint(x: 0.2127626009857383d, y: 0.31684724074044324d), new NpgsqlTypes.NpgsqlPoint(x: 0.44887061471866707d, y: 0.08641027040851723d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16958874270903923d, y: 0.16619074484634078d), new NpgsqlTypes.NpgsqlPoint(x: 0.4110437058777048d, y: 0.15641767376038784d), new NpgsqlTypes.NpgsqlPoint(x: 0.7785198961681384d, y: 0.8998661191792527d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9511915269798027d, y: 0.6062287913706129d), new NpgsqlTypes.NpgsqlPoint(x: 0.13180621609620613d, y: 0.8581158827273474d), new NpgsqlTypes.NpgsqlPoint(x: 0.40883710287754316d, y: 0.7510948958351451d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5270290804053217d, y: 0.1413841024671323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7058022369366147d, y: 0.10608853681367103d), new NpgsqlTypes.NpgsqlPoint(x: 0.010562600649787868d, y: 0.2362914947993161d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2932247495031842d, y: 0.9429784509737993d), new NpgsqlTypes.NpgsqlPoint(x: 0.0663611135108807d, y: 0.7724049684769638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8933884722034096d, y: 0.9808908948768545d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08664089539175768d, y: 0.11127217914454224d), new NpgsqlTypes.NpgsqlPoint(x: 0.21887246094108803d, y: 0.7785976069394189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8525331591497359d, y: 0.44148270185770877d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.040076012073060996d, y: 0.809070119067173d), new NpgsqlTypes.NpgsqlPoint(x: 0.14950004205256184d, y: 0.8871769613428705d), new NpgsqlTypes.NpgsqlPoint(x: 0.3698044973842166d, y: 0.7905771727630281d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12380797305338709d, y: 0.2142514482976795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5474755453348294d, y: 0.7468385056502592d), new NpgsqlTypes.NpgsqlPoint(x: 0.07729625460012013d, y: 0.5967550025841837d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6924780886876419d, y: 0.18675754930054822d), new NpgsqlTypes.NpgsqlPoint(x: 0.889621790242513d, y: 0.695745465447444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8978331767879474d, y: 0.07414942785259548d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7023457653148409d, y: 0.24859313733497412d), new NpgsqlTypes.NpgsqlPoint(x: 0.30597861231778867d, y: 0.11417389110641263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116585819913464d, y: 0.00781225593427981d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5219211130635201d, y: 0.3972420150398521d), new NpgsqlTypes.NpgsqlPoint(x: 0.47950449246148796d, y: 0.3973789656125817d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878164582857184d, y: 0.2104048103524333d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0017252590365117726d, y: 0.10468370572356733d), new NpgsqlTypes.NpgsqlPoint(x: 0.48462079469992614d, y: 0.8270565541912651d), new NpgsqlTypes.NpgsqlPoint(x: 0.683192728618037d, y: 0.2988982219110745d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9345682292293096d, y: 0.2995047896402948d), new NpgsqlTypes.NpgsqlPoint(x: 0.633875293343271d, y: 0.636212214251618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8514263445326234d, y: 0.44777880045687235d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8064639199189186d, y: 0.41682549615239173d), new NpgsqlTypes.NpgsqlPoint(x: 0.07395715560069582d, y: 0.05017454997161108d), new NpgsqlTypes.NpgsqlPoint(x: 0.5087320439659982d, y: 0.2549825439064384d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5916363322726022d, y: 0.6512670099370086d), new NpgsqlTypes.NpgsqlPoint(x: 0.3488891375172014d, y: 0.7727050310686648d), new NpgsqlTypes.NpgsqlPoint(x: 0.2189176427673275d, y: 0.14998611472751278d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30564387289882167d, y: 0.06744896472141959d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507781229427854d, y: 0.48543423735322544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7721914707723578d, y: 0.8654033372026022d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05727672918461868d, y: 0.18297881178367825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6860136786690001d, y: 0.13776661569323545d), new NpgsqlTypes.NpgsqlPoint(x: 0.62338051302098d, y: 0.5807066990758205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46017346402246484d, y: 0.5667582363043753d), new NpgsqlTypes.NpgsqlPoint(x: 0.943987464051414d, y: 0.5673212095719882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848770399760881d, y: 0.5282246528129971d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5636167848627741d, y: 0.14562820845640345d), new NpgsqlTypes.NpgsqlPoint(x: 0.9505647883024056d, y: 0.9929111791584734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4223188619221667d, y: 0.5933787824458151d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08911901854850635d, y: 0.7121221377676966d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373265169156207d, y: 0.6720615683140195d), new NpgsqlTypes.NpgsqlPoint(x: 0.20258180319571073d, y: 0.12165774165331755d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23955712079423985d, y: 0.6477855247288292d), new NpgsqlTypes.NpgsqlPoint(x: 0.4947708542192527d, y: 0.19359184288716713d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752808796544554d, y: 0.17959772127025553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09141048023356202d, y: 0.08507017493179647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7651752226614322d, y: 0.3534811870484317d), new NpgsqlTypes.NpgsqlPoint(x: 0.7165633330155774d, y: 0.43979818427580797d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19608297669378705d, y: 0.6428829555004029d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820950466730271d, y: 0.8547835421017272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5596560250820437d, y: 0.155329754258538d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8485747962713288d, y: 0.1450931640119394d), new NpgsqlTypes.NpgsqlPoint(x: 0.3373022214338386d, y: 0.44736231999357334d), new NpgsqlTypes.NpgsqlPoint(x: 0.2778646465068769d, y: 0.015524740264591497d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05569025724193355d, y: 0.8494909520285858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5338060304993588d, y: 0.3037645978642519d), new NpgsqlTypes.NpgsqlPoint(x: 0.3751261115819342d, y: 0.42264593650847393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011067303775829873d, y: 0.47693241384413165d), new NpgsqlTypes.NpgsqlPoint(x: 0.39515611467900025d, y: 0.9413906638067369d), new NpgsqlTypes.NpgsqlPoint(x: 0.738899549926419d, y: 0.3920528669344431d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9855211781248643d, y: 0.1265179869248686d), new NpgsqlTypes.NpgsqlPoint(x: 0.5527582200594576d, y: 0.21311715973166445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4122305187239891d, y: 0.2873394777734549d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7349109275689771d, y: 0.5787835944079317d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853625300379605d, y: 0.5253108402976283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6214400310190702d, y: 0.8332938217170621d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21321685263982548d, y: 0.1495554694701754d), new NpgsqlTypes.NpgsqlPoint(x: 0.11914330310313836d, y: 0.8555501883192144d), new NpgsqlTypes.NpgsqlPoint(x: 0.48781367142795307d, y: 0.4007712425353539d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14121417205688702d, y: 0.5090949262958318d), new NpgsqlTypes.NpgsqlPoint(x: 0.09346154561388154d, y: 0.6684623306841101d), new NpgsqlTypes.NpgsqlPoint(x: 0.9553550742769051d, y: 0.18938912968026078d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9482827087543625d, y: 0.37445337028000447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5105182163752057d, y: 0.7069647073471184d), new NpgsqlTypes.NpgsqlPoint(x: 0.31916926237435783d, y: 0.6050830498418909d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.926696719041337d, y: 0.8183635016339766d), new NpgsqlTypes.NpgsqlPoint(x: 0.2276331578926798d, y: 0.6328971085566382d), new NpgsqlTypes.NpgsqlPoint(x: 0.021940632071733246d, y: 0.8347450722198378d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39857448925193506d, y: 0.43020559692368787d), new NpgsqlTypes.NpgsqlPoint(x: 0.12326628341057644d, y: 0.8001561245520327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6057346738303213d, y: 0.6793168654216944d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0026526628307456113d, y: 0.41844481631538444d), new NpgsqlTypes.NpgsqlPoint(x: 0.4776945033136507d, y: 0.03512333124369582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5747077363321201d, y: 0.40463786973285254d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17024523831630467d, y: 0.31701871876890564d), new NpgsqlTypes.NpgsqlPoint(x: 0.9698145784778088d, y: 0.6124594622321127d), new NpgsqlTypes.NpgsqlPoint(x: 0.39682977863157276d, y: 0.5865323674612315d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07174912637482544d, y: 0.8408897173044582d), new NpgsqlTypes.NpgsqlPoint(x: 0.4961174454897217d, y: 0.10392914240489792d), new NpgsqlTypes.NpgsqlPoint(x: 0.2997555162811302d, y: 0.8668853452215721d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4027291701085407d, y: 0.7092690432549505d), new NpgsqlTypes.NpgsqlPoint(x: 0.19281646645494865d, y: 0.8989734865941746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528899376875801d, y: 0.9630223417703253d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9823658105022599d, y: 0.15159359785697135d), new NpgsqlTypes.NpgsqlPoint(x: 0.9950311995832366d, y: 0.4242975148946988d), new NpgsqlTypes.NpgsqlPoint(x: 0.8515266448622472d, y: 0.0683762781853895d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27126305851857235d, y: 0.723354068607965d), new NpgsqlTypes.NpgsqlPoint(x: 0.0031545909059942367d, y: 0.7875827140611145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111609782427317d, y: 0.6661024569794585d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4890771134209436d, y: 0.14122657842863529d), new NpgsqlTypes.NpgsqlPoint(x: 0.5453261266547554d, y: 0.688450732320335d), new NpgsqlTypes.NpgsqlPoint(x: 0.20987306658344973d, y: 0.0891698730362338d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6872612559429792d, y: 0.3631718984130079d), new NpgsqlTypes.NpgsqlPoint(x: 0.7578959582193078d, y: 0.9235901920996983d), new NpgsqlTypes.NpgsqlPoint(x: 0.8137431011689229d, y: 0.7694482258826848d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.516097418491915d, y: 0.09287704677644204d), new NpgsqlTypes.NpgsqlPoint(x: 0.17624128934537053d, y: 0.45451173739740625d), new NpgsqlTypes.NpgsqlPoint(x: 0.2497650680548712d, y: 0.7680046039003185d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04761281362343828d, y: 0.1977027695261797d), new NpgsqlTypes.NpgsqlPoint(x: 0.23205697087822896d, y: 0.42119926460380686d), new NpgsqlTypes.NpgsqlPoint(x: 0.12332935770631226d, y: 0.2323325049253755d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7434539499077039d, y: 0.7335319659947122d), new NpgsqlTypes.NpgsqlPoint(x: 0.12612985151944212d, y: 0.3212107018975292d), new NpgsqlTypes.NpgsqlPoint(x: 0.3496130812267385d, y: 0.9938000263827553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8648146737053938d, y: 0.47128635391980644d), new NpgsqlTypes.NpgsqlPoint(x: 0.050478381406966255d, y: 0.553050358694266d), new NpgsqlTypes.NpgsqlPoint(x: 0.007126917036191394d, y: 0.31294953917346247d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3367473240719553d, y: 0.14425829187088868d), new NpgsqlTypes.NpgsqlPoint(x: 0.3195854705617823d, y: 0.4703837866746672d), new NpgsqlTypes.NpgsqlPoint(x: 0.015498595504158885d, y: 0.6280749356557168d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8851890579608329d, y: 0.5258559400027674d), new NpgsqlTypes.NpgsqlPoint(x: 0.13307992954909498d, y: 0.6341920671129139d), new NpgsqlTypes.NpgsqlPoint(x: 0.2023390993071803d, y: 0.4367362398829987d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14885485009978716d, y: 0.7240833889564942d), new NpgsqlTypes.NpgsqlPoint(x: 0.3199314904785403d, y: 0.3391103087493986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8221365682665205d, y: 0.5111598144568269d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49316731051228657d, y: 0.5806483270108941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5943060150411152d, y: 0.920658984607199d), new NpgsqlTypes.NpgsqlPoint(x: 0.39187504024257847d, y: 0.39791994473538683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4456522950541132d, y: 0.299431497819037d), new NpgsqlTypes.NpgsqlPoint(x: 0.15327520591196275d, y: 0.2512692475414904d), new NpgsqlTypes.NpgsqlPoint(x: 0.09450670767976455d, y: 0.5510385857695096d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
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
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18082388456762244d, y: 0.9895545045446342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286189947447949d, y: 0.2031050759314348d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243084164688d, y: 0.9145550182444904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9946639234938931d, y: 0.6199569597237379d), new NpgsqlTypes.NpgsqlPoint(x: 0.0055804211579103535d, y: 0.6406579073988875d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216717847598736d, y: 0.8578495607714154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7968925474791765d, y: 0.26201908429394216d), new NpgsqlTypes.NpgsqlPoint(x: 0.53984409274396d, y: 0.3368569849880112d), new NpgsqlTypes.NpgsqlPoint(x: 0.11851712558908678d, y: 0.7042153003413723d)),
}));
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1486827904430913d, y: 0.9166379121106715d), new NpgsqlTypes.NpgsqlPoint(x: 0.931380994462064d, y: 0.9672998748726424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6731057335965384d, y: 0.09123294160283701d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8133188739614188d, y: 0.6767931849221208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7149964284987249d, y: 0.10841289363571538d), new NpgsqlTypes.NpgsqlPoint(x: 0.24869816412521406d, y: 0.9918544036823389d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48048238683682465d, y: 0.8230207898269624d), new NpgsqlTypes.NpgsqlPoint(x: 0.23457644268815137d, y: 0.2954881884528271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832148253206426d, y: 0.615301070793515d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22523782512713064d, y: 0.6556053530280499d), new NpgsqlTypes.NpgsqlPoint(x: 0.2925498502348751d, y: 0.7623416359980385d), new NpgsqlTypes.NpgsqlPoint(x: 0.5718356024166563d, y: 0.8780022438984789d)),
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49326657997739254d, y: 0.9365106074850306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853079898314615d, y: 0.12751111838133844d), new NpgsqlTypes.NpgsqlPoint(x: 0.5893571597927575d, y: 0.15235049784812504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9778446704004368d, y: 0.7853079963599358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402175715698567d, y: 0.9761366695653473d), new NpgsqlTypes.NpgsqlPoint(x: 0.23060472724044678d, y: 0.22842633926714573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.776557274366397d, y: 0.486702773451677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601483914113655d, y: 0.0672896303630276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442525484940929d, y: 0.01890684927393893d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18463917416061004d, y: 0.9586584881967003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180632119215655d, y: 0.05397396188215908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5738470645758931d, y: 0.643438270254981d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05045217322628559d, y: 0.27060327719261446d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887764270128858d, y: 0.10090036111886935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7660307127627569d, y: 0.48766449634201403d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19685494309970508d, y: 0.2904275312441995d), new NpgsqlTypes.NpgsqlPoint(x: 0.16162235281232362d, y: 0.6059718071161756d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278475030274608d, y: 0.46608623418210804d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6589993892311491d, y: 0.08469489721689694d), new NpgsqlTypes.NpgsqlPoint(x: 0.8294731537434723d, y: 0.7507560403591265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196263235936472d, y: 0.9519963517153017d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 66, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 9, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 130, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 44, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 124, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 69, query1, 159, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 61, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 74, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 61, 32))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 44);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[30], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[31], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[32], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[33], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[30], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[31], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[32], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[33], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI), typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                await ((INpgsqlPathArraypathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                ((INpgsqlPathArraypathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

