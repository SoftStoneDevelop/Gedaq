

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5549482808548318d,right: 0.12435380171039567d,bottom: 0.2243644416785996d,left: 0.0611361362616083d),

new NpgsqlTypes.NpgsqlBox(top: 0.982148317787902d,right: 0.9260715618449306d,bottom: 0.7150035767209055d,left: 0.23043369071052178d),

new NpgsqlTypes.NpgsqlBox(top: 0.881837615482955d,right: 0.8766967360877114d,bottom: 0.736492213047128d,left: 0.8081543461578206d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4854351461617782d,right: 0.560019144569925d,bottom: 0.31135390809021035d,left: 0.3434200121863136d),

new NpgsqlTypes.NpgsqlBox(top: 0.6716771535351247d,right: 0.9686230124624178d,bottom: 0.38581347059467797d,left: 0.5790324903521346d),

new NpgsqlTypes.NpgsqlBox(top: 0.4586245266250736d,right: 0.5729904811070109d,bottom: 0.10664970189884804d,left: 0.4370895527722636d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6010985745319993d,right: 0.9793234499944417d,bottom: 0.012440246793942067d,left: 0.8994905581165429d),

new NpgsqlTypes.NpgsqlBox(top: 0.6924613717753643d,right: 0.5043466980564234d,bottom: 0.3673567467050739d,left: 0.2854872339423473d),

new NpgsqlTypes.NpgsqlBox(top: 0.80989540253933d,right: 0.8286645664976635d,bottom: 0.08255428963428701d,left: 0.38585367688813765d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4879380914933391d,right: 0.9081428172417486d,bottom: 0.03329224440650058d,left: 0.8379660194864044d),

new NpgsqlTypes.NpgsqlBox(top: 0.24336073547168868d,right: 0.8271156694344235d,bottom: 0.06368943214434797d,left: 0.41169784904493223d),

new NpgsqlTypes.NpgsqlBox(top: 0.6075580087261532d,right: 0.9912947581804675d,bottom: 0.5072015122877696d,left: 0.5612798109027497d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7928797624521425d,right: 0.5716232167568417d,bottom: 0.06389893932090684d,left: 0.24082377845708614d),

new NpgsqlTypes.NpgsqlBox(top: 0.6660987724382623d,right: 0.7875377300274804d,bottom: 0.25457180133881496d,left: 0.4732357286741635d),

new NpgsqlTypes.NpgsqlBox(top: 0.5005170594211258d,right: 0.674778372298498d,bottom: 0.3221588194703584d,left: 0.297917109254651d),

new NpgsqlTypes.NpgsqlBox(top: 0.8168430628157286d,right: 0.694574689700815d,bottom: 0.4580337803919573d,left: 0.6541740831423701d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6995638461100505d,right: 0.08938249242524654d,bottom: 0.1862676681583797d,left: 0.015806046044801625d),

new NpgsqlTypes.NpgsqlBox(top: 0.7274051806275236d,right: 0.462657853767074d,bottom: 0.11633063630547247d,left: 0.20680146328021398d),

new NpgsqlTypes.NpgsqlBox(top: 0.3727587446323646d,right: 0.7174336023810723d,bottom: 0.22600940372311396d,left: 0.354193466687195d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6122424582015024d,right: 0.979662855655999d,bottom: 0.009433415038793025d,left: 0.9214159302097931d),

new NpgsqlTypes.NpgsqlBox(top: 0.629945988082629d,right: 0.2493564272441271d,bottom: 0.10976492577436026d,left: 0.18924022483933045d),

new NpgsqlTypes.NpgsqlBox(top: 0.592745906536665d,right: 0.12767794714112324d,bottom: 0.14627836624311275d,left: 0.017730905258120377d),

new NpgsqlTypes.NpgsqlBox(top: 0.7367679764855439d,right: 0.23287221907832123d,bottom: 0.030896879992434845d,left: 0.16239954925543199d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.36577463702904756d,right: 0.8576477552464283d,bottom: 0.33481372437179613d,left: 0.5645848059973626d),

new NpgsqlTypes.NpgsqlBox(top: 0.5761763748127671d,right: 0.6268169692870399d,bottom: 0.05102061428563964d,left: 0.43897363713531357d),

new NpgsqlTypes.NpgsqlBox(top: 0.2659920948812884d,right: 0.8330971620265238d,bottom: 0.18563505867420416d,left: 0.6126039663376199d),

new NpgsqlTypes.NpgsqlBox(top: 0.9361531708232086d,right: 0.8822010445911452d,bottom: 0.4610141584542714d,left: 0.8767485224636763d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8910581083919009d,right: 0.7298893384261156d,bottom: 0.5084152901495028d,left: 0.4548841174104564d),

new NpgsqlTypes.NpgsqlBox(top: 0.8988462364497419d,right: 0.19946765059576377d,bottom: 0.8704574718974456d,left: 0.13427354086691956d),

new NpgsqlTypes.NpgsqlBox(top: 0.40463153203021485d,right: 0.8932203495920993d,bottom: 0.40446805350954174d,left: 0.41764220450183775d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8312919048399062d,right: 0.9049878234690752d,bottom: 0.5361102278413811d,left: 0.8427197185173492d),

new NpgsqlTypes.NpgsqlBox(top: 0.699961406775009d,right: 0.4545127511909527d,bottom: 0.5433756591238877d,left: 0.41567821226319823d),

new NpgsqlTypes.NpgsqlBox(top: 0.7474479995832423d,right: 0.6656581143615626d,bottom: 0.5189789967979924d,left: 0.4808199311052309d),

new NpgsqlTypes.NpgsqlBox(top: 0.544742373594725d,right: 0.7741291549688886d,bottom: 0.4664330706466433d,left: 0.587375465861794d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.920399812561248d,right: 0.9637975725174125d,bottom: 0.2422689318294856d,left: 0.3308873271884394d),

new NpgsqlTypes.NpgsqlBox(top: 0.7431634398121543d,right: 0.346786889024462d,bottom: 0.18165071718824077d,left: 0.13695789104587264d),

new NpgsqlTypes.NpgsqlBox(top: 0.46891935795054474d,right: 0.6455788855712342d,bottom: 0.1544961663383927d,left: 0.19725505972118418d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6689868671887834d,right: 0.5817166949273115d,bottom: 0.4311370812387131d,left: 0.33967945467145844d),

new NpgsqlTypes.NpgsqlBox(top: 0.7369841601578678d,right: 0.7946163608967367d,bottom: 0.25011077538901827d,left: 0.5278263058468593d),

new NpgsqlTypes.NpgsqlBox(top: 0.7500362961426427d,right: 0.6165230112132242d,bottom: 0.5405205328179825d,left: 0.5823178013737893d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7781240701477071d,right: 0.926500485063382d,bottom: 0.710141234152569d,left: 0.81358868311432d),

new NpgsqlTypes.NpgsqlBox(top: 0.8407835598081366d,right: 0.39716184225450024d,bottom: 0.3387860346850492d,left: 0.22241609226374393d),

new NpgsqlTypes.NpgsqlBox(top: 0.9515349178401968d,right: 0.5378531185506283d,bottom: 0.7584179954194834d,left: 0.16764694339417285d),

new NpgsqlTypes.NpgsqlBox(top: 0.9170861952633206d,right: 0.909973684076479d,bottom: 0.44351927461294693d,left: 0.014653624728411141d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6477833232284002d,right: 0.7199170652867611d,bottom: 0.5366036375098933d,left: 0.3445803296142119d),

new NpgsqlTypes.NpgsqlBox(top: 0.9141307544800856d,right: 0.7336236456628775d,bottom: 0.5619545324377515d,left: 0.2352033623533013d),

new NpgsqlTypes.NpgsqlBox(top: 0.32069914821334655d,right: 0.3172796363448034d,bottom: 0.20231090198134216d,left: 0.21662433965413908d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9079804263627355d,right: 0.8546200401836154d,bottom: 0.26618270540463373d,left: 0.3379059942311151d),

new NpgsqlTypes.NpgsqlBox(top: 0.37577505772033226d,right: 0.9571535541272254d,bottom: 0.05939327903165448d,left: 0.6552343668481695d),

new NpgsqlTypes.NpgsqlBox(top: 0.07716258761914052d,right: 0.5425357665792044d,bottom: 0.01829900803749762d,left: 0.12390409697380556d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.21010774638262364d,right: 0.7650172485275706d,bottom: 0.13126501387693823d,left: 0.5657790215418139d),

new NpgsqlTypes.NpgsqlBox(top: 0.7880643256247355d,right: 0.11202005084629096d,bottom: 0.3255400330127882d,left: 0.08061948908294314d),

new NpgsqlTypes.NpgsqlBox(top: 0.6904430813237369d,right: 0.835885134041646d,bottom: 0.546830965684536d,left: 0.34988399873661136d),

new NpgsqlTypes.NpgsqlBox(top: 0.8337600363330246d,right: 0.6410229177156122d,bottom: 0.016734299353332482d,left: 0.5561390487076603d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8304439340624904d,right: 0.6176964749824785d,bottom: 0.1259128159000824d,left: 0.2887762259744875d),

new NpgsqlTypes.NpgsqlBox(top: 0.908379252602046d,right: 0.9740953897217441d,bottom: 0.02641787069656465d,left: 0.8614624349465609d),

new NpgsqlTypes.NpgsqlBox(top: 0.7130700351044079d,right: 0.684329890795091d,bottom: 0.6628795569469795d,left: 0.6734612329757228d),

new NpgsqlTypes.NpgsqlBox(top: 0.7401663424543741d,right: 0.6172939119608846d,bottom: 0.5488971211732268d,left: 0.379290366820925d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8283062612420456d,right: 0.6496435410557725d,bottom: 0.26150156061001206d,left: 0.4711594148697269d),

new NpgsqlTypes.NpgsqlBox(top: 0.8101705244937075d,right: 0.6239711552525967d,bottom: 0.6494522182070531d,left: 0.04703584234651659d),

new NpgsqlTypes.NpgsqlBox(top: 0.497010175965632d,right: 0.636925167293977d,bottom: 0.051325407248326904d,left: 0.6276863030436386d),

new NpgsqlTypes.NpgsqlBox(top: 0.6995451050117582d,right: 0.928929159608572d,bottom: 0.6632209769345114d,left: 0.33172404870087413d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3879604097305963d,right: 0.9670197131106049d,bottom: 0.250071570948338d,left: 0.3981678563321108d),

new NpgsqlTypes.NpgsqlBox(top: 0.2972164043305602d,right: 0.9552055193082456d,bottom: 0.2509608887422804d,left: 0.3038759300327343d),

new NpgsqlTypes.NpgsqlBox(top: 0.7386430962082728d,right: 0.8323131324443396d,bottom: 0.6199369152626768d,left: 0.7482019760156166d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3885305979089887d,right: 0.7614395623724382d,bottom: 0.28016272233292505d,left: 0.39377088061441523d),

new NpgsqlTypes.NpgsqlBox(top: 0.7536205616143233d,right: 0.7014947964842552d,bottom: 0.4659310662278765d,left: 0.4006243850002775d),

new NpgsqlTypes.NpgsqlBox(top: 0.7175253635094387d,right: 0.6481833898757385d,bottom: 0.4852165814173638d,left: 0.3564446622198246d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7609582142494368d,right: 0.590826819019407d,bottom: 0.5181634310612002d,left: 0.38218606865189786d),

new NpgsqlTypes.NpgsqlBox(top: 0.9519834629393388d,right: 0.3132951304850373d,bottom: 0.3862750522015346d,left: 0.07494941950937994d),

new NpgsqlTypes.NpgsqlBox(top: 0.954784204177687d,right: 0.7418300474823214d,bottom: 0.5410970962554162d,left: 0.6917265415107506d),

new NpgsqlTypes.NpgsqlBox(top: 0.5008209301676417d,right: 0.9376339186077991d,bottom: 0.031567075120140786d,left: 0.8014418990673549d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8973575800273063d,right: 0.7510581252829758d,bottom: 0.6829479489355919d,left: 0.05978905815631408d),

new NpgsqlTypes.NpgsqlBox(top: 0.8871174853854454d,right: 0.9274466683685665d,bottom: 0.3106879235134523d,left: 0.04341490214103205d),

new NpgsqlTypes.NpgsqlBox(top: 0.27808849741795205d,right: 0.25946518745761327d,bottom: 0.2702529374579117d,left: 0.06038206773942889d),

new NpgsqlTypes.NpgsqlBox(top: 0.68156422513841d,right: 0.595084627070234d,bottom: 0.2890400487688243d,left: 0.18829107073742635d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9751010188371416d,right: 0.45154848595834796d,bottom: 0.9520896521632883d,left: 0.1930341319586566d),

new NpgsqlTypes.NpgsqlBox(top: 0.8661545471995974d,right: 0.9774061921002047d,bottom: 0.7864451079064404d,left: 0.3838570653776836d),

new NpgsqlTypes.NpgsqlBox(top: 0.7172664121265588d,right: 0.497296031479846d,bottom: 0.6257589953710957d,left: 0.4232191428137825d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5723924280038639d,right: 0.8347570710876048d,bottom: 0.5326178393565345d,left: 0.38921168702017495d),

new NpgsqlTypes.NpgsqlBox(top: 0.7805853028289356d,right: 0.5026084340962126d,bottom: 0.5774283338196352d,left: 0.03915794600014133d),

new NpgsqlTypes.NpgsqlBox(top: 0.5460127756387876d,right: 0.6722984849195659d,bottom: 0.1047701722926585d,left: 0.3552774525980167d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9896260184930795d,right: 0.8669043778028601d,bottom: 0.32617959149690234d,left: 0.45884722695372493d),

new NpgsqlTypes.NpgsqlBox(top: 0.6736167626214279d,right: 0.633467300032508d,bottom: 0.4716115202138278d,left: 0.13261069247368085d),

new NpgsqlTypes.NpgsqlBox(top: 0.675191871406536d,right: 0.5568516720307168d,bottom: 0.29989509957024163d,left: 0.05812998626341359d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8947760145078603d,right: 0.7365673913304952d,bottom: 0.6001849716873436d,left: 0.6040951509063887d),

new NpgsqlTypes.NpgsqlBox(top: 0.5003089551300952d,right: 0.703505396961581d,bottom: 0.2443113904197164d,left: 0.2178724187265596d),

new NpgsqlTypes.NpgsqlBox(top: 0.6304575784480541d,right: 0.5779824128719061d,bottom: 0.4104720963018976d,left: 0.5345901663409951d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6167083720117518d,right: 0.9085693822687418d,bottom: 0.23907544718739981d,left: 0.14173358013178095d),

new NpgsqlTypes.NpgsqlBox(top: 0.3417406719804853d,right: 0.6556954619709872d,bottom: 0.08194449529784231d,left: 0.15880816681926413d),

new NpgsqlTypes.NpgsqlBox(top: 0.961826306079506d,right: 0.9067539789591793d,bottom: 0.8760707846085904d,left: 0.22361576090314483d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.06946808894847356d,right: 0.6813967509117922d,bottom: 0.007510468861020803d,left: 0.4621679527300633d),

new NpgsqlTypes.NpgsqlBox(top: 0.6935465835791516d,right: 0.646230473822323d,bottom: 0.3148396974834643d,left: 0.5349260825818296d),

new NpgsqlTypes.NpgsqlBox(top: 0.6671435926276853d,right: 0.9910165750304802d,bottom: 0.5766321814369181d,left: 0.7479899553355915d),

new NpgsqlTypes.NpgsqlBox(top: 0.8508871270223145d,right: 0.8748954848147742d,bottom: 0.8012335554721257d,left: 0.43059713901544006d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5482935270797755d,right: 0.6396427067957822d,bottom: 0.47592627698287626d,left: 0.2024458410367742d),

new NpgsqlTypes.NpgsqlBox(top: 0.7603699706747322d,right: 0.4680749992080725d,bottom: 0.2507371313695026d,left: 0.12200648301438577d),

new NpgsqlTypes.NpgsqlBox(top: 0.8278914469234084d,right: 0.6791313714518209d,bottom: 0.025470277355468585d,left: 0.4765375976674959d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8005026849273736d,right: 0.4994458957579324d,bottom: 0.13252805027647996d,left: 0.3956143556985344d),

new NpgsqlTypes.NpgsqlBox(top: 0.8225959841183393d,right: 0.9835039299448918d,bottom: 0.6724286403170587d,left: 0.6302387287760749d),

new NpgsqlTypes.NpgsqlBox(top: 0.5493649367200651d,right: 0.35643209748834803d,bottom: 0.32221884712689364d,left: 0.21072771019147118d),

new NpgsqlTypes.NpgsqlBox(top: 0.49550204939639453d,right: 0.8476681306449346d,bottom: 0.45215581100584823d,left: 0.29177356396902676d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6599932329514209d,right: 0.7188082722464231d,bottom: 0.3661199136379285d,left: 0.19546107254661393d),

new NpgsqlTypes.NpgsqlBox(top: 0.9288803527061201d,right: 0.9820147922713176d,bottom: 0.836354440219209d,left: 0.14432120047372077d),

new NpgsqlTypes.NpgsqlBox(top: 0.7990448644058543d,right: 0.7795568026082325d,bottom: 0.6001872982470241d,left: 0.11650637640272787d),

new NpgsqlTypes.NpgsqlBox(top: 0.4717960562212691d,right: 0.8238089712772843d,bottom: 0.0350105096470793d,left: 0.4510773085588934d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9556528278242141d,right: 0.6491356812521749d,bottom: 0.2845016916808035d,left: 0.014963738642258861d),

new NpgsqlTypes.NpgsqlBox(top: 0.8318116705784142d,right: 0.6909234998650942d,bottom: 0.5648369642142771d,left: 0.3809789399945477d),

new NpgsqlTypes.NpgsqlBox(top: 0.4037712858705954d,right: 0.2608875179431226d,bottom: 0.2994186082902517d,left: 0.07719522412004065d),

new NpgsqlTypes.NpgsqlBox(top: 0.8407657816117822d,right: 0.9176710841274953d,bottom: 0.6413215664362757d,left: 0.5129216908667332d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9142646657222752d,right: 0.8955973714852659d,bottom: 0.6099160051265061d,left: 0.4950798621038326d),

new NpgsqlTypes.NpgsqlBox(top: 0.5201741871777141d,right: 0.6591365559817748d,bottom: 0.4419872740906743d,left: 0.3015602125260214d),

new NpgsqlTypes.NpgsqlBox(top: 0.6109360849512265d,right: 0.3944956197224678d,bottom: 0.15911654703636813d,left: 0.33336188653311494d),

new NpgsqlTypes.NpgsqlBox(top: 0.8728723124485295d,right: 0.7346835078797522d,bottom: 0.40713856581837793d,left: 0.43934231494050124d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.33827222953872826d,right: 0.6212819173477815d,bottom: 0.2844390518635038d,left: 0.3697486416363014d),

new NpgsqlTypes.NpgsqlBox(top: 0.6824682410238933d,right: 0.6393487167873273d,bottom: 0.57746073422114d,left: 0.1298764351990176d),

new NpgsqlTypes.NpgsqlBox(top: 0.6657081195697147d,right: 0.2585459093880873d,bottom: 0.16242804162644575d,left: 0.249774083840401d),

new NpgsqlTypes.NpgsqlBox(top: 0.8743230945539001d,right: 0.8709382127420682d,bottom: 0.29066234963720605d,left: 0.6301925006512092d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8079362810234717d,right: 0.7437920125164286d,bottom: 0.48678891004154223d,left: 0.03186154949417863d),

new NpgsqlTypes.NpgsqlBox(top: 0.19960955073260656d,right: 0.44760143470355584d,bottom: 0.16165419133794123d,left: 0.01140321768971675d),

new NpgsqlTypes.NpgsqlBox(top: 0.4531663857203868d,right: 0.9607535597032455d,bottom: 0.26380327973573847d,left: 0.32765501810705233d),

new NpgsqlTypes.NpgsqlBox(top: 0.6710666642333775d,right: 0.4616847695893087d,bottom: 0.6671719727219155d,left: 0.02572630762739314d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8622162990079836d,right: 0.128034791137987d,bottom: 0.11741143255517894d,left: 0.02467273046063856d),

new NpgsqlTypes.NpgsqlBox(top: 0.6650822394958771d,right: 0.9298549087365865d,bottom: 0.11400236504449901d,left: 0.06965552067384495d),

new NpgsqlTypes.NpgsqlBox(top: 0.9920708423580712d,right: 0.6025890467167788d,bottom: 0.2681778037142659d,left: 0.2803953321580469d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.47063295632724145d,right: 0.8907485014918275d,bottom: 0.11081294612666082d,left: 0.3136017230592245d),

new NpgsqlTypes.NpgsqlBox(top: 0.643004503159165d,right: 0.6536937836574063d,bottom: 0.46847128367268287d,left: 0.5586489656268488d),

new NpgsqlTypes.NpgsqlBox(top: 0.7361529528680949d,right: 0.5498739860265695d,bottom: 0.3548408504592212d,left: 0.41058285743348544d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8375647491156456d,right: 0.9210574793736414d,bottom: 0.1318720393885251d,left: 0.2568870575173794d),

new NpgsqlTypes.NpgsqlBox(top: 0.8416560186121237d,right: 0.8457721017063584d,bottom: 0.2751411675190968d,left: 0.20941067037540073d),

new NpgsqlTypes.NpgsqlBox(top: 0.19720551065079905d,right: 0.37404134217402496d,bottom: 0.00958631498131346d,left: 0.1947112133928095d),

new NpgsqlTypes.NpgsqlBox(top: 0.942897974922176d,right: 0.9319731005478592d,bottom: 0.6397894423187874d,left: 0.40355484539304287d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9698056972783439d,right: 0.6310362300813385d,bottom: 0.48131317644705307d,left: 0.47659103198791763d),

new NpgsqlTypes.NpgsqlBox(top: 0.5607418550298146d,right: 0.7741349111232024d,bottom: 0.27001079420124385d,left: 0.524668960383862d),

new NpgsqlTypes.NpgsqlBox(top: 0.7287725677497889d,right: 0.44360012069535093d,bottom: 0.43747446065943374d,left: 0.06599129589992847d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.36044860416958324d,right: 0.9613839545701401d,bottom: 0.12971303201464113d,left: 0.692437085116624d),

new NpgsqlTypes.NpgsqlBox(top: 0.8294267359268435d,right: 0.7246485604259006d,bottom: 0.5754787258462565d,left: 0.08341682779908821d),

new NpgsqlTypes.NpgsqlBox(top: 0.3817064530653431d,right: 0.6165688991246616d,bottom: 0.08405763282149814d,left: 0.16243169544986824d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5115435466655937d,right: 0.162747046976633d,bottom: 0.21302560938171256d,left: 0.03426358438437438d),

new NpgsqlTypes.NpgsqlBox(top: 0.9870557496124339d,right: 0.5158207272359362d,bottom: 0.4590340850659963d,left: 0.05089540924892788d),

new NpgsqlTypes.NpgsqlBox(top: 0.3337937486552539d,right: 0.6514861271009555d,bottom: 0.10154725935137943d,left: 0.5554555704363814d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9118902732073205d,right: 0.9049234069332662d,bottom: 0.6447607595531794d,left: 0.8687463604364244d),

new NpgsqlTypes.NpgsqlBox(top: 0.39991462077641027d,right: 0.6922648239931379d,bottom: 0.09469508797410331d,left: 0.18951822705424082d),

new NpgsqlTypes.NpgsqlBox(top: 0.117118772345289d,right: 0.6206863864489124d,bottom: 0.07173498109994803d,left: 0.54134900117752d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4644888002614579d,right: 0.8132226380936738d,bottom: 0.10645271840006287d,left: 0.7860885871669958d),

new NpgsqlTypes.NpgsqlBox(top: 0.9141104168568404d,right: 0.5966928788606879d,bottom: 0.7493819306101802d,left: 0.21302359855242026d),

new NpgsqlTypes.NpgsqlBox(top: 0.2878194971298589d,right: 0.45554868728189635d,bottom: 0.2480511954132727d,left: 0.36482349019831806d),

new NpgsqlTypes.NpgsqlBox(top: 0.885449439126073d,right: 0.719829216841273d,bottom: 0.18348114891838885d,left: 0.6770783307377918d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8287592041115335d,right: 0.9300996724337547d,bottom: 0.7880738809131206d,left: 0.17530285461310469d),

new NpgsqlTypes.NpgsqlBox(top: 0.24043328264637465d,right: 0.8740217208665112d,bottom: 0.21951930391205565d,left: 0.03647862701430393d),

new NpgsqlTypes.NpgsqlBox(top: 0.2694092650446146d,right: 0.9073770451101328d,bottom: 0.06258196008823802d,left: 0.7077009237421115d),

new NpgsqlTypes.NpgsqlBox(top: 0.39047991190873277d,right: 0.6634627171453531d,bottom: 0.24617108741001226d,left: 0.2839480940524888d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7799188716964812d,right: 0.9746713962758632d,bottom: 0.4998705069172169d,left: 0.10395291919817307d),

new NpgsqlTypes.NpgsqlBox(top: 0.37848590057003806d,right: 0.4930672903419764d,bottom: 0.21206105611083415d,left: 0.11316746992856541d),

new NpgsqlTypes.NpgsqlBox(top: 0.6713111198146143d,right: 0.8129410859396424d,bottom: 0.32829448542044704d,left: 0.7670658643055825d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.731181128700517d,right: 0.4494850333166637d,bottom: 0.3891707569065038d,left: 0.2582686067418546d),

new NpgsqlTypes.NpgsqlBox(top: 0.9972978512598222d,right: 0.9153252971689564d,bottom: 0.9956549100524262d,left: 0.8029677213717438d),

new NpgsqlTypes.NpgsqlBox(top: 0.9600422689398838d,right: 0.9884336206199043d,bottom: 0.9559259069988215d,left: 0.47093828339580357d),

new NpgsqlTypes.NpgsqlBox(top: 0.5908891214194876d,right: 0.9123592769532337d,bottom: 0.36739720337308446d,left: 0.15691228753353337d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8877927897943672d,right: 0.45048198392159977d,bottom: 0.8315479776186891d,left: 0.24909206837609732d),

new NpgsqlTypes.NpgsqlBox(top: 0.33105330798573307d,right: 0.2458091952773237d,bottom: 0.04222841835652358d,left: 0.03900694522840287d),

new NpgsqlTypes.NpgsqlBox(top: 0.5002943382512004d,right: 0.9485981638205573d,bottom: 0.3510518335847649d,left: 0.8753316341727206d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8417266897598801d,right: 0.6791101223134052d,bottom: 0.5548368707758393d,left: 0.550896355319514d),

new NpgsqlTypes.NpgsqlBox(top: 0.889527461304967d,right: 0.5602052677865146d,bottom: 0.8683291773638613d,left: 0.2297253052605509d),

new NpgsqlTypes.NpgsqlBox(top: 0.6910169873927272d,right: 0.7774818198782134d,bottom: 0.2719735047868763d,left: 0.7396669834449878d),

new NpgsqlTypes.NpgsqlBox(top: 0.9957345583369226d,right: 0.7879412165413358d,bottom: 0.7093847696626735d,left: 0.7672817163268392d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9197297747951244d,right: 0.6374750386689925d,bottom: 0.26970836092738015d,left: 0.28760459908306535d),

new NpgsqlTypes.NpgsqlBox(top: 0.32295762968764075d,right: 0.9201169641319963d,bottom: 0.01518276922095918d,left: 0.06602700343743184d),

new NpgsqlTypes.NpgsqlBox(top: 0.39558792828988476d,right: 0.33291466119718915d,bottom: 0.19322799865445195d,left: 0.2736548305567875d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46320800532739614d,right: 0.8984668079830432d,bottom: 0.45879381548064546d,left: 0.8588805341578445d),

new NpgsqlTypes.NpgsqlBox(top: 0.7182129847457055d,right: 0.7357088684255562d,bottom: 0.6694231968806135d,left: 0.4204459979666263d),

new NpgsqlTypes.NpgsqlBox(top: 0.9203373479651136d,right: 0.597498899710845d,bottom: 0.47330282351979236d,left: 0.46308327906829716d),

new NpgsqlTypes.NpgsqlBox(top: 0.41652176101889493d,right: 0.13355379202041606d,bottom: 0.027217535120763525d,left: 0.01942600184533938d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7889125962868522d,right: 0.3509231037787275d,bottom: 0.09280190133345301d,left: 0.2729731010022878d),

new NpgsqlTypes.NpgsqlBox(top: 0.6332794707298577d,right: 0.8706558547332885d,bottom: 0.11490122272461412d,left: 0.4623892916225586d),

new NpgsqlTypes.NpgsqlBox(top: 0.48321740463290874d,right: 0.49091045314460025d,bottom: 0.11134911768279288d,left: 0.1727919945888836d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6241858022852554d,right: 0.8375539534304044d,bottom: 0.03239694060302656d,left: 0.27430500407669145d),

new NpgsqlTypes.NpgsqlBox(top: 0.8440202938716683d,right: 0.5448307258834015d,bottom: 0.2621626009343998d,left: 0.18393703220789537d),

new NpgsqlTypes.NpgsqlBox(top: 0.9500179264038124d,right: 0.9711132869442582d,bottom: 0.45591105378541796d,left: 0.9614074314931701d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.946805943132869d,right: 0.2218243441822182d,bottom: 0.774673778710879d,left: 0.05710763289354959d),

new NpgsqlTypes.NpgsqlBox(top: 0.5475905986690861d,right: 0.885286426421751d,bottom: 0.31384257254570935d,left: 0.49011303879674517d),

new NpgsqlTypes.NpgsqlBox(top: 0.8305826440442958d,right: 0.9101490832519739d,bottom: 0.0736816233383939d,left: 0.5352096843659068d),

new NpgsqlTypes.NpgsqlBox(top: 0.867961440430702d,right: 0.910088673002906d,bottom: 0.509691666870426d,left: 0.55698986963191d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.997977893615556d,right: 0.5668383108933179d,bottom: 0.6061261163828585d,left: 0.24340635958006396d),

new NpgsqlTypes.NpgsqlBox(top: 0.9348022891289782d,right: 0.20205073627459602d,bottom: 0.6490316699825058d,left: 0.10061370700334671d),

new NpgsqlTypes.NpgsqlBox(top: 0.9326600847813341d,right: 0.5670705208624306d,bottom: 0.8633867326419074d,left: 0.4900033587086867d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5450685334843226d,right: 0.7795324574928302d,bottom: 0.4946546018134388d,left: 0.6566127091781054d),

new NpgsqlTypes.NpgsqlBox(top: 0.47530609194184725d,right: 0.832773247195916d,bottom: 0.3612117056406591d,left: 0.6111312217562885d),

new NpgsqlTypes.NpgsqlBox(top: 0.62158049316611d,right: 0.9844762453858896d,bottom: 0.11559298874107438d,left: 0.4094619799476408d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9995127135731755d,right: 0.38759589910529135d,bottom: 0.42037150039841065d,left: 0.018042925197927606d),

new NpgsqlTypes.NpgsqlBox(top: 0.6863248301011174d,right: 0.6574712703400178d,bottom: 0.01469133836959835d,left: 0.6103226271372416d),

new NpgsqlTypes.NpgsqlBox(top: 0.7107207031588739d,right: 0.47549662604569054d,bottom: 0.4522496620957295d,left: 0.29589981860728654d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2756710149290502d,right: 0.8237457187343085d,bottom: 0.1473664908057838d,left: 0.359221831109519d),

new NpgsqlTypes.NpgsqlBox(top: 0.4201285929882336d,right: 0.7603292875149162d,bottom: 0.12917575387574431d,left: 0.37882848046948736d),

new NpgsqlTypes.NpgsqlBox(top: 0.920999445175589d,right: 0.8909612722025645d,bottom: 0.14467290348281825d,left: 0.7037271016758992d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6754138521642329d,right: 0.904893841681176d,bottom: 0.5359952314440549d,left: 0.19531414901331345d),

new NpgsqlTypes.NpgsqlBox(top: 0.590562421854811d,right: 0.6803939012773558d,bottom: 0.5459799649204691d,left: 0.09973496421333161d),

new NpgsqlTypes.NpgsqlBox(top: 0.9044645136726344d,right: 0.8240415782525765d,bottom: 0.11759404461406675d,left: 0.20472037044862412d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8625797579306579d,right: 0.4108304435429737d,bottom: 0.2544416367315774d,left: 0.3881931945381212d),

new NpgsqlTypes.NpgsqlBox(top: 0.9267285092367193d,right: 0.17256598231393516d,bottom: 0.03292649909487411d,left: 0.028425164889341104d),

new NpgsqlTypes.NpgsqlBox(top: 0.6623007708874306d,right: 0.8289396463626406d,bottom: 0.08825732685178078d,left: 0.026292966503626003d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46779814069426295d,right: 0.9675965018868237d,bottom: 0.25578359017417074d,left: 0.5457950942091521d),

new NpgsqlTypes.NpgsqlBox(top: 0.907074566600135d,right: 0.9426201051848532d,bottom: 0.18249104224299562d,left: 0.668461213293721d),

new NpgsqlTypes.NpgsqlBox(top: 0.9759017108501247d,right: 0.3415280220563789d,bottom: 0.3668644921217369d,left: 0.31982298672403786d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2946221099672146d,right: 0.43805639408891794d,bottom: 0.2679468921676058d,left: 0.2767341653352636d),

new NpgsqlTypes.NpgsqlBox(top: 0.5238161832218639d,right: 0.6908099149209995d,bottom: 0.3720006910619096d,left: 0.6095450475608956d),

new NpgsqlTypes.NpgsqlBox(top: 0.7058412009249089d,right: 0.8299003383972149d,bottom: 0.4858260235645342d,left: 0.2251909048977757d),

new NpgsqlTypes.NpgsqlBox(top: 0.4116210615089726d,right: 0.8246155357392135d,bottom: 0.3832792022302445d,left: 0.7644384892808667d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6517799164568859d,right: 0.807758538519803d,bottom: 0.49224782349385154d,left: 0.05523840725048146d),

new NpgsqlTypes.NpgsqlBox(top: 0.420298416353463d,right: 0.9044465375381741d,bottom: 0.3151314094464587d,left: 0.3643668821794718d),

new NpgsqlTypes.NpgsqlBox(top: 0.542751158316048d,right: 0.8474952269653563d,bottom: 0.5125781207199788d,left: 0.8440826727711225d),

new NpgsqlTypes.NpgsqlBox(top: 0.7018168381628596d,right: 0.31023871417197846d,bottom: 0.6931544229741995d,left: 0.045951103430413975d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.57912446631002d,right: 0.48551206804537717d,bottom: 0.2865065239434875d,left: 0.2577672393681296d),

new NpgsqlTypes.NpgsqlBox(top: 0.8256421130511622d,right: 0.7016792783859904d,bottom: 0.29803016304228835d,left: 0.052976326890969316d),

new NpgsqlTypes.NpgsqlBox(top: 0.8096434943934775d,right: 0.9481698502616744d,bottom: 0.5326631859103992d,left: 0.7103358231771344d),

new NpgsqlTypes.NpgsqlBox(top: 0.8036696749435982d,right: 0.7815605465941147d,bottom: 0.16694675365223333d,left: 0.43493825572006084d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7914654729646693d,right: 0.4720429441191363d,bottom: 0.3083628745551662d,left: 0.10850758080971457d),

new NpgsqlTypes.NpgsqlBox(top: 0.7980546338284744d,right: 0.4146685602594212d,bottom: 0.3131476031502596d,left: 0.057412701799547716d),

new NpgsqlTypes.NpgsqlBox(top: 0.4516288084995119d,right: 0.7755949457752129d,bottom: 0.45003846529291947d,left: 0.3065004252100877d),

new NpgsqlTypes.NpgsqlBox(top: 0.9076551708279977d,right: 0.3969420414810215d,bottom: 0.4099710483487947d,left: 0.2017114612063975d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7568554107925209d,right: 0.7926775282724813d,bottom: 0.3606700221298128d,left: 0.36482330631391624d),

new NpgsqlTypes.NpgsqlBox(top: 0.23451951348011757d,right: 0.7275317587080522d,bottom: 0.002654211367683401d,left: 0.5903942872562552d),

new NpgsqlTypes.NpgsqlBox(top: 0.6910631200718269d,right: 0.6604508263118287d,bottom: 0.5315686117388819d,left: 0.37327432532820726d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.618485254118219d,right: 0.19337084410211847d,bottom: 0.22350533095249392d,left: 0.12794339260354293d),

new NpgsqlTypes.NpgsqlBox(top: 0.7975810372621165d,right: 0.2284324511621516d,bottom: 0.10776478196639017d,left: 0.07697224471629671d),

new NpgsqlTypes.NpgsqlBox(top: 0.13443235815476795d,right: 0.15364885354945168d,bottom: 0.002544658739705885d,left: 0.11304798244951697d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9624748072839672d,right: 0.5688078935418137d,bottom: 0.37905243053369364d,left: 0.19007601941475472d),

new NpgsqlTypes.NpgsqlBox(top: 0.6198149917726133d,right: 0.7883673709909276d,bottom: 0.4727430318359347d,left: 0.5784917120771202d),

new NpgsqlTypes.NpgsqlBox(top: 0.9307428543845649d,right: 0.7221633763536884d,bottom: 0.7185791287346359d,left: 0.514801343296645d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5219099215091634d,right: 0.27111787665967024d,bottom: 0.20199898417674766d,left: 0.12735296645281513d),

new NpgsqlTypes.NpgsqlBox(top: 0.8560175245426571d,right: 0.883486030646178d,bottom: 0.038242696882350824d,left: 0.628691556937873d),

new NpgsqlTypes.NpgsqlBox(top: 0.7858714260424726d,right: 0.8970416859239566d,bottom: 0.24919136512812767d,left: 0.26240135580962587d),

new NpgsqlTypes.NpgsqlBox(top: 0.8240077812084627d,right: 0.8755013211829532d,bottom: 0.38210014563289585d,left: 0.7607109152835847d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6504893522555918d,right: 0.7327678850330589d,bottom: 0.38834433683314984d,left: 0.3584242379073751d),

new NpgsqlTypes.NpgsqlBox(top: 0.5808639278410492d,right: 0.953528169145271d,bottom: 0.3204752739283987d,left: 0.823743947345191d),

new NpgsqlTypes.NpgsqlBox(top: 0.8688730964186563d,right: 0.49037211170946193d,bottom: 0.6406760956955492d,left: 0.365449378346008d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8352560030494203d,right: 0.6816982732215506d,bottom: 0.17808488666201439d,left: 0.6794371681851896d),

new NpgsqlTypes.NpgsqlBox(top: 0.28052518523554537d,right: 0.7469915686520349d,bottom: 0.19186714023346152d,left: 0.6168125718591009d),

new NpgsqlTypes.NpgsqlBox(top: 0.7618516726528385d,right: 0.34622363146449175d,bottom: 0.21371146332602087d,left: 0.022401158047279934d),

new NpgsqlTypes.NpgsqlBox(top: 0.5539968034800455d,right: 0.3322773943598004d,bottom: 0.344317941332524d,left: 0.2189985574586668d),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatchAsync(connection, 61, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatch(connection, 68, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2M>(15);

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
                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

