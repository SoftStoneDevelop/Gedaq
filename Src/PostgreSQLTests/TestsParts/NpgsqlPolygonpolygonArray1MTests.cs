

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
    internal partial interface INpgsqlPolygonArraypolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonArraypolygonArray : INpgsqlPolygonArraypolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray1M[] _testData = new NpgsqlPolygonpolygonArray1M[]
        {
            new NpgsqlPolygonpolygonArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36756415182474345d, y: 0.023084183585469153d), new NpgsqlTypes.NpgsqlPoint(x: 0.35638647047410543d, y: 0.7261630297999465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112366919455397d, y: 0.8012997704496484d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3636935611498546d, y: 0.8305201063273429d), new NpgsqlTypes.NpgsqlPoint(x: 0.9706736880899379d, y: 0.6436558161442489d), new NpgsqlTypes.NpgsqlPoint(x: 0.9024252026274925d, y: 0.730372475570107d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.239662373589549d, y: 0.5113709006752579d), new NpgsqlTypes.NpgsqlPoint(x: 0.3828918649784955d, y: 0.6123667218682316d), new NpgsqlTypes.NpgsqlPoint(x: 0.2744119160006745d, y: 0.6162006112510364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2911218150691388d, y: 0.5259654718675251d), new NpgsqlTypes.NpgsqlPoint(x: 0.26996142652583044d, y: 0.694305208486957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6931392127060947d, y: 0.3965758925333528d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4443299283691555d, y: 0.4723882942375942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738406882884678d, y: 0.3713411312281686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3090999816506942d, y: 0.3862796234117827d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6992649741339204d, y: 0.8877674544466038d), new NpgsqlTypes.NpgsqlPoint(x: 0.10304681608940292d, y: 0.44701202380769234d), new NpgsqlTypes.NpgsqlPoint(x: 0.01585111495036584d, y: 0.05555700645840134d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9863729616309234d, y: 0.1823558836201581d), new NpgsqlTypes.NpgsqlPoint(x: 0.22273426335028135d, y: 0.5801185443167277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424197730756389d, y: 0.9023349310646679d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8133949290530498d, y: 0.38748724739081764d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529841179178564d, y: 0.8951153904215329d), new NpgsqlTypes.NpgsqlPoint(x: 0.15850011740378644d, y: 0.32271826217457766d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5162624609626648d, y: 0.19900546251555162d), new NpgsqlTypes.NpgsqlPoint(x: 0.46161724179369146d, y: 0.3323967352811622d), new NpgsqlTypes.NpgsqlPoint(x: 0.7673217924367464d, y: 0.02316402858672817d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9545866440423109d, y: 0.17663303561817145d), new NpgsqlTypes.NpgsqlPoint(x: 0.4757805866096876d, y: 0.5726905776687039d), new NpgsqlTypes.NpgsqlPoint(x: 0.24340871002818465d, y: 0.208687401340373d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5933541981953386d, y: 0.2121441483337505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6235674518572113d, y: 0.8318000910901129d), new NpgsqlTypes.NpgsqlPoint(x: 0.012470043723181834d, y: 0.9423222220343072d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18271087791159002d, y: 0.625188001791135d), new NpgsqlTypes.NpgsqlPoint(x: 0.15297234455815978d, y: 0.4958083233024355d), new NpgsqlTypes.NpgsqlPoint(x: 0.2452960641507309d, y: 0.399441484135423d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10375125647409811d, y: 0.09899429056005038d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828826867786451d, y: 0.35294540125997886d), new NpgsqlTypes.NpgsqlPoint(x: 0.24702783092325653d, y: 0.6289459773102959d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9126751925220526d, y: 0.9481967706410112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625918149008557d, y: 0.9013807648171235d), new NpgsqlTypes.NpgsqlPoint(x: 0.33377368171738253d, y: 0.42624147312712135d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5397112132328151d, y: 0.7143503457388688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765274589827915d, y: 0.8059334245417226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877544226513137d, y: 0.9447430926798299d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20517384808718642d, y: 0.541922152397855d), new NpgsqlTypes.NpgsqlPoint(x: 0.36139840187525263d, y: 0.9262948701060753d), new NpgsqlTypes.NpgsqlPoint(x: 0.17834458661328545d, y: 0.12957416348293127d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6182838463400329d, y: 0.8409363529558795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976467945531216d, y: 0.6650559123189327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9037553436323532d, y: 0.9201329489358552d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6809332106883306d, y: 0.15079584103375587d), new NpgsqlTypes.NpgsqlPoint(x: 0.7273429254794289d, y: 0.8378773690961453d), new NpgsqlTypes.NpgsqlPoint(x: 0.47363937802701506d, y: 0.2830949103857039d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21748682411672038d, y: 0.6316946758827394d), new NpgsqlTypes.NpgsqlPoint(x: 0.612512547998814d, y: 0.969557167083285d), new NpgsqlTypes.NpgsqlPoint(x: 0.703012161470024d, y: 0.6294409034671716d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36222036044945116d, y: 0.26373050974827184d), new NpgsqlTypes.NpgsqlPoint(x: 0.9255763855628637d, y: 0.7197807783222491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8225390871173546d, y: 0.5168636504799872d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9102506399305667d, y: 0.26992697950964617d), new NpgsqlTypes.NpgsqlPoint(x: 0.42818454708002085d, y: 0.6290253448814366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682013282314278d, y: 0.6163636786619539d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23142262656328627d, y: 0.7386197111249476d), new NpgsqlTypes.NpgsqlPoint(x: 0.10308667474085287d, y: 0.8212322927554038d), new NpgsqlTypes.NpgsqlPoint(x: 0.8908915864095222d, y: 0.2712607165953027d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13982842269724194d, y: 0.9214108593484188d), new NpgsqlTypes.NpgsqlPoint(x: 0.28726260438364026d, y: 0.7789776727406015d), new NpgsqlTypes.NpgsqlPoint(x: 0.36011779986663284d, y: 0.7125322899496749d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07084975881925026d, y: 0.6681836050250796d), new NpgsqlTypes.NpgsqlPoint(x: 0.2041486524849151d, y: 0.7145033727288159d), new NpgsqlTypes.NpgsqlPoint(x: 0.05632744218274821d, y: 0.36279203314467956d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3268352286592784d, y: 0.8944337853471152d), new NpgsqlTypes.NpgsqlPoint(x: 0.3836444175218783d, y: 0.5941397334839879d), new NpgsqlTypes.NpgsqlPoint(x: 0.18242745870020738d, y: 0.2259233950780779d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7425503860486712d, y: 0.17782674282033428d), new NpgsqlTypes.NpgsqlPoint(x: 0.09527284623512178d, y: 0.17541700128123583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364670911285753d, y: 0.4959124194117891d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5962914081278206d, y: 0.23909664072724657d), new NpgsqlTypes.NpgsqlPoint(x: 0.6543441938601157d, y: 0.4360451274995162d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365258082227131d, y: 0.544397201338329d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06762828656834974d, y: 0.8696683237198995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338471157040259d, y: 0.20597239416007407d), new NpgsqlTypes.NpgsqlPoint(x: 0.3008916547160526d, y: 0.46416362020913493d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13195331708194247d, y: 0.8343520730890228d), new NpgsqlTypes.NpgsqlPoint(x: 0.7453802042836201d, y: 0.7343885931002716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752679967280576d, y: 0.19682410527006156d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5206225063089011d, y: 0.20336439443076026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9513901448667391d, y: 0.299969988266922d), new NpgsqlTypes.NpgsqlPoint(x: 0.01931845564851442d, y: 0.3229900522384265d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5781111709077223d, y: 0.3667381439428229d), new NpgsqlTypes.NpgsqlPoint(x: 0.738560474822509d, y: 0.811294533260055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7447875995128389d, y: 0.5455642649759902d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.361678606086951d, y: 0.526782609034837d), new NpgsqlTypes.NpgsqlPoint(x: 0.7204729858038135d, y: 0.24435587152020954d), new NpgsqlTypes.NpgsqlPoint(x: 0.4118742038764531d, y: 0.4398735244368437d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05684727617573693d, y: 0.03783404585810923d), new NpgsqlTypes.NpgsqlPoint(x: 0.06038373610822967d, y: 0.4467126624196097d), new NpgsqlTypes.NpgsqlPoint(x: 0.95058904422893d, y: 0.9032378018937073d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7788673383169271d, y: 0.5618681968225424d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503467244539425d, y: 0.7427502457860404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9234478286372491d, y: 0.0536749224815295d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3422214034419415d, y: 0.7845887865088449d), new NpgsqlTypes.NpgsqlPoint(x: 0.17950192841489554d, y: 0.05772358100911612d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045557129355516d, y: 0.7164400351748978d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5607024896876194d, y: 0.688508147052657d), new NpgsqlTypes.NpgsqlPoint(x: 0.959543022076423d, y: 0.6832252230958396d), new NpgsqlTypes.NpgsqlPoint(x: 0.6889519562408534d, y: 0.03452792795959059d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5296402601270652d, y: 0.13633369416642926d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759481539589162d, y: 0.5283015359246969d), new NpgsqlTypes.NpgsqlPoint(x: 0.12932024356790395d, y: 0.3350035628860689d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8008987954807213d, y: 0.16822362639464217d), new NpgsqlTypes.NpgsqlPoint(x: 0.768693684730685d, y: 0.024222810533454764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894925042846864d, y: 0.5973077441218773d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7668822105334451d, y: 0.8448550625481968d), new NpgsqlTypes.NpgsqlPoint(x: 0.2694650026468415d, y: 0.2629369007335307d), new NpgsqlTypes.NpgsqlPoint(x: 0.1535376446900858d, y: 0.05247207533021048d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2864944101735225d, y: 0.6868264022678824d), new NpgsqlTypes.NpgsqlPoint(x: 0.20732552660977133d, y: 0.2201238480824308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309559119165195d, y: 0.18254743377029536d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2556012289292491d, y: 0.23344540156639149d), new NpgsqlTypes.NpgsqlPoint(x: 0.7568030657373227d, y: 0.7475124960139501d), new NpgsqlTypes.NpgsqlPoint(x: 0.3165805388196776d, y: 0.4718979653883767d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5384783016495254d, y: 0.4659087785852777d), new NpgsqlTypes.NpgsqlPoint(x: 0.15158060667537143d, y: 0.045696284242209506d), new NpgsqlTypes.NpgsqlPoint(x: 0.7913488221898743d, y: 0.5382678301796723d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3477443706864525d, y: 0.8393566274347092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7921069858010433d, y: 0.6112179034366563d), new NpgsqlTypes.NpgsqlPoint(x: 0.37498857406540953d, y: 0.8333247135833525d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8237645536184232d, y: 0.377700424067984d), new NpgsqlTypes.NpgsqlPoint(x: 0.26072776186229574d, y: 0.1608098120877396d), new NpgsqlTypes.NpgsqlPoint(x: 0.06387161626434479d, y: 0.7474900280414477d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0006865214795119812d, y: 0.8037775225447834d), new NpgsqlTypes.NpgsqlPoint(x: 0.22746722142153553d, y: 0.39379072133097426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7153330469257302d, y: 0.23561333126112682d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4409901283239236d, y: 0.4137143158937565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6511775294226486d, y: 0.014111003149587797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7119242923044572d, y: 0.028440488656058305d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7792950472226023d, y: 0.19560505154254648d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579657837843621d, y: 0.9247967185022401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5781265929836588d, y: 0.8546100989401579d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43095854724293015d, y: 0.8652214290494248d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639562973720251d, y: 0.11915803397974511d), new NpgsqlTypes.NpgsqlPoint(x: 0.07136309745443215d, y: 0.5746798054732408d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9852070064243188d, y: 0.49807497664471634d), new NpgsqlTypes.NpgsqlPoint(x: 0.134601973704234d, y: 0.021223663232415535d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641276253771155d, y: 0.9016886744722036d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6823572387447355d, y: 0.8248679811289993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5858181863432785d, y: 0.18110111252023853d), new NpgsqlTypes.NpgsqlPoint(x: 0.823831018673044d, y: 0.8294336041755801d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37986783930266055d, y: 0.11462831129893891d), new NpgsqlTypes.NpgsqlPoint(x: 0.8444670593261617d, y: 0.7234366619742769d), new NpgsqlTypes.NpgsqlPoint(x: 0.04141354260189756d, y: 0.5497501594172345d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.125961436338908d, y: 0.20467912606856575d), new NpgsqlTypes.NpgsqlPoint(x: 0.4597161199898072d, y: 0.3211523810000816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005828275578879d, y: 0.7345290489282237d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5846613555356075d, y: 0.34524574571858724d), new NpgsqlTypes.NpgsqlPoint(x: 0.35930066827419915d, y: 0.45567407145649186d), new NpgsqlTypes.NpgsqlPoint(x: 0.30666679198184765d, y: 0.9468104507004698d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9974559635734227d, y: 0.17502709220948465d), new NpgsqlTypes.NpgsqlPoint(x: 0.0738460720540679d, y: 0.9252054261326035d), new NpgsqlTypes.NpgsqlPoint(x: 0.9401134917532371d, y: 0.7964537159567724d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9796638025674678d, y: 0.24833229974843762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9955984058851574d, y: 0.78220515811016d), new NpgsqlTypes.NpgsqlPoint(x: 0.5241597498743578d, y: 0.3350096901756746d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10278671103648851d, y: 0.7002018681153955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233442920313037d, y: 0.9567414093184141d), new NpgsqlTypes.NpgsqlPoint(x: 0.7811956253216643d, y: 0.6025631230617088d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.697603061987046d, y: 0.12299771390432668d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369705538053495d, y: 0.043179496211269264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5316581376321362d, y: 0.7574345762245275d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.540983039839021d, y: 0.7260103091269273d), new NpgsqlTypes.NpgsqlPoint(x: 0.9667406744205562d, y: 0.36146473436534476d), new NpgsqlTypes.NpgsqlPoint(x: 0.40112259146531737d, y: 0.8431372391344027d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5439168210154098d, y: 0.435885714723641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5614449563513394d, y: 0.9243782502247342d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652216830287778d, y: 0.14179887722024254d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.031237468962273085d, y: 0.6220456912705775d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598067624930221d, y: 0.27915017823175026d), new NpgsqlTypes.NpgsqlPoint(x: 0.8540100596305326d, y: 0.8434607024036369d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08392635976425522d, y: 0.5936094054290747d), new NpgsqlTypes.NpgsqlPoint(x: 0.6742708371543297d, y: 0.7857541683044564d), new NpgsqlTypes.NpgsqlPoint(x: 0.16702275525577337d, y: 0.4269550069161212d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8576643193131964d, y: 0.5013849731328646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201830881218283d, y: 0.1251889914440456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7058742299229717d, y: 0.4467100905190753d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42190512757783705d, y: 0.31868811305586964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4171403098445309d, y: 0.9035670784845357d), new NpgsqlTypes.NpgsqlPoint(x: 0.06528947580546862d, y: 0.25945145946532355d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32897738030634394d, y: 0.7289344099838995d), new NpgsqlTypes.NpgsqlPoint(x: 0.503602347500239d, y: 0.6220205258586855d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102654959431531d, y: 0.9984093310592448d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.567703797813782d, y: 0.6318979108790582d), new NpgsqlTypes.NpgsqlPoint(x: 0.10401540698847389d, y: 0.4589640299697746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6327589105616781d, y: 0.0003841031986013821d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9299380665676948d, y: 0.07210504905601522d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701599637969449d, y: 0.16467314654967002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9062584660214085d, y: 0.9327895723382388d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4285879384949456d, y: 0.0829646221498932d), new NpgsqlTypes.NpgsqlPoint(x: 0.6650878032530435d, y: 0.1726417070165176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8698107463424789d, y: 0.047173000149638766d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5802256931758101d, y: 0.4628207287275491d), new NpgsqlTypes.NpgsqlPoint(x: 0.2650992380123678d, y: 0.5888132461104478d), new NpgsqlTypes.NpgsqlPoint(x: 0.8090937230372546d, y: 0.0855681193652632d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11223863511963605d, y: 0.6005987375513144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461958943804273d, y: 0.7842165933407581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161702722569822d, y: 0.42393296480448506d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5845996574404564d, y: 0.7839878671702737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5709654724360209d, y: 0.3308084495735616d), new NpgsqlTypes.NpgsqlPoint(x: 0.11558838208252564d, y: 0.13422032922540317d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8865126129313787d, y: 0.4992055220616133d), new NpgsqlTypes.NpgsqlPoint(x: 0.2845510350211893d, y: 0.6463685924176026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646987442892001d, y: 0.32473900332841854d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9318598991263732d, y: 0.6253195136766554d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058734632767792d, y: 0.6681084578783704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518319878222596d, y: 0.5116804993630493d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3151331325247605d, y: 0.8875203159724627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739208761961413d, y: 0.9126484013288795d), new NpgsqlTypes.NpgsqlPoint(x: 0.39182441804599955d, y: 0.8294796600123318d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7844071703939272d, y: 0.2087409055517725d), new NpgsqlTypes.NpgsqlPoint(x: 0.38937548653991916d, y: 0.21453433421896828d), new NpgsqlTypes.NpgsqlPoint(x: 0.8023731230149606d, y: 0.36227968779589537d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9584324283503071d, y: 0.36601804627998724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6238243948797726d, y: 0.33606835295991766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6380194175982792d, y: 0.2553140903162885d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5315781828127936d, y: 0.048954841366618984d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776572111153023d, y: 0.12160116033804058d), new NpgsqlTypes.NpgsqlPoint(x: 0.44689694302256233d, y: 0.4564080401408829d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0673248547493076d, y: 0.5300159354383117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735830917874852d, y: 0.5523274255663313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386937047413414d, y: 0.5275957742977987d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2473642325858848d, y: 0.014494195975943591d), new NpgsqlTypes.NpgsqlPoint(x: 0.7911900999205537d, y: 0.7957282996674842d), new NpgsqlTypes.NpgsqlPoint(x: 0.04776575790373594d, y: 0.18664403662077322d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30323645099240193d, y: 0.24142061429446993d), new NpgsqlTypes.NpgsqlPoint(x: 0.6053339619242839d, y: 0.45888183769001334d), new NpgsqlTypes.NpgsqlPoint(x: 0.19525568040433228d, y: 0.6788693047764999d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.645517459864839d, y: 0.5711024214537032d), new NpgsqlTypes.NpgsqlPoint(x: 0.004842933813506867d, y: 0.17963776166821077d), new NpgsqlTypes.NpgsqlPoint(x: 0.061844773898896976d, y: 0.16427730751476677d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5137322140560219d, y: 0.8891740287399063d), new NpgsqlTypes.NpgsqlPoint(x: 0.16865478960127356d, y: 0.5866136210465592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6413966443420445d, y: 0.777394117195472d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2045409980041919d, y: 0.6698355658723631d), new NpgsqlTypes.NpgsqlPoint(x: 0.6750708113501218d, y: 0.7776417217531282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6648605730802534d, y: 0.43654500400682805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7679356565415053d, y: 0.0005639681407868524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905436752082689d, y: 0.5512833990038573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9898008063410547d, y: 0.6008955606401771d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5392048528163367d, y: 0.34919118687517436d), new NpgsqlTypes.NpgsqlPoint(x: 0.008433228563175188d, y: 0.588434975473793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436512477977982d, y: 0.3631057925519824d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27054894916403704d, y: 0.11069932228894519d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493443991679373d, y: 0.6813941471042999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8858054339553444d, y: 0.6134261242835628d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6044483745418988d, y: 0.7671352701558307d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432288649400017d, y: 0.7470775248284206d), new NpgsqlTypes.NpgsqlPoint(x: 0.46038695597371426d, y: 0.776494172592368d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8871714205851657d, y: 0.8488178552215635d), new NpgsqlTypes.NpgsqlPoint(x: 0.2754774879051789d, y: 0.35641807086368604d), new NpgsqlTypes.NpgsqlPoint(x: 0.6615735666633017d, y: 0.7345468760553774d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.585635162413732d, y: 0.37813369981374045d), new NpgsqlTypes.NpgsqlPoint(x: 0.023206463362001162d, y: 0.875668345824336d), new NpgsqlTypes.NpgsqlPoint(x: 0.3210615725469239d, y: 0.9156468044842918d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19427702257550206d, y: 0.5819776526911832d), new NpgsqlTypes.NpgsqlPoint(x: 0.21447374189408186d, y: 0.8124454364122827d), new NpgsqlTypes.NpgsqlPoint(x: 0.2701634819921588d, y: 0.532557978159861d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9749422109436973d, y: 0.15454043565076314d), new NpgsqlTypes.NpgsqlPoint(x: 0.37154007749102935d, y: 0.6333252516565409d), new NpgsqlTypes.NpgsqlPoint(x: 0.12520364125582872d, y: 0.06348881340620782d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10245671380080867d, y: 0.9692548509821167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9984461261703524d, y: 0.37862298259971705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375927095395826d, y: 0.5904827657422504d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8301574683706152d, y: 0.18775143765682245d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185461076632811d, y: 0.5749985129278873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492622007681649d, y: 0.9012990000757549d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3246108761596903d, y: 0.7288760366276402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9699895137381835d, y: 0.40542356615717123d), new NpgsqlTypes.NpgsqlPoint(x: 0.3435999551271187d, y: 0.9371718452729327d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.343161735684511d, y: 0.458815995146178d), new NpgsqlTypes.NpgsqlPoint(x: 0.538350833094368d, y: 0.44537569496282026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572381929203697d, y: 0.5340736600186149d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8090948591084787d, y: 0.6163124340735835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098121497153153d, y: 0.8627954042169979d), new NpgsqlTypes.NpgsqlPoint(x: 0.12505127031572605d, y: 0.40530187143211605d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44755093047700945d, y: 0.655329091589273d), new NpgsqlTypes.NpgsqlPoint(x: 0.42358191761278463d, y: 0.6043334373296122d), new NpgsqlTypes.NpgsqlPoint(x: 0.45543457001605203d, y: 0.9795804623955411d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4268196886509975d, y: 0.16713558284948227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7509431042243675d, y: 0.07837008805442092d), new NpgsqlTypes.NpgsqlPoint(x: 0.906990081986714d, y: 0.7414164888380965d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6726455520813331d, y: 0.4273438107692469d), new NpgsqlTypes.NpgsqlPoint(x: 0.16645428259897888d, y: 0.10502145422285858d), new NpgsqlTypes.NpgsqlPoint(x: 0.05057393502765817d, y: 0.15813287383446384d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3707724264517348d, y: 0.4329821708017064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8229893932855395d, y: 0.17505078340708802d), new NpgsqlTypes.NpgsqlPoint(x: 0.3987380470195033d, y: 0.32217528741201906d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.520212116371237d, y: 0.974542029793739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454734808696908d, y: 0.9610091880433399d), new NpgsqlTypes.NpgsqlPoint(x: 0.03472822838825962d, y: 0.3140398989379338d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5500034336588604d, y: 0.4632670850052051d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624060313065409d, y: 0.09961940337640818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673980939869323d, y: 0.20981115741097567d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6470710725977106d, y: 0.6632142868128237d), new NpgsqlTypes.NpgsqlPoint(x: 0.4291969338613498d, y: 0.7058008563327429d), new NpgsqlTypes.NpgsqlPoint(x: 0.2613583320489993d, y: 0.1935048606841313d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7924109901630942d, y: 0.45337151421046695d), new NpgsqlTypes.NpgsqlPoint(x: 0.06309528787636076d, y: 0.46440663905371626d), new NpgsqlTypes.NpgsqlPoint(x: 0.373817769473176d, y: 0.7219224244997174d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5758886103263515d, y: 0.4554411254114562d), new NpgsqlTypes.NpgsqlPoint(x: 0.4765266238193028d, y: 0.5020388106470647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7694965780124994d, y: 0.7134755067899055d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8194362121027464d, y: 0.46156980434186434d), new NpgsqlTypes.NpgsqlPoint(x: 0.3716819352166393d, y: 0.8140827351770547d), new NpgsqlTypes.NpgsqlPoint(x: 0.786951323713522d, y: 0.8756354567343273d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.078395089055466d, y: 0.6450103512823925d), new NpgsqlTypes.NpgsqlPoint(x: 0.23045362972370365d, y: 0.611165857977606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8415587112351016d, y: 0.3821638228865708d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21386159112184644d, y: 0.47454936641939693d), new NpgsqlTypes.NpgsqlPoint(x: 0.7542667503225298d, y: 0.7652206727269057d), new NpgsqlTypes.NpgsqlPoint(x: 0.7664429896970343d, y: 0.26027136277135676d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36085192422931367d, y: 0.48703033259608075d), new NpgsqlTypes.NpgsqlPoint(x: 0.17022933268287843d, y: 0.7372083056325244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201203021746212d, y: 0.3520266527857603d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3487338299602356d, y: 0.5965035922573398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5300946096358689d, y: 0.31711931544395544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459652991068557d, y: 0.3820666491052519d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44899533711848394d, y: 0.7059749422060356d), new NpgsqlTypes.NpgsqlPoint(x: 0.4900228222206685d, y: 0.8509304895329465d), new NpgsqlTypes.NpgsqlPoint(x: 0.18939531987614222d, y: 0.8293980454601607d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13116531639445927d, y: 0.37215224240886036d), new NpgsqlTypes.NpgsqlPoint(x: 0.10106588242391312d, y: 0.3308786070254195d), new NpgsqlTypes.NpgsqlPoint(x: 0.632546779018407d, y: 0.8781751358066193d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5644813508871295d, y: 0.7426487222300279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9820169182896679d, y: 0.43701749774270926d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017008249052279378d, y: 0.07959776718252476d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9245398007879125d, y: 0.8644854832199786d), new NpgsqlTypes.NpgsqlPoint(x: 0.20631216667901897d, y: 0.30364012822089836d), new NpgsqlTypes.NpgsqlPoint(x: 0.35619092927427687d, y: 0.8505347174182524d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04708562232803626d, y: 0.6450693928124208d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693944583828437d, y: 0.1552467270768153d), new NpgsqlTypes.NpgsqlPoint(x: 0.456524354587336d, y: 0.4558992519724646d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8361915245737928d, y: 0.481624235707102d), new NpgsqlTypes.NpgsqlPoint(x: 0.17262609396456308d, y: 0.04225387046630846d), new NpgsqlTypes.NpgsqlPoint(x: 0.05567858766985112d, y: 0.6052491480241592d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9209408452522998d, y: 0.6081461269196401d), new NpgsqlTypes.NpgsqlPoint(x: 0.19679483404452003d, y: 0.7239335016421055d), new NpgsqlTypes.NpgsqlPoint(x: 0.42469785378710856d, y: 0.054309911151212975d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32448506816396894d, y: 0.1792629072830706d), new NpgsqlTypes.NpgsqlPoint(x: 0.14171493854424067d, y: 0.3506595673924181d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314347423139546d, y: 0.9699547943394248d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08461721362412478d, y: 0.5586908444599411d), new NpgsqlTypes.NpgsqlPoint(x: 0.9329347158391772d, y: 0.5477469487715587d), new NpgsqlTypes.NpgsqlPoint(x: 0.16431623267768936d, y: 0.02485397209935425d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09522422934641883d, y: 0.7064062563246951d), new NpgsqlTypes.NpgsqlPoint(x: 0.45623095501452116d, y: 0.7779055035532867d), new NpgsqlTypes.NpgsqlPoint(x: 0.13124751715796534d, y: 0.16418404649291563d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6373706479223946d, y: 0.8196921076827646d), new NpgsqlTypes.NpgsqlPoint(x: 0.29414173258810405d, y: 0.12621766093597797d), new NpgsqlTypes.NpgsqlPoint(x: 0.2981496647222036d, y: 0.809177361790674d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9982435138248603d, y: 0.27624368428396895d), new NpgsqlTypes.NpgsqlPoint(x: 0.2911466118028523d, y: 0.4361404285394581d), new NpgsqlTypes.NpgsqlPoint(x: 0.30120189413767284d, y: 0.24793426425575749d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6137452959838695d, y: 0.17327622508983398d), new NpgsqlTypes.NpgsqlPoint(x: 0.11607866641364462d, y: 0.18713217088572498d), new NpgsqlTypes.NpgsqlPoint(x: 0.9621038465375619d, y: 0.8499761134062116d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7965097949797162d, y: 0.045018621467214026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9696568741180276d, y: 0.36883074976692487d), new NpgsqlTypes.NpgsqlPoint(x: 0.8117039282106403d, y: 0.9896453248048523d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7920392612589291d, y: 0.04003615323953891d), new NpgsqlTypes.NpgsqlPoint(x: 0.4615847879647683d, y: 0.8314140609216438d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899218703720252d, y: 0.38537723111116085d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.282728985064562d, y: 0.13881856304103546d), new NpgsqlTypes.NpgsqlPoint(x: 0.34255352389826454d, y: 0.819864715021372d), new NpgsqlTypes.NpgsqlPoint(x: 0.36588349233425466d, y: 0.6450839944146725d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16738334107325892d, y: 0.5995275711614613d), new NpgsqlTypes.NpgsqlPoint(x: 0.8271489153043825d, y: 0.94772978429411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3124495897030828d, y: 0.4801395224861169d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5180765784359617d, y: 0.2751908098297128d), new NpgsqlTypes.NpgsqlPoint(x: 0.17754231797073183d, y: 0.17217316331458699d), new NpgsqlTypes.NpgsqlPoint(x: 0.2527323455593694d, y: 0.7527428331084345d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8553161657162254d, y: 0.7605719613581782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5470728866424481d, y: 0.43992085587171503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589094604282193d, y: 0.92194462362525d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.150670546984232d, y: 0.6976667735837616d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286838228537809d, y: 0.7235288422402363d), new NpgsqlTypes.NpgsqlPoint(x: 0.25500080118563084d, y: 0.08596115416760974d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9358304551897404d, y: 0.3977489469265435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8060845806401086d, y: 0.7173077905233244d), new NpgsqlTypes.NpgsqlPoint(x: 0.07956760865393031d, y: 0.33480495578644487d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5950033911116798d, y: 0.4497165273454672d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872899401663953d, y: 0.22682122364689794d), new NpgsqlTypes.NpgsqlPoint(x: 0.4439307379632875d, y: 0.5966803958620055d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11017487444010277d, y: 0.519544901976683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5478064966219385d, y: 0.3474403800995145d), new NpgsqlTypes.NpgsqlPoint(x: 0.04229010542717737d, y: 0.9234868280916781d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3857515474568346d, y: 0.7465819215937869d), new NpgsqlTypes.NpgsqlPoint(x: 0.0030137703280218586d, y: 0.2639622688965819d), new NpgsqlTypes.NpgsqlPoint(x: 0.9108045560365317d, y: 0.4152319729556154d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16136487154517754d, y: 0.8550763705372852d), new NpgsqlTypes.NpgsqlPoint(x: 0.7482651679422131d, y: 0.2468091119878595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6777885123818146d, y: 0.8185924453468777d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10132441644241241d, y: 0.9165984731723332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445720322264918d, y: 0.34062436497976d), new NpgsqlTypes.NpgsqlPoint(x: 0.6835455498102341d, y: 0.9416520038291509d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7632694921977591d, y: 0.34545211630782124d), new NpgsqlTypes.NpgsqlPoint(x: 0.35983457024008136d, y: 0.331800186621517d), new NpgsqlTypes.NpgsqlPoint(x: 0.26527437057436964d, y: 0.35368641135223255d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13631616881229558d, y: 0.028463897920609993d), new NpgsqlTypes.NpgsqlPoint(x: 0.18703820560622864d, y: 0.9585853999180725d), new NpgsqlTypes.NpgsqlPoint(x: 0.9463674657215574d, y: 0.9982859451182504d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39365361097918683d, y: 0.9634724174977588d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023818297182296d, y: 0.25939608904608d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293544396951243d, y: 0.9045947884161265d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1688788076907084d, y: 0.9369948672164483d), new NpgsqlTypes.NpgsqlPoint(x: 0.09093352457487003d, y: 0.4442372308354271d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137439774673272d, y: 0.7136697412176136d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25427222687100404d, y: 0.22944810005678695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6884882666663744d, y: 0.583517088616027d), new NpgsqlTypes.NpgsqlPoint(x: 0.1263000338821112d, y: 0.6317921287794086d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1314010458407503d, y: 0.382589428081776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256986580179291d, y: 0.6025473682914799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6245034275814023d, y: 0.43481629506387454d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.043576346647928865d, y: 0.701106089548314d), new NpgsqlTypes.NpgsqlPoint(x: 0.9935388916833153d, y: 0.4346646755510263d), new NpgsqlTypes.NpgsqlPoint(x: 0.05291940070340084d, y: 0.20961663544951303d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5346987496502213d, y: 0.06659720482744447d), new NpgsqlTypes.NpgsqlPoint(x: 0.8819893669239367d, y: 0.3173968132782994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652829889171793d, y: 0.0483363235469616d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1917880966784865d, y: 0.712819644143389d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598920676664364d, y: 0.31279213474761425d), new NpgsqlTypes.NpgsqlPoint(x: 0.28627645665316137d, y: 0.7855488133145904d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22634991559179773d, y: 0.6365786139307807d), new NpgsqlTypes.NpgsqlPoint(x: 0.26989910040548715d, y: 0.9744926614929916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5755861899278611d, y: 0.9033666173372996d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3465524915013197d, y: 0.28284250625094887d), new NpgsqlTypes.NpgsqlPoint(x: 0.4383426683082595d, y: 0.16920359984075894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5024126815435229d, y: 0.06638755523925344d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7776601712850844d, y: 0.6103962769622489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5201510299305085d, y: 0.5376003929189003d), new NpgsqlTypes.NpgsqlPoint(x: 0.07384392017945529d, y: 0.28484716548540656d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3879799591066452d, y: 0.3577387180421797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469154753486251d, y: 0.7086531586171388d), new NpgsqlTypes.NpgsqlPoint(x: 0.701874486664213d, y: 0.15350739122970403d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.599535098016065d, y: 0.5836937748210215d), new NpgsqlTypes.NpgsqlPoint(x: 0.22963920537922988d, y: 0.540412276817874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220382541690511d, y: 0.20594202940790596d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49187521408787904d, y: 0.023036160660503846d), new NpgsqlTypes.NpgsqlPoint(x: 0.34256640462222565d, y: 0.24954344486390334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6447643455582273d, y: 0.9159174196036511d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6870384894016983d, y: 0.8607894080282648d), new NpgsqlTypes.NpgsqlPoint(x: 0.2709859977881858d, y: 0.50708588967027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8834621776532645d, y: 0.42232318445912775d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4365531004966344d, y: 0.8117608247538071d), new NpgsqlTypes.NpgsqlPoint(x: 0.4397660009112765d, y: 0.3830924993479784d), new NpgsqlTypes.NpgsqlPoint(x: 0.197314638728183d, y: 0.6825464761826591d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5317165921380765d, y: 0.31582359272506655d), new NpgsqlTypes.NpgsqlPoint(x: 0.10340990215300949d, y: 0.5473525269943799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7964302410206181d, y: 0.9341703963246072d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8583002707145573d, y: 0.08011168530786572d), new NpgsqlTypes.NpgsqlPoint(x: 0.7847182639795194d, y: 0.5522543415921073d), new NpgsqlTypes.NpgsqlPoint(x: 0.7641735669981672d, y: 0.5562589460919146d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06618056264095318d, y: 0.7618681735071318d), new NpgsqlTypes.NpgsqlPoint(x: 0.6790044925473878d, y: 0.7723142371627881d), new NpgsqlTypes.NpgsqlPoint(x: 0.39984903596180277d, y: 0.21597784712714974d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4904735535947098d, y: 0.7568718962422782d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021693396442961d, y: 0.8456041848087429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7608729406481265d, y: 0.9699754025053218d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4531491755152687d, y: 0.05030550076859741d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886271918101311d, y: 0.7735907239742361d), new NpgsqlTypes.NpgsqlPoint(x: 0.06584433947426849d, y: 0.998969576609968d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3464127014581643d, y: 0.6528378089838652d), new NpgsqlTypes.NpgsqlPoint(x: 0.14657474536391613d, y: 0.47707842823150826d), new NpgsqlTypes.NpgsqlPoint(x: 0.25557861120637826d, y: 0.6456767822960199d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20930034134268238d, y: 0.6349995261120677d), new NpgsqlTypes.NpgsqlPoint(x: 0.11121355957842949d, y: 0.6196009216050812d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772780813427072d, y: 0.6390892227398101d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8010182207737968d, y: 0.00117771897029062d), new NpgsqlTypes.NpgsqlPoint(x: 0.49737709798164464d, y: 0.6592890073596909d), new NpgsqlTypes.NpgsqlPoint(x: 0.8356440596666711d, y: 0.9560798223341291d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.140670824505707d, y: 0.910686928707313d), new NpgsqlTypes.NpgsqlPoint(x: 0.3000735162750706d, y: 0.472159292394278d), new NpgsqlTypes.NpgsqlPoint(x: 0.3481930047337799d, y: 0.05887167332908272d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.432370184699565d, y: 0.37893641717880466d), new NpgsqlTypes.NpgsqlPoint(x: 0.07389343819218486d, y: 0.8828484685115837d), new NpgsqlTypes.NpgsqlPoint(x: 0.4046337255442305d, y: 0.28976223343025886d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18043327590796776d, y: 0.03304008016830706d), new NpgsqlTypes.NpgsqlPoint(x: 0.588719937329502d, y: 0.5847139808100961d), new NpgsqlTypes.NpgsqlPoint(x: 0.20384312998045484d, y: 0.3086301399438208d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8744300237693295d, y: 0.36421744676839796d), new NpgsqlTypes.NpgsqlPoint(x: 0.5553782611390627d, y: 0.3909596977436084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144254292869694d, y: 0.5692745323843549d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2858179178201363d, y: 0.27689780470151637d), new NpgsqlTypes.NpgsqlPoint(x: 0.21690615215533748d, y: 0.723713929903711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163449258409488d, y: 0.09950673737449034d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19292455587023827d, y: 0.3901827360980089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273483524804511d, y: 0.4545752308707075d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492697039801936d, y: 0.49808636451601207d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5879774084471227d, y: 0.5763333661050597d), new NpgsqlTypes.NpgsqlPoint(x: 0.31689611049262534d, y: 0.11418771558355045d), new NpgsqlTypes.NpgsqlPoint(x: 0.31801231545936404d, y: 0.09133222325130741d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26832392622665413d, y: 0.5041467673024045d), new NpgsqlTypes.NpgsqlPoint(x: 0.15825478503677126d, y: 0.0069612396862889225d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445019638522034d, y: 0.16660131570912706d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5272277240513517d, y: 0.8876677833138955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5088201540000431d, y: 0.6551818795633294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324673921443979d, y: 0.4711887385659106d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.89693851172257d, y: 0.5309585227059429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7040944145675422d, y: 0.00021878323246804499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520590121103825d, y: 0.11560914553357671d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2532376165671181d, y: 0.019735567555616007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8157840398112073d, y: 0.6452649757272628d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888916091193181d, y: 0.9111569664328585d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6181259102318871d, y: 0.5779645125187514d), new NpgsqlTypes.NpgsqlPoint(x: 0.3510948841918511d, y: 0.9769618528122516d), new NpgsqlTypes.NpgsqlPoint(x: 0.12375212897298427d, y: 0.7344391617258257d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43747177399491743d, y: 0.274739878403539d), new NpgsqlTypes.NpgsqlPoint(x: 0.13298216617250613d, y: 0.010052066206564292d), new NpgsqlTypes.NpgsqlPoint(x: 0.18425176540428057d, y: 0.02982998397782688d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9669981277223972d, y: 0.11466781995041775d), new NpgsqlTypes.NpgsqlPoint(x: 0.4302145910503329d, y: 0.48772863481514905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3409148379891609d, y: 0.22515296229972648d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9568844681906375d, y: 0.9275443789902695d), new NpgsqlTypes.NpgsqlPoint(x: 0.013104426582987272d, y: 0.7932517454688653d), new NpgsqlTypes.NpgsqlPoint(x: 0.4010126580464368d, y: 0.9949301597778268d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9458155098652212d, y: 0.08382852480959346d), new NpgsqlTypes.NpgsqlPoint(x: 0.35686988095613914d, y: 0.338151113815203d), new NpgsqlTypes.NpgsqlPoint(x: 0.718421292041933d, y: 0.17100946228403957d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4044159335285422d, y: 0.7748548485688256d), new NpgsqlTypes.NpgsqlPoint(x: 0.022271704995936892d, y: 0.8616396691091732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944694962040308d, y: 0.8050167038935208d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5328947919674292d, y: 0.3322864707637121d), new NpgsqlTypes.NpgsqlPoint(x: 0.23626597190622423d, y: 0.584027996638017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164166548457026d, y: 0.8961791147302512d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06583292105361593d, y: 0.5748984072133085d), new NpgsqlTypes.NpgsqlPoint(x: 0.26050287788306414d, y: 0.2852340213462481d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662422382325447d, y: 0.279600526995207d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11479427385928165d, y: 0.20082266597810017d), new NpgsqlTypes.NpgsqlPoint(x: 0.526401297821131d, y: 0.49649174645108984d), new NpgsqlTypes.NpgsqlPoint(x: 0.17968356041951128d, y: 0.43636850193699483d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10793184728985716d, y: 0.7650600218531708d), new NpgsqlTypes.NpgsqlPoint(x: 0.9706272050847251d, y: 0.4617847572032222d), new NpgsqlTypes.NpgsqlPoint(x: 0.32455061450308376d, y: 0.4657902503136693d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45063660812592254d, y: 0.5751585482522861d), new NpgsqlTypes.NpgsqlPoint(x: 0.13076665139460109d, y: 0.9456477658000129d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118724683872756d, y: 0.4092187726352643d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7485415677544494d, y: 0.924777391200551d), new NpgsqlTypes.NpgsqlPoint(x: 0.4713965297345779d, y: 0.8470338008171105d), new NpgsqlTypes.NpgsqlPoint(x: 0.15811037174355003d, y: 0.017183351542081837d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9069920549761361d, y: 0.8384288327710455d), new NpgsqlTypes.NpgsqlPoint(x: 0.1667347526142816d, y: 0.0035284211599354576d), new NpgsqlTypes.NpgsqlPoint(x: 0.27925447611828835d, y: 0.6059327468767213d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6381729321645617d, y: 0.42243905890903155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8839822700288329d, y: 0.2958193060246226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8173731996887437d, y: 0.8348735552750989d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.744004858426739d, y: 0.5050783631970052d), new NpgsqlTypes.NpgsqlPoint(x: 0.43127689991168594d, y: 0.5358876284385568d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397121430005353d, y: 0.06446456081669472d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4883382279717233d, y: 0.643077447631208d), new NpgsqlTypes.NpgsqlPoint(x: 0.4865391261571027d, y: 0.05695674549183749d), new NpgsqlTypes.NpgsqlPoint(x: 0.2534723978307596d, y: 0.17453638090130597d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5150737401964773d, y: 0.14331530047774665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5414588442759755d, y: 0.6442164837855431d), new NpgsqlTypes.NpgsqlPoint(x: 0.04050372743632502d, y: 0.28739916607118265d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16399094635318d, y: 0.5041050547469578d), new NpgsqlTypes.NpgsqlPoint(x: 0.3018913437107048d, y: 0.7984071289080816d), new NpgsqlTypes.NpgsqlPoint(x: 0.967178991183223d, y: 0.9719437080573168d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45854013353586687d, y: 0.34557820052057797d), new NpgsqlTypes.NpgsqlPoint(x: 0.2913240000651557d, y: 0.46390229680502215d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966361549221501d, y: 0.21039896232774025d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9780583240061492d, y: 0.6686661238546179d), new NpgsqlTypes.NpgsqlPoint(x: 0.5998825165330222d, y: 0.930968562783262d), new NpgsqlTypes.NpgsqlPoint(x: 0.7244442055381728d, y: 0.4882775708414321d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8040621394787157d, y: 0.7857579017441642d), new NpgsqlTypes.NpgsqlPoint(x: 0.036534402041258573d, y: 0.6808188352394254d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840760893149289d, y: 0.9517678839807756d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6781520628271295d, y: 0.9273817751513289d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494580044549939d, y: 0.7501164636673745d), new NpgsqlTypes.NpgsqlPoint(x: 0.4316678732598934d, y: 0.3645333080911257d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2691971268122544d, y: 0.7756991133929878d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005790955505587d, y: 0.3453503839816259d), new NpgsqlTypes.NpgsqlPoint(x: 0.8228235900360168d, y: 0.11357477150561357d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9204430530793152d, y: 0.9309016434833614d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469439444654074d, y: 0.48864186063649473d), new NpgsqlTypes.NpgsqlPoint(x: 0.6410622464051762d, y: 0.9299197429517475d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6236873263887515d, y: 0.9052554424860921d), new NpgsqlTypes.NpgsqlPoint(x: 0.445787608713769d, y: 0.7674965488005645d), new NpgsqlTypes.NpgsqlPoint(x: 0.5851598190492847d, y: 0.6904324596327315d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21359829339877756d, y: 0.6789957114794654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338154714563159d, y: 0.7620570200322048d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967239141412835d, y: 0.6952144492677463d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7608767092895622d, y: 0.9683393724642851d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213849826547191d, y: 0.2285328074012105d), new NpgsqlTypes.NpgsqlPoint(x: 0.7502908143352331d, y: 0.4709387087202349d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4800955530722161d, y: 0.788932956688589d), new NpgsqlTypes.NpgsqlPoint(x: 0.1860031489537911d, y: 0.8741630907699528d), new NpgsqlTypes.NpgsqlPoint(x: 0.531209848107725d, y: 0.17105573962644127d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6695089109871d, y: 0.8779667677122286d), new NpgsqlTypes.NpgsqlPoint(x: 0.18515282324718874d, y: 0.7814810886356715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6579010791891775d, y: 0.02377704992739016d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7437571549659828d, y: 0.038519103976568214d), new NpgsqlTypes.NpgsqlPoint(x: 0.3792204049604745d, y: 0.7934520788210764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9155773826273846d, y: 0.8269170268466531d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.018720677372335515d, y: 0.9487409531290892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189145599130818d, y: 0.828534291976446d), new NpgsqlTypes.NpgsqlPoint(x: 0.24906925866968177d, y: 0.9358500592699267d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7597380709992292d, y: 0.9130391083643393d), new NpgsqlTypes.NpgsqlPoint(x: 0.663540845829459d, y: 0.1389843459088801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5406413424677352d, y: 0.6634985775001444d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9939417120170327d, y: 0.40051593952820963d), new NpgsqlTypes.NpgsqlPoint(x: 0.25683475124964616d, y: 0.42325801572511634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9155064503898107d, y: 0.9989902949352613d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7798933923834364d, y: 0.10974668928549725d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551932199057443d, y: 0.7608233780566327d), new NpgsqlTypes.NpgsqlPoint(x: 0.061122164092832665d, y: 0.6231251365196514d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5775896594005998d, y: 0.539037134860341d), new NpgsqlTypes.NpgsqlPoint(x: 0.09563758316764293d, y: 0.3908490890846045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8277776827307358d, y: 0.03736074645715193d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38329982708640964d, y: 0.38927885743766233d), new NpgsqlTypes.NpgsqlPoint(x: 0.20181486583435737d, y: 0.803026398234313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6632967066803303d, y: 0.15644848375937093d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7663468549331799d, y: 0.07857493901902557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486540374139592d, y: 0.5725319008607208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6210280287628345d, y: 0.927515591638646d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3834886276037752d, y: 0.4406201843842169d), new NpgsqlTypes.NpgsqlPoint(x: 0.923519754492426d, y: 0.8300019878236549d), new NpgsqlTypes.NpgsqlPoint(x: 0.1613886615653124d, y: 0.406098063502076d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20305543166153106d, y: 0.8009790553511321d), new NpgsqlTypes.NpgsqlPoint(x: 0.8867367567727702d, y: 0.16537940337401835d), new NpgsqlTypes.NpgsqlPoint(x: 0.27747133154764814d, y: 0.8758192407915969d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4423969707568426d, y: 0.7730029131605792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914230396625966d, y: 0.28629926444911535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9333982322626525d, y: 0.09760861422426137d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8934997463983162d, y: 0.2753891489997161d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928399526824894d, y: 0.3783170046005867d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521125842958713d, y: 0.4041862943537057d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6300899104108616d, y: 0.9308032606269465d), new NpgsqlTypes.NpgsqlPoint(x: 0.30832470918775434d, y: 0.3617475921621073d), new NpgsqlTypes.NpgsqlPoint(x: 0.039498260871414725d, y: 0.9156084100971401d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36628498563260226d, y: 0.2532130454977227d), new NpgsqlTypes.NpgsqlPoint(x: 0.8786603362666985d, y: 0.004729656170831098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7516675339929253d, y: 0.6353878693695099d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8415294000892796d, y: 0.34006432952185117d), new NpgsqlTypes.NpgsqlPoint(x: 0.48570346904463d, y: 0.19759415164185468d), new NpgsqlTypes.NpgsqlPoint(x: 0.23591014026290147d, y: 0.14509727928179905d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.55150597488755d, y: 0.023504252152676597d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651676777415035d, y: 0.5385800407059629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5569036869885834d, y: 0.4922411181069425d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9102266835224483d, y: 0.2787443945691924d), new NpgsqlTypes.NpgsqlPoint(x: 0.022389296033373363d, y: 0.29669357079582537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835792433370291d, y: 0.9374116965834539d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23516711459584083d, y: 0.5974630016234213d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132332558637609d, y: 0.05053318364919557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808931760950018d, y: 0.09629061429936003d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7922395223694092d, y: 0.6586402893237128d), new NpgsqlTypes.NpgsqlPoint(x: 0.03293907891334513d, y: 0.2812550904517863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737605941331237d, y: 0.1715926340370847d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05701858426523143d, y: 0.774818158775411d), new NpgsqlTypes.NpgsqlPoint(x: 0.06436353813822582d, y: 0.1606830484681493d), new NpgsqlTypes.NpgsqlPoint(x: 0.732016348056974d, y: 0.6698868004759084d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36096773670345583d, y: 0.8448260636677835d), new NpgsqlTypes.NpgsqlPoint(x: 0.34995137211808325d, y: 0.14315238101480832d), new NpgsqlTypes.NpgsqlPoint(x: 0.6592710877829191d, y: 0.7270472796990369d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3092949745377057d, y: 0.32609825174482265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9916806112060355d, y: 0.9621963355985934d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991812260724608d, y: 0.08460876055505484d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08763529635119705d, y: 0.9739824978283104d), new NpgsqlTypes.NpgsqlPoint(x: 0.26478710348896217d, y: 0.8700407592429363d), new NpgsqlTypes.NpgsqlPoint(x: 0.08318611628977579d, y: 0.06019546559708988d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8882386439797845d, y: 0.07184876655136041d), new NpgsqlTypes.NpgsqlPoint(x: 0.7928576160820053d, y: 0.9209301178059837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5310626179456238d, y: 0.09074504159104668d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11351818251234291d, y: 0.4751727409508778d), new NpgsqlTypes.NpgsqlPoint(x: 0.7320462111960377d, y: 0.8723181024804569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464370067235016d, y: 0.43769688417378916d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6077601236123977d, y: 0.41778412696397127d), new NpgsqlTypes.NpgsqlPoint(x: 0.8085635266422367d, y: 0.10863863150239061d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817411093700979d, y: 0.3866457669254586d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7472895420271392d, y: 0.6738727669306688d), new NpgsqlTypes.NpgsqlPoint(x: 0.15068791934600612d, y: 0.3613183428672192d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625328393822671d, y: 0.7096156323909071d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4836951559946584d, y: 0.14452714128394462d), new NpgsqlTypes.NpgsqlPoint(x: 0.8356222893403911d, y: 0.2444335521847465d), new NpgsqlTypes.NpgsqlPoint(x: 0.17126637119008892d, y: 0.5306689051298237d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16652506016969026d, y: 0.9473477379350925d), new NpgsqlTypes.NpgsqlPoint(x: 0.04829843781673915d, y: 0.11041291445952262d), new NpgsqlTypes.NpgsqlPoint(x: 0.12938737874207074d, y: 0.6326199746040768d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3449165597074505d, y: 0.9191578732401103d), new NpgsqlTypes.NpgsqlPoint(x: 0.6628811275900551d, y: 0.4491255746175187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114695844980901d, y: 0.8105155214860172d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.330457295715878d, y: 0.03291333552064146d), new NpgsqlTypes.NpgsqlPoint(x: 0.22640371823559557d, y: 0.13759640135188977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6642259633155726d, y: 0.4590864993383068d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9242465193895892d, y: 0.1532090094878571d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760273237001169d, y: 0.7998028614673937d), new NpgsqlTypes.NpgsqlPoint(x: 0.050579302040971275d, y: 0.3711482511399695d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4348261051503589d, y: 0.9756665571629097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383262446572616d, y: 0.9895728489063594d), new NpgsqlTypes.NpgsqlPoint(x: 0.1368174360597476d, y: 0.7290838070402232d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15706036709549087d, y: 0.04641920061249971d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855553952075534d, y: 0.7103236360982741d), new NpgsqlTypes.NpgsqlPoint(x: 0.22408822800158867d, y: 0.4614296051976199d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40582704938186753d, y: 0.20339902657579179d), new NpgsqlTypes.NpgsqlPoint(x: 0.5783501632374201d, y: 0.3832683928885473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7953180919838759d, y: 0.38428210081649994d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23487020143647752d, y: 0.3837071205981515d), new NpgsqlTypes.NpgsqlPoint(x: 0.4934355633193598d, y: 0.6313759986776231d), new NpgsqlTypes.NpgsqlPoint(x: 0.26569236025839404d, y: 0.8908050416968707d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2372801344077936d, y: 0.1931446069379864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486258335295792d, y: 0.4051009443978254d), new NpgsqlTypes.NpgsqlPoint(x: 0.811140086793633d, y: 0.27850855065009006d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21702177394627764d, y: 0.9525648142104236d), new NpgsqlTypes.NpgsqlPoint(x: 0.6185003756608356d, y: 0.043563730124844824d), new NpgsqlTypes.NpgsqlPoint(x: 0.11333091208458135d, y: 0.4053661519131131d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22549703440357316d, y: 0.871971652118401d), new NpgsqlTypes.NpgsqlPoint(x: 0.06685056695716385d, y: 0.09042619731716117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778293019561167d, y: 0.35713698567108243d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9774701612349347d, y: 0.6874352267234141d), new NpgsqlTypes.NpgsqlPoint(x: 0.23819190217931407d, y: 0.34955665761651555d), new NpgsqlTypes.NpgsqlPoint(x: 0.18442780676991233d, y: 0.2425470065951314d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4469524191797992d, y: 0.9891385047794118d), new NpgsqlTypes.NpgsqlPoint(x: 0.06542821734935911d, y: 0.38828766450674346d), new NpgsqlTypes.NpgsqlPoint(x: 0.47273851424181246d, y: 0.28538959319318125d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7348884333198492d, y: 0.18655310803130254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8765949317981342d, y: 0.6541875568059142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989318209991523d, y: 0.6500153607008917d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5027135692030368d, y: 0.01346806125855149d), new NpgsqlTypes.NpgsqlPoint(x: 0.3370434542643168d, y: 0.8031807249901856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9553515862615609d, y: 0.7951795868632199d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05791867769317505d, y: 0.4358674793520918d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335212237909702d, y: 0.9347905156626433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5806070099537239d, y: 0.9883887478838319d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5592554049351434d, y: 0.9310133049509708d), new NpgsqlTypes.NpgsqlPoint(x: 0.2973924721046327d, y: 0.755814575599704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133525913232721d, y: 0.6705767884542713d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5396110709292843d, y: 0.584244147983528d), new NpgsqlTypes.NpgsqlPoint(x: 0.23580928312958815d, y: 0.2855978205237888d), new NpgsqlTypes.NpgsqlPoint(x: 0.25293255664386927d, y: 0.8721805171823918d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4495297390650095d, y: 0.018224332927772147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156125687546067d, y: 0.07423412613245028d), new NpgsqlTypes.NpgsqlPoint(x: 0.7226518684451599d, y: 0.5078998964928292d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7698620948227843d, y: 0.3137121525508232d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494637033444759d, y: 0.7189297597261722d), new NpgsqlTypes.NpgsqlPoint(x: 0.2200613568210822d, y: 0.9671010453726893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5598243781313667d, y: 0.6549653673178105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4425964507272978d, y: 0.10701335439368576d), new NpgsqlTypes.NpgsqlPoint(x: 0.33983832626609833d, y: 0.9799248618608855d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4430716829123924d, y: 0.9204114760928196d), new NpgsqlTypes.NpgsqlPoint(x: 0.9804215549615707d, y: 0.6326987526350792d), new NpgsqlTypes.NpgsqlPoint(x: 0.11488977697066227d, y: 0.5613047916065217d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18267026373857476d, y: 0.6548601212544316d), new NpgsqlTypes.NpgsqlPoint(x: 0.3188642973265574d, y: 0.059485262258686444d), new NpgsqlTypes.NpgsqlPoint(x: 0.03387658055204823d, y: 0.1435246077248713d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06191167931719477d, y: 0.5103732441645762d), new NpgsqlTypes.NpgsqlPoint(x: 0.01634982378917682d, y: 0.8580651590650928d), new NpgsqlTypes.NpgsqlPoint(x: 0.639751971971308d, y: 0.9911099716070872d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7297803553027046d, y: 0.6818930067259047d), new NpgsqlTypes.NpgsqlPoint(x: 0.18649187014123725d, y: 0.8585587756094258d), new NpgsqlTypes.NpgsqlPoint(x: 0.1920504604292368d, y: 0.46329688944369285d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42190512757783705d, y: 0.31868811305586964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4171403098445309d, y: 0.9035670784845357d), new NpgsqlTypes.NpgsqlPoint(x: 0.06528947580546862d, y: 0.25945145946532355d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32897738030634394d, y: 0.7289344099838995d), new NpgsqlTypes.NpgsqlPoint(x: 0.503602347500239d, y: 0.6220205258586855d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102654959431531d, y: 0.9984093310592448d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.567703797813782d, y: 0.6318979108790582d), new NpgsqlTypes.NpgsqlPoint(x: 0.10401540698847389d, y: 0.4589640299697746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6327589105616781d, y: 0.0003841031986013821d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5845996574404564d, y: 0.7839878671702737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5709654724360209d, y: 0.3308084495735616d), new NpgsqlTypes.NpgsqlPoint(x: 0.11558838208252564d, y: 0.13422032922540317d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8865126129313787d, y: 0.4992055220616133d), new NpgsqlTypes.NpgsqlPoint(x: 0.2845510350211893d, y: 0.6463685924176026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646987442892001d, y: 0.32473900332841854d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9318598991263732d, y: 0.6253195136766554d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058734632767792d, y: 0.6681084578783704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518319878222596d, y: 0.5116804993630493d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3151331325247605d, y: 0.8875203159724627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739208761961413d, y: 0.9126484013288795d), new NpgsqlTypes.NpgsqlPoint(x: 0.39182441804599955d, y: 0.8294796600123318d)),
}));
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27054894916403704d, y: 0.11069932228894519d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493443991679373d, y: 0.6813941471042999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8858054339553444d, y: 0.6134261242835628d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6044483745418988d, y: 0.7671352701558307d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432288649400017d, y: 0.7470775248284206d), new NpgsqlTypes.NpgsqlPoint(x: 0.46038695597371426d, y: 0.776494172592368d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8871714205851657d, y: 0.8488178552215635d), new NpgsqlTypes.NpgsqlPoint(x: 0.2754774879051789d, y: 0.35641807086368604d), new NpgsqlTypes.NpgsqlPoint(x: 0.6615735666633017d, y: 0.7345468760553774d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.585635162413732d, y: 0.37813369981374045d), new NpgsqlTypes.NpgsqlPoint(x: 0.023206463362001162d, y: 0.875668345824336d), new NpgsqlTypes.NpgsqlPoint(x: 0.3210615725469239d, y: 0.9156468044842918d)),
}));
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8090948591084787d, y: 0.6163124340735835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098121497153153d, y: 0.8627954042169979d), new NpgsqlTypes.NpgsqlPoint(x: 0.12505127031572605d, y: 0.40530187143211605d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44755093047700945d, y: 0.655329091589273d), new NpgsqlTypes.NpgsqlPoint(x: 0.42358191761278463d, y: 0.6043334373296122d), new NpgsqlTypes.NpgsqlPoint(x: 0.45543457001605203d, y: 0.9795804623955411d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4268196886509975d, y: 0.16713558284948227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7509431042243675d, y: 0.07837008805442092d), new NpgsqlTypes.NpgsqlPoint(x: 0.906990081986714d, y: 0.7414164888380965d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6726455520813331d, y: 0.4273438107692469d), new NpgsqlTypes.NpgsqlPoint(x: 0.16645428259897888d, y: 0.10502145422285858d), new NpgsqlTypes.NpgsqlPoint(x: 0.05057393502765817d, y: 0.15813287383446384d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
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
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 6, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 44, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 121, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 27, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 111, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 73, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatch(connection, 32, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[2], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[3], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[4], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[5], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1M>(15);

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
                ((INpgsqlPolygonArraypolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPolygonArraypolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

