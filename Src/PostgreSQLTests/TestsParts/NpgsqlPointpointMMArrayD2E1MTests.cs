

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
    internal partial interface INpgsqlPointMArraypointMMArrayD2
    {
    }
    
    internal partial class NpgsqlPointMArraypointMMArrayD2 : INpgsqlPointMArraypointMMArrayD2
    {


#region TestData

        private readonly NpgsqlPointpointMMArrayD2E1M[] _testData = new NpgsqlPointpointMMArrayD2E1M[]
        {
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3246882774408961d, y: 0.6841770876500101d), new NpgsqlTypes.NpgsqlPoint(x: 0.2549789300529314d, y: 0.6997100005869143d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.025247514165213758d, y: 0.5535531692461426d), new NpgsqlTypes.NpgsqlPoint(x: 0.31908296974194106d, y: 0.9468100237518222d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2843018761564945d, y: 0.9041502042348685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9304103230100143d, y: 0.03398569643083782d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4950029955967633d, y: 0.16287393685285945d), new NpgsqlTypes.NpgsqlPoint(x: 0.607231489333787d, y: 0.38859016593903006d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.030603581201432806d, y: 0.04076584400393746d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101894577488233d, y: 0.31896251832307654d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.04740714653914435d, y: 0.5804883048194016d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544809695541d, y: 0.12710469979638428d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3855191834309316d, y: 0.07134861110222868d), new NpgsqlTypes.NpgsqlPoint(x: 0.18340030250893857d, y: 0.5396585452850521d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8238498576288821d, y: 0.7161038506246842d), new NpgsqlTypes.NpgsqlPoint(x: 0.6445615970272848d, y: 0.6549016867308841d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4036276904224825d, y: 0.2167753042247743d), new NpgsqlTypes.NpgsqlPoint(x: 0.18490014641820973d, y: 0.16004822778389183d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7807491206186944d, y: 0.5973530184322662d), new NpgsqlTypes.NpgsqlPoint(x: 0.110148164094383d, y: 0.2430527474178671d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.053974989433521636d, y: 0.6268618706682185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7018181479308304d, y: 0.2568981768242864d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5863436067772473d, y: 0.2301269957599098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8839069120163863d, y: 0.8416349770741972d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.004837654074276276d, y: 0.7624949891145684d), new NpgsqlTypes.NpgsqlPoint(x: 0.08243676919912635d, y: 0.37663551468741974d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1694148393261019d, y: 0.7984675027722359d), new NpgsqlTypes.NpgsqlPoint(x: 0.3037373718968387d, y: 0.20286390007722843d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.048688150431822175d, y: 0.25154427436712934d), new NpgsqlTypes.NpgsqlPoint(x: 0.018999265974643853d, y: 0.43365625892698445d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6814631797038294d, y: 0.8069121928127179d), new NpgsqlTypes.NpgsqlPoint(x: 0.7143521515174053d, y: 0.5941450435139136d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4186573841006065d, y: 0.0902130693209876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9386614293299907d, y: 0.8852621617431407d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3334514142452991d, y: 0.5884800369063541d), new NpgsqlTypes.NpgsqlPoint(x: 0.6294738680826476d, y: 0.06163850072398047d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7785835728642776d, y: 0.5494449259075304d), new NpgsqlTypes.NpgsqlPoint(x: 0.529956621529779d, y: 0.8588585011668246d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10030717327840677d, y: 0.7977444779835917d), new NpgsqlTypes.NpgsqlPoint(x: 0.531855330018471d, y: 0.41419895607170165d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6163050403097783d, y: 0.32289945974644574d), new NpgsqlTypes.NpgsqlPoint(x: 0.0380665151124252d, y: 0.10852949052113625d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7171816405823541d, y: 0.2107409881150506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8456150953135444d, y: 0.5570191195975716d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7429854979669288d, y: 0.22545432608032845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7814960273807458d, y: 0.515177360467043d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.30246578057859597d, y: 0.23925029232601713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936464665704731d, y: 0.11881153488741458d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6833286815920625d, y: 0.9879141639205984d), new NpgsqlTypes.NpgsqlPoint(x: 0.4055796250922554d, y: 0.6119261849807959d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1255957488945142d, y: 0.8290824654945362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638791068356147d, y: 0.7649721766738885d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.943115522068506d, y: 0.8638216467225366d), new NpgsqlTypes.NpgsqlPoint(x: 0.460323705283495d, y: 0.9404363199066597d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.04027406558399749d, y: 0.4735005527842516d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032352655798116d, y: 0.07704306608813483d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8794296694791058d, y: 0.6255845448955812d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318050010733389d, y: 0.8458029329008084d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.580207290479475d, y: 0.09025218917303279d), new NpgsqlTypes.NpgsqlPoint(x: 0.179935726495421d, y: 0.08010673011030178d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.23465898178807187d, y: 0.22853727882345076d), new NpgsqlTypes.NpgsqlPoint(x: 0.6330920174260095d, y: 0.9333636356849457d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6118909500262963d, y: 0.8861518818943724d), new NpgsqlTypes.NpgsqlPoint(x: 0.1974883877980229d, y: 0.02470848831814043d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.04222169216857363d, y: 0.4200812403791052d), new NpgsqlTypes.NpgsqlPoint(x: 0.33992494653266736d, y: 0.22370022301760017d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.48818372225508344d, y: 0.27405495508593913d), new NpgsqlTypes.NpgsqlPoint(x: 0.7207686587119945d, y: 0.18516513611041685d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6442274660669234d, y: 0.9741242992541673d), new NpgsqlTypes.NpgsqlPoint(x: 0.2048226144805867d, y: 0.9159423966449757d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2060955974674734d, y: 0.2950164780739293d), new NpgsqlTypes.NpgsqlPoint(x: 0.02204625224759771d, y: 0.3984038021248758d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.04985320752054945d, y: 0.8704526672341933d), new NpgsqlTypes.NpgsqlPoint(x: 0.1844002117275816d, y: 0.2315185935278049d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9025037972755785d, y: 0.5388435060097805d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126884343873843d, y: 0.42000370450283586d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9110208026775533d, y: 0.3470390827366101d), new NpgsqlTypes.NpgsqlPoint(x: 0.9286044539331287d, y: 0.7858361939039148d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.31393021939602384d, y: 0.6376699668133838d), new NpgsqlTypes.NpgsqlPoint(x: 0.32141324122425385d, y: 0.1348175024229793d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9338172215562721d, y: 0.9725796198917148d), new NpgsqlTypes.NpgsqlPoint(x: 0.0617939078561065d, y: 0.04912060969217169d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8299042801254654d, y: 0.0014504674508989401d), new NpgsqlTypes.NpgsqlPoint(x: 0.968327537870152d, y: 0.2739096679008751d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2972340565317724d, y: 0.04945503449191613d), new NpgsqlTypes.NpgsqlPoint(x: 0.824006447161271d, y: 0.19612582283125168d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3662090677369825d, y: 0.5420869805213343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046839671276359d, y: 0.42929745921702134d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5529957645343953d, y: 0.46846214165367117d), new NpgsqlTypes.NpgsqlPoint(x: 0.32283458818812205d, y: 0.14319558562953494d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6185498910680879d, y: 0.3980276866360256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8427903901771906d, y: 0.5547675878494868d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.09487934454713687d, y: 0.2766679954194493d), new NpgsqlTypes.NpgsqlPoint(x: 0.28392651772586097d, y: 0.2022714590389375d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.020967457860722294d, y: 0.20089764002440158d), new NpgsqlTypes.NpgsqlPoint(x: 0.14393196777544504d, y: 0.2724993849643337d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9728630902164088d, y: 0.5299504624149621d), new NpgsqlTypes.NpgsqlPoint(x: 0.4728683773228499d, y: 0.33510528915850535d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4626439503487677d, y: 0.8181137289347427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975834764130296d, y: 0.8269914912372981d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7635533143907778d, y: 0.825588147789719d), new NpgsqlTypes.NpgsqlPoint(x: 0.028242901985895297d, y: 0.35292337130825135d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.385068661624393d, y: 0.74688295406301d), new NpgsqlTypes.NpgsqlPoint(x: 0.22444470155543628d, y: 0.6338994783680151d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3298562905098842d, y: 0.03738154545247374d), new NpgsqlTypes.NpgsqlPoint(x: 0.4088534767121964d, y: 0.3835932703065429d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9764865548775422d, y: 0.6372609297965985d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350770620618521d, y: 0.5707912809964011d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3334927181219095d, y: 0.19570330301534078d), new NpgsqlTypes.NpgsqlPoint(x: 0.27204612731600486d, y: 0.8063254848923591d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8097635715734016d, y: 0.5762876055001634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5949127009374955d, y: 0.30049254798429414d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3054926596580029d, y: 0.7707612347965522d), new NpgsqlTypes.NpgsqlPoint(x: 0.04096410782215609d, y: 0.6525013790296821d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.07704440423326786d, y: 0.9942448510792465d), new NpgsqlTypes.NpgsqlPoint(x: 0.10400839521831018d, y: 0.6862724564278214d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8706757586690876d, y: 0.06825814058247837d), new NpgsqlTypes.NpgsqlPoint(x: 0.2596540687387593d, y: 0.7648233015547613d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9171934169998323d, y: 0.7699346254908348d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708099682015091d, y: 0.1000934714619276d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.04961742500798616d, y: 0.6172556679057108d), new NpgsqlTypes.NpgsqlPoint(x: 0.1456243522705607d, y: 0.8213878887565398d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9065489061809535d, y: 0.1912745828135568d), new NpgsqlTypes.NpgsqlPoint(x: 0.0404036923854636d, y: 0.7196379740613359d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7369213170397501d, y: 0.07628477432569403d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271391018859598d, y: 0.010638070749547701d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.27101360261807017d, y: 0.9586168262681698d), new NpgsqlTypes.NpgsqlPoint(x: 0.789945336651062d, y: 0.014557296272334153d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6174823159476288d, y: 0.1904006578758941d), new NpgsqlTypes.NpgsqlPoint(x: 0.864615190495701d, y: 0.0923610208916732d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5796121374533859d, y: 0.6414062212897176d), new NpgsqlTypes.NpgsqlPoint(x: 0.4047546863151871d, y: 0.6621386503965369d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3564597544437459d, y: 0.4849863453631603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879729538224411d, y: 0.8697378359611848d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3807703791599427d, y: 0.9760467577086673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878680534424948d, y: 0.49129468972535584d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7706808824828393d, y: 0.6247789971757413d), new NpgsqlTypes.NpgsqlPoint(x: 0.31556234745238143d, y: 0.856015155158223d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8061968140423027d, y: 0.9692742595745963d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661976120752946d, y: 0.15447064706404146d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7404340965817737d, y: 0.6722657245795833d), new NpgsqlTypes.NpgsqlPoint(x: 0.0404644849575031d, y: 0.7697294344318313d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.44145209668993224d, y: 0.0858995171086735d), new NpgsqlTypes.NpgsqlPoint(x: 0.14587589969828763d, y: 0.8894566133156068d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.17377477213698345d, y: 0.803397831890026d), new NpgsqlTypes.NpgsqlPoint(x: 0.38518502712753266d, y: 0.42836413073323576d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6381306289063803d, y: 0.33147767989085275d), new NpgsqlTypes.NpgsqlPoint(x: 0.9208537428605713d, y: 0.3455674797089746d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8450184464741669d, y: 0.3399396103884872d), new NpgsqlTypes.NpgsqlPoint(x: 0.6364954258070804d, y: 0.658503006409091d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6443739301050969d, y: 0.1542883339542952d), new NpgsqlTypes.NpgsqlPoint(x: 0.15518174298696186d, y: 0.6863714243470247d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5326566119659857d, y: 0.9272458269402495d), new NpgsqlTypes.NpgsqlPoint(x: 0.3600839208950134d, y: 0.9309019401563207d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.40103505285489593d, y: 0.6689649258030974d), new NpgsqlTypes.NpgsqlPoint(x: 0.185985292687037d, y: 0.5565582282540306d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2429072278714387d, y: 0.911204320970706d), new NpgsqlTypes.NpgsqlPoint(x: 0.25232754050661654d, y: 0.24010448684725538d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9880588233878905d, y: 0.36324821181506006d), new NpgsqlTypes.NpgsqlPoint(x: 0.30403288665982475d, y: 0.1330558450685082d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3091900535650156d, y: 0.1665875522264605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8544866982149367d, y: 0.6367838029137255d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.549245973872243d, y: 0.6558255874369474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5532384415103717d, y: 0.20356329082461d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7441292784835333d, y: 0.9937235534925023d), new NpgsqlTypes.NpgsqlPoint(x: 0.45572339409463847d, y: 0.2383314804946911d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5665776171251399d, y: 0.5809428066669102d), new NpgsqlTypes.NpgsqlPoint(x: 0.8573721866875182d, y: 0.19187298205225367d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.039711925460947595d, y: 0.5804583718850996d), new NpgsqlTypes.NpgsqlPoint(x: 0.774147987305125d, y: 0.7862783601824247d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3987314439875074d, y: 0.20925939416746842d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445344536549135d, y: 0.2616798918845935d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7857808570782425d, y: 0.883655438383904d), new NpgsqlTypes.NpgsqlPoint(x: 0.4197046965943636d, y: 0.556549814032238d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1170104733438484d, y: 0.6576053902296839d), new NpgsqlTypes.NpgsqlPoint(x: 0.24639323078296094d, y: 0.759058234251635d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.09515117119003991d, y: 0.6866230175447702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6355607636320609d, y: 0.4793127475934751d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.30749761078828164d, y: 0.5628334346056764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7165465868633802d, y: 0.18200303944755714d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.38791215139971946d, y: 0.7743041278613961d), new NpgsqlTypes.NpgsqlPoint(x: 0.48248324535774023d, y: 0.12208006743606592d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.166985662116925d, y: 0.9142824332113381d), new NpgsqlTypes.NpgsqlPoint(x: 0.2483375532505453d, y: 0.05322188057942534d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5259331818783262d, y: 0.1891413880045234d), new NpgsqlTypes.NpgsqlPoint(x: 0.9564487287098551d, y: 0.3504674945034707d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8691550288297167d, y: 0.10305726172515361d), new NpgsqlTypes.NpgsqlPoint(x: 0.08213661684587792d, y: 0.228934379250332d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.27539296453285034d, y: 0.29319841486203924d), new NpgsqlTypes.NpgsqlPoint(x: 0.175695944518115d, y: 0.806403667646215d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.469731709757069d, y: 0.20545775588753556d), new NpgsqlTypes.NpgsqlPoint(x: 0.06869047916214066d, y: 0.37892064738017883d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7532389238144825d, y: 0.6323371404878436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662531643769253d, y: 0.417443573501325d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6534738171925116d, y: 0.31746056012037605d), new NpgsqlTypes.NpgsqlPoint(x: 0.565721999896756d, y: 0.5825788678079155d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6784637804977576d, y: 0.6449297763835967d), new NpgsqlTypes.NpgsqlPoint(x: 0.19526056919284285d, y: 0.7996406095980604d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2830547082670162d, y: 0.784761069463037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093459837007871d, y: 0.304825892436117d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3566907513892513d, y: 0.9421882494722793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7925565778836583d, y: 0.8170771971554366d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9037348200556774d, y: 0.874058533584757d), new NpgsqlTypes.NpgsqlPoint(x: 0.6653639631050667d, y: 0.6929632896385449d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.012694674866944533d, y: 0.743574533550749d), new NpgsqlTypes.NpgsqlPoint(x: 0.050551028489950856d, y: 0.2744476995857885d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8274815118878552d, y: 0.021277578173876988d), new NpgsqlTypes.NpgsqlPoint(x: 0.060558197682730075d, y: 0.9516221216942411d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.04847346910581363d, y: 0.20474069175082033d), new NpgsqlTypes.NpgsqlPoint(x: 0.09148093803658408d, y: 0.9184993833921009d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.45270118679244065d, y: 0.5646197568387676d), new NpgsqlTypes.NpgsqlPoint(x: 0.22727203186175782d, y: 0.26404635190773496d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.49669642317632623d, y: 0.2970270943183735d), new NpgsqlTypes.NpgsqlPoint(x: 0.678564870214022d, y: 0.7009944423899097d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4850730832942881d, y: 0.8717512993613694d), new NpgsqlTypes.NpgsqlPoint(x: 0.24032054514569812d, y: 0.28113005846572614d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2660487683469489d, y: 0.46432584213024886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622220498662467d, y: 0.05808704801324027d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.28692917612062085d, y: 0.8770254778845736d), new NpgsqlTypes.NpgsqlPoint(x: 0.7106282242500771d, y: 0.507640353173696d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.40388302082389294d, y: 0.12036174611971862d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808109798234356d, y: 0.6437203075047082d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.29459257481573975d, y: 0.6639917194927701d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884053492091257d, y: 0.8311490929820474d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4440207775354029d, y: 0.012843162910240902d), new NpgsqlTypes.NpgsqlPoint(x: 0.8677414551773847d, y: 0.281282071877784d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3577821848735847d, y: 0.021346956143747375d), new NpgsqlTypes.NpgsqlPoint(x: 0.11631289584725424d, y: 0.8827720389937704d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.13079118077045793d, y: 0.9705474372774334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6009030930450143d, y: 0.2535703320588375d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.27893550917405185d, y: 0.0674238147975057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572297091825718d, y: 0.8081254838386264d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.08103476034156132d, y: 0.9892580529705801d), new NpgsqlTypes.NpgsqlPoint(x: 0.14092776475886792d, y: 0.6851029165103686d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5764124452731094d, y: 0.8535598753860768d), new NpgsqlTypes.NpgsqlPoint(x: 0.5348325711047994d, y: 0.6561760914180514d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.46384201922384316d, y: 0.8224588604382147d), new NpgsqlTypes.NpgsqlPoint(x: 0.032191665383580204d, y: 0.7392551622498189d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.030707631731167973d, y: 0.4823053083366483d), new NpgsqlTypes.NpgsqlPoint(x: 0.40892270914865225d, y: 0.4614327212999767d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8875877667357955d, y: 0.6985638620086008d), new NpgsqlTypes.NpgsqlPoint(x: 0.16949308738605906d, y: 0.7950382041170688d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.619173572787531d, y: 0.7203771613444512d), new NpgsqlTypes.NpgsqlPoint(x: 0.507317481766573d, y: 0.8040788673888112d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8195549232110813d, y: 0.5973472483100348d), new NpgsqlTypes.NpgsqlPoint(x: 0.32975663476287886d, y: 0.8674170551386724d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3796891617312187d, y: 0.20464724408286894d), new NpgsqlTypes.NpgsqlPoint(x: 0.30769940826234254d, y: 0.6439943883933464d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.17285177655856088d, y: 0.15603507659332716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8445116641728129d, y: 0.4002657698066582d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9737850049571d, y: 0.03387591433920201d), new NpgsqlTypes.NpgsqlPoint(x: 0.4840642329119167d, y: 0.37176788633069535d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8110620439941818d, y: 0.729741799960556d), new NpgsqlTypes.NpgsqlPoint(x: 0.5138259001205729d, y: 0.3085943633937065d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7274468655813501d, y: 0.7333824547394752d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142486816413785d, y: 0.8227905320244927d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2138801055464521d, y: 0.14432668097092294d), new NpgsqlTypes.NpgsqlPoint(x: 0.48217835068680726d, y: 0.663667946393771d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.495556159766094d, y: 0.9618138253424583d), new NpgsqlTypes.NpgsqlPoint(x: 0.39767484753822413d, y: 0.5252184949572075d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7426469841987073d, y: 0.943846727050629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187344366094369d, y: 0.11650090780809608d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4372974299681649d, y: 0.9948227485514592d), new NpgsqlTypes.NpgsqlPoint(x: 0.64746178306731d, y: 0.2623394571942942d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.002553382954656236d, y: 0.2966626988029646d), new NpgsqlTypes.NpgsqlPoint(x: 0.3226680120702128d, y: 0.3179626909902562d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9139007235973786d, y: 0.1846579112443354d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629730628886046d, y: 0.191673044938941d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9639010054298285d, y: 0.29110290115804627d), new NpgsqlTypes.NpgsqlPoint(x: 0.1586832870450301d, y: 0.1288463486063992d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2900461719123011d, y: 0.7454930285192876d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535308015727492d, y: 0.17442558601412794d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.1544700136939633d, y: 0.05314388132211645d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274328081969941d, y: 0.30209982773196364d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.027833316876443748d, y: 0.25966320634324214d), new NpgsqlTypes.NpgsqlPoint(x: 0.613123086609159d, y: 0.21589503876576632d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.801313062581082d, y: 0.7656968773756901d), new NpgsqlTypes.NpgsqlPoint(x: 0.3911376705640437d, y: 0.32652097282360415d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.12210965583027433d, y: 0.37798429625888796d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486717757720859d, y: 0.9118915401553821d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.40912659853571487d, y: 0.008535263013576322d), new NpgsqlTypes.NpgsqlPoint(x: 7.321390837089492E-05d, y: 0.48070654436298743d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.776649506694233d, y: 0.7099867940867043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9075732960647943d, y: 0.0338233040542989d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.07912902348119855d, y: 0.8845535188597925d), new NpgsqlTypes.NpgsqlPoint(x: 0.23241253861313416d, y: 0.3171774681783909d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.27247058402416535d, y: 0.22614756058826224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6000232086154419d, y: 0.733301447734673d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.06826535903001574d, y: 0.72453541179201d), new NpgsqlTypes.NpgsqlPoint(x: 0.05963965526670223d, y: 0.02447761462353193d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6190517255346886d, y: 0.08894832454016266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9701730746089389d, y: 0.6553672485260824d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.34059358434064824d, y: 0.2404035536577359d), new NpgsqlTypes.NpgsqlPoint(x: 0.794438461905266d, y: 0.16317477016116366d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4026851645250421d, y: 0.5647215052676698d), new NpgsqlTypes.NpgsqlPoint(x: 0.9999412687342071d, y: 0.005617760391740334d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.34704914149981114d, y: 0.17430664654606798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937284917840695d, y: 0.07349812882955897d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7779567573706166d, y: 0.44232541839250406d), new NpgsqlTypes.NpgsqlPoint(x: 0.4263591012995944d, y: 0.4692660280657889d), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
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

                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd2e1mi_id
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
    npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7429854979669288d, y: 0.22545432608032845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7814960273807458d, y: 0.515177360467043d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.30246578057859597d, y: 0.23925029232601713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936464665704731d, y: 0.11881153488741458d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.04222169216857363d, y: 0.4200812403791052d), new NpgsqlTypes.NpgsqlPoint(x: 0.33992494653266736d, y: 0.22370022301760017d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.48818372225508344d, y: 0.27405495508593913d), new NpgsqlTypes.NpgsqlPoint(x: 0.7207686587119945d, y: 0.18516513611041685d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd2e1mi_id
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
    npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7635533143907778d, y: 0.825588147789719d), new NpgsqlTypes.NpgsqlPoint(x: 0.028242901985895297d, y: 0.35292337130825135d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.385068661624393d, y: 0.74688295406301d), new NpgsqlTypes.NpgsqlPoint(x: 0.22444470155543628d, y: 0.6338994783680151d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD2E1M> models = null;

                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD2E1M> models = null;

                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr2.Value = 93;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 143, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 112, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 34, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 68, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 166, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 39, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 93, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 16, 166))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 78, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointMArraypointMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointMArraypointMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointMArraypointMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointMArraypointMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((INpgsqlPointMArraypointMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
FROM public.binary_npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointMArraypointMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA), typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA), typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI), typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA), typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

