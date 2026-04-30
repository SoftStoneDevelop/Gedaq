

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
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5521181905275673d, y: 0.7770683585806953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5736859468876658d, y: 0.3499868344771627d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8549915729252382d, y: 0.05126153475181772d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.053008999330408146d, y: 0.03428975575986559d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5684846265341341d, y: 0.5747161223145598d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7040762851625616d, y: 0.3822349145861116d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5067809484652002d, y: 0.8552854565593796d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6212869128673221d, y: 0.4198189873991014d),
new NpgsqlTypes.NpgsqlPoint(x: 0.026558906256054615d, y: 0.8195798141092463d),
new NpgsqlTypes.NpgsqlPoint(x: 0.025335928113629058d, y: 0.27365859422449723d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4534187966640074d, y: 0.19844599406475916d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14870108902694668d, y: 0.249035944785432d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3296117744916818d, y: 0.9074879132928584d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09373847085070397d, y: 0.6631173218181087d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7407129748992175d, y: 0.9168651937288712d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43248850998592425d, y: 0.333403674970409d),
new NpgsqlTypes.NpgsqlPoint(x: 0.600106993503654d, y: 0.44296484704284456d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38685695737691395d, y: 0.9562706286992427d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8383959389058222d, y: 0.6450664543032496d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18982015944800135d, y: 0.9465301101960395d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3420907089769619d, y: 0.8754543087751593d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10465805119208416d, y: 0.9885937429994425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.911266068941247d, y: 0.7375603736221904d),
new NpgsqlTypes.NpgsqlPoint(x: 0.614576810686205d, y: 0.8465806879498143d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23452045448234737d, y: 0.49624390409289043d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47005271654534786d, y: 0.29297241870038715d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32325175729025724d, y: 0.8953658667548177d),
new NpgsqlTypes.NpgsqlPoint(x: 0.011219247706338975d, y: 0.47781730651237997d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9049868855036344d, y: 0.7606491759816261d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7164016023121618d, y: 0.8398044286442651d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6485195839461562d, y: 0.66911575519001d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6267456253697143d, y: 0.5062976725206056d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5166055612689117d, y: 0.37657403848523785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4570567040866902d, y: 0.17397933777340946d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9908418320555217d, y: 0.8417228023495668d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3780177798818518d, y: 0.8596669557631716d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48085770702129005d, y: 0.21915479909387303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4147318634262718d, y: 0.21716490333712724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7294085439195238d, y: 0.5394386586870967d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5771073060369696d, y: 0.10641962306522579d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6328084858111033d, y: 0.7550069464808807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07567398417472071d, y: 0.43034283649814953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6814232148338417d, y: 0.661058162618907d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1279551446369026d, y: 0.6110155384183151d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02857826305093769d, y: 0.6109844583486435d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2973826477036453d, y: 0.8084442517620825d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7719827431653075d, y: 0.35374062734402223d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9960656613345533d, y: 0.6806106857160018d),
new NpgsqlTypes.NpgsqlPoint(x: 0.434243344900626d, y: 0.4783694278235012d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6954538084018258d, y: 0.7545473981748319d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17206338199923243d, y: 0.7534314553958702d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7456974075849677d, y: 0.04724779732485296d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09883790820723948d, y: 0.2631246082405774d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8306057437817632d, y: 0.5565455869378524d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5642079225568613d, y: 0.8902607373734227d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6848635599410589d, y: 0.9284572690101665d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7208922508629695d, y: 0.2966767499563061d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6724384971790375d, y: 0.4099069986395576d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2942277762553426d, y: 0.8072254854454051d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7027600397491921d, y: 0.25154250188286664d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6303234900787998d, y: 0.37861518343346257d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7280769227304158d, y: 0.7298739356026257d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3304094195729509d, y: 0.617977157106606d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09719564305529393d, y: 0.5766841592941753d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49340076160367896d, y: 0.296240148787993d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7759713304498649d, y: 0.9741373032407223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8037549633448575d, y: 0.3823242736572182d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7257338752218974d, y: 0.4264374904037401d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3893817446908555d, y: 0.9360145172057706d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5722233175415729d, y: 0.8088834123963538d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9212846118320867d, y: 0.7735184147912973d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1025617338246636d, y: 0.4309764618495113d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10228276902980504d, y: 0.5342157896557315d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5935448657772953d, y: 0.32249981067941114d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5415462148709295d, y: 0.3528163268214731d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4891079226997709d, y: 0.5265943540325383d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2876487523264991d, y: 0.787658740378616d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09711213919411421d, y: 0.4230569551393021d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7296573240203612d, y: 0.5982786311631695d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5125887155798149d, y: 0.5183421384805014d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7596322516660898d, y: 0.7705660943747819d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17483625368604905d, y: 0.1497192759599978d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.017724594626954415d, y: 0.7385049770560846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.798054267960237d, y: 0.5345307063021086d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7646301060392208d, y: 0.007641639165955394d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5079300501404481d, y: 0.12464035303519494d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5874490796663442d, y: 0.6133964646428627d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03454055216310814d, y: 0.9551498381309804d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8509954063690894d, y: 0.25870440376930803d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13241608067447674d, y: 0.29626169286904214d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2921295736127426d, y: 0.5941623955569258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18526900944722224d, y: 0.9796424151563758d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6302264124447761d, y: 0.0389700322946156d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8230885074186577d, y: 0.9266484276077641d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2635728903565685d, y: 0.9221683044807814d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8594164009355538d, y: 0.5830530871516751d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.790506923501334d, y: 0.6150400124914754d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1826598757481679d, y: 0.015018251568772789d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2555938175844409d, y: 0.45580323398435496d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24314694922126812d, y: 0.10993714078648564d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30521719309889217d, y: 0.6751609421301369d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6820612236255621d, y: 0.7950388961482852d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5958602354741283d, y: 0.16231538908534948d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19017027132661068d, y: 0.8346271023322024d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5661758218863381d, y: 0.39428999178903446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6876111346075137d, y: 0.6128442712556325d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5180374456619457d, y: 0.8780348007228966d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3411429685954884d, y: 0.10424585713086831d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8992083214697902d, y: 0.24648940983627454d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7846492041608379d, y: 0.2939927935962673d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2380883552630899d, y: 0.034062452758712114d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4625383624929621d, y: 0.08937365096225258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0859018821246399d, y: 0.102719733575667d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23815129391328194d, y: 0.5950579465148202d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12903922577937543d, y: 0.9550175645828044d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4448165815866094d, y: 0.45824304579140773d),
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
new NpgsqlTypes.NpgsqlPoint(x: 0.5595560548419909d, y: 0.9178194235436833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6864031282042671d, y: 0.8438101249838376d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44690871447972225d, y: 0.5059797965675074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.93172450497747d, y: 0.7472042781211192d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3182486186915846d, y: 0.2995479914546325d),
new NpgsqlTypes.NpgsqlPoint(x: 0.482969797924511d, y: 0.3413553958050445d),
new NpgsqlTypes.NpgsqlPoint(x: 0.830426141734885d, y: 0.2871662827199759d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02509519084593448d, y: 0.8535986791432397d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35542417342858745d, y: 0.888326284026587d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6762980598151905d, y: 0.8796134980234646d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47245126272062943d, y: 0.992260793032234d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22140234309231877d, y: 0.7085794452606468d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13954446077159344d, y: 0.928433048552486d),
new NpgsqlTypes.NpgsqlPoint(x: 0.894146618352283d, y: 0.02080924264038675d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8413954212494308d, y: 0.570578955125569d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0870116621828273d, y: 0.9190649879169394d),
new NpgsqlTypes.NpgsqlPoint(x: 0.654295944234605d, y: 0.2441808927808461d),
new NpgsqlTypes.NpgsqlPoint(x: 0.042524181016093676d, y: 0.7408491999921182d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7223634242839937d, y: 0.6456383996401733d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4580625041181752d, y: 0.8568767778745129d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43076164655899585d, y: 0.022415927090194354d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6535661949356032d, y: 0.839720101411177d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3838856961203412d, y: 0.3648084572073035d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7320087095286072d, y: 0.7720195558204658d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40896196217315406d, y: 0.7404464607596027d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8777761855578009d, y: 0.2824635306639016d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6522223376324484d, y: 0.043788128784040814d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9455936405641767d, y: 0.7935685901763301d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14986163392956708d, y: 0.00508376247857345d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34868961301384716d, y: 0.906479101706282d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4842698878002094d, y: 0.4688668532513237d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18955744107795325d, y: 0.7358651793937327d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37531575661201155d, y: 0.3452379043568219d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25828753937510507d, y: 0.1076231417452953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03385064268425675d, y: 0.9999644228895375d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3132362878344701d, y: 0.23767663404115524d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7080260849274184d, y: 0.23406634567901985d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34645379088404193d, y: 0.6837638812146096d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2722700665709259d, y: 0.3073143644580787d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7597952056564233d, y: 0.7654478572895718d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8419046179423093d, y: 0.7182734316573838d),
new NpgsqlTypes.NpgsqlPoint(x: 0.054327487734127544d, y: 0.7121808013229192d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49509915943368044d, y: 0.720143812216005d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31613233797921336d, y: 0.7428934116407906d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36293444218189974d, y: 0.35802687184703474d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23141678300131063d, y: 0.633736870872753d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29232330809883333d, y: 0.814843084596158d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7586479758446447d, y: 0.9533612140631941d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2701379388809566d, y: 0.03368364271356783d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5040355731433904d, y: 0.698524674924895d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6507814071600099d, y: 0.6141871085705702d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22520060082557058d, y: 0.7258408025952313d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2841485473178835d, y: 0.9959876818860119d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5262433293105734d, y: 0.9270246159666575d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8474061774927206d, y: 0.47032897850609534d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18831835134750896d, y: 0.039411501601368526d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8817869204287645d, y: 0.04323946275695434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.031101668602149357d, y: 0.11381688683781899d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24375658841868308d, y: 0.8771359999687799d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3344453848533384d, y: 0.8053378764003147d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6248768622885028d, y: 0.516412489389778d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3418158914015482d, y: 0.09910799387204161d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.029003482221182875d, y: 0.6038341406802109d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30670303184432623d, y: 0.05609564584048454d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0024627375061301304d, y: 0.9662604171069629d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7888906926433583d, y: 0.5537554482863694d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9815925861470781d, y: 0.09928903396837518d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5795786615366199d, y: 0.09800423722554874d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5899780289639056d, y: 0.8060546756465329d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9766995812535867d, y: 0.5406755143150676d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9906780075102579d, y: 0.7461612883794874d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7351808105231056d, y: 0.25953542316135836d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7937426115389161d, y: 0.27895611877894844d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12567870013286309d, y: 0.16353299988413428d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3631932227161374d, y: 0.3534410639301806d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6379979653632147d, y: 0.23907455787988618d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.778549896150797d, y: 0.729360863600668d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3771435804438824d, y: 0.2520167795312087d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09515614528852279d, y: 0.2873320408873197d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05206940502635915d, y: 0.7651917817712507d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4346339173333187d, y: 0.9616199424019019d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6424887461772566d, y: 0.32705887223801533d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5995668314255239d, y: 0.010762390782367515d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3595377701506467d, y: 0.3603387737436421d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6935497560436947d, y: 0.8063201090293328d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44660600220683044d, y: 0.3775884260668698d),
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
new NpgsqlTypes.NpgsqlPoint(x: 0.8677644311505636d, y: 0.7568072683717519d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9343151365975252d, y: 0.36076960181956286d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6589794979548168d, y: 0.10759553338756644d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9398452802402442d, y: 0.3308666798927403d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1638381447548074d, y: 0.02174695392482706d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4775792604706842d, y: 0.4381707645290729d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5729766530448378d, y: 0.13985881695231983d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0863663884055138d, y: 0.6133723771504129d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3697439422893123d, y: 0.02634507816116438d),
new NpgsqlTypes.NpgsqlPoint(x: 0.054500934963194414d, y: 0.0034144688200440365d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5172439136416741d, y: 0.8623167743713787d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6387622544786542d, y: 0.8375746581431508d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09312534830893027d, y: 0.7119679818302818d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6657028734246677d, y: 0.6289058817622429d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48912301076180564d, y: 0.5425908029838378d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6701370653827191d, y: 0.537772004366327d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9446414900777308d, y: 0.055239379129819355d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6316018506538144d, y: 0.05794277724021901d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1668451774502967d, y: 0.6094152573325096d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22634487432506456d, y: 0.4058691642931911d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11448229714766522d, y: 0.16581350707818876d),
new NpgsqlTypes.NpgsqlPoint(x: 0.874199474231325d, y: 0.8704105409384674d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6042610245870191d, y: 0.17990380543629658d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13020214655377071d, y: 0.08416284781343442d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3738563691805362d, y: 0.8287393809935253d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32925200416622524d, y: 0.46200070120774517d),
},
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
new NpgsqlTypes.NpgsqlPoint(x: 0.48085770702129005d, y: 0.21915479909387303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4147318634262718d, y: 0.21716490333712724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7294085439195238d, y: 0.5394386586870967d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5771073060369696d, y: 0.10641962306522579d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6848635599410589d, y: 0.9284572690101665d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7208922508629695d, y: 0.2966767499563061d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6724384971790375d, y: 0.4099069986395576d),
}));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5125887155798149d, y: 0.5183421384805014d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7596322516660898d, y: 0.7705660943747819d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17483625368604905d, y: 0.1497192759599978d),
}));
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
                Assert.That(nullable, Is.Null);
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 54;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 54;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 43, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 104, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 70, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 67, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 70, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 146, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 93, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 82, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
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
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(NpgsqlPointpointArray1MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPointpointArray1M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPointArraypointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
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

