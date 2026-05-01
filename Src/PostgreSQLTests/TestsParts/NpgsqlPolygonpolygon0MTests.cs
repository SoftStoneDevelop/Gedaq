

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygon0M[] _testData = new NpgsqlPolygonpolygon0M[]
        {
            new NpgsqlPolygonpolygon0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47596019667704115d, y: 0.5915346994607956d), new NpgsqlTypes.NpgsqlPoint(x: 0.4477648123326099d, y: 0.0061583479807090225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503594434956217d, y: 0.9319502389850647d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9544931944874377d, y: 0.3316940321601216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5211166096155034d, y: 0.10715732023763436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5712524103827655d, y: 0.20680883129148864d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6743387817190566d, y: 0.09963322499437577d), new NpgsqlTypes.NpgsqlPoint(x: 0.40108258104444927d, y: 0.27953968557259157d), new NpgsqlTypes.NpgsqlPoint(x: 0.09001027008729379d, y: 0.9556551747789314d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4194057541276266d, y: 0.6066945908276855d), new NpgsqlTypes.NpgsqlPoint(x: 0.1925981748662079d, y: 0.7208893097196297d), new NpgsqlTypes.NpgsqlPoint(x: 0.40739979067110155d, y: 0.579046259924396d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5647569836161075d, y: 0.08743110442790258d), new NpgsqlTypes.NpgsqlPoint(x: 0.47703221868632883d, y: 0.675313376981604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764002116476912d, y: 0.22411147110684992d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5695156765660765d, y: 0.4555371804182685d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547303356337108d, y: 0.2682574556136721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774217011617382d, y: 0.7809301871195105d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7718214325984084d, y: 0.8023351573177239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9306081553444723d, y: 0.3438859455352077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7705732038151464d, y: 0.07471592240527891d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.976107156697126d, y: 0.040262926570980406d), new NpgsqlTypes.NpgsqlPoint(x: 0.21631010450810872d, y: 0.24468010576668098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327007407353103d, y: 0.6355465730891994d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8196411725847902d, y: 0.7312492548392744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896527401264587d, y: 0.08447307116162184d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580164080781957d, y: 0.5805778250349385d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16269462761628783d, y: 0.4716724713163011d), new NpgsqlTypes.NpgsqlPoint(x: 0.8347632233162978d, y: 0.5668278661358664d), new NpgsqlTypes.NpgsqlPoint(x: 0.3377706065721786d, y: 0.3469024794529365d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9244734882675719d, y: 0.7036008972405546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810965525408627d, y: 0.6703417452357217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334824490539841d, y: 0.26805442834456417d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16898168202927766d, y: 0.16692606946275634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2740794156975065d, y: 0.24742297810291125d), new NpgsqlTypes.NpgsqlPoint(x: 0.672650914676745d, y: 0.1884421835771689d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14614989235414322d, y: 0.13436303707530628d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836806093581396d, y: 0.3170907270950434d), new NpgsqlTypes.NpgsqlPoint(x: 0.21650906015075821d, y: 0.7074024400998139d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8188086334304301d, y: 0.6588966366186113d), new NpgsqlTypes.NpgsqlPoint(x: 0.76724133355391d, y: 0.3687794161761593d), new NpgsqlTypes.NpgsqlPoint(x: 0.0506497969252383d, y: 0.9364041496675833d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8200096604387216d, y: 0.978419645098777d), new NpgsqlTypes.NpgsqlPoint(x: 0.09420205474323906d, y: 0.6884098819936568d), new NpgsqlTypes.NpgsqlPoint(x: 0.24045084321469246d, y: 0.6589804797010758d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27701271191042676d, y: 0.372539479671086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6957846960788242d, y: 0.9034782513976163d), new NpgsqlTypes.NpgsqlPoint(x: 0.36555040682523776d, y: 0.4770907778225544d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3739313064625761d, y: 0.21989734945505357d), new NpgsqlTypes.NpgsqlPoint(x: 0.4943349338906481d, y: 0.2331190852461501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575157968682156d, y: 0.5706227078622318d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.035614463632072546d, y: 0.3035558395431259d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598062999263621d, y: 0.2627253412279362d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412489415068309d, y: 0.41458931864966897d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8657504686531434d, y: 0.602362395624736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5474186013059215d, y: 0.5529222094687107d), new NpgsqlTypes.NpgsqlPoint(x: 0.12625232988613755d, y: 0.06994730413581296d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6936523729989701d, y: 0.08405647084463386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7438202172469405d, y: 0.6271501512952841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960089140208274d, y: 0.48971934911255965d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14421097029331797d, y: 0.6946919768170168d), new NpgsqlTypes.NpgsqlPoint(x: 0.16099747664267383d, y: 0.44856456480510387d), new NpgsqlTypes.NpgsqlPoint(x: 0.44446515081377014d, y: 0.5377222970206572d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45619016774478416d, y: 0.39510542425273554d), new NpgsqlTypes.NpgsqlPoint(x: 0.19593173550406096d, y: 0.06177475015725764d), new NpgsqlTypes.NpgsqlPoint(x: 0.3185774066906152d, y: 0.7209018628010843d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9397416346820192d, y: 0.8701333979012733d), new NpgsqlTypes.NpgsqlPoint(x: 0.18940478417763595d, y: 0.407382964351945d), new NpgsqlTypes.NpgsqlPoint(x: 0.43191650277576565d, y: 0.7093272025779102d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9997154261919281d, y: 0.909868307467857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9703529609597631d, y: 0.8367249136349667d), new NpgsqlTypes.NpgsqlPoint(x: 0.89054824658629d, y: 0.8946050578446664d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16322076825450182d, y: 0.9158456657947261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284332234729389d, y: 0.481754072871426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4672107532797146d, y: 0.44783390224084674d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23691648282796263d, y: 0.04481066047375892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5831728910574673d, y: 0.04277758347894378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730757563962685d, y: 0.1453042664743177d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5874672725814514d, y: 0.8929570679905279d), new NpgsqlTypes.NpgsqlPoint(x: 0.2897611699336543d, y: 0.9678134926346574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646753802366843d, y: 0.16014651059625185d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22498244195233386d, y: 0.0815539518491577d), new NpgsqlTypes.NpgsqlPoint(x: 0.699892292343728d, y: 0.11544543224462134d), new NpgsqlTypes.NpgsqlPoint(x: 0.2231627048487479d, y: 0.15805067848082488d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39816836521595567d, y: 0.8077040149037233d), new NpgsqlTypes.NpgsqlPoint(x: 0.8339164475930477d, y: 0.481121834836284d), new NpgsqlTypes.NpgsqlPoint(x: 0.5216614159916616d, y: 0.05243372628298881d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3465740875910902d, y: 0.8479008887297239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8979368268140117d, y: 0.9517510097907621d), new NpgsqlTypes.NpgsqlPoint(x: 0.03316717201058916d, y: 0.2225006762325683d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20870480819308979d, y: 0.9178386849430047d), new NpgsqlTypes.NpgsqlPoint(x: 0.09295710303816329d, y: 0.5799688465576859d), new NpgsqlTypes.NpgsqlPoint(x: 0.38634318800987577d, y: 0.5596306135789142d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6456044541491601d, y: 0.604291369960402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835654103731172d, y: 0.7720541955427448d), new NpgsqlTypes.NpgsqlPoint(x: 0.3212163432689963d, y: 0.12718052421533121d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5711757489391309d, y: 0.8082826560541257d), new NpgsqlTypes.NpgsqlPoint(x: 0.17275318665899586d, y: 0.9453876994610846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5666031290696664d, y: 0.05169800892808896d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6843754505396619d, y: 0.01979769072622628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367659843092d, y: 0.6753122507263788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7276349261843393d, y: 0.09361016639923081d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6458114581618818d, y: 0.39498243017626267d), new NpgsqlTypes.NpgsqlPoint(x: 0.19218302630489004d, y: 0.2575771445770767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144482392740463d, y: 0.6176363359920498d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8569475711420579d, y: 0.0027679834928558966d), new NpgsqlTypes.NpgsqlPoint(x: 0.4487767534071113d, y: 0.8871073492217217d), new NpgsqlTypes.NpgsqlPoint(x: 0.5201098356317917d, y: 0.8663199445177865d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.752970959688701d, y: 0.16997454606889528d), new NpgsqlTypes.NpgsqlPoint(x: 0.5802175549853467d, y: 0.7133108323905679d), new NpgsqlTypes.NpgsqlPoint(x: 0.28090748724941306d, y: 0.7317849231568588d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3968202658292389d, y: 0.12806279285554079d), new NpgsqlTypes.NpgsqlPoint(x: 0.011087045812388507d, y: 0.5093575947516117d), new NpgsqlTypes.NpgsqlPoint(x: 0.4620913922096169d, y: 0.48477560524805585d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7741829757244361d, y: 0.4345757759133402d), new NpgsqlTypes.NpgsqlPoint(x: 0.45122881617854316d, y: 0.4141395682517425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2117669664319305d, y: 0.666416077489796d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6230227603882144d, y: 0.7997491846863437d), new NpgsqlTypes.NpgsqlPoint(x: 0.1418012255498141d, y: 0.5461971200363277d), new NpgsqlTypes.NpgsqlPoint(x: 0.22476229570875694d, y: 0.5992594720346603d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4285000647084617d, y: 0.20121913595616037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7254101685217661d, y: 0.8466137048154948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6035924495922768d, y: 0.3781005337246448d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28669457920323604d, y: 0.3874283483725828d), new NpgsqlTypes.NpgsqlPoint(x: 0.3154092515498087d, y: 0.35928525413117696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7168860015477652d, y: 0.9954646044307481d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8066750781329095d, y: 0.040134042345891685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919109826807302d, y: 0.619746361125972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6742813656259674d, y: 0.9795366463511056d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1571750980358546d, y: 0.12698079930352346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632823694345433d, y: 0.5287259529152131d), new NpgsqlTypes.NpgsqlPoint(x: 0.04733270100697318d, y: 0.7274520200297465d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9842741056489241d, y: 0.4184524289358956d), new NpgsqlTypes.NpgsqlPoint(x: 0.11295824591801407d, y: 0.8789324619121054d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882479838268031d, y: 0.8591222326362312d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49104251927182285d, y: 0.28324344359597475d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813613873215279d, y: 0.6699771222493065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8233996854370809d, y: 0.8991511122697443d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3798827916122678d, y: 0.8317428898741509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545926531456938d, y: 0.20744705568605815d), new NpgsqlTypes.NpgsqlPoint(x: 0.02923048860569255d, y: 0.4618682672820098d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48597512443284574d, y: 0.7897432636516429d), new NpgsqlTypes.NpgsqlPoint(x: 0.06850823312647303d, y: 0.5595823866216671d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351078725742918d, y: 0.10502969250742633d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6867061834654172d, y: 0.8929317802395601d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899337310989075d, y: 0.3098885830728231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532074118955634d, y: 0.025626576489778063d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.846124579974663d, y: 0.18718193109883896d), new NpgsqlTypes.NpgsqlPoint(x: 0.376794769355962d, y: 0.42103684897418137d), new NpgsqlTypes.NpgsqlPoint(x: 0.35397386101268913d, y: 0.44528011401518497d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3226634794029316d, y: 0.6069468077706147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6605231152370874d, y: 0.6465759642642563d), new NpgsqlTypes.NpgsqlPoint(x: 0.1216517648872858d, y: 0.4144632290793069d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6162805153536376d, y: 0.9402279891378944d), new NpgsqlTypes.NpgsqlPoint(x: 0.8283124120197662d, y: 0.6256837190340518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702062004007991d, y: 0.24954904155725843d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13470226228315718d, y: 0.7838912182802645d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067550778057762d, y: 0.7815529563039284d), new NpgsqlTypes.NpgsqlPoint(x: 0.41612857036262274d, y: 0.43674816334564925d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34411820164417783d, y: 0.8370120734689686d), new NpgsqlTypes.NpgsqlPoint(x: 0.04027801729967495d, y: 0.9879762374016141d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725860764484072d, y: 0.172334592323255d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9554176853200257d, y: 0.24351842283621283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552037000284622d, y: 0.2608899273939106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5192667748267983d, y: 0.5106346437858499d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24236332502659874d, y: 0.05148562054288763d), new NpgsqlTypes.NpgsqlPoint(x: 0.1986711672987701d, y: 0.36047225481957257d), new NpgsqlTypes.NpgsqlPoint(x: 0.0436839907065798d, y: 0.3044635465474784d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3852203095675857d, y: 0.3996741679748903d), new NpgsqlTypes.NpgsqlPoint(x: 0.789039373701719d, y: 0.4614976873402692d), new NpgsqlTypes.NpgsqlPoint(x: 0.7028239087104056d, y: 0.37775123956837275d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5893840372049616d, y: 0.6795110869011706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4376215010140839d, y: 0.7650461058368254d), new NpgsqlTypes.NpgsqlPoint(x: 0.930715681708901d, y: 0.8415373042556927d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.68212793093347d, y: 0.7866520412838557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110469935652208d, y: 0.43536711545621376d), new NpgsqlTypes.NpgsqlPoint(x: 0.1611660984961204d, y: 0.8620337670796568d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24949744802820706d, y: 0.9269412889597858d), new NpgsqlTypes.NpgsqlPoint(x: 0.3693782047461215d, y: 0.1654053181832812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3172231312834771d, y: 0.7778986753793486d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2795351895741739d, y: 0.5917268662005372d), new NpgsqlTypes.NpgsqlPoint(x: 0.20141523318751509d, y: 0.6644127512961874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460471439685601d, y: 0.7310783670687241d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3650675746187755d, y: 0.9465237064931362d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038002481012899d, y: 0.23407075152134993d), new NpgsqlTypes.NpgsqlPoint(x: 0.894863366919902d, y: 0.25460306789215803d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24953762404925606d, y: 0.054601859086468085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8967022992821525d, y: 0.6173835111540504d), new NpgsqlTypes.NpgsqlPoint(x: 0.06049772291593325d, y: 0.1693388084340124d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004205683246189307d, y: 0.6829148364957021d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002194033751799d, y: 0.8355079305618387d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944163394134667d, y: 0.3259886752712109d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10872063844860003d, y: 0.7633494818576032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566836509184213d, y: 0.28847616809263765d), new NpgsqlTypes.NpgsqlPoint(x: 0.25261645256691123d, y: 0.23878374042564665d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5979259264373148d, y: 0.9361396740577569d), new NpgsqlTypes.NpgsqlPoint(x: 0.134219481167424d, y: 0.2927165537166372d), new NpgsqlTypes.NpgsqlPoint(x: 0.23839604230962874d, y: 0.4336755691348434d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9678985415240355d, y: 0.26276896087007084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6964326191989302d, y: 0.0372855057454915d), new NpgsqlTypes.NpgsqlPoint(x: 0.44578441380179534d, y: 0.6863177972500195d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4083321471257322d, y: 0.5282487113367095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6348356826530149d, y: 0.8047612620681823d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301209754209242d, y: 0.5047417836815015d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.959625508085551d, y: 0.3884116610638355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720173348259016d, y: 0.5826705278688014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8457305569683871d, y: 0.656224650742619d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47804306918499717d, y: 0.10302017913518657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4872191928891574d, y: 0.7278417763096685d), new NpgsqlTypes.NpgsqlPoint(x: 0.927884472392908d, y: 0.9921368744419943d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.777375923729231d, y: 0.7403046321036799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678193668292987d, y: 0.009584892267065603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438577655499647d, y: 0.12450391567687924d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24088029857136295d, y: 0.36174050902794064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5804772668756206d, y: 0.24391168725077061d), new NpgsqlTypes.NpgsqlPoint(x: 0.251905477567671d, y: 0.6578115910738067d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9274668866288902d, y: 0.2405451873906771d), new NpgsqlTypes.NpgsqlPoint(x: 0.705765605252313d, y: 0.3831331850957054d), new NpgsqlTypes.NpgsqlPoint(x: 0.2548272542463609d, y: 0.36484591819359213d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1725191975767817d, y: 0.6927046688007692d), new NpgsqlTypes.NpgsqlPoint(x: 0.15989672703080748d, y: 0.6691202514050002d), new NpgsqlTypes.NpgsqlPoint(x: 0.04747000187172912d, y: 0.4375533661577359d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7737121733291972d, y: 0.03376369293826598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4285649379241949d, y: 0.29514293992028007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002250193141938d, y: 0.7999770821137164d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7959019446664922d, y: 0.49304085480802495d), new NpgsqlTypes.NpgsqlPoint(x: 0.3078792101479615d, y: 0.11947228500270601d), new NpgsqlTypes.NpgsqlPoint(x: 0.2180690161455212d, y: 0.47813179964031416d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.134306447699875d, y: 0.9905817264818134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7777422306826144d, y: 0.8994734917213946d), new NpgsqlTypes.NpgsqlPoint(x: 0.006052847022763208d, y: 0.5339401343437573d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9244734882675719d, y: 0.7036008972405546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810965525408627d, y: 0.6703417452357217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334824490539841d, y: 0.26805442834456417d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8200096604387216d, y: 0.978419645098777d), new NpgsqlTypes.NpgsqlPoint(x: 0.09420205474323906d, y: 0.6884098819936568d), new NpgsqlTypes.NpgsqlPoint(x: 0.24045084321469246d, y: 0.6589804797010758d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6936523729989701d, y: 0.08405647084463386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7438202172469405d, y: 0.6271501512952841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960089140208274d, y: 0.48971934911255965d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9997154261919281d, y: 0.909868307467857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9703529609597631d, y: 0.8367249136349667d), new NpgsqlTypes.NpgsqlPoint(x: 0.89054824658629d, y: 0.8946050578446664d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygon0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygon0mi_id", 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 90, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 156, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 118, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 10, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 146, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 70, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 10, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 28, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 103, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[30], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[31], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[32], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[33], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47596019667704115d, y: 0.5915346994607956d), new NpgsqlTypes.NpgsqlPoint(x: 0.4477648123326099d, y: 0.0061583479807090225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503594434956217d, y: 0.9319502389850647d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9544931944874377d, y: 0.3316940321601216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5211166096155034d, y: 0.10715732023763436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5712524103827655d, y: 0.20680883129148864d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6743387817190566d, y: 0.09963322499437577d), new NpgsqlTypes.NpgsqlPoint(x: 0.40108258104444927d, y: 0.27953968557259157d), new NpgsqlTypes.NpgsqlPoint(x: 0.09001027008729379d, y: 0.9556551747789314d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4194057541276266d, y: 0.6066945908276855d), new NpgsqlTypes.NpgsqlPoint(x: 0.1925981748662079d, y: 0.7208893097196297d), new NpgsqlTypes.NpgsqlPoint(x: 0.40739979067110155d, y: 0.579046259924396d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5647569836161075d, y: 0.08743110442790258d), new NpgsqlTypes.NpgsqlPoint(x: 0.47703221868632883d, y: 0.675313376981604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764002116476912d, y: 0.22411147110684992d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5695156765660765d, y: 0.4555371804182685d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547303356337108d, y: 0.2682574556136721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774217011617382d, y: 0.7809301871195105d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7718214325984084d, y: 0.8023351573177239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9306081553444723d, y: 0.3438859455352077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7705732038151464d, y: 0.07471592240527891d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.976107156697126d, y: 0.040262926570980406d), new NpgsqlTypes.NpgsqlPoint(x: 0.21631010450810872d, y: 0.24468010576668098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327007407353103d, y: 0.6355465730891994d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8196411725847902d, y: 0.7312492548392744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896527401264587d, y: 0.08447307116162184d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580164080781957d, y: 0.5805778250349385d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16269462761628783d, y: 0.4716724713163011d), new NpgsqlTypes.NpgsqlPoint(x: 0.8347632233162978d, y: 0.5668278661358664d), new NpgsqlTypes.NpgsqlPoint(x: 0.3377706065721786d, y: 0.3469024794529365d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9244734882675719d, y: 0.7036008972405546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810965525408627d, y: 0.6703417452357217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334824490539841d, y: 0.26805442834456417d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16898168202927766d, y: 0.16692606946275634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2740794156975065d, y: 0.24742297810291125d), new NpgsqlTypes.NpgsqlPoint(x: 0.672650914676745d, y: 0.1884421835771689d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14614989235414322d, y: 0.13436303707530628d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836806093581396d, y: 0.3170907270950434d), new NpgsqlTypes.NpgsqlPoint(x: 0.21650906015075821d, y: 0.7074024400998139d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8188086334304301d, y: 0.6588966366186113d), new NpgsqlTypes.NpgsqlPoint(x: 0.76724133355391d, y: 0.3687794161761593d), new NpgsqlTypes.NpgsqlPoint(x: 0.0506497969252383d, y: 0.9364041496675833d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8200096604387216d, y: 0.978419645098777d), new NpgsqlTypes.NpgsqlPoint(x: 0.09420205474323906d, y: 0.6884098819936568d), new NpgsqlTypes.NpgsqlPoint(x: 0.24045084321469246d, y: 0.6589804797010758d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27701271191042676d, y: 0.372539479671086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6957846960788242d, y: 0.9034782513976163d), new NpgsqlTypes.NpgsqlPoint(x: 0.36555040682523776d, y: 0.4770907778225544d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3739313064625761d, y: 0.21989734945505357d), new NpgsqlTypes.NpgsqlPoint(x: 0.4943349338906481d, y: 0.2331190852461501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575157968682156d, y: 0.5706227078622318d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.035614463632072546d, y: 0.3035558395431259d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598062999263621d, y: 0.2627253412279362d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412489415068309d, y: 0.41458931864966897d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8657504686531434d, y: 0.602362395624736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5474186013059215d, y: 0.5529222094687107d), new NpgsqlTypes.NpgsqlPoint(x: 0.12625232988613755d, y: 0.06994730413581296d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6936523729989701d, y: 0.08405647084463386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7438202172469405d, y: 0.6271501512952841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960089140208274d, y: 0.48971934911255965d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14421097029331797d, y: 0.6946919768170168d), new NpgsqlTypes.NpgsqlPoint(x: 0.16099747664267383d, y: 0.44856456480510387d), new NpgsqlTypes.NpgsqlPoint(x: 0.44446515081377014d, y: 0.5377222970206572d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45619016774478416d, y: 0.39510542425273554d), new NpgsqlTypes.NpgsqlPoint(x: 0.19593173550406096d, y: 0.06177475015725764d), new NpgsqlTypes.NpgsqlPoint(x: 0.3185774066906152d, y: 0.7209018628010843d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9397416346820192d, y: 0.8701333979012733d), new NpgsqlTypes.NpgsqlPoint(x: 0.18940478417763595d, y: 0.407382964351945d), new NpgsqlTypes.NpgsqlPoint(x: 0.43191650277576565d, y: 0.7093272025779102d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9997154261919281d, y: 0.909868307467857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9703529609597631d, y: 0.8367249136349667d), new NpgsqlTypes.NpgsqlPoint(x: 0.89054824658629d, y: 0.8946050578446664d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16322076825450182d, y: 0.9158456657947261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284332234729389d, y: 0.481754072871426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4672107532797146d, y: 0.44783390224084674d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23691648282796263d, y: 0.04481066047375892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5831728910574673d, y: 0.04277758347894378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730757563962685d, y: 0.1453042664743177d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5874672725814514d, y: 0.8929570679905279d), new NpgsqlTypes.NpgsqlPoint(x: 0.2897611699336543d, y: 0.9678134926346574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646753802366843d, y: 0.16014651059625185d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22498244195233386d, y: 0.0815539518491577d), new NpgsqlTypes.NpgsqlPoint(x: 0.699892292343728d, y: 0.11544543224462134d), new NpgsqlTypes.NpgsqlPoint(x: 0.2231627048487479d, y: 0.15805067848082488d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39816836521595567d, y: 0.8077040149037233d), new NpgsqlTypes.NpgsqlPoint(x: 0.8339164475930477d, y: 0.481121834836284d), new NpgsqlTypes.NpgsqlPoint(x: 0.5216614159916616d, y: 0.05243372628298881d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3465740875910902d, y: 0.8479008887297239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8979368268140117d, y: 0.9517510097907621d), new NpgsqlTypes.NpgsqlPoint(x: 0.03316717201058916d, y: 0.2225006762325683d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20870480819308979d, y: 0.9178386849430047d), new NpgsqlTypes.NpgsqlPoint(x: 0.09295710303816329d, y: 0.5799688465576859d), new NpgsqlTypes.NpgsqlPoint(x: 0.38634318800987577d, y: 0.5596306135789142d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6456044541491601d, y: 0.604291369960402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835654103731172d, y: 0.7720541955427448d), new NpgsqlTypes.NpgsqlPoint(x: 0.3212163432689963d, y: 0.12718052421533121d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5711757489391309d, y: 0.8082826560541257d), new NpgsqlTypes.NpgsqlPoint(x: 0.17275318665899586d, y: 0.9453876994610846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5666031290696664d, y: 0.05169800892808896d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6843754505396619d, y: 0.01979769072622628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367659843092d, y: 0.6753122507263788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7276349261843393d, y: 0.09361016639923081d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6458114581618818d, y: 0.39498243017626267d), new NpgsqlTypes.NpgsqlPoint(x: 0.19218302630489004d, y: 0.2575771445770767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144482392740463d, y: 0.6176363359920498d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8569475711420579d, y: 0.0027679834928558966d), new NpgsqlTypes.NpgsqlPoint(x: 0.4487767534071113d, y: 0.8871073492217217d), new NpgsqlTypes.NpgsqlPoint(x: 0.5201098356317917d, y: 0.8663199445177865d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.752970959688701d, y: 0.16997454606889528d), new NpgsqlTypes.NpgsqlPoint(x: 0.5802175549853467d, y: 0.7133108323905679d), new NpgsqlTypes.NpgsqlPoint(x: 0.28090748724941306d, y: 0.7317849231568588d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3968202658292389d, y: 0.12806279285554079d), new NpgsqlTypes.NpgsqlPoint(x: 0.011087045812388507d, y: 0.5093575947516117d), new NpgsqlTypes.NpgsqlPoint(x: 0.4620913922096169d, y: 0.48477560524805585d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7741829757244361d, y: 0.4345757759133402d), new NpgsqlTypes.NpgsqlPoint(x: 0.45122881617854316d, y: 0.4141395682517425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2117669664319305d, y: 0.666416077489796d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6230227603882144d, y: 0.7997491846863437d), new NpgsqlTypes.NpgsqlPoint(x: 0.1418012255498141d, y: 0.5461971200363277d), new NpgsqlTypes.NpgsqlPoint(x: 0.22476229570875694d, y: 0.5992594720346603d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4285000647084617d, y: 0.20121913595616037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7254101685217661d, y: 0.8466137048154948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6035924495922768d, y: 0.3781005337246448d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28669457920323604d, y: 0.3874283483725828d), new NpgsqlTypes.NpgsqlPoint(x: 0.3154092515498087d, y: 0.35928525413117696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7168860015477652d, y: 0.9954646044307481d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8066750781329095d, y: 0.040134042345891685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919109826807302d, y: 0.619746361125972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6742813656259674d, y: 0.9795366463511056d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1571750980358546d, y: 0.12698079930352346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632823694345433d, y: 0.5287259529152131d), new NpgsqlTypes.NpgsqlPoint(x: 0.04733270100697318d, y: 0.7274520200297465d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9842741056489241d, y: 0.4184524289358956d), new NpgsqlTypes.NpgsqlPoint(x: 0.11295824591801407d, y: 0.8789324619121054d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882479838268031d, y: 0.8591222326362312d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49104251927182285d, y: 0.28324344359597475d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813613873215279d, y: 0.6699771222493065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8233996854370809d, y: 0.8991511122697443d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3798827916122678d, y: 0.8317428898741509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545926531456938d, y: 0.20744705568605815d), new NpgsqlTypes.NpgsqlPoint(x: 0.02923048860569255d, y: 0.4618682672820098d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48597512443284574d, y: 0.7897432636516429d), new NpgsqlTypes.NpgsqlPoint(x: 0.06850823312647303d, y: 0.5595823866216671d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351078725742918d, y: 0.10502969250742633d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6867061834654172d, y: 0.8929317802395601d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899337310989075d, y: 0.3098885830728231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532074118955634d, y: 0.025626576489778063d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.846124579974663d, y: 0.18718193109883896d), new NpgsqlTypes.NpgsqlPoint(x: 0.376794769355962d, y: 0.42103684897418137d), new NpgsqlTypes.NpgsqlPoint(x: 0.35397386101268913d, y: 0.44528011401518497d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3226634794029316d, y: 0.6069468077706147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6605231152370874d, y: 0.6465759642642563d), new NpgsqlTypes.NpgsqlPoint(x: 0.1216517648872858d, y: 0.4144632290793069d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6162805153536376d, y: 0.9402279891378944d), new NpgsqlTypes.NpgsqlPoint(x: 0.8283124120197662d, y: 0.6256837190340518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702062004007991d, y: 0.24954904155725843d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13470226228315718d, y: 0.7838912182802645d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067550778057762d, y: 0.7815529563039284d), new NpgsqlTypes.NpgsqlPoint(x: 0.41612857036262274d, y: 0.43674816334564925d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34411820164417783d, y: 0.8370120734689686d), new NpgsqlTypes.NpgsqlPoint(x: 0.04027801729967495d, y: 0.9879762374016141d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725860764484072d, y: 0.172334592323255d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9554176853200257d, y: 0.24351842283621283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552037000284622d, y: 0.2608899273939106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5192667748267983d, y: 0.5106346437858499d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24236332502659874d, y: 0.05148562054288763d), new NpgsqlTypes.NpgsqlPoint(x: 0.1986711672987701d, y: 0.36047225481957257d), new NpgsqlTypes.NpgsqlPoint(x: 0.0436839907065798d, y: 0.3044635465474784d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3852203095675857d, y: 0.3996741679748903d), new NpgsqlTypes.NpgsqlPoint(x: 0.789039373701719d, y: 0.4614976873402692d), new NpgsqlTypes.NpgsqlPoint(x: 0.7028239087104056d, y: 0.37775123956837275d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5893840372049616d, y: 0.6795110869011706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4376215010140839d, y: 0.7650461058368254d), new NpgsqlTypes.NpgsqlPoint(x: 0.930715681708901d, y: 0.8415373042556927d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.68212793093347d, y: 0.7866520412838557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110469935652208d, y: 0.43536711545621376d), new NpgsqlTypes.NpgsqlPoint(x: 0.1611660984961204d, y: 0.8620337670796568d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24949744802820706d, y: 0.9269412889597858d), new NpgsqlTypes.NpgsqlPoint(x: 0.3693782047461215d, y: 0.1654053181832812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3172231312834771d, y: 0.7778986753793486d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2795351895741739d, y: 0.5917268662005372d), new NpgsqlTypes.NpgsqlPoint(x: 0.20141523318751509d, y: 0.6644127512961874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460471439685601d, y: 0.7310783670687241d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3650675746187755d, y: 0.9465237064931362d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038002481012899d, y: 0.23407075152134993d), new NpgsqlTypes.NpgsqlPoint(x: 0.894863366919902d, y: 0.25460306789215803d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24953762404925606d, y: 0.054601859086468085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8967022992821525d, y: 0.6173835111540504d), new NpgsqlTypes.NpgsqlPoint(x: 0.06049772291593325d, y: 0.1693388084340124d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004205683246189307d, y: 0.6829148364957021d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002194033751799d, y: 0.8355079305618387d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944163394134667d, y: 0.3259886752712109d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10872063844860003d, y: 0.7633494818576032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566836509184213d, y: 0.28847616809263765d), new NpgsqlTypes.NpgsqlPoint(x: 0.25261645256691123d, y: 0.23878374042564665d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5979259264373148d, y: 0.9361396740577569d), new NpgsqlTypes.NpgsqlPoint(x: 0.134219481167424d, y: 0.2927165537166372d), new NpgsqlTypes.NpgsqlPoint(x: 0.23839604230962874d, y: 0.4336755691348434d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9678985415240355d, y: 0.26276896087007084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6964326191989302d, y: 0.0372855057454915d), new NpgsqlTypes.NpgsqlPoint(x: 0.44578441380179534d, y: 0.6863177972500195d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4083321471257322d, y: 0.5282487113367095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6348356826530149d, y: 0.8047612620681823d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301209754209242d, y: 0.5047417836815015d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.959625508085551d, y: 0.3884116610638355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720173348259016d, y: 0.5826705278688014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8457305569683871d, y: 0.656224650742619d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47804306918499717d, y: 0.10302017913518657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4872191928891574d, y: 0.7278417763096685d), new NpgsqlTypes.NpgsqlPoint(x: 0.927884472392908d, y: 0.9921368744419943d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.777375923729231d, y: 0.7403046321036799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678193668292987d, y: 0.009584892267065603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438577655499647d, y: 0.12450391567687924d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24088029857136295d, y: 0.36174050902794064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5804772668756206d, y: 0.24391168725077061d), new NpgsqlTypes.NpgsqlPoint(x: 0.251905477567671d, y: 0.6578115910738067d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9274668866288902d, y: 0.2405451873906771d), new NpgsqlTypes.NpgsqlPoint(x: 0.705765605252313d, y: 0.3831331850957054d), new NpgsqlTypes.NpgsqlPoint(x: 0.2548272542463609d, y: 0.36484591819359213d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1725191975767817d, y: 0.6927046688007692d), new NpgsqlTypes.NpgsqlPoint(x: 0.15989672703080748d, y: 0.6691202514050002d), new NpgsqlTypes.NpgsqlPoint(x: 0.04747000187172912d, y: 0.4375533661577359d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7737121733291972d, y: 0.03376369293826598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4285649379241949d, y: 0.29514293992028007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002250193141938d, y: 0.7999770821137164d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7959019446664922d, y: 0.49304085480802495d), new NpgsqlTypes.NpgsqlPoint(x: 0.3078792101479615d, y: 0.11947228500270601d), new NpgsqlTypes.NpgsqlPoint(x: 0.2180690161455212d, y: 0.47813179964031416d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.134306447699875d, y: 0.9905817264818134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7777422306826144d, y: 0.8994734917213946d), new NpgsqlTypes.NpgsqlPoint(x: 0.006052847022763208d, y: 0.5339401343437573d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47596019667704115d, y: 0.5915346994607956d), new NpgsqlTypes.NpgsqlPoint(x: 0.4477648123326099d, y: 0.0061583479807090225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503594434956217d, y: 0.9319502389850647d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9544931944874377d, y: 0.3316940321601216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5211166096155034d, y: 0.10715732023763436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5712524103827655d, y: 0.20680883129148864d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6743387817190566d, y: 0.09963322499437577d), new NpgsqlTypes.NpgsqlPoint(x: 0.40108258104444927d, y: 0.27953968557259157d), new NpgsqlTypes.NpgsqlPoint(x: 0.09001027008729379d, y: 0.9556551747789314d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4194057541276266d, y: 0.6066945908276855d), new NpgsqlTypes.NpgsqlPoint(x: 0.1925981748662079d, y: 0.7208893097196297d), new NpgsqlTypes.NpgsqlPoint(x: 0.40739979067110155d, y: 0.579046259924396d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5647569836161075d, y: 0.08743110442790258d), new NpgsqlTypes.NpgsqlPoint(x: 0.47703221868632883d, y: 0.675313376981604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764002116476912d, y: 0.22411147110684992d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5695156765660765d, y: 0.4555371804182685d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547303356337108d, y: 0.2682574556136721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774217011617382d, y: 0.7809301871195105d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7718214325984084d, y: 0.8023351573177239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9306081553444723d, y: 0.3438859455352077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7705732038151464d, y: 0.07471592240527891d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.976107156697126d, y: 0.040262926570980406d), new NpgsqlTypes.NpgsqlPoint(x: 0.21631010450810872d, y: 0.24468010576668098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327007407353103d, y: 0.6355465730891994d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8196411725847902d, y: 0.7312492548392744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896527401264587d, y: 0.08447307116162184d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580164080781957d, y: 0.5805778250349385d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16269462761628783d, y: 0.4716724713163011d), new NpgsqlTypes.NpgsqlPoint(x: 0.8347632233162978d, y: 0.5668278661358664d), new NpgsqlTypes.NpgsqlPoint(x: 0.3377706065721786d, y: 0.3469024794529365d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9244734882675719d, y: 0.7036008972405546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810965525408627d, y: 0.6703417452357217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334824490539841d, y: 0.26805442834456417d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16898168202927766d, y: 0.16692606946275634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2740794156975065d, y: 0.24742297810291125d), new NpgsqlTypes.NpgsqlPoint(x: 0.672650914676745d, y: 0.1884421835771689d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14614989235414322d, y: 0.13436303707530628d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836806093581396d, y: 0.3170907270950434d), new NpgsqlTypes.NpgsqlPoint(x: 0.21650906015075821d, y: 0.7074024400998139d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8188086334304301d, y: 0.6588966366186113d), new NpgsqlTypes.NpgsqlPoint(x: 0.76724133355391d, y: 0.3687794161761593d), new NpgsqlTypes.NpgsqlPoint(x: 0.0506497969252383d, y: 0.9364041496675833d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8200096604387216d, y: 0.978419645098777d), new NpgsqlTypes.NpgsqlPoint(x: 0.09420205474323906d, y: 0.6884098819936568d), new NpgsqlTypes.NpgsqlPoint(x: 0.24045084321469246d, y: 0.6589804797010758d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27701271191042676d, y: 0.372539479671086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6957846960788242d, y: 0.9034782513976163d), new NpgsqlTypes.NpgsqlPoint(x: 0.36555040682523776d, y: 0.4770907778225544d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3739313064625761d, y: 0.21989734945505357d), new NpgsqlTypes.NpgsqlPoint(x: 0.4943349338906481d, y: 0.2331190852461501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575157968682156d, y: 0.5706227078622318d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.035614463632072546d, y: 0.3035558395431259d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598062999263621d, y: 0.2627253412279362d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412489415068309d, y: 0.41458931864966897d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8657504686531434d, y: 0.602362395624736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5474186013059215d, y: 0.5529222094687107d), new NpgsqlTypes.NpgsqlPoint(x: 0.12625232988613755d, y: 0.06994730413581296d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6936523729989701d, y: 0.08405647084463386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7438202172469405d, y: 0.6271501512952841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960089140208274d, y: 0.48971934911255965d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14421097029331797d, y: 0.6946919768170168d), new NpgsqlTypes.NpgsqlPoint(x: 0.16099747664267383d, y: 0.44856456480510387d), new NpgsqlTypes.NpgsqlPoint(x: 0.44446515081377014d, y: 0.5377222970206572d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45619016774478416d, y: 0.39510542425273554d), new NpgsqlTypes.NpgsqlPoint(x: 0.19593173550406096d, y: 0.06177475015725764d), new NpgsqlTypes.NpgsqlPoint(x: 0.3185774066906152d, y: 0.7209018628010843d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9397416346820192d, y: 0.8701333979012733d), new NpgsqlTypes.NpgsqlPoint(x: 0.18940478417763595d, y: 0.407382964351945d), new NpgsqlTypes.NpgsqlPoint(x: 0.43191650277576565d, y: 0.7093272025779102d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9997154261919281d, y: 0.909868307467857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9703529609597631d, y: 0.8367249136349667d), new NpgsqlTypes.NpgsqlPoint(x: 0.89054824658629d, y: 0.8946050578446664d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16322076825450182d, y: 0.9158456657947261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284332234729389d, y: 0.481754072871426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4672107532797146d, y: 0.44783390224084674d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23691648282796263d, y: 0.04481066047375892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5831728910574673d, y: 0.04277758347894378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730757563962685d, y: 0.1453042664743177d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5874672725814514d, y: 0.8929570679905279d), new NpgsqlTypes.NpgsqlPoint(x: 0.2897611699336543d, y: 0.9678134926346574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646753802366843d, y: 0.16014651059625185d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22498244195233386d, y: 0.0815539518491577d), new NpgsqlTypes.NpgsqlPoint(x: 0.699892292343728d, y: 0.11544543224462134d), new NpgsqlTypes.NpgsqlPoint(x: 0.2231627048487479d, y: 0.15805067848082488d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39816836521595567d, y: 0.8077040149037233d), new NpgsqlTypes.NpgsqlPoint(x: 0.8339164475930477d, y: 0.481121834836284d), new NpgsqlTypes.NpgsqlPoint(x: 0.5216614159916616d, y: 0.05243372628298881d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3465740875910902d, y: 0.8479008887297239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8979368268140117d, y: 0.9517510097907621d), new NpgsqlTypes.NpgsqlPoint(x: 0.03316717201058916d, y: 0.2225006762325683d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20870480819308979d, y: 0.9178386849430047d), new NpgsqlTypes.NpgsqlPoint(x: 0.09295710303816329d, y: 0.5799688465576859d), new NpgsqlTypes.NpgsqlPoint(x: 0.38634318800987577d, y: 0.5596306135789142d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6456044541491601d, y: 0.604291369960402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835654103731172d, y: 0.7720541955427448d), new NpgsqlTypes.NpgsqlPoint(x: 0.3212163432689963d, y: 0.12718052421533121d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5711757489391309d, y: 0.8082826560541257d), new NpgsqlTypes.NpgsqlPoint(x: 0.17275318665899586d, y: 0.9453876994610846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5666031290696664d, y: 0.05169800892808896d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6843754505396619d, y: 0.01979769072622628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367659843092d, y: 0.6753122507263788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7276349261843393d, y: 0.09361016639923081d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6458114581618818d, y: 0.39498243017626267d), new NpgsqlTypes.NpgsqlPoint(x: 0.19218302630489004d, y: 0.2575771445770767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144482392740463d, y: 0.6176363359920498d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8569475711420579d, y: 0.0027679834928558966d), new NpgsqlTypes.NpgsqlPoint(x: 0.4487767534071113d, y: 0.8871073492217217d), new NpgsqlTypes.NpgsqlPoint(x: 0.5201098356317917d, y: 0.8663199445177865d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.752970959688701d, y: 0.16997454606889528d), new NpgsqlTypes.NpgsqlPoint(x: 0.5802175549853467d, y: 0.7133108323905679d), new NpgsqlTypes.NpgsqlPoint(x: 0.28090748724941306d, y: 0.7317849231568588d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3968202658292389d, y: 0.12806279285554079d), new NpgsqlTypes.NpgsqlPoint(x: 0.011087045812388507d, y: 0.5093575947516117d), new NpgsqlTypes.NpgsqlPoint(x: 0.4620913922096169d, y: 0.48477560524805585d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7741829757244361d, y: 0.4345757759133402d), new NpgsqlTypes.NpgsqlPoint(x: 0.45122881617854316d, y: 0.4141395682517425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2117669664319305d, y: 0.666416077489796d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6230227603882144d, y: 0.7997491846863437d), new NpgsqlTypes.NpgsqlPoint(x: 0.1418012255498141d, y: 0.5461971200363277d), new NpgsqlTypes.NpgsqlPoint(x: 0.22476229570875694d, y: 0.5992594720346603d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4285000647084617d, y: 0.20121913595616037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7254101685217661d, y: 0.8466137048154948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6035924495922768d, y: 0.3781005337246448d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28669457920323604d, y: 0.3874283483725828d), new NpgsqlTypes.NpgsqlPoint(x: 0.3154092515498087d, y: 0.35928525413117696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7168860015477652d, y: 0.9954646044307481d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8066750781329095d, y: 0.040134042345891685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919109826807302d, y: 0.619746361125972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6742813656259674d, y: 0.9795366463511056d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1571750980358546d, y: 0.12698079930352346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632823694345433d, y: 0.5287259529152131d), new NpgsqlTypes.NpgsqlPoint(x: 0.04733270100697318d, y: 0.7274520200297465d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9842741056489241d, y: 0.4184524289358956d), new NpgsqlTypes.NpgsqlPoint(x: 0.11295824591801407d, y: 0.8789324619121054d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882479838268031d, y: 0.8591222326362312d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49104251927182285d, y: 0.28324344359597475d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813613873215279d, y: 0.6699771222493065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8233996854370809d, y: 0.8991511122697443d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3798827916122678d, y: 0.8317428898741509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545926531456938d, y: 0.20744705568605815d), new NpgsqlTypes.NpgsqlPoint(x: 0.02923048860569255d, y: 0.4618682672820098d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48597512443284574d, y: 0.7897432636516429d), new NpgsqlTypes.NpgsqlPoint(x: 0.06850823312647303d, y: 0.5595823866216671d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351078725742918d, y: 0.10502969250742633d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6867061834654172d, y: 0.8929317802395601d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899337310989075d, y: 0.3098885830728231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532074118955634d, y: 0.025626576489778063d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.846124579974663d, y: 0.18718193109883896d), new NpgsqlTypes.NpgsqlPoint(x: 0.376794769355962d, y: 0.42103684897418137d), new NpgsqlTypes.NpgsqlPoint(x: 0.35397386101268913d, y: 0.44528011401518497d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3226634794029316d, y: 0.6069468077706147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6605231152370874d, y: 0.6465759642642563d), new NpgsqlTypes.NpgsqlPoint(x: 0.1216517648872858d, y: 0.4144632290793069d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6162805153536376d, y: 0.9402279891378944d), new NpgsqlTypes.NpgsqlPoint(x: 0.8283124120197662d, y: 0.6256837190340518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702062004007991d, y: 0.24954904155725843d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13470226228315718d, y: 0.7838912182802645d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067550778057762d, y: 0.7815529563039284d), new NpgsqlTypes.NpgsqlPoint(x: 0.41612857036262274d, y: 0.43674816334564925d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34411820164417783d, y: 0.8370120734689686d), new NpgsqlTypes.NpgsqlPoint(x: 0.04027801729967495d, y: 0.9879762374016141d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725860764484072d, y: 0.172334592323255d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9554176853200257d, y: 0.24351842283621283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552037000284622d, y: 0.2608899273939106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5192667748267983d, y: 0.5106346437858499d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24236332502659874d, y: 0.05148562054288763d), new NpgsqlTypes.NpgsqlPoint(x: 0.1986711672987701d, y: 0.36047225481957257d), new NpgsqlTypes.NpgsqlPoint(x: 0.0436839907065798d, y: 0.3044635465474784d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3852203095675857d, y: 0.3996741679748903d), new NpgsqlTypes.NpgsqlPoint(x: 0.789039373701719d, y: 0.4614976873402692d), new NpgsqlTypes.NpgsqlPoint(x: 0.7028239087104056d, y: 0.37775123956837275d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5893840372049616d, y: 0.6795110869011706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4376215010140839d, y: 0.7650461058368254d), new NpgsqlTypes.NpgsqlPoint(x: 0.930715681708901d, y: 0.8415373042556927d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.68212793093347d, y: 0.7866520412838557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110469935652208d, y: 0.43536711545621376d), new NpgsqlTypes.NpgsqlPoint(x: 0.1611660984961204d, y: 0.8620337670796568d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24949744802820706d, y: 0.9269412889597858d), new NpgsqlTypes.NpgsqlPoint(x: 0.3693782047461215d, y: 0.1654053181832812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3172231312834771d, y: 0.7778986753793486d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2795351895741739d, y: 0.5917268662005372d), new NpgsqlTypes.NpgsqlPoint(x: 0.20141523318751509d, y: 0.6644127512961874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460471439685601d, y: 0.7310783670687241d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3650675746187755d, y: 0.9465237064931362d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038002481012899d, y: 0.23407075152134993d), new NpgsqlTypes.NpgsqlPoint(x: 0.894863366919902d, y: 0.25460306789215803d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24953762404925606d, y: 0.054601859086468085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8967022992821525d, y: 0.6173835111540504d), new NpgsqlTypes.NpgsqlPoint(x: 0.06049772291593325d, y: 0.1693388084340124d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004205683246189307d, y: 0.6829148364957021d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002194033751799d, y: 0.8355079305618387d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944163394134667d, y: 0.3259886752712109d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10872063844860003d, y: 0.7633494818576032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566836509184213d, y: 0.28847616809263765d), new NpgsqlTypes.NpgsqlPoint(x: 0.25261645256691123d, y: 0.23878374042564665d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5979259264373148d, y: 0.9361396740577569d), new NpgsqlTypes.NpgsqlPoint(x: 0.134219481167424d, y: 0.2927165537166372d), new NpgsqlTypes.NpgsqlPoint(x: 0.23839604230962874d, y: 0.4336755691348434d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9678985415240355d, y: 0.26276896087007084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6964326191989302d, y: 0.0372855057454915d), new NpgsqlTypes.NpgsqlPoint(x: 0.44578441380179534d, y: 0.6863177972500195d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4083321471257322d, y: 0.5282487113367095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6348356826530149d, y: 0.8047612620681823d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301209754209242d, y: 0.5047417836815015d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.959625508085551d, y: 0.3884116610638355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720173348259016d, y: 0.5826705278688014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8457305569683871d, y: 0.656224650742619d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47804306918499717d, y: 0.10302017913518657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4872191928891574d, y: 0.7278417763096685d), new NpgsqlTypes.NpgsqlPoint(x: 0.927884472392908d, y: 0.9921368744419943d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.777375923729231d, y: 0.7403046321036799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678193668292987d, y: 0.009584892267065603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438577655499647d, y: 0.12450391567687924d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24088029857136295d, y: 0.36174050902794064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5804772668756206d, y: 0.24391168725077061d), new NpgsqlTypes.NpgsqlPoint(x: 0.251905477567671d, y: 0.6578115910738067d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9274668866288902d, y: 0.2405451873906771d), new NpgsqlTypes.NpgsqlPoint(x: 0.705765605252313d, y: 0.3831331850957054d), new NpgsqlTypes.NpgsqlPoint(x: 0.2548272542463609d, y: 0.36484591819359213d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1725191975767817d, y: 0.6927046688007692d), new NpgsqlTypes.NpgsqlPoint(x: 0.15989672703080748d, y: 0.6691202514050002d), new NpgsqlTypes.NpgsqlPoint(x: 0.04747000187172912d, y: 0.4375533661577359d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7737121733291972d, y: 0.03376369293826598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4285649379241949d, y: 0.29514293992028007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002250193141938d, y: 0.7999770821137164d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7959019446664922d, y: 0.49304085480802495d), new NpgsqlTypes.NpgsqlPoint(x: 0.3078792101479615d, y: 0.11947228500270601d), new NpgsqlTypes.NpgsqlPoint(x: 0.2180690161455212d, y: 0.47813179964031416d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.134306447699875d, y: 0.9905817264818134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7777422306826144d, y: 0.8994734917213946d), new NpgsqlTypes.NpgsqlPoint(x: 0.006052847022763208d, y: 0.5339401343437573d)))));

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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygon0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygon0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI), typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

