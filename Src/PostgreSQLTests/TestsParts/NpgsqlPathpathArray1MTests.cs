

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
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13794770865099826d, y: 0.5061708273450253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8615949689516759d, y: 0.8613226959755995d), new NpgsqlTypes.NpgsqlPoint(x: 0.031307214008366224d, y: 0.6368506439808947d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22680420086662134d, y: 0.1915591460917353d), new NpgsqlTypes.NpgsqlPoint(x: 0.35312335744881085d, y: 0.9305898362245942d), new NpgsqlTypes.NpgsqlPoint(x: 0.9035012270473008d, y: 0.13577827002116372d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.970016012853776d, y: 0.624334588838613d), new NpgsqlTypes.NpgsqlPoint(x: 0.1106057491966338d, y: 0.8756934703377184d), new NpgsqlTypes.NpgsqlPoint(x: 0.027063893495121172d, y: 0.535407383211361d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7596920265169814d, y: 0.0373349667462215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457041542821867d, y: 0.5261986950322155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6369282517145942d, y: 0.038215792846507335d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5713536535971236d, y: 0.9962373916731836d), new NpgsqlTypes.NpgsqlPoint(x: 0.9662795519806238d, y: 0.7659940312430782d), new NpgsqlTypes.NpgsqlPoint(x: 0.41749031964263017d, y: 0.29443078228023956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1994841081329365d, y: 0.17918311391439967d), new NpgsqlTypes.NpgsqlPoint(x: 0.10456633299676543d, y: 0.19319812524496704d), new NpgsqlTypes.NpgsqlPoint(x: 0.14454645875680572d, y: 0.722140349160444d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45217161333854494d, y: 0.5583266279412451d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103781161855596d, y: 0.37081512138229333d), new NpgsqlTypes.NpgsqlPoint(x: 0.00567765483151772d, y: 0.15275033807665217d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06576962579649626d, y: 0.9239952251598313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9355170293107712d, y: 0.5755233469789861d), new NpgsqlTypes.NpgsqlPoint(x: 0.2129161515766007d, y: 0.9031724274671568d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8857390047433479d, y: 0.29529268793675967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8710185235505807d, y: 0.23733641678528994d), new NpgsqlTypes.NpgsqlPoint(x: 0.013141970158717764d, y: 0.38787788862023664d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46212274283181387d, y: 0.026161308180077447d), new NpgsqlTypes.NpgsqlPoint(x: 0.30199453015265676d, y: 0.19327606763648653d), new NpgsqlTypes.NpgsqlPoint(x: 0.05064799137915099d, y: 0.8390278980444166d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1008169200869038d, y: 0.3254617694357469d), new NpgsqlTypes.NpgsqlPoint(x: 0.15973888260250813d, y: 0.49337637868154094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8488684161419934d, y: 0.8526312748102834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49668572351153784d, y: 0.6482777256082699d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434319768954218d, y: 0.6822288567264027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8755237256877927d, y: 0.16511246577956595d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4031023923174545d, y: 0.6012595251124355d), new NpgsqlTypes.NpgsqlPoint(x: 0.32814588664583577d, y: 0.46291213377749596d), new NpgsqlTypes.NpgsqlPoint(x: 0.36579636961203854d, y: 0.6000466453880606d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8700495255369901d, y: 0.4746113405772536d), new NpgsqlTypes.NpgsqlPoint(x: 0.012892632406574345d, y: 0.7084215977629427d), new NpgsqlTypes.NpgsqlPoint(x: 0.47488462153015143d, y: 0.4874189540462437d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14816099026344065d, y: 0.6387606936541984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912904353281953d, y: 0.8709906659925716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6173325224220064d, y: 0.8638389153845123d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9758920964684878d, y: 0.773810462818202d), new NpgsqlTypes.NpgsqlPoint(x: 0.4134427230258795d, y: 0.09354313050205199d), new NpgsqlTypes.NpgsqlPoint(x: 0.35008157051412636d, y: 0.6753669506298757d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7784377956189964d, y: 0.7879350564101909d), new NpgsqlTypes.NpgsqlPoint(x: 0.06136528709559652d, y: 0.8025532560334131d), new NpgsqlTypes.NpgsqlPoint(x: 0.2689070162645698d, y: 0.03204520210311679d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6488744205924235d, y: 0.5046626148747698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701979685783416d, y: 0.8878597009235528d), new NpgsqlTypes.NpgsqlPoint(x: 0.8299247472033032d, y: 0.4634751355333937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15206852494783152d, y: 0.16199934026121998d), new NpgsqlTypes.NpgsqlPoint(x: 0.3044256152129703d, y: 0.6476627818812053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141029165841863d, y: 0.7665445712130156d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.183332498615441d, y: 0.4846450331633825d), new NpgsqlTypes.NpgsqlPoint(x: 0.07086287372352951d, y: 0.8456862847545759d), new NpgsqlTypes.NpgsqlPoint(x: 0.37975635212932723d, y: 0.5904199120478112d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9453501920251712d, y: 0.9255412164233588d), new NpgsqlTypes.NpgsqlPoint(x: 0.1924071243554617d, y: 0.06430233061466928d), new NpgsqlTypes.NpgsqlPoint(x: 0.5793735253522804d, y: 0.04665549026958116d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3544738246601574d, y: 0.9446423395106512d), new NpgsqlTypes.NpgsqlPoint(x: 0.2972637333893603d, y: 0.9991568977805908d), new NpgsqlTypes.NpgsqlPoint(x: 0.518828813802641d, y: 0.4650781305816294d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1091351274425244d, y: 0.9793501680444198d), new NpgsqlTypes.NpgsqlPoint(x: 0.33878431964669664d, y: 0.24697008065167392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4786135910728313d, y: 0.2565384252510393d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6328056249838111d, y: 0.21430319578679868d), new NpgsqlTypes.NpgsqlPoint(x: 0.27146765111051463d, y: 0.47025590305118514d), new NpgsqlTypes.NpgsqlPoint(x: 0.49487934106709053d, y: 0.7470707536382325d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9851079162249622d, y: 0.6370175891341819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969300500456849d, y: 0.4459160997732663d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353992067098436d, y: 0.9270369719107642d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0685207536279383d, y: 0.22248386525303832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8197962676049567d, y: 0.3246409968211377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496805040948847d, y: 0.008192259374731448d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8209193911140941d, y: 0.7159444741216503d), new NpgsqlTypes.NpgsqlPoint(x: 0.8871891884398077d, y: 0.8717819729871502d), new NpgsqlTypes.NpgsqlPoint(x: 0.999736008455261d, y: 0.37220151492806763d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1689200218184922d, y: 0.5933954985787195d), new NpgsqlTypes.NpgsqlPoint(x: 0.669381945899105d, y: 0.6788599106725351d), new NpgsqlTypes.NpgsqlPoint(x: 0.43432128600004016d, y: 0.49404594530554136d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43368657450791726d, y: 0.33808402289253126d), new NpgsqlTypes.NpgsqlPoint(x: 0.174742660507056d, y: 0.5938767882969954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9564646681143203d, y: 0.8148936624729004d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7852003856268505d, y: 0.5014782372263018d), new NpgsqlTypes.NpgsqlPoint(x: 0.783220359286732d, y: 2.7100465433527177E-05d), new NpgsqlTypes.NpgsqlPoint(x: 0.28995377807909517d, y: 0.6675465755458688d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8183989637275932d, y: 0.1782639763767292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5229197995931628d, y: 0.42721725503832275d), new NpgsqlTypes.NpgsqlPoint(x: 0.013459082591898097d, y: 0.468361578505306d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4197958742546275d, y: 0.5750749178530892d), new NpgsqlTypes.NpgsqlPoint(x: 0.15157686203443077d, y: 0.5030904120240343d), new NpgsqlTypes.NpgsqlPoint(x: 0.39667287658558303d, y: 0.7100119490534179d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9599041351713913d, y: 0.07374286732913837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322329704079857d, y: 0.38340762519308336d), new NpgsqlTypes.NpgsqlPoint(x: 0.15288803065970147d, y: 0.5960490754347528d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26534741390161065d, y: 0.8017667233702325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215019482966087d, y: 0.5307309932923673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8871436985306616d, y: 0.5220381416722369d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32880809695420665d, y: 0.4761151620644487d), new NpgsqlTypes.NpgsqlPoint(x: 0.2448021643866155d, y: 0.48203965981754504d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118180103528551d, y: 0.14502236411155567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17290495500379977d, y: 0.030032129770973914d), new NpgsqlTypes.NpgsqlPoint(x: 0.1320936326776524d, y: 0.7536861201714236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406259271917878d, y: 0.6473231424020645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21427137267363816d, y: 0.3675171195193241d), new NpgsqlTypes.NpgsqlPoint(x: 0.1633450984998127d, y: 0.9771795544300176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373431484839822d, y: 0.5956547968151332d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23130068761842182d, y: 0.40325202742922983d), new NpgsqlTypes.NpgsqlPoint(x: 0.1290654740407281d, y: 0.02716730944721335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836974233694675d, y: 0.4363812887282098d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6460698616927879d, y: 0.1939078331130295d), new NpgsqlTypes.NpgsqlPoint(x: 0.830264387762938d, y: 0.18128812122806914d), new NpgsqlTypes.NpgsqlPoint(x: 0.18151123494964405d, y: 0.9471800839972793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47104456366898506d, y: 0.3954079365355818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8573848053765134d, y: 0.6157967040615827d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248942486662554d, y: 0.25082158528046483d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22953830501947137d, y: 0.43721938752415546d), new NpgsqlTypes.NpgsqlPoint(x: 0.8678182519631769d, y: 0.7127697035654583d), new NpgsqlTypes.NpgsqlPoint(x: 0.0065123901927935934d, y: 0.40171543898373663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4860603094458401d, y: 0.28974466514771646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442726597480789d, y: 0.49650143550985193d), new NpgsqlTypes.NpgsqlPoint(x: 0.3259020685628269d, y: 0.5431868138978575d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8149621734215665d, y: 0.5011933036465415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9996592441247137d, y: 0.8763360353447005d), new NpgsqlTypes.NpgsqlPoint(x: 0.7481730520842437d, y: 0.7478960925766007d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33781672063250123d, y: 0.04850751200048187d), new NpgsqlTypes.NpgsqlPoint(x: 0.747564907196783d, y: 0.20293164129303354d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631132584750561d, y: 0.22086098344388028d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3715501237178199d, y: 0.30862744962242517d), new NpgsqlTypes.NpgsqlPoint(x: 0.46593944685141586d, y: 0.9638518711411257d), new NpgsqlTypes.NpgsqlPoint(x: 0.3978353960837048d, y: 0.019625529360193683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5425921672542191d, y: 0.3660777466379622d), new NpgsqlTypes.NpgsqlPoint(x: 0.014751999941916893d, y: 0.4696797329361895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6930700830566221d, y: 0.1623939386485037d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3237256000822607d, y: 0.16369782853067372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799630042515608d, y: 0.10764101201818776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287521216584669d, y: 0.766983922303787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5956490288051658d, y: 0.8747797959535156d), new NpgsqlTypes.NpgsqlPoint(x: 0.3841481196978477d, y: 0.23778470728965428d), new NpgsqlTypes.NpgsqlPoint(x: 0.4527778984258911d, y: 0.8613893037198614d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7035875795260337d, y: 0.27066089153358075d), new NpgsqlTypes.NpgsqlPoint(x: 0.84933814388002d, y: 0.5166271059080969d), new NpgsqlTypes.NpgsqlPoint(x: 0.6349446817972916d, y: 0.6928846379669996d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43360627486619496d, y: 0.5616346070578424d), new NpgsqlTypes.NpgsqlPoint(x: 0.4003583578365836d, y: 0.34061688245596433d), new NpgsqlTypes.NpgsqlPoint(x: 0.24119546868641994d, y: 0.16184589009466466d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5758644408458654d, y: 0.10740171189255021d), new NpgsqlTypes.NpgsqlPoint(x: 0.6932056848624175d, y: 0.8890060591407065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9039416017430062d, y: 0.46868137103389085d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41526191155931513d, y: 0.015018932326746115d), new NpgsqlTypes.NpgsqlPoint(x: 0.34786561093425983d, y: 0.7763543854673259d), new NpgsqlTypes.NpgsqlPoint(x: 0.44908813655732305d, y: 0.7188809659885711d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20756403918127664d, y: 0.014116544955396382d), new NpgsqlTypes.NpgsqlPoint(x: 0.42312413003255334d, y: 0.6937808299085488d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439110916625874d, y: 0.8556372995686271d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3569840278261749d, y: 0.7998589426552601d), new NpgsqlTypes.NpgsqlPoint(x: 0.2243508748696057d, y: 0.287575905688519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8274948343468473d, y: 0.14015867218506095d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08325275520478315d, y: 0.7044525277964157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575908568574535d, y: 0.25932936585513566d), new NpgsqlTypes.NpgsqlPoint(x: 0.3346288239848406d, y: 0.22626530207410755d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40279498498716104d, y: 0.8442085362335128d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856760596192534d, y: 0.8213885649010905d), new NpgsqlTypes.NpgsqlPoint(x: 0.19875025998384133d, y: 0.15640603685905452d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8237753222660615d, y: 0.7285003227121957d), new NpgsqlTypes.NpgsqlPoint(x: 0.05522593149105526d, y: 0.7949355075924494d), new NpgsqlTypes.NpgsqlPoint(x: 0.24081566871258053d, y: 0.5929780981810241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057011073294119585d, y: 0.9687378367328898d), new NpgsqlTypes.NpgsqlPoint(x: 0.046595437630577496d, y: 0.8100085543410165d), new NpgsqlTypes.NpgsqlPoint(x: 0.27309878667854826d, y: 0.5026524311069555d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8979360388978721d, y: 0.04361572009989223d), new NpgsqlTypes.NpgsqlPoint(x: 0.2365050710968266d, y: 0.7984954237467867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3056094058798532d, y: 0.12540739768722453d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4148088538734449d, y: 0.47615634555252895d), new NpgsqlTypes.NpgsqlPoint(x: 0.09977733175948988d, y: 0.42860915673516253d), new NpgsqlTypes.NpgsqlPoint(x: 0.03819092164970428d, y: 0.9576494822230569d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6360227668039313d, y: 0.9878105186810179d), new NpgsqlTypes.NpgsqlPoint(x: 0.010084061826661661d, y: 0.6012921429826695d), new NpgsqlTypes.NpgsqlPoint(x: 0.4739129794689142d, y: 0.8702154105175565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7313526544114892d, y: 0.13494083752888042d), new NpgsqlTypes.NpgsqlPoint(x: 0.3897576905201585d, y: 0.6987749523862122d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345085998032223d, y: 0.33479460353538315d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4215136151860194d, y: 0.8970409222414057d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080785443340561d, y: 0.9215170384124067d), new NpgsqlTypes.NpgsqlPoint(x: 0.1388231361898613d, y: 0.11888935032013304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14310828849022872d, y: 0.8088656702816818d), new NpgsqlTypes.NpgsqlPoint(x: 0.009098422047474686d, y: 0.1315851747509551d), new NpgsqlTypes.NpgsqlPoint(x: 0.054554284883186255d, y: 0.7389209610633816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5993862924875073d, y: 0.11452423961497471d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020989126289805d, y: 0.6884509977773853d), new NpgsqlTypes.NpgsqlPoint(x: 0.26066062424079217d, y: 0.5224907919854468d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10278409870842908d, y: 0.6748274855127494d), new NpgsqlTypes.NpgsqlPoint(x: 0.1148486163118485d, y: 0.6013178771765116d), new NpgsqlTypes.NpgsqlPoint(x: 0.47995680719954614d, y: 0.8434929298029223d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20071411370257675d, y: 0.2887780977324803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539784061952693d, y: 0.20133640655775775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618734348946431d, y: 0.9547324009806287d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3195600064649251d, y: 0.8771865137062546d), new NpgsqlTypes.NpgsqlPoint(x: 0.0841006606204554d, y: 0.39544754341862165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903731357823423d, y: 0.34976103338080466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13692703651754778d, y: 0.1943965820185357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423679645013987d, y: 0.692772383960896d), new NpgsqlTypes.NpgsqlPoint(x: 0.04142688924293514d, y: 0.2779019826271021d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6343621820575508d, y: 0.3334912717310252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995054396686641d, y: 0.005492966585024739d), new NpgsqlTypes.NpgsqlPoint(x: 0.45683796093318774d, y: 0.37579839893049893d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3055783370085817d, y: 0.14038731136582472d), new NpgsqlTypes.NpgsqlPoint(x: 0.6124753221998881d, y: 0.1180175699684144d), new NpgsqlTypes.NpgsqlPoint(x: 0.2271903271962067d, y: 0.10775666557114327d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27187712077340176d, y: 0.4518725994829328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7720853177264392d, y: 0.9932014937244167d), new NpgsqlTypes.NpgsqlPoint(x: 0.34393424747187507d, y: 0.09927520065356621d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10924371616089956d, y: 0.8865714671074166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8336617378661129d, y: 0.8840711315349704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9859283718518629d, y: 0.4499133273323338d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6699856690334242d, y: 0.7395210461681464d), new NpgsqlTypes.NpgsqlPoint(x: 0.17236795407574612d, y: 0.06409042645046747d), new NpgsqlTypes.NpgsqlPoint(x: 0.4250401135625498d, y: 0.04547961733383499d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42257247985405644d, y: 0.668973368781478d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488498585633607d, y: 0.9613589604839802d), new NpgsqlTypes.NpgsqlPoint(x: 0.2634794053304429d, y: 0.4290274659147767d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9718456941646105d, y: 0.38112718497822484d), new NpgsqlTypes.NpgsqlPoint(x: 0.10396418768126126d, y: 0.021613885463292792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9921472995154295d, y: 0.27950203110910166d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29279702537689856d, y: 0.13695370618805536d), new NpgsqlTypes.NpgsqlPoint(x: 0.965380200715608d, y: 0.7414990769589125d), new NpgsqlTypes.NpgsqlPoint(x: 0.3848596132631845d, y: 0.5792593979533762d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7293026643637301d, y: 0.6068297280850548d), new NpgsqlTypes.NpgsqlPoint(x: 0.44940693230561035d, y: 0.22747843429389858d), new NpgsqlTypes.NpgsqlPoint(x: 0.6755062562873044d, y: 0.7201420409229341d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2657895911763247d, y: 0.4050889392896766d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222118043464991d, y: 0.03796703786082434d), new NpgsqlTypes.NpgsqlPoint(x: 0.28551916165490643d, y: 0.9485701906839811d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7030280867944564d, y: 0.28855684491831124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934583889949144d, y: 0.4789624527749252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821271834384949d, y: 0.9724346631639115d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7083088797365693d, y: 0.6164610706444654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9883012127916152d, y: 0.5003318325058574d), new NpgsqlTypes.NpgsqlPoint(x: 0.19384422136155355d, y: 0.36602728094054304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1094363792286619d, y: 0.6115200664657328d), new NpgsqlTypes.NpgsqlPoint(x: 0.03593862902070255d, y: 0.18161485852115244d), new NpgsqlTypes.NpgsqlPoint(x: 0.047744240240923164d, y: 0.7750970650193523d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6511992360577455d, y: 0.49892462511405433d), new NpgsqlTypes.NpgsqlPoint(x: 0.406251319387103d, y: 0.5318781425410252d), new NpgsqlTypes.NpgsqlPoint(x: 0.3098297320939729d, y: 0.48424776127899183d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8380649007084552d, y: 0.5947770650305294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945563090018995d, y: 0.7790130626474113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739446126808819d, y: 0.8839814067902744d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0743803555271011d, y: 0.4839289493837896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6439400316195909d, y: 0.5020904454257906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9982890268198434d, y: 0.48510210624597605d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03250485434726669d, y: 0.9300741255885602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4880493787571043d, y: 0.7984449575854928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396086249277305d, y: 0.26561655069977164d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8405522201299447d, y: 0.8007795791040102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314539084513137d, y: 0.47116616697695424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3037870818195416d, y: 0.9725474414723526d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02158497573800444d, y: 0.5102004811635662d), new NpgsqlTypes.NpgsqlPoint(x: 0.12391842977419953d, y: 0.8027214713600009d), new NpgsqlTypes.NpgsqlPoint(x: 0.46824009619482965d, y: 0.9082840276081453d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3163472257730007d, y: 0.11112529875707056d), new NpgsqlTypes.NpgsqlPoint(x: 0.23924323797996794d, y: 0.23011829728309896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293458664320883d, y: 0.44332809287527597d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01533668810886879d, y: 0.7291350084810233d), new NpgsqlTypes.NpgsqlPoint(x: 0.02716391133823992d, y: 0.050421397556517755d), new NpgsqlTypes.NpgsqlPoint(x: 0.5964383443786662d, y: 0.646796866687195d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8678462409137228d, y: 0.5722152038282142d), new NpgsqlTypes.NpgsqlPoint(x: 0.42595344660387724d, y: 0.3372900826729619d), new NpgsqlTypes.NpgsqlPoint(x: 0.019462346631318628d, y: 0.047508794811939925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29600148058304354d, y: 0.6409506272023052d), new NpgsqlTypes.NpgsqlPoint(x: 0.6872629121880532d, y: 0.7082317622714926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156780996791787d, y: 0.374638633935666d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48768327082636387d, y: 0.2105584815970145d), new NpgsqlTypes.NpgsqlPoint(x: 0.960354465045619d, y: 0.6748764002748664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7346442369589169d, y: 0.2634989797446089d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15649257954289075d, y: 0.8331040158203044d), new NpgsqlTypes.NpgsqlPoint(x: 0.15416556319797547d, y: 0.6363052775293752d), new NpgsqlTypes.NpgsqlPoint(x: 0.8692872294741406d, y: 0.9457648595916773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9109629517193718d, y: 0.7616235398303618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019224487272984d, y: 0.8047120515164947d), new NpgsqlTypes.NpgsqlPoint(x: 0.7068950955826986d, y: 0.10151857975636847d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16865369050390877d, y: 0.6967143202813472d), new NpgsqlTypes.NpgsqlPoint(x: 0.3391173247548591d, y: 0.5564310100994331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9295448403448556d, y: 0.026266928767133657d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8907636179204875d, y: 0.8612798601170911d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554784969163337d, y: 0.7383127754840549d), new NpgsqlTypes.NpgsqlPoint(x: 0.10522611957699646d, y: 0.4861462294036636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8886055549583601d, y: 0.22237903748264742d), new NpgsqlTypes.NpgsqlPoint(x: 0.8735582262403542d, y: 0.7611274418903391d), new NpgsqlTypes.NpgsqlPoint(x: 0.40229558983044345d, y: 0.9495897125085716d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38235338804483854d, y: 0.7207767679264018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107148774915078d, y: 0.9992714217825314d), new NpgsqlTypes.NpgsqlPoint(x: 0.887491784819811d, y: 0.22303067588759695d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09474052936522559d, y: 0.411066521099837d), new NpgsqlTypes.NpgsqlPoint(x: 0.4718729812697683d, y: 0.9234928215035941d), new NpgsqlTypes.NpgsqlPoint(x: 0.8898590707723372d, y: 0.6226551168981938d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.472230461401709d, y: 0.29768582050893944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6368201531483432d, y: 0.78318054310119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574655081845955d, y: 0.6137473246840844d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5535689466680309d, y: 0.7954397294828709d), new NpgsqlTypes.NpgsqlPoint(x: 0.04073838885324188d, y: 0.32491924415559714d), new NpgsqlTypes.NpgsqlPoint(x: 0.21903725921484796d, y: 0.8580763759937515d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4277612939170894d, y: 0.8131072624499421d), new NpgsqlTypes.NpgsqlPoint(x: 0.4470689279204879d, y: 0.46638238458587966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016465509015359d, y: 0.782706666599255d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02915615800265825d, y: 0.18941671375558033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3153142425314358d, y: 0.9799273898553782d), new NpgsqlTypes.NpgsqlPoint(x: 0.2706892940550042d, y: 0.8548473219492828d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833706214545002d, y: 0.5087517159905564d), new NpgsqlTypes.NpgsqlPoint(x: 0.9005088192491184d, y: 0.5296697223033894d), new NpgsqlTypes.NpgsqlPoint(x: 0.540304524382577d, y: 0.2239796586737236d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8351470787011483d, y: 0.8812670821225005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5737021777529434d, y: 0.9405938671688862d), new NpgsqlTypes.NpgsqlPoint(x: 0.5105517608384418d, y: 0.28260774100264807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9213728175002326d, y: 0.028814359140299284d), new NpgsqlTypes.NpgsqlPoint(x: 0.39549599479017794d, y: 0.9905002424558783d), new NpgsqlTypes.NpgsqlPoint(x: 0.0699969385854542d, y: 0.43693219247822923d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9940544159505358d, y: 0.9892151436515745d), new NpgsqlTypes.NpgsqlPoint(x: 0.6870396122864608d, y: 0.3448556723618339d), new NpgsqlTypes.NpgsqlPoint(x: 0.831800183384242d, y: 0.39406425789830746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47861011759695327d, y: 0.9347649177011036d), new NpgsqlTypes.NpgsqlPoint(x: 0.304049097055365d, y: 0.6880504140447502d), new NpgsqlTypes.NpgsqlPoint(x: 0.8973561013197472d, y: 0.2847456105025512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5087114182389515d, y: 0.2867782930146813d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100087429273744d, y: 0.12672509342226956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6326044016576728d, y: 0.7759266631380266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19198381335490633d, y: 0.16550451942350874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531322940196419d, y: 0.01780519806322567d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788518327995757d, y: 0.8289113131469166d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9005909995975049d, y: 0.40178655260955276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6979586818663337d, y: 0.7764873554698275d), new NpgsqlTypes.NpgsqlPoint(x: 0.5562963559525114d, y: 0.5195005141285243d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5249786745134809d, y: 0.04140555690647474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351161864084341d, y: 0.8124351206665936d), new NpgsqlTypes.NpgsqlPoint(x: 0.6023594420828472d, y: 0.25872543042288254d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7997127921678886d, y: 0.3754419158753063d), new NpgsqlTypes.NpgsqlPoint(x: 0.15418128481328364d, y: 0.376256336362233d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455699322081718d, y: 0.7355245455076564d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49868673005412045d, y: 0.5751693308446308d), new NpgsqlTypes.NpgsqlPoint(x: 0.2731784351763481d, y: 0.6548539660257776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8425021306615313d, y: 0.5314768307541553d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12707255713739585d, y: 0.23080648029589335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9407609244527828d, y: 0.28268460533296247d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988767898519123d, y: 0.7305012938834266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7859116863035123d, y: 0.5277060166967177d), new NpgsqlTypes.NpgsqlPoint(x: 0.987849841957832d, y: 0.2445423856651412d), new NpgsqlTypes.NpgsqlPoint(x: 0.4840876096664516d, y: 0.526926365838859d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21914926267679957d, y: 0.8816983034441167d), new NpgsqlTypes.NpgsqlPoint(x: 0.663877091277891d, y: 0.30340477866114834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6841984091362627d, y: 0.14266543490889116d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38289053964640185d, y: 0.8410500746611428d), new NpgsqlTypes.NpgsqlPoint(x: 0.23171376072707972d, y: 0.7198659313099868d), new NpgsqlTypes.NpgsqlPoint(x: 0.47189035093744025d, y: 0.5193608500296807d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8684264796840441d, y: 0.22499054970287646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9485782780203064d, y: 0.8004931943987368d), new NpgsqlTypes.NpgsqlPoint(x: 0.1442392796871047d, y: 0.8657083094052174d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27508653682130924d, y: 0.08214212235681351d), new NpgsqlTypes.NpgsqlPoint(x: 0.30938921952957366d, y: 0.3947245222779041d), new NpgsqlTypes.NpgsqlPoint(x: 0.46290399259190484d, y: 0.3815533343052d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3527874620708089d, y: 0.13617233040046173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902806937449306d, y: 0.5673821367697969d), new NpgsqlTypes.NpgsqlPoint(x: 0.21167640977826974d, y: 0.14428460987206537d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4630006047849965d, y: 0.7854469336357062d), new NpgsqlTypes.NpgsqlPoint(x: 0.657256898500849d, y: 0.9390086149238868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810596488737303d, y: 0.31777074352182255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6673019971268996d, y: 0.02679564871804374d), new NpgsqlTypes.NpgsqlPoint(x: 0.873416829685748d, y: 0.3667575077435711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2545573615343524d, y: 0.9275068446408896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36603895518629415d, y: 0.09765030837221722d), new NpgsqlTypes.NpgsqlPoint(x: 0.14854363444146645d, y: 0.7782107161421793d), new NpgsqlTypes.NpgsqlPoint(x: 0.467738115936977d, y: 0.4802940130428879d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44859573663832997d, y: 0.5731399093007667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671539016644374d, y: 0.1416169766460298d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388930076404155d, y: 0.16282660316440878d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8615751097415639d, y: 0.048797815331149574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8015149038768113d, y: 0.992878862738969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5310519393112709d, y: 0.020790420568476242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1610445166611547d, y: 0.7765889007903187d), new NpgsqlTypes.NpgsqlPoint(x: 0.47036771344557593d, y: 0.7621921004516363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9184669851080798d, y: 0.8553306429940205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8145176556316412d, y: 0.026656586094341295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7850013339930845d, y: 0.24694668916776108d), new NpgsqlTypes.NpgsqlPoint(x: 0.7437404268187229d, y: 0.18235777216354232d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06697531179693439d, y: 0.9736707633401731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8096616856294081d, y: 0.8527812396003515d), new NpgsqlTypes.NpgsqlPoint(x: 0.0337188502300626d, y: 0.4598347980455424d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39588789489163045d, y: 0.03244237086427448d), new NpgsqlTypes.NpgsqlPoint(x: 0.8980732955574605d, y: 0.34020292793085705d), new NpgsqlTypes.NpgsqlPoint(x: 0.23392208195242348d, y: 0.07052736808202065d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11366263080270478d, y: 0.0999557282831447d), new NpgsqlTypes.NpgsqlPoint(x: 0.544174164060434d, y: 0.21941087744952958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171908104507424d, y: 0.595633808323634d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.620007024021233d, y: 0.4587137595371311d), new NpgsqlTypes.NpgsqlPoint(x: 0.1460013329510541d, y: 0.24529758979140504d), new NpgsqlTypes.NpgsqlPoint(x: 0.740264761219734d, y: 0.5271594905622028d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3559551616403249d, y: 0.8752329374620609d), new NpgsqlTypes.NpgsqlPoint(x: 0.34468013636931005d, y: 0.5987761342826746d), new NpgsqlTypes.NpgsqlPoint(x: 0.027228971256673007d, y: 0.1235763717490469d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15806201056553637d, y: 0.6344273439321703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686439723624194d, y: 0.49624393746064854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093562432765883d, y: 0.2122797116544597d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0469833433363831d, y: 0.67909657289323d), new NpgsqlTypes.NpgsqlPoint(x: 0.4146685640284187d, y: 0.11692117766539256d), new NpgsqlTypes.NpgsqlPoint(x: 0.2500147071779373d, y: 0.7623206697850816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17490460016399234d, y: 0.8554247586785775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6822827583215868d, y: 0.17795544090617832d), new NpgsqlTypes.NpgsqlPoint(x: 0.20331138801763093d, y: 0.4171855844443121d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04405461982244374d, y: 0.3032001014727781d), new NpgsqlTypes.NpgsqlPoint(x: 0.12508670915921039d, y: 0.27669296519484665d), new NpgsqlTypes.NpgsqlPoint(x: 0.06905293491011422d, y: 0.3118349517101996d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5289156843336981d, y: 0.2790286345158429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7225632272151064d, y: 0.858610113373967d), new NpgsqlTypes.NpgsqlPoint(x: 0.846384566392449d, y: 0.2562316029005077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6944348199074077d, y: 0.20693929144662415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6903703039481128d, y: 0.2604121279264491d), new NpgsqlTypes.NpgsqlPoint(x: 0.6795092825136805d, y: 0.07402277667612867d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43394622635634283d, y: 0.2091348088260223d), new NpgsqlTypes.NpgsqlPoint(x: 0.08801700619804365d, y: 0.5972776844476169d), new NpgsqlTypes.NpgsqlPoint(x: 0.43738171725353436d, y: 0.503015432681742d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39612335105614194d, y: 0.7124126252518073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364169899441113d, y: 0.19946630649524744d), new NpgsqlTypes.NpgsqlPoint(x: 0.275106733889632d, y: 0.647000009468976d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23509351212145102d, y: 0.6474783991314927d), new NpgsqlTypes.NpgsqlPoint(x: 0.38495360185554806d, y: 0.9500751307053501d), new NpgsqlTypes.NpgsqlPoint(x: 0.3018439829700913d, y: 0.4888041106135974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46129685941678067d, y: 0.4612808798246505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8420929798074944d, y: 0.9069353362781708d), new NpgsqlTypes.NpgsqlPoint(x: 0.74424827739276d, y: 0.7695528586188266d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8248438011157908d, y: 0.4580039669213326d), new NpgsqlTypes.NpgsqlPoint(x: 0.3791702130274064d, y: 0.5125162043601577d), new NpgsqlTypes.NpgsqlPoint(x: 0.507445713550322d, y: 0.7337587015814662d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3020461386855795d, y: 0.9415535638289292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6931936496380389d, y: 0.21119164733701823d), new NpgsqlTypes.NpgsqlPoint(x: 0.4008634144790376d, y: 0.05155947620251822d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23917854727243015d, y: 0.025812749977092597d), new NpgsqlTypes.NpgsqlPoint(x: 0.2363936428944794d, y: 0.5037322904595272d), new NpgsqlTypes.NpgsqlPoint(x: 0.03000705775349577d, y: 0.5147460578910147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31795244792040167d, y: 0.8675421479897437d), new NpgsqlTypes.NpgsqlPoint(x: 0.4103678841172286d, y: 0.6475657639829094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6742181778125896d, y: 0.15823199438804558d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1806055013196608d, y: 0.9274221508311233d), new NpgsqlTypes.NpgsqlPoint(x: 0.1199582635888532d, y: 0.30121986700232484d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653125905956782d, y: 0.09262019593533677d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5403226566498597d, y: 0.8872943946828507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9619447072096713d, y: 0.7198113268839065d), new NpgsqlTypes.NpgsqlPoint(x: 0.26175123063791106d, y: 0.24594118481418625d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5735123127359731d, y: 0.6591914423256546d), new NpgsqlTypes.NpgsqlPoint(x: 0.15101038747254059d, y: 0.2260302877609035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682647707869899d, y: 0.5621453818410256d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7143844366204647d, y: 0.36073764480328774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2117489637460459d, y: 0.7973208523288626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8308402320154014d, y: 0.6728195893724449d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05330184521154124d, y: 0.7065574943398696d), new NpgsqlTypes.NpgsqlPoint(x: 0.6592822927997576d, y: 0.6070820342498537d), new NpgsqlTypes.NpgsqlPoint(x: 0.15848624406078304d, y: 0.5999950892234402d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6375831744553203d, y: 0.34503023643302344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024821448710704d, y: 0.7964483102460209d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559354235896922d, y: 0.9916725594326806d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4891864114517571d, y: 0.05530394699065322d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891383703836481d, y: 0.24319403042329035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8058909745003874d, y: 0.4329095720544204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25597321071967005d, y: 0.24245356573987686d), new NpgsqlTypes.NpgsqlPoint(x: 0.17342945612501848d, y: 0.3854670699371514d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495699390428789d, y: 0.4081299161791425d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7103450974938478d, y: 0.3627520005395042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122243776444925d, y: 0.6869841494400915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8425746330020953d, y: 0.0851027964442389d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8269105197557789d, y: 0.9998049852828821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8604896541290612d, y: 0.4536256840321322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6450104907209331d, y: 0.8812500301523465d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3569977122923885d, y: 0.08590085909040124d), new NpgsqlTypes.NpgsqlPoint(x: 0.010423874823063062d, y: 0.3167188733801817d), new NpgsqlTypes.NpgsqlPoint(x: 0.2043052340421545d, y: 0.9902026437903592d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4775989136444738d, y: 0.9828070534974747d), new NpgsqlTypes.NpgsqlPoint(x: 0.6550029382352538d, y: 0.7418783141923445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572003903059453d, y: 0.9159074637938188d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4880115340860367d, y: 0.21324096331511633d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157385234805424d, y: 0.55565371033349d), new NpgsqlTypes.NpgsqlPoint(x: 0.04853358174732203d, y: 0.7786895139366207d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14270767273139406d, y: 0.6502516409000871d), new NpgsqlTypes.NpgsqlPoint(x: 0.5043128086919333d, y: 0.2236846518740221d), new NpgsqlTypes.NpgsqlPoint(x: 0.018107914722949814d, y: 0.07999098472818167d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7495304184380763d, y: 0.91756016452511d), new NpgsqlTypes.NpgsqlPoint(x: 0.1819523247606719d, y: 0.4834626345906491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865330455326339d, y: 0.14549957156269933d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04883825580013357d, y: 0.9178450573459384d), new NpgsqlTypes.NpgsqlPoint(x: 0.2780619826953593d, y: 0.5834124185781161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222819086555994d, y: 0.2238711882750567d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6385577051153618d, y: 0.6766032334432754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2151885798968467d, y: 0.11002468360347484d), new NpgsqlTypes.NpgsqlPoint(x: 0.18270958089283618d, y: 0.7305509202235045d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5956722869377797d, y: 0.4162466294730156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093575394383292d, y: 0.49692506804965464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6348873068703363d, y: 0.7218244741854655d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07143161194691028d, y: 0.9915123926260337d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468717462692038d, y: 0.10804088025455905d), new NpgsqlTypes.NpgsqlPoint(x: 0.05373487083847828d, y: 0.6940921853834459d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3584117879256722d, y: 0.854614896936161d), new NpgsqlTypes.NpgsqlPoint(x: 0.042805301628996206d, y: 0.745803864231374d), new NpgsqlTypes.NpgsqlPoint(x: 0.16056026200816909d, y: 0.3019526050363056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13357330803347378d, y: 0.7547885776098342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335616471937094d, y: 0.02766385630712842d), new NpgsqlTypes.NpgsqlPoint(x: 0.03827132376028597d, y: 0.7584392037588702d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17994652083530416d, y: 0.28664833100117126d), new NpgsqlTypes.NpgsqlPoint(x: 0.8183222243736527d, y: 0.5825594217238905d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078158087267886d, y: 0.13803887307265283d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18218295449135158d, y: 0.9889308791465887d), new NpgsqlTypes.NpgsqlPoint(x: 0.004824660552775084d, y: 0.15848533887649296d), new NpgsqlTypes.NpgsqlPoint(x: 0.9339380497592193d, y: 0.34007395168739496d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.620006255660886d, y: 0.11007344465947266d), new NpgsqlTypes.NpgsqlPoint(x: 0.32197091085460716d, y: 0.5040826269532512d), new NpgsqlTypes.NpgsqlPoint(x: 0.17433288963523674d, y: 0.9783715562928672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.245595568418992d, y: 0.26369155043515347d), new NpgsqlTypes.NpgsqlPoint(x: 0.4243567540758477d, y: 0.34295158386727886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7542879448314619d, y: 0.5014480673038014d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6246643374817722d, y: 0.8911973455820293d), new NpgsqlTypes.NpgsqlPoint(x: 0.06362416303205276d, y: 0.47606891654731587d), new NpgsqlTypes.NpgsqlPoint(x: 0.0934562607012881d, y: 0.5345514994062158d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30629087582547576d, y: 0.9117888224346536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396499172211915d, y: 0.4305999739084432d), new NpgsqlTypes.NpgsqlPoint(x: 0.1473030878086995d, y: 0.9802258478537447d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23428953754696424d, y: 0.548923677732796d), new NpgsqlTypes.NpgsqlPoint(x: 0.09073512526368055d, y: 0.27056928131390734d), new NpgsqlTypes.NpgsqlPoint(x: 0.667024275965589d, y: 0.33746959635083096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6431207002414095d, y: 0.5500896293337397d), new NpgsqlTypes.NpgsqlPoint(x: 0.17940051623671727d, y: 0.5036193508754288d), new NpgsqlTypes.NpgsqlPoint(x: 0.35284237013298403d, y: 0.9094461789889744d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2731716363305281d, y: 0.6517023036603435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8956415372691185d, y: 0.0987692196129718d), new NpgsqlTypes.NpgsqlPoint(x: 0.32309910099294037d, y: 0.27158302543549695d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5551931563591171d, y: 0.11622579381319509d), new NpgsqlTypes.NpgsqlPoint(x: 0.16095447201237267d, y: 0.651589348012292d), new NpgsqlTypes.NpgsqlPoint(x: 0.03258608049112166d, y: 0.6883018002959068d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3012090202536255d, y: 0.7272075045852574d), new NpgsqlTypes.NpgsqlPoint(x: 0.07723221041142248d, y: 0.7449649036193802d), new NpgsqlTypes.NpgsqlPoint(x: 0.07649830029299409d, y: 0.42005112044150483d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07928823201097779d, y: 0.7886082908656725d), new NpgsqlTypes.NpgsqlPoint(x: 0.9674206819284045d, y: 0.737266497160673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7260513953797604d, y: 0.02746080346565294d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3971670896328756d, y: 0.325317697084474d), new NpgsqlTypes.NpgsqlPoint(x: 0.03479987964212228d, y: 0.5264061200774727d), new NpgsqlTypes.NpgsqlPoint(x: 0.17774763109504288d, y: 0.5664614805531056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7609163354381141d, y: 0.6356911310880132d), new NpgsqlTypes.NpgsqlPoint(x: 0.525559503461416d, y: 0.7127313797608409d), new NpgsqlTypes.NpgsqlPoint(x: 0.23718090967553862d, y: 0.7707663719585713d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8114554541722213d, y: 0.9942386750762788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7950484420970615d, y: 0.4533857680497585d), new NpgsqlTypes.NpgsqlPoint(x: 0.08258812204885602d, y: 0.8169683915917031d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7012737199924456d, y: 0.8696867716510447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5993259332077205d, y: 0.2609637740161235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3296217910383862d, y: 0.9556682859077363d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49060329094289823d, y: 0.8086828411414734d), new NpgsqlTypes.NpgsqlPoint(x: 0.44663246175076277d, y: 0.6815741426074408d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292188598560304d, y: 0.7718084225065338d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.802239147409097d, y: 0.8678040354718778d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561165632747543d, y: 0.2629325714909787d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569897015120125d, y: 0.40189316884324733d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01349076209581812d, y: 0.6423223476141143d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138153088264387d, y: 0.10537325643383832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033317981139297d, y: 0.17130298151491308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2815887488720027d, y: 0.6383491976252028d), new NpgsqlTypes.NpgsqlPoint(x: 0.5080498471213203d, y: 0.1665978394775688d), new NpgsqlTypes.NpgsqlPoint(x: 0.03322343575813269d, y: 0.32806272922038093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004199001278612058d, y: 0.8154491748886777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5244620747682764d, y: 0.026443021363703467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414014118229032d, y: 0.23361386947600982d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6070682347415041d, y: 0.956209855480747d), new NpgsqlTypes.NpgsqlPoint(x: 0.09179411865377463d, y: 0.7911369767512455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041911684756711d, y: 0.635136490172427d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9147877266751268d, y: 0.40160951821281965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8159876583427196d, y: 0.9614598620703181d), new NpgsqlTypes.NpgsqlPoint(x: 0.4779117483512202d, y: 0.7808949589393184d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.609340136125502d, y: 0.8280895899800146d), new NpgsqlTypes.NpgsqlPoint(x: 0.15297139163518203d, y: 0.5715746703887484d), new NpgsqlTypes.NpgsqlPoint(x: 0.27194400519491757d, y: 0.3568027192601849d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9663105468164462d, y: 0.1089482919917173d), new NpgsqlTypes.NpgsqlPoint(x: 0.1981368132401683d, y: 0.7978767829782504d), new NpgsqlTypes.NpgsqlPoint(x: 0.3910068090002822d, y: 0.27393174997264813d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5578571704173527d, y: 0.620831706727934d), new NpgsqlTypes.NpgsqlPoint(x: 0.258629537853588d, y: 0.8703854147154838d), new NpgsqlTypes.NpgsqlPoint(x: 0.28985205772729106d, y: 0.29325556428297805d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4338849986612826d, y: 0.8880098665830113d), new NpgsqlTypes.NpgsqlPoint(x: 0.9501365939674539d, y: 0.06966243417437412d), new NpgsqlTypes.NpgsqlPoint(x: 0.41923664091723767d, y: 0.49429139258622423d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4799737174806029d, y: 0.8804585860923492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7975733534603571d, y: 0.27792003008502764d), new NpgsqlTypes.NpgsqlPoint(x: 0.4285883648704272d, y: 0.9131583791069269d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023909503194910586d, y: 0.6304745869270973d), new NpgsqlTypes.NpgsqlPoint(x: 0.38789355006148507d, y: 0.6698672826683514d), new NpgsqlTypes.NpgsqlPoint(x: 0.07340158819614262d, y: 0.9933921457492123d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25434139024176916d, y: 0.04536652101888161d), new NpgsqlTypes.NpgsqlPoint(x: 0.7801516300560924d, y: 0.168485497705962d), new NpgsqlTypes.NpgsqlPoint(x: 0.3207594302704654d, y: 0.8843602090983093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.978058392969549d, y: 0.4076183367883076d), new NpgsqlTypes.NpgsqlPoint(x: 0.368598747186334d, y: 0.0644080048517689d), new NpgsqlTypes.NpgsqlPoint(x: 0.19665939701488866d, y: 0.3459947045715662d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24733917728441346d, y: 0.9026903260496224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8669481787600568d, y: 0.7873989351129508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8973259907391185d, y: 0.733925027247306d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4194968096893664d, y: 0.46925133312500655d), new NpgsqlTypes.NpgsqlPoint(x: 0.06448648992408768d, y: 0.1116286088726256d), new NpgsqlTypes.NpgsqlPoint(x: 0.01679249259415716d, y: 0.1497793446507728d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.870182432355601d, y: 0.5254324448041607d), new NpgsqlTypes.NpgsqlPoint(x: 0.37088417190288336d, y: 0.22116571231812754d), new NpgsqlTypes.NpgsqlPoint(x: 0.12809523564001302d, y: 0.8376506382015776d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3913840367735779d, y: 0.5853063496677324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507074863270659d, y: 0.9240531043109385d), new NpgsqlTypes.NpgsqlPoint(x: 0.4999483995636961d, y: 0.6710070905077118d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8482772377518042d, y: 0.6638885327703244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274004269534349d, y: 0.6685458783512409d), new NpgsqlTypes.NpgsqlPoint(x: 0.391030912199714d, y: 0.9115724854272194d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2794348118194143d, y: 0.5544588534752101d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592573625304488d, y: 0.7280712404385018d), new NpgsqlTypes.NpgsqlPoint(x: 0.1832884232976164d, y: 0.8005975724104074d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23638970062047304d, y: 0.30043907799931635d), new NpgsqlTypes.NpgsqlPoint(x: 0.9488291096478033d, y: 0.038032321679458914d), new NpgsqlTypes.NpgsqlPoint(x: 0.700477871744215d, y: 0.5127108618118572d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43703211896680394d, y: 0.5816160464447485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7143483118140596d, y: 0.8214942581648053d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833121393198362d, y: 0.40663208875722645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7761650547516987d, y: 0.45124345772120444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9941167367726093d, y: 0.6183060462068651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132113466742686d, y: 0.5815698679317207d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6779678758380265d, y: 0.6505521128673264d), new NpgsqlTypes.NpgsqlPoint(x: 0.13520750617616772d, y: 0.5209269445820891d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326797850337658d, y: 0.11442073881491965d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9914432050640457d, y: 0.5240577992688086d), new NpgsqlTypes.NpgsqlPoint(x: 0.22863550752233208d, y: 0.15172801458317253d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711309177821147d, y: 0.6711287837901567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11398414628271392d, y: 0.5170628217112392d), new NpgsqlTypes.NpgsqlPoint(x: 0.3998648849701779d, y: 0.9078218537455726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471260138439299d, y: 0.01747721717841977d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10520177011906306d, y: 0.4923811215369386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863611286339046d, y: 0.678401197953991d), new NpgsqlTypes.NpgsqlPoint(x: 0.30008194157842194d, y: 0.027061932031859692d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2052658610011212d, y: 0.6240020300809647d), new NpgsqlTypes.NpgsqlPoint(x: 0.25143103214195306d, y: 0.9105961981208338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7153254624485007d, y: 0.6035710744282763d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4497719778241447d, y: 0.005967393591463477d), new NpgsqlTypes.NpgsqlPoint(x: 0.07067544837191653d, y: 0.9225470213957536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8765941615956824d, y: 0.08615096109235465d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1386986224849973d, y: 0.9429891652921466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891411015191707d, y: 0.6761582589979888d), new NpgsqlTypes.NpgsqlPoint(x: 0.3443639648937148d, y: 0.19105242666843103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0433643991084629d, y: 0.3415503101124949d), new NpgsqlTypes.NpgsqlPoint(x: 0.017736029238081485d, y: 0.3161599853201228d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062249233638594d, y: 0.8407460528676695d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02858565359786025d, y: 0.4523902934106392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7967932790742996d, y: 0.5521544427143755d), new NpgsqlTypes.NpgsqlPoint(x: 0.20480306014128047d, y: 0.09354383417936041d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9441926731487372d, y: 0.16658258610990662d), new NpgsqlTypes.NpgsqlPoint(x: 0.1786233455995051d, y: 0.4008148031537019d), new NpgsqlTypes.NpgsqlPoint(x: 0.24847839994298826d, y: 0.26724546055912146d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8534507008799698d, y: 0.8274310052341717d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874727704451713d, y: 0.5358439160945375d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788373610056503d, y: 0.3418438652446193d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17896589425484621d, y: 0.6852621907866847d), new NpgsqlTypes.NpgsqlPoint(x: 0.08070707613362416d, y: 0.40198296528265365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7233503825522729d, y: 0.6509013979687397d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4409458794058143d, y: 0.008757739726566682d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219972380188452d, y: 0.4517219221559755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9383473601040093d, y: 0.3256491526324572d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29856750975385704d, y: 0.6017196867745318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133056389919115d, y: 0.025683909563885998d), new NpgsqlTypes.NpgsqlPoint(x: 0.4299744008818681d, y: 0.8086667139006023d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7998887413553344d, y: 0.6590267097950661d), new NpgsqlTypes.NpgsqlPoint(x: 0.8841269224844748d, y: 0.685465939621979d), new NpgsqlTypes.NpgsqlPoint(x: 0.7997292611292086d, y: 0.33777910513126264d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8088791868725785d, y: 0.6265778238646127d), new NpgsqlTypes.NpgsqlPoint(x: 0.4545476753386474d, y: 0.04184405122528567d), new NpgsqlTypes.NpgsqlPoint(x: 0.6132875222596229d, y: 0.2965361738361447d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8983809865997191d, y: 0.13662548337031888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4218588906974745d, y: 0.09789161258045975d), new NpgsqlTypes.NpgsqlPoint(x: 0.47628540285833043d, y: 0.4418005201283346d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18152503749053184d, y: 0.2664492361395979d), new NpgsqlTypes.NpgsqlPoint(x: 0.9088097825869118d, y: 0.14651906818900384d), new NpgsqlTypes.NpgsqlPoint(x: 0.31607743720880843d, y: 0.21465569624400227d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6286090648379209d, y: 0.5339876702937797d), new NpgsqlTypes.NpgsqlPoint(x: 0.945201701127782d, y: 0.7863439721801897d), new NpgsqlTypes.NpgsqlPoint(x: 0.8419442725532226d, y: 0.6017887297390655d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3050597078788022d, y: 0.5798228878293242d), new NpgsqlTypes.NpgsqlPoint(x: 0.5535839802880238d, y: 0.10452633808312572d), new NpgsqlTypes.NpgsqlPoint(x: 0.22676540261385947d, y: 0.6715586748431314d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9490716702179105d, y: 0.15543699935171784d), new NpgsqlTypes.NpgsqlPoint(x: 0.015288931212937618d, y: 0.9233818990912886d), new NpgsqlTypes.NpgsqlPoint(x: 0.17560097795599328d, y: 0.9862226945352149d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5641276813896329d, y: 0.6702341830249288d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620607070298445d, y: 0.5653727305368553d), new NpgsqlTypes.NpgsqlPoint(x: 0.583651211123153d, y: 0.32110611479904105d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8536778384085443d, y: 0.8014996200078606d), new NpgsqlTypes.NpgsqlPoint(x: 0.7162438224920267d, y: 0.2639003928473387d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129904531424588d, y: 0.37398908459562696d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7430698632575049d, y: 0.17292806739721767d), new NpgsqlTypes.NpgsqlPoint(x: 0.46899451974915274d, y: 0.7258045083095027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8871619498625671d, y: 0.13263333281755596d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5815543719918485d, y: 0.3480539935572283d), new NpgsqlTypes.NpgsqlPoint(x: 0.012579449784634877d, y: 0.5267027939707652d), new NpgsqlTypes.NpgsqlPoint(x: 0.4916616420807509d, y: 0.33142954904827704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9015191305296113d, y: 0.33004456276939376d), new NpgsqlTypes.NpgsqlPoint(x: 0.12011294937167338d, y: 0.517104921696335d), new NpgsqlTypes.NpgsqlPoint(x: 0.17717066202931064d, y: 0.06413259948784844d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6215113456416504d, y: 0.5815375362515406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6632055177218859d, y: 0.2783712640343844d), new NpgsqlTypes.NpgsqlPoint(x: 0.5009926162302542d, y: 0.922011954491546d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26973667913034083d, y: 0.5362555975194395d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571452938316394d, y: 0.8380433985608075d), new NpgsqlTypes.NpgsqlPoint(x: 0.020410173277175758d, y: 0.5046600318066047d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5026448117815593d, y: 0.7171760283435685d), new NpgsqlTypes.NpgsqlPoint(x: 0.01674153956394686d, y: 0.125844843411983d), new NpgsqlTypes.NpgsqlPoint(x: 0.2515668972301778d, y: 0.4165042577311374d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005580526243016193d, y: 0.19506183234573415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762863876933648d, y: 0.5774649588941252d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686499740295431d, y: 0.6935262407551355d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49657131741726634d, y: 0.4976920768725409d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383912956483895d, y: 0.6252395850521343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530318338796192d, y: 0.6925086814891043d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2175870656786586d, y: 0.6792080730670913d), new NpgsqlTypes.NpgsqlPoint(x: 0.3634834684681527d, y: 0.5398734404375433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5962645720921609d, y: 0.8722149773241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833107768004708d, y: 0.7780003872374267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4701543045341142d, y: 0.5164654700861867d), new NpgsqlTypes.NpgsqlPoint(x: 0.14336282260717248d, y: 0.7038897200895348d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.634815433183983d, y: 0.49872891711550704d), new NpgsqlTypes.NpgsqlPoint(x: 0.3529579821218176d, y: 0.6096851863733559d), new NpgsqlTypes.NpgsqlPoint(x: 0.3207894825736589d, y: 0.4500835946095185d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36168639995736485d, y: 0.8658295210802774d), new NpgsqlTypes.NpgsqlPoint(x: 0.125572096181241d, y: 0.03635987435498078d), new NpgsqlTypes.NpgsqlPoint(x: 0.36920794283060276d, y: 0.6645531609843622d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4050451160070584d, y: 0.6287111337128389d), new NpgsqlTypes.NpgsqlPoint(x: 0.6619931205072104d, y: 0.1390199983691004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8940603989565854d, y: 0.995021093420382d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8902471755891892d, y: 0.6316712728921596d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610955958238564d, y: 0.22054588035597522d), new NpgsqlTypes.NpgsqlPoint(x: 0.8297944321852708d, y: 0.8689806201236979d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04685937272871166d, y: 0.8831440495751414d), new NpgsqlTypes.NpgsqlPoint(x: 0.40686303816743274d, y: 0.23439694379829212d), new NpgsqlTypes.NpgsqlPoint(x: 0.2245871609293375d, y: 0.16986284311495203d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5487950285639721d, y: 0.25678178234405435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411866919938619d, y: 0.22540101780236632d), new NpgsqlTypes.NpgsqlPoint(x: 0.2862490495692195d, y: 0.8392731788570923d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6621009966677998d, y: 0.08528477933407075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7805827854199315d, y: 0.4606035067997867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7365295204284501d, y: 0.18554718161762673d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04895708404977972d, y: 0.6138643121584476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6645385904757384d, y: 0.26227493651449163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9917516373343295d, y: 0.3927657931519568d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021481930739222d, y: 0.8833872226440306d), new NpgsqlTypes.NpgsqlPoint(x: 0.13293736636416498d, y: 0.2785511577848747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8614435743771697d, y: 0.12630263169502565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02278717316120782d, y: 0.8394782490452827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5382716312911054d, y: 0.9285741128389208d), new NpgsqlTypes.NpgsqlPoint(x: 0.4269771647561519d, y: 0.5755316053113572d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8382511061072793d, y: 0.7273992808681995d), new NpgsqlTypes.NpgsqlPoint(x: 0.5123944065057783d, y: 0.649647174780109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9714907925995665d, y: 0.21403410139904944d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.210493963237408d, y: 0.37700330939909543d), new NpgsqlTypes.NpgsqlPoint(x: 0.4358891358738415d, y: 0.8827505899117588d), new NpgsqlTypes.NpgsqlPoint(x: 0.10229980953564599d, y: 0.6329065779732084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2507631322900231d, y: 0.3713926343403414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232062021820694d, y: 0.9069445015009037d), new NpgsqlTypes.NpgsqlPoint(x: 0.2834350157890342d, y: 0.2407495729330139d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28464375523837027d, y: 0.29634256723302554d), new NpgsqlTypes.NpgsqlPoint(x: 0.8509683928021117d, y: 0.20294309245053088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3291293589962726d, y: 0.45445035830317404d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6947023923481516d, y: 0.6779230338730753d), new NpgsqlTypes.NpgsqlPoint(x: 0.37085287953134305d, y: 0.27801414037358474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5950176102301783d, y: 0.1511176333261125d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8769426736952479d, y: 0.12367340494441481d), new NpgsqlTypes.NpgsqlPoint(x: 0.30817083379952714d, y: 0.17658027337599047d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397689004854959d, y: 0.8920160008535741d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16967809971564618d, y: 0.8009877185318562d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522926810246446d, y: 0.0786357343398244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4175940945411881d, y: 0.4289894332752343d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5652134985855942d, y: 0.24182420826525164d), new NpgsqlTypes.NpgsqlPoint(x: 0.667611628772132d, y: 0.08035716188938036d), new NpgsqlTypes.NpgsqlPoint(x: 0.028505470535917343d, y: 0.4305268986838233d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9826627601005234d, y: 0.818211142850103d), new NpgsqlTypes.NpgsqlPoint(x: 0.1843377389300206d, y: 0.4194494339596526d), new NpgsqlTypes.NpgsqlPoint(x: 0.4929073655294799d, y: 0.8280189400015503d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7894043985810334d, y: 0.2344406318735156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567676461120773d, y: 0.956228707057653d), new NpgsqlTypes.NpgsqlPoint(x: 0.14769927941937322d, y: 0.3630311608233633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9632819815140543d, y: 0.45026120213752385d), new NpgsqlTypes.NpgsqlPoint(x: 0.39813822436365764d, y: 0.6857925120316103d), new NpgsqlTypes.NpgsqlPoint(x: 0.20466654929044525d, y: 0.22449578084554123d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8190501583893249d, y: 0.13406825578206716d), new NpgsqlTypes.NpgsqlPoint(x: 0.5562891170302143d, y: 0.3626070328901556d), new NpgsqlTypes.NpgsqlPoint(x: 0.703930255085011d, y: 0.7802892190652397d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20818027706011344d, y: 0.7404779511674572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6363932406899176d, y: 0.90075323349513d), new NpgsqlTypes.NpgsqlPoint(x: 0.9862692948881578d, y: 0.16817676162444994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2956311740599533d, y: 0.06161277122875375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596156736522537d, y: 0.5666747784989062d), new NpgsqlTypes.NpgsqlPoint(x: 0.8016133826642026d, y: 0.9638556975418642d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24180546253320878d, y: 0.6533892607012219d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058462577253089d, y: 0.9955919233897434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8227482952408973d, y: 0.24830719746037688d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12265530327166974d, y: 0.7735507735678104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740067902036917d, y: 0.0444532326247985d), new NpgsqlTypes.NpgsqlPoint(x: 0.032187521915018724d, y: 0.02153199623387858d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7989904246103935d, y: 0.23401758568781028d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846620686231978d, y: 0.3856263442800685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7804105672890398d, y: 0.8177918693560596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30755683348417073d, y: 0.4755840102001694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7374653965085748d, y: 0.8029381880265363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731225884804187d, y: 0.5559608181756911d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01909302358530951d, y: 0.6361484822912014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461605751620647d, y: 0.2915265149094378d), new NpgsqlTypes.NpgsqlPoint(x: 0.2160692043690402d, y: 0.39066228005693404d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9317260086872032d, y: 0.8763240026950375d), new NpgsqlTypes.NpgsqlPoint(x: 0.09832202798715006d, y: 0.98464669694124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668243824867857d, y: 0.9922696763750821d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5737065435712133d, y: 0.3682220946434933d), new NpgsqlTypes.NpgsqlPoint(x: 0.3571617113439286d, y: 0.33731220896641145d), new NpgsqlTypes.NpgsqlPoint(x: 0.11183238024944664d, y: 0.8024448190649972d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1621654206089832d, y: 0.758634313550558d), new NpgsqlTypes.NpgsqlPoint(x: 0.8361700554255502d, y: 0.7065379640047327d), new NpgsqlTypes.NpgsqlPoint(x: 0.12425592482252901d, y: 0.496610030798993d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18328095764703956d, y: 0.36977049739856815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888610033482699d, y: 0.7324488158197788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5640479602628622d, y: 0.9998314076076905d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.753342093689877d, y: 0.2061627537294055d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430335214895871d, y: 0.41836736572526556d), new NpgsqlTypes.NpgsqlPoint(x: 0.1869643419110294d, y: 0.47423554117186717d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28026199151993125d, y: 0.6478897003863894d), new NpgsqlTypes.NpgsqlPoint(x: 0.4070351960757298d, y: 0.5188402990209786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8819840025485203d, y: 0.5678627154559097d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4668738844489816d, y: 0.16198116461691892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292944285389924d, y: 0.42799600912934066d), new NpgsqlTypes.NpgsqlPoint(x: 0.058182951969735885d, y: 0.4816683543707687d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18076063046861157d, y: 0.12205569236653169d), new NpgsqlTypes.NpgsqlPoint(x: 0.33334950924610884d, y: 0.33673707789928353d), new NpgsqlTypes.NpgsqlPoint(x: 0.1938046836203302d, y: 0.30394217184568084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5717730595858137d, y: 0.9024017458529154d), new NpgsqlTypes.NpgsqlPoint(x: 0.45039196237952495d, y: 0.9732133616657419d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901108134746389d, y: 0.6268388426570553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.640159627952252d, y: 0.22836643048793648d), new NpgsqlTypes.NpgsqlPoint(x: 0.4830211217377012d, y: 0.296086482922719d), new NpgsqlTypes.NpgsqlPoint(x: 0.06301224791958315d, y: 0.46908580684174916d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13349564839294825d, y: 0.023762402402065952d), new NpgsqlTypes.NpgsqlPoint(x: 0.23909127166972d, y: 0.6503182502490364d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846708006918244d, y: 0.9549251556861184d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07830408014185997d, y: 0.35772616846188143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205935592953742d, y: 0.526663570829563d), new NpgsqlTypes.NpgsqlPoint(x: 0.4291272503269822d, y: 0.334707155283932d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44242955465494604d, y: 0.8005164498907508d), new NpgsqlTypes.NpgsqlPoint(x: 0.10046158602791366d, y: 0.46462875147515836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5483680304404451d, y: 0.15537163889872985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6122207518654933d, y: 0.90641772515369d), new NpgsqlTypes.NpgsqlPoint(x: 0.234418766608678d, y: 0.25434950021067204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8776438201050839d, y: 0.8157049960293777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06003569384755758d, y: 0.6830283861591856d), new NpgsqlTypes.NpgsqlPoint(x: 0.1614347033255824d, y: 0.44468058342855166d), new NpgsqlTypes.NpgsqlPoint(x: 0.45973444074455305d, y: 0.04229071255200645d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4197958742546275d, y: 0.5750749178530892d), new NpgsqlTypes.NpgsqlPoint(x: 0.15157686203443077d, y: 0.5030904120240343d), new NpgsqlTypes.NpgsqlPoint(x: 0.39667287658558303d, y: 0.7100119490534179d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9599041351713913d, y: 0.07374286732913837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322329704079857d, y: 0.38340762519308336d), new NpgsqlTypes.NpgsqlPoint(x: 0.15288803065970147d, y: 0.5960490754347528d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26534741390161065d, y: 0.8017667233702325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215019482966087d, y: 0.5307309932923673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8871436985306616d, y: 0.5220381416722369d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3237256000822607d, y: 0.16369782853067372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799630042515608d, y: 0.10764101201818776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287521216584669d, y: 0.766983922303787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5956490288051658d, y: 0.8747797959535156d), new NpgsqlTypes.NpgsqlPoint(x: 0.3841481196978477d, y: 0.23778470728965428d), new NpgsqlTypes.NpgsqlPoint(x: 0.4527778984258911d, y: 0.8613893037198614d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7035875795260337d, y: 0.27066089153358075d), new NpgsqlTypes.NpgsqlPoint(x: 0.84933814388002d, y: 0.5166271059080969d), new NpgsqlTypes.NpgsqlPoint(x: 0.6349446817972916d, y: 0.6928846379669996d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43360627486619496d, y: 0.5616346070578424d), new NpgsqlTypes.NpgsqlPoint(x: 0.4003583578365836d, y: 0.34061688245596433d), new NpgsqlTypes.NpgsqlPoint(x: 0.24119546868641994d, y: 0.16184589009466466d)),
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
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20071411370257675d, y: 0.2887780977324803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539784061952693d, y: 0.20133640655775775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618734348946431d, y: 0.9547324009806287d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3195600064649251d, y: 0.8771865137062546d), new NpgsqlTypes.NpgsqlPoint(x: 0.0841006606204554d, y: 0.39544754341862165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903731357823423d, y: 0.34976103338080466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13692703651754778d, y: 0.1943965820185357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423679645013987d, y: 0.692772383960896d), new NpgsqlTypes.NpgsqlPoint(x: 0.04142688924293514d, y: 0.2779019826271021d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6343621820575508d, y: 0.3334912717310252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995054396686641d, y: 0.005492966585024739d), new NpgsqlTypes.NpgsqlPoint(x: 0.45683796093318774d, y: 0.37579839893049893d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7293026643637301d, y: 0.6068297280850548d), new NpgsqlTypes.NpgsqlPoint(x: 0.44940693230561035d, y: 0.22747843429389858d), new NpgsqlTypes.NpgsqlPoint(x: 0.6755062562873044d, y: 0.7201420409229341d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2657895911763247d, y: 0.4050889392896766d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222118043464991d, y: 0.03796703786082434d), new NpgsqlTypes.NpgsqlPoint(x: 0.28551916165490643d, y: 0.9485701906839811d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7030280867944564d, y: 0.28855684491831124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934583889949144d, y: 0.4789624527749252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821271834384949d, y: 0.9724346631639115d)),
}));
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
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8380649007084552d, y: 0.5947770650305294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945563090018995d, y: 0.7790130626474113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739446126808819d, y: 0.8839814067902744d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0743803555271011d, y: 0.4839289493837896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6439400316195909d, y: 0.5020904454257906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9982890268198434d, y: 0.48510210624597605d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03250485434726669d, y: 0.9300741255885602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4880493787571043d, y: 0.7984449575854928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396086249277305d, y: 0.26561655069977164d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15649257954289075d, y: 0.8331040158203044d), new NpgsqlTypes.NpgsqlPoint(x: 0.15416556319797547d, y: 0.6363052775293752d), new NpgsqlTypes.NpgsqlPoint(x: 0.8692872294741406d, y: 0.9457648595916773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9109629517193718d, y: 0.7616235398303618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019224487272984d, y: 0.8047120515164947d), new NpgsqlTypes.NpgsqlPoint(x: 0.7068950955826986d, y: 0.10151857975636847d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16865369050390877d, y: 0.6967143202813472d), new NpgsqlTypes.NpgsqlPoint(x: 0.3391173247548591d, y: 0.5564310100994331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9295448403448556d, y: 0.026266928767133657d)),
}));
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[34], false);
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
                parametr1.Value = 22;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 6, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 8, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 22, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 48, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 8, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 148, query1, 54, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 74, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 163, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 99, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[34], false);
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
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[29], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[30], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[31], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[32], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[33], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[29], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[30], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[31], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[32], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[33], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[34], false);
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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

