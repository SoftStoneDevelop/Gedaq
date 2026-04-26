

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9519339591168117d, y: 0.2763163211969676d), radius: 0.11529189515704874d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7215039198842637d, y: 0.08272082202629538d), radius: 0.2116468042238867d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4649848028121557d, y: 0.369797411000926d), radius: 0.2981590760945395d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2388960688992937d, y: 0.07482757491132064d), radius: 0.11960195810457086d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2898570426524387d, y: 0.02622669892405305d), radius: 0.6152688599540709d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9552676802623153d, y: 0.7119475373556533d), radius: 0.8698397454822049d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7075343103369007d, y: 0.695085821818349d), radius: 0.0770483390293919d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748452096861705d, y: 0.9333216586808881d), radius: 0.05848291073414902d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0686546487469778d, y: 0.405271853353376d), radius: 0.6351687250759398d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15473923091314468d, y: 0.7008726363918215d), radius: 0.349367465253169d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6202472038544656d, y: 0.5579829208806247d), radius: 0.12971867249369862d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48243709207346896d, y: 0.7932319041927844d), radius: 0.6690499594871862d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5220937438536355d, y: 0.5416397361433319d), radius: 0.937618962472083d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9864523612114278d, y: 0.8683590022487845d), radius: 0.9169609916739678d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7927599949701173d, y: 0.19687108664575093d), radius: 0.10757497726144227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08723839749014706d, y: 0.22096862245972404d), radius: 0.2803425731984982d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4607505081078841d, y: 0.3607214318293628d), radius: 0.9759328864082266d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3116703161730725d, y: 0.8181995836234616d), radius: 0.2692644196267029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.882238464789862d, y: 0.5978142011361925d), radius: 0.8320053581111552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9157121262890743d, y: 0.1526455879219405d), radius: 0.7126596890260739d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0673392169435395d, y: 0.29750940499223366d), radius: 0.8521395718795154d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.767930643396271d, y: 0.35293233883637676d), radius: 0.6696099560907042d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9675987804287993d, y: 0.9047513344275788d), radius: 0.04916694777763109d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2560587665827767d, y: 0.6816537917488376d), radius: 0.3785690215007492d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3881192172742244d, y: 0.8015650206151655d), radius: 0.06878030254172685d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41559186105641954d, y: 0.2887494889719765d), radius: 0.9247351740419147d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6643592120907942d, y: 0.15041389154714346d), radius: 0.7235107904893386d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9817981146374105d, y: 0.3198291058783703d), radius: 0.2349119499019141d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39325362599483393d, y: 0.11810145521809323d), radius: 0.16807691061655372d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4315737107809773d, y: 0.9825131472021963d), radius: 0.07371662732161521d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7453018159835368d, y: 0.03989250061306737d), radius: 0.8333941364390767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3061687189462766d, y: 0.3626060333943907d), radius: 0.029135052602382028d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9378609387514669d, y: 0.6900430606125626d), radius: 0.38979037542025496d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7407019652721383d, y: 0.875057153045456d), radius: 0.09394491486362455d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923638538528808d, y: 0.9648153188231676d), radius: 0.7527536606768853d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05559022338959463d, y: 0.3913763333363809d), radius: 0.6196649851177174d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3391429141241106d, y: 0.683363358358893d), radius: 0.9180177710843632d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15057867504340272d, y: 0.21540189350541994d), radius: 0.17120771162059711d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9404582961296313d, y: 0.8665711975793989d), radius: 0.17426504540057008d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9908687565581626d, y: 0.2222948196172324d), radius: 0.8882039747157983d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4623849264297186d, y: 0.009991750394879761d), radius: 0.37419966599874077d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.779732893815277d, y: 0.5702758234801901d), radius: 0.9632051207004951d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8241978564434097d, y: 0.31165047167380144d), radius: 0.17724586470477832d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4053188905997789d, y: 0.8922740128970654d), radius: 0.5379711792223464d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3975291958677427d, y: 0.661679879266959d), radius: 0.383845839080993d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0010584042992621834d, y: 0.21331439489117432d), radius: 0.6524146128638804d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8346835082771729d, y: 0.7862173387433343d), radius: 0.8487336547205536d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9489611342425545d, y: 0.6411135466838238d), radius: 0.17160977767283547d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5133516507103574d, y: 0.5870300227862437d), radius: 0.47980564482992893d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36893886187079605d, y: 0.9173468173183675d), radius: 0.3567118924660121d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4821416134878572d, y: 0.22938019452566993d), radius: 0.8980951888217271d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9095287882693359d, y: 0.3930686180082479d), radius: 0.8255618533915325d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18698558001158205d, y: 0.6465998958680834d), radius: 0.12771457787824458d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4033923074468787d, y: 0.7731652299348292d), radius: 0.3782958542943653d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29979119889041406d, y: 0.9347156497055248d), radius: 0.4903587755446287d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.372371810369568d, y: 0.791732798099651d), radius: 0.12806578184743878d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08852482938915285d, y: 0.5607623517631901d), radius: 0.8393993162594534d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5638410592690389d, y: 0.17833358215350337d), radius: 0.15260172656916016d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7066337924924029d, y: 0.7117651852995499d), radius: 0.42738297316873d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8497821583897458d, y: 0.49364487541398105d), radius: 0.6095755899123686d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4382723305324432d, y: 0.1779872031575097d), radius: 0.7636417987441104d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5427182417610211d, y: 0.9095458889205206d), radius: 0.6335268805358452d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46986760859571086d, y: 0.35843462001087445d), radius: 0.12061086047412795d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7505019572098304d, y: 0.8094176334986404d), radius: 0.6127886240056502d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3304000782715998d, y: 0.9897949406710616d), radius: 0.3431672005734735d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3745168555518361d, y: 0.3790719941417433d), radius: 0.8783954910637343d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3788424190541061d, y: 0.8263446366209998d), radius: 0.013986732292531223d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8565175329277649d, y: 0.9432157040832552d), radius: 0.293959087958623d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08048244436825147d, y: 0.5035767540721401d), radius: 0.8373140651653599d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6410820612127045d, y: 0.8879866642820953d), radius: 0.3559888889388908d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0768402170262713d, y: 0.9806601784461006d), radius: 0.2081466811102306d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6812275777999138d, y: 0.47939452112611547d), radius: 0.14910556169683042d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8909401505103436d, y: 0.27759027365352085d), radius: 0.6064068037335509d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9170354585211185d, y: 0.029370460016675204d), radius: 0.20939535967760103d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43047452376590734d, y: 0.8603963202540413d), radius: 0.9524004313652101d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.493815361420885d, y: 0.626107930220296d), radius: 0.5009375002636749d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.753188191718227d, y: 0.5842403933662347d), radius: 0.8584105851487506d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3095822618739029d, y: 0.20114062592129622d), radius: 0.8274539585851911d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6041198415137617d, y: 0.16756041247454734d), radius: 0.14681944109803302d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4742924852530066d, y: 0.35700540451763874d), radius: 0.2693553268656892d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7064919890377886d, y: 0.01022069075273313d), radius: 0.9362611042900792d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07289253706032373d, y: 0.23287373656295873d), radius: 0.13824148606408326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21376853620861536d, y: 0.06451377773505029d), radius: 0.5879532400888529d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7762971217390512d, y: 0.12840772057248728d), radius: 0.18578093525243833d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11425976448077768d, y: 0.43380698493824443d), radius: 0.15062206190916494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9219913072440212d, y: 0.6107084353208664d), radius: 0.5418490895586849d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34465087072493916d, y: 0.6051514180430763d), radius: 0.4334799409645359d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9989805808364045d, y: 0.5993043533078459d), radius: 0.42867856058344833d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7819185283847301d, y: 0.19615663492553392d), radius: 0.7048537529932778d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5366093929520237d, y: 0.06409886490769046d), radius: 0.6091388270459345d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9659771045420217d, y: 0.749947256480522d), radius: 0.33048422440520175d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4010033961311178d, y: 0.9351141000031662d), radius: 0.946438692338773d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21282622685467822d, y: 0.15123098515913647d), radius: 0.799065284730493d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.96829859774941d, y: 0.6110245685303777d), radius: 0.5251165410137338d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9896004169196159d, y: 0.7345791124193043d), radius: 0.5916700224952728d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.541942850707373d, y: 0.1936921711121129d), radius: 0.37554660933502515d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37741894057308045d, y: 0.04806246240552303d), radius: 0.018083904072261903d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.949384899517147d, y: 0.7047746938767049d), radius: 0.2761606684587202d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8385439661656704d, y: 0.6936866920111171d), radius: 0.9516171651599679d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4456677036926868d, y: 0.5887045763591625d), radius: 0.4347618841987322d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09853577816367676d, y: 0.1625269505734095d), radius: 0.02948368948380309d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013935663014955746d, y: 0.7684498762534568d), radius: 0.1994894558253154d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6262173828812807d, y: 0.3393653179365207d), radius: 0.8715694814316066d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46399381197893297d, y: 0.8247872640420865d), radius: 0.6429352397689576d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6969420238902881d, y: 0.13418481694977646d), radius: 0.5687430461431412d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3324545177036805d, y: 0.3503098289627422d), radius: 0.9178212830723098d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5030786066118744d, y: 0.08259184451282664d), radius: 0.16137157135706748d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7633956783015342d, y: 0.7202674742060075d), radius: 0.0658392540449999d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632423030806909d, y: 0.470125346000419d), radius: 0.40233013617534574d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19463327573900435d, y: 0.5693471093723722d), radius: 0.8320347385226153d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20314870746696723d, y: 0.7496550171353165d), radius: 0.8723560242691537d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19281537974543517d, y: 0.03984351049149126d), radius: 0.46541104032943437d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7105213174078908d, y: 0.005183149197013459d), radius: 0.8000470093453788d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6006725115840724d, y: 0.6932244685218544d), radius: 0.9915503134302616d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9342986510310624d, y: 0.8865579491914038d), radius: 0.7767767608716686d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.896911762532843d, y: 0.3441175963354959d), radius: 0.562772431342546d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7704869318740358d, y: 0.6985750553987364d), radius: 0.2244340838221336d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5707116344237982d, y: 0.9779741858715382d), radius: 0.9104008485026844d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7383012663723899d, y: 0.889488761818683d), radius: 0.47254138191245854d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49309723182303256d, y: 0.5930934747233713d), radius: 0.6400530952087822d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9491581178377068d, y: 0.41339479224983144d), radius: 0.01743688409622579d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6603114988758941d, y: 0.16760059376971126d), radius: 0.6187075454411947d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15678426694909275d, y: 0.7288408039429102d), radius: 0.04736497977709708d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08505049826478028d, y: 0.02369413431327394d), radius: 0.7579982529253485d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4321985933239725d, y: 0.9333302175702638d), radius: 0.03972600190067943d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9468867217681585d, y: 0.3555720650777774d), radius: 0.4177119126474812d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6806443054545074d, y: 0.7645636576388796d), radius: 0.125223142667652d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.689650556847318d, y: 0.568018284146244d), radius: 0.3846872730868688d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17328519133897557d, y: 0.778061539677684d), radius: 0.626285591149752d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9746581542068994d, y: 0.5636804638844216d), radius: 0.5970491610101644d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.718525330502358d, y: 0.2956077289110125d), radius: 0.510968457836568d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20640454264874442d, y: 0.8180739287553507d), radius: 0.47241759042491904d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8071083309719144d, y: 0.028024327665114757d), radius: 0.26810949990159183d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.421785311876552d, y: 0.035422091049944426d), radius: 0.10669470876323339d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3465446872885092d, y: 0.14334866990264838d), radius: 0.3466497495898271d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7970379124677298d, y: 0.5439066571507641d), radius: 0.1874423656844446d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.729839132471422d, y: 0.6897129575707894d), radius: 0.924046775277683d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.603124211638176d, y: 0.851627135608398d), radius: 0.05992763955074498d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6909678569955908d, y: 0.7559675846175159d), radius: 0.8163165694115341d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15912739280755106d, y: 0.5745945571164289d), radius: 0.5793279580443383d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5367839480572887d, y: 0.8870196088715409d), radius: 0.860742036124837d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010903434770456744d, y: 0.1356627477421628d), radius: 0.5278319615180199d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5484994057546313d, y: 0.38613499383167404d), radius: 0.614668013611036d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28589510326344203d, y: 0.20682398334736707d), radius: 0.17735877823302282d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.990142900391401d, y: 0.5277262015966534d), radius: 0.9301996396977034d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16486984426652307d, y: 0.40009705630246195d), radius: 0.6107844361684585d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2254574637368627d, y: 0.6327648383755001d), radius: 0.9439715007749574d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7363649802963443d, y: 0.6442702173144119d), radius: 0.6510895672661791d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.150293404220617d, y: 0.039060037454920926d), radius: 0.6475138351119397d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3225793352719952d, y: 0.8975293383136684d), radius: 0.9171199917108694d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9630526168847834d, y: 0.18008893958060246d), radius: 0.04654290324332255d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22381603739675837d, y: 0.544487222780464d), radius: 0.11208812230098875d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8952406362862944d, y: 0.2758518046493652d), radius: 0.8445762409163029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6493914282985634d, y: 0.8743275225617242d), radius: 0.41364034805824257d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9778628703691192d, y: 0.8226187016448026d), radius: 0.7196105416013063d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09249499325565269d, y: 0.870910210963392d), radius: 0.6460228716631594d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18173394043732805d, y: 0.24227679771600386d), radius: 0.1889876671852313d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5905918041040207d, y: 0.5828550688340869d), radius: 0.9767301468209382d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6885973489328446d, y: 0.6103298129444911d), radius: 0.002243058188895919d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7679401599543957d, y: 0.5363515850181597d), radius: 0.10946997918276458d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.002370757358299058d, y: 0.9422353929309302d), radius: 0.7606860355546702d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5957475531419127d, y: 0.33929780612253657d), radius: 0.7130047143384852d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8517644713070542d, y: 0.024587619297576913d), radius: 0.4173946601351859d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6714923650467581d, y: 0.8166518458589928d), radius: 0.11646879755848127d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5255238499059783d, y: 0.5656291115124058d), radius: 0.926944896122293d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023042355157098515d, y: 0.4233940110238973d), radius: 0.5095439049891156d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38080836357060954d, y: 0.6463955066199945d), radius: 0.5025034111585823d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3434152823508144d, y: 0.5899552461192951d), radius: 0.4495386550272059d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08535994127865854d, y: 0.18921460046249994d), radius: 0.20714554019988896d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9421684612246229d, y: 0.06841281860197856d), radius: 0.7686964519156771d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009614880587177077d, y: 0.854709816718859d), radius: 0.745353190963992d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6354045292951874d, y: 0.9283593781794537d), radius: 0.4338151810919566d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22469038768079608d, y: 0.24678456221157985d), radius: 0.6485012543653227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6909775899866377d, y: 0.1095808228036591d), radius: 0.9536722394831926d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.99906487402729d, y: 0.9226724261562751d), radius: 0.3976739716238038d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23734598990135314d, y: 0.6020766758183004d), radius: 0.010832382684142328d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.523192571525848d, y: 0.6456192650781669d), radius: 0.3689870572874777d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11438343456316458d, y: 0.2156856689107075d), radius: 0.39421987552674354d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15686555017105652d, y: 0.24144280290157083d), radius: 0.6868246753206534d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37731164340079315d, y: 0.9974769980450594d), radius: 0.13743559892150337d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19619432814051696d, y: 0.7199662906888373d), radius: 0.7201250517429287d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13720316363712526d, y: 0.26542109333509745d), radius: 0.05782264921701863d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006791388590363101d, y: 0.5051101718407343d), radius: 0.41213716618975327d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4883655565691303d, y: 0.4576052877194642d), radius: 0.352545537077089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8744696141523539d, y: 0.4726568059333921d), radius: 0.9641488057622831d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9076922141905713d, y: 0.7516181903957115d), radius: 0.48943376379176395d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9423550737702404d, y: 0.008428550832649262d), radius: 0.8507420233420617d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6472864975905017d, y: 0.4216600058011384d), radius: 0.16209893426767452d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12860850950257474d, y: 0.5745105598761315d), radius: 0.9560598610564767d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7821355915803525d, y: 0.2367946517078846d), radius: 0.7808181687534441d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3113245756552885d, y: 0.9211630948123606d), radius: 0.42723480518566426d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2976026736733527d, y: 0.5943672112357854d), radius: 0.017039105241604013d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6661895685910991d, y: 0.005339588160474307d), radius: 0.4300817853937341d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7883026234638357d, y: 0.20485956282446272d), radius: 0.15516115584887236d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8779245642111551d, y: 0.7236286877930134d), radius: 0.09733949027545163d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5484617009181315d, y: 0.9176948188053853d), radius: 0.574854369292058d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10787015148691981d, y: 0.6583101497484358d), radius: 0.5625894019924829d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8539830396149625d, y: 0.5138248814851032d), radius: 0.5688362065214383d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21360332565088735d, y: 0.7655739011225443d), radius: 0.23459970364954197d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5217423119701675d, y: 0.21455909787533756d), radius: 0.25943251623307473d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7193061587077142d, y: 0.7531983951981085d), radius: 0.012010687334697123d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6660381602724538d, y: 0.6381757319689321d), radius: 0.8101061028258275d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5168613005059699d, y: 0.22039626575069016d), radius: 0.6812054206094915d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6014729471943606d, y: 0.9829971240652717d), radius: 0.9167256296580052d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48020582058986194d, y: 0.2706110540062965d), radius: 0.8061808962689091d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13807149821511255d, y: 0.04305782983592832d), radius: 0.7083282377014639d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5892274280572027d, y: 0.46336161990839664d), radius: 0.6017348213450939d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9672405271737519d, y: 0.7371121977079269d), radius: 0.046212847048163086d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32389113945998116d, y: 0.3129105074221986d), radius: 0.6462311663821888d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2275497630865796d, y: 0.44230267335537876d), radius: 0.6136218687937895d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.659851440200908d, y: 0.6943457284167518d), radius: 0.5639832476512782d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.883751042353365d, y: 0.6914232416412985d), radius: 0.5049181773044159d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.837691822748006d, y: 0.5072249681881906d), radius: 0.1920601431117912d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5990543593135121d, y: 0.2902493409423227d), radius: 0.13938503503872346d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10426095022768d, y: 0.57623434293283d), radius: 0.8224952200938194d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35798109562629743d, y: 0.5953889417292426d), radius: 0.10361917058142034d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3870221062246829d, y: 0.3212861318942828d), radius: 0.24675855958846782d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8707405381360196d, y: 0.7485510118748102d), radius: 0.20990482404483535d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47947941610958156d, y: 0.17743125196793963d), radius: 0.3854037209960899d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6871306189581647d, y: 0.5718253061274892d), radius: 0.6154966754220199d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32120308908622575d, y: 0.33557076714920453d), radius: 0.3028087529133142d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5688631269064253d, y: 0.7417710277237627d), radius: 0.10428767487191948d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3612291226723483d, y: 0.2176258235002534d), radius: 0.443813799362862d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9966656970298136d, y: 0.6827895538706512d), radius: 0.49000323909135635d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3637583721701464d, y: 0.04759308188752587d), radius: 0.8539323008559774d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9861679391657658d, y: 0.847993242155655d), radius: 0.45845527736430913d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.513427829054411d, y: 0.7678266252944649d), radius: 0.6139705014635269d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15057867504340272d, y: 0.21540189350541994d), radius: 0.17120771162059711d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9404582961296313d, y: 0.8665711975793989d), radius: 0.17426504540057008d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9908687565581626d, y: 0.2222948196172324d), radius: 0.8882039747157983d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4623849264297186d, y: 0.009991750394879761d), radius: 0.37419966599874077d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4033923074468787d, y: 0.7731652299348292d), radius: 0.3782958542943653d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29979119889041406d, y: 0.9347156497055248d), radius: 0.4903587755446287d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.372371810369568d, y: 0.791732798099651d), radius: 0.12806578184743878d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8565175329277649d, y: 0.9432157040832552d), radius: 0.293959087958623d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08048244436825147d, y: 0.5035767540721401d), radius: 0.8373140651653599d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6410820612127045d, y: 0.8879866642820953d), radius: 0.3559888889388908d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0768402170262713d, y: 0.9806601784461006d), radius: 0.2081466811102306d),
}));
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6041198415137617d, y: 0.16756041247454734d), radius: 0.14681944109803302d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4742924852530066d, y: 0.35700540451763874d), radius: 0.2693553268656892d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7064919890377886d, y: 0.01022069075273313d), radius: 0.9362611042900792d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11425976448077768d, y: 0.43380698493824443d), radius: 0.15062206190916494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9219913072440212d, y: 0.6107084353208664d), radius: 0.5418490895586849d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34465087072493916d, y: 0.6051514180430763d), radius: 0.4334799409645359d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9989805808364045d, y: 0.5993043533078459d), radius: 0.42867856058344833d),
}));
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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

                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[18], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[19], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[20], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[21], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[22], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[23], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[24], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[25], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[26], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[27], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[28], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[8], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[9], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[10], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[11], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[12], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[13], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[14], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[15], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[16], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[17], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[18], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[19], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[20], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[21], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[22], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[23], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[24], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[25], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[26], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[27], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[28], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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

                var models = await ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[7], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[8], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[9], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[29], false);
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

                var models =  ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[3], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[4], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[5], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[6], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[7], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[8], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[9], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 78, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 24, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[7], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[8], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[9], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[10], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[11], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[12], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[13], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[14], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[15], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[16], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[17], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[18], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[19], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[20], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[21], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[22], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[23], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[24], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[25], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[26], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[27], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[28], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelBatchAsync(connection, 111, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
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
                var models =  ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelBatch(connection, 45, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1M>(15);

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
                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

