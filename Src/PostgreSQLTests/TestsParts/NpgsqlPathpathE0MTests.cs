

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpathE0M[] _testData = new NpgsqlPathpathE0M[]
        {
            new NpgsqlPathpathE0M
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7806712851180767d, y: 0.9303387081948017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3520999063092761d, y: 0.4303423537496128d), new NpgsqlTypes.NpgsqlPoint(x: 0.331466030546286d, y: 0.921615053832415d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7247090472674472d, y: 0.9339782887814201d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253313166532324d, y: 0.5752860643247214d), new NpgsqlTypes.NpgsqlPoint(x: 0.21857314003793793d, y: 0.03701240717250187d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.80950138974335d, y: 0.333514826928203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752737445149164d, y: 0.4200443609888638d), new NpgsqlTypes.NpgsqlPoint(x: 0.45037044147525407d, y: 0.570710231083539d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.705163955339244d, y: 0.3153114592293724d), new NpgsqlTypes.NpgsqlPoint(x: 0.4589497222201314d, y: 0.4996444608707963d), new NpgsqlTypes.NpgsqlPoint(x: 0.054134475659257664d, y: 0.461303831189561d)),
},
            new NpgsqlPathpathE0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21515885992322703d, y: 0.40323873450697956d), new NpgsqlTypes.NpgsqlPoint(x: 0.17509772521639522d, y: 0.5141586651703457d), new NpgsqlTypes.NpgsqlPoint(x: 0.26098804655910945d, y: 0.7784053157542223d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6683779563393362d, y: 0.4005054816678095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8531825315177249d, y: 0.3989534266756929d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327564251845339d, y: 0.9033236452652466d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006001624815018092d, y: 0.6763689520242846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270861736234934d, y: 0.41037470364830475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7793119684466671d, y: 0.6203744012757396d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061832191356487654d, y: 0.28225250385402045d), new NpgsqlTypes.NpgsqlPoint(x: 9.018067566013421E-05d, y: 0.27127047215136413d), new NpgsqlTypes.NpgsqlPoint(x: 0.20880503218347823d, y: 0.4264198511305799d)),
},
            new NpgsqlPathpathE0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8941060355244045d, y: 0.6402121783260235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3215957714476665d, y: 0.34879315922673115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8242535700590875d, y: 0.5426545713980204d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7571752381372975d, y: 0.219208114222596d), new NpgsqlTypes.NpgsqlPoint(x: 0.34262095581537355d, y: 0.1493059533249661d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408809911449805d, y: 0.020404981685522183d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28819989863390605d, y: 0.23609043158893306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3215425871951163d, y: 0.654480172351982d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933237337056722d, y: 0.18837250688357154d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.427425190493798d, y: 0.6961124584616604d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610472145727546d, y: 0.3442810913086307d), new NpgsqlTypes.NpgsqlPoint(x: 0.837865451239259d, y: 0.2571307138573985d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3766279522387235d, y: 0.30263249996889774d), new NpgsqlTypes.NpgsqlPoint(x: 0.29483057372054633d, y: 0.7207157162453166d), new NpgsqlTypes.NpgsqlPoint(x: 0.25065902231057346d, y: 0.8959288460879027d)),
},
            new NpgsqlPathpathE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6377361124180912d, y: 0.03120886608724338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3048150539398514d, y: 0.15942797932748531d), new NpgsqlTypes.NpgsqlPoint(x: 0.23588903348424162d, y: 0.15618208131220113d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21893553730733362d, y: 0.6247108646485154d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383621573754551d, y: 0.5793203764763355d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711231789011201d, y: 0.6209742721303109d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.062490599102038025d, y: 0.8179030646681043d), new NpgsqlTypes.NpgsqlPoint(x: 0.69452775335875d, y: 0.761461402348097d), new NpgsqlTypes.NpgsqlPoint(x: 0.3981780090899153d, y: 0.9874158986831735d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7758966075659413d, y: 0.6940580829841471d), new NpgsqlTypes.NpgsqlPoint(x: 0.755186148890223d, y: 0.45185094087272115d), new NpgsqlTypes.NpgsqlPoint(x: 0.801476315120517d, y: 0.7301620033653123d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7786851854673513d, y: 0.10003494869168794d), new NpgsqlTypes.NpgsqlPoint(x: 0.24813620940794867d, y: 0.8366101456181559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789673010332814d, y: 0.6752476463481123d)),
},
            new NpgsqlPathpathE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23753264898289195d, y: 0.017791520372228642d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553379649755232d, y: 0.8038178762780965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180394954728671d, y: 0.18642124253371606d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6467495297014123d, y: 0.2835884163991479d), new NpgsqlTypes.NpgsqlPoint(x: 0.13986199862429538d, y: 0.7217315269529292d), new NpgsqlTypes.NpgsqlPoint(x: 0.37041239258371517d, y: 0.3458179762496504d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9752743933032023d, y: 0.6098687470083103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903008560698899d, y: 0.6565289606516888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867110861086468d, y: 0.2775416561498044d)),
},
            new NpgsqlPathpathE0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8027488573589581d, y: 0.36271728863130126d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671148805712089d, y: 0.32500116527077727d), new NpgsqlTypes.NpgsqlPoint(x: 0.197941580632505d, y: 0.41520585611661387d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5938373463372449d, y: 0.0901103078369555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4483892162618943d, y: 0.8011408472465474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6843877275440882d, y: 0.37946539343110464d)),
},
            new NpgsqlPathpathE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2636761608700575d, y: 0.834038965601895d), new NpgsqlTypes.NpgsqlPoint(x: 0.0995851329844073d, y: 0.20270713581499733d), new NpgsqlTypes.NpgsqlPoint(x: 0.40692689681156524d, y: 0.009434196168120468d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06702180654059264d, y: 0.07505339177520232d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580429359889754d, y: 0.038883375722095326d), new NpgsqlTypes.NpgsqlPoint(x: 0.08110212036611586d, y: 0.08274629223663144d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36701555330182367d, y: 0.6849442650512986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944625401071011d, y: 0.748137240276312d), new NpgsqlTypes.NpgsqlPoint(x: 0.4521762884001772d, y: 0.8301548082351663d)),
},
            new NpgsqlPathpathE0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4710088319122193d, y: 0.6086898369138857d), new NpgsqlTypes.NpgsqlPoint(x: 0.18229116859162675d, y: 0.41450566938354205d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579118525187488d, y: 0.4578174749715057d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.811883133435817d, y: 0.7637577920067035d), new NpgsqlTypes.NpgsqlPoint(x: 0.2458055186770126d, y: 0.9185248236198664d), new NpgsqlTypes.NpgsqlPoint(x: 0.43569769162350136d, y: 0.8842572585313132d)),
},
            new NpgsqlPathpathE0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19398245829527583d, y: 0.7675563603498452d), new NpgsqlTypes.NpgsqlPoint(x: 0.7491467072892891d, y: 0.22802713267173125d), new NpgsqlTypes.NpgsqlPoint(x: 0.38753556891572016d, y: 0.6253387420886364d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5913769994337478d, y: 0.8564754895340267d), new NpgsqlTypes.NpgsqlPoint(x: 0.34638826316328086d, y: 0.1783004093448508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465026464386923d, y: 0.592110550177385d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9381772953027633d, y: 0.48895937236215403d), new NpgsqlTypes.NpgsqlPoint(x: 0.766369478665355d, y: 0.6468026803040511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168307253793294d, y: 0.9946911816280659d)),
},
            new NpgsqlPathpathE0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44791892139621914d, y: 0.6021818605831569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254762131533689d, y: 0.5373411954772773d), new NpgsqlTypes.NpgsqlPoint(x: 0.0472023007007899d, y: 0.16539645798588032d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37713944873837923d, y: 0.29552524231561617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8587427151243007d, y: 0.9678305267675654d), new NpgsqlTypes.NpgsqlPoint(x: 0.12337040187370674d, y: 0.9895697100966288d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6960967457079102d, y: 0.31178631608443486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032054463036025d, y: 0.11152602860564287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851673453781731d, y: 0.5615381076361451d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2337241761407466d, y: 0.27662961976475997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560747774532829d, y: 0.6298704862459927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707146410421482d, y: 0.9780698967852429d)),
},
            new NpgsqlPathpathE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18600936471089258d, y: 0.4057041993594461d), new NpgsqlTypes.NpgsqlPoint(x: 0.4458426805388711d, y: 0.06714697770061306d), new NpgsqlTypes.NpgsqlPoint(x: 0.541319776276368d, y: 0.5880406975738159d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1957433742332435d, y: 0.7863566338853074d), new NpgsqlTypes.NpgsqlPoint(x: 0.21816506472917607d, y: 0.7973091612254145d), new NpgsqlTypes.NpgsqlPoint(x: 0.1721036983157651d, y: 0.6333562468431627d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37033585285192294d, y: 0.04456118474069792d), new NpgsqlTypes.NpgsqlPoint(x: 0.48751509302794116d, y: 0.4819924352072862d), new NpgsqlTypes.NpgsqlPoint(x: 0.006396595149123274d, y: 0.8619612557783972d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0019646972260641826d, y: 0.1931010524492034d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860375488048446d, y: 0.9549118547799353d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581167740633863d, y: 0.8340041364218316d)),
},
            new NpgsqlPathpathE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30271155360177304d, y: 0.2564222796579264d), new NpgsqlTypes.NpgsqlPoint(x: 0.03881593599120414d, y: 0.8642203794847939d), new NpgsqlTypes.NpgsqlPoint(x: 0.458884002882476d, y: 0.8571903375910808d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1497126618731206d, y: 0.0554165644343968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534891632233515d, y: 0.8286882892290522d), new NpgsqlTypes.NpgsqlPoint(x: 0.023758535247521473d, y: 0.04317296280924965d)),
},
            new NpgsqlPathpathE0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111162967380964d, y: 0.005816515850587067d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880578934957482d, y: 0.7222243764305021d), new NpgsqlTypes.NpgsqlPoint(x: 0.972365747092909d, y: 0.24009933821340823d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38621263035834563d, y: 0.6358686576076888d), new NpgsqlTypes.NpgsqlPoint(x: 0.7894522586394683d, y: 0.7265046800480132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410673272345042d, y: 0.20788725458681445d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26193493729190964d, y: 0.8252046868467913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6666956159715527d, y: 0.8985733821031483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9639273433350233d, y: 0.7484759672693734d)),
},
            new NpgsqlPathpathE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7158861547092589d, y: 0.11890592688058566d), new NpgsqlTypes.NpgsqlPoint(x: 0.17430007946608927d, y: 0.39989455252361406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6614714081007513d, y: 0.2477470028300589d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6586290233450284d, y: 0.18423721120799086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479044361531118d, y: 0.7617401945772497d), new NpgsqlTypes.NpgsqlPoint(x: 0.08820911995956704d, y: 0.9312341552321404d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6744147377668268d, y: 0.885826715112669d), new NpgsqlTypes.NpgsqlPoint(x: 0.4744803009862908d, y: 0.030663757236229272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5793992243683168d, y: 0.15845659769763532d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3188500372146368d, y: 0.7834776293967042d), new NpgsqlTypes.NpgsqlPoint(x: 0.045659087189315106d, y: 0.5633431094717801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292185709881567d, y: 0.8722082542736028d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9150578580225687d, y: 0.7031689915012708d), new NpgsqlTypes.NpgsqlPoint(x: 0.3742075580709773d, y: 0.4015962573291163d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967587345938779d, y: 0.7207285966596783d)),
},
            new NpgsqlPathpathE0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8901824396151734d, y: 0.2631793055451984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253911026932105d, y: 0.68385583600567d), new NpgsqlTypes.NpgsqlPoint(x: 0.45810916919956013d, y: 0.35459336308739464d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9558978533378132d, y: 0.7463601527018818d), new NpgsqlTypes.NpgsqlPoint(x: 0.526205084020484d, y: 0.8121105212465374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8710317137543787d, y: 0.40504649564643946d)),
},
            new NpgsqlPathpathE0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2854490072116723d, y: 0.750434918894167d), new NpgsqlTypes.NpgsqlPoint(x: 0.0778067027723306d, y: 0.5079871314763637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460405310974852d, y: 0.984377214439987d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2539047245929331d, y: 0.9983587154068904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484906648427563d, y: 0.39590398341286315d), new NpgsqlTypes.NpgsqlPoint(x: 0.74968344357577d, y: 0.9349666233675359d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21851791238137985d, y: 0.552562870095514d), new NpgsqlTypes.NpgsqlPoint(x: 0.21716995591536004d, y: 0.5943251216919823d), new NpgsqlTypes.NpgsqlPoint(x: 0.27507344589153904d, y: 0.5437958124495406d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9944441804806852d, y: 0.5732351919157629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5977682044474427d, y: 0.22954995297796843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6177335088925185d, y: 0.6618600299024581d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2605918902294956d, y: 0.10338664970069333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2678634156388504d, y: 0.30818594397443355d), new NpgsqlTypes.NpgsqlPoint(x: 0.22513932450984753d, y: 0.05028582832726802d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11648927306540013d, y: 0.22551548445726943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160643111462461d, y: 0.9207669402509995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712058933482993d, y: 0.7229382756026319d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2810361521136362d, y: 0.3290007844513554d), new NpgsqlTypes.NpgsqlPoint(x: 0.16929432461137484d, y: 0.3337990213733538d), new NpgsqlTypes.NpgsqlPoint(x: 0.09280249853375244d, y: 0.4135121239807351d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048627631892556256d, y: 0.3472599428446994d), new NpgsqlTypes.NpgsqlPoint(x: 0.1258726934922687d, y: 0.12400550367357255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348536317962589d, y: 0.5322955385366552d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7881939997769777d, y: 0.07226344130180073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827820873787543d, y: 0.7483251435973869d), new NpgsqlTypes.NpgsqlPoint(x: 0.07459187525357935d, y: 0.8341854275770132d)),
},
            new NpgsqlPathpathE0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2183356016440171d, y: 0.862304393668213d), new NpgsqlTypes.NpgsqlPoint(x: 0.38070625512510536d, y: 0.730600026855956d), new NpgsqlTypes.NpgsqlPoint(x: 0.11943628806693962d, y: 0.5434938904938852d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7549584370278964d, y: 0.7080978470582036d), new NpgsqlTypes.NpgsqlPoint(x: 0.3722880514744017d, y: 0.7339855893284355d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484228194970607d, y: 0.7723673547845901d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9095359880248807d, y: 0.6129211804617889d), new NpgsqlTypes.NpgsqlPoint(x: 0.09106895466297726d, y: 0.6194138909835428d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794826198022703d, y: 0.9193953441368824d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5625543706649213d, y: 0.006577588776359833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8385369609608635d, y: 0.24050102674181184d), new NpgsqlTypes.NpgsqlPoint(x: 0.23458420013953207d, y: 0.6736652730010495d)),
},
            new NpgsqlPathpathE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4436313277783347d, y: 0.9419271060855037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7694865973701703d, y: 0.5025355279740928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760444862718552d, y: 0.08451692785497655d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.679249235888303d, y: 0.8986844768821646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213190003817081d, y: 0.4209109632927627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5306174243261996d, y: 0.9925527498316575d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07584965685929279d, y: 0.4563951787069582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309476792976515d, y: 0.8748748929773685d), new NpgsqlTypes.NpgsqlPoint(x: 0.43712656446600817d, y: 0.07816400234555387d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9439565812050006d, y: 0.14008024333657176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129865391688462d, y: 0.06138674019636714d), new NpgsqlTypes.NpgsqlPoint(x: 0.9306611388497285d, y: 0.7964271897667979d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4691485208461301d, y: 0.4097483450554029d), new NpgsqlTypes.NpgsqlPoint(x: 0.26412402707285787d, y: 0.2942600700396636d), new NpgsqlTypes.NpgsqlPoint(x: 0.9946978726936268d, y: 0.37884952431786956d)),
},
            new NpgsqlPathpathE0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7358119531955732d, y: 0.8223742208416988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519074941430982d, y: 0.6417483025928943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496407314162268d, y: 0.30465776068409567d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6122249899408159d, y: 0.3785815729727511d), new NpgsqlTypes.NpgsqlPoint(x: 0.01578976203717597d, y: 0.036563425362867386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551725509515636d, y: 0.062410474560900875d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8409502349908307d, y: 0.2873608786582753d), new NpgsqlTypes.NpgsqlPoint(x: 0.39389345788134367d, y: 0.28026772296781266d), new NpgsqlTypes.NpgsqlPoint(x: 0.786087980743154d, y: 0.49378772773878765d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24870966507358494d, y: 0.276228526939973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6884784357592871d, y: 0.17181591824455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329588011634105d, y: 0.38286858222202713d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5614397425519096d, y: 0.2774551762269013d), new NpgsqlTypes.NpgsqlPoint(x: 0.2897745036231345d, y: 0.655894342722083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519836676473806d, y: 0.5774591514533813d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7802943176151464d, y: 0.9758719232516261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349874325562354d, y: 0.07791360723619889d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682380809223891d, y: 0.6975442006335216d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44764931762745075d, y: 0.09859018362673688d), new NpgsqlTypes.NpgsqlPoint(x: 0.7969221654121127d, y: 0.010631380103786281d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424150427264609d, y: 0.1570493750020303d)),
},
            new NpgsqlPathpathE0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12377373898499966d, y: 0.07755609712797606d), new NpgsqlTypes.NpgsqlPoint(x: 0.43768430081485166d, y: 0.20595715128080427d), new NpgsqlTypes.NpgsqlPoint(x: 0.78819974973355d, y: 0.05130374684732919d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3766279522387235d, y: 0.30263249996889774d), new NpgsqlTypes.NpgsqlPoint(x: 0.29483057372054633d, y: 0.7207157162453166d), new NpgsqlTypes.NpgsqlPoint(x: 0.25065902231057346d, y: 0.8959288460879027d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7786851854673513d, y: 0.10003494869168794d), new NpgsqlTypes.NpgsqlPoint(x: 0.24813620940794867d, y: 0.8366101456181559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789673010332814d, y: 0.6752476463481123d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9752743933032023d, y: 0.6098687470083103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903008560698899d, y: 0.6565289606516888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867110861086468d, y: 0.2775416561498044d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5938373463372449d, y: 0.0901103078369555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4483892162618943d, y: 0.8011408472465474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6843877275440882d, y: 0.37946539343110464d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36701555330182367d, y: 0.6849442650512986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944625401071011d, y: 0.748137240276312d), new NpgsqlTypes.NpgsqlPoint(x: 0.4521762884001772d, y: 0.8301548082351663d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpathe0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpathe0mi_id", 
                methodParametrName: "npgsqlpathpathe0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr2.Value = 118;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 66;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 37, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 56, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 146, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 78, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 80, query1, 80, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 80, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 137, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 89, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 146, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 7, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[8], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[9], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[10], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[11], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[12], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[13], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[14], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[20],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[21],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[22],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[23],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[24],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[25],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[11], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[12], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[13], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[14], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[20],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[21],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[22],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7806712851180767d, y: 0.9303387081948017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3520999063092761d, y: 0.4303423537496128d), new NpgsqlTypes.NpgsqlPoint(x: 0.331466030546286d, y: 0.921615053832415d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7247090472674472d, y: 0.9339782887814201d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253313166532324d, y: 0.5752860643247214d), new NpgsqlTypes.NpgsqlPoint(x: 0.21857314003793793d, y: 0.03701240717250187d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.80950138974335d, y: 0.333514826928203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752737445149164d, y: 0.4200443609888638d), new NpgsqlTypes.NpgsqlPoint(x: 0.45037044147525407d, y: 0.570710231083539d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.705163955339244d, y: 0.3153114592293724d), new NpgsqlTypes.NpgsqlPoint(x: 0.4589497222201314d, y: 0.4996444608707963d), new NpgsqlTypes.NpgsqlPoint(x: 0.054134475659257664d, y: 0.461303831189561d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21515885992322703d, y: 0.40323873450697956d), new NpgsqlTypes.NpgsqlPoint(x: 0.17509772521639522d, y: 0.5141586651703457d), new NpgsqlTypes.NpgsqlPoint(x: 0.26098804655910945d, y: 0.7784053157542223d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6683779563393362d, y: 0.4005054816678095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8531825315177249d, y: 0.3989534266756929d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327564251845339d, y: 0.9033236452652466d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006001624815018092d, y: 0.6763689520242846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270861736234934d, y: 0.41037470364830475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7793119684466671d, y: 0.6203744012757396d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061832191356487654d, y: 0.28225250385402045d), new NpgsqlTypes.NpgsqlPoint(x: 9.018067566013421E-05d, y: 0.27127047215136413d), new NpgsqlTypes.NpgsqlPoint(x: 0.20880503218347823d, y: 0.4264198511305799d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8941060355244045d, y: 0.6402121783260235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3215957714476665d, y: 0.34879315922673115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8242535700590875d, y: 0.5426545713980204d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7571752381372975d, y: 0.219208114222596d), new NpgsqlTypes.NpgsqlPoint(x: 0.34262095581537355d, y: 0.1493059533249661d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408809911449805d, y: 0.020404981685522183d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28819989863390605d, y: 0.23609043158893306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3215425871951163d, y: 0.654480172351982d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933237337056722d, y: 0.18837250688357154d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.427425190493798d, y: 0.6961124584616604d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610472145727546d, y: 0.3442810913086307d), new NpgsqlTypes.NpgsqlPoint(x: 0.837865451239259d, y: 0.2571307138573985d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3766279522387235d, y: 0.30263249996889774d), new NpgsqlTypes.NpgsqlPoint(x: 0.29483057372054633d, y: 0.7207157162453166d), new NpgsqlTypes.NpgsqlPoint(x: 0.25065902231057346d, y: 0.8959288460879027d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6377361124180912d, y: 0.03120886608724338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3048150539398514d, y: 0.15942797932748531d), new NpgsqlTypes.NpgsqlPoint(x: 0.23588903348424162d, y: 0.15618208131220113d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21893553730733362d, y: 0.6247108646485154d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383621573754551d, y: 0.5793203764763355d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711231789011201d, y: 0.6209742721303109d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.062490599102038025d, y: 0.8179030646681043d), new NpgsqlTypes.NpgsqlPoint(x: 0.69452775335875d, y: 0.761461402348097d), new NpgsqlTypes.NpgsqlPoint(x: 0.3981780090899153d, y: 0.9874158986831735d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7758966075659413d, y: 0.6940580829841471d), new NpgsqlTypes.NpgsqlPoint(x: 0.755186148890223d, y: 0.45185094087272115d), new NpgsqlTypes.NpgsqlPoint(x: 0.801476315120517d, y: 0.7301620033653123d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7786851854673513d, y: 0.10003494869168794d), new NpgsqlTypes.NpgsqlPoint(x: 0.24813620940794867d, y: 0.8366101456181559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789673010332814d, y: 0.6752476463481123d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23753264898289195d, y: 0.017791520372228642d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553379649755232d, y: 0.8038178762780965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180394954728671d, y: 0.18642124253371606d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6467495297014123d, y: 0.2835884163991479d), new NpgsqlTypes.NpgsqlPoint(x: 0.13986199862429538d, y: 0.7217315269529292d), new NpgsqlTypes.NpgsqlPoint(x: 0.37041239258371517d, y: 0.3458179762496504d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9752743933032023d, y: 0.6098687470083103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903008560698899d, y: 0.6565289606516888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867110861086468d, y: 0.2775416561498044d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8027488573589581d, y: 0.36271728863130126d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671148805712089d, y: 0.32500116527077727d), new NpgsqlTypes.NpgsqlPoint(x: 0.197941580632505d, y: 0.41520585611661387d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5938373463372449d, y: 0.0901103078369555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4483892162618943d, y: 0.8011408472465474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6843877275440882d, y: 0.37946539343110464d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2636761608700575d, y: 0.834038965601895d), new NpgsqlTypes.NpgsqlPoint(x: 0.0995851329844073d, y: 0.20270713581499733d), new NpgsqlTypes.NpgsqlPoint(x: 0.40692689681156524d, y: 0.009434196168120468d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06702180654059264d, y: 0.07505339177520232d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580429359889754d, y: 0.038883375722095326d), new NpgsqlTypes.NpgsqlPoint(x: 0.08110212036611586d, y: 0.08274629223663144d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36701555330182367d, y: 0.6849442650512986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944625401071011d, y: 0.748137240276312d), new NpgsqlTypes.NpgsqlPoint(x: 0.4521762884001772d, y: 0.8301548082351663d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4710088319122193d, y: 0.6086898369138857d), new NpgsqlTypes.NpgsqlPoint(x: 0.18229116859162675d, y: 0.41450566938354205d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579118525187488d, y: 0.4578174749715057d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.811883133435817d, y: 0.7637577920067035d), new NpgsqlTypes.NpgsqlPoint(x: 0.2458055186770126d, y: 0.9185248236198664d), new NpgsqlTypes.NpgsqlPoint(x: 0.43569769162350136d, y: 0.8842572585313132d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19398245829527583d, y: 0.7675563603498452d), new NpgsqlTypes.NpgsqlPoint(x: 0.7491467072892891d, y: 0.22802713267173125d), new NpgsqlTypes.NpgsqlPoint(x: 0.38753556891572016d, y: 0.6253387420886364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5913769994337478d, y: 0.8564754895340267d), new NpgsqlTypes.NpgsqlPoint(x: 0.34638826316328086d, y: 0.1783004093448508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465026464386923d, y: 0.592110550177385d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9381772953027633d, y: 0.48895937236215403d), new NpgsqlTypes.NpgsqlPoint(x: 0.766369478665355d, y: 0.6468026803040511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168307253793294d, y: 0.9946911816280659d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44791892139621914d, y: 0.6021818605831569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254762131533689d, y: 0.5373411954772773d), new NpgsqlTypes.NpgsqlPoint(x: 0.0472023007007899d, y: 0.16539645798588032d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37713944873837923d, y: 0.29552524231561617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8587427151243007d, y: 0.9678305267675654d), new NpgsqlTypes.NpgsqlPoint(x: 0.12337040187370674d, y: 0.9895697100966288d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6960967457079102d, y: 0.31178631608443486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032054463036025d, y: 0.11152602860564287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851673453781731d, y: 0.5615381076361451d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2337241761407466d, y: 0.27662961976475997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560747774532829d, y: 0.6298704862459927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707146410421482d, y: 0.9780698967852429d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18600936471089258d, y: 0.4057041993594461d), new NpgsqlTypes.NpgsqlPoint(x: 0.4458426805388711d, y: 0.06714697770061306d), new NpgsqlTypes.NpgsqlPoint(x: 0.541319776276368d, y: 0.5880406975738159d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1957433742332435d, y: 0.7863566338853074d), new NpgsqlTypes.NpgsqlPoint(x: 0.21816506472917607d, y: 0.7973091612254145d), new NpgsqlTypes.NpgsqlPoint(x: 0.1721036983157651d, y: 0.6333562468431627d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37033585285192294d, y: 0.04456118474069792d), new NpgsqlTypes.NpgsqlPoint(x: 0.48751509302794116d, y: 0.4819924352072862d), new NpgsqlTypes.NpgsqlPoint(x: 0.006396595149123274d, y: 0.8619612557783972d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0019646972260641826d, y: 0.1931010524492034d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860375488048446d, y: 0.9549118547799353d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581167740633863d, y: 0.8340041364218316d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30271155360177304d, y: 0.2564222796579264d), new NpgsqlTypes.NpgsqlPoint(x: 0.03881593599120414d, y: 0.8642203794847939d), new NpgsqlTypes.NpgsqlPoint(x: 0.458884002882476d, y: 0.8571903375910808d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1497126618731206d, y: 0.0554165644343968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534891632233515d, y: 0.8286882892290522d), new NpgsqlTypes.NpgsqlPoint(x: 0.023758535247521473d, y: 0.04317296280924965d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111162967380964d, y: 0.005816515850587067d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880578934957482d, y: 0.7222243764305021d), new NpgsqlTypes.NpgsqlPoint(x: 0.972365747092909d, y: 0.24009933821340823d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38621263035834563d, y: 0.6358686576076888d), new NpgsqlTypes.NpgsqlPoint(x: 0.7894522586394683d, y: 0.7265046800480132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410673272345042d, y: 0.20788725458681445d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26193493729190964d, y: 0.8252046868467913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6666956159715527d, y: 0.8985733821031483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9639273433350233d, y: 0.7484759672693734d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7158861547092589d, y: 0.11890592688058566d), new NpgsqlTypes.NpgsqlPoint(x: 0.17430007946608927d, y: 0.39989455252361406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6614714081007513d, y: 0.2477470028300589d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6586290233450284d, y: 0.18423721120799086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479044361531118d, y: 0.7617401945772497d), new NpgsqlTypes.NpgsqlPoint(x: 0.08820911995956704d, y: 0.9312341552321404d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6744147377668268d, y: 0.885826715112669d), new NpgsqlTypes.NpgsqlPoint(x: 0.4744803009862908d, y: 0.030663757236229272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5793992243683168d, y: 0.15845659769763532d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3188500372146368d, y: 0.7834776293967042d), new NpgsqlTypes.NpgsqlPoint(x: 0.045659087189315106d, y: 0.5633431094717801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292185709881567d, y: 0.8722082542736028d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9150578580225687d, y: 0.7031689915012708d), new NpgsqlTypes.NpgsqlPoint(x: 0.3742075580709773d, y: 0.4015962573291163d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967587345938779d, y: 0.7207285966596783d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8901824396151734d, y: 0.2631793055451984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253911026932105d, y: 0.68385583600567d), new NpgsqlTypes.NpgsqlPoint(x: 0.45810916919956013d, y: 0.35459336308739464d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9558978533378132d, y: 0.7463601527018818d), new NpgsqlTypes.NpgsqlPoint(x: 0.526205084020484d, y: 0.8121105212465374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8710317137543787d, y: 0.40504649564643946d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2854490072116723d, y: 0.750434918894167d), new NpgsqlTypes.NpgsqlPoint(x: 0.0778067027723306d, y: 0.5079871314763637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460405310974852d, y: 0.984377214439987d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2539047245929331d, y: 0.9983587154068904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484906648427563d, y: 0.39590398341286315d), new NpgsqlTypes.NpgsqlPoint(x: 0.74968344357577d, y: 0.9349666233675359d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21851791238137985d, y: 0.552562870095514d), new NpgsqlTypes.NpgsqlPoint(x: 0.21716995591536004d, y: 0.5943251216919823d), new NpgsqlTypes.NpgsqlPoint(x: 0.27507344589153904d, y: 0.5437958124495406d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9944441804806852d, y: 0.5732351919157629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5977682044474427d, y: 0.22954995297796843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6177335088925185d, y: 0.6618600299024581d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2605918902294956d, y: 0.10338664970069333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2678634156388504d, y: 0.30818594397443355d), new NpgsqlTypes.NpgsqlPoint(x: 0.22513932450984753d, y: 0.05028582832726802d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11648927306540013d, y: 0.22551548445726943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160643111462461d, y: 0.9207669402509995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712058933482993d, y: 0.7229382756026319d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2810361521136362d, y: 0.3290007844513554d), new NpgsqlTypes.NpgsqlPoint(x: 0.16929432461137484d, y: 0.3337990213733538d), new NpgsqlTypes.NpgsqlPoint(x: 0.09280249853375244d, y: 0.4135121239807351d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048627631892556256d, y: 0.3472599428446994d), new NpgsqlTypes.NpgsqlPoint(x: 0.1258726934922687d, y: 0.12400550367357255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348536317962589d, y: 0.5322955385366552d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7881939997769777d, y: 0.07226344130180073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827820873787543d, y: 0.7483251435973869d), new NpgsqlTypes.NpgsqlPoint(x: 0.07459187525357935d, y: 0.8341854275770132d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2183356016440171d, y: 0.862304393668213d), new NpgsqlTypes.NpgsqlPoint(x: 0.38070625512510536d, y: 0.730600026855956d), new NpgsqlTypes.NpgsqlPoint(x: 0.11943628806693962d, y: 0.5434938904938852d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7549584370278964d, y: 0.7080978470582036d), new NpgsqlTypes.NpgsqlPoint(x: 0.3722880514744017d, y: 0.7339855893284355d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484228194970607d, y: 0.7723673547845901d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9095359880248807d, y: 0.6129211804617889d), new NpgsqlTypes.NpgsqlPoint(x: 0.09106895466297726d, y: 0.6194138909835428d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794826198022703d, y: 0.9193953441368824d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5625543706649213d, y: 0.006577588776359833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8385369609608635d, y: 0.24050102674181184d), new NpgsqlTypes.NpgsqlPoint(x: 0.23458420013953207d, y: 0.6736652730010495d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4436313277783347d, y: 0.9419271060855037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7694865973701703d, y: 0.5025355279740928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760444862718552d, y: 0.08451692785497655d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.679249235888303d, y: 0.8986844768821646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213190003817081d, y: 0.4209109632927627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5306174243261996d, y: 0.9925527498316575d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07584965685929279d, y: 0.4563951787069582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309476792976515d, y: 0.8748748929773685d), new NpgsqlTypes.NpgsqlPoint(x: 0.43712656446600817d, y: 0.07816400234555387d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9439565812050006d, y: 0.14008024333657176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129865391688462d, y: 0.06138674019636714d), new NpgsqlTypes.NpgsqlPoint(x: 0.9306611388497285d, y: 0.7964271897667979d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4691485208461301d, y: 0.4097483450554029d), new NpgsqlTypes.NpgsqlPoint(x: 0.26412402707285787d, y: 0.2942600700396636d), new NpgsqlTypes.NpgsqlPoint(x: 0.9946978726936268d, y: 0.37884952431786956d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7358119531955732d, y: 0.8223742208416988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519074941430982d, y: 0.6417483025928943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496407314162268d, y: 0.30465776068409567d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6122249899408159d, y: 0.3785815729727511d), new NpgsqlTypes.NpgsqlPoint(x: 0.01578976203717597d, y: 0.036563425362867386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551725509515636d, y: 0.062410474560900875d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8409502349908307d, y: 0.2873608786582753d), new NpgsqlTypes.NpgsqlPoint(x: 0.39389345788134367d, y: 0.28026772296781266d), new NpgsqlTypes.NpgsqlPoint(x: 0.786087980743154d, y: 0.49378772773878765d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24870966507358494d, y: 0.276228526939973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6884784357592871d, y: 0.17181591824455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329588011634105d, y: 0.38286858222202713d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5614397425519096d, y: 0.2774551762269013d), new NpgsqlTypes.NpgsqlPoint(x: 0.2897745036231345d, y: 0.655894342722083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519836676473806d, y: 0.5774591514533813d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7802943176151464d, y: 0.9758719232516261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349874325562354d, y: 0.07791360723619889d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682380809223891d, y: 0.6975442006335216d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44764931762745075d, y: 0.09859018362673688d), new NpgsqlTypes.NpgsqlPoint(x: 0.7969221654121127d, y: 0.010631380103786281d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424150427264609d, y: 0.1570493750020303d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12377373898499966d, y: 0.07755609712797606d), new NpgsqlTypes.NpgsqlPoint(x: 0.43768430081485166d, y: 0.20595715128080427d), new NpgsqlTypes.NpgsqlPoint(x: 0.78819974973355d, y: 0.05130374684732919d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7806712851180767d, y: 0.9303387081948017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3520999063092761d, y: 0.4303423537496128d), new NpgsqlTypes.NpgsqlPoint(x: 0.331466030546286d, y: 0.921615053832415d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7247090472674472d, y: 0.9339782887814201d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253313166532324d, y: 0.5752860643247214d), new NpgsqlTypes.NpgsqlPoint(x: 0.21857314003793793d, y: 0.03701240717250187d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.80950138974335d, y: 0.333514826928203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752737445149164d, y: 0.4200443609888638d), new NpgsqlTypes.NpgsqlPoint(x: 0.45037044147525407d, y: 0.570710231083539d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.705163955339244d, y: 0.3153114592293724d), new NpgsqlTypes.NpgsqlPoint(x: 0.4589497222201314d, y: 0.4996444608707963d), new NpgsqlTypes.NpgsqlPoint(x: 0.054134475659257664d, y: 0.461303831189561d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21515885992322703d, y: 0.40323873450697956d), new NpgsqlTypes.NpgsqlPoint(x: 0.17509772521639522d, y: 0.5141586651703457d), new NpgsqlTypes.NpgsqlPoint(x: 0.26098804655910945d, y: 0.7784053157542223d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6683779563393362d, y: 0.4005054816678095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8531825315177249d, y: 0.3989534266756929d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327564251845339d, y: 0.9033236452652466d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006001624815018092d, y: 0.6763689520242846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270861736234934d, y: 0.41037470364830475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7793119684466671d, y: 0.6203744012757396d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061832191356487654d, y: 0.28225250385402045d), new NpgsqlTypes.NpgsqlPoint(x: 9.018067566013421E-05d, y: 0.27127047215136413d), new NpgsqlTypes.NpgsqlPoint(x: 0.20880503218347823d, y: 0.4264198511305799d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8941060355244045d, y: 0.6402121783260235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3215957714476665d, y: 0.34879315922673115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8242535700590875d, y: 0.5426545713980204d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7571752381372975d, y: 0.219208114222596d), new NpgsqlTypes.NpgsqlPoint(x: 0.34262095581537355d, y: 0.1493059533249661d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408809911449805d, y: 0.020404981685522183d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28819989863390605d, y: 0.23609043158893306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3215425871951163d, y: 0.654480172351982d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933237337056722d, y: 0.18837250688357154d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.427425190493798d, y: 0.6961124584616604d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610472145727546d, y: 0.3442810913086307d), new NpgsqlTypes.NpgsqlPoint(x: 0.837865451239259d, y: 0.2571307138573985d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3766279522387235d, y: 0.30263249996889774d), new NpgsqlTypes.NpgsqlPoint(x: 0.29483057372054633d, y: 0.7207157162453166d), new NpgsqlTypes.NpgsqlPoint(x: 0.25065902231057346d, y: 0.8959288460879027d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6377361124180912d, y: 0.03120886608724338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3048150539398514d, y: 0.15942797932748531d), new NpgsqlTypes.NpgsqlPoint(x: 0.23588903348424162d, y: 0.15618208131220113d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21893553730733362d, y: 0.6247108646485154d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383621573754551d, y: 0.5793203764763355d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711231789011201d, y: 0.6209742721303109d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.062490599102038025d, y: 0.8179030646681043d), new NpgsqlTypes.NpgsqlPoint(x: 0.69452775335875d, y: 0.761461402348097d), new NpgsqlTypes.NpgsqlPoint(x: 0.3981780090899153d, y: 0.9874158986831735d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7758966075659413d, y: 0.6940580829841471d), new NpgsqlTypes.NpgsqlPoint(x: 0.755186148890223d, y: 0.45185094087272115d), new NpgsqlTypes.NpgsqlPoint(x: 0.801476315120517d, y: 0.7301620033653123d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7786851854673513d, y: 0.10003494869168794d), new NpgsqlTypes.NpgsqlPoint(x: 0.24813620940794867d, y: 0.8366101456181559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789673010332814d, y: 0.6752476463481123d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23753264898289195d, y: 0.017791520372228642d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553379649755232d, y: 0.8038178762780965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180394954728671d, y: 0.18642124253371606d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6467495297014123d, y: 0.2835884163991479d), new NpgsqlTypes.NpgsqlPoint(x: 0.13986199862429538d, y: 0.7217315269529292d), new NpgsqlTypes.NpgsqlPoint(x: 0.37041239258371517d, y: 0.3458179762496504d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9752743933032023d, y: 0.6098687470083103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903008560698899d, y: 0.6565289606516888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867110861086468d, y: 0.2775416561498044d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8027488573589581d, y: 0.36271728863130126d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671148805712089d, y: 0.32500116527077727d), new NpgsqlTypes.NpgsqlPoint(x: 0.197941580632505d, y: 0.41520585611661387d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5938373463372449d, y: 0.0901103078369555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4483892162618943d, y: 0.8011408472465474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6843877275440882d, y: 0.37946539343110464d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2636761608700575d, y: 0.834038965601895d), new NpgsqlTypes.NpgsqlPoint(x: 0.0995851329844073d, y: 0.20270713581499733d), new NpgsqlTypes.NpgsqlPoint(x: 0.40692689681156524d, y: 0.009434196168120468d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06702180654059264d, y: 0.07505339177520232d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580429359889754d, y: 0.038883375722095326d), new NpgsqlTypes.NpgsqlPoint(x: 0.08110212036611586d, y: 0.08274629223663144d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36701555330182367d, y: 0.6849442650512986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944625401071011d, y: 0.748137240276312d), new NpgsqlTypes.NpgsqlPoint(x: 0.4521762884001772d, y: 0.8301548082351663d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4710088319122193d, y: 0.6086898369138857d), new NpgsqlTypes.NpgsqlPoint(x: 0.18229116859162675d, y: 0.41450566938354205d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579118525187488d, y: 0.4578174749715057d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.811883133435817d, y: 0.7637577920067035d), new NpgsqlTypes.NpgsqlPoint(x: 0.2458055186770126d, y: 0.9185248236198664d), new NpgsqlTypes.NpgsqlPoint(x: 0.43569769162350136d, y: 0.8842572585313132d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19398245829527583d, y: 0.7675563603498452d), new NpgsqlTypes.NpgsqlPoint(x: 0.7491467072892891d, y: 0.22802713267173125d), new NpgsqlTypes.NpgsqlPoint(x: 0.38753556891572016d, y: 0.6253387420886364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5913769994337478d, y: 0.8564754895340267d), new NpgsqlTypes.NpgsqlPoint(x: 0.34638826316328086d, y: 0.1783004093448508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465026464386923d, y: 0.592110550177385d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9381772953027633d, y: 0.48895937236215403d), new NpgsqlTypes.NpgsqlPoint(x: 0.766369478665355d, y: 0.6468026803040511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168307253793294d, y: 0.9946911816280659d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44791892139621914d, y: 0.6021818605831569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254762131533689d, y: 0.5373411954772773d), new NpgsqlTypes.NpgsqlPoint(x: 0.0472023007007899d, y: 0.16539645798588032d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37713944873837923d, y: 0.29552524231561617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8587427151243007d, y: 0.9678305267675654d), new NpgsqlTypes.NpgsqlPoint(x: 0.12337040187370674d, y: 0.9895697100966288d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6960967457079102d, y: 0.31178631608443486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032054463036025d, y: 0.11152602860564287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851673453781731d, y: 0.5615381076361451d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2337241761407466d, y: 0.27662961976475997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560747774532829d, y: 0.6298704862459927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707146410421482d, y: 0.9780698967852429d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18600936471089258d, y: 0.4057041993594461d), new NpgsqlTypes.NpgsqlPoint(x: 0.4458426805388711d, y: 0.06714697770061306d), new NpgsqlTypes.NpgsqlPoint(x: 0.541319776276368d, y: 0.5880406975738159d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1957433742332435d, y: 0.7863566338853074d), new NpgsqlTypes.NpgsqlPoint(x: 0.21816506472917607d, y: 0.7973091612254145d), new NpgsqlTypes.NpgsqlPoint(x: 0.1721036983157651d, y: 0.6333562468431627d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37033585285192294d, y: 0.04456118474069792d), new NpgsqlTypes.NpgsqlPoint(x: 0.48751509302794116d, y: 0.4819924352072862d), new NpgsqlTypes.NpgsqlPoint(x: 0.006396595149123274d, y: 0.8619612557783972d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0019646972260641826d, y: 0.1931010524492034d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860375488048446d, y: 0.9549118547799353d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581167740633863d, y: 0.8340041364218316d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30271155360177304d, y: 0.2564222796579264d), new NpgsqlTypes.NpgsqlPoint(x: 0.03881593599120414d, y: 0.8642203794847939d), new NpgsqlTypes.NpgsqlPoint(x: 0.458884002882476d, y: 0.8571903375910808d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1497126618731206d, y: 0.0554165644343968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534891632233515d, y: 0.8286882892290522d), new NpgsqlTypes.NpgsqlPoint(x: 0.023758535247521473d, y: 0.04317296280924965d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111162967380964d, y: 0.005816515850587067d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880578934957482d, y: 0.7222243764305021d), new NpgsqlTypes.NpgsqlPoint(x: 0.972365747092909d, y: 0.24009933821340823d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38621263035834563d, y: 0.6358686576076888d), new NpgsqlTypes.NpgsqlPoint(x: 0.7894522586394683d, y: 0.7265046800480132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410673272345042d, y: 0.20788725458681445d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26193493729190964d, y: 0.8252046868467913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6666956159715527d, y: 0.8985733821031483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9639273433350233d, y: 0.7484759672693734d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7158861547092589d, y: 0.11890592688058566d), new NpgsqlTypes.NpgsqlPoint(x: 0.17430007946608927d, y: 0.39989455252361406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6614714081007513d, y: 0.2477470028300589d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6586290233450284d, y: 0.18423721120799086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479044361531118d, y: 0.7617401945772497d), new NpgsqlTypes.NpgsqlPoint(x: 0.08820911995956704d, y: 0.9312341552321404d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6744147377668268d, y: 0.885826715112669d), new NpgsqlTypes.NpgsqlPoint(x: 0.4744803009862908d, y: 0.030663757236229272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5793992243683168d, y: 0.15845659769763532d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3188500372146368d, y: 0.7834776293967042d), new NpgsqlTypes.NpgsqlPoint(x: 0.045659087189315106d, y: 0.5633431094717801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292185709881567d, y: 0.8722082542736028d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9150578580225687d, y: 0.7031689915012708d), new NpgsqlTypes.NpgsqlPoint(x: 0.3742075580709773d, y: 0.4015962573291163d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967587345938779d, y: 0.7207285966596783d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8901824396151734d, y: 0.2631793055451984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253911026932105d, y: 0.68385583600567d), new NpgsqlTypes.NpgsqlPoint(x: 0.45810916919956013d, y: 0.35459336308739464d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9558978533378132d, y: 0.7463601527018818d), new NpgsqlTypes.NpgsqlPoint(x: 0.526205084020484d, y: 0.8121105212465374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8710317137543787d, y: 0.40504649564643946d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2854490072116723d, y: 0.750434918894167d), new NpgsqlTypes.NpgsqlPoint(x: 0.0778067027723306d, y: 0.5079871314763637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460405310974852d, y: 0.984377214439987d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2539047245929331d, y: 0.9983587154068904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484906648427563d, y: 0.39590398341286315d), new NpgsqlTypes.NpgsqlPoint(x: 0.74968344357577d, y: 0.9349666233675359d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21851791238137985d, y: 0.552562870095514d), new NpgsqlTypes.NpgsqlPoint(x: 0.21716995591536004d, y: 0.5943251216919823d), new NpgsqlTypes.NpgsqlPoint(x: 0.27507344589153904d, y: 0.5437958124495406d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9944441804806852d, y: 0.5732351919157629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5977682044474427d, y: 0.22954995297796843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6177335088925185d, y: 0.6618600299024581d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2605918902294956d, y: 0.10338664970069333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2678634156388504d, y: 0.30818594397443355d), new NpgsqlTypes.NpgsqlPoint(x: 0.22513932450984753d, y: 0.05028582832726802d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11648927306540013d, y: 0.22551548445726943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160643111462461d, y: 0.9207669402509995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712058933482993d, y: 0.7229382756026319d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2810361521136362d, y: 0.3290007844513554d), new NpgsqlTypes.NpgsqlPoint(x: 0.16929432461137484d, y: 0.3337990213733538d), new NpgsqlTypes.NpgsqlPoint(x: 0.09280249853375244d, y: 0.4135121239807351d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048627631892556256d, y: 0.3472599428446994d), new NpgsqlTypes.NpgsqlPoint(x: 0.1258726934922687d, y: 0.12400550367357255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348536317962589d, y: 0.5322955385366552d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7881939997769777d, y: 0.07226344130180073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827820873787543d, y: 0.7483251435973869d), new NpgsqlTypes.NpgsqlPoint(x: 0.07459187525357935d, y: 0.8341854275770132d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2183356016440171d, y: 0.862304393668213d), new NpgsqlTypes.NpgsqlPoint(x: 0.38070625512510536d, y: 0.730600026855956d), new NpgsqlTypes.NpgsqlPoint(x: 0.11943628806693962d, y: 0.5434938904938852d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7549584370278964d, y: 0.7080978470582036d), new NpgsqlTypes.NpgsqlPoint(x: 0.3722880514744017d, y: 0.7339855893284355d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484228194970607d, y: 0.7723673547845901d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9095359880248807d, y: 0.6129211804617889d), new NpgsqlTypes.NpgsqlPoint(x: 0.09106895466297726d, y: 0.6194138909835428d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794826198022703d, y: 0.9193953441368824d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5625543706649213d, y: 0.006577588776359833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8385369609608635d, y: 0.24050102674181184d), new NpgsqlTypes.NpgsqlPoint(x: 0.23458420013953207d, y: 0.6736652730010495d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4436313277783347d, y: 0.9419271060855037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7694865973701703d, y: 0.5025355279740928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760444862718552d, y: 0.08451692785497655d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.679249235888303d, y: 0.8986844768821646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213190003817081d, y: 0.4209109632927627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5306174243261996d, y: 0.9925527498316575d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07584965685929279d, y: 0.4563951787069582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309476792976515d, y: 0.8748748929773685d), new NpgsqlTypes.NpgsqlPoint(x: 0.43712656446600817d, y: 0.07816400234555387d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9439565812050006d, y: 0.14008024333657176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129865391688462d, y: 0.06138674019636714d), new NpgsqlTypes.NpgsqlPoint(x: 0.9306611388497285d, y: 0.7964271897667979d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4691485208461301d, y: 0.4097483450554029d), new NpgsqlTypes.NpgsqlPoint(x: 0.26412402707285787d, y: 0.2942600700396636d), new NpgsqlTypes.NpgsqlPoint(x: 0.9946978726936268d, y: 0.37884952431786956d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7358119531955732d, y: 0.8223742208416988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519074941430982d, y: 0.6417483025928943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496407314162268d, y: 0.30465776068409567d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6122249899408159d, y: 0.3785815729727511d), new NpgsqlTypes.NpgsqlPoint(x: 0.01578976203717597d, y: 0.036563425362867386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551725509515636d, y: 0.062410474560900875d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8409502349908307d, y: 0.2873608786582753d), new NpgsqlTypes.NpgsqlPoint(x: 0.39389345788134367d, y: 0.28026772296781266d), new NpgsqlTypes.NpgsqlPoint(x: 0.786087980743154d, y: 0.49378772773878765d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24870966507358494d, y: 0.276228526939973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6884784357592871d, y: 0.17181591824455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329588011634105d, y: 0.38286858222202713d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5614397425519096d, y: 0.2774551762269013d), new NpgsqlTypes.NpgsqlPoint(x: 0.2897745036231345d, y: 0.655894342722083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519836676473806d, y: 0.5774591514533813d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7802943176151464d, y: 0.9758719232516261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349874325562354d, y: 0.07791360723619889d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682380809223891d, y: 0.6975442006335216d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44764931762745075d, y: 0.09859018362673688d), new NpgsqlTypes.NpgsqlPoint(x: 0.7969221654121127d, y: 0.010631380103786281d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424150427264609d, y: 0.1570493750020303d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12377373898499966d, y: 0.07755609712797606d), new NpgsqlTypes.NpgsqlPoint(x: 0.43768430081485166d, y: 0.20595715128080427d), new NpgsqlTypes.NpgsqlPoint(x: 0.78819974973355d, y: 0.05130374684732919d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpathe0m m
LEFT JOIN public.binary_npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI), typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

