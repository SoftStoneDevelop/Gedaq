

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9883287398364454d, y: 0.9454085485496566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.567118046953685d, y: 0.8795472692900883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6072049864135778d, y: 0.0854639591419245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9946075852472678d, y: 0.20838317027745312d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3595108968223053d, y: 0.9237597699729521d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5861665159783789d, y: 0.6643578469924379d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03305986344931544d, y: 0.37584574673839477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5696457609209479d, y: 0.9949011270316558d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8864679631191272d, y: 0.8781307987416654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6646970969329218d, y: 0.27986225347521543d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7960418937510992d, y: 0.298549851066896d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3559869465194545d, y: 0.7883734104293442d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7007390286636773d, y: 0.32514105288446393d),

new NpgsqlTypes.NpgsqlPoint(x: 0.753315351280786d, y: 0.08686948198891609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6289637969053387d, y: 0.09689340399170021d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8821712308010633d, y: 0.26757688029161786d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8699357321092431d, y: 0.9847673472039202d),

new NpgsqlTypes.NpgsqlPoint(x: 0.528047869621665d, y: 0.7453598425982353d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5556036960210976d, y: 0.7060663878668898d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6866694441703945d, y: 0.7029133949297667d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13135041680955806d, y: 0.8318940022207836d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6453575486622372d, y: 0.29918227038262113d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13579256492204828d, y: 0.23495677228201606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6628952670813129d, y: 0.05069724043998858d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17282731696595344d, y: 0.3445771975351508d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05225700109080644d, y: 0.6113211969340795d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19829647822204544d, y: 0.7415865072584904d),

new NpgsqlTypes.NpgsqlPoint(x: 0.060596489722080316d, y: 0.1906876690407462d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6539608527999466d, y: 0.8838101119570732d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9478822634324168d, y: 0.8731338131231142d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8691096861411717d, y: 0.8149718293355235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16139541987323158d, y: 0.3796159354759062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.030451497189763366d, y: 0.2885052471280395d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.019666907476538653d, y: 0.34950124422657247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8432020051923165d, y: 0.8854810366775411d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6271624902460802d, y: 0.7046872859940986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7833218122442667d, y: 0.8597954160898027d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43351826986330066d, y: 0.5043784759472792d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5371762875751314d, y: 0.08366250370545092d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5387015140523855d, y: 0.7495099622963214d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8929355265792905d, y: 0.16024286930161513d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8437593555046682d, y: 0.9230247493322606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41300024911182853d, y: 0.1698484480306166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18928253408631368d, y: 0.7203750409190158d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3054924925896526d, y: 0.42542059196112836d),

new NpgsqlTypes.NpgsqlPoint(x: 0.797961256108158d, y: 0.3283245824171376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6177370835239367d, y: 0.8079731894534552d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8465424650911796d, y: 0.17682292364267016d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6281596100663167d, y: 0.8253478504386311d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8429511065858784d, y: 0.5849181759750303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10126644604343238d, y: 0.7344451163063157d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11276416332254646d, y: 0.38991903657762506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4581898519729014d, y: 0.5962449899618854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28646576399480805d, y: 0.4136196600028734d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8615920979709706d, y: 0.7047978900007686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08053931973189699d, y: 0.48281043052030603d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3263136384912896d, y: 0.9255982386002145d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7681980565629316d, y: 0.2490280762524515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2921500337445253d, y: 0.2927125991674493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8474025413359529d, y: 0.7389524269590391d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4509226408325048d, y: 0.9927792691266797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.761730899082621d, y: 0.36089172256005464d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3607051148108277d, y: 0.6683608790324386d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8265171985821174d, y: 0.05536902959790768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7798408126575955d, y: 0.41115344888581673d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8734780836429179d, y: 0.7960459822918988d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0033813020401113336d, y: 0.010585581870555694d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01742037343403413d, y: 0.6483050820864869d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14778877730404505d, y: 0.8530729558782378d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5327781328096242d, y: 0.1288750390181579d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5421529829188669d, y: 0.7693126881312734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6577997269725533d, y: 0.49531643366655687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09401589637328034d, y: 0.2942391195518804d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1720008324193626d, y: 0.9032898659850995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.825129275225541d, y: 0.22196913362377713d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18098279940618434d, y: 0.5639004365184808d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3946561552214962d, y: 0.5216097992834581d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33365055558546797d, y: 0.5721137353556726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6591131363538529d, y: 0.6510974330508311d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11624977441057938d, y: 0.8521221083485898d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39726986904138817d, y: 0.49698793742836256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34146247526158946d, y: 0.32053347064007653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06978848187502107d, y: 0.5442299995063697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3258642112096103d, y: 0.11940397089199184d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.840415955754895d, y: 0.8789841808480578d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8072801179758468d, y: 0.10054241168129385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.522502488323689d, y: 0.9891035250634574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5895135120462671d, y: 0.7909615669835477d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22026096042817234d, y: 0.7155690766664862d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7292340822048323d, y: 0.17369755003952259d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31875341601080354d, y: 0.5814871913242468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9064490318882867d, y: 0.9391908692181876d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7824995713530031d, y: 0.6596100144844024d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7696333762379365d, y: 0.21714335192622514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7717101681336969d, y: 0.726479665097664d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21647845145305789d, y: 0.7814137060978277d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4273037537963502d, y: 0.15749433729562456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2557527897838493d, y: 0.4019392743863376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8104695851767917d, y: 0.22850631648477482d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3313282760419227d, y: 0.9187221931382972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9469902328809973d, y: 0.9424083439887654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6700175135651466d, y: 0.5697302575284107d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2990678979166119d, y: 0.9269783209725683d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7999098047864444d, y: 0.8432700908153156d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5681443853721712d, y: 0.7512243448143254d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5251486998712948d, y: 0.7964899339611221d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06879399121460916d, y: 0.45077664991361555d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4445044255940107d, y: 0.09930838630469829d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24567868503724832d, y: 0.4322200492641418d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5495764168264992d, y: 0.259209787786285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.257510348559273d, y: 0.2206221673634312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8649536848220548d, y: 0.25293629999305567d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26732472888701564d, y: 0.4267999498472457d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8537263868370638d, y: 0.36613914985421947d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24441985533766275d, y: 0.3507864826735987d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26396007057487747d, y: 0.2570141054537357d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20007631541606563d, y: 0.931369029138651d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9972653854666591d, y: 0.22748959474280328d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8485644188948078d, y: 0.28441889840109236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.509627305153062d, y: 0.9891175947754383d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7029221965492081d, y: 0.8647032346368845d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12685788670265974d, y: 0.10583681705292025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45007861471633115d, y: 0.8107498769989373d),

new NpgsqlTypes.NpgsqlPoint(x: 0.044995732002218736d, y: 0.8522042315703101d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38261966424821325d, y: 0.6066363791806234d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7244875603122756d, y: 0.15282112708647522d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9997370097619375d, y: 0.6086638253653763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3569551806410366d, y: 0.9706207210133646d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37300307606116956d, y: 0.3200580482177464d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8977238185109099d, y: 0.19910223121678494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8754958770694485d, y: 0.3026778474147962d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29950527376715064d, y: 0.7366328562229901d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7506497918182742d, y: 0.143116506871367d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11348168905244793d, y: 0.17826405199384965d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7470159521445314d, y: 0.9216092661767639d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7125515750293034d, y: 0.19839318563389352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5944755105835495d, y: 0.9908741718304547d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3193678952718716d, y: 0.7813771255317006d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6510123832285499d, y: 0.7712542589271127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2684913729596159d, y: 0.8138493011768146d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14989857759501624d, y: 0.9640653582195051d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45725609452657334d, y: 0.08870225550400535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9128459728992216d, y: 0.7681543010209362d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48146731530000597d, y: 0.9155800877359255d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8639901329918572d, y: 0.020807803969414507d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22834449665498902d, y: 0.4046528944861796d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.051447921671675445d, y: 0.3356387850116219d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7612184948212541d, y: 0.8070321212445327d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2343146067039078d, y: 0.46264606028382327d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5231914068674334d, y: 0.7758066598083624d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08824751042267132d, y: 0.42703096205406377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5779034639208666d, y: 0.3117030216405121d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.055149168158040496d, y: 0.4330525291762386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8207912965069875d, y: 0.6566988299093235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38598887968357365d, y: 0.011463118919337822d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.036268394861084796d, y: 0.6396125359498168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22554117006243657d, y: 0.14322953291062646d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45391250634801583d, y: 0.8574219232589995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28063078987009615d, y: 0.3500669815304617d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6689169006389536d, y: 0.00839957178826034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3035595673490248d, y: 0.6474061132441835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03858799889271103d, y: 0.6280291213124626d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4734434575691555d, y: 0.11084783044579216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7049215848020084d, y: 0.145850586603967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8033419206627136d, y: 0.6464134756293727d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19984801462371926d, y: 0.10575935286089089d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9812684105441273d, y: 0.6487822530487471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00669004083361846d, y: 0.789497806953462d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9924937122654983d, y: 0.25310483292085906d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2545521327715473d, y: 0.012590405014678452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5591099673555394d, y: 0.8038076756536454d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15783379000159847d, y: 0.32338246083989886d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19298585464243578d, y: 0.09306384016256952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5573945924164901d, y: 0.7660911519362502d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2815836284268406d, y: 0.6501274813714917d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46645640265816635d, y: 0.02382670905341444d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26787538382428644d, y: 0.8845997950943528d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8527176571850237d, y: 0.5446185728222428d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5678265770293232d, y: 0.3773386659277871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5682457357245384d, y: 0.9914897294582783d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12080839194091786d, y: 0.6930950593764948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7716051099008838d, y: 0.1039790743786786d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7144868626922689d, y: 0.962326785306354d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9151042509658748d, y: 0.4347522237361311d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33232273647739197d, y: 0.994783735384469d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8733439008542381d, y: 0.0201856942521067d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3504507027199103d, y: 0.21372372717071786d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5670445716447526d, y: 0.3075007621947319d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08264188748152301d, y: 0.22002311746826275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9685221542299229d, y: 0.2101573576689122d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2352055421488891d, y: 0.5315949604810429d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07904573073358334d, y: 0.18368432118234201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6970521626530048d, y: 0.7561150281743829d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4500157801123973d, y: 0.1476049177643144d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28292625669314564d, y: 0.5450789869792761d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5083247316459485d, y: 0.8054453336532815d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7690499754795833d, y: 0.6951409238611542d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5122678022096477d, y: 0.9541292025834727d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20196070883080952d, y: 0.6105486908956947d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5631208642172442d, y: 0.025994870247785018d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4175974383006076d, y: 0.6855935791636232d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6726805987005512d, y: 0.5201388376442058d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30580626659110544d, y: 0.839450061935193d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6295656836871028d, y: 0.9957908327602247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5268472834438248d, y: 0.5176282619217331d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4199066422125255d, y: 0.43449833777215674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0162842809212409d, y: 0.11376637359990083d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6868377136156993d, y: 0.09907338268105848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5080579298992931d, y: 0.2513735046977914d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7661710329378948d, y: 0.807192043100403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.786354578213425d, y: 0.8198041302380017d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14193516784900284d, y: 0.05223217164256089d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2153752947830827d, y: 0.06339959094890579d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28401351180699186d, y: 0.4952100060734299d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2880917450915129d, y: 0.3638324870931601d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8620250392742468d, y: 0.4099653017496444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5831498270354484d, y: 0.3637796306273875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6075867891932485d, y: 0.11657572076623302d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5954737783464655d, y: 0.4098781544845156d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3830395986646009d, y: 0.46807017952065255d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37968596759996065d, y: 0.5275749463593994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05724493116696394d, y: 0.6425473576893453d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5817590109729865d, y: 0.16862061210577173d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1034771266159209d, y: 0.37346847466191313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.847434345143695d, y: 0.6315899218599671d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29395892858936756d, y: 0.42818894019489406d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7136933604967778d, y: 0.11242934317877973d),

new NpgsqlTypes.NpgsqlPoint(x: 0.019584593083053048d, y: 0.7189456015304649d),

new NpgsqlTypes.NpgsqlPoint(x: 0.293692397637744d, y: 0.18703105880275928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3120263571179358d, y: 0.9533583443210994d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6672253126686923d, y: 0.6465088692030292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5578706703520371d, y: 0.8876192781730793d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4495384427380491d, y: 0.5111623926475168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5785524658075486d, y: 0.1687454207309288d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7819390881908148d, y: 0.9660523470937169d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8651346022842415d, y: 0.3575142510530007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03704433777993299d, y: 0.5356240336302341d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42255133713343807d, y: 0.541686514062969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3473821522537117d, y: 0.10532838907147168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24533216123045443d, y: 0.8660961473348668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35408720828800555d, y: 0.170972215372439d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07768561379565864d, y: 0.5939187493037933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28586234305715286d, y: 0.278939871466545d),

new NpgsqlTypes.NpgsqlPoint(x: 0.016779206503507504d, y: 0.6324853899273756d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8035575860714211d, y: 0.12233076275115384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9305202147384959d, y: 0.06376958558210954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9175614519431917d, y: 0.7054735983138587d),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 110, query1, 86, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatchAsync(connection, 12, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatch(connection, 87, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 57);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray2M>(15);

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
                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

