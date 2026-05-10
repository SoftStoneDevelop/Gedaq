

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.606372330460809d, y: 0.47745170730963526d), new NpgsqlTypes.NpgsqlPoint(x: 0.05267089761585109d, y: 0.5765657944434522d), new NpgsqlTypes.NpgsqlPoint(x: 0.18408055594028894d, y: 0.38908524295888014d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7084516351904045d, y: 0.26233110005427984d), new NpgsqlTypes.NpgsqlPoint(x: 0.13281949386765945d, y: 0.018495086614739864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572995182331852d, y: 0.37138760933807813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5833410907325662d, y: 0.8719507128001565d), new NpgsqlTypes.NpgsqlPoint(x: 0.2077107759964032d, y: 0.9500961605343968d), new NpgsqlTypes.NpgsqlPoint(x: 0.8129780598398447d, y: 0.8780554538287119d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41099026564818764d, y: 0.5492716829110628d), new NpgsqlTypes.NpgsqlPoint(x: 0.07215284340289296d, y: 0.3092942765365263d), new NpgsqlTypes.NpgsqlPoint(x: 0.04121249289058948d, y: 0.259294541930035d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46735119626742727d, y: 0.7565605518072278d), new NpgsqlTypes.NpgsqlPoint(x: 0.4087749576241463d, y: 0.7266245265851475d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311367504249579d, y: 0.7931240013521845d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40162539763457283d, y: 0.45221040639654353d), new NpgsqlTypes.NpgsqlPoint(x: 0.38217826050363857d, y: 0.2510921049721381d), new NpgsqlTypes.NpgsqlPoint(x: 0.6500729645701773d, y: 0.3468711427732447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9520641734790289d, y: 0.00090950084352448d), new NpgsqlTypes.NpgsqlPoint(x: 0.358200777098193d, y: 0.11232337968191564d), new NpgsqlTypes.NpgsqlPoint(x: 0.8591204902464632d, y: 0.6678268006481498d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38273477437516323d, y: 0.9021059562977033d), new NpgsqlTypes.NpgsqlPoint(x: 0.2999095035002174d, y: 0.31008086468119056d), new NpgsqlTypes.NpgsqlPoint(x: 0.5625206386283729d, y: 0.22028967218678686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20821637065182108d, y: 0.982426318312863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962256817984462d, y: 0.6993513525483797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9547879751119842d, y: 0.451916708624704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48360115785240687d, y: 0.813358856870051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557725966710255d, y: 0.7023576900103269d), new NpgsqlTypes.NpgsqlPoint(x: 0.948287424860245d, y: 0.6871425959977878d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.648338500991134d, y: 0.8760639045329263d), new NpgsqlTypes.NpgsqlPoint(x: 0.2902716928896303d, y: 0.7918093460602617d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367857722525697d, y: 0.06110046055979146d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5451812840353447d, y: 0.616545939016242d), new NpgsqlTypes.NpgsqlPoint(x: 0.37261375187149726d, y: 0.7177061814584542d), new NpgsqlTypes.NpgsqlPoint(x: 0.06626265008865406d, y: 0.6537508063209435d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3959624522875107d, y: 0.019052721903429548d), new NpgsqlTypes.NpgsqlPoint(x: 0.3867373667978724d, y: 0.6997702586370204d), new NpgsqlTypes.NpgsqlPoint(x: 0.9037781974808353d, y: 0.2694134232606197d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6221221625440955d, y: 0.09179615577055455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8229596791444065d, y: 0.31623933266781423d), new NpgsqlTypes.NpgsqlPoint(x: 0.45859275191125093d, y: 0.05927267224918764d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16158914164540006d, y: 0.2399950875537884d), new NpgsqlTypes.NpgsqlPoint(x: 0.2237109839785565d, y: 0.3953469681004944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254572136858594d, y: 0.04967184994180818d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7893945727189733d, y: 0.5324235625097702d), new NpgsqlTypes.NpgsqlPoint(x: 0.08601833947228765d, y: 0.7766116590268756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6051054243717571d, y: 0.7197475667591519d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.402160657185057d, y: 0.6591740879885827d), new NpgsqlTypes.NpgsqlPoint(x: 0.4515475773181926d, y: 0.8868914173302437d), new NpgsqlTypes.NpgsqlPoint(x: 0.21632437315741504d, y: 0.8681102188440804d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9913609098000763d, y: 0.47800841123345283d), new NpgsqlTypes.NpgsqlPoint(x: 0.5970964755659715d, y: 0.332068758245496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939179061866146d, y: 0.10117839265729267d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3806104525029884d, y: 0.1060759539610936d), new NpgsqlTypes.NpgsqlPoint(x: 0.20835696555861716d, y: 0.585631699621271d), new NpgsqlTypes.NpgsqlPoint(x: 0.1939157075722442d, y: 0.05146948417359398d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0944982871072475d, y: 0.20828214516514965d), new NpgsqlTypes.NpgsqlPoint(x: 0.85535381239845d, y: 0.21622795749283907d), new NpgsqlTypes.NpgsqlPoint(x: 0.2848350023596824d, y: 0.8778954448905906d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9065968327758731d, y: 0.80691288045674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3998950635357612d, y: 0.20723922839342956d), new NpgsqlTypes.NpgsqlPoint(x: 0.10229828346184555d, y: 0.39695217119197046d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.913054207709914d, y: 0.7215634252920379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6196279271344067d, y: 0.6583792541392569d), new NpgsqlTypes.NpgsqlPoint(x: 0.2391962972556836d, y: 0.12927601457400095d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07667947551218857d, y: 0.3496242819083857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906482985324133d, y: 0.557030105602964d), new NpgsqlTypes.NpgsqlPoint(x: 0.810512682525714d, y: 0.12702194988660886d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21591836131502917d, y: 0.5763513435408449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4098350896517847d, y: 0.7270874251146603d), new NpgsqlTypes.NpgsqlPoint(x: 0.11152089887972505d, y: 0.4981623573149152d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8791037028854604d, y: 0.9258068191246486d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067373990626712d, y: 0.5831602957454224d), new NpgsqlTypes.NpgsqlPoint(x: 0.16558845664738253d, y: 0.16286357594923773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1405580780994925d, y: 0.32147349534038583d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483570432595969d, y: 0.6701656711734071d), new NpgsqlTypes.NpgsqlPoint(x: 0.2075661510973288d, y: 0.90809153982d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24207076801598448d, y: 0.28862958384808335d), new NpgsqlTypes.NpgsqlPoint(x: 0.012296248527568054d, y: 0.512224724431498d), new NpgsqlTypes.NpgsqlPoint(x: 0.6959273622741782d, y: 0.38798857714997215d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4215688634927539d, y: 0.27922411332797115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002896943713154d, y: 0.9106771128546458d), new NpgsqlTypes.NpgsqlPoint(x: 0.010389068144655789d, y: 0.9426144038680537d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9823161250310178d, y: 0.5207484021153058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185919487530335d, y: 0.440313930923225d), new NpgsqlTypes.NpgsqlPoint(x: 0.33387865113021686d, y: 0.6211697903316264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5361313950989733d, y: 0.7110325324083031d), new NpgsqlTypes.NpgsqlPoint(x: 0.7152462608209551d, y: 0.27704285523336747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7027475204352285d, y: 0.0009204370669638751d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5317316769007064d, y: 0.05597784656191118d), new NpgsqlTypes.NpgsqlPoint(x: 0.26418805486210883d, y: 0.763807707621332d), new NpgsqlTypes.NpgsqlPoint(x: 0.22107360406423393d, y: 0.7405231488650118d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4890873607388936d, y: 0.3032661212351453d), new NpgsqlTypes.NpgsqlPoint(x: 0.6342056574162849d, y: 0.8720381725000586d), new NpgsqlTypes.NpgsqlPoint(x: 0.17667341693625338d, y: 0.20622503602766917d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5014059881572809d, y: 0.6925715635290964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6147636409071349d, y: 0.07790572029729481d), new NpgsqlTypes.NpgsqlPoint(x: 0.195443705860608d, y: 0.6882241469707956d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9672509213048023d, y: 0.25332342242583095d), new NpgsqlTypes.NpgsqlPoint(x: 0.11531243940570168d, y: 0.7810611850887308d), new NpgsqlTypes.NpgsqlPoint(x: 0.38158803583895695d, y: 0.569820198899101d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0149267313251491d, y: 0.150967888384547d), new NpgsqlTypes.NpgsqlPoint(x: 0.33708728632367546d, y: 0.47757988520752215d), new NpgsqlTypes.NpgsqlPoint(x: 0.1007321505931531d, y: 0.22082349738923224d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08326035412664246d, y: 0.6019916167361236d), new NpgsqlTypes.NpgsqlPoint(x: 0.10398505076349696d, y: 0.5459000770618087d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864987622006397d, y: 0.2571105350469126d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1348641270808918d, y: 0.8622524773894207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5218403361708351d, y: 0.993702732184854d), new NpgsqlTypes.NpgsqlPoint(x: 0.33973147970900164d, y: 0.4590334320526068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3667949100519349d, y: 0.9545121788212705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092183797698675d, y: 0.773096272528115d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828001510785902d, y: 0.9968145849315966d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9726593749963498d, y: 0.045490796836763936d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865946073866475d, y: 0.8678514472220389d), new NpgsqlTypes.NpgsqlPoint(x: 0.9282905697206512d, y: 0.03257724992732858d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9182404049095019d, y: 0.7885274219201662d), new NpgsqlTypes.NpgsqlPoint(x: 0.8247009604605692d, y: 0.725718031211442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8718549294414641d, y: 0.9188320216907744d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4358382015062099d, y: 0.27032087412096895d), new NpgsqlTypes.NpgsqlPoint(x: 0.24705716620684237d, y: 0.06154605693517334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6431616434351031d, y: 0.9772805597520103d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15752167798486083d, y: 0.8789006823063443d), new NpgsqlTypes.NpgsqlPoint(x: 0.2873819932795211d, y: 0.7637322590743406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6629540370865581d, y: 0.42681539711661853d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8248819879192753d, y: 0.4658627858607891d), new NpgsqlTypes.NpgsqlPoint(x: 0.10256110662863571d, y: 0.45089157004571156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537679410814397d, y: 0.03092713019022164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4767713280887681d, y: 0.9378947614843617d), new NpgsqlTypes.NpgsqlPoint(x: 0.37568798615223975d, y: 0.6920349971364843d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707197648265192d, y: 0.019656719126869726d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.931869777032117d, y: 0.6689774545522932d), new NpgsqlTypes.NpgsqlPoint(x: 0.06815950748947841d, y: 0.9336964257667228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5915050007103321d, y: 0.5780522702862827d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.772354337300041d, y: 0.04266787427542995d), new NpgsqlTypes.NpgsqlPoint(x: 0.5127623013177328d, y: 0.4968696899155145d), new NpgsqlTypes.NpgsqlPoint(x: 0.2758244226199742d, y: 0.6580181930022909d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3287034629273792d, y: 0.787578941268771d), new NpgsqlTypes.NpgsqlPoint(x: 0.14268017097653396d, y: 0.6075662513975771d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809145242294178d, y: 0.337287550531541d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45893561039967434d, y: 0.9580464839047417d), new NpgsqlTypes.NpgsqlPoint(x: 0.1347549570171781d, y: 0.0983803442453407d), new NpgsqlTypes.NpgsqlPoint(x: 0.3602578110740572d, y: 0.9174815221163202d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4378827033655812d, y: 0.9282816496998694d), new NpgsqlTypes.NpgsqlPoint(x: 0.017927789371757208d, y: 0.586770634347149d), new NpgsqlTypes.NpgsqlPoint(x: 0.36760330522082196d, y: 0.14215593295296858d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48319398490537d, y: 0.22824448875112024d), new NpgsqlTypes.NpgsqlPoint(x: 0.021093441997227846d, y: 0.950928817185834d), new NpgsqlTypes.NpgsqlPoint(x: 0.381822752062109d, y: 0.4965264643513221d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5447182799407639d, y: 0.5733252688462036d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121846756089474d, y: 0.9015082602169256d), new NpgsqlTypes.NpgsqlPoint(x: 0.033105387986647195d, y: 0.44729556946568594d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26590306110846196d, y: 0.8684331575236999d), new NpgsqlTypes.NpgsqlPoint(x: 0.48419839164878586d, y: 0.46088561649490345d), new NpgsqlTypes.NpgsqlPoint(x: 0.6975133245450533d, y: 0.25248104548918837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03602896401421829d, y: 0.07407327548165321d), new NpgsqlTypes.NpgsqlPoint(x: 0.06243809494138963d, y: 0.2320490059235485d), new NpgsqlTypes.NpgsqlPoint(x: 0.23633188477856792d, y: 0.5363979057314123d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.920692275944414d, y: 0.7019695009408871d), new NpgsqlTypes.NpgsqlPoint(x: 0.4413379009772743d, y: 0.6023783120120929d), new NpgsqlTypes.NpgsqlPoint(x: 0.18426618426193875d, y: 0.09981005049212344d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13167276242430714d, y: 0.12178212859213244d), new NpgsqlTypes.NpgsqlPoint(x: 0.49895858845149754d, y: 0.8193171766729376d), new NpgsqlTypes.NpgsqlPoint(x: 0.6652032696767518d, y: 0.9813140111869612d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024922584763357625d, y: 0.15403307827033308d), new NpgsqlTypes.NpgsqlPoint(x: 0.6626332525428665d, y: 0.4358877495344802d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535998071129577d, y: 0.8027464217636902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09072050399261788d, y: 0.45896093080872535d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866616043183286d, y: 0.5122806282072291d), new NpgsqlTypes.NpgsqlPoint(x: 0.2614383604619711d, y: 0.8724897821305907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5971876028291889d, y: 0.02597036403414066d), new NpgsqlTypes.NpgsqlPoint(x: 0.3163948031757181d, y: 0.4683475951153009d), new NpgsqlTypes.NpgsqlPoint(x: 0.24344473600325478d, y: 0.7634482428119603d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7043939105470365d, y: 0.4655112813461828d), new NpgsqlTypes.NpgsqlPoint(x: 0.5733675872900124d, y: 0.03875630750414305d), new NpgsqlTypes.NpgsqlPoint(x: 0.42199919570401356d, y: 0.6222096773498648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8271352348037678d, y: 0.12627906233287878d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938946216928137d, y: 0.9546218333686977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983593619920995d, y: 0.6989201498042981d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9391515005042639d, y: 0.2107733336397133d), new NpgsqlTypes.NpgsqlPoint(x: 0.02892283844966803d, y: 0.07670593918664848d), new NpgsqlTypes.NpgsqlPoint(x: 0.16079801176545339d, y: 0.42461375499512977d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9841647292870244d, y: 0.28142312641781897d), new NpgsqlTypes.NpgsqlPoint(x: 0.8795900497546587d, y: 0.12474653037282013d), new NpgsqlTypes.NpgsqlPoint(x: 0.10976282128054837d, y: 0.015149715733115854d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33190410018416616d, y: 0.4417909493367499d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807496811010744d, y: 0.6633789189897928d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495953914183925d, y: 0.6735422436579254d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2812642421244158d, y: 0.8141580188224055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9530550059604199d, y: 0.5217901670326026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277012937641651d, y: 0.5887804939501747d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5879500592647731d, y: 0.3812102287285294d), new NpgsqlTypes.NpgsqlPoint(x: 0.5856747448932069d, y: 0.019325194473162943d), new NpgsqlTypes.NpgsqlPoint(x: 0.48859683790074493d, y: 0.9468716681980786d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7647537776611908d, y: 0.26126895183350607d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179999415158426d, y: 0.622392551021967d), new NpgsqlTypes.NpgsqlPoint(x: 0.022316512839612335d, y: 0.46961067246465205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6464766855794387d, y: 0.43980693561908746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451812305933424d, y: 0.5982511726404268d), new NpgsqlTypes.NpgsqlPoint(x: 0.24185711956327927d, y: 0.09836565117905516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7081599298506153d, y: 0.17912008891147768d), new NpgsqlTypes.NpgsqlPoint(x: 0.3953618438787595d, y: 0.4626509677114662d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988427157740202d, y: 0.29342735851403456d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11965453820080851d, y: 0.8782105475581987d), new NpgsqlTypes.NpgsqlPoint(x: 0.6621386796877364d, y: 0.8850113780373334d), new NpgsqlTypes.NpgsqlPoint(x: 0.66893312959669d, y: 0.11565885453523073d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39384444838401156d, y: 0.5665256714015844d), new NpgsqlTypes.NpgsqlPoint(x: 0.5734124030709058d, y: 0.770505113354179d), new NpgsqlTypes.NpgsqlPoint(x: 0.27855915461826397d, y: 0.23300284130052962d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8698065603932535d, y: 0.8095154697157761d), new NpgsqlTypes.NpgsqlPoint(x: 0.16222565510073905d, y: 0.487089991127689d), new NpgsqlTypes.NpgsqlPoint(x: 0.32005514544976854d, y: 0.21472386656830833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8313040318437384d, y: 0.07698829165737697d), new NpgsqlTypes.NpgsqlPoint(x: 0.04155061358334289d, y: 0.5811656765913186d), new NpgsqlTypes.NpgsqlPoint(x: 0.6075924492610391d, y: 0.2538349067337572d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8957090127636337d, y: 0.4565325649257913d), new NpgsqlTypes.NpgsqlPoint(x: 0.299079866349067d, y: 0.32017787778408513d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437890912063428d, y: 0.7704954650820353d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16911468861305068d, y: 0.6636840564659892d), new NpgsqlTypes.NpgsqlPoint(x: 0.633674706568266d, y: 0.497284116815326d), new NpgsqlTypes.NpgsqlPoint(x: 0.35889620508099784d, y: 0.7482886043954772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6137391947955031d, y: 0.4343053128350526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638514995842962d, y: 0.8397286393258155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8702656748842518d, y: 0.6516118289439945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8500558054564806d, y: 0.22262666188715086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6666671014106584d, y: 0.3798232521184929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649425938929681d, y: 0.07437578760760621d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26738168230778925d, y: 0.17382268259530576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4571986523178353d, y: 0.5640589227915118d), new NpgsqlTypes.NpgsqlPoint(x: 0.04142283406372338d, y: 0.2269498610107904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4519891454297599d, y: 0.02828136217118038d), new NpgsqlTypes.NpgsqlPoint(x: 0.3805992373074345d, y: 0.7845896586352887d), new NpgsqlTypes.NpgsqlPoint(x: 0.598606461241807d, y: 0.5756565650494762d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7138416357797754d, y: 0.6075800675544207d), new NpgsqlTypes.NpgsqlPoint(x: 0.02600958967419853d, y: 0.010502199968703385d), new NpgsqlTypes.NpgsqlPoint(x: 0.17168361713779468d, y: 0.6042874458519659d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45059346918741316d, y: 0.8370633392428904d), new NpgsqlTypes.NpgsqlPoint(x: 0.40060704480753107d, y: 0.24027906047977066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6724561955522415d, y: 0.18996803462258072d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6646025928420053d, y: 0.9373655763648793d), new NpgsqlTypes.NpgsqlPoint(x: 0.13681964244399492d, y: 0.9439006452957691d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068385282200364d, y: 0.9391133280841222d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.656448463700367d, y: 0.7960784753772107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5717186297206853d, y: 0.3781275587909444d), new NpgsqlTypes.NpgsqlPoint(x: 0.5462297708319742d, y: 0.33433372834809405d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8784562943455959d, y: 0.9071666059131724d), new NpgsqlTypes.NpgsqlPoint(x: 0.03342735860855195d, y: 0.8025960639373673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7657839972174575d, y: 0.4676907886139393d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7794437993558263d, y: 0.15714259683523535d), new NpgsqlTypes.NpgsqlPoint(x: 0.4960407552294368d, y: 0.33086130457688634d), new NpgsqlTypes.NpgsqlPoint(x: 0.7869539203132213d, y: 0.5492754210794514d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6212592207702419d, y: 0.036419496400677764d), new NpgsqlTypes.NpgsqlPoint(x: 0.022193548849847367d, y: 0.3559215521056296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5016913587750265d, y: 0.8472252322964153d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6468731987908806d, y: 0.13529519737123064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391786500300647d, y: 0.010860613703252753d), new NpgsqlTypes.NpgsqlPoint(x: 0.492354611643388d, y: 0.4704779110847792d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05707926610865166d, y: 0.7973022357271831d), new NpgsqlTypes.NpgsqlPoint(x: 0.13823919392202022d, y: 0.2402484041759807d), new NpgsqlTypes.NpgsqlPoint(x: 0.45819573234691524d, y: 0.6465746655676805d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43235432370814064d, y: 0.9214231947845866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002567064922403d, y: 0.45533179467867735d), new NpgsqlTypes.NpgsqlPoint(x: 0.934285037938142d, y: 0.6680420282084222d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7499922989953476d, y: 0.866344995887058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7669536232061386d, y: 0.18580787416361377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4519006849090109d, y: 0.9116814623187354d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027663139026853023d, y: 0.04255123174348552d), new NpgsqlTypes.NpgsqlPoint(x: 0.3360161518727801d, y: 0.2520517722294444d), new NpgsqlTypes.NpgsqlPoint(x: 0.06089317552246498d, y: 0.05442971598774726d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8502094044450319d, y: 0.24718560384207722d), new NpgsqlTypes.NpgsqlPoint(x: 0.13253611347000105d, y: 0.9106283081754546d), new NpgsqlTypes.NpgsqlPoint(x: 0.13434189934852814d, y: 0.902987123934383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7162948755827732d, y: 0.5714450299237379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6761625878585832d, y: 0.2776251247644449d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525466064617222d, y: 0.5681090338218432d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4937576332608151d, y: 0.3630220267988561d), new NpgsqlTypes.NpgsqlPoint(x: 0.9891639864990779d, y: 0.1890409108882053d), new NpgsqlTypes.NpgsqlPoint(x: 0.28743721379114895d, y: 0.9946559436040776d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222314390306677d, y: 0.4001104814796095d), new NpgsqlTypes.NpgsqlPoint(x: 0.3984650030820118d, y: 0.049084634454666376d), new NpgsqlTypes.NpgsqlPoint(x: 0.28412199183736864d, y: 0.5269733682313815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8616112358470226d, y: 0.5510631806895747d), new NpgsqlTypes.NpgsqlPoint(x: 0.24528244269349375d, y: 0.3520549929114717d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223260514587758d, y: 0.7416471415794685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39720852837429865d, y: 0.26086505456725195d), new NpgsqlTypes.NpgsqlPoint(x: 0.14925816949032533d, y: 0.1332233811901028d), new NpgsqlTypes.NpgsqlPoint(x: 0.8478026582200963d, y: 0.8405140764722256d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6310513247415097d, y: 0.5777183314780815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5830937798621582d, y: 0.5425951571938245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9666517937722442d, y: 0.6594025388005761d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14883557080409593d, y: 0.9899270849134163d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752969549046459d, y: 0.039133310987385816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628696620333838d, y: 0.1119334649927407d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3096707123932162d, y: 0.2610282109362524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9820840834331311d, y: 0.32123144994198227d), new NpgsqlTypes.NpgsqlPoint(x: 0.9252211437286693d, y: 0.28839821330663284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9285508374344337d, y: 0.8081771751334185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4556799429617414d, y: 0.06235869841979291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013078816614762d, y: 0.7330849984799597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07456637242187303d, y: 0.7461741934465063d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204414401195911d, y: 0.601306619440935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6891286075776972d, y: 0.3593847427442243d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7868710078007414d, y: 0.04006240275066897d), new NpgsqlTypes.NpgsqlPoint(x: 0.4891127676068874d, y: 0.14695307031445226d), new NpgsqlTypes.NpgsqlPoint(x: 0.17703753576878556d, y: 0.040850270505878084d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26410045907586077d, y: 0.22008888040155727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6453684754659615d, y: 0.9126988992935046d), new NpgsqlTypes.NpgsqlPoint(x: 0.030662362970718893d, y: 0.6534884106186979d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8819681982369818d, y: 0.9641321075336848d), new NpgsqlTypes.NpgsqlPoint(x: 0.3883442727290166d, y: 0.1545057149861513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4230419839174092d, y: 0.9976936640304597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7034316058833139d, y: 0.2798213442621471d), new NpgsqlTypes.NpgsqlPoint(x: 0.8828751459039486d, y: 0.17255097851892298d), new NpgsqlTypes.NpgsqlPoint(x: 0.15838794893111152d, y: 0.3039761171666455d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26706489001547806d, y: 0.7633155377323368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899325847086807d, y: 0.6480836615616248d), new NpgsqlTypes.NpgsqlPoint(x: 0.7984900342991147d, y: 0.06288428165665394d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07290933267362842d, y: 0.9861067697348435d), new NpgsqlTypes.NpgsqlPoint(x: 0.36874537759595305d, y: 0.8466833553887548d), new NpgsqlTypes.NpgsqlPoint(x: 0.998216793225265d, y: 0.7537855326429388d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6813334413913741d, y: 0.7350099568760039d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273960040253254d, y: 0.004399592937818775d), new NpgsqlTypes.NpgsqlPoint(x: 0.004604922118308874d, y: 0.11899910775936207d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42855686217967925d, y: 0.8625995743076271d), new NpgsqlTypes.NpgsqlPoint(x: 0.33622154219755473d, y: 0.2543728783795398d), new NpgsqlTypes.NpgsqlPoint(x: 0.7819568199534244d, y: 0.16289060068707772d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.782937653312407d, y: 0.14683345339208675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908001204616778d, y: 0.20820994230290224d), new NpgsqlTypes.NpgsqlPoint(x: 0.1556627820868327d, y: 0.6851721394810895d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7688398263260827d, y: 0.2509780753227898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7949476493114401d, y: 0.6434484664896041d), new NpgsqlTypes.NpgsqlPoint(x: 0.06971362019647298d, y: 0.8636923240100107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.799967744458366d, y: 0.5050676780593053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231863341658115d, y: 0.18746680894386814d), new NpgsqlTypes.NpgsqlPoint(x: 0.7747286530713651d, y: 0.68874066513108d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5565726537819006d, y: 0.7124057305636103d), new NpgsqlTypes.NpgsqlPoint(x: 0.2618897024974526d, y: 0.7262924010810912d), new NpgsqlTypes.NpgsqlPoint(x: 0.1671085081706415d, y: 0.9370194256312133d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7560373929405602d, y: 0.13617747501107924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7243852040198825d, y: 0.0850333858219684d), new NpgsqlTypes.NpgsqlPoint(x: 0.4236626494891679d, y: 0.015350033100888671d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32996030068947657d, y: 0.30773199686251107d), new NpgsqlTypes.NpgsqlPoint(x: 0.10507990180669602d, y: 0.09746342211296632d), new NpgsqlTypes.NpgsqlPoint(x: 0.4040667162439887d, y: 0.7404663982310374d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44612840569122647d, y: 0.6369925038408042d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765811240568955d, y: 0.1792204172467674d), new NpgsqlTypes.NpgsqlPoint(x: 0.1873361621422419d, y: 0.7586178871826199d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03781477742622885d, y: 0.49352189494989585d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613943672511284d, y: 0.03214246324634429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633504834391597d, y: 0.15906830212757683d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7643484561275915d, y: 0.7356374955607434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528518662452066d, y: 0.11430504858078916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8208890394597091d, y: 0.8045221930438314d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27231347268239414d, y: 0.8658469568682449d), new NpgsqlTypes.NpgsqlPoint(x: 0.06137219800474014d, y: 0.2907239057481007d), new NpgsqlTypes.NpgsqlPoint(x: 0.45858572235673223d, y: 0.6903285883655592d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6755369365053603d, y: 0.14728281991286418d), new NpgsqlTypes.NpgsqlPoint(x: 0.8427035408366792d, y: 0.09073075964743849d), new NpgsqlTypes.NpgsqlPoint(x: 0.04683265896086497d, y: 0.4638649323613744d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354446508835357d, y: 0.00035057189838860747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8952903567379621d, y: 0.8181853071113829d), new NpgsqlTypes.NpgsqlPoint(x: 0.04675375628931744d, y: 0.30284512419983556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08511735587592362d, y: 0.48314469321518716d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383199785123263d, y: 0.770933064273254d), new NpgsqlTypes.NpgsqlPoint(x: 0.22425093834651244d, y: 0.7786645104696062d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8435392456741666d, y: 0.1608790876989985d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105682111301294d, y: 0.5487898729626981d), new NpgsqlTypes.NpgsqlPoint(x: 0.26566090682010746d, y: 0.769700770552564d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.871046041201513d, y: 0.9257155629273317d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189645089164121d, y: 0.048841848616396955d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277187049544074d, y: 0.9213321528847643d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693737812661571d, y: 0.20066320961712425d), new NpgsqlTypes.NpgsqlPoint(x: 0.6586480972042908d, y: 0.24335920580584858d), new NpgsqlTypes.NpgsqlPoint(x: 0.8240697147305865d, y: 0.49065454161899213d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41415904172120743d, y: 0.5880046149667749d), new NpgsqlTypes.NpgsqlPoint(x: 0.37522421745047096d, y: 0.4895725888997675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8065877145892736d, y: 0.1862563355387763d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6418694513104228d, y: 0.7051245509739513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6513136393562643d, y: 0.6172367286478339d), new NpgsqlTypes.NpgsqlPoint(x: 0.45911297472421364d, y: 0.9385356996180273d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34291103908800424d, y: 0.8086415000574112d), new NpgsqlTypes.NpgsqlPoint(x: 0.21377830604355308d, y: 0.8749089895528054d), new NpgsqlTypes.NpgsqlPoint(x: 0.9601549868735335d, y: 0.6968356432747487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12705837473021908d, y: 0.8795141482946363d), new NpgsqlTypes.NpgsqlPoint(x: 0.1897107810583003d, y: 0.26255876116239596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639132884333528d, y: 0.06881692492227554d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47945077278224524d, y: 0.7319476108085308d), new NpgsqlTypes.NpgsqlPoint(x: 0.27195519685923164d, y: 0.3215653863854804d), new NpgsqlTypes.NpgsqlPoint(x: 0.23870394195317335d, y: 0.615493830385685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33169532080709785d, y: 0.463218562622543d), new NpgsqlTypes.NpgsqlPoint(x: 0.6632285459820396d, y: 0.29790058710038636d), new NpgsqlTypes.NpgsqlPoint(x: 0.32804950276166933d, y: 0.7679380402877171d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2895548858756063d, y: 0.36896801124474254d), new NpgsqlTypes.NpgsqlPoint(x: 0.0070457741693643605d, y: 0.8365124400156468d), new NpgsqlTypes.NpgsqlPoint(x: 0.43864651862598536d, y: 0.3856555799799103d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5629709670770865d, y: 0.10029212220223427d), new NpgsqlTypes.NpgsqlPoint(x: 0.09950454157857325d, y: 0.49871249025904774d), new NpgsqlTypes.NpgsqlPoint(x: 0.06478001247221288d, y: 0.5355827690030293d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.122102787523374d, y: 0.42573075702154806d), new NpgsqlTypes.NpgsqlPoint(x: 0.524737057126918d, y: 0.11147036529825616d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412025062202898d, y: 0.5051002250817107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1327687779956962d, y: 0.9935665074839545d), new NpgsqlTypes.NpgsqlPoint(x: 0.26657504331223025d, y: 0.0804388637322263d), new NpgsqlTypes.NpgsqlPoint(x: 0.528250124360599d, y: 0.19416383389144765d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4278410087120833d, y: 0.2936180099648239d), new NpgsqlTypes.NpgsqlPoint(x: 0.01223882568230139d, y: 0.14097994853586204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387680308923033d, y: 0.2214906045215027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3358660540699344d, y: 0.16777852619096212d), new NpgsqlTypes.NpgsqlPoint(x: 0.18117102294742682d, y: 0.8597955604802864d), new NpgsqlTypes.NpgsqlPoint(x: 0.44543426098486905d, y: 0.14441697091161598d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07365974742679227d, y: 0.7685862492885774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278163903033055d, y: 0.5426738248693934d), new NpgsqlTypes.NpgsqlPoint(x: 0.3069303666505123d, y: 0.1978931256333003d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022484085674696397d, y: 0.8817710092263772d), new NpgsqlTypes.NpgsqlPoint(x: 0.2663355454332652d, y: 0.0038761715361358418d), new NpgsqlTypes.NpgsqlPoint(x: 0.18593505533087196d, y: 0.5712843851657233d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.539848778334302d, y: 0.3753837046248868d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530033412184826d, y: 0.7633593559389842d), new NpgsqlTypes.NpgsqlPoint(x: 0.3081796071393339d, y: 0.7330741330511205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9725864076068306d, y: 0.6813652996831245d), new NpgsqlTypes.NpgsqlPoint(x: 0.2065550633009785d, y: 0.5866027128193174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441445454092572d, y: 0.6628429904551166d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4190960996145259d, y: 0.3955662310319449d), new NpgsqlTypes.NpgsqlPoint(x: 0.12385386595242331d, y: 0.0159428498854578d), new NpgsqlTypes.NpgsqlPoint(x: 0.2043586626650492d, y: 0.5071480776433953d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7517111407117308d, y: 0.07605977585621193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101641991500967d, y: 0.7187373229133047d), new NpgsqlTypes.NpgsqlPoint(x: 0.06344189956296031d, y: 0.45215023851599034d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9082543224902094d, y: 0.26611277298772285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337141654866584d, y: 0.8850190367937262d), new NpgsqlTypes.NpgsqlPoint(x: 0.18141427611576721d, y: 0.23983878172713935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24859236307830168d, y: 0.13050954330328268d), new NpgsqlTypes.NpgsqlPoint(x: 0.2622610868821661d, y: 0.610905580154526d), new NpgsqlTypes.NpgsqlPoint(x: 0.4875877912929999d, y: 0.23502508850392367d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5240640093492285d, y: 0.22416385030680297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440655032899522d, y: 0.9302022288912455d), new NpgsqlTypes.NpgsqlPoint(x: 0.3205141465384259d, y: 0.9353295037473821d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6948149198666425d, y: 0.7702752807745662d), new NpgsqlTypes.NpgsqlPoint(x: 0.9110724306763154d, y: 0.9783329901509897d), new NpgsqlTypes.NpgsqlPoint(x: 0.41377329754202385d, y: 0.3478087290903529d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07006974101195584d, y: 0.39525279636817123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178804200050513d, y: 0.9592142925960282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3846060444742745d, y: 0.7359823005646515d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3615100675001872d, y: 0.19072766151992393d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581567125256403d, y: 0.9622303809984344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7675104345479716d, y: 0.1989914710108186d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9132008562262727d, y: 0.5034874570632086d), new NpgsqlTypes.NpgsqlPoint(x: 0.539141340397511d, y: 0.23185668136997184d), new NpgsqlTypes.NpgsqlPoint(x: 0.18375604455884142d, y: 0.4207372940748556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8463549982796397d, y: 0.3804228262950857d), new NpgsqlTypes.NpgsqlPoint(x: 0.07107885187024987d, y: 0.9829805730519756d), new NpgsqlTypes.NpgsqlPoint(x: 0.1776515246612963d, y: 0.31513649638806995d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46973740447501955d, y: 0.9041117757489464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6121103705591726d, y: 0.6460379167804005d), new NpgsqlTypes.NpgsqlPoint(x: 0.4043836956053948d, y: 0.8168987123850407d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9257161041606229d, y: 0.8700753385993943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733683291153761d, y: 0.5442816347979126d), new NpgsqlTypes.NpgsqlPoint(x: 0.07872996524762266d, y: 0.7241749635420016d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7211354054645677d, y: 0.9568026952628037d), new NpgsqlTypes.NpgsqlPoint(x: 0.5856470800717533d, y: 0.11814823575348232d), new NpgsqlTypes.NpgsqlPoint(x: 0.5968329889843474d, y: 0.5248223566073068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9477514216503989d, y: 0.8133303498584623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766999680228052d, y: 0.7306909879616662d), new NpgsqlTypes.NpgsqlPoint(x: 0.02894995569740566d, y: 0.44841378279158584d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8899202570488652d, y: 0.13165025676011577d), new NpgsqlTypes.NpgsqlPoint(x: 0.3415972183437368d, y: 0.3490492706756352d), new NpgsqlTypes.NpgsqlPoint(x: 0.3530989198306689d, y: 0.4456623211043437d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3816191907829396d, y: 0.16147802044201753d), new NpgsqlTypes.NpgsqlPoint(x: 0.6556621530719899d, y: 0.14678454878179192d), new NpgsqlTypes.NpgsqlPoint(x: 0.03453312445570511d, y: 0.6776581651147067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24816510456521113d, y: 0.6447542388225936d), new NpgsqlTypes.NpgsqlPoint(x: 0.943816745493397d, y: 0.3758204186258457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9724185516377607d, y: 0.5660003941397048d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48754113833019597d, y: 0.1687794310543318d), new NpgsqlTypes.NpgsqlPoint(x: 0.2489477045835332d, y: 0.580260092953988d), new NpgsqlTypes.NpgsqlPoint(x: 0.5224472667774279d, y: 0.9403367736152962d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9686962578044478d, y: 0.806166651993936d), new NpgsqlTypes.NpgsqlPoint(x: 0.39047272397512134d, y: 0.133278035705518d), new NpgsqlTypes.NpgsqlPoint(x: 0.015836043750125595d, y: 0.7700892362520243d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34934184199363927d, y: 0.2151383606515732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535810022237862d, y: 0.7916401221689703d), new NpgsqlTypes.NpgsqlPoint(x: 0.15307637944781816d, y: 0.2777701630895869d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5103304351692178d, y: 0.8108633713894943d), new NpgsqlTypes.NpgsqlPoint(x: 0.6789184046475772d, y: 0.46056212193477575d), new NpgsqlTypes.NpgsqlPoint(x: 0.26518568126379893d, y: 0.9622088823898077d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.668082075227045d, y: 0.8056625987411735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079052235280683d, y: 0.10795415793862251d), new NpgsqlTypes.NpgsqlPoint(x: 0.2337520778788016d, y: 0.9173498364328162d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5896829255672609d, y: 0.5671512899530329d), new NpgsqlTypes.NpgsqlPoint(x: 0.772812833196829d, y: 0.1021693244504569d), new NpgsqlTypes.NpgsqlPoint(x: 0.4852440547028938d, y: 0.12281215890466102d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05786728772836802d, y: 0.9557360899358429d), new NpgsqlTypes.NpgsqlPoint(x: 0.0830988989123772d, y: 0.9538234576789651d), new NpgsqlTypes.NpgsqlPoint(x: 0.24531064684873427d, y: 0.5632436666844092d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2749089864952865d, y: 0.5369770990521059d), new NpgsqlTypes.NpgsqlPoint(x: 0.261222319556619d, y: 0.904554357747636d), new NpgsqlTypes.NpgsqlPoint(x: 0.12944902809051062d, y: 0.25761112214260107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5293894778833644d, y: 0.8446672912516326d), new NpgsqlTypes.NpgsqlPoint(x: 0.33255211271613005d, y: 0.3166354144183089d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799398131953283d, y: 0.459899876718306d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477366389602066d, y: 0.6989231064906217d), new NpgsqlTypes.NpgsqlPoint(x: 0.3301859109427937d, y: 0.9389204047094071d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070692025469265d, y: 0.48457416878568016d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5536274853975846d, y: 0.7940563284743022d), new NpgsqlTypes.NpgsqlPoint(x: 0.351146292402032d, y: 0.4859214609395488d), new NpgsqlTypes.NpgsqlPoint(x: 0.16726432005239467d, y: 0.31244545737887397d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6661502662315117d, y: 0.3032684028702817d), new NpgsqlTypes.NpgsqlPoint(x: 0.4313219599009154d, y: 0.3212230451140411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236252249568778d, y: 0.09656588567197266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6381310526654941d, y: 0.9743046922539517d), new NpgsqlTypes.NpgsqlPoint(x: 0.47479360997252695d, y: 0.0749029632763697d), new NpgsqlTypes.NpgsqlPoint(x: 0.22941780834937653d, y: 0.03677022258615614d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8964961415047648d, y: 0.5212957175013165d), new NpgsqlTypes.NpgsqlPoint(x: 0.363950428610915d, y: 0.81953111176327d), new NpgsqlTypes.NpgsqlPoint(x: 0.03459191657303495d, y: 0.8567860244574611d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6825045667924459d, y: 0.22470408084852456d), new NpgsqlTypes.NpgsqlPoint(x: 0.40924988168995247d, y: 0.8742342047903107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708735727487356d, y: 0.5511885443085672d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15932942439552444d, y: 0.6113593250650441d), new NpgsqlTypes.NpgsqlPoint(x: 0.29401856386231506d, y: 0.533328869737102d), new NpgsqlTypes.NpgsqlPoint(x: 0.7228101892378324d, y: 0.7010835087224461d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7232816452483367d, y: 0.04039150215411491d), new NpgsqlTypes.NpgsqlPoint(x: 0.2896596004189035d, y: 0.9327626072885344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6174821389011325d, y: 0.0824230557997001d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6864800415820569d, y: 0.7604754458450471d), new NpgsqlTypes.NpgsqlPoint(x: 0.06106286786356119d, y: 0.740100719434034d), new NpgsqlTypes.NpgsqlPoint(x: 0.46599273616337555d, y: 0.6387671504344414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5760731261385215d, y: 0.9893629365313545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9803826067142953d, y: 0.6872775392372719d), new NpgsqlTypes.NpgsqlPoint(x: 0.88111226821212d, y: 0.047729815465412884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7096810898431105d, y: 0.6117253130676167d), new NpgsqlTypes.NpgsqlPoint(x: 0.03593353375333397d, y: 0.8407017961914165d), new NpgsqlTypes.NpgsqlPoint(x: 0.0353281452728178d, y: 0.6711376454671626d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7087441429095868d, y: 0.271734310258847d), new NpgsqlTypes.NpgsqlPoint(x: 0.8547025066350007d, y: 0.9359065375535166d), new NpgsqlTypes.NpgsqlPoint(x: 0.939542247359564d, y: 0.7262769162082021d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23335091815732567d, y: 0.028924741047308244d), new NpgsqlTypes.NpgsqlPoint(x: 0.2788839024088938d, y: 0.8057249484461817d), new NpgsqlTypes.NpgsqlPoint(x: 0.1611959389015094d, y: 0.45132682559687565d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02860619940996756d, y: 0.5469468820932691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6275617976660569d, y: 0.7016218181741195d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833140328760832d, y: 0.27718689995713064d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8710731233446041d, y: 0.356012322833715d), new NpgsqlTypes.NpgsqlPoint(x: 0.09280788458528744d, y: 0.2981670107196064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587072560285224d, y: 0.10047125700226667d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7900283609789452d, y: 0.36647372702431347d), new NpgsqlTypes.NpgsqlPoint(x: 0.3502046034284021d, y: 0.1981914967238908d), new NpgsqlTypes.NpgsqlPoint(x: 0.6473063301433102d, y: 0.6787093297999938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5412361433703076d, y: 0.2801443422950878d), new NpgsqlTypes.NpgsqlPoint(x: 0.28074918863864706d, y: 0.5468052096606297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822299103731669d, y: 0.6788846338326848d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5638908146583428d, y: 0.17440723606622155d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368590826764146d, y: 0.914334584570143d), new NpgsqlTypes.NpgsqlPoint(x: 0.48942941449347266d, y: 0.17155451527521048d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7358135894032831d, y: 0.45761134283443505d), new NpgsqlTypes.NpgsqlPoint(x: 0.535839402673987d, y: 0.10721920620271941d), new NpgsqlTypes.NpgsqlPoint(x: 0.3247180753599973d, y: 0.6179607411737981d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7837741871413955d, y: 0.9624300235961212d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537488073313065d, y: 0.5229269606622817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3421692647385467d, y: 0.048912360574640545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5964349034349334d, y: 0.34713286867599713d), new NpgsqlTypes.NpgsqlPoint(x: 0.2874299672924584d, y: 0.7976375620112494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774954177787197d, y: 0.5614185851614266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09045154156946922d, y: 0.2967277623076886d), new NpgsqlTypes.NpgsqlPoint(x: 0.09598353276983107d, y: 0.36702583487327967d), new NpgsqlTypes.NpgsqlPoint(x: 0.17091624101669334d, y: 0.5638817676551614d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8883389159884373d, y: 0.16282382890446023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409847047305854d, y: 0.25744183876756455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236316466503549d, y: 0.2454445684131148d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.327195742309596d, y: 0.0531440550704122d), new NpgsqlTypes.NpgsqlPoint(x: 0.1264701656677104d, y: 0.6327742966544214d), new NpgsqlTypes.NpgsqlPoint(x: 0.15508426890265714d, y: 0.24920690416901414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.901073917580088d, y: 0.05512121950421178d), new NpgsqlTypes.NpgsqlPoint(x: 0.037361817014561094d, y: 0.35302887636812796d), new NpgsqlTypes.NpgsqlPoint(x: 0.6585329425193166d, y: 0.7106918754663505d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.697297352575436d, y: 0.356997032259061d), new NpgsqlTypes.NpgsqlPoint(x: 0.6555097189832615d, y: 0.070157492276536d), new NpgsqlTypes.NpgsqlPoint(x: 0.4388153526186621d, y: 0.6854069962312564d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7955075375547913d, y: 0.7249420712054445d), new NpgsqlTypes.NpgsqlPoint(x: 0.26450187298428374d, y: 0.20967854809700115d), new NpgsqlTypes.NpgsqlPoint(x: 0.17298130411773815d, y: 0.44447192363353927d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.279055147025688d, y: 0.3647008683999021d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389523730760444d, y: 0.7375306820770462d), new NpgsqlTypes.NpgsqlPoint(x: 0.41063567659326883d, y: 0.4140543591810495d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7313007327403075d, y: 0.9263141668645498d), new NpgsqlTypes.NpgsqlPoint(x: 0.7266845692813441d, y: 0.1517213201958536d), new NpgsqlTypes.NpgsqlPoint(x: 0.36749237812759816d, y: 0.5642917264483037d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35535310372171314d, y: 0.9445438198811271d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084292430009806d, y: 0.41879886280758516d), new NpgsqlTypes.NpgsqlPoint(x: 0.04741789998010493d, y: 0.6981535720839871d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4746166220389435d, y: 0.7945752621820859d), new NpgsqlTypes.NpgsqlPoint(x: 0.783411633722669d, y: 0.24209566723061116d), new NpgsqlTypes.NpgsqlPoint(x: 0.84860607478429d, y: 0.45690480779790965d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7725039524581053d, y: 0.12776134787460758d), new NpgsqlTypes.NpgsqlPoint(x: 0.058554464761263136d, y: 0.055063251919548084d), new NpgsqlTypes.NpgsqlPoint(x: 0.01607052231010886d, y: 0.7433084670670772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19168418601231652d, y: 0.8688767677679561d), new NpgsqlTypes.NpgsqlPoint(x: 0.25483427809321635d, y: 0.9019213240276207d), new NpgsqlTypes.NpgsqlPoint(x: 0.795149738258673d, y: 0.6925624726742714d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20254452397766065d, y: 0.22775502221319277d), new NpgsqlTypes.NpgsqlPoint(x: 0.18746918229795073d, y: 0.08992232412101941d), new NpgsqlTypes.NpgsqlPoint(x: 0.14834104732098152d, y: 0.03709992346616775d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4025437435476905d, y: 0.06979645534847834d), new NpgsqlTypes.NpgsqlPoint(x: 0.3852663599131271d, y: 0.7963710896640334d), new NpgsqlTypes.NpgsqlPoint(x: 0.08901466378203138d, y: 0.3046657305189846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9242448852527789d, y: 0.5553574174165846d), new NpgsqlTypes.NpgsqlPoint(x: 0.956733497452697d, y: 0.7279846223160457d), new NpgsqlTypes.NpgsqlPoint(x: 0.2152477189888573d, y: 0.388668580261892d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5314955741216703d, y: 0.42497479907816094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7847378494237702d, y: 0.45524101428978847d), new NpgsqlTypes.NpgsqlPoint(x: 0.42781708413385033d, y: 0.8726196365129384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7049969308413379d, y: 0.5782295709845123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6041594714402566d, y: 0.17689943871636005d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668535784086632d, y: 0.414423096385798d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9415239031658329d, y: 0.5464260275874522d), new NpgsqlTypes.NpgsqlPoint(x: 0.910641135814764d, y: 0.29052597061615026d), new NpgsqlTypes.NpgsqlPoint(x: 0.5052654694782505d, y: 0.9264808929647028d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9827304366316477d, y: 0.534571103152867d), new NpgsqlTypes.NpgsqlPoint(x: 0.799637441591383d, y: 0.893421577819164d), new NpgsqlTypes.NpgsqlPoint(x: 0.33411094217857296d, y: 0.8003732064357608d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03527072442883217d, y: 0.045837245982966235d), new NpgsqlTypes.NpgsqlPoint(x: 0.35588210713712065d, y: 0.4627728997252867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6463175635380565d, y: 0.05819107443678828d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9986439379408856d, y: 0.2213997815546861d), new NpgsqlTypes.NpgsqlPoint(x: 0.6722553426008896d, y: 0.10711695283183698d), new NpgsqlTypes.NpgsqlPoint(x: 0.3626572372769764d, y: 0.03658698082194578d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07434199128485364d, y: 0.9335081721532319d), new NpgsqlTypes.NpgsqlPoint(x: 0.2209876992291825d, y: 0.07383585313312602d), new NpgsqlTypes.NpgsqlPoint(x: 0.8027069044371191d, y: 0.18996058985739317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5507236162243182d, y: 0.5154590307657869d), new NpgsqlTypes.NpgsqlPoint(x: 0.533587233180748d, y: 0.4885922574584266d), new NpgsqlTypes.NpgsqlPoint(x: 0.4134351410268231d, y: 0.10593156315841523d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7270444718840371d, y: 0.8547393907065326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652579509180659d, y: 0.2815583730500686d), new NpgsqlTypes.NpgsqlPoint(x: 0.41474217098110566d, y: 0.4402274214687619d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9662069373785854d, y: 0.5870362265893556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8094920748593352d, y: 0.4847472186359677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586342750045636d, y: 0.2517127999044837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9356808950247402d, y: 0.3736143193924707d), new NpgsqlTypes.NpgsqlPoint(x: 0.962200642599187d, y: 0.20044243438905096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746733044708348d, y: 0.5351193464184723d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8641271686164304d, y: 0.647217635317378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3920270143548109d, y: 0.8659019205167643d), new NpgsqlTypes.NpgsqlPoint(x: 0.8841565109064867d, y: 0.32793747292266995d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3542461118671828d, y: 0.26800748610084846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9396770063920252d, y: 0.8739675013926854d), new NpgsqlTypes.NpgsqlPoint(x: 0.371036690288034d, y: 0.16320650020933947d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14325119337622094d, y: 0.9161667421220939d), new NpgsqlTypes.NpgsqlPoint(x: 0.027096420787308784d, y: 0.9280048667610825d), new NpgsqlTypes.NpgsqlPoint(x: 0.03288992140867897d, y: 0.8588434673116538d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8328115237807794d, y: 0.4320513397820772d), new NpgsqlTypes.NpgsqlPoint(x: 0.383258344978863d, y: 0.4180705817892547d), new NpgsqlTypes.NpgsqlPoint(x: 0.26679774303285075d, y: 0.41650962979042394d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28608897154392654d, y: 0.6958476256006682d), new NpgsqlTypes.NpgsqlPoint(x: 0.7131406244854787d, y: 0.2618745061263731d), new NpgsqlTypes.NpgsqlPoint(x: 0.4278254391874199d, y: 0.3790717930672518d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0013546219781546132d, y: 0.23569625866294497d), new NpgsqlTypes.NpgsqlPoint(x: 0.04663552118222303d, y: 0.8111915568949883d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598927967844466d, y: 0.2545846565611005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23345069070899271d, y: 0.338914255536936d), new NpgsqlTypes.NpgsqlPoint(x: 0.6010078355601446d, y: 0.11539470696356235d), new NpgsqlTypes.NpgsqlPoint(x: 0.21477641486847043d, y: 0.10424950612902462d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8983422142756409d, y: 0.6324068365634793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7853514712308851d, y: 0.8630395584730813d), new NpgsqlTypes.NpgsqlPoint(x: 0.026818031969451095d, y: 0.15455529846922145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6879720808045987d, y: 0.18141621054251722d), new NpgsqlTypes.NpgsqlPoint(x: 0.7193425374726284d, y: 0.24296753748322064d), new NpgsqlTypes.NpgsqlPoint(x: 0.12330741903917763d, y: 0.8689877562896434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09710912373480907d, y: 0.7735988969152047d), new NpgsqlTypes.NpgsqlPoint(x: 0.8380306754603637d, y: 0.15239389692277394d), new NpgsqlTypes.NpgsqlPoint(x: 0.16296871330738838d, y: 0.12547232256262053d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2648190843767273d, y: 0.40755953512845877d), new NpgsqlTypes.NpgsqlPoint(x: 0.9358535280216088d, y: 0.06759498233225492d), new NpgsqlTypes.NpgsqlPoint(x: 0.18397845067406016d, y: 0.1765462071658288d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5132073413025282d, y: 0.06231123674728911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902566224936805d, y: 0.023511899452965168d), new NpgsqlTypes.NpgsqlPoint(x: 0.7207882958820632d, y: 0.5420395828875408d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13686722885396185d, y: 0.15454526082842068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518715764200423d, y: 0.7214674403071021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5264880782848808d, y: 0.482800481937403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21826448624327277d, y: 0.228840358403833d), new NpgsqlTypes.NpgsqlPoint(x: 0.7737189824638447d, y: 0.7166278640769536d), new NpgsqlTypes.NpgsqlPoint(x: 0.22919364343087023d, y: 0.8490434569059432d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6115936979821303d, y: 0.9193814657710568d), new NpgsqlTypes.NpgsqlPoint(x: 0.9808263474381174d, y: 0.41088470288498546d), new NpgsqlTypes.NpgsqlPoint(x: 0.001202334762992252d, y: 0.6643217948492172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06493771531832138d, y: 0.5440912326880691d), new NpgsqlTypes.NpgsqlPoint(x: 0.66731058285563d, y: 0.9827440487052019d), new NpgsqlTypes.NpgsqlPoint(x: 0.3717681945316338d, y: 0.21105940205951124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06820910140344894d, y: 0.6316697416654544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7423313592964578d, y: 0.3869459373534464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824540499153242d, y: 0.3901463796565676d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04690919144956984d, y: 0.7031477756518956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5202999835243624d, y: 0.39550099273710904d), new NpgsqlTypes.NpgsqlPoint(x: 0.4555255958394012d, y: 0.7378487286861837d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.916195436026605d, y: 0.6419934266409494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132591712789832d, y: 0.5305087190223643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5289347579895098d, y: 0.4606190579297219d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7543505357604997d, y: 0.03850035233318716d), new NpgsqlTypes.NpgsqlPoint(x: 0.3290526629809334d, y: 0.8938226411828535d), new NpgsqlTypes.NpgsqlPoint(x: 0.42963114369062005d, y: 0.3943693056852594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6310374162994021d, y: 0.4819009920742303d), new NpgsqlTypes.NpgsqlPoint(x: 0.43877036010394255d, y: 0.33676757522707035d), new NpgsqlTypes.NpgsqlPoint(x: 0.43306759798840233d, y: 0.7174773832029412d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1297831659099863d, y: 0.7224610329578883d), new NpgsqlTypes.NpgsqlPoint(x: 0.3494059494560453d, y: 0.2650150852463785d), new NpgsqlTypes.NpgsqlPoint(x: 0.8603552231895025d, y: 0.1348274031065686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9910001186975447d, y: 0.4853507826715696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8472803295358216d, y: 0.8647787246704378d), new NpgsqlTypes.NpgsqlPoint(x: 0.4892581118298214d, y: 0.5439451560237496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.055069371382241106d, y: 0.8935941811493128d), new NpgsqlTypes.NpgsqlPoint(x: 0.6050269383234941d, y: 0.5683327410107849d), new NpgsqlTypes.NpgsqlPoint(x: 0.22128095978099738d, y: 0.3660681447738584d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8106463983200911d, y: 0.63620845669943d), new NpgsqlTypes.NpgsqlPoint(x: 0.15656421944748755d, y: 0.8179092354484626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6218124789007033d, y: 0.6209352629959954d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9801762468586462d, y: 0.6288906229574064d), new NpgsqlTypes.NpgsqlPoint(x: 0.09565251689297594d, y: 0.3609592019103752d), new NpgsqlTypes.NpgsqlPoint(x: 0.15592628373866713d, y: 0.4429928427550489d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4792667373658699d, y: 0.9858991250034106d), new NpgsqlTypes.NpgsqlPoint(x: 0.49516563750690157d, y: 0.845543687750416d), new NpgsqlTypes.NpgsqlPoint(x: 0.29677860334309325d, y: 0.38444251077695946d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28594143146740003d, y: 0.6455417558544888d), new NpgsqlTypes.NpgsqlPoint(x: 0.3411484192833847d, y: 0.2004978334867662d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113590328047292d, y: 0.7993341896147359d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9862930532518183d, y: 0.3292553483190095d), new NpgsqlTypes.NpgsqlPoint(x: 0.0826127206009365d, y: 0.41436514407480673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838645428546541d, y: 0.3512410129883362d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14213331061348833d, y: 0.44508770896182137d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924649464765292d, y: 0.8656326758795454d), new NpgsqlTypes.NpgsqlPoint(x: 0.647818275366152d, y: 0.725727181591198d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4665864088070458d, y: 0.7536791734038706d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098381515899817d, y: 0.8910897019099433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5067354150721192d, y: 0.8123880738699488d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.362262510791706d, y: 0.6893912942761785d), new NpgsqlTypes.NpgsqlPoint(x: 0.07952866579046569d, y: 0.734622555889971d), new NpgsqlTypes.NpgsqlPoint(x: 0.29004338292761345d, y: 0.0317738946547117d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25975323468124245d, y: 0.601762225122678d), new NpgsqlTypes.NpgsqlPoint(x: 0.09692436099853852d, y: 0.43292444832179244d), new NpgsqlTypes.NpgsqlPoint(x: 0.43873190134074846d, y: 0.6914081971387545d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37849121644967176d, y: 0.40632008765177874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914435532627041d, y: 0.2880453131936317d), new NpgsqlTypes.NpgsqlPoint(x: 0.61799863427848d, y: 0.28608008528333395d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47972890274598357d, y: 0.06144461216635122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5307059821629532d, y: 0.5942934856776932d), new NpgsqlTypes.NpgsqlPoint(x: 0.9383508738561669d, y: 0.18904632047451864d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4479377041854429d, y: 0.7296531647361193d), new NpgsqlTypes.NpgsqlPoint(x: 0.0837470935541973d, y: 0.31637297464903125d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077122222508286d, y: 0.5685140288479711d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2087678173832409d, y: 0.10848901967213864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6578849522157886d, y: 0.5339281250550216d), new NpgsqlTypes.NpgsqlPoint(x: 0.19058030258813108d, y: 0.5196400600453756d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0959718976321573d, y: 0.6335912257004945d), new NpgsqlTypes.NpgsqlPoint(x: 0.703101752292717d, y: 0.8611920953453922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5720012188425766d, y: 0.4201214142068427d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8244495931933518d, y: 0.2400148844614589d), new NpgsqlTypes.NpgsqlPoint(x: 0.20568214522930894d, y: 0.6331670078943081d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433449721182549d, y: 0.6928020898634674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21561625458955525d, y: 0.3147129052620399d), new NpgsqlTypes.NpgsqlPoint(x: 0.5365645194980279d, y: 0.23326362497792463d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734420040010999d, y: 0.5541220479255463d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0619303350080872d, y: 0.8764079042575494d), new NpgsqlTypes.NpgsqlPoint(x: 0.421031205610809d, y: 0.5321536848628964d), new NpgsqlTypes.NpgsqlPoint(x: 0.08526964658311864d, y: 0.7128416741216999d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6607243891516539d, y: 0.4951546878264863d), new NpgsqlTypes.NpgsqlPoint(x: 0.1895457489228819d, y: 0.6959411438958379d), new NpgsqlTypes.NpgsqlPoint(x: 0.7515639833551745d, y: 0.8403323534605404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13024098145201035d, y: 0.9559460410460016d), new NpgsqlTypes.NpgsqlPoint(x: 0.767193106480932d, y: 0.9890241197746602d), new NpgsqlTypes.NpgsqlPoint(x: 0.578920195143289d, y: 0.9154336716893403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0159248270125667d, y: 0.8192535828470364d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252873313278062d, y: 0.3990094468885006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6668867125616482d, y: 0.6471635188324704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7858121284388492d, y: 0.7114366029415184d), new NpgsqlTypes.NpgsqlPoint(x: 0.14765108412165817d, y: 0.504112413198024d), new NpgsqlTypes.NpgsqlPoint(x: 0.22283591900182187d, y: 0.10981568039953771d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6782595765334062d, y: 0.6018747344585792d), new NpgsqlTypes.NpgsqlPoint(x: 0.14324554888043706d, y: 0.5766633817222108d), new NpgsqlTypes.NpgsqlPoint(x: 0.03639284647186003d, y: 0.49050856407210774d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8855300081340395d, y: 0.8916632102573205d), new NpgsqlTypes.NpgsqlPoint(x: 0.7815967963662335d, y: 0.7150828749465388d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234999882029545d, y: 0.38148440166688d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4866151262767924d, y: 0.17622497518832547d), new NpgsqlTypes.NpgsqlPoint(x: 0.2181906543727019d, y: 0.05701139846573389d), new NpgsqlTypes.NpgsqlPoint(x: 0.11580320612517425d, y: 0.48224688510275704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49472990348092616d, y: 0.9037256446381893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9715973223601048d, y: 0.36653884876477294d), new NpgsqlTypes.NpgsqlPoint(x: 0.18868509317605509d, y: 0.6006407991231805d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2105115603879223d, y: 0.34390490640153193d), new NpgsqlTypes.NpgsqlPoint(x: 0.574718077269372d, y: 0.6337530950884267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561773070274285d, y: 0.21302741284504456d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31996347228117317d, y: 0.5151321040269037d), new NpgsqlTypes.NpgsqlPoint(x: 0.9477933639737947d, y: 0.5852520214013551d), new NpgsqlTypes.NpgsqlPoint(x: 0.07646718316448842d, y: 0.22956687482738025d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9686054178343708d, y: 0.3472504081327794d), new NpgsqlTypes.NpgsqlPoint(x: 0.33797021461690224d, y: 0.4114734977180262d), new NpgsqlTypes.NpgsqlPoint(x: 0.3523984332965d, y: 0.6135693673150261d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8026669774288326d, y: 0.8808259448206005d), new NpgsqlTypes.NpgsqlPoint(x: 0.7514134395698563d, y: 0.492821034616737d), new NpgsqlTypes.NpgsqlPoint(x: 0.508520335986318d, y: 0.3402570728897214d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2745736203316016d, y: 0.9035578039564482d), new NpgsqlTypes.NpgsqlPoint(x: 0.07530287935550717d, y: 0.49598893034377334d), new NpgsqlTypes.NpgsqlPoint(x: 0.22852323402701458d, y: 0.37184253359763897d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11566703115196597d, y: 0.19025685534018077d), new NpgsqlTypes.NpgsqlPoint(x: 0.279995150332617d, y: 0.8535346827351632d), new NpgsqlTypes.NpgsqlPoint(x: 0.019425430973639468d, y: 0.9242750745982633d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5087023327034739d, y: 0.7223717825633704d), new NpgsqlTypes.NpgsqlPoint(x: 0.4496616387454938d, y: 0.9433570525705056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708193653602305d, y: 0.8216954532825378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.956449365251839d, y: 0.6504620548626714d), new NpgsqlTypes.NpgsqlPoint(x: 0.34628038777409587d, y: 0.15607272758115365d), new NpgsqlTypes.NpgsqlPoint(x: 0.66108506162033d, y: 0.6859000594776422d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.769058352383628d, y: 0.022122765803021083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728635523346957d, y: 0.20245609548463217d), new NpgsqlTypes.NpgsqlPoint(x: 0.5143129212771932d, y: 0.3624960386074454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.98853209552568d, y: 0.2665889424214013d), new NpgsqlTypes.NpgsqlPoint(x: 0.221821230078468d, y: 0.25537928814132504d), new NpgsqlTypes.NpgsqlPoint(x: 0.07068121728014065d, y: 0.6169123593392952d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9773686056156514d, y: 0.7629930874711577d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056733104667738d, y: 0.0327339897016623d), new NpgsqlTypes.NpgsqlPoint(x: 0.06989039350906867d, y: 0.30873206358074456d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8542612985935325d, y: 0.535441359516841d), new NpgsqlTypes.NpgsqlPoint(x: 0.4234238841259238d, y: 0.8022038483388089d), new NpgsqlTypes.NpgsqlPoint(x: 0.7078354982427005d, y: 0.5151039646855453d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17291882788797275d, y: 0.13539542611133404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9070923089360038d, y: 0.28227927952300114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9219379204966636d, y: 0.15444279487417445d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8113797567273433d, y: 0.2790022236709284d), new NpgsqlTypes.NpgsqlPoint(x: 0.4894540782618282d, y: 0.018664087028862908d), new NpgsqlTypes.NpgsqlPoint(x: 0.1286109654866513d, y: 0.9797152304573724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8090129041592868d, y: 0.7024081851645678d), new NpgsqlTypes.NpgsqlPoint(x: 0.593803406425093d, y: 0.3529237109587732d), new NpgsqlTypes.NpgsqlPoint(x: 0.7371192451265713d, y: 0.13874848542618656d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7060880458239855d, y: 0.5693139374350685d), new NpgsqlTypes.NpgsqlPoint(x: 0.26574707715159596d, y: 0.0912091361773375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6715443621210195d, y: 0.7058204294012054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6161378943374644d, y: 0.06592188038151736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6084048870553175d, y: 0.9633118018688126d), new NpgsqlTypes.NpgsqlPoint(x: 0.24942813730913904d, y: 0.6122711068701102d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5171751764433071d, y: 0.22629918673547578d), new NpgsqlTypes.NpgsqlPoint(x: 0.08167132046826608d, y: 0.6849823949221233d), new NpgsqlTypes.NpgsqlPoint(x: 0.40239917053411667d, y: 0.6552050708002509d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23286592324994648d, y: 0.24426955145188645d), new NpgsqlTypes.NpgsqlPoint(x: 0.2596057611409852d, y: 0.4657277188397384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494384833215457d, y: 0.11480451334801667d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0744580199548881d, y: 0.6609621329599786d), new NpgsqlTypes.NpgsqlPoint(x: 0.10076136633354649d, y: 0.9756020009747695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182224367527119d, y: 0.1152446896185726d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.532451354639173d, y: 0.8757669433121563d), new NpgsqlTypes.NpgsqlPoint(x: 0.25981056423888893d, y: 0.525559629498728d), new NpgsqlTypes.NpgsqlPoint(x: 0.4231492060772972d, y: 0.9160326703834357d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6614144665913173d, y: 0.35803336981015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6298012536905687d, y: 0.8695817260812504d), new NpgsqlTypes.NpgsqlPoint(x: 0.3666635925127417d, y: 0.10700015014316078d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9064742214421978d, y: 0.7153056855514823d), new NpgsqlTypes.NpgsqlPoint(x: 0.4145223037162148d, y: 0.2716007823516411d), new NpgsqlTypes.NpgsqlPoint(x: 0.39653055412499405d, y: 0.10774835198308397d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2647797295521187d, y: 0.41241681037982936d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674903115768594d, y: 0.4127920574563477d), new NpgsqlTypes.NpgsqlPoint(x: 0.886588304914251d, y: 0.7111346178534297d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.578312585322077d, y: 0.9763944069918242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9737719767317166d, y: 0.802800740333202d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524921674962286d, y: 0.4093848041556175d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9637326818994105d, y: 0.5081295808561186d), new NpgsqlTypes.NpgsqlPoint(x: 0.1229198243040126d, y: 0.45065964091368516d), new NpgsqlTypes.NpgsqlPoint(x: 0.08494924062616505d, y: 0.29597302461177777d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8976325881836738d, y: 0.8286749610837908d), new NpgsqlTypes.NpgsqlPoint(x: 0.563940786908188d, y: 0.7870306192913513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8834034421966821d, y: 0.039739423069573454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34888513078136996d, y: 0.020621304489959802d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815273692505397d, y: 0.9864618710794248d), new NpgsqlTypes.NpgsqlPoint(x: 0.10117456240297729d, y: 0.34367842638421187d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7406395191014457d, y: 0.4072297206327976d), new NpgsqlTypes.NpgsqlPoint(x: 0.838766734821905d, y: 0.9904760196881616d), new NpgsqlTypes.NpgsqlPoint(x: 0.7154611541604424d, y: 0.6386889958035048d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42327384824260206d, y: 0.028065111038407586d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903159134767365d, y: 0.8348925074764939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9458626333636306d, y: 0.011810633921063296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9091902237722459d, y: 0.009721991603103719d), new NpgsqlTypes.NpgsqlPoint(x: 0.6611056062749869d, y: 0.23452203750975198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9951917697912813d, y: 0.7954003215318675d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8576126005681696d, y: 0.9793969351812014d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227785535588517d, y: 0.3740534083727455d), new NpgsqlTypes.NpgsqlPoint(x: 0.26123477642479864d, y: 0.17398072778528884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028352772091775336d, y: 0.19077883860298994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5611861729171828d, y: 0.1881694101273056d), new NpgsqlTypes.NpgsqlPoint(x: 0.3183273461905439d, y: 0.06715519698279815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22958724423245291d, y: 0.13238581511576664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8051437845177555d, y: 0.952668851093915d), new NpgsqlTypes.NpgsqlPoint(x: 0.2421691502943969d, y: 0.7578156791546601d)),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 46, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 22, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 113, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 118, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 60, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 22, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 170, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 118, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[30],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[31],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[32],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

