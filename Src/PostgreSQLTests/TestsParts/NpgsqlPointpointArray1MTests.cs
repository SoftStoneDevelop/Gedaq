

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1504951462530688d, y: 0.6503641328115672d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3592387337246168d, y: 0.1193323296703852d),
new NpgsqlTypes.NpgsqlPoint(x: 0.045866948358948d, y: 0.4773376458223617d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.869175496516802d, y: 0.41936599718629086d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5862734439888512d, y: 0.6260718450893623d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8638329530501687d, y: 0.8277780513643399d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6382342018186576d, y: 0.18254929529673014d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.79341833707124d, y: 0.44551967614034305d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9636228169306731d, y: 0.831301344964139d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7555698195704631d, y: 0.6578019725387474d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8560574891709415d, y: 0.5416551942455963d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9819363038806203d, y: 0.33872819285832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.355361233839946d, y: 0.16484151421517423d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21455652201230646d, y: 0.08938548899202536d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2226304108757151d, y: 0.19591612462619035d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15590970322852882d, y: 0.03399636904238845d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41619389185043587d, y: 0.005064400223052434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.987572600578237d, y: 0.5741268091400834d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23277856964882637d, y: 0.18754501467226126d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3933788245206228d, y: 0.1595617170349869d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.519510848498707d, y: 0.18161905372422915d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17782842576962465d, y: 0.181979107702829d),
new NpgsqlTypes.NpgsqlPoint(x: 0.59935655923333d, y: 0.47528072683819034d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02748816325595349d, y: 0.5244333889557137d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6155724616461254d, y: 0.7091158968497268d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0678080679612535d, y: 0.16083435629415654d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21418443966105838d, y: 0.3886612611711312d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1559875741853729d, y: 0.5930803392564917d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6168510447966299d, y: 0.23252305051256117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18493571016303212d, y: 0.15437530825746681d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4500213619433888d, y: 0.28373545865656435d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6678383303021477d, y: 0.6820373299610683d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8267230581198951d, y: 0.7533530647953507d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7990485034310306d, y: 0.05509163875862644d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7265475428209964d, y: 0.3372260584862721d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3188231901417077d, y: 0.0559864816288439d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26881083148659735d, y: 0.2766924518017848d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6780563832501946d, y: 0.01122944852108465d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7748286852353292d, y: 0.5757712084286805d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9925454756232547d, y: 0.22660391668198354d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17991542080542622d, y: 0.6499262993157419d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5562507230603904d, y: 0.04039504258109117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8503265215731234d, y: 0.30778026825888405d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7820005702190957d, y: 0.9620302877659472d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0398531738075929d, y: 0.7116876703893195d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5337253522264784d, y: 0.5637869628052348d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.855829404749816d, y: 0.6066223628292395d),
new NpgsqlTypes.NpgsqlPoint(x: 0.873290892082003d, y: 0.6723290449710054d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9093424915647372d, y: 0.6314586822689932d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9571119938260233d, y: 0.4981710385647745d),
new NpgsqlTypes.NpgsqlPoint(x: 0.663749851929035d, y: 0.2412858636700077d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47755505544583576d, y: 0.5561717494384795d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31983389151179586d, y: 0.016230860455223373d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5780628945444991d, y: 0.16248950289903508d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8204625267921872d, y: 0.9910449608316209d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6214737286801317d, y: 0.3212037455206044d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9940207259791376d, y: 0.582123386138734d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5517952976660291d, y: 0.44673385313604985d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9522876888314658d, y: 0.6845789797444354d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2962214946638433d, y: 0.21875257155267258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6973477949473719d, y: 0.9064401631922989d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6608519258245378d, y: 0.8093196052237126d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16442222402283402d, y: 0.4318598320103265d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4293654183230635d, y: 0.1291059570739289d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06697698402004792d, y: 0.1956553690444537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8796301362336199d, y: 0.8395160341427695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8594728704536725d, y: 0.19943139154146494d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7334842700340978d, y: 0.25130720342369983d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5030781153105629d, y: 0.8132278216201899d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8600865165172213d, y: 0.38940762158615316d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09819643034473668d, y: 0.011120066108499582d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08137775178275963d, y: 0.7480380719150848d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43192735088262013d, y: 0.6777140374533621d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6503359170535353d, y: 0.6469900463213885d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45723318097836496d, y: 0.09782093305151873d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10503616025779794d, y: 0.034266234399635054d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9999970943896443d, y: 0.6294184188816758d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05844301643870553d, y: 0.20027652950506525d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9816776823549569d, y: 0.10043941964791103d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8480251479728732d, y: 0.067737507213119d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8040167435160204d, y: 0.29864274861082596d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14171321095595102d, y: 0.012607094972027943d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6794717011413737d, y: 0.5680352872360422d),
new NpgsqlTypes.NpgsqlPoint(x: 0.644386850818792d, y: 0.4023939003063163d),
new NpgsqlTypes.NpgsqlPoint(x: 0.550629969065182d, y: 0.18996949161201027d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6353822179924924d, y: 0.6841932782445832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7113633936059067d, y: 0.4242022182958237d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9201421783446416d, y: 0.5706603643025134d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8298870381099847d, y: 0.8527632371769899d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35132766136034244d, y: 0.2745819993218569d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6827184204415228d, y: 0.5529378248497138d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6817221077160849d, y: 0.8904766075177917d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8449086358618488d, y: 0.050281293091564705d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7327370798550848d, y: 0.6613311199402367d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30721399531852844d, y: 0.08194358025805859d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7955311490405839d, y: 0.1564169284214466d),
new NpgsqlTypes.NpgsqlPoint(x: 0.699365361712632d, y: 0.7263259935356152d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5584022784630447d, y: 0.24311336238561854d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3070186087312037d, y: 0.8274077666210133d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21209161870854365d, y: 0.6899691386088085d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28473225899565147d, y: 0.38710401557071916d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04724442241911542d, y: 0.5173542427650326d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09822846541233132d, y: 0.9180218166614346d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3034925225641226d, y: 0.04298209489133309d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49174286717529603d, y: 0.28002081680924973d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6147215819871006d, y: 0.260945219088366d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6018631300678527d, y: 0.6145638762994281d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8371775018075296d, y: 0.027855928996140422d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49571112771518633d, y: 0.8632481134308944d),
new NpgsqlTypes.NpgsqlPoint(x: 0.734895830343321d, y: 0.3904072789304608d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8146614013737967d, y: 0.6482681831047034d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8228479778645869d, y: 0.19512379480600817d),
new NpgsqlTypes.NpgsqlPoint(x: 0.548655950581205d, y: 0.2700526833530973d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19673151213123163d, y: 0.8530052589903029d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3717183794072142d, y: 0.10726361147936836d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08852727057328713d, y: 0.356841030306725d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3026855960664757d, y: 0.32081572821996074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4457034709514418d, y: 0.9158572063648603d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6719255780265322d, y: 0.22781658508148428d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46813527223849305d, y: 0.9383026169128115d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6181207076181459d, y: 0.13925913240529375d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8750976764989614d, y: 0.1695502798889329d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40030197629454967d, y: 0.7517203303341388d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3128705939934239d, y: 0.584186494916605d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9626607962854771d, y: 0.02808335576638421d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9141638991801139d, y: 0.7960470047468329d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8386902343481923d, y: 0.4548867268847562d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07143651582023203d, y: 0.3794071653403601d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2981450302448977d, y: 0.392945082352955d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4864037747438962d, y: 0.914512570230824d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9375817311030942d, y: 0.5360518729242861d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03086363446293605d, y: 0.6641250698556693d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11417394055466734d, y: 0.7595595985243337d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9819519286432732d, y: 0.10623264454218351d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4318630722143718d, y: 0.6904747890841156d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24421754547949925d, y: 0.960121018265947d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5355933981137707d, y: 0.03184848436209253d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19381766818171342d, y: 0.6935894900732883d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32708104729323173d, y: 0.13084375004296012d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8428484497955456d, y: 0.8923041456541579d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05081163492567087d, y: 0.31049981918084735d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15185299262450735d, y: 0.20634219331242665d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6929531831688718d, y: 0.37437226638134546d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5957727703549514d, y: 0.36686399835253725d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04575022723511191d, y: 0.9266626917443125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5210942932894663d, y: 0.591211874342782d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1637230193874526d, y: 0.19847627119121702d),
new NpgsqlTypes.NpgsqlPoint(x: 0.00017410982536292252d, y: 0.04657494213744462d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9311326079237681d, y: 0.2742028942007637d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8853744568963214d, y: 0.49445221582119303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5862085913783065d, y: 0.4048541548981579d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6689692231550577d, y: 0.39897353093272714d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5582763669585094d, y: 0.5941757659566881d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030984232528300626d, y: 0.946940264839264d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20370622010362982d, y: 0.5715247228436214d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7248515943345679d, y: 0.8567532878510546d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44083937136677376d, y: 0.02667715278109073d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.501025460060808d, y: 0.8190171686417673d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0954388014276859d, y: 0.017705656250459723d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6582637693642401d, y: 0.9692285283320042d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3758556414176627d, y: 0.8071184189562376d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09777454519675144d, y: 0.39822425876847056d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06346827061552707d, y: 0.9949062277292605d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08396704834934632d, y: 0.15447727079357731d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2457576809420794d, y: 0.2075687575975429d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28752846601878523d, y: 0.4706473443890624d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6351597676542685d, y: 0.8485681113342624d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5973864240707512d, y: 0.19704009232520392d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5052853243327844d, y: 0.40182739141943435d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3773221100361728d, y: 0.9280914999624873d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16792875702160126d, y: 0.01153362759636134d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6731693639060222d, y: 0.13225932981375532d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16401154035603183d, y: 0.08245364892774742d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3959793098838241d, y: 0.25010875078497163d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5801843229478593d, y: 0.9702018376387601d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.89716205910878d, y: 0.7810693888140077d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23779569736301753d, y: 0.3083372371739891d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7433024105138566d, y: 0.8068797113247145d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13018116174862415d, y: 0.8301936444545205d),
new NpgsqlTypes.NpgsqlPoint(x: 0.038470747275218264d, y: 0.5939012660182718d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04758482756743865d, y: 0.10628670985743527d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39713458902612864d, y: 0.6356023958692663d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0006864456052766421d, y: 0.9163455400793529d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8242493182979485d, y: 0.38301871709189494d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5946288586826393d, y: 0.8874719583236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35247025499092144d, y: 0.309426789784791d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47187580331191303d, y: 0.5755324858743491d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3138882856362254d, y: 0.8017738697265692d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4178296211828282d, y: 0.7229567975374822d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6304588170589648d, y: 0.4342477501098616d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36470699236227433d, y: 0.21355053487719722d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44678227047586816d, y: 0.1436142513694395d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16998617536032323d, y: 0.5176717408744244d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6648731182391152d, y: 0.45690221807446896d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11727747093978358d, y: 0.18589750879589684d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8771915493450125d, y: 0.3008412093597703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.356237155765464d, y: 0.24037153226324004d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7406822534602976d, y: 0.6919930679366404d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9381949419584347d, y: 0.03270771159101804d),
new NpgsqlTypes.NpgsqlPoint(x: 0.624154951545108d, y: 0.5621703308319425d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5931585951231811d, y: 0.2696556810737998d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3230696721099786d, y: 0.17882677805763536d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5125303365243619d, y: 0.11934036187099573d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.764895981880771d, y: 0.9612542512879508d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6462799685682155d, y: 0.2095554323873169d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6177083294213076d, y: 0.8174367429249005d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16371069384477266d, y: 0.502996647714156d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.003149605123538568d, y: 0.39565975366786865d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03031214397005988d, y: 0.8117913734721602d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2693189086880208d, y: 0.9209614841991016d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5130370990011507d, y: 0.03883761117497753d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3594489992224974d, y: 0.16696934497431848d),
new NpgsqlTypes.NpgsqlPoint(x: 0.047380846636681184d, y: 0.21297916597787536d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20588106120470884d, y: 0.7714583031940887d),
new NpgsqlTypes.NpgsqlPoint(x: 0.01436193138494224d, y: 0.0651267128999673d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7781888297225226d, y: 0.9510150961096026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8581715748519516d, y: 0.4361691509101684d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32391185433858727d, y: 0.4239385816752059d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03508105329451461d, y: 0.4032403941171565d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5335098813932958d, y: 0.08036767133989786d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7701964439657675d, y: 0.09148942372879731d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7886982143237328d, y: 0.45072444254063393d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5506008329790884d, y: 0.7746594257610493d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9929303738055076d, y: 0.2855811729188271d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6003062114258522d, y: 0.6202258887912696d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7406335088383986d, y: 0.35014379185464695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3107459195319314d, y: 0.9011212030760359d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7458598643505333d, y: 0.5998341281024252d),
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9925454756232547d, y: 0.22660391668198354d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17991542080542622d, y: 0.6499262993157419d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5562507230603904d, y: 0.04039504258109117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8503265215731234d, y: 0.30778026825888405d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4293654183230635d, y: 0.1291059570739289d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06697698402004792d, y: 0.1956553690444537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8796301362336199d, y: 0.8395160341427695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8594728704536725d, y: 0.19943139154146494d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6353822179924924d, y: 0.6841932782445832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7113633936059067d, y: 0.4242022182958237d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9201421783446416d, y: 0.5706603643025134d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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

                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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

                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
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

                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 127, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 100, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatchAsync(connection, 40, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
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
                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatch(connection, 24, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

