

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.36850996125418345d,right: 0.27728030429718165d,bottom: 0.005609211492516697d,left: 0.051227038023854754d),

new NpgsqlTypes.NpgsqlBox(top: 0.8604008671037562d,right: 0.6699074493847816d,bottom: 0.572591560371492d,left: 0.0465809304225252d),

new NpgsqlTypes.NpgsqlBox(top: 0.7175704645569375d,right: 0.9542831803143977d,bottom: 0.5425936141761382d,left: 0.9388283701822708d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6159772563519381d,right: 0.7465392294000067d,bottom: 0.2085171231546199d,left: 0.6198508471263142d),

new NpgsqlTypes.NpgsqlBox(top: 0.8280710289865026d,right: 0.8561735437952825d,bottom: 0.7601835605977505d,left: 0.23303640015521976d),

new NpgsqlTypes.NpgsqlBox(top: 0.8868509568681028d,right: 0.3426809130871308d,bottom: 0.08957494446116254d,left: 0.040718742882730585d),

new NpgsqlTypes.NpgsqlBox(top: 0.8575160377441907d,right: 0.6215042387044468d,bottom: 0.7151944343241713d,left: 0.3548659374208263d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7979267884703521d,right: 0.8275896628050102d,bottom: 0.2762585801539964d,left: 0.7808451632721491d),

new NpgsqlTypes.NpgsqlBox(top: 0.7316753195274861d,right: 0.3818760502598302d,bottom: 0.5377884350409131d,left: 0.12947893808319433d),

new NpgsqlTypes.NpgsqlBox(top: 0.8427346702748134d,right: 0.9676287351543529d,bottom: 0.45858211086984557d,left: 0.9038697913827413d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8772493578397869d,right: 0.2094688192656481d,bottom: 0.05251287189136966d,left: 0.19295823253611788d),

new NpgsqlTypes.NpgsqlBox(top: 0.893594047225791d,right: 0.9292835996272566d,bottom: 0.17627425888264825d,left: 0.26957737865555287d),

new NpgsqlTypes.NpgsqlBox(top: 0.6311374572424994d,right: 0.4196563283061141d,bottom: 0.052253306044602876d,left: 0.39840634791799456d),

new NpgsqlTypes.NpgsqlBox(top: 0.47145703177296416d,right: 0.6885934234734168d,bottom: 0.07688292795371265d,left: 0.028133888871654356d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.25725449493522223d,right: 0.975210737981397d,bottom: 0.012544711897795824d,left: 0.10512699112133961d),

new NpgsqlTypes.NpgsqlBox(top: 0.7746278116546229d,right: 0.932418659797433d,bottom: 0.2770680599966945d,left: 0.2485215389639326d),

new NpgsqlTypes.NpgsqlBox(top: 0.9344361115592182d,right: 0.4857979316252493d,bottom: 0.32283512763447575d,left: 0.3975733930584241d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.04588735806579791d,right: 0.7604222708945454d,bottom: 0.0029044388874230886d,left: 0.2798170658724797d),

new NpgsqlTypes.NpgsqlBox(top: 0.5801164183015031d,right: 0.974501409176703d,bottom: 0.4428646543154495d,left: 0.3206989358303338d),

new NpgsqlTypes.NpgsqlBox(top: 0.9939713513104482d,right: 0.6306905156782325d,bottom: 0.6960742591369972d,left: 0.031596132599367444d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7093470973037305d,right: 0.7953524301264557d,bottom: 0.045075719606184284d,left: 0.5882434059427243d),

new NpgsqlTypes.NpgsqlBox(top: 0.4955155025447371d,right: 0.6534300577518278d,bottom: 0.1786296755804937d,left: 0.2506731107422694d),

new NpgsqlTypes.NpgsqlBox(top: 0.5264858748490538d,right: 0.9401152681633898d,bottom: 0.022474961637276913d,left: 0.3265495337735427d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3004248892206164d,right: 0.3557515739391699d,bottom: 0.05864601869970176d,left: 0.17654183318860894d),

new NpgsqlTypes.NpgsqlBox(top: 0.9363781389983155d,right: 0.41004964516098386d,bottom: 0.6352532241717527d,left: 0.2810447379207054d),

new NpgsqlTypes.NpgsqlBox(top: 0.6126055523729488d,right: 0.9957281458982867d,bottom: 0.09588732798159594d,left: 0.4541931887144146d),

new NpgsqlTypes.NpgsqlBox(top: 0.4027007071779032d,right: 0.7638080508329879d,bottom: 0.1732454864276456d,left: 0.23513023815179046d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44224479596825983d,right: 0.5640567608494067d,bottom: 0.422397993622853d,left: 0.16331799325689933d),

new NpgsqlTypes.NpgsqlBox(top: 0.9001912452154921d,right: 0.770820623762348d,bottom: 0.37339346330222756d,left: 0.27012809160647255d),

new NpgsqlTypes.NpgsqlBox(top: 0.6464534626312991d,right: 0.7366569282591262d,bottom: 0.6358302177961745d,left: 0.586093102779723d),

new NpgsqlTypes.NpgsqlBox(top: 0.8816180366125511d,right: 0.9059674114956373d,bottom: 0.38619757444758407d,left: 0.6522631848110411d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8150326757683334d,right: 0.5583572691212162d,bottom: 0.36043220401413456d,left: 0.3694928773664722d),

new NpgsqlTypes.NpgsqlBox(top: 0.668078598183413d,right: 0.6645926860194254d,bottom: 0.5934163346024686d,left: 0.017231610141778986d),

new NpgsqlTypes.NpgsqlBox(top: 0.6998880297311801d,right: 0.8375290798359626d,bottom: 0.1810921035542563d,left: 0.028311471995845494d),

new NpgsqlTypes.NpgsqlBox(top: 0.19250061012733866d,right: 0.23728726719083681d,bottom: 0.017455444845123735d,left: 0.23266558136081505d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7421895611327601d,right: 0.5096779758472613d,bottom: 0.6993442576067215d,left: 0.0851600330214547d),

new NpgsqlTypes.NpgsqlBox(top: 0.790564589801507d,right: 0.38202586018353d,bottom: 0.38928706933954726d,left: 0.09807311139656716d),

new NpgsqlTypes.NpgsqlBox(top: 0.984732337769676d,right: 0.9968988862384544d,bottom: 0.37531431349845434d,left: 0.07910895049628608d),

new NpgsqlTypes.NpgsqlBox(top: 0.8960764408758587d,right: 0.5059394665811228d,bottom: 0.39295771002382596d,left: 0.11865392037041833d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8160882286675202d,right: 0.8362483190414922d,bottom: 0.31521128189652947d,left: 0.4241144670963488d),

new NpgsqlTypes.NpgsqlBox(top: 0.18607654460151724d,right: 0.04273995297924371d,bottom: 0.14672501998055443d,left: 0.005662892000084296d),

new NpgsqlTypes.NpgsqlBox(top: 0.9302231544124852d,right: 0.7883629978131008d,bottom: 0.37073720198327653d,left: 0.14633208073410997d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7455094701127918d,right: 0.506527251651474d,bottom: 0.46958508452306724d,left: 0.4133547045044198d),

new NpgsqlTypes.NpgsqlBox(top: 0.9219640473684841d,right: 0.4259282833851892d,bottom: 0.08762900127353701d,left: 0.4239604651405444d),

new NpgsqlTypes.NpgsqlBox(top: 0.6716912094338128d,right: 0.6550592352240819d,bottom: 0.6426969690109536d,left: 0.5800834728999265d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6532047207361875d,right: 0.4795772165525827d,bottom: 0.29765715806981186d,left: 0.3865758076557828d),

new NpgsqlTypes.NpgsqlBox(top: 0.772523650914418d,right: 0.8940193604108407d,bottom: 0.23440019442213067d,left: 0.419622222554628d),

new NpgsqlTypes.NpgsqlBox(top: 0.6557216277161717d,right: 0.8770501539070672d,bottom: 0.2825444942046317d,left: 0.34888934578861797d),

new NpgsqlTypes.NpgsqlBox(top: 0.9012661928791291d,right: 0.6443735748943168d,bottom: 0.8175246079726723d,left: 0.10813069960277777d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.47184986854548727d,right: 0.7896966283330503d,bottom: 0.0817509050109907d,left: 0.21522580090574428d),

new NpgsqlTypes.NpgsqlBox(top: 0.5870849100759494d,right: 0.9679651643901723d,bottom: 0.24177453312981634d,left: 9.987683581957896E-06d),

new NpgsqlTypes.NpgsqlBox(top: 0.3187254341640031d,right: 0.9280240180389331d,bottom: 0.05374511545928995d,left: 0.29545764052606527d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8144080024583382d,right: 0.6827875545622186d,bottom: 0.35563334091749543d,left: 0.2844461366780183d),

new NpgsqlTypes.NpgsqlBox(top: 0.9625740751420797d,right: 0.5320515393452342d,bottom: 0.47243060452546026d,left: 0.3985396385474743d),

new NpgsqlTypes.NpgsqlBox(top: 0.6991937652142364d,right: 0.7655949112224036d,bottom: 0.1828794206327553d,left: 0.039495826701488435d),

new NpgsqlTypes.NpgsqlBox(top: 0.4939538726743983d,right: 0.891283941553914d,bottom: 0.154795706243386d,left: 0.03927514613773575d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5138298412255567d,right: 0.5893300366068913d,bottom: 0.2971826527280451d,left: 0.2512910073986203d),

new NpgsqlTypes.NpgsqlBox(top: 0.7870806822257437d,right: 0.31185688613289664d,bottom: 0.2750638742972237d,left: 0.20160701978703965d),

new NpgsqlTypes.NpgsqlBox(top: 0.5554111620540874d,right: 0.6039425751236674d,bottom: 0.35083664381132185d,left: 0.14535025564710102d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5849318209129839d,right: 0.6265725115308299d,bottom: 0.24508769649241724d,left: 0.14403205675790942d),

new NpgsqlTypes.NpgsqlBox(top: 0.5238074511657659d,right: 0.3496518495146632d,bottom: 0.4228720415264372d,left: 0.07036188442798674d),

new NpgsqlTypes.NpgsqlBox(top: 0.5517930372328834d,right: 0.8760000045835524d,bottom: 0.26405197558616345d,left: 0.6937842998884596d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8097588262877269d,right: 0.7613144324370804d,bottom: 0.22563448488359206d,left: 0.44868439662493753d),

new NpgsqlTypes.NpgsqlBox(top: 0.8835917736845414d,right: 0.7426497483447064d,bottom: 0.6613379753022666d,left: 0.2927136331725826d),

new NpgsqlTypes.NpgsqlBox(top: 0.5357488478810285d,right: 0.6180373820571721d,bottom: 0.17430490674494847d,left: 0.057917977750974514d),

new NpgsqlTypes.NpgsqlBox(top: 0.8528454931597115d,right: 0.9514855985270491d,bottom: 0.6641243862478275d,left: 0.9439985058535012d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9421455800202053d,right: 0.8140086999954815d,bottom: 0.26704755162577787d,left: 0.7365259761549521d),

new NpgsqlTypes.NpgsqlBox(top: 0.8351206856719207d,right: 0.8752477685202522d,bottom: 0.1915804286514523d,left: 0.6258443310169407d),

new NpgsqlTypes.NpgsqlBox(top: 0.32153298275102216d,right: 0.7817322483297937d,bottom: 0.302987502880107d,left: 0.41125629500432814d),

new NpgsqlTypes.NpgsqlBox(top: 0.9049760570513349d,right: 0.6061305957985411d,bottom: 0.2737228049727306d,left: 0.19257249794962716d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.894663496170726d,right: 0.7946834842138869d,bottom: 0.012836500086941705d,left: 0.29385539967501695d),

new NpgsqlTypes.NpgsqlBox(top: 0.634444509256606d,right: 0.3406736125988641d,bottom: 0.30781444964789795d,left: 0.06865961289338862d),

new NpgsqlTypes.NpgsqlBox(top: 0.7006351654181722d,right: 0.9268665897000685d,bottom: 0.5229965298242419d,left: 0.007855619564481442d),

new NpgsqlTypes.NpgsqlBox(top: 0.7012780498038111d,right: 0.2528525332433986d,bottom: 0.5783675330285172d,left: 0.1642214474018271d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5405563965861063d,right: 0.8993010893320668d,bottom: 0.4845916402649413d,left: 0.2877147797249662d),

new NpgsqlTypes.NpgsqlBox(top: 0.6420889234972981d,right: 0.921593509979661d,bottom: 0.09673562658391599d,left: 0.35124971364698d),

new NpgsqlTypes.NpgsqlBox(top: 0.5761788349781136d,right: 0.8674227308967856d,bottom: 0.15663413267067938d,left: 0.3445693413773142d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3605797634407172d,right: 0.42399918265314207d,bottom: 0.1708270423885384d,left: 0.08024996274628315d),

new NpgsqlTypes.NpgsqlBox(top: 0.9183229918294127d,right: 0.7029530183895242d,bottom: 0.6542981535290009d,left: 0.1130246545131286d),

new NpgsqlTypes.NpgsqlBox(top: 0.638399901502446d,right: 0.4895947079269508d,bottom: 0.3707659022409421d,left: 0.2249327091116643d),

new NpgsqlTypes.NpgsqlBox(top: 0.4134786617894721d,right: 0.2535585467326754d,bottom: 0.2298553190465058d,left: 0.13559957790291577d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4445019302806684d,right: 0.5446969605338583d,bottom: 0.3386586904467126d,left: 0.04972731070723535d),

new NpgsqlTypes.NpgsqlBox(top: 0.531757025640044d,right: 0.7511974609937591d,bottom: 0.5078263680252741d,left: 0.22484964732028778d),

new NpgsqlTypes.NpgsqlBox(top: 0.5914156264575696d,right: 0.553169754474484d,bottom: 0.4985200834083322d,left: 0.05782035845119937d),

new NpgsqlTypes.NpgsqlBox(top: 0.8793900191033964d,right: 0.5826465066293844d,bottom: 0.824078318233013d,left: 0.4679467858454097d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6837704380376902d,right: 0.277478592098922d,bottom: 0.12100409513379162d,left: 0.098529826278421d),

new NpgsqlTypes.NpgsqlBox(top: 0.24684625679741434d,right: 0.8768615557718545d,bottom: 0.1488882743558585d,left: 0.25779990231137095d),

new NpgsqlTypes.NpgsqlBox(top: 0.5325628381760483d,right: 0.7144444925364978d,bottom: 0.15294205635310165d,left: 0.3773582988422376d),

new NpgsqlTypes.NpgsqlBox(top: 0.8664959989771397d,right: 0.895902857706033d,bottom: 0.06015727844857155d,left: 0.05527285880238242d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5047261163996767d,right: 0.9741315447241707d,bottom: 0.28424138125658105d,left: 0.726974485047049d),

new NpgsqlTypes.NpgsqlBox(top: 0.8992742554333519d,right: 0.6894142009347944d,bottom: 0.8189532315002147d,left: 0.2769766335742341d),

new NpgsqlTypes.NpgsqlBox(top: 0.7283833195702182d,right: 0.4508789202710194d,bottom: 0.7227471585308173d,left: 0.33571840195865255d),

new NpgsqlTypes.NpgsqlBox(top: 0.7040116149265148d,right: 0.8206730044708234d,bottom: 0.35749484853002067d,left: 0.37439542394187697d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9540798286894312d,right: 0.7514112693945597d,bottom: 0.11487730491304216d,left: 0.5021115859964554d),

new NpgsqlTypes.NpgsqlBox(top: 0.6559622193575254d,right: 0.5849224932821372d,bottom: 0.0889716037139523d,left: 0.31172905140104534d),

new NpgsqlTypes.NpgsqlBox(top: 0.7814426770495787d,right: 0.9474242716387256d,bottom: 0.625689536606986d,left: 0.5668156901744805d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.48612975092653177d,right: 0.3445964964857867d,bottom: 0.45467709039998105d,left: 0.22961360927743313d),

new NpgsqlTypes.NpgsqlBox(top: 0.7155379514152682d,right: 0.6955820543583592d,bottom: 0.14318431793053876d,left: 0.12194343603699165d),

new NpgsqlTypes.NpgsqlBox(top: 0.2811227175271507d,right: 0.8485234233228596d,bottom: 0.08158357925316251d,left: 0.6493016058596839d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6264873342930293d,right: 0.7029205644968171d,bottom: 0.0497046020889107d,left: 0.26894466175691156d),

new NpgsqlTypes.NpgsqlBox(top: 0.9448672038277085d,right: 0.9482569370631534d,bottom: 0.7147092387049456d,left: 0.546078587317316d),

new NpgsqlTypes.NpgsqlBox(top: 0.3680905710864093d,right: 0.6477536792731443d,bottom: 0.34541907779363057d,left: 0.02261823055511003d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8951464402878526d,right: 0.820898432769783d,bottom: 0.17099147658323433d,left: 0.35923159700496954d),

new NpgsqlTypes.NpgsqlBox(top: 0.7635955952503392d,right: 0.960664690159731d,bottom: 0.6468835105430047d,left: 0.2169105700905709d),

new NpgsqlTypes.NpgsqlBox(top: 0.29060993813679814d,right: 0.3190678846476873d,bottom: 0.24565842093087475d,left: 0.08329908055822666d),

new NpgsqlTypes.NpgsqlBox(top: 0.955861207851511d,right: 0.4552655402881227d,bottom: 0.02926622000214074d,left: 0.15898445421149765d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8902970316823454d,right: 0.49130417985293073d,bottom: 0.6096267843291581d,left: 0.4364168176814416d),

new NpgsqlTypes.NpgsqlBox(top: 0.8015902598636462d,right: 0.5575611279558894d,bottom: 0.2771094918189482d,left: 0.4547246411717609d),

new NpgsqlTypes.NpgsqlBox(top: 0.3542795997845777d,right: 0.2551841927688492d,bottom: 0.3401664412367533d,left: 0.1548724124792551d),

new NpgsqlTypes.NpgsqlBox(top: 0.8762184183115814d,right: 0.9723088577702071d,bottom: 0.113866920282364d,left: 0.5966217095154162d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.530566113371056d,right: 0.7930481392518671d,bottom: 0.4634857255018692d,left: 0.08608502563366316d),

new NpgsqlTypes.NpgsqlBox(top: 0.32773899863318d,right: 0.14196840062249205d,bottom: 0.24464323327825044d,left: 0.13428603097025538d),

new NpgsqlTypes.NpgsqlBox(top: 0.9153024579300691d,right: 0.643617201093871d,bottom: 0.4355757059677293d,left: 0.12056452847483068d),

new NpgsqlTypes.NpgsqlBox(top: 0.8767354612658973d,right: 0.629641879621654d,bottom: 0.4625519852332626d,left: 0.10155190894878163d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4947620203798716d,right: 0.6259966676505573d,bottom: 0.47643517152232473d,left: 0.5768521526287488d),

new NpgsqlTypes.NpgsqlBox(top: 0.6337840539564866d,right: 0.8419945369699275d,bottom: 0.5304406734067448d,left: 0.17171112652326626d),

new NpgsqlTypes.NpgsqlBox(top: 0.9225592357981399d,right: 0.7841231404853393d,bottom: 0.8278249366128537d,left: 0.7203236339988408d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.925046526717197d,right: 0.9455223467266959d,bottom: 0.35741238146780396d,left: 0.42998055339087793d),

new NpgsqlTypes.NpgsqlBox(top: 0.5146183887873775d,right: 0.8104151868384832d,bottom: 0.16925898160562813d,left: 0.7750458774025116d),

new NpgsqlTypes.NpgsqlBox(top: 0.6241949478109106d,right: 0.8467022387414299d,bottom: 0.4256953656483916d,left: 0.5595973026179125d),

new NpgsqlTypes.NpgsqlBox(top: 0.27466952124732114d,right: 0.7773062664496533d,bottom: 0.051689305924757734d,left: 0.013322379760217995d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7318719532395869d,right: 0.21049992033306808d,bottom: 0.7240367825711644d,left: 0.14560068471790755d),

new NpgsqlTypes.NpgsqlBox(top: 0.8553147476333884d,right: 0.6608420211959266d,bottom: 0.3745800027071092d,left: 0.628017441020792d),

new NpgsqlTypes.NpgsqlBox(top: 0.4964937141332495d,right: 0.7959698957176228d,bottom: 0.1473267043848281d,left: 0.580724982514185d),

new NpgsqlTypes.NpgsqlBox(top: 0.7507870434649417d,right: 0.6424092231120344d,bottom: 0.10038990718495655d,left: 0.034245778928487014d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6866930723842661d,right: 0.9927836737274044d,bottom: 0.4013360540761669d,left: 0.7546383936939742d),

new NpgsqlTypes.NpgsqlBox(top: 0.6188510974066325d,right: 0.9573349193394757d,bottom: 0.3704328142532596d,left: 0.16581266922096594d),

new NpgsqlTypes.NpgsqlBox(top: 0.5553947709871683d,right: 0.8824226396919348d,bottom: 0.2932861502681162d,left: 0.7733411660652796d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6867818022314811d,right: 0.9414485303090598d,bottom: 0.05306619380247568d,left: 0.5927829023973564d),

new NpgsqlTypes.NpgsqlBox(top: 0.819987436086256d,right: 0.27456641924069647d,bottom: 0.6323522092014956d,left: 0.2110009448793042d),

new NpgsqlTypes.NpgsqlBox(top: 0.7724355683262394d,right: 0.3167693348422388d,bottom: 0.6558676784033567d,left: 0.10195255736925224d),

new NpgsqlTypes.NpgsqlBox(top: 0.7777559653022971d,right: 0.5903961880483255d,bottom: 0.4215610829117674d,left: 0.4407107131508414d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.87435635752877d,right: 0.7827506372114595d,bottom: 0.869894758962269d,left: 0.7327638816585968d),

new NpgsqlTypes.NpgsqlBox(top: 0.5236655544605213d,right: 0.8291212301791142d,bottom: 0.21275021972413732d,left: 0.014557010835499984d),

new NpgsqlTypes.NpgsqlBox(top: 0.9338290176016217d,right: 0.6823465705275803d,bottom: 0.9264349803516563d,left: 0.61414549489186d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6072242961333516d,right: 0.24646499168673142d,bottom: 0.0011756236527107333d,left: 0.03796290013757753d),

new NpgsqlTypes.NpgsqlBox(top: 0.9476738223127225d,right: 0.8468879728315397d,bottom: 0.16809578309036444d,left: 0.32528546466752306d),

new NpgsqlTypes.NpgsqlBox(top: 0.14066599178638017d,right: 0.6148797266293138d,bottom: 0.00254245028317035d,left: 0.047956537794879184d),

new NpgsqlTypes.NpgsqlBox(top: 0.4090534882729773d,right: 0.9768430522724071d,bottom: 0.08880110435656097d,left: 0.412135518263424d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5284872450414356d,right: 0.8205588292337705d,bottom: 0.4209119841071891d,left: 0.3030689227009207d),

new NpgsqlTypes.NpgsqlBox(top: 0.8125593318803974d,right: 0.6268646114495098d,bottom: 0.7420905051330298d,left: 0.13546191259544893d),

new NpgsqlTypes.NpgsqlBox(top: 0.7755606757961461d,right: 0.9896081276960627d,bottom: 0.6000980672584811d,left: 0.8948204348333639d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4918391826706925d,right: 0.8161501753736049d,bottom: 0.3410880507673951d,left: 0.18545458370565804d),

new NpgsqlTypes.NpgsqlBox(top: 0.9081765191583624d,right: 0.9873209183350882d,bottom: 0.051020218156767605d,left: 0.4968934079945667d),

new NpgsqlTypes.NpgsqlBox(top: 0.9908701526631782d,right: 0.20158677090851962d,bottom: 0.9080851989760398d,left: 0.10690613552249961d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7163520359138753d,right: 0.9540861254031426d,bottom: 0.23961382674600007d,left: 0.7457951100187981d),

new NpgsqlTypes.NpgsqlBox(top: 0.4482586602672738d,right: 0.8666975595048274d,bottom: 0.017027338558669447d,left: 0.5620619494776047d),

new NpgsqlTypes.NpgsqlBox(top: 0.9315150261613857d,right: 0.8735156154791858d,bottom: 0.37263445559808317d,left: 0.17621295773561618d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4649982192287667d,right: 0.8234317853807093d,bottom: 0.09616194084353802d,left: 0.7575810344776206d),

new NpgsqlTypes.NpgsqlBox(top: 0.14141072592223358d,right: 0.6370324753250483d,bottom: 0.11859501703869368d,left: 0.10790969250296634d),

new NpgsqlTypes.NpgsqlBox(top: 0.6698490534365794d,right: 0.7946050964018572d,bottom: 0.07271378761123326d,left: 0.16168328490458206d),

new NpgsqlTypes.NpgsqlBox(top: 0.5350739484503376d,right: 0.8697022505429434d,bottom: 0.36241218572719813d,left: 0.6070246836973053d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5586164456821932d,right: 0.6049377879396216d,bottom: 0.05614314082598615d,left: 0.5206685320558838d),

new NpgsqlTypes.NpgsqlBox(top: 0.7374699408650557d,right: 0.9809100296012918d,bottom: 0.36006902642478555d,left: 0.3075521128678802d),

new NpgsqlTypes.NpgsqlBox(top: 0.8011513362101168d,right: 0.6442798017254266d,bottom: 0.5558372692978814d,left: 0.3892332869368076d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7065233735959238d,right: 0.9836085487923752d,bottom: 0.01932454134950201d,left: 0.010961621697424428d),

new NpgsqlTypes.NpgsqlBox(top: 0.8866977428866797d,right: 0.7594423158936647d,bottom: 0.42907384056137854d,left: 0.3943004381243873d),

new NpgsqlTypes.NpgsqlBox(top: 0.7770556387146954d,right: 0.7751146729456426d,bottom: 0.0025253458937425366d,left: 0.18465980488412115d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8170965547109501d,right: 0.4935419538043938d,bottom: 0.48870246745793167d,left: 0.07642963467262032d),

new NpgsqlTypes.NpgsqlBox(top: 0.875679181518913d,right: 0.8022828029400213d,bottom: 0.14557191112471035d,left: 0.7374031544844779d),

new NpgsqlTypes.NpgsqlBox(top: 0.9706220268683196d,right: 0.6333002914448702d,bottom: 0.4951767390179054d,left: 0.5018990344846527d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8244109537143791d,right: 0.4483568797718277d,bottom: 0.5107200394459156d,left: 0.20075431576323444d),

new NpgsqlTypes.NpgsqlBox(top: 0.6361254384838618d,right: 0.2746064350670615d,bottom: 0.43763243045586153d,left: 0.15636388589976902d),

new NpgsqlTypes.NpgsqlBox(top: 0.16836262706698324d,right: 0.4669766283544686d,bottom: 0.030044818891615144d,left: 0.0023556374170663474d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2861104142366324d,right: 0.15337100968113027d,bottom: 0.008289236140071488d,left: 0.02476658856661529d),

new NpgsqlTypes.NpgsqlBox(top: 0.77527184007926d,right: 0.6682586153927217d,bottom: 0.2913778226533923d,left: 0.04060160530607415d),

new NpgsqlTypes.NpgsqlBox(top: 0.76920622159021d,right: 0.8296020397781289d,bottom: 0.5358868630007463d,left: 0.18908575584775322d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9120421164178623d,right: 0.9122621757171887d,bottom: 0.052143955966897026d,left: 0.03983708762946159d),

new NpgsqlTypes.NpgsqlBox(top: 0.8625181633985065d,right: 0.031174841307864076d,bottom: 0.01057732281166901d,left: 0.030703861510943176d),

new NpgsqlTypes.NpgsqlBox(top: 0.196729974375618d,right: 0.9481627844029842d,bottom: 0.1693533317059348d,left: 0.09226132177926438d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7503209996496054d,right: 0.777970920373646d,bottom: 0.40854234237807885d,left: 0.7560299183989071d),

new NpgsqlTypes.NpgsqlBox(top: 0.9742618862647111d,right: 0.9000079886398092d,bottom: 0.8881951516659042d,left: 0.158252799036655d),

new NpgsqlTypes.NpgsqlBox(top: 0.9785177819336925d,right: 0.9066051619623753d,bottom: 0.6905620113693175d,left: 0.6410754931632364d),

new NpgsqlTypes.NpgsqlBox(top: 0.6732745752701295d,right: 0.34727149801970825d,bottom: 0.6394413575091442d,left: 0.2421430441485567d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.739145329111136d,right: 0.8812217695980986d,bottom: 0.5889187640892083d,left: 0.19043270160625148d),

new NpgsqlTypes.NpgsqlBox(top: 0.4629297807703706d,right: 0.39891220928517446d,bottom: 0.3417503862075997d,left: 0.15410150937550382d),

new NpgsqlTypes.NpgsqlBox(top: 0.1952568960194514d,right: 0.72644608443969d,bottom: 0.10939145733600042d,left: 0.5208295367253571d),

new NpgsqlTypes.NpgsqlBox(top: 0.7050013115684045d,right: 0.5579963202398136d,bottom: 0.39810156190872914d,left: 0.4132482999330085d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7918308664603988d,right: 0.37335299138292277d,bottom: 0.38026156852025794d,left: 0.12527982761893086d),

new NpgsqlTypes.NpgsqlBox(top: 0.8287111403769185d,right: 0.6265469713607081d,bottom: 0.15773215233450166d,left: 0.03853450635979083d),

new NpgsqlTypes.NpgsqlBox(top: 0.9617953114713389d,right: 0.7730723139667092d,bottom: 0.26145285205909197d,left: 0.44472136418447794d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.19335696461726426d,right: 0.7069201678494855d,bottom: 0.010083996511453308d,left: 0.34905279250593335d),

new NpgsqlTypes.NpgsqlBox(top: 0.6719923041448121d,right: 0.9233180331977697d,bottom: 0.6414479957721175d,left: 0.6454103884744099d),

new NpgsqlTypes.NpgsqlBox(top: 0.2900806669576492d,right: 0.8896777888475533d,bottom: 0.07678719307078175d,left: 0.7305576201261366d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4706666629159817d,right: 0.5752272441740467d,bottom: 0.3147439313191164d,left: 0.06769955648647541d),

new NpgsqlTypes.NpgsqlBox(top: 0.9914842058301697d,right: 0.48390080851221917d,bottom: 0.3499372059838747d,left: 0.21969768283048208d),

new NpgsqlTypes.NpgsqlBox(top: 0.8273679047101287d,right: 0.7288072711741223d,bottom: 0.036677450603984973d,left: 0.015421247918062098d),

new NpgsqlTypes.NpgsqlBox(top: 0.7932728760172381d,right: 0.8248239128900832d,bottom: 0.1578375698436999d,left: 0.5271814321422957d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9173963786602609d,right: 0.9506511626500169d,bottom: 0.8233820464821728d,left: 0.6077486352176028d),

new NpgsqlTypes.NpgsqlBox(top: 0.6763968298843097d,right: 0.2908854409812116d,bottom: 0.37414311767533515d,left: 0.28123193791978596d),

new NpgsqlTypes.NpgsqlBox(top: 0.746382082957995d,right: 0.8238938744884198d,bottom: 0.10975564494650969d,left: 0.8047281162423932d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7410480740918709d,right: 0.3627083074005002d,bottom: 0.049361530314410595d,left: 0.22386482005363817d),

new NpgsqlTypes.NpgsqlBox(top: 0.14497575011538044d,right: 0.8020102027478475d,bottom: 0.046389294266687475d,left: 0.7417312588824746d),

new NpgsqlTypes.NpgsqlBox(top: 0.2781484373008638d,right: 0.35060297273136865d,bottom: 0.14446860008825368d,left: 0.25846737676694487d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9789191439264529d,right: 0.494376069661033d,bottom: 0.14157643407517673d,left: 0.030532442268537463d),

new NpgsqlTypes.NpgsqlBox(top: 0.7233990972432371d,right: 0.8400032616416d,bottom: 0.03722130829276016d,left: 0.21681330966102952d),

new NpgsqlTypes.NpgsqlBox(top: 0.8276453164553601d,right: 0.6903900233105317d,bottom: 0.26495456509933846d,left: 0.4793119260072617d),

new NpgsqlTypes.NpgsqlBox(top: 0.5635394855639652d,right: 0.6707363538586011d,bottom: 0.05966637262760299d,left: 0.40241451805392436d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9003374669501152d,right: 0.5563863813273693d,bottom: 0.11052537291420617d,left: 0.4674353571443949d),

new NpgsqlTypes.NpgsqlBox(top: 0.8482824110426757d,right: 0.7205304016265446d,bottom: 0.22446527013044093d,left: 0.5795337800342146d),

new NpgsqlTypes.NpgsqlBox(top: 0.7582002209254953d,right: 0.6043154539084099d,bottom: 0.10401421651664278d,left: 0.1292446294219215d),

new NpgsqlTypes.NpgsqlBox(top: 0.7618759559574494d,right: 0.9842678297867516d,bottom: 0.706004737128459d,left: 0.01208602033927697d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.41423268410800995d,right: 0.5617198836106785d,bottom: 0.08375867722924457d,left: 0.0800367926312816d),

new NpgsqlTypes.NpgsqlBox(top: 0.7408097451811639d,right: 0.9018025095333895d,bottom: 0.4217726745550817d,left: 0.47303303047452494d),

new NpgsqlTypes.NpgsqlBox(top: 0.7842662776103299d,right: 0.8974662270699033d,bottom: 0.470071633332241d,left: 0.6716641567336415d),

new NpgsqlTypes.NpgsqlBox(top: 0.9491157224540829d,right: 0.3749035892763549d,bottom: 0.3316963270668811d,left: 0.029298150913007692d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9764924164609572d,right: 0.6724026476900178d,bottom: 0.2522247994400263d,left: 0.22359218333282016d),

new NpgsqlTypes.NpgsqlBox(top: 0.7220689687563286d,right: 0.7767780891792266d,bottom: 0.2761431034617067d,left: 0.23424394610162602d),

new NpgsqlTypes.NpgsqlBox(top: 0.988893143068877d,right: 0.948217134649406d,bottom: 0.3994800404122286d,left: 0.40401621469035043d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9503182097580747d,right: 0.9191870540123507d,bottom: 0.05355734560269343d,left: 0.07435826963299041d),

new NpgsqlTypes.NpgsqlBox(top: 0.7226574716160905d,right: 0.6192342800487941d,bottom: 0.21862259487208024d,left: 0.2793291628172958d),

new NpgsqlTypes.NpgsqlBox(top: 0.5463674323997055d,right: 0.8408456193265306d,bottom: 0.05117842836272646d,left: 0.3141391423964315d),

new NpgsqlTypes.NpgsqlBox(top: 0.47825943102951785d,right: 0.7267226819915243d,bottom: 0.4483055798198986d,left: 0.5539752706552614d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9804120543765179d,right: 0.6851091132449171d,bottom: 0.9794571051813246d,left: 0.15834972579190965d),

new NpgsqlTypes.NpgsqlBox(top: 0.8341111740717649d,right: 0.30439214659525937d,bottom: 0.8250663301300915d,left: 0.1389662769550477d),

new NpgsqlTypes.NpgsqlBox(top: 0.7475648818930856d,right: 0.6193428887102007d,bottom: 0.7113793653358921d,left: 0.4459198845882134d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.686190909693963d,right: 0.5359106018870095d,bottom: 0.1582794776551969d,left: 0.1862869363565246d),

new NpgsqlTypes.NpgsqlBox(top: 0.7652058305866105d,right: 0.5928467103438092d,bottom: 0.23100999508800324d,left: 0.5268312480899245d),

new NpgsqlTypes.NpgsqlBox(top: 0.9855642722825393d,right: 0.355344080263004d,bottom: 0.6666790764452211d,left: 0.0724566811564179d),

new NpgsqlTypes.NpgsqlBox(top: 0.5164506219122892d,right: 0.5549853583998069d,bottom: 0.3285745766549043d,left: 0.34160170467540263d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6827923799435262d,right: 0.2463310312342306d,bottom: 0.560255514833825d,left: 0.22214286645427417d),

new NpgsqlTypes.NpgsqlBox(top: 0.9445962003620654d,right: 0.9948275683244022d,bottom: 0.4823779393004378d,left: 0.6169675791378115d),

new NpgsqlTypes.NpgsqlBox(top: 0.6419669810703125d,right: 0.5840344979316123d,bottom: 0.01569885854277364d,left: 0.47263631129155825d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7735119274017991d,right: 0.6615411803687207d,bottom: 0.05253196478484745d,left: 0.4341374409580343d),

new NpgsqlTypes.NpgsqlBox(top: 0.5938077246290439d,right: 0.9601899929571964d,bottom: 0.4651601209535582d,left: 0.5948985409701988d),

new NpgsqlTypes.NpgsqlBox(top: 0.7630893889432726d,right: 0.937783363281824d,bottom: 0.17543740776293493d,left: 0.15828376768589136d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2712435449466185d,right: 0.7697822996523966d,bottom: 0.0638209104507288d,left: 0.016329129046182222d),

new NpgsqlTypes.NpgsqlBox(top: 0.40918876030068696d,right: 0.10965565096404983d,bottom: 0.06878670705418499d,left: 0.02555255341789142d),

new NpgsqlTypes.NpgsqlBox(top: 0.7102790653743135d,right: 0.6806607431728456d,bottom: 0.24906208799116847d,left: 0.6565464974713484d),

new NpgsqlTypes.NpgsqlBox(top: 0.36620279388609334d,right: 0.4815404672598682d,bottom: 0.30692553989917937d,left: 0.12594548569576725d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5904166616540023d,right: 0.7499530995893813d,bottom: 0.5553394001331534d,left: 0.06368424397119243d),

new NpgsqlTypes.NpgsqlBox(top: 0.980214341188791d,right: 0.8587408213926047d,bottom: 0.9192832043796398d,left: 0.09522637674035095d),

new NpgsqlTypes.NpgsqlBox(top: 0.8035191250584228d,right: 0.5880698844532375d,bottom: 0.6509347455683018d,left: 0.07080821621608913d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.13642681167003512d,right: 0.8760053854426418d,bottom: 0.038706145224256305d,left: 0.7558213403973669d),

new NpgsqlTypes.NpgsqlBox(top: 0.7349010866529675d,right: 0.25292817250294375d,bottom: 0.06280465208483532d,left: 0.012416555035215548d),

new NpgsqlTypes.NpgsqlBox(top: 0.8914766077773365d,right: 0.7810808950597278d,bottom: 0.687246256299408d,left: 0.10572431091071022d),

new NpgsqlTypes.NpgsqlBox(top: 0.9108159576088691d,right: 0.6988850117322919d,bottom: 0.5794851202989867d,left: 0.14151163854616633d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6642931293512219d,right: 0.6358232853090164d,bottom: 0.21844858139503565d,left: 0.5523337697086974d),

new NpgsqlTypes.NpgsqlBox(top: 0.6792957213101869d,right: 0.9088238128446623d,bottom: 0.5481615093436584d,left: 0.641914165322382d),

new NpgsqlTypes.NpgsqlBox(top: 0.8433702096375543d,right: 0.8949428995904862d,bottom: 0.2261347678035024d,left: 0.8665622811934857d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.884873438932845d,right: 0.6846807851850629d,bottom: 0.610347591887131d,left: 0.5856029235235044d),

new NpgsqlTypes.NpgsqlBox(top: 0.7127878089073882d,right: 0.5305111868428137d,bottom: 0.5730694925198364d,left: 0.4792117403743821d),

new NpgsqlTypes.NpgsqlBox(top: 0.9751164523495711d,right: 0.45775100758865606d,bottom: 0.9300731518114713d,left: 0.036803930145919206d),

new NpgsqlTypes.NpgsqlBox(top: 0.7642735213875262d,right: 0.9203199024188716d,bottom: 0.7346242435057707d,left: 0.8908968583222072d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.800703872628007d,right: 0.9279823149313581d,bottom: 0.6781087869324806d,left: 0.7646969217749966d),

new NpgsqlTypes.NpgsqlBox(top: 0.7483479835449452d,right: 0.7600441316899741d,bottom: 0.7034497585633934d,left: 0.1599468649786837d),

new NpgsqlTypes.NpgsqlBox(top: 0.8837239778203109d,right: 0.9985625931946416d,bottom: 0.28556714937990213d,left: 0.6076890607893295d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.680236799394183d,right: 0.9666952260932172d,bottom: 0.03229427029198595d,left: 0.7827429429622563d),

new NpgsqlTypes.NpgsqlBox(top: 0.6377097881243545d,right: 0.8914463824445876d,bottom: 0.5316839248691297d,left: 0.08926141483452799d),

new NpgsqlTypes.NpgsqlBox(top: 0.5248265025426103d,right: 0.1004199067521182d,bottom: 0.11119818685541094d,left: 0.08680216578601119d),

new NpgsqlTypes.NpgsqlBox(top: 0.5261446603301227d,right: 0.22637815532978767d,bottom: 0.09041218682424257d,left: 0.05192417385346548d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7128312133390484d,right: 0.9901554265181594d,bottom: 0.4102168936582764d,left: 0.0657920296733675d),

new NpgsqlTypes.NpgsqlBox(top: 0.424837099104604d,right: 0.35696598022546666d,bottom: 0.306548458209814d,left: 0.12225697774744704d),

new NpgsqlTypes.NpgsqlBox(top: 0.23862276565111817d,right: 0.844944389245769d,bottom: 0.0369536625700172d,left: 0.506276261652346d),

new NpgsqlTypes.NpgsqlBox(top: 0.5094387475523263d,right: 0.526707812832932d,bottom: 0.29989978931402494d,left: 0.03056825353894621d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.737592770775014d,right: 0.9094492255529538d,bottom: 0.4142534813116152d,left: 0.439601723815785d),

new NpgsqlTypes.NpgsqlBox(top: 0.6933188157770551d,right: 0.6923623317915257d,bottom: 0.60384559050239d,left: 0.6157402913804204d),

new NpgsqlTypes.NpgsqlBox(top: 0.970174254189227d,right: 0.9683127239860563d,bottom: 0.4798649734226411d,left: 0.9276805129232992d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
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
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 101;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 144, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 17, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 155, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 155, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 80, query1, 144, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 85, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 85, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 89, 151))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MI),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray2M),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI), typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                await ((INpgsqlBoxListboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                ((INpgsqlBoxListboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

