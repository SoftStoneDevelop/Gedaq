

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
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8194779911075283d, y: 0.0160586817696593d), new NpgsqlTypes.NpgsqlPoint(x: 0.09395341168133331d, y: 0.36984446863403886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972848964806185d, y: 0.21091278443083927d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7979762409402802d, y: 0.7810547296505393d), new NpgsqlTypes.NpgsqlPoint(x: 0.09436881579782297d, y: 0.2349053557649874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2391791925566631d, y: 0.9419915851208466d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4526072798099603d, y: 0.8260962677756795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6060738508964455d, y: 0.20785386983509357d), new NpgsqlTypes.NpgsqlPoint(x: 0.17841342958756934d, y: 0.5888840699614989d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09037748937677192d, y: 0.9979892638324085d), new NpgsqlTypes.NpgsqlPoint(x: 0.897100958543357d, y: 0.12798932154232823d), new NpgsqlTypes.NpgsqlPoint(x: 0.1999014515828348d, y: 0.28798497132879586d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8986078513342908d, y: 0.6192611371978926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7760089275400189d, y: 0.30625220508948703d), new NpgsqlTypes.NpgsqlPoint(x: 0.35060339465019685d, y: 0.42127950121182567d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8427983056343157d, y: 0.9243585665876922d), new NpgsqlTypes.NpgsqlPoint(x: 0.04841459272082782d, y: 0.6003994733079222d), new NpgsqlTypes.NpgsqlPoint(x: 0.29694846655049745d, y: 0.24255235327051627d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37149870135470675d, y: 0.6351188809528601d), new NpgsqlTypes.NpgsqlPoint(x: 0.20408284154970224d, y: 0.045334176819536776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6581196642596465d, y: 0.18480530388692473d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10701599872190226d, y: 0.9221539326657603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440422304910152d, y: 0.09279861699164338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361486385050224d, y: 0.9920059483034639d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07185677320239736d, y: 0.7107083758139002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9938850155797014d, y: 0.27529877332467023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627584270522511d, y: 0.24438850675505086d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8964356975256421d, y: 0.5362346518059727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219387839953127d, y: 0.8448189598076925d), new NpgsqlTypes.NpgsqlPoint(x: 0.009135812426881995d, y: 0.7367965620490334d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019063643983896594d, y: 0.17725638787525966d), new NpgsqlTypes.NpgsqlPoint(x: 0.78450096262502d, y: 0.49925981318005175d), new NpgsqlTypes.NpgsqlPoint(x: 0.12537218961606367d, y: 0.5138898392864484d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7153835973183366d, y: 0.16876277815638752d), new NpgsqlTypes.NpgsqlPoint(x: 0.16956992375922453d, y: 0.7526518942852021d), new NpgsqlTypes.NpgsqlPoint(x: 0.8153944895822213d, y: 0.037032816572145744d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3817549086646209d, y: 0.3967883807569199d), new NpgsqlTypes.NpgsqlPoint(x: 0.17431946841098678d, y: 0.08891646127711006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583737789195496d, y: 0.8011060561918716d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9614913304702577d, y: 0.7172500748262931d), new NpgsqlTypes.NpgsqlPoint(x: 0.016594447337504592d, y: 0.3622007576069569d), new NpgsqlTypes.NpgsqlPoint(x: 0.4577981869767891d, y: 0.26944483718138d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40064779592219213d, y: 0.35227570030027067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8208581886375327d, y: 0.5328511645774313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185753166887941d, y: 0.7434799806883404d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1433977938514377d, y: 0.38072179023425834d), new NpgsqlTypes.NpgsqlPoint(x: 0.838247258526049d, y: 0.9003179689708304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5546912899899544d, y: 0.8884522026929553d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17608541844121928d, y: 0.789515216381493d), new NpgsqlTypes.NpgsqlPoint(x: 0.21049284291026715d, y: 0.7474162248199788d), new NpgsqlTypes.NpgsqlPoint(x: 0.894106993165953d, y: 0.889025300785017d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7214087716937209d, y: 0.7789048387368762d), new NpgsqlTypes.NpgsqlPoint(x: 0.11101807591421686d, y: 0.7184431436525366d), new NpgsqlTypes.NpgsqlPoint(x: 0.99243744692667d, y: 0.7876267060355716d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2915596854598168d, y: 0.705094820869762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8248406650615115d, y: 0.6403577498853477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770708652532772d, y: 0.46298535305712474d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6278944473050309d, y: 0.2286595213651893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6407785230647148d, y: 0.18139872195430784d), new NpgsqlTypes.NpgsqlPoint(x: 0.19835901941643796d, y: 0.20927478718110537d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31072734430464377d, y: 0.07819399008668759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327285927232801d, y: 0.16150317887352938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600214145479445d, y: 0.8867790029074883d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2943266319012737d, y: 0.6377832545051442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209231082255283d, y: 0.2463125625078305d), new NpgsqlTypes.NpgsqlPoint(x: 0.19657707714885408d, y: 0.2863096622484066d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9169573955643463d, y: 0.1304910040733427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6283978018016493d, y: 0.5045096661947732d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161295663903586d, y: 0.6503182390431225d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3699009522530773d, y: 0.18311666714246477d), new NpgsqlTypes.NpgsqlPoint(x: 0.17533998787714455d, y: 0.029614154577008445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4930371353070099d, y: 0.06985106029862465d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6464923575156587d, y: 0.04243300681650297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095109889197091d, y: 0.7974799212467304d), new NpgsqlTypes.NpgsqlPoint(x: 0.67952439005902d, y: 0.14979337359214995d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.928327614967041d, y: 0.6343146903851582d), new NpgsqlTypes.NpgsqlPoint(x: 0.30716327323751835d, y: 0.1628007731403014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810346877291199d, y: 0.41241706834681546d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125681637200555d, y: 0.1086284699605723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249053918436863d, y: 0.8110103141638043d), new NpgsqlTypes.NpgsqlPoint(x: 0.24558020139698267d, y: 0.555260118665426d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5811005391187684d, y: 0.8254705252349236d), new NpgsqlTypes.NpgsqlPoint(x: 0.6906721305283355d, y: 0.789137800572378d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686681275935233d, y: 0.7395363199561195d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4423523520219744d, y: 0.8110861237913102d), new NpgsqlTypes.NpgsqlPoint(x: 0.9132612458945987d, y: 0.13480556699672852d), new NpgsqlTypes.NpgsqlPoint(x: 0.3027527187043242d, y: 0.30505417124796497d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.041746543829601634d, y: 0.27378398567281015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8475185883535653d, y: 0.4041168465229744d), new NpgsqlTypes.NpgsqlPoint(x: 0.03716399363353817d, y: 0.9060144400507996d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9589448379860106d, y: 0.11032074835976102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807928414332648d, y: 0.6169636951768721d), new NpgsqlTypes.NpgsqlPoint(x: 0.23856917361355834d, y: 0.34569904450643396d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09447138809077982d, y: 0.7283459146053708d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373855301928639d, y: 0.1792248076623989d), new NpgsqlTypes.NpgsqlPoint(x: 0.07963334460849703d, y: 0.12963664172065048d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4001719981390398d, y: 0.3870134209285321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9386539694937039d, y: 0.7657625337456899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6632809075695653d, y: 0.814590226388297d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.586213816625528d, y: 0.06732646129399511d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334670193268618d, y: 0.2084667455770406d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096225346109929d, y: 0.807804463314792d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.58937515038918d, y: 0.8728132305483948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496945938723548d, y: 0.8633657345255698d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995826699789103d, y: 0.5217691020049081d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7929878874173805d, y: 0.990978868131203d), new NpgsqlTypes.NpgsqlPoint(x: 0.45664560934213627d, y: 0.2954161668817905d), new NpgsqlTypes.NpgsqlPoint(x: 0.005915607509755172d, y: 0.9465778596988635d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4060187160880957d, y: 0.06617274739996237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5747420787376697d, y: 0.15318808859204136d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070547062186912d, y: 0.6989279807309d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42027699019116715d, y: 0.45350128868863127d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196509522962713d, y: 0.7516874692042037d), new NpgsqlTypes.NpgsqlPoint(x: 0.00593699597666042d, y: 0.6758682010613507d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5063612221663173d, y: 0.9578970427706062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321840956374396d, y: 0.7367142833260062d), new NpgsqlTypes.NpgsqlPoint(x: 0.713773625224432d, y: 0.013870175915147165d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6052191789536738d, y: 0.37060582194564307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897003054032255d, y: 0.7956092729924119d), new NpgsqlTypes.NpgsqlPoint(x: 0.8956080038314792d, y: 0.07017106837096998d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2397843177638388d, y: 0.21827810262711123d), new NpgsqlTypes.NpgsqlPoint(x: 0.21024230401927002d, y: 0.4556708580725837d), new NpgsqlTypes.NpgsqlPoint(x: 0.4956934225237739d, y: 0.3205969475055389d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9228980336452822d, y: 0.7857509810097861d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222846588558544d, y: 0.033081956003332746d), new NpgsqlTypes.NpgsqlPoint(x: 0.1271652514029079d, y: 0.24803020413973742d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4297420718045505d, y: 0.1214759062450208d), new NpgsqlTypes.NpgsqlPoint(x: 0.06755618268613872d, y: 0.1721833769913862d), new NpgsqlTypes.NpgsqlPoint(x: 0.24075853169876527d, y: 0.3142860140913988d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5667080080847628d, y: 0.8741518838315379d), new NpgsqlTypes.NpgsqlPoint(x: 0.19792198277773787d, y: 0.9778799722302975d), new NpgsqlTypes.NpgsqlPoint(x: 0.04812642791712274d, y: 0.05399442936097598d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5449399909756591d, y: 0.13308162702745896d), new NpgsqlTypes.NpgsqlPoint(x: 0.45207515260714537d, y: 0.7511358238512006d), new NpgsqlTypes.NpgsqlPoint(x: 0.968173765044092d, y: 0.03835831798111833d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8189000067646963d, y: 0.5367722865014645d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530163332753954d, y: 0.30638571984496776d), new NpgsqlTypes.NpgsqlPoint(x: 0.0755179416722832d, y: 0.27413071299772884d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8846692371687278d, y: 0.8813785465409761d), new NpgsqlTypes.NpgsqlPoint(x: 0.17762595821162896d, y: 0.3362174730133548d), new NpgsqlTypes.NpgsqlPoint(x: 0.7009545958593462d, y: 0.13768708972921917d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4679102083169593d, y: 0.2566501231584779d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886328629069977d, y: 0.6888153009019924d), new NpgsqlTypes.NpgsqlPoint(x: 0.18017596128962765d, y: 0.08659093638317505d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9561161639041138d, y: 0.8571608570330652d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292387634904998d, y: 0.42797811152530374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668813483680025d, y: 0.49663513416387606d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8803281916636247d, y: 0.48996317624045627d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958877446745366d, y: 0.19248520658178836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266648295486267d, y: 0.035437828388082626d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8268376159381785d, y: 0.1695073696882491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928854861855413d, y: 0.013396341409273482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848641784999645d, y: 0.7333863826838579d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29433182817910963d, y: 0.6717132554109563d), new NpgsqlTypes.NpgsqlPoint(x: 0.47922380732244285d, y: 0.8009127841637859d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480497536255312d, y: 0.8915027889237602d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9400681403275967d, y: 0.1540197566422884d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236147751156271d, y: 0.4797685297914134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618800030984049d, y: 0.3932135894685146d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5293500224599413d, y: 0.9071503793047877d), new NpgsqlTypes.NpgsqlPoint(x: 0.003665480964040624d, y: 0.25933612152029206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543387218783318d, y: 0.23029602749208877d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0532261826500704d, y: 0.6226747218777574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5751602089703217d, y: 0.7123833011889552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220073490219595d, y: 0.9150262530062105d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4585223718924869d, y: 0.8240462558588879d), new NpgsqlTypes.NpgsqlPoint(x: 0.381203768442808d, y: 0.03866573860262523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646431776816095d, y: 0.09926679801207483d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21872067032657716d, y: 0.8615516482143758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9670318628824496d, y: 0.36699354203228884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640329914726976d, y: 0.19649970554750185d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7640670267380001d, y: 0.7886538640150029d), new NpgsqlTypes.NpgsqlPoint(x: 0.033799584974023134d, y: 0.4407686720540491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8190224315138658d, y: 0.521489825278943d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3108098711979712d, y: 0.12570827955371433d), new NpgsqlTypes.NpgsqlPoint(x: 0.30177569785580116d, y: 0.6791993791297108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274848475456926d, y: 0.18291435239347642d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.779654771275866d, y: 0.12211786468564867d), new NpgsqlTypes.NpgsqlPoint(x: 0.578372204276269d, y: 0.3466821391884972d), new NpgsqlTypes.NpgsqlPoint(x: 0.9152546841644481d, y: 0.3656774671502764d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6757655867857318d, y: 0.6721088929881434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749903262182912d, y: 0.004598986549084971d), new NpgsqlTypes.NpgsqlPoint(x: 0.22973220984188858d, y: 0.9956699123942343d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19411661165040184d, y: 0.1633365263112193d), new NpgsqlTypes.NpgsqlPoint(x: 0.07083125993417316d, y: 0.5649583505414009d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923898951518074d, y: 0.32324806600362055d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7437867584641032d, y: 0.6505303811681548d), new NpgsqlTypes.NpgsqlPoint(x: 0.07783812941986534d, y: 0.8575743304666238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6241436030808546d, y: 0.23829275173358266d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.092911894881065d, y: 0.7087130090182014d), new NpgsqlTypes.NpgsqlPoint(x: 0.46476655615874785d, y: 0.3830508275233262d), new NpgsqlTypes.NpgsqlPoint(x: 0.27276360028506386d, y: 0.18537885915102836d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.864141866344011d, y: 0.8888819377438468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4438182195475249d, y: 0.24185206775793644d), new NpgsqlTypes.NpgsqlPoint(x: 0.628041375912234d, y: 0.35292818699454875d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16359562232278946d, y: 0.8082179170349454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4719567036248652d, y: 0.2724432727502176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9855714682830268d, y: 0.9659057284089397d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21504391115074661d, y: 0.33057811981828367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7078588566797085d, y: 0.04272885119897807d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088716064087269d, y: 0.18157461079268966d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3984524667782263d, y: 0.7051914111188657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4151666771187854d, y: 0.5919844208917235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9791816482955215d, y: 0.3386897648534303d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9987437287093772d, y: 0.9212885694603588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861039615656154d, y: 0.824333858160163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4209652116100153d, y: 0.33193873092743276d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8753298162553492d, y: 0.8188214669708239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9256812360387704d, y: 0.5198343553643501d), new NpgsqlTypes.NpgsqlPoint(x: 0.03351696216100719d, y: 0.09833500442449672d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4102565844108167d, y: 0.06902247958670216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512929517966076d, y: 0.354168096683832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7027001228926104d, y: 0.5075095253549331d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 173,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24154593790945555d, y: 0.7323730573196707d), new NpgsqlTypes.NpgsqlPoint(x: 0.15884635773461664d, y: 0.5044644307118866d), new NpgsqlTypes.NpgsqlPoint(x: 0.2630990085984064d, y: 0.2853742828287458d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.782993019340021d, y: 0.4502161115270976d), new NpgsqlTypes.NpgsqlPoint(x: 0.07214360508715623d, y: 0.2139550706637442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3426135193797104d, y: 0.9868125484637137d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 178,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8520441085290952d, y: 0.2542429827081315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9344565976576067d, y: 0.48459013293762854d), new NpgsqlTypes.NpgsqlPoint(x: 0.26060292947131725d, y: 0.7584734366615928d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31097304709958196d, y: 0.6491602333613679d), new NpgsqlTypes.NpgsqlPoint(x: 0.10678816606663988d, y: 0.8170310182872628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7565743981216453d, y: 0.9907007799042894d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.002476887059016164d, y: 0.24518089249704378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071085795976481d, y: 0.48538685878924337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4254784081415952d, y: 0.21005352007258593d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 187,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4635538950742536d, y: 0.4091201292252612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678906496344926d, y: 0.5644489302726674d), new NpgsqlTypes.NpgsqlPoint(x: 0.27892803797145527d, y: 0.04793309658879796d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26293728849938436d, y: 0.3320891145018072d), new NpgsqlTypes.NpgsqlPoint(x: 0.10951879343759297d, y: 0.8463280788937853d), new NpgsqlTypes.NpgsqlPoint(x: 0.33133850549234667d, y: 0.7210569121489648d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40064779592219213d, y: 0.35227570030027067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8208581886375327d, y: 0.5328511645774313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185753166887941d, y: 0.7434799806883404d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2915596854598168d, y: 0.705094820869762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8248406650615115d, y: 0.6403577498853477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770708652532772d, y: 0.46298535305712474d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31072734430464377d, y: 0.07819399008668759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327285927232801d, y: 0.16150317887352938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600214145479445d, y: 0.8867790029074883d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[34], false);
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
                parametr1.Value = 25;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[34], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 27, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[34], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 156, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 156, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[34], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 146, query1, 111, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[34], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 50, query1, 142, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 157, query1, 135, query2))
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[34], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 70, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 70, 110))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 27, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 140);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8194779911075283d, y: 0.0160586817696593d), new NpgsqlTypes.NpgsqlPoint(x: 0.09395341168133331d, y: 0.36984446863403886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972848964806185d, y: 0.21091278443083927d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7979762409402802d, y: 0.7810547296505393d), new NpgsqlTypes.NpgsqlPoint(x: 0.09436881579782297d, y: 0.2349053557649874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2391791925566631d, y: 0.9419915851208466d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4526072798099603d, y: 0.8260962677756795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6060738508964455d, y: 0.20785386983509357d), new NpgsqlTypes.NpgsqlPoint(x: 0.17841342958756934d, y: 0.5888840699614989d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09037748937677192d, y: 0.9979892638324085d), new NpgsqlTypes.NpgsqlPoint(x: 0.897100958543357d, y: 0.12798932154232823d), new NpgsqlTypes.NpgsqlPoint(x: 0.1999014515828348d, y: 0.28798497132879586d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8986078513342908d, y: 0.6192611371978926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7760089275400189d, y: 0.30625220508948703d), new NpgsqlTypes.NpgsqlPoint(x: 0.35060339465019685d, y: 0.42127950121182567d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8427983056343157d, y: 0.9243585665876922d), new NpgsqlTypes.NpgsqlPoint(x: 0.04841459272082782d, y: 0.6003994733079222d), new NpgsqlTypes.NpgsqlPoint(x: 0.29694846655049745d, y: 0.24255235327051627d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37149870135470675d, y: 0.6351188809528601d), new NpgsqlTypes.NpgsqlPoint(x: 0.20408284154970224d, y: 0.045334176819536776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6581196642596465d, y: 0.18480530388692473d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10701599872190226d, y: 0.9221539326657603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440422304910152d, y: 0.09279861699164338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361486385050224d, y: 0.9920059483034639d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07185677320239736d, y: 0.7107083758139002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9938850155797014d, y: 0.27529877332467023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627584270522511d, y: 0.24438850675505086d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8964356975256421d, y: 0.5362346518059727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219387839953127d, y: 0.8448189598076925d), new NpgsqlTypes.NpgsqlPoint(x: 0.009135812426881995d, y: 0.7367965620490334d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019063643983896594d, y: 0.17725638787525966d), new NpgsqlTypes.NpgsqlPoint(x: 0.78450096262502d, y: 0.49925981318005175d), new NpgsqlTypes.NpgsqlPoint(x: 0.12537218961606367d, y: 0.5138898392864484d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7153835973183366d, y: 0.16876277815638752d), new NpgsqlTypes.NpgsqlPoint(x: 0.16956992375922453d, y: 0.7526518942852021d), new NpgsqlTypes.NpgsqlPoint(x: 0.8153944895822213d, y: 0.037032816572145744d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3817549086646209d, y: 0.3967883807569199d), new NpgsqlTypes.NpgsqlPoint(x: 0.17431946841098678d, y: 0.08891646127711006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583737789195496d, y: 0.8011060561918716d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9614913304702577d, y: 0.7172500748262931d), new NpgsqlTypes.NpgsqlPoint(x: 0.016594447337504592d, y: 0.3622007576069569d), new NpgsqlTypes.NpgsqlPoint(x: 0.4577981869767891d, y: 0.26944483718138d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40064779592219213d, y: 0.35227570030027067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8208581886375327d, y: 0.5328511645774313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185753166887941d, y: 0.7434799806883404d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1433977938514377d, y: 0.38072179023425834d), new NpgsqlTypes.NpgsqlPoint(x: 0.838247258526049d, y: 0.9003179689708304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5546912899899544d, y: 0.8884522026929553d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17608541844121928d, y: 0.789515216381493d), new NpgsqlTypes.NpgsqlPoint(x: 0.21049284291026715d, y: 0.7474162248199788d), new NpgsqlTypes.NpgsqlPoint(x: 0.894106993165953d, y: 0.889025300785017d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7214087716937209d, y: 0.7789048387368762d), new NpgsqlTypes.NpgsqlPoint(x: 0.11101807591421686d, y: 0.7184431436525366d), new NpgsqlTypes.NpgsqlPoint(x: 0.99243744692667d, y: 0.7876267060355716d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2915596854598168d, y: 0.705094820869762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8248406650615115d, y: 0.6403577498853477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770708652532772d, y: 0.46298535305712474d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6278944473050309d, y: 0.2286595213651893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6407785230647148d, y: 0.18139872195430784d), new NpgsqlTypes.NpgsqlPoint(x: 0.19835901941643796d, y: 0.20927478718110537d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31072734430464377d, y: 0.07819399008668759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327285927232801d, y: 0.16150317887352938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600214145479445d, y: 0.8867790029074883d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2943266319012737d, y: 0.6377832545051442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209231082255283d, y: 0.2463125625078305d), new NpgsqlTypes.NpgsqlPoint(x: 0.19657707714885408d, y: 0.2863096622484066d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9169573955643463d, y: 0.1304910040733427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6283978018016493d, y: 0.5045096661947732d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161295663903586d, y: 0.6503182390431225d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3699009522530773d, y: 0.18311666714246477d), new NpgsqlTypes.NpgsqlPoint(x: 0.17533998787714455d, y: 0.029614154577008445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4930371353070099d, y: 0.06985106029862465d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6464923575156587d, y: 0.04243300681650297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095109889197091d, y: 0.7974799212467304d), new NpgsqlTypes.NpgsqlPoint(x: 0.67952439005902d, y: 0.14979337359214995d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.928327614967041d, y: 0.6343146903851582d), new NpgsqlTypes.NpgsqlPoint(x: 0.30716327323751835d, y: 0.1628007731403014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810346877291199d, y: 0.41241706834681546d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125681637200555d, y: 0.1086284699605723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249053918436863d, y: 0.8110103141638043d), new NpgsqlTypes.NpgsqlPoint(x: 0.24558020139698267d, y: 0.555260118665426d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5811005391187684d, y: 0.8254705252349236d), new NpgsqlTypes.NpgsqlPoint(x: 0.6906721305283355d, y: 0.789137800572378d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686681275935233d, y: 0.7395363199561195d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4423523520219744d, y: 0.8110861237913102d), new NpgsqlTypes.NpgsqlPoint(x: 0.9132612458945987d, y: 0.13480556699672852d), new NpgsqlTypes.NpgsqlPoint(x: 0.3027527187043242d, y: 0.30505417124796497d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.041746543829601634d, y: 0.27378398567281015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8475185883535653d, y: 0.4041168465229744d), new NpgsqlTypes.NpgsqlPoint(x: 0.03716399363353817d, y: 0.9060144400507996d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9589448379860106d, y: 0.11032074835976102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807928414332648d, y: 0.6169636951768721d), new NpgsqlTypes.NpgsqlPoint(x: 0.23856917361355834d, y: 0.34569904450643396d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09447138809077982d, y: 0.7283459146053708d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373855301928639d, y: 0.1792248076623989d), new NpgsqlTypes.NpgsqlPoint(x: 0.07963334460849703d, y: 0.12963664172065048d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4001719981390398d, y: 0.3870134209285321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9386539694937039d, y: 0.7657625337456899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6632809075695653d, y: 0.814590226388297d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.586213816625528d, y: 0.06732646129399511d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334670193268618d, y: 0.2084667455770406d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096225346109929d, y: 0.807804463314792d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.58937515038918d, y: 0.8728132305483948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496945938723548d, y: 0.8633657345255698d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995826699789103d, y: 0.5217691020049081d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7929878874173805d, y: 0.990978868131203d), new NpgsqlTypes.NpgsqlPoint(x: 0.45664560934213627d, y: 0.2954161668817905d), new NpgsqlTypes.NpgsqlPoint(x: 0.005915607509755172d, y: 0.9465778596988635d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4060187160880957d, y: 0.06617274739996237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5747420787376697d, y: 0.15318808859204136d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070547062186912d, y: 0.6989279807309d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42027699019116715d, y: 0.45350128868863127d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196509522962713d, y: 0.7516874692042037d), new NpgsqlTypes.NpgsqlPoint(x: 0.00593699597666042d, y: 0.6758682010613507d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5063612221663173d, y: 0.9578970427706062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321840956374396d, y: 0.7367142833260062d), new NpgsqlTypes.NpgsqlPoint(x: 0.713773625224432d, y: 0.013870175915147165d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6052191789536738d, y: 0.37060582194564307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897003054032255d, y: 0.7956092729924119d), new NpgsqlTypes.NpgsqlPoint(x: 0.8956080038314792d, y: 0.07017106837096998d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2397843177638388d, y: 0.21827810262711123d), new NpgsqlTypes.NpgsqlPoint(x: 0.21024230401927002d, y: 0.4556708580725837d), new NpgsqlTypes.NpgsqlPoint(x: 0.4956934225237739d, y: 0.3205969475055389d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9228980336452822d, y: 0.7857509810097861d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222846588558544d, y: 0.033081956003332746d), new NpgsqlTypes.NpgsqlPoint(x: 0.1271652514029079d, y: 0.24803020413973742d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4297420718045505d, y: 0.1214759062450208d), new NpgsqlTypes.NpgsqlPoint(x: 0.06755618268613872d, y: 0.1721833769913862d), new NpgsqlTypes.NpgsqlPoint(x: 0.24075853169876527d, y: 0.3142860140913988d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5667080080847628d, y: 0.8741518838315379d), new NpgsqlTypes.NpgsqlPoint(x: 0.19792198277773787d, y: 0.9778799722302975d), new NpgsqlTypes.NpgsqlPoint(x: 0.04812642791712274d, y: 0.05399442936097598d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5449399909756591d, y: 0.13308162702745896d), new NpgsqlTypes.NpgsqlPoint(x: 0.45207515260714537d, y: 0.7511358238512006d), new NpgsqlTypes.NpgsqlPoint(x: 0.968173765044092d, y: 0.03835831798111833d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8189000067646963d, y: 0.5367722865014645d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530163332753954d, y: 0.30638571984496776d), new NpgsqlTypes.NpgsqlPoint(x: 0.0755179416722832d, y: 0.27413071299772884d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8846692371687278d, y: 0.8813785465409761d), new NpgsqlTypes.NpgsqlPoint(x: 0.17762595821162896d, y: 0.3362174730133548d), new NpgsqlTypes.NpgsqlPoint(x: 0.7009545958593462d, y: 0.13768708972921917d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4679102083169593d, y: 0.2566501231584779d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886328629069977d, y: 0.6888153009019924d), new NpgsqlTypes.NpgsqlPoint(x: 0.18017596128962765d, y: 0.08659093638317505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9561161639041138d, y: 0.8571608570330652d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292387634904998d, y: 0.42797811152530374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668813483680025d, y: 0.49663513416387606d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8803281916636247d, y: 0.48996317624045627d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958877446745366d, y: 0.19248520658178836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266648295486267d, y: 0.035437828388082626d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8268376159381785d, y: 0.1695073696882491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928854861855413d, y: 0.013396341409273482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848641784999645d, y: 0.7333863826838579d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29433182817910963d, y: 0.6717132554109563d), new NpgsqlTypes.NpgsqlPoint(x: 0.47922380732244285d, y: 0.8009127841637859d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480497536255312d, y: 0.8915027889237602d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9400681403275967d, y: 0.1540197566422884d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236147751156271d, y: 0.4797685297914134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618800030984049d, y: 0.3932135894685146d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5293500224599413d, y: 0.9071503793047877d), new NpgsqlTypes.NpgsqlPoint(x: 0.003665480964040624d, y: 0.25933612152029206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543387218783318d, y: 0.23029602749208877d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0532261826500704d, y: 0.6226747218777574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5751602089703217d, y: 0.7123833011889552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220073490219595d, y: 0.9150262530062105d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4585223718924869d, y: 0.8240462558588879d), new NpgsqlTypes.NpgsqlPoint(x: 0.381203768442808d, y: 0.03866573860262523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646431776816095d, y: 0.09926679801207483d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21872067032657716d, y: 0.8615516482143758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9670318628824496d, y: 0.36699354203228884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640329914726976d, y: 0.19649970554750185d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7640670267380001d, y: 0.7886538640150029d), new NpgsqlTypes.NpgsqlPoint(x: 0.033799584974023134d, y: 0.4407686720540491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8190224315138658d, y: 0.521489825278943d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3108098711979712d, y: 0.12570827955371433d), new NpgsqlTypes.NpgsqlPoint(x: 0.30177569785580116d, y: 0.6791993791297108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274848475456926d, y: 0.18291435239347642d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.779654771275866d, y: 0.12211786468564867d), new NpgsqlTypes.NpgsqlPoint(x: 0.578372204276269d, y: 0.3466821391884972d), new NpgsqlTypes.NpgsqlPoint(x: 0.9152546841644481d, y: 0.3656774671502764d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6757655867857318d, y: 0.6721088929881434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749903262182912d, y: 0.004598986549084971d), new NpgsqlTypes.NpgsqlPoint(x: 0.22973220984188858d, y: 0.9956699123942343d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19411661165040184d, y: 0.1633365263112193d), new NpgsqlTypes.NpgsqlPoint(x: 0.07083125993417316d, y: 0.5649583505414009d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923898951518074d, y: 0.32324806600362055d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7437867584641032d, y: 0.6505303811681548d), new NpgsqlTypes.NpgsqlPoint(x: 0.07783812941986534d, y: 0.8575743304666238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6241436030808546d, y: 0.23829275173358266d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.092911894881065d, y: 0.7087130090182014d), new NpgsqlTypes.NpgsqlPoint(x: 0.46476655615874785d, y: 0.3830508275233262d), new NpgsqlTypes.NpgsqlPoint(x: 0.27276360028506386d, y: 0.18537885915102836d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.864141866344011d, y: 0.8888819377438468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4438182195475249d, y: 0.24185206775793644d), new NpgsqlTypes.NpgsqlPoint(x: 0.628041375912234d, y: 0.35292818699454875d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16359562232278946d, y: 0.8082179170349454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4719567036248652d, y: 0.2724432727502176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9855714682830268d, y: 0.9659057284089397d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21504391115074661d, y: 0.33057811981828367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7078588566797085d, y: 0.04272885119897807d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088716064087269d, y: 0.18157461079268966d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3984524667782263d, y: 0.7051914111188657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4151666771187854d, y: 0.5919844208917235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9791816482955215d, y: 0.3386897648534303d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9987437287093772d, y: 0.9212885694603588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861039615656154d, y: 0.824333858160163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4209652116100153d, y: 0.33193873092743276d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8753298162553492d, y: 0.8188214669708239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9256812360387704d, y: 0.5198343553643501d), new NpgsqlTypes.NpgsqlPoint(x: 0.03351696216100719d, y: 0.09833500442449672d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4102565844108167d, y: 0.06902247958670216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512929517966076d, y: 0.354168096683832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7027001228926104d, y: 0.5075095253549331d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24154593790945555d, y: 0.7323730573196707d), new NpgsqlTypes.NpgsqlPoint(x: 0.15884635773461664d, y: 0.5044644307118866d), new NpgsqlTypes.NpgsqlPoint(x: 0.2630990085984064d, y: 0.2853742828287458d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.782993019340021d, y: 0.4502161115270976d), new NpgsqlTypes.NpgsqlPoint(x: 0.07214360508715623d, y: 0.2139550706637442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3426135193797104d, y: 0.9868125484637137d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8520441085290952d, y: 0.2542429827081315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9344565976576067d, y: 0.48459013293762854d), new NpgsqlTypes.NpgsqlPoint(x: 0.26060292947131725d, y: 0.7584734366615928d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31097304709958196d, y: 0.6491602333613679d), new NpgsqlTypes.NpgsqlPoint(x: 0.10678816606663988d, y: 0.8170310182872628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7565743981216453d, y: 0.9907007799042894d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.002476887059016164d, y: 0.24518089249704378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071085795976481d, y: 0.48538685878924337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4254784081415952d, y: 0.21005352007258593d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4635538950742536d, y: 0.4091201292252612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678906496344926d, y: 0.5644489302726674d), new NpgsqlTypes.NpgsqlPoint(x: 0.27892803797145527d, y: 0.04793309658879796d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26293728849938436d, y: 0.3320891145018072d), new NpgsqlTypes.NpgsqlPoint(x: 0.10951879343759297d, y: 0.8463280788937853d), new NpgsqlTypes.NpgsqlPoint(x: 0.33133850549234667d, y: 0.7210569121489648d)))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8194779911075283d, y: 0.0160586817696593d), new NpgsqlTypes.NpgsqlPoint(x: 0.09395341168133331d, y: 0.36984446863403886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972848964806185d, y: 0.21091278443083927d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7979762409402802d, y: 0.7810547296505393d), new NpgsqlTypes.NpgsqlPoint(x: 0.09436881579782297d, y: 0.2349053557649874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2391791925566631d, y: 0.9419915851208466d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4526072798099603d, y: 0.8260962677756795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6060738508964455d, y: 0.20785386983509357d), new NpgsqlTypes.NpgsqlPoint(x: 0.17841342958756934d, y: 0.5888840699614989d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09037748937677192d, y: 0.9979892638324085d), new NpgsqlTypes.NpgsqlPoint(x: 0.897100958543357d, y: 0.12798932154232823d), new NpgsqlTypes.NpgsqlPoint(x: 0.1999014515828348d, y: 0.28798497132879586d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8986078513342908d, y: 0.6192611371978926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7760089275400189d, y: 0.30625220508948703d), new NpgsqlTypes.NpgsqlPoint(x: 0.35060339465019685d, y: 0.42127950121182567d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8427983056343157d, y: 0.9243585665876922d), new NpgsqlTypes.NpgsqlPoint(x: 0.04841459272082782d, y: 0.6003994733079222d), new NpgsqlTypes.NpgsqlPoint(x: 0.29694846655049745d, y: 0.24255235327051627d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37149870135470675d, y: 0.6351188809528601d), new NpgsqlTypes.NpgsqlPoint(x: 0.20408284154970224d, y: 0.045334176819536776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6581196642596465d, y: 0.18480530388692473d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10701599872190226d, y: 0.9221539326657603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440422304910152d, y: 0.09279861699164338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361486385050224d, y: 0.9920059483034639d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07185677320239736d, y: 0.7107083758139002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9938850155797014d, y: 0.27529877332467023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627584270522511d, y: 0.24438850675505086d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8964356975256421d, y: 0.5362346518059727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219387839953127d, y: 0.8448189598076925d), new NpgsqlTypes.NpgsqlPoint(x: 0.009135812426881995d, y: 0.7367965620490334d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019063643983896594d, y: 0.17725638787525966d), new NpgsqlTypes.NpgsqlPoint(x: 0.78450096262502d, y: 0.49925981318005175d), new NpgsqlTypes.NpgsqlPoint(x: 0.12537218961606367d, y: 0.5138898392864484d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7153835973183366d, y: 0.16876277815638752d), new NpgsqlTypes.NpgsqlPoint(x: 0.16956992375922453d, y: 0.7526518942852021d), new NpgsqlTypes.NpgsqlPoint(x: 0.8153944895822213d, y: 0.037032816572145744d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3817549086646209d, y: 0.3967883807569199d), new NpgsqlTypes.NpgsqlPoint(x: 0.17431946841098678d, y: 0.08891646127711006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583737789195496d, y: 0.8011060561918716d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9614913304702577d, y: 0.7172500748262931d), new NpgsqlTypes.NpgsqlPoint(x: 0.016594447337504592d, y: 0.3622007576069569d), new NpgsqlTypes.NpgsqlPoint(x: 0.4577981869767891d, y: 0.26944483718138d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40064779592219213d, y: 0.35227570030027067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8208581886375327d, y: 0.5328511645774313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185753166887941d, y: 0.7434799806883404d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1433977938514377d, y: 0.38072179023425834d), new NpgsqlTypes.NpgsqlPoint(x: 0.838247258526049d, y: 0.9003179689708304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5546912899899544d, y: 0.8884522026929553d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17608541844121928d, y: 0.789515216381493d), new NpgsqlTypes.NpgsqlPoint(x: 0.21049284291026715d, y: 0.7474162248199788d), new NpgsqlTypes.NpgsqlPoint(x: 0.894106993165953d, y: 0.889025300785017d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7214087716937209d, y: 0.7789048387368762d), new NpgsqlTypes.NpgsqlPoint(x: 0.11101807591421686d, y: 0.7184431436525366d), new NpgsqlTypes.NpgsqlPoint(x: 0.99243744692667d, y: 0.7876267060355716d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2915596854598168d, y: 0.705094820869762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8248406650615115d, y: 0.6403577498853477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770708652532772d, y: 0.46298535305712474d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6278944473050309d, y: 0.2286595213651893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6407785230647148d, y: 0.18139872195430784d), new NpgsqlTypes.NpgsqlPoint(x: 0.19835901941643796d, y: 0.20927478718110537d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31072734430464377d, y: 0.07819399008668759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327285927232801d, y: 0.16150317887352938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600214145479445d, y: 0.8867790029074883d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2943266319012737d, y: 0.6377832545051442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209231082255283d, y: 0.2463125625078305d), new NpgsqlTypes.NpgsqlPoint(x: 0.19657707714885408d, y: 0.2863096622484066d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9169573955643463d, y: 0.1304910040733427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6283978018016493d, y: 0.5045096661947732d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161295663903586d, y: 0.6503182390431225d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3699009522530773d, y: 0.18311666714246477d), new NpgsqlTypes.NpgsqlPoint(x: 0.17533998787714455d, y: 0.029614154577008445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4930371353070099d, y: 0.06985106029862465d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6464923575156587d, y: 0.04243300681650297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095109889197091d, y: 0.7974799212467304d), new NpgsqlTypes.NpgsqlPoint(x: 0.67952439005902d, y: 0.14979337359214995d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.928327614967041d, y: 0.6343146903851582d), new NpgsqlTypes.NpgsqlPoint(x: 0.30716327323751835d, y: 0.1628007731403014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810346877291199d, y: 0.41241706834681546d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125681637200555d, y: 0.1086284699605723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249053918436863d, y: 0.8110103141638043d), new NpgsqlTypes.NpgsqlPoint(x: 0.24558020139698267d, y: 0.555260118665426d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5811005391187684d, y: 0.8254705252349236d), new NpgsqlTypes.NpgsqlPoint(x: 0.6906721305283355d, y: 0.789137800572378d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686681275935233d, y: 0.7395363199561195d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4423523520219744d, y: 0.8110861237913102d), new NpgsqlTypes.NpgsqlPoint(x: 0.9132612458945987d, y: 0.13480556699672852d), new NpgsqlTypes.NpgsqlPoint(x: 0.3027527187043242d, y: 0.30505417124796497d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.041746543829601634d, y: 0.27378398567281015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8475185883535653d, y: 0.4041168465229744d), new NpgsqlTypes.NpgsqlPoint(x: 0.03716399363353817d, y: 0.9060144400507996d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9589448379860106d, y: 0.11032074835976102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807928414332648d, y: 0.6169636951768721d), new NpgsqlTypes.NpgsqlPoint(x: 0.23856917361355834d, y: 0.34569904450643396d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09447138809077982d, y: 0.7283459146053708d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373855301928639d, y: 0.1792248076623989d), new NpgsqlTypes.NpgsqlPoint(x: 0.07963334460849703d, y: 0.12963664172065048d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4001719981390398d, y: 0.3870134209285321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9386539694937039d, y: 0.7657625337456899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6632809075695653d, y: 0.814590226388297d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.586213816625528d, y: 0.06732646129399511d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334670193268618d, y: 0.2084667455770406d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096225346109929d, y: 0.807804463314792d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.58937515038918d, y: 0.8728132305483948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496945938723548d, y: 0.8633657345255698d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995826699789103d, y: 0.5217691020049081d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7929878874173805d, y: 0.990978868131203d), new NpgsqlTypes.NpgsqlPoint(x: 0.45664560934213627d, y: 0.2954161668817905d), new NpgsqlTypes.NpgsqlPoint(x: 0.005915607509755172d, y: 0.9465778596988635d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4060187160880957d, y: 0.06617274739996237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5747420787376697d, y: 0.15318808859204136d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070547062186912d, y: 0.6989279807309d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42027699019116715d, y: 0.45350128868863127d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196509522962713d, y: 0.7516874692042037d), new NpgsqlTypes.NpgsqlPoint(x: 0.00593699597666042d, y: 0.6758682010613507d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5063612221663173d, y: 0.9578970427706062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321840956374396d, y: 0.7367142833260062d), new NpgsqlTypes.NpgsqlPoint(x: 0.713773625224432d, y: 0.013870175915147165d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6052191789536738d, y: 0.37060582194564307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897003054032255d, y: 0.7956092729924119d), new NpgsqlTypes.NpgsqlPoint(x: 0.8956080038314792d, y: 0.07017106837096998d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2397843177638388d, y: 0.21827810262711123d), new NpgsqlTypes.NpgsqlPoint(x: 0.21024230401927002d, y: 0.4556708580725837d), new NpgsqlTypes.NpgsqlPoint(x: 0.4956934225237739d, y: 0.3205969475055389d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9228980336452822d, y: 0.7857509810097861d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222846588558544d, y: 0.033081956003332746d), new NpgsqlTypes.NpgsqlPoint(x: 0.1271652514029079d, y: 0.24803020413973742d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4297420718045505d, y: 0.1214759062450208d), new NpgsqlTypes.NpgsqlPoint(x: 0.06755618268613872d, y: 0.1721833769913862d), new NpgsqlTypes.NpgsqlPoint(x: 0.24075853169876527d, y: 0.3142860140913988d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5667080080847628d, y: 0.8741518838315379d), new NpgsqlTypes.NpgsqlPoint(x: 0.19792198277773787d, y: 0.9778799722302975d), new NpgsqlTypes.NpgsqlPoint(x: 0.04812642791712274d, y: 0.05399442936097598d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5449399909756591d, y: 0.13308162702745896d), new NpgsqlTypes.NpgsqlPoint(x: 0.45207515260714537d, y: 0.7511358238512006d), new NpgsqlTypes.NpgsqlPoint(x: 0.968173765044092d, y: 0.03835831798111833d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8189000067646963d, y: 0.5367722865014645d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530163332753954d, y: 0.30638571984496776d), new NpgsqlTypes.NpgsqlPoint(x: 0.0755179416722832d, y: 0.27413071299772884d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8846692371687278d, y: 0.8813785465409761d), new NpgsqlTypes.NpgsqlPoint(x: 0.17762595821162896d, y: 0.3362174730133548d), new NpgsqlTypes.NpgsqlPoint(x: 0.7009545958593462d, y: 0.13768708972921917d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4679102083169593d, y: 0.2566501231584779d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886328629069977d, y: 0.6888153009019924d), new NpgsqlTypes.NpgsqlPoint(x: 0.18017596128962765d, y: 0.08659093638317505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9561161639041138d, y: 0.8571608570330652d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292387634904998d, y: 0.42797811152530374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668813483680025d, y: 0.49663513416387606d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8803281916636247d, y: 0.48996317624045627d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958877446745366d, y: 0.19248520658178836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266648295486267d, y: 0.035437828388082626d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8268376159381785d, y: 0.1695073696882491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928854861855413d, y: 0.013396341409273482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848641784999645d, y: 0.7333863826838579d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29433182817910963d, y: 0.6717132554109563d), new NpgsqlTypes.NpgsqlPoint(x: 0.47922380732244285d, y: 0.8009127841637859d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480497536255312d, y: 0.8915027889237602d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9400681403275967d, y: 0.1540197566422884d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236147751156271d, y: 0.4797685297914134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618800030984049d, y: 0.3932135894685146d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5293500224599413d, y: 0.9071503793047877d), new NpgsqlTypes.NpgsqlPoint(x: 0.003665480964040624d, y: 0.25933612152029206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543387218783318d, y: 0.23029602749208877d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0532261826500704d, y: 0.6226747218777574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5751602089703217d, y: 0.7123833011889552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220073490219595d, y: 0.9150262530062105d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4585223718924869d, y: 0.8240462558588879d), new NpgsqlTypes.NpgsqlPoint(x: 0.381203768442808d, y: 0.03866573860262523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646431776816095d, y: 0.09926679801207483d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21872067032657716d, y: 0.8615516482143758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9670318628824496d, y: 0.36699354203228884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640329914726976d, y: 0.19649970554750185d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7640670267380001d, y: 0.7886538640150029d), new NpgsqlTypes.NpgsqlPoint(x: 0.033799584974023134d, y: 0.4407686720540491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8190224315138658d, y: 0.521489825278943d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3108098711979712d, y: 0.12570827955371433d), new NpgsqlTypes.NpgsqlPoint(x: 0.30177569785580116d, y: 0.6791993791297108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274848475456926d, y: 0.18291435239347642d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.779654771275866d, y: 0.12211786468564867d), new NpgsqlTypes.NpgsqlPoint(x: 0.578372204276269d, y: 0.3466821391884972d), new NpgsqlTypes.NpgsqlPoint(x: 0.9152546841644481d, y: 0.3656774671502764d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6757655867857318d, y: 0.6721088929881434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749903262182912d, y: 0.004598986549084971d), new NpgsqlTypes.NpgsqlPoint(x: 0.22973220984188858d, y: 0.9956699123942343d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19411661165040184d, y: 0.1633365263112193d), new NpgsqlTypes.NpgsqlPoint(x: 0.07083125993417316d, y: 0.5649583505414009d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923898951518074d, y: 0.32324806600362055d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7437867584641032d, y: 0.6505303811681548d), new NpgsqlTypes.NpgsqlPoint(x: 0.07783812941986534d, y: 0.8575743304666238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6241436030808546d, y: 0.23829275173358266d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.092911894881065d, y: 0.7087130090182014d), new NpgsqlTypes.NpgsqlPoint(x: 0.46476655615874785d, y: 0.3830508275233262d), new NpgsqlTypes.NpgsqlPoint(x: 0.27276360028506386d, y: 0.18537885915102836d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.864141866344011d, y: 0.8888819377438468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4438182195475249d, y: 0.24185206775793644d), new NpgsqlTypes.NpgsqlPoint(x: 0.628041375912234d, y: 0.35292818699454875d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16359562232278946d, y: 0.8082179170349454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4719567036248652d, y: 0.2724432727502176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9855714682830268d, y: 0.9659057284089397d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21504391115074661d, y: 0.33057811981828367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7078588566797085d, y: 0.04272885119897807d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088716064087269d, y: 0.18157461079268966d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3984524667782263d, y: 0.7051914111188657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4151666771187854d, y: 0.5919844208917235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9791816482955215d, y: 0.3386897648534303d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9987437287093772d, y: 0.9212885694603588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861039615656154d, y: 0.824333858160163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4209652116100153d, y: 0.33193873092743276d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8753298162553492d, y: 0.8188214669708239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9256812360387704d, y: 0.5198343553643501d), new NpgsqlTypes.NpgsqlPoint(x: 0.03351696216100719d, y: 0.09833500442449672d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4102565844108167d, y: 0.06902247958670216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512929517966076d, y: 0.354168096683832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7027001228926104d, y: 0.5075095253549331d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24154593790945555d, y: 0.7323730573196707d), new NpgsqlTypes.NpgsqlPoint(x: 0.15884635773461664d, y: 0.5044644307118866d), new NpgsqlTypes.NpgsqlPoint(x: 0.2630990085984064d, y: 0.2853742828287458d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.782993019340021d, y: 0.4502161115270976d), new NpgsqlTypes.NpgsqlPoint(x: 0.07214360508715623d, y: 0.2139550706637442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3426135193797104d, y: 0.9868125484637137d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8520441085290952d, y: 0.2542429827081315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9344565976576067d, y: 0.48459013293762854d), new NpgsqlTypes.NpgsqlPoint(x: 0.26060292947131725d, y: 0.7584734366615928d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31097304709958196d, y: 0.6491602333613679d), new NpgsqlTypes.NpgsqlPoint(x: 0.10678816606663988d, y: 0.8170310182872628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7565743981216453d, y: 0.9907007799042894d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.002476887059016164d, y: 0.24518089249704378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071085795976481d, y: 0.48538685878924337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4254784081415952d, y: 0.21005352007258593d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4635538950742536d, y: 0.4091201292252612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678906496344926d, y: 0.5644489302726674d), new NpgsqlTypes.NpgsqlPoint(x: 0.27892803797145527d, y: 0.04793309658879796d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26293728849938436d, y: 0.3320891145018072d), new NpgsqlTypes.NpgsqlPoint(x: 0.10951879343759297d, y: 0.8463280788937853d), new NpgsqlTypes.NpgsqlPoint(x: 0.33133850549234667d, y: 0.7210569121489648d)))));

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

