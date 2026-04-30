

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
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23411111075457058d, y: 0.6741456006252893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7155377221211209d, y: 0.1978829460498579d), new NpgsqlTypes.NpgsqlPoint(x: 0.8687799790441922d, y: 0.1681922642066842d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39238895905420046d, y: 0.9252620957789968d), new NpgsqlTypes.NpgsqlPoint(x: 0.577233749178644d, y: 0.12186273193503139d), new NpgsqlTypes.NpgsqlPoint(x: 0.0942389046489508d, y: 0.21013122250162775d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3667575770316015d, y: 0.9494864699844224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585224022460992d, y: 0.25728653263200696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7951888426756519d, y: 0.3623352345812729d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8845569840952077d, y: 0.7374206889990265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825422821196647d, y: 0.3745962688777392d), new NpgsqlTypes.NpgsqlPoint(x: 0.028374588878853135d, y: 0.033902479686500064d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05787646996160012d, y: 0.7466151569272369d), new NpgsqlTypes.NpgsqlPoint(x: 0.29026342657089466d, y: 0.7281856272128249d), new NpgsqlTypes.NpgsqlPoint(x: 0.4985363232602126d, y: 0.8568743749581652d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9569695848855049d, y: 0.6276360413682688d), new NpgsqlTypes.NpgsqlPoint(x: 0.09052468046685946d, y: 0.004626645276924357d), new NpgsqlTypes.NpgsqlPoint(x: 0.1633188508082113d, y: 0.6973730000544462d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0031691819116164144d, y: 0.13694383919733144d), new NpgsqlTypes.NpgsqlPoint(x: 0.969411525741198d, y: 0.2857136794707974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452380190690905d, y: 0.44239841703984917d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8340353460619139d, y: 0.7893922231878656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530199158052728d, y: 0.6329696086374628d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004326651478071d, y: 0.14949543959444123d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12188406562839227d, y: 0.52652402668781d), new NpgsqlTypes.NpgsqlPoint(x: 0.6540588487248322d, y: 0.7729450437857835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5892745887071337d, y: 0.5282771255021443d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5162390259308067d, y: 0.6876006440285846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465153536801403d, y: 0.39745728144409187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201266886908468d, y: 0.2020176943816936d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7315597219505922d, y: 0.5871488391213036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590306062722807d, y: 0.6111151274832942d), new NpgsqlTypes.NpgsqlPoint(x: 0.21739201366432814d, y: 0.44195822447402866d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3518953859339967d, y: 0.6318914920513071d), new NpgsqlTypes.NpgsqlPoint(x: 0.20395506233356353d, y: 0.37548380643822854d), new NpgsqlTypes.NpgsqlPoint(x: 0.38365649111539424d, y: 0.44289275865101885d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06327737184764148d, y: 0.7461338139471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027601716684828d, y: 0.8219407088846334d), new NpgsqlTypes.NpgsqlPoint(x: 0.10017660227525649d, y: 0.928676794689073d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3838747528908617d, y: 0.5476489213224125d), new NpgsqlTypes.NpgsqlPoint(x: 0.218969298347085d, y: 0.6790788561861199d), new NpgsqlTypes.NpgsqlPoint(x: 0.3499927923560153d, y: 0.19434672852727386d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25531755659757194d, y: 0.9829656941805861d), new NpgsqlTypes.NpgsqlPoint(x: 0.32467569509046534d, y: 0.8304545806890953d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227046702400304d, y: 0.20825033431985174d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2698511461664257d, y: 0.06333288111540303d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906750967803224d, y: 0.8879009396320555d), new NpgsqlTypes.NpgsqlPoint(x: 0.675865547876203d, y: 0.3801494671355492d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.554773791411561d, y: 0.10436504470139685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483923151616683d, y: 0.818884590528801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765719320863251d, y: 0.2269963142102871d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31823984699598173d, y: 0.4354960201338043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612321098526083d, y: 0.9265251619306936d), new NpgsqlTypes.NpgsqlPoint(x: 0.46126320721592584d, y: 0.5225685372546018d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4689033151737356d, y: 0.1950232114018824d), new NpgsqlTypes.NpgsqlPoint(x: 0.4311952427981486d, y: 0.5166131202936818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844273652623014d, y: 0.790365566598528d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6486472212841207d, y: 0.6092097561087672d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240044202534379d, y: 0.9297749462081278d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071486406499177d, y: 0.11521607183422722d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17267410305561293d, y: 0.4885535096808118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581877361631269d, y: 0.4942666176317997d), new NpgsqlTypes.NpgsqlPoint(x: 0.23378916089175739d, y: 0.7148693071177952d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9624797915820896d, y: 0.06141896968414706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831010058379074d, y: 0.08675355815811825d), new NpgsqlTypes.NpgsqlPoint(x: 0.03433111186196547d, y: 0.04668405539952514d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6398206751114421d, y: 0.4703940160334631d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653563272776835d, y: 0.4830019831002612d), new NpgsqlTypes.NpgsqlPoint(x: 0.46203119158705974d, y: 0.3338146080023231d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9379366018770214d, y: 0.6417356789681155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039854350645343d, y: 0.3425913416053866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470275594708302d, y: 0.7558729229530491d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5037344640282818d, y: 0.42821941737619884d), new NpgsqlTypes.NpgsqlPoint(x: 0.13635720050427447d, y: 0.6960785373616614d), new NpgsqlTypes.NpgsqlPoint(x: 0.402732161695181d, y: 0.3522547302884954d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14608951785968272d, y: 0.18973940366267916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848753032618587d, y: 0.2326134846854403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879569198430939d, y: 0.9056552252956948d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5441479324581817d, y: 0.2067166450033162d), new NpgsqlTypes.NpgsqlPoint(x: 0.6532473502339251d, y: 0.7908048209323312d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552446268956675d, y: 0.37284393432799723d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42952172802039634d, y: 0.6286126496055302d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328446307567129d, y: 0.8635150913025533d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342258204857049d, y: 0.5686681822434589d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6196678501653196d, y: 0.6628662545220936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835330046459051d, y: 0.7403927499482826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9684922464777037d, y: 0.35945676447434516d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8920685610708559d, y: 0.3945269005040898d), new NpgsqlTypes.NpgsqlPoint(x: 0.38933947209602593d, y: 0.11836275875785729d), new NpgsqlTypes.NpgsqlPoint(x: 0.22048752265691185d, y: 0.012446331656817966d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8298274378570688d, y: 0.6149322153572718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4408500504617473d, y: 0.4002310669704854d), new NpgsqlTypes.NpgsqlPoint(x: 0.3375511718711718d, y: 0.7157758484238996d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8369476728947186d, y: 0.6411875841373789d), new NpgsqlTypes.NpgsqlPoint(x: 0.31566661950470265d, y: 0.6286642527451233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3094436611564484d, y: 0.4249943142371272d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44036438945327283d, y: 0.39469157211729544d), new NpgsqlTypes.NpgsqlPoint(x: 0.3800695524389264d, y: 0.8288672504478939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2854650682473642d, y: 0.04016209200891774d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29138709256356565d, y: 0.6953574980603177d), new NpgsqlTypes.NpgsqlPoint(x: 0.7224907004576576d, y: 0.06540898133061179d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696579725880097d, y: 0.2350139744734544d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9713555062870469d, y: 0.3844963707236443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8735989067240322d, y: 0.12973988566019456d), new NpgsqlTypes.NpgsqlPoint(x: 0.08379685441206086d, y: 0.19377824362952722d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7221081827947765d, y: 0.5372264169282949d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346478085322912d, y: 0.7027938022094664d), new NpgsqlTypes.NpgsqlPoint(x: 0.47868467012030635d, y: 0.051678191212232494d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028902813879190248d, y: 0.38993989224138326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8577766146383168d, y: 0.9080048188407728d), new NpgsqlTypes.NpgsqlPoint(x: 0.20943048718215074d, y: 0.8283365999396356d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5472911640408559d, y: 0.8339556738401764d), new NpgsqlTypes.NpgsqlPoint(x: 0.28371635232400105d, y: 0.8435053161511283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070406104306012d, y: 0.8517276829676447d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17753715040170193d, y: 0.8692823861595537d), new NpgsqlTypes.NpgsqlPoint(x: 0.32696438710537035d, y: 0.594988083199962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4837121524226242d, y: 0.7161700294557632d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5876405635564423d, y: 0.3768592292969759d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217098338227284d, y: 0.08966167625962251d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848344387377469d, y: 0.46709321704252593d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6929523415152592d, y: 0.9035257058801237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7745297272813815d, y: 0.24343621637116497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5844729740178567d, y: 0.12040319031002478d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7456657641866278d, y: 0.8095503281090632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249483709963268d, y: 0.6713270767150857d), new NpgsqlTypes.NpgsqlPoint(x: 0.02278785645549597d, y: 0.7853081700843294d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5453098153305627d, y: 0.5141581421565975d), new NpgsqlTypes.NpgsqlPoint(x: 0.2077664528868607d, y: 0.22458472497930682d), new NpgsqlTypes.NpgsqlPoint(x: 0.6052018540292802d, y: 0.5602116336487933d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07980731536981012d, y: 0.8182465332510648d), new NpgsqlTypes.NpgsqlPoint(x: 0.06729524261788733d, y: 0.09730859601519048d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285011707118777d, y: 0.751169320846629d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29141607143259207d, y: 0.2556755542205499d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627091828523733d, y: 0.13656583850645343d), new NpgsqlTypes.NpgsqlPoint(x: 0.046289434728087886d, y: 0.388725945024861d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3114948874291369d, y: 0.27702119174573936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879634937833779d, y: 0.5249798246744971d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837743316447485d, y: 0.484865471759131d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1956506347041861d, y: 0.0857056577363634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2765987163389363d, y: 0.6473397033747027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699490583117431d, y: 0.9182433056578573d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8425607604521119d, y: 0.05441014276099554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810486559230077d, y: 0.8876803675252541d), new NpgsqlTypes.NpgsqlPoint(x: 0.878391243594643d, y: 0.2373905498961928d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944510164598244d, y: 0.500437345177661d), new NpgsqlTypes.NpgsqlPoint(x: 0.996107391164437d, y: 0.7205275077970869d), new NpgsqlTypes.NpgsqlPoint(x: 0.38873805524230476d, y: 0.11142318388177885d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1414852968632061d, y: 0.3845949978632749d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927316191615426d, y: 0.19820052232787677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376245118788446d, y: 0.09167998927879506d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004535573403795068d, y: 0.2305236026460863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4928060365701755d, y: 0.8613752793444005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9338083311548583d, y: 0.6886500475847225d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07780037936395867d, y: 0.42893106264414793d), new NpgsqlTypes.NpgsqlPoint(x: 0.1664088591802073d, y: 0.23911303263883577d), new NpgsqlTypes.NpgsqlPoint(x: 0.3648400118993116d, y: 0.8732194086607057d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7336430430627808d, y: 0.05373579680647245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5526050838771495d, y: 0.5272372662644871d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765878011669141d, y: 0.39433075829179165d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9615072768668582d, y: 0.1942031196818903d), new NpgsqlTypes.NpgsqlPoint(x: 0.975715281657575d, y: 0.6609076292332876d), new NpgsqlTypes.NpgsqlPoint(x: 0.091169655562644d, y: 0.07209428743385216d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8116584568778904d, y: 0.9578934760237013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455976023617336d, y: 0.3364229695955604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776080377829234d, y: 0.3312010665901034d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41525236969655477d, y: 0.950224556257303d), new NpgsqlTypes.NpgsqlPoint(x: 0.7117350286725059d, y: 0.4177821841700827d), new NpgsqlTypes.NpgsqlPoint(x: 0.15189422170343247d, y: 0.2652171013588618d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9159703478105677d, y: 0.7740349170814201d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761177650443286d, y: 0.15524081492826058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098522600060361d, y: 0.19972225674183064d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7355211577742128d, y: 0.8973296246212777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459150546260913d, y: 0.002108640697466191d), new NpgsqlTypes.NpgsqlPoint(x: 0.23174467771407326d, y: 0.4509388772531293d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32800914246500834d, y: 0.249245186889687d), new NpgsqlTypes.NpgsqlPoint(x: 0.0640264294201619d, y: 0.8898315167223375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324018937383117d, y: 0.20203443476431338d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2529626228039885d, y: 0.24041686021185793d), new NpgsqlTypes.NpgsqlPoint(x: 0.35751829857652806d, y: 0.5651053938554559d), new NpgsqlTypes.NpgsqlPoint(x: 0.1868323159911065d, y: 0.7649143303831795d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15769828303254252d, y: 0.8339316223530522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9677896344596254d, y: 0.7293221964664388d), new NpgsqlTypes.NpgsqlPoint(x: 0.519201757941975d, y: 0.41616348044804363d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5785719610092729d, y: 0.3443114375325367d), new NpgsqlTypes.NpgsqlPoint(x: 0.20702133508080722d, y: 0.042884046435619494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443240697395798d, y: 0.6668944715086476d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48899911739264257d, y: 0.8514008976229174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156516936821151d, y: 0.37564581656582086d), new NpgsqlTypes.NpgsqlPoint(x: 0.727167307977827d, y: 0.8781693152405762d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.533199260369435d, y: 0.8234017466893057d), new NpgsqlTypes.NpgsqlPoint(x: 0.991255163023308d, y: 0.380805521384868d), new NpgsqlTypes.NpgsqlPoint(x: 0.10963919465997585d, y: 0.33564472798351475d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11254651353038103d, y: 0.6001297529472829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4584464041174393d, y: 0.7997316888901541d), new NpgsqlTypes.NpgsqlPoint(x: 0.06016355465651657d, y: 0.6429015899426028d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7270275544156307d, y: 0.8410102593131112d), new NpgsqlTypes.NpgsqlPoint(x: 0.22016643937329983d, y: 0.95861897901964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4715307275617051d, y: 0.03082611595148743d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07065859413889286d, y: 0.37463186162846185d), new NpgsqlTypes.NpgsqlPoint(x: 0.38828644023516845d, y: 0.1730534558327982d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495307104864157d, y: 0.3187914106690388d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8262287693422693d, y: 0.9201260430269033d), new NpgsqlTypes.NpgsqlPoint(x: 0.7259021786949746d, y: 0.3140188990114269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9130613171459802d, y: 0.06896450298618217d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33802309303197d, y: 0.3016754117004703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7150757726716738d, y: 0.6842402859949058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490954435853645d, y: 0.6070991751430052d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8964408557253626d, y: 0.253435415562105d), new NpgsqlTypes.NpgsqlPoint(x: 0.07521599363346099d, y: 0.2828544566707064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633182786950886d, y: 0.9979754723683933d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4726925699306448d, y: 0.387769523568788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085791692101548d, y: 0.25501122521633524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384493080488385d, y: 0.0002009739754273987d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8416028113254626d, y: 0.8478417881538548d), new NpgsqlTypes.NpgsqlPoint(x: 0.23635562353204642d, y: 0.7857978078317109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015907760953023d, y: 0.19684280085970762d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9326411299717269d, y: 0.2021761053977369d), new NpgsqlTypes.NpgsqlPoint(x: 0.0488991450013192d, y: 0.6254282898139787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765972880551218d, y: 0.14558915372532832d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38804349281903316d, y: 0.2843114595739398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5982613249897545d, y: 0.4511161161766195d), new NpgsqlTypes.NpgsqlPoint(x: 0.6009869723686113d, y: 0.823756756178562d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 174,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8875150605618756d, y: 0.7321953105669373d), new NpgsqlTypes.NpgsqlPoint(x: 0.47437610111475315d, y: 0.2706674146641378d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702762100776536d, y: 0.7402539388356006d)),
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3838747528908617d, y: 0.5476489213224125d), new NpgsqlTypes.NpgsqlPoint(x: 0.218969298347085d, y: 0.6790788561861199d), new NpgsqlTypes.NpgsqlPoint(x: 0.3499927923560153d, y: 0.19434672852727386d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.554773791411561d, y: 0.10436504470139685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483923151616683d, y: 0.818884590528801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765719320863251d, y: 0.2269963142102871d))));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17267410305561293d, y: 0.4885535096808118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581877361631269d, y: 0.4942666176317997d), new NpgsqlTypes.NpgsqlPoint(x: 0.23378916089175739d, y: 0.7148693071177952d))));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14608951785968272d, y: 0.18973940366267916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848753032618587d, y: 0.2326134846854403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879569198430939d, y: 0.9056552252956948d))));
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[34], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 166, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[34], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 130, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 151, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 151, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[33],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 151, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[34], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 138, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 16, query1, 8, query2))
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[34], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 66, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 10, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 166, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[34], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[30], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[31], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[32], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[33], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[29], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[30], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[31], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[32], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[33], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23411111075457058d, y: 0.6741456006252893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7155377221211209d, y: 0.1978829460498579d), new NpgsqlTypes.NpgsqlPoint(x: 0.8687799790441922d, y: 0.1681922642066842d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39238895905420046d, y: 0.9252620957789968d), new NpgsqlTypes.NpgsqlPoint(x: 0.577233749178644d, y: 0.12186273193503139d), new NpgsqlTypes.NpgsqlPoint(x: 0.0942389046489508d, y: 0.21013122250162775d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3667575770316015d, y: 0.9494864699844224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585224022460992d, y: 0.25728653263200696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7951888426756519d, y: 0.3623352345812729d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8845569840952077d, y: 0.7374206889990265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825422821196647d, y: 0.3745962688777392d), new NpgsqlTypes.NpgsqlPoint(x: 0.028374588878853135d, y: 0.033902479686500064d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05787646996160012d, y: 0.7466151569272369d), new NpgsqlTypes.NpgsqlPoint(x: 0.29026342657089466d, y: 0.7281856272128249d), new NpgsqlTypes.NpgsqlPoint(x: 0.4985363232602126d, y: 0.8568743749581652d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9569695848855049d, y: 0.6276360413682688d), new NpgsqlTypes.NpgsqlPoint(x: 0.09052468046685946d, y: 0.004626645276924357d), new NpgsqlTypes.NpgsqlPoint(x: 0.1633188508082113d, y: 0.6973730000544462d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0031691819116164144d, y: 0.13694383919733144d), new NpgsqlTypes.NpgsqlPoint(x: 0.969411525741198d, y: 0.2857136794707974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452380190690905d, y: 0.44239841703984917d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8340353460619139d, y: 0.7893922231878656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530199158052728d, y: 0.6329696086374628d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004326651478071d, y: 0.14949543959444123d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12188406562839227d, y: 0.52652402668781d), new NpgsqlTypes.NpgsqlPoint(x: 0.6540588487248322d, y: 0.7729450437857835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5892745887071337d, y: 0.5282771255021443d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5162390259308067d, y: 0.6876006440285846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465153536801403d, y: 0.39745728144409187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201266886908468d, y: 0.2020176943816936d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7315597219505922d, y: 0.5871488391213036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590306062722807d, y: 0.6111151274832942d), new NpgsqlTypes.NpgsqlPoint(x: 0.21739201366432814d, y: 0.44195822447402866d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3518953859339967d, y: 0.6318914920513071d), new NpgsqlTypes.NpgsqlPoint(x: 0.20395506233356353d, y: 0.37548380643822854d), new NpgsqlTypes.NpgsqlPoint(x: 0.38365649111539424d, y: 0.44289275865101885d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06327737184764148d, y: 0.7461338139471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027601716684828d, y: 0.8219407088846334d), new NpgsqlTypes.NpgsqlPoint(x: 0.10017660227525649d, y: 0.928676794689073d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3838747528908617d, y: 0.5476489213224125d), new NpgsqlTypes.NpgsqlPoint(x: 0.218969298347085d, y: 0.6790788561861199d), new NpgsqlTypes.NpgsqlPoint(x: 0.3499927923560153d, y: 0.19434672852727386d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25531755659757194d, y: 0.9829656941805861d), new NpgsqlTypes.NpgsqlPoint(x: 0.32467569509046534d, y: 0.8304545806890953d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227046702400304d, y: 0.20825033431985174d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2698511461664257d, y: 0.06333288111540303d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906750967803224d, y: 0.8879009396320555d), new NpgsqlTypes.NpgsqlPoint(x: 0.675865547876203d, y: 0.3801494671355492d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.554773791411561d, y: 0.10436504470139685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483923151616683d, y: 0.818884590528801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765719320863251d, y: 0.2269963142102871d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31823984699598173d, y: 0.4354960201338043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612321098526083d, y: 0.9265251619306936d), new NpgsqlTypes.NpgsqlPoint(x: 0.46126320721592584d, y: 0.5225685372546018d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4689033151737356d, y: 0.1950232114018824d), new NpgsqlTypes.NpgsqlPoint(x: 0.4311952427981486d, y: 0.5166131202936818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844273652623014d, y: 0.790365566598528d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6486472212841207d, y: 0.6092097561087672d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240044202534379d, y: 0.9297749462081278d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071486406499177d, y: 0.11521607183422722d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17267410305561293d, y: 0.4885535096808118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581877361631269d, y: 0.4942666176317997d), new NpgsqlTypes.NpgsqlPoint(x: 0.23378916089175739d, y: 0.7148693071177952d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9624797915820896d, y: 0.06141896968414706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831010058379074d, y: 0.08675355815811825d), new NpgsqlTypes.NpgsqlPoint(x: 0.03433111186196547d, y: 0.04668405539952514d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6398206751114421d, y: 0.4703940160334631d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653563272776835d, y: 0.4830019831002612d), new NpgsqlTypes.NpgsqlPoint(x: 0.46203119158705974d, y: 0.3338146080023231d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9379366018770214d, y: 0.6417356789681155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039854350645343d, y: 0.3425913416053866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470275594708302d, y: 0.7558729229530491d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5037344640282818d, y: 0.42821941737619884d), new NpgsqlTypes.NpgsqlPoint(x: 0.13635720050427447d, y: 0.6960785373616614d), new NpgsqlTypes.NpgsqlPoint(x: 0.402732161695181d, y: 0.3522547302884954d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14608951785968272d, y: 0.18973940366267916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848753032618587d, y: 0.2326134846854403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879569198430939d, y: 0.9056552252956948d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5441479324581817d, y: 0.2067166450033162d), new NpgsqlTypes.NpgsqlPoint(x: 0.6532473502339251d, y: 0.7908048209323312d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552446268956675d, y: 0.37284393432799723d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42952172802039634d, y: 0.6286126496055302d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328446307567129d, y: 0.8635150913025533d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342258204857049d, y: 0.5686681822434589d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6196678501653196d, y: 0.6628662545220936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835330046459051d, y: 0.7403927499482826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9684922464777037d, y: 0.35945676447434516d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8920685610708559d, y: 0.3945269005040898d), new NpgsqlTypes.NpgsqlPoint(x: 0.38933947209602593d, y: 0.11836275875785729d), new NpgsqlTypes.NpgsqlPoint(x: 0.22048752265691185d, y: 0.012446331656817966d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8298274378570688d, y: 0.6149322153572718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4408500504617473d, y: 0.4002310669704854d), new NpgsqlTypes.NpgsqlPoint(x: 0.3375511718711718d, y: 0.7157758484238996d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8369476728947186d, y: 0.6411875841373789d), new NpgsqlTypes.NpgsqlPoint(x: 0.31566661950470265d, y: 0.6286642527451233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3094436611564484d, y: 0.4249943142371272d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44036438945327283d, y: 0.39469157211729544d), new NpgsqlTypes.NpgsqlPoint(x: 0.3800695524389264d, y: 0.8288672504478939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2854650682473642d, y: 0.04016209200891774d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29138709256356565d, y: 0.6953574980603177d), new NpgsqlTypes.NpgsqlPoint(x: 0.7224907004576576d, y: 0.06540898133061179d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696579725880097d, y: 0.2350139744734544d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9713555062870469d, y: 0.3844963707236443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8735989067240322d, y: 0.12973988566019456d), new NpgsqlTypes.NpgsqlPoint(x: 0.08379685441206086d, y: 0.19377824362952722d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7221081827947765d, y: 0.5372264169282949d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346478085322912d, y: 0.7027938022094664d), new NpgsqlTypes.NpgsqlPoint(x: 0.47868467012030635d, y: 0.051678191212232494d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028902813879190248d, y: 0.38993989224138326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8577766146383168d, y: 0.9080048188407728d), new NpgsqlTypes.NpgsqlPoint(x: 0.20943048718215074d, y: 0.8283365999396356d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5472911640408559d, y: 0.8339556738401764d), new NpgsqlTypes.NpgsqlPoint(x: 0.28371635232400105d, y: 0.8435053161511283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070406104306012d, y: 0.8517276829676447d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17753715040170193d, y: 0.8692823861595537d), new NpgsqlTypes.NpgsqlPoint(x: 0.32696438710537035d, y: 0.594988083199962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4837121524226242d, y: 0.7161700294557632d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5876405635564423d, y: 0.3768592292969759d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217098338227284d, y: 0.08966167625962251d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848344387377469d, y: 0.46709321704252593d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6929523415152592d, y: 0.9035257058801237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7745297272813815d, y: 0.24343621637116497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5844729740178567d, y: 0.12040319031002478d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7456657641866278d, y: 0.8095503281090632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249483709963268d, y: 0.6713270767150857d), new NpgsqlTypes.NpgsqlPoint(x: 0.02278785645549597d, y: 0.7853081700843294d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5453098153305627d, y: 0.5141581421565975d), new NpgsqlTypes.NpgsqlPoint(x: 0.2077664528868607d, y: 0.22458472497930682d), new NpgsqlTypes.NpgsqlPoint(x: 0.6052018540292802d, y: 0.5602116336487933d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07980731536981012d, y: 0.8182465332510648d), new NpgsqlTypes.NpgsqlPoint(x: 0.06729524261788733d, y: 0.09730859601519048d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285011707118777d, y: 0.751169320846629d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29141607143259207d, y: 0.2556755542205499d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627091828523733d, y: 0.13656583850645343d), new NpgsqlTypes.NpgsqlPoint(x: 0.046289434728087886d, y: 0.388725945024861d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3114948874291369d, y: 0.27702119174573936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879634937833779d, y: 0.5249798246744971d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837743316447485d, y: 0.484865471759131d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1956506347041861d, y: 0.0857056577363634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2765987163389363d, y: 0.6473397033747027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699490583117431d, y: 0.9182433056578573d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8425607604521119d, y: 0.05441014276099554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810486559230077d, y: 0.8876803675252541d), new NpgsqlTypes.NpgsqlPoint(x: 0.878391243594643d, y: 0.2373905498961928d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944510164598244d, y: 0.500437345177661d), new NpgsqlTypes.NpgsqlPoint(x: 0.996107391164437d, y: 0.7205275077970869d), new NpgsqlTypes.NpgsqlPoint(x: 0.38873805524230476d, y: 0.11142318388177885d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1414852968632061d, y: 0.3845949978632749d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927316191615426d, y: 0.19820052232787677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376245118788446d, y: 0.09167998927879506d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004535573403795068d, y: 0.2305236026460863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4928060365701755d, y: 0.8613752793444005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9338083311548583d, y: 0.6886500475847225d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07780037936395867d, y: 0.42893106264414793d), new NpgsqlTypes.NpgsqlPoint(x: 0.1664088591802073d, y: 0.23911303263883577d), new NpgsqlTypes.NpgsqlPoint(x: 0.3648400118993116d, y: 0.8732194086607057d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7336430430627808d, y: 0.05373579680647245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5526050838771495d, y: 0.5272372662644871d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765878011669141d, y: 0.39433075829179165d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9615072768668582d, y: 0.1942031196818903d), new NpgsqlTypes.NpgsqlPoint(x: 0.975715281657575d, y: 0.6609076292332876d), new NpgsqlTypes.NpgsqlPoint(x: 0.091169655562644d, y: 0.07209428743385216d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8116584568778904d, y: 0.9578934760237013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455976023617336d, y: 0.3364229695955604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776080377829234d, y: 0.3312010665901034d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41525236969655477d, y: 0.950224556257303d), new NpgsqlTypes.NpgsqlPoint(x: 0.7117350286725059d, y: 0.4177821841700827d), new NpgsqlTypes.NpgsqlPoint(x: 0.15189422170343247d, y: 0.2652171013588618d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9159703478105677d, y: 0.7740349170814201d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761177650443286d, y: 0.15524081492826058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098522600060361d, y: 0.19972225674183064d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7355211577742128d, y: 0.8973296246212777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459150546260913d, y: 0.002108640697466191d), new NpgsqlTypes.NpgsqlPoint(x: 0.23174467771407326d, y: 0.4509388772531293d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32800914246500834d, y: 0.249245186889687d), new NpgsqlTypes.NpgsqlPoint(x: 0.0640264294201619d, y: 0.8898315167223375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324018937383117d, y: 0.20203443476431338d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2529626228039885d, y: 0.24041686021185793d), new NpgsqlTypes.NpgsqlPoint(x: 0.35751829857652806d, y: 0.5651053938554559d), new NpgsqlTypes.NpgsqlPoint(x: 0.1868323159911065d, y: 0.7649143303831795d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15769828303254252d, y: 0.8339316223530522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9677896344596254d, y: 0.7293221964664388d), new NpgsqlTypes.NpgsqlPoint(x: 0.519201757941975d, y: 0.41616348044804363d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5785719610092729d, y: 0.3443114375325367d), new NpgsqlTypes.NpgsqlPoint(x: 0.20702133508080722d, y: 0.042884046435619494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443240697395798d, y: 0.6668944715086476d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48899911739264257d, y: 0.8514008976229174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156516936821151d, y: 0.37564581656582086d), new NpgsqlTypes.NpgsqlPoint(x: 0.727167307977827d, y: 0.8781693152405762d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.533199260369435d, y: 0.8234017466893057d), new NpgsqlTypes.NpgsqlPoint(x: 0.991255163023308d, y: 0.380805521384868d), new NpgsqlTypes.NpgsqlPoint(x: 0.10963919465997585d, y: 0.33564472798351475d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11254651353038103d, y: 0.6001297529472829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4584464041174393d, y: 0.7997316888901541d), new NpgsqlTypes.NpgsqlPoint(x: 0.06016355465651657d, y: 0.6429015899426028d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7270275544156307d, y: 0.8410102593131112d), new NpgsqlTypes.NpgsqlPoint(x: 0.22016643937329983d, y: 0.95861897901964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4715307275617051d, y: 0.03082611595148743d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07065859413889286d, y: 0.37463186162846185d), new NpgsqlTypes.NpgsqlPoint(x: 0.38828644023516845d, y: 0.1730534558327982d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495307104864157d, y: 0.3187914106690388d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8262287693422693d, y: 0.9201260430269033d), new NpgsqlTypes.NpgsqlPoint(x: 0.7259021786949746d, y: 0.3140188990114269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9130613171459802d, y: 0.06896450298618217d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33802309303197d, y: 0.3016754117004703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7150757726716738d, y: 0.6842402859949058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490954435853645d, y: 0.6070991751430052d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8964408557253626d, y: 0.253435415562105d), new NpgsqlTypes.NpgsqlPoint(x: 0.07521599363346099d, y: 0.2828544566707064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633182786950886d, y: 0.9979754723683933d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4726925699306448d, y: 0.387769523568788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085791692101548d, y: 0.25501122521633524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384493080488385d, y: 0.0002009739754273987d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8416028113254626d, y: 0.8478417881538548d), new NpgsqlTypes.NpgsqlPoint(x: 0.23635562353204642d, y: 0.7857978078317109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015907760953023d, y: 0.19684280085970762d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((102)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9326411299717269d, y: 0.2021761053977369d), new NpgsqlTypes.NpgsqlPoint(x: 0.0488991450013192d, y: 0.6254282898139787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765972880551218d, y: 0.14558915372532832d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38804349281903316d, y: 0.2843114595739398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5982613249897545d, y: 0.4511161161766195d), new NpgsqlTypes.NpgsqlPoint(x: 0.6009869723686113d, y: 0.823756756178562d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8875150605618756d, y: 0.7321953105669373d), new NpgsqlTypes.NpgsqlPoint(x: 0.47437610111475315d, y: 0.2706674146641378d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702762100776536d, y: 0.7402539388356006d)))));//Value

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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23411111075457058d, y: 0.6741456006252893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7155377221211209d, y: 0.1978829460498579d), new NpgsqlTypes.NpgsqlPoint(x: 0.8687799790441922d, y: 0.1681922642066842d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39238895905420046d, y: 0.9252620957789968d), new NpgsqlTypes.NpgsqlPoint(x: 0.577233749178644d, y: 0.12186273193503139d), new NpgsqlTypes.NpgsqlPoint(x: 0.0942389046489508d, y: 0.21013122250162775d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3667575770316015d, y: 0.9494864699844224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585224022460992d, y: 0.25728653263200696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7951888426756519d, y: 0.3623352345812729d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8845569840952077d, y: 0.7374206889990265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825422821196647d, y: 0.3745962688777392d), new NpgsqlTypes.NpgsqlPoint(x: 0.028374588878853135d, y: 0.033902479686500064d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05787646996160012d, y: 0.7466151569272369d), new NpgsqlTypes.NpgsqlPoint(x: 0.29026342657089466d, y: 0.7281856272128249d), new NpgsqlTypes.NpgsqlPoint(x: 0.4985363232602126d, y: 0.8568743749581652d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9569695848855049d, y: 0.6276360413682688d), new NpgsqlTypes.NpgsqlPoint(x: 0.09052468046685946d, y: 0.004626645276924357d), new NpgsqlTypes.NpgsqlPoint(x: 0.1633188508082113d, y: 0.6973730000544462d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0031691819116164144d, y: 0.13694383919733144d), new NpgsqlTypes.NpgsqlPoint(x: 0.969411525741198d, y: 0.2857136794707974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452380190690905d, y: 0.44239841703984917d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8340353460619139d, y: 0.7893922231878656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530199158052728d, y: 0.6329696086374628d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004326651478071d, y: 0.14949543959444123d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12188406562839227d, y: 0.52652402668781d), new NpgsqlTypes.NpgsqlPoint(x: 0.6540588487248322d, y: 0.7729450437857835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5892745887071337d, y: 0.5282771255021443d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5162390259308067d, y: 0.6876006440285846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465153536801403d, y: 0.39745728144409187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201266886908468d, y: 0.2020176943816936d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7315597219505922d, y: 0.5871488391213036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590306062722807d, y: 0.6111151274832942d), new NpgsqlTypes.NpgsqlPoint(x: 0.21739201366432814d, y: 0.44195822447402866d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3518953859339967d, y: 0.6318914920513071d), new NpgsqlTypes.NpgsqlPoint(x: 0.20395506233356353d, y: 0.37548380643822854d), new NpgsqlTypes.NpgsqlPoint(x: 0.38365649111539424d, y: 0.44289275865101885d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06327737184764148d, y: 0.7461338139471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027601716684828d, y: 0.8219407088846334d), new NpgsqlTypes.NpgsqlPoint(x: 0.10017660227525649d, y: 0.928676794689073d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3838747528908617d, y: 0.5476489213224125d), new NpgsqlTypes.NpgsqlPoint(x: 0.218969298347085d, y: 0.6790788561861199d), new NpgsqlTypes.NpgsqlPoint(x: 0.3499927923560153d, y: 0.19434672852727386d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25531755659757194d, y: 0.9829656941805861d), new NpgsqlTypes.NpgsqlPoint(x: 0.32467569509046534d, y: 0.8304545806890953d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227046702400304d, y: 0.20825033431985174d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2698511461664257d, y: 0.06333288111540303d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906750967803224d, y: 0.8879009396320555d), new NpgsqlTypes.NpgsqlPoint(x: 0.675865547876203d, y: 0.3801494671355492d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.554773791411561d, y: 0.10436504470139685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483923151616683d, y: 0.818884590528801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765719320863251d, y: 0.2269963142102871d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31823984699598173d, y: 0.4354960201338043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612321098526083d, y: 0.9265251619306936d), new NpgsqlTypes.NpgsqlPoint(x: 0.46126320721592584d, y: 0.5225685372546018d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4689033151737356d, y: 0.1950232114018824d), new NpgsqlTypes.NpgsqlPoint(x: 0.4311952427981486d, y: 0.5166131202936818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844273652623014d, y: 0.790365566598528d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6486472212841207d, y: 0.6092097561087672d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240044202534379d, y: 0.9297749462081278d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071486406499177d, y: 0.11521607183422722d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17267410305561293d, y: 0.4885535096808118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581877361631269d, y: 0.4942666176317997d), new NpgsqlTypes.NpgsqlPoint(x: 0.23378916089175739d, y: 0.7148693071177952d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9624797915820896d, y: 0.06141896968414706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831010058379074d, y: 0.08675355815811825d), new NpgsqlTypes.NpgsqlPoint(x: 0.03433111186196547d, y: 0.04668405539952514d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6398206751114421d, y: 0.4703940160334631d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653563272776835d, y: 0.4830019831002612d), new NpgsqlTypes.NpgsqlPoint(x: 0.46203119158705974d, y: 0.3338146080023231d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9379366018770214d, y: 0.6417356789681155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039854350645343d, y: 0.3425913416053866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470275594708302d, y: 0.7558729229530491d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5037344640282818d, y: 0.42821941737619884d), new NpgsqlTypes.NpgsqlPoint(x: 0.13635720050427447d, y: 0.6960785373616614d), new NpgsqlTypes.NpgsqlPoint(x: 0.402732161695181d, y: 0.3522547302884954d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14608951785968272d, y: 0.18973940366267916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848753032618587d, y: 0.2326134846854403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879569198430939d, y: 0.9056552252956948d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5441479324581817d, y: 0.2067166450033162d), new NpgsqlTypes.NpgsqlPoint(x: 0.6532473502339251d, y: 0.7908048209323312d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552446268956675d, y: 0.37284393432799723d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42952172802039634d, y: 0.6286126496055302d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328446307567129d, y: 0.8635150913025533d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342258204857049d, y: 0.5686681822434589d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6196678501653196d, y: 0.6628662545220936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835330046459051d, y: 0.7403927499482826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9684922464777037d, y: 0.35945676447434516d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8920685610708559d, y: 0.3945269005040898d), new NpgsqlTypes.NpgsqlPoint(x: 0.38933947209602593d, y: 0.11836275875785729d), new NpgsqlTypes.NpgsqlPoint(x: 0.22048752265691185d, y: 0.012446331656817966d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8298274378570688d, y: 0.6149322153572718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4408500504617473d, y: 0.4002310669704854d), new NpgsqlTypes.NpgsqlPoint(x: 0.3375511718711718d, y: 0.7157758484238996d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8369476728947186d, y: 0.6411875841373789d), new NpgsqlTypes.NpgsqlPoint(x: 0.31566661950470265d, y: 0.6286642527451233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3094436611564484d, y: 0.4249943142371272d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44036438945327283d, y: 0.39469157211729544d), new NpgsqlTypes.NpgsqlPoint(x: 0.3800695524389264d, y: 0.8288672504478939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2854650682473642d, y: 0.04016209200891774d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29138709256356565d, y: 0.6953574980603177d), new NpgsqlTypes.NpgsqlPoint(x: 0.7224907004576576d, y: 0.06540898133061179d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696579725880097d, y: 0.2350139744734544d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9713555062870469d, y: 0.3844963707236443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8735989067240322d, y: 0.12973988566019456d), new NpgsqlTypes.NpgsqlPoint(x: 0.08379685441206086d, y: 0.19377824362952722d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7221081827947765d, y: 0.5372264169282949d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346478085322912d, y: 0.7027938022094664d), new NpgsqlTypes.NpgsqlPoint(x: 0.47868467012030635d, y: 0.051678191212232494d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028902813879190248d, y: 0.38993989224138326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8577766146383168d, y: 0.9080048188407728d), new NpgsqlTypes.NpgsqlPoint(x: 0.20943048718215074d, y: 0.8283365999396356d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5472911640408559d, y: 0.8339556738401764d), new NpgsqlTypes.NpgsqlPoint(x: 0.28371635232400105d, y: 0.8435053161511283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070406104306012d, y: 0.8517276829676447d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17753715040170193d, y: 0.8692823861595537d), new NpgsqlTypes.NpgsqlPoint(x: 0.32696438710537035d, y: 0.594988083199962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4837121524226242d, y: 0.7161700294557632d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5876405635564423d, y: 0.3768592292969759d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217098338227284d, y: 0.08966167625962251d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848344387377469d, y: 0.46709321704252593d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6929523415152592d, y: 0.9035257058801237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7745297272813815d, y: 0.24343621637116497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5844729740178567d, y: 0.12040319031002478d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7456657641866278d, y: 0.8095503281090632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249483709963268d, y: 0.6713270767150857d), new NpgsqlTypes.NpgsqlPoint(x: 0.02278785645549597d, y: 0.7853081700843294d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5453098153305627d, y: 0.5141581421565975d), new NpgsqlTypes.NpgsqlPoint(x: 0.2077664528868607d, y: 0.22458472497930682d), new NpgsqlTypes.NpgsqlPoint(x: 0.6052018540292802d, y: 0.5602116336487933d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07980731536981012d, y: 0.8182465332510648d), new NpgsqlTypes.NpgsqlPoint(x: 0.06729524261788733d, y: 0.09730859601519048d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285011707118777d, y: 0.751169320846629d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29141607143259207d, y: 0.2556755542205499d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627091828523733d, y: 0.13656583850645343d), new NpgsqlTypes.NpgsqlPoint(x: 0.046289434728087886d, y: 0.388725945024861d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3114948874291369d, y: 0.27702119174573936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879634937833779d, y: 0.5249798246744971d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837743316447485d, y: 0.484865471759131d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1956506347041861d, y: 0.0857056577363634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2765987163389363d, y: 0.6473397033747027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699490583117431d, y: 0.9182433056578573d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8425607604521119d, y: 0.05441014276099554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810486559230077d, y: 0.8876803675252541d), new NpgsqlTypes.NpgsqlPoint(x: 0.878391243594643d, y: 0.2373905498961928d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944510164598244d, y: 0.500437345177661d), new NpgsqlTypes.NpgsqlPoint(x: 0.996107391164437d, y: 0.7205275077970869d), new NpgsqlTypes.NpgsqlPoint(x: 0.38873805524230476d, y: 0.11142318388177885d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1414852968632061d, y: 0.3845949978632749d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927316191615426d, y: 0.19820052232787677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376245118788446d, y: 0.09167998927879506d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004535573403795068d, y: 0.2305236026460863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4928060365701755d, y: 0.8613752793444005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9338083311548583d, y: 0.6886500475847225d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07780037936395867d, y: 0.42893106264414793d), new NpgsqlTypes.NpgsqlPoint(x: 0.1664088591802073d, y: 0.23911303263883577d), new NpgsqlTypes.NpgsqlPoint(x: 0.3648400118993116d, y: 0.8732194086607057d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7336430430627808d, y: 0.05373579680647245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5526050838771495d, y: 0.5272372662644871d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765878011669141d, y: 0.39433075829179165d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9615072768668582d, y: 0.1942031196818903d), new NpgsqlTypes.NpgsqlPoint(x: 0.975715281657575d, y: 0.6609076292332876d), new NpgsqlTypes.NpgsqlPoint(x: 0.091169655562644d, y: 0.07209428743385216d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8116584568778904d, y: 0.9578934760237013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455976023617336d, y: 0.3364229695955604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776080377829234d, y: 0.3312010665901034d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41525236969655477d, y: 0.950224556257303d), new NpgsqlTypes.NpgsqlPoint(x: 0.7117350286725059d, y: 0.4177821841700827d), new NpgsqlTypes.NpgsqlPoint(x: 0.15189422170343247d, y: 0.2652171013588618d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9159703478105677d, y: 0.7740349170814201d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761177650443286d, y: 0.15524081492826058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098522600060361d, y: 0.19972225674183064d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7355211577742128d, y: 0.8973296246212777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459150546260913d, y: 0.002108640697466191d), new NpgsqlTypes.NpgsqlPoint(x: 0.23174467771407326d, y: 0.4509388772531293d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32800914246500834d, y: 0.249245186889687d), new NpgsqlTypes.NpgsqlPoint(x: 0.0640264294201619d, y: 0.8898315167223375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324018937383117d, y: 0.20203443476431338d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2529626228039885d, y: 0.24041686021185793d), new NpgsqlTypes.NpgsqlPoint(x: 0.35751829857652806d, y: 0.5651053938554559d), new NpgsqlTypes.NpgsqlPoint(x: 0.1868323159911065d, y: 0.7649143303831795d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15769828303254252d, y: 0.8339316223530522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9677896344596254d, y: 0.7293221964664388d), new NpgsqlTypes.NpgsqlPoint(x: 0.519201757941975d, y: 0.41616348044804363d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5785719610092729d, y: 0.3443114375325367d), new NpgsqlTypes.NpgsqlPoint(x: 0.20702133508080722d, y: 0.042884046435619494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443240697395798d, y: 0.6668944715086476d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48899911739264257d, y: 0.8514008976229174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156516936821151d, y: 0.37564581656582086d), new NpgsqlTypes.NpgsqlPoint(x: 0.727167307977827d, y: 0.8781693152405762d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.533199260369435d, y: 0.8234017466893057d), new NpgsqlTypes.NpgsqlPoint(x: 0.991255163023308d, y: 0.380805521384868d), new NpgsqlTypes.NpgsqlPoint(x: 0.10963919465997585d, y: 0.33564472798351475d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11254651353038103d, y: 0.6001297529472829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4584464041174393d, y: 0.7997316888901541d), new NpgsqlTypes.NpgsqlPoint(x: 0.06016355465651657d, y: 0.6429015899426028d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7270275544156307d, y: 0.8410102593131112d), new NpgsqlTypes.NpgsqlPoint(x: 0.22016643937329983d, y: 0.95861897901964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4715307275617051d, y: 0.03082611595148743d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07065859413889286d, y: 0.37463186162846185d), new NpgsqlTypes.NpgsqlPoint(x: 0.38828644023516845d, y: 0.1730534558327982d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495307104864157d, y: 0.3187914106690388d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8262287693422693d, y: 0.9201260430269033d), new NpgsqlTypes.NpgsqlPoint(x: 0.7259021786949746d, y: 0.3140188990114269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9130613171459802d, y: 0.06896450298618217d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33802309303197d, y: 0.3016754117004703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7150757726716738d, y: 0.6842402859949058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490954435853645d, y: 0.6070991751430052d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8964408557253626d, y: 0.253435415562105d), new NpgsqlTypes.NpgsqlPoint(x: 0.07521599363346099d, y: 0.2828544566707064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633182786950886d, y: 0.9979754723683933d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4726925699306448d, y: 0.387769523568788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085791692101548d, y: 0.25501122521633524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384493080488385d, y: 0.0002009739754273987d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8416028113254626d, y: 0.8478417881538548d), new NpgsqlTypes.NpgsqlPoint(x: 0.23635562353204642d, y: 0.7857978078317109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015907760953023d, y: 0.19684280085970762d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((102)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9326411299717269d, y: 0.2021761053977369d), new NpgsqlTypes.NpgsqlPoint(x: 0.0488991450013192d, y: 0.6254282898139787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765972880551218d, y: 0.14558915372532832d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38804349281903316d, y: 0.2843114595739398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5982613249897545d, y: 0.4511161161766195d), new NpgsqlTypes.NpgsqlPoint(x: 0.6009869723686113d, y: 0.823756756178562d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8875150605618756d, y: 0.7321953105669373d), new NpgsqlTypes.NpgsqlPoint(x: 0.47437610111475315d, y: 0.2706674146641378d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702762100776536d, y: 0.7402539388356006d)))));//Value

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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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

