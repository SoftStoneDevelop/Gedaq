

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
    internal partial interface INpgsqlBoxListboxListD1
    {
    }
    
    internal partial class NpgsqlBoxListboxListD1 : INpgsqlBoxListboxListD1
    {


#region TestData

        private readonly NpgsqlBoxboxListD1E2M[] _testData = new NpgsqlBoxboxListD1E2M[]
        {
            new NpgsqlBoxboxListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8977879278463735d,right: 0.47232106206884683d,bottom: 0.06070067210621066d,left: 0.4341651189423843d),

new NpgsqlTypes.NpgsqlBox(top: 0.28495082017229845d,right: 0.5790834760937358d,bottom: 0.07039497396548577d,left: 0.1663968146509085d),

new NpgsqlTypes.NpgsqlBox(top: 0.5153946912187395d,right: 0.2729779629310414d,bottom: 0.05777554692030562d,left: 0.15788934768916363d),

new NpgsqlTypes.NpgsqlBox(top: 0.6144897748842075d,right: 0.4360771918045355d,bottom: 0.08563703736799999d,left: 0.2087815424344569d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.406303344583577d,right: 0.5302761665523588d,bottom: 0.18454040933095983d,left: 0.4752088220721562d),

new NpgsqlTypes.NpgsqlBox(top: 0.8372697759170653d,right: 0.6666543910853279d,bottom: 0.12924106210203834d,left: 0.27048189876125284d),

new NpgsqlTypes.NpgsqlBox(top: 0.9577476800015804d,right: 0.29024523345546427d,bottom: 0.6725632348191755d,left: 0.011849088092895532d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44442640571791503d,right: 0.2658523300118396d,bottom: 0.002091583004594111d,left: 0.24385197646846102d),

new NpgsqlTypes.NpgsqlBox(top: 0.8881081473062555d,right: 0.09466553863021132d,bottom: 0.4166852363293785d,left: 0.01934421803769104d),

new NpgsqlTypes.NpgsqlBox(top: 0.6429201726604358d,right: 0.8228764088430897d,bottom: 0.0069207055593367706d,left: 0.3048748769370123d),

new NpgsqlTypes.NpgsqlBox(top: 0.5366095816232759d,right: 0.7601773344816405d,bottom: 0.048643511638092995d,left: 0.44634878002086553d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6622098600197415d,right: 0.5828778671524246d,bottom: 0.19063946731416848d,left: 0.37622936559566855d),

new NpgsqlTypes.NpgsqlBox(top: 0.9374914423227697d,right: 0.23520299531730504d,bottom: 0.08859903494936461d,left: 0.09943838000446181d),

new NpgsqlTypes.NpgsqlBox(top: 0.1741730021799135d,right: 0.2666393734155512d,bottom: 0.12350642922499122d,left: 0.07658335962788221d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.07083438374771767d,right: 0.9968143295587526d,bottom: 0.02324469057166556d,left: 0.29704568255633323d),

new NpgsqlTypes.NpgsqlBox(top: 0.7839165859425341d,right: 0.9075730587045534d,bottom: 0.13468627813342016d,left: 0.022260474248908202d),

new NpgsqlTypes.NpgsqlBox(top: 0.7684490079250604d,right: 0.23333877586477236d,bottom: 0.07775759294964368d,left: 0.048847195130225396d),

new NpgsqlTypes.NpgsqlBox(top: 0.9477579438118076d,right: 0.7700675320786543d,bottom: 0.13155299239260798d,left: 0.44408672002186333d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.10808694158954957d,right: 0.8939259052611286d,bottom: 0.05858340451338451d,left: 0.32540330679620466d),

new NpgsqlTypes.NpgsqlBox(top: 0.24422591812042538d,right: 0.5893419210778932d,bottom: 0.16296616208469694d,left: 0.4699210656653362d),

new NpgsqlTypes.NpgsqlBox(top: 0.8710219580119277d,right: 0.6202969729174258d,bottom: 0.6847167246973164d,left: 0.2645975749703505d),

new NpgsqlTypes.NpgsqlBox(top: 0.9411087208648107d,right: 0.9376116353356091d,bottom: 0.3472046310499961d,left: 0.12217775834808808d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6693873301388152d,right: 0.5365638214196854d,bottom: 0.14727600325577705d,left: 0.037247858401256995d),

new NpgsqlTypes.NpgsqlBox(top: 0.976691109666811d,right: 0.2946792115454583d,bottom: 0.9340166760603595d,left: 0.289157488957528d),

new NpgsqlTypes.NpgsqlBox(top: 0.5807877132197753d,right: 0.5232796775874563d,bottom: 0.34767984566713084d,left: 0.2016601341904669d),

new NpgsqlTypes.NpgsqlBox(top: 0.8460149150526199d,right: 0.847562688348909d,bottom: 0.014871997157556716d,left: 0.1606053436166589d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5510098427732941d,right: 0.9493424907491016d,bottom: 0.2774057379260306d,left: 0.12109173682863572d),

new NpgsqlTypes.NpgsqlBox(top: 0.3941821835466457d,right: 0.9021336672723081d,bottom: 0.19247018999010757d,left: 0.8098082299662555d),

new NpgsqlTypes.NpgsqlBox(top: 0.7126982286251635d,right: 0.47988934758904034d,bottom: 0.1523214707144982d,left: 0.43214165257881765d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7212346899560305d,right: 0.390472647542775d,bottom: 0.13756001550727048d,left: 0.31664929976635914d),

new NpgsqlTypes.NpgsqlBox(top: 0.5169669760000354d,right: 0.7818733804731536d,bottom: 0.4934750919699479d,left: 0.247837735369699d),

new NpgsqlTypes.NpgsqlBox(top: 0.1520328299148893d,right: 0.10618334520510586d,bottom: 0.11174564066937387d,left: 0.09603285528724648d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.885890315845314d,right: 0.8840853132032661d,bottom: 0.7255219074953023d,left: 0.5421787167584595d),

new NpgsqlTypes.NpgsqlBox(top: 0.5337178623387341d,right: 0.6553861306005995d,bottom: 0.23901129933243526d,left: 0.41917596885473063d),

new NpgsqlTypes.NpgsqlBox(top: 0.3095723539067943d,right: 0.6071039109810259d,bottom: 0.09287756516204781d,left: 0.1333001609257115d),

new NpgsqlTypes.NpgsqlBox(top: 0.7211781238263113d,right: 0.7027629932777505d,bottom: 0.0755444188194151d,left: 0.03172862991490333d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5958022714818425d,right: 0.2653889353577541d,bottom: 0.44573410934514324d,left: 0.04378079049812855d),

new NpgsqlTypes.NpgsqlBox(top: 0.7045454334175816d,right: 0.4889740116817448d,bottom: 0.3274477268808974d,left: 0.00832194503481587d),

new NpgsqlTypes.NpgsqlBox(top: 0.9685254816118243d,right: 0.782475251600402d,bottom: 0.22644854928169678d,left: 0.6319993333513353d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8957332836693596d,right: 0.8591230920351117d,bottom: 0.20446528360819005d,left: 0.3739285747411867d),

new NpgsqlTypes.NpgsqlBox(top: 0.8360531175020176d,right: 0.22826659211886668d,bottom: 0.34196846648712864d,left: 0.0036530849870615167d),

new NpgsqlTypes.NpgsqlBox(top: 0.6164591950087236d,right: 0.7291487977347296d,bottom: 0.5844409307080585d,left: 0.15239453078182963d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.727520344562231d,right: 0.4343052800939148d,bottom: 0.7259704252894837d,left: 0.16021999277261256d),

new NpgsqlTypes.NpgsqlBox(top: 0.9516734612937576d,right: 0.9474298006777949d,bottom: 0.51878675770815d,left: 0.17129072668754142d),

new NpgsqlTypes.NpgsqlBox(top: 0.8869347710768447d,right: 0.8340946106047468d,bottom: 0.6362937802072416d,left: 0.7427370454305415d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5312482322686458d,right: 0.3284950671399517d,bottom: 0.3898821578333035d,left: 0.3133373600881706d),

new NpgsqlTypes.NpgsqlBox(top: 0.7315956280936998d,right: 0.506784007912872d,bottom: 0.4875656760504371d,left: 0.08951558155121386d),

new NpgsqlTypes.NpgsqlBox(top: 0.3131855956544991d,right: 0.0973911952089247d,bottom: 0.20657714554206053d,left: 0.00048803062926117136d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3710986612099595d,right: 0.5718072461925144d,bottom: 0.14527962294981223d,left: 0.12040185525893321d),

new NpgsqlTypes.NpgsqlBox(top: 0.33662000448792706d,right: 0.24286668401424516d,bottom: 0.03664486477684259d,left: 0.08751675857096441d),

new NpgsqlTypes.NpgsqlBox(top: 0.06906596783019803d,right: 0.9645977286129812d,bottom: 0.03288563459533167d,left: 0.4372768115988769d),

new NpgsqlTypes.NpgsqlBox(top: 0.9882428562413482d,right: 0.5449490491160812d,bottom: 0.7288300654477244d,left: 0.4222659314606202d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5529778054453756d,right: 0.5489619534659088d,bottom: 0.033356540196639806d,left: 0.5210673109611776d),

new NpgsqlTypes.NpgsqlBox(top: 0.9278664325737174d,right: 0.6235097502420476d,bottom: 0.7950467882311508d,left: 0.30417600002464107d),

new NpgsqlTypes.NpgsqlBox(top: 0.8416488716677646d,right: 0.8351260761120678d,bottom: 0.6830708966803316d,left: 0.2437017346120527d),

new NpgsqlTypes.NpgsqlBox(top: 0.26659578966360364d,right: 0.6229918909141536d,bottom: 0.2360185724581324d,left: 0.34290320792671924d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6382662692848776d,right: 0.8336178407503747d,bottom: 0.33167722742180095d,left: 0.3181838365222791d),

new NpgsqlTypes.NpgsqlBox(top: 0.9750028183350289d,right: 0.009544721600254324d,bottom: 0.5824924653936663d,left: 0.008700919884302216d),

new NpgsqlTypes.NpgsqlBox(top: 0.5158381037815871d,right: 0.5917059517973415d,bottom: 0.24032617196547756d,left: 0.267458020420587d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2175386075797462d,right: 0.8154473571765517d,bottom: 0.0358889007249229d,left: 0.08716677106695792d),

new NpgsqlTypes.NpgsqlBox(top: 0.9878826450351462d,right: 0.8378981892199614d,bottom: 0.5813949511722475d,left: 0.28210683487903365d),

new NpgsqlTypes.NpgsqlBox(top: 0.37231235108747907d,right: 0.7013450994302831d,bottom: 0.034539603391736784d,left: 0.2521288672707671d),

new NpgsqlTypes.NpgsqlBox(top: 0.5754752002093129d,right: 0.38321608506047977d,bottom: 0.3319922663929722d,left: 0.2903455431275238d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5657667432023424d,right: 0.602567694889767d,bottom: 0.048692682173360535d,left: 0.15068308030647737d),

new NpgsqlTypes.NpgsqlBox(top: 0.9353210764836185d,right: 0.7565666432782177d,bottom: 0.6255934883198634d,left: 0.056588705593896615d),

new NpgsqlTypes.NpgsqlBox(top: 0.9226044513912215d,right: 0.7589923506413394d,bottom: 0.8527357241713712d,left: 0.23577946464809207d),

new NpgsqlTypes.NpgsqlBox(top: 0.987491772829623d,right: 0.9253122042552193d,bottom: 0.3715651756205267d,left: 0.40410428266410914d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8154941095280918d,right: 0.3280827973156978d,bottom: 0.6496829731420014d,left: 0.0595676135286779d),

new NpgsqlTypes.NpgsqlBox(top: 0.29301232266444954d,right: 0.9118763353545185d,bottom: 0.033142008452685334d,left: 0.3857598619532361d),

new NpgsqlTypes.NpgsqlBox(top: 0.8114392735339898d,right: 0.8261499487661831d,bottom: 0.8011339816530451d,left: 0.579939296760035d),

new NpgsqlTypes.NpgsqlBox(top: 0.6607173396139706d,right: 0.6312755359751661d,bottom: 0.07317033804974382d,left: 0.5325669000133278d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7938867072684415d,right: 0.7385813445215599d,bottom: 0.13859551361252753d,left: 0.02795792400892949d),

new NpgsqlTypes.NpgsqlBox(top: 0.49838579840401276d,right: 0.5489825066862519d,bottom: 0.3595455656633014d,left: 0.25739228188302643d),

new NpgsqlTypes.NpgsqlBox(top: 0.6432174901171297d,right: 0.8212903590888034d,bottom: 0.6082637229646363d,left: 0.18888928583089037d),

new NpgsqlTypes.NpgsqlBox(top: 0.6211050580874558d,right: 0.5654475648176884d,bottom: 0.39997763521847507d,left: 0.010933780877235955d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6357769759033135d,right: 0.6016735329369488d,bottom: 0.09254501838173235d,left: 0.03672257247899191d),

new NpgsqlTypes.NpgsqlBox(top: 0.4562030898180367d,right: 0.14903569958593477d,bottom: 0.04377208625204543d,left: 0.058419035561471655d),

new NpgsqlTypes.NpgsqlBox(top: 0.5011557741317729d,right: 0.8338668443540839d,bottom: 0.0059447786860773455d,left: 0.6221716311541037d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46657950433451156d,right: 0.5316321578787627d,bottom: 0.07543925840643384d,left: 0.29794647837474675d),

new NpgsqlTypes.NpgsqlBox(top: 0.4209654154708389d,right: 0.9234537450291347d,bottom: 0.39292073058772603d,left: 0.16181109932567694d),

new NpgsqlTypes.NpgsqlBox(top: 0.430071306083768d,right: 0.7680016217342204d,bottom: 0.3261236904158652d,left: 0.026174717662971192d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3462368392508933d,right: 0.829042044327959d,bottom: 0.14865259974251321d,left: 0.7492171171296345d),

new NpgsqlTypes.NpgsqlBox(top: 0.6413043252161479d,right: 0.21124134694257246d,bottom: 0.5896052890112682d,left: 0.046733786593287086d),

new NpgsqlTypes.NpgsqlBox(top: 0.5905616062425124d,right: 0.9365830550416545d,bottom: 0.5144122202375777d,left: 0.8658229973200966d),

new NpgsqlTypes.NpgsqlBox(top: 0.6195268498388167d,right: 0.5645198363116457d,bottom: 0.23155754155770247d,left: 0.22138421664616892d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6982266311609006d,right: 0.767872434741226d,bottom: 0.00639616473575455d,left: 0.28330291641016303d),

new NpgsqlTypes.NpgsqlBox(top: 0.7666390891578345d,right: 0.28518627579552314d,bottom: 0.31294682063410983d,left: 0.08756895088974281d),

new NpgsqlTypes.NpgsqlBox(top: 0.962894699822083d,right: 0.8452413787618946d,bottom: 0.5066651285585253d,left: 0.4296877946539326d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3224542879052381d,right: 0.33875945109846506d,bottom: 0.2676234098463641d,left: 0.07299508527977205d),

new NpgsqlTypes.NpgsqlBox(top: 0.4601636478045328d,right: 0.9947897516931046d,bottom: 0.3867847840848633d,left: 0.9859290298651157d),

new NpgsqlTypes.NpgsqlBox(top: 0.7964219689284391d,right: 0.1689196563460701d,bottom: 0.3015766912100435d,left: 0.07012289078934997d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9181743432297381d,right: 0.956869075496944d,bottom: 0.09588687883144342d,left: 0.4009984596962176d),

new NpgsqlTypes.NpgsqlBox(top: 0.4778146937075578d,right: 0.9304468770508814d,bottom: 0.2549915905111184d,left: 0.5359036751009667d),

new NpgsqlTypes.NpgsqlBox(top: 0.8194069052401443d,right: 0.4174090141723177d,bottom: 0.39466743454005326d,left: 0.3068160900819582d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1923822347963582d,right: 0.9402017769229903d,bottom: 0.10794918910539375d,left: 0.736077451491384d),

new NpgsqlTypes.NpgsqlBox(top: 0.9088888524669485d,right: 0.5137632960663925d,bottom: 0.34607351908038575d,left: 0.4295993738234435d),

new NpgsqlTypes.NpgsqlBox(top: 0.5893045398521863d,right: 0.30074480428851114d,bottom: 0.3477219656765419d,left: 0.19790761357429743d),

new NpgsqlTypes.NpgsqlBox(top: 0.7330441369553027d,right: 0.3349434106466279d,bottom: 0.5840501495733912d,left: 0.0028826103962349414d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8209019229841577d,right: 0.9494279088442684d,bottom: 0.3287456284211068d,left: 0.2222171296782366d),

new NpgsqlTypes.NpgsqlBox(top: 0.7472589960343572d,right: 0.20971187302147665d,bottom: 0.6176258906168316d,left: 0.12184345686226228d),

new NpgsqlTypes.NpgsqlBox(top: 0.9913485885524373d,right: 0.832267662303048d,bottom: 0.7957700244177289d,left: 0.5798574900926432d),

new NpgsqlTypes.NpgsqlBox(top: 0.8927100772977495d,right: 0.5408698544223218d,bottom: 0.44926940052628084d,left: 0.29890228941137265d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7861080097498027d,right: 0.6995382630418482d,bottom: 0.5389330462639689d,left: 0.13941327708146967d),

new NpgsqlTypes.NpgsqlBox(top: 0.7887295425743246d,right: 0.35094075434577d,bottom: 0.2685938301855496d,left: 0.1768689357860438d),

new NpgsqlTypes.NpgsqlBox(top: 0.10328757674548161d,right: 0.835697373161939d,bottom: 0.10012798566333503d,left: 0.6934289883654705d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9709293307008582d,right: 0.7040731570297889d,bottom: 0.2633815204275698d,left: 0.19028956525292362d),

new NpgsqlTypes.NpgsqlBox(top: 0.8293494391022841d,right: 0.7634066167240929d,bottom: 0.48530762712006215d,left: 0.5146099372035414d),

new NpgsqlTypes.NpgsqlBox(top: 0.7917715644017007d,right: 0.6393420286243048d,bottom: 0.7886225731668409d,left: 0.6086133996986326d),

new NpgsqlTypes.NpgsqlBox(top: 0.045586699814120224d,right: 0.9023606335398868d,bottom: 0.020686033144722837d,left: 0.6369803968770865d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37347083035851325d,right: 0.9451888659130854d,bottom: 0.33263665372352014d,left: 0.6082481174185268d),

new NpgsqlTypes.NpgsqlBox(top: 0.9762961815881877d,right: 0.8737101056907652d,bottom: 0.8785297849539553d,left: 0.3686209922663892d),

new NpgsqlTypes.NpgsqlBox(top: 0.3550542714236894d,right: 0.8751509577172922d,bottom: 0.21838988800126835d,left: 0.06363314706226741d),

new NpgsqlTypes.NpgsqlBox(top: 0.8608154891006939d,right: 0.9553091682488908d,bottom: 0.5371486857390922d,left: 0.9365538924195255d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.08898395154047478d,right: 0.4049629680896315d,bottom: 0.06571209964983737d,left: 0.23788701930421174d),

new NpgsqlTypes.NpgsqlBox(top: 0.5601152651523221d,right: 0.8129211663250234d,bottom: 0.5186840643070834d,left: 0.05722717348513062d),

new NpgsqlTypes.NpgsqlBox(top: 0.79850352733638d,right: 0.3438050747447231d,bottom: 0.4258886558080085d,left: 0.3014153774837155d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2654230736251766d,right: 0.8486604185236327d,bottom: 0.08800532446210807d,left: 0.0797176495960481d),

new NpgsqlTypes.NpgsqlBox(top: 0.1487649315316919d,right: 0.6818017084503611d,bottom: 0.0921231717227774d,left: 0.6587292266254984d),

new NpgsqlTypes.NpgsqlBox(top: 0.6230449741645855d,right: 0.7786959241112769d,bottom: 0.2201538491757672d,left: 0.6152003377249279d),

new NpgsqlTypes.NpgsqlBox(top: 0.8559801339503785d,right: 0.5752180393166472d,bottom: 0.2823502490965415d,left: 0.15482398682412457d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6143806172432253d,right: 0.4723779197371746d,bottom: 0.0888061942345052d,left: 0.11156678812463738d),

new NpgsqlTypes.NpgsqlBox(top: 0.6960396886805418d,right: 0.5221574276135965d,bottom: 0.15556090634027508d,left: 0.437424231457881d),

new NpgsqlTypes.NpgsqlBox(top: 0.7663618120991615d,right: 0.5200822872968017d,bottom: 0.6159131368873523d,left: 0.3869060756092917d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4515304861871765d,right: 0.322144848976364d,bottom: 0.04181447483831591d,left: 0.22925289653392977d),

new NpgsqlTypes.NpgsqlBox(top: 0.33318033961019977d,right: 0.7831642555020103d,bottom: 0.04055311938559247d,left: 0.6741280760558261d),

new NpgsqlTypes.NpgsqlBox(top: 0.3647807347675184d,right: 0.6699205709955753d,bottom: 0.24599822053450193d,left: 0.03500963973255d),

new NpgsqlTypes.NpgsqlBox(top: 0.3383204584527866d,right: 0.2713739440640729d,bottom: 0.215598494207082d,left: 0.08430097954234095d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8701350065508002d,right: 0.9331575747600888d,bottom: 0.3378957823664712d,left: 0.618349555275125d),

new NpgsqlTypes.NpgsqlBox(top: 0.0470444777623128d,right: 0.2603149142913562d,bottom: 0.04079241123927968d,left: 0.05940357979668909d),

new NpgsqlTypes.NpgsqlBox(top: 0.8114528962858601d,right: 0.3025214665230693d,bottom: 0.6911318323863711d,left: 0.20488238906323042d),

new NpgsqlTypes.NpgsqlBox(top: 0.6848951870865887d,right: 0.9098632999613374d,bottom: 0.25610993350940536d,left: 0.1689995083730177d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9887632457332612d,right: 0.3630997688622907d,bottom: 0.7485186986498154d,left: 0.33760894384428364d),

new NpgsqlTypes.NpgsqlBox(top: 0.6703058314261148d,right: 0.3459815546608689d,bottom: 0.18847098279354524d,left: 0.16460443507552525d),

new NpgsqlTypes.NpgsqlBox(top: 0.5914747412224164d,right: 0.7108431396498168d,bottom: 0.03528502529985522d,left: 0.38229033825551406d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7589562135358596d,right: 0.8984832269812694d,bottom: 0.21504268349589695d,left: 0.5247104792044663d),

new NpgsqlTypes.NpgsqlBox(top: 0.7411139066177073d,right: 0.602905077741363d,bottom: 0.6225914915148957d,left: 0.3792126497509335d),

new NpgsqlTypes.NpgsqlBox(top: 0.7826679370318161d,right: 0.9893362111126758d,bottom: 0.10635660292304572d,left: 0.31090898682730217d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3461415782967463d,right: 0.5143079534342647d,bottom: 0.13912059376490793d,left: 0.008444350870028372d),

new NpgsqlTypes.NpgsqlBox(top: 0.9183807103389849d,right: 0.733122095432711d,bottom: 0.34587456898791635d,left: 0.169623376361286d),

new NpgsqlTypes.NpgsqlBox(top: 0.6752899987707398d,right: 0.6975080620447425d,bottom: 0.5185852250287557d,left: 0.33258040668583466d),

new NpgsqlTypes.NpgsqlBox(top: 0.5233033410701193d,right: 0.6705324015964619d,bottom: 0.029905296064288267d,left: 0.08402410786681769d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.927996913927037d,right: 0.7190624630087494d,bottom: 0.496450841116293d,left: 0.12707414218523316d),

new NpgsqlTypes.NpgsqlBox(top: 0.8873862178122861d,right: 0.5681864400802875d,bottom: 0.32707456579930116d,left: 0.2812142815561294d),

new NpgsqlTypes.NpgsqlBox(top: 0.7856462745716615d,right: 0.8879801758989784d,bottom: 0.7195859572062056d,left: 0.3184013389884838d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3437247442155662d,right: 0.29298047909907377d,bottom: 0.2771209278920673d,left: 0.0924299584696402d),

new NpgsqlTypes.NpgsqlBox(top: 0.8149672503712944d,right: 0.5337393673929962d,bottom: 0.5003283988727139d,left: 0.5276139798158282d),

new NpgsqlTypes.NpgsqlBox(top: 0.9027720826458732d,right: 0.30637392346648507d,bottom: 0.5962357236018128d,left: 0.22130775192723007d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3312079494726553d,right: 0.7084168429756327d,bottom: 0.19639360269984563d,left: 0.580628816016176d),

new NpgsqlTypes.NpgsqlBox(top: 0.17179177205350382d,right: 0.8153265850063557d,bottom: 0.018183142109380435d,left: 0.18200922583274193d),

new NpgsqlTypes.NpgsqlBox(top: 0.7506573238673857d,right: 0.841290048906159d,bottom: 0.4660012893817006d,left: 0.6348769587552302d),

new NpgsqlTypes.NpgsqlBox(top: 0.9442199623197013d,right: 0.9731317051447876d,bottom: 0.5776922175462594d,left: 0.4363522767442899d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9636479350154146d,right: 0.9865747529875715d,bottom: 0.663167498203658d,left: 0.638981476736228d),

new NpgsqlTypes.NpgsqlBox(top: 0.4013620684721404d,right: 0.7471594773760398d,bottom: 0.3064049729038886d,left: 0.7239881122201848d),

new NpgsqlTypes.NpgsqlBox(top: 0.5478149844230034d,right: 0.3039905911391071d,bottom: 0.022892089968041818d,left: 0.11480614122147659d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8178791406839512d,right: 0.6559566950112655d,bottom: 0.11452812811917745d,left: 0.6397791984464193d),

new NpgsqlTypes.NpgsqlBox(top: 0.883528435782744d,right: 0.6225920283845217d,bottom: 0.6861166026816573d,left: 0.6209509504050649d),

new NpgsqlTypes.NpgsqlBox(top: 0.32446890439819276d,right: 0.5394633960435525d,bottom: 0.13958629260335242d,left: 0.23989330037466672d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6241986168573267d,right: 0.8093401415814943d,bottom: 0.30758324137836457d,left: 0.570691471407821d),

new NpgsqlTypes.NpgsqlBox(top: 0.6774205402442747d,right: 0.8125806005922556d,bottom: 0.224761170537907d,left: 0.4749230285116003d),

new NpgsqlTypes.NpgsqlBox(top: 0.8591734247803029d,right: 0.533045921811358d,bottom: 0.7431632121643643d,left: 0.42953387824575495d),

new NpgsqlTypes.NpgsqlBox(top: 0.8381338706533411d,right: 0.7501581793740828d,bottom: 0.3778823106319552d,left: 0.4291984797750247d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9621832976230784d,right: 0.690200817886323d,bottom: 0.01465866962764839d,left: 0.42886512019327816d),

new NpgsqlTypes.NpgsqlBox(top: 0.9669204753850353d,right: 0.8724845071192623d,bottom: 0.02475868619516608d,left: 0.1909871989404136d),

new NpgsqlTypes.NpgsqlBox(top: 0.2787971011199676d,right: 0.2690128642215568d,bottom: 0.02089659706892988d,left: 0.14983207571821788d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9587896373779474d,right: 0.6541543178511445d,bottom: 0.34225286639327857d,left: 0.38858453996947007d),

new NpgsqlTypes.NpgsqlBox(top: 0.9802766175968406d,right: 0.2979465093276613d,bottom: 0.8488876756464897d,left: 0.25837894508385917d),

new NpgsqlTypes.NpgsqlBox(top: 0.7019066245115841d,right: 0.3277312259312889d,bottom: 0.3766744152763014d,left: 0.2741438017117003d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6514112087422149d,right: 0.4901326371806797d,bottom: 0.5170717186827704d,left: 0.43985743385008025d),

new NpgsqlTypes.NpgsqlBox(top: 0.9580554263485634d,right: 0.8409112616644202d,bottom: 0.3210063262152968d,left: 0.4423519586099717d),

new NpgsqlTypes.NpgsqlBox(top: 0.5692001490520141d,right: 0.7190224564242623d,bottom: 0.47177125918879637d,left: 0.3265908503227962d),

new NpgsqlTypes.NpgsqlBox(top: 0.8289681976181222d,right: 0.6979897253717183d,bottom: 0.46085331243310845d,left: 0.6877243739312787d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9386868816670284d,right: 0.8515665663237877d,bottom: 0.335281598085844d,left: 0.3719833675681492d),

new NpgsqlTypes.NpgsqlBox(top: 0.7843213507859679d,right: 0.5992289955585309d,bottom: 0.49619567237795625d,left: 0.43835496219434544d),

new NpgsqlTypes.NpgsqlBox(top: 0.9453981802021401d,right: 0.5513670152597855d,bottom: 0.2371387103613487d,left: 0.46357418863930144d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8185688544108723d,right: 0.9516238068261399d,bottom: 0.3912187693288105d,left: 0.1364458003327288d),

new NpgsqlTypes.NpgsqlBox(top: 0.7474392689942021d,right: 0.9220640045002055d,bottom: 0.29808375935387144d,left: 0.6833871244372609d),

new NpgsqlTypes.NpgsqlBox(top: 0.9553712502652095d,right: 0.9238748880831967d,bottom: 0.31798893547088003d,left: 0.3494778625200121d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.674801211700731d,right: 0.5979198808190823d,bottom: 0.6384137692946855d,left: 0.23411267085035514d),

new NpgsqlTypes.NpgsqlBox(top: 0.3802117793138293d,right: 0.7582406172301778d,bottom: 0.004746916254050548d,left: 0.40685281724805d),

new NpgsqlTypes.NpgsqlBox(top: 0.4387346086060163d,right: 0.3858745238028799d,bottom: 0.31433196246775175d,left: 0.20932471547382625d),

new NpgsqlTypes.NpgsqlBox(top: 0.8804685431305611d,right: 0.6940348048075345d,bottom: 0.7364847086106115d,left: 0.23343392192075418d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2440920516431908d,right: 0.3751413905008921d,bottom: 0.18733716070482243d,left: 0.009524916838946407d),

new NpgsqlTypes.NpgsqlBox(top: 0.7119189091373878d,right: 0.07620628595156909d,bottom: 0.4838119791069675d,left: 0.012459771243413575d),

new NpgsqlTypes.NpgsqlBox(top: 0.8116357871809895d,right: 0.7678124629767615d,bottom: 0.6625080229813131d,left: 0.757216693232253d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.45663353413208696d,right: 0.7789538594174312d,bottom: 0.12128064374272696d,left: 0.2506168243996041d),

new NpgsqlTypes.NpgsqlBox(top: 0.7004275355475915d,right: 0.26485495286226646d,bottom: 0.11186838598925519d,left: 0.08157717184321689d),

new NpgsqlTypes.NpgsqlBox(top: 0.751970005608302d,right: 0.3557273465825753d,bottom: 0.41389943517400174d,left: 0.28605011210274756d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.964112285861378d,right: 0.5190159728634599d,bottom: 0.2962295527279114d,left: 0.5118778650148843d),

new NpgsqlTypes.NpgsqlBox(top: 0.714811607306843d,right: 0.18165204572561755d,bottom: 0.4822007732035317d,left: 0.08219535442548431d),

new NpgsqlTypes.NpgsqlBox(top: 0.9255798516011515d,right: 0.7540306177212266d,bottom: 0.7174937541135656d,left: 0.5863127884215732d),

new NpgsqlTypes.NpgsqlBox(top: 0.7458743998413814d,right: 0.5585986360327357d,bottom: 0.46842975017005783d,left: 0.22908298720240405d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6882487890823835d,right: 0.40222423033163524d,bottom: 0.0681609994718212d,left: 0.36257011624638513d),

new NpgsqlTypes.NpgsqlBox(top: 0.8003484455892744d,right: 0.8032563413131132d,bottom: 0.3529814855965936d,left: 0.1255669990978192d),

new NpgsqlTypes.NpgsqlBox(top: 0.7906329154114756d,right: 0.3260998712608737d,bottom: 0.48837749776150297d,left: 0.05868973483299833d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7948856399896721d,right: 0.8461305336370126d,bottom: 0.7030028215958637d,left: 0.7026891054248722d),

new NpgsqlTypes.NpgsqlBox(top: 0.5985465843554758d,right: 0.9027480262758023d,bottom: 0.12861533629374777d,left: 0.502332597599647d),

new NpgsqlTypes.NpgsqlBox(top: 0.8397662334060847d,right: 0.6762179358758463d,bottom: 0.502125072548909d,left: 0.5862384790448831d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9547695928558166d,right: 0.9348374417369464d,bottom: 0.677726960460214d,left: 0.21319452391575877d),

new NpgsqlTypes.NpgsqlBox(top: 0.7746948373781649d,right: 0.29833283048437087d,bottom: 0.2532471606230873d,left: 0.030884794342124655d),

new NpgsqlTypes.NpgsqlBox(top: 0.41456090284183467d,right: 0.694880052765947d,bottom: 0.026587113621551306d,left: 0.5077412777487821d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9255691440007847d,right: 0.8123718930043198d,bottom: 0.6994912435713911d,left: 0.6430895825206906d),

new NpgsqlTypes.NpgsqlBox(top: 0.6853432825857867d,right: 0.9673675330508305d,bottom: 0.3532996913745631d,left: 0.01062146170754985d),

new NpgsqlTypes.NpgsqlBox(top: 0.20738942564154628d,right: 0.8237329132201123d,bottom: 0.03852344741647806d,left: 0.7858577343110996d),

new NpgsqlTypes.NpgsqlBox(top: 0.7019128299719337d,right: 0.8738843662352388d,bottom: 0.2601596273557545d,left: 0.6227266798343228d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4239398419684065d,right: 0.9859777987348975d,bottom: 0.3452047568031902d,left: 0.49714048380346576d),

new NpgsqlTypes.NpgsqlBox(top: 0.9233417979631651d,right: 0.3745487565412924d,bottom: 0.7212007534954635d,left: 0.0961894316588332d),

new NpgsqlTypes.NpgsqlBox(top: 0.8375999239767647d,right: 0.7950088383459633d,bottom: 0.639828890154813d,left: 0.6630631997906323d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2446694945172555d,right: 0.891915608575246d,bottom: 0.13196242317627793d,left: 0.12766348545673178d),

new NpgsqlTypes.NpgsqlBox(top: 0.5449555399223047d,right: 0.7837679765793157d,bottom: 0.018009795357347258d,left: 0.7831728860295566d),

new NpgsqlTypes.NpgsqlBox(top: 0.586803670589195d,right: 0.2960251785901644d,bottom: 0.1624783330251387d,left: 0.09919543999027325d),

new NpgsqlTypes.NpgsqlBox(top: 0.677395899843774d,right: 0.25947429484229145d,bottom: 0.013030223270742769d,left: 0.07804475655581666d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8432594427396504d,right: 0.030668333615644805d,bottom: 0.055884395298832046d,left: 0.009586769677269902d),

new NpgsqlTypes.NpgsqlBox(top: 0.7236216906003232d,right: 0.8032277502172189d,bottom: 0.6645420079712377d,left: 0.7767169330813996d),

new NpgsqlTypes.NpgsqlBox(top: 0.7641412326299964d,right: 0.19236538176448703d,bottom: 0.4587509405432113d,left: 0.12654585251623607d),

new NpgsqlTypes.NpgsqlBox(top: 0.8388954008489817d,right: 0.38172077711168395d,bottom: 0.7814825309256619d,left: 0.020551509256910516d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6122427489264434d,right: 0.8520484851399929d,bottom: 0.17695563228614775d,left: 0.8086111971185177d),

new NpgsqlTypes.NpgsqlBox(top: 0.9424154034916158d,right: 0.6155796026083555d,bottom: 0.23326926000057768d,left: 0.3964797893085831d),

new NpgsqlTypes.NpgsqlBox(top: 0.3018650157906523d,right: 0.9363572934010315d,bottom: 0.058997234837999124d,left: 0.7644754591927636d),

new NpgsqlTypes.NpgsqlBox(top: 0.43307314089821913d,right: 0.28722216212961893d,bottom: 0.36891007064470227d,left: 0.14117036837231323d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6598202830914072d,right: 0.7127976023901452d,bottom: 0.18591814552716435d,left: 0.2980856854641287d),

new NpgsqlTypes.NpgsqlBox(top: 0.25737450139424356d,right: 0.27411012234727594d,bottom: 0.006508651814146615d,left: 0.20606097436672555d),

new NpgsqlTypes.NpgsqlBox(top: 0.9790843749936309d,right: 0.6080590191731867d,bottom: 0.8756197229926815d,left: 0.0755966297128523d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5574512481749323d,right: 0.3977415711854865d,bottom: 0.20732953531729337d,left: 0.133391968738935d),

new NpgsqlTypes.NpgsqlBox(top: 0.6150097949735317d,right: 0.3196547377842953d,bottom: 0.5525383369093174d,left: 0.1483094029687343d),

new NpgsqlTypes.NpgsqlBox(top: 0.9652837746899298d,right: 0.5106754589892841d,bottom: 0.8266795522694113d,left: 0.32767394618000467d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.20177281790583268d,right: 0.8875965579132958d,bottom: 0.10925682798656555d,left: 0.20648071267886858d),

new NpgsqlTypes.NpgsqlBox(top: 0.705520505171011d,right: 0.9846788773179246d,bottom: 0.35758616442407265d,left: 0.7811249097045154d),

new NpgsqlTypes.NpgsqlBox(top: 0.5412547343477544d,right: 0.6216792053474828d,bottom: 0.29869355612670623d,left: 0.4095203071315905d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9998199660878865d,right: 0.2634048380633096d,bottom: 0.8572039036601709d,left: 0.11574162335076743d),

new NpgsqlTypes.NpgsqlBox(top: 0.884567047729453d,right: 0.6272078880686258d,bottom: 0.46322838658616106d,left: 0.6207111341848884d),

new NpgsqlTypes.NpgsqlBox(top: 0.6924888964078894d,right: 0.7107261295603612d,bottom: 0.21506342432286196d,left: 0.6894605478263869d),

new NpgsqlTypes.NpgsqlBox(top: 0.21440504598526677d,right: 0.2311175204128635d,bottom: 0.1765962995590471d,left: 0.002855077599898448d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7207304368292446d,right: 0.6196717638259516d,bottom: 0.1604785982081739d,left: 0.1897762125665463d),

new NpgsqlTypes.NpgsqlBox(top: 0.8542764693269541d,right: 0.2495604257274474d,bottom: 0.12244037660603202d,left: 0.18903572030388016d),

new NpgsqlTypes.NpgsqlBox(top: 0.9401681644251566d,right: 0.8418718932180412d,bottom: 0.6154175189754079d,left: 0.15251420850530117d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6251584226094331d,right: 0.9302997050226587d,bottom: 0.10475218407042963d,left: 0.11379924158296328d),

new NpgsqlTypes.NpgsqlBox(top: 0.754560720388528d,right: 0.7689538871889349d,bottom: 0.38162092340653375d,left: 0.243613173198578d),

new NpgsqlTypes.NpgsqlBox(top: 0.98069304962943d,right: 0.5923360651102356d,bottom: 0.7812696012885567d,left: 0.0588340969775738d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9078634932990869d,right: 0.4139182793380476d,bottom: 0.3911748566544593d,left: 0.3566904856122407d),

new NpgsqlTypes.NpgsqlBox(top: 0.9755620668721379d,right: 0.8815541690695536d,bottom: 0.30795974271548143d,left: 0.0948612574138209d),

new NpgsqlTypes.NpgsqlBox(top: 0.6991837545754938d,right: 0.8746499174961414d,bottom: 0.48147594257204607d,left: 0.69764615636903d),

new NpgsqlTypes.NpgsqlBox(top: 0.7729689874476711d,right: 0.6803571805597518d,bottom: 0.04408898342212708d,left: 0.6031640932108763d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42315126247153234d,right: 0.9007813987182328d,bottom: 0.10424834973392738d,left: 0.49208809909708306d),

new NpgsqlTypes.NpgsqlBox(top: 0.681844517865197d,right: 0.10425304718531692d,bottom: 0.23307462790480693d,left: 0.06548152016276709d),

new NpgsqlTypes.NpgsqlBox(top: 0.8345095785370258d,right: 0.4644049986198824d,bottom: 0.467193706449357d,left: 0.1561370813173354d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9252162277128855d,right: 0.7890267123769127d,bottom: 0.5427128917142146d,left: 0.12106456093013185d),

new NpgsqlTypes.NpgsqlBox(top: 0.285626390009457d,right: 0.5670165322196664d,bottom: 0.14647269675331276d,left: 0.3614101447548549d),

new NpgsqlTypes.NpgsqlBox(top: 0.8588372876582682d,right: 0.043866804578595375d,bottom: 0.8421369917433271d,left: 0.0005306111650253964d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49646477088539576d,right: 0.6867074226423895d,bottom: 0.4957467694842729d,left: 0.14273275444058042d),

new NpgsqlTypes.NpgsqlBox(top: 0.7184022818776229d,right: 0.3735710098335523d,bottom: 0.457214508948958d,left: 0.1781792893716876d),

new NpgsqlTypes.NpgsqlBox(top: 0.8419621848113743d,right: 0.47468917557275525d,bottom: 0.25697976084343255d,left: 0.2758762490345418d),

new NpgsqlTypes.NpgsqlBox(top: 0.7509624003298836d,right: 0.886258098136811d,bottom: 0.11347582124846867d,left: 0.3580527761854656d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5107155866372575d,right: 0.9795476648075138d,bottom: 0.3490221885262853d,left: 0.13897526023587237d),

new NpgsqlTypes.NpgsqlBox(top: 0.9925777798896233d,right: 0.8536813580237408d,bottom: 0.5811235344250324d,left: 0.24079075445135745d),

new NpgsqlTypes.NpgsqlBox(top: 0.6115685569992719d,right: 0.448555009204215d,bottom: 0.09265503728700031d,left: 0.43447533907333236d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5382614082430656d,right: 0.7917100010081994d,bottom: 0.27470501431936534d,left: 0.4522273136775318d),

new NpgsqlTypes.NpgsqlBox(top: 0.7314493562547713d,right: 0.8018086534489478d,bottom: 0.019674087858713718d,left: 0.16301584119693835d),

new NpgsqlTypes.NpgsqlBox(top: 0.8524917510307568d,right: 0.5733023713680557d,bottom: 0.3420409157329537d,left: 0.15521856442327042d),

new NpgsqlTypes.NpgsqlBox(top: 0.39637730739405697d,right: 0.6495998404369763d,bottom: 0.38878058318733977d,left: 0.5324415702209433d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9431483805002706d,right: 0.5353908399232051d,bottom: 0.4223083593233291d,left: 0.033479432012174626d),

new NpgsqlTypes.NpgsqlBox(top: 0.1638167090805449d,right: 0.5521992465029887d,bottom: 0.09340757310342096d,left: 0.3345021930489078d),

new NpgsqlTypes.NpgsqlBox(top: 0.43934955329096137d,right: 0.5312177626867065d,bottom: 0.23247780147984698d,left: 0.47884657592657076d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxlistd1e2mi_id", 
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
                List<NpgsqlBoxboxListD1E2M> models = null;

                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxListD1E2M> models = null;

                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[34], false);
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
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 127, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 26, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 163, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 99, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 133, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 137, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatch(connection, 14, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models = await ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[18], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[19], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[20], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[21], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[22], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[23], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[24], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[25], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[26], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[27], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[28], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[29], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[30], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[31], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models =  ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[14], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[15], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[16], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[17], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[18], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[19], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[20], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[21], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[22], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[23], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[24], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[25], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[26], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[27], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[28], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[29], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[30], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[31], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
FROM public.binary_npgsqlboxboxlistd1e2m m
LEFT JOIN public.binary_npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxListboxListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI), typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxListD1E2MI>();
                var models2 = new List<NpgsqlBoxboxListD1E2MI>();
                await ((INpgsqlBoxListboxListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MI>();
                var models2 = new List<NpgsqlBoxboxListD1E2MI>();
                ((INpgsqlBoxListboxListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

