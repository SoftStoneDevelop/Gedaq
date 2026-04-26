

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
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21230653171740854d, y: 0.2891972776435754d), new NpgsqlTypes.NpgsqlPoint(x: 0.1901646774969975d, y: 0.6141051758420918d), new NpgsqlTypes.NpgsqlPoint(x: 0.28900020778907964d, y: 0.8361577382155688d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8607447338860753d, y: 0.29969086905597775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2475630289126497d, y: 0.6633894886325903d), new NpgsqlTypes.NpgsqlPoint(x: 0.09104190580987881d, y: 0.7987685562116159d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8983731782451899d, y: 0.5474740104001747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182026163745044d, y: 0.17218230295274062d), new NpgsqlTypes.NpgsqlPoint(x: 0.4196424151791728d, y: 0.6069136051998334d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22472919763247168d, y: 0.6798537115809208d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551849096937999d, y: 0.7192767203080735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3979347562311455d, y: 0.7617735088093134d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7290630674760679d, y: 0.3500905368111902d), new NpgsqlTypes.NpgsqlPoint(x: 0.29819572530170924d, y: 0.14261600961918575d), new NpgsqlTypes.NpgsqlPoint(x: 0.35096720411261495d, y: 0.5510135403759495d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5081451821373141d, y: 0.7381499087319795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800475424489419d, y: 0.7559381958310714d), new NpgsqlTypes.NpgsqlPoint(x: 0.33340847659591744d, y: 0.9421908658392626d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2567066392196602d, y: 0.5790164049556691d), new NpgsqlTypes.NpgsqlPoint(x: 0.8462675183584998d, y: 0.9730179927287433d), new NpgsqlTypes.NpgsqlPoint(x: 0.07538992375008557d, y: 0.49619124745360066d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5458800780892691d, y: 0.21047802790305425d), new NpgsqlTypes.NpgsqlPoint(x: 0.824629220390081d, y: 0.8352575668549367d), new NpgsqlTypes.NpgsqlPoint(x: 0.0838230584212617d, y: 0.5827760869879487d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.215026404534842d, y: 0.028265968143295295d), new NpgsqlTypes.NpgsqlPoint(x: 0.41608603409625267d, y: 0.21145406051802007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5501958615561364d, y: 0.7078590524301706d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0963885608931313d, y: 0.33866389577914435d), new NpgsqlTypes.NpgsqlPoint(x: 0.40263340668198777d, y: 0.33965915937178437d), new NpgsqlTypes.NpgsqlPoint(x: 0.15710272374376433d, y: 0.6387554788002263d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2821096136961715d, y: 0.6188972248622433d), new NpgsqlTypes.NpgsqlPoint(x: 0.4918364956040139d, y: 0.10846222247451598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4772856535248684d, y: 0.4847152866199914d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38307806841285286d, y: 0.2543116748715133d), new NpgsqlTypes.NpgsqlPoint(x: 0.593154918750853d, y: 0.3400502041267377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245032713063682d, y: 0.1067756386841866d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4052282757290915d, y: 0.7370262674383825d), new NpgsqlTypes.NpgsqlPoint(x: 0.003318068336155222d, y: 0.988325434750932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443838919852716d, y: 0.5127248792966144d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9352693465127996d, y: 0.972825955423745d), new NpgsqlTypes.NpgsqlPoint(x: 0.18931218335360112d, y: 0.1390255061826149d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818469409034568d, y: 0.658227069483009d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33592762286015876d, y: 0.548468711077957d), new NpgsqlTypes.NpgsqlPoint(x: 0.46420397241525524d, y: 0.7707177202109646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241034284339021d, y: 0.4567107330334943d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06199587965292652d, y: 0.5289559272516806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9749331338291766d, y: 0.11400805335418407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132095335522185d, y: 0.39072479461172005d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2735885345042861d, y: 0.4350270691349779d), new NpgsqlTypes.NpgsqlPoint(x: 0.001154662284501784d, y: 0.46640777353916807d), new NpgsqlTypes.NpgsqlPoint(x: 0.05602092248377388d, y: 0.8806551701111979d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3076229438272585d, y: 0.04734799486972319d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102515526071403d, y: 0.903828195221976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324616788644933d, y: 0.41366950725733465d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6104315448241528d, y: 0.6117562072903052d), new NpgsqlTypes.NpgsqlPoint(x: 0.3426839986987892d, y: 0.7619787535616184d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813181765155063d, y: 0.6699989461663731d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7215150924490317d, y: 0.592360668027126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290172605588614d, y: 0.4738308244416981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864945555405013d, y: 0.5943953947907455d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8800568643944194d, y: 0.14346912670000334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015148619618689d, y: 0.9443941318663048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5237142134654188d, y: 0.4536725636342931d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39803551490508005d, y: 0.35009806594084203d), new NpgsqlTypes.NpgsqlPoint(x: 0.718225089779281d, y: 0.6930209678733855d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883819872654756d, y: 0.39250203482296164d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4813414516076191d, y: 0.01377095031990827d), new NpgsqlTypes.NpgsqlPoint(x: 0.44437076236283635d, y: 0.6283481554528173d), new NpgsqlTypes.NpgsqlPoint(x: 0.038326969903602515d, y: 0.40129912719957195d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8447532465562799d, y: 0.5633827891164557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6491997459954675d, y: 0.9631443709210676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3002522485697011d, y: 0.6834445467751669d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2937879828969553d, y: 0.2972512180851056d), new NpgsqlTypes.NpgsqlPoint(x: 0.87110842876555d, y: 0.29884855495242857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9708275274223279d, y: 0.9453093872021282d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03682383473339457d, y: 0.6007816861159511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309223396366971d, y: 0.49957024263582817d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503872167358729d, y: 0.9982289406524913d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8957620037699933d, y: 0.6108943051533d), new NpgsqlTypes.NpgsqlPoint(x: 0.25967068572392793d, y: 0.10176942285199453d), new NpgsqlTypes.NpgsqlPoint(x: 0.14545683786134267d, y: 0.5893298343652067d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5037092691573933d, y: 0.17791720679322442d), new NpgsqlTypes.NpgsqlPoint(x: 0.19125948657277647d, y: 0.26188461861849444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285988527135685d, y: 0.6059805864569894d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6064665292433776d, y: 0.882824683942671d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061172903775338d, y: 0.1928889853310013d), new NpgsqlTypes.NpgsqlPoint(x: 0.01661430910349182d, y: 0.6395103796075767d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016007038626248193d, y: 0.6124918184845399d), new NpgsqlTypes.NpgsqlPoint(x: 0.753272685562708d, y: 0.9321544795647332d), new NpgsqlTypes.NpgsqlPoint(x: 0.1793363808928301d, y: 0.7683559156379395d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41006384656564565d, y: 0.35300896806585236d), new NpgsqlTypes.NpgsqlPoint(x: 0.2531868473536968d, y: 0.862043976844407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896322685857839d, y: 0.9127321311969112d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4817455813410527d, y: 0.0628092566742312d), new NpgsqlTypes.NpgsqlPoint(x: 0.3585513246251214d, y: 0.6473595474501589d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454019497891154d, y: 0.03368253547753064d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042163334909201655d, y: 0.35421687156959714d), new NpgsqlTypes.NpgsqlPoint(x: 0.989376859633718d, y: 0.7159550230372234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6404194682723662d, y: 0.7478242162305879d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3778340242356063d, y: 0.18615079362106213d), new NpgsqlTypes.NpgsqlPoint(x: 0.752619306341367d, y: 0.7061309502138036d), new NpgsqlTypes.NpgsqlPoint(x: 0.33111976661249587d, y: 0.3382055771815463d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6663715019846703d, y: 0.926938442711607d), new NpgsqlTypes.NpgsqlPoint(x: 0.1156245692658977d, y: 0.3907462554715003d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222752077385348d, y: 0.37226996467042495d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04262030586133536d, y: 0.7830611139368654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5635973683556348d, y: 0.6901516722112616d), new NpgsqlTypes.NpgsqlPoint(x: 0.009024201348723948d, y: 0.6569988394894605d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18816978609541812d, y: 0.5350558508103618d), new NpgsqlTypes.NpgsqlPoint(x: 0.17881175050642661d, y: 0.4461341700333905d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472689898385688d, y: 0.8889943914731887d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9663304429614837d, y: 0.8044599670449092d), new NpgsqlTypes.NpgsqlPoint(x: 0.32094016728379027d, y: 0.9277710347948424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9873727095760056d, y: 0.18950009980155902d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.720081513565905d, y: 0.2878347611994817d), new NpgsqlTypes.NpgsqlPoint(x: 0.270074375113564d, y: 0.9982916209110406d), new NpgsqlTypes.NpgsqlPoint(x: 0.3798533196840873d, y: 0.9104043440237561d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11108702754826283d, y: 0.4874025967570651d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280836330770945d, y: 0.8704444189685497d), new NpgsqlTypes.NpgsqlPoint(x: 0.14665023582295922d, y: 0.5411188983016888d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11639309633640726d, y: 0.6144477732080054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6835695893001618d, y: 0.296879172549543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480299356841555d, y: 0.8963955882339802d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5825687700232047d, y: 0.5254183946482684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6779931796208161d, y: 0.3621639678530766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071350464622058d, y: 0.2521830890311283d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42332456553806763d, y: 0.3511744246774018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6926818414013388d, y: 0.7522823353908439d), new NpgsqlTypes.NpgsqlPoint(x: 0.3728325498529854d, y: 0.49066071470662465d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4527174551840565d, y: 0.4093314394531221d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933376632401274d, y: 0.34614127771904446d), new NpgsqlTypes.NpgsqlPoint(x: 0.2802686211245875d, y: 0.5322855812989852d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8016773713751345d, y: 0.19527850751900055d), new NpgsqlTypes.NpgsqlPoint(x: 0.22536874098844417d, y: 0.44989085382770455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440621844324049d, y: 0.8344783926865496d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9753707328921553d, y: 0.3796855348292941d), new NpgsqlTypes.NpgsqlPoint(x: 0.37257913364009076d, y: 0.8327046033477594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774127252283748d, y: 0.590177637485429d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.492913040326428d, y: 0.45188576920773793d), new NpgsqlTypes.NpgsqlPoint(x: 0.38698645538243737d, y: 0.8671480995613573d), new NpgsqlTypes.NpgsqlPoint(x: 0.29670298480280255d, y: 0.9898672500293422d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4324593939540944d, y: 0.5927800976651687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537030824925868d, y: 0.9496549669173598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572315383652419d, y: 0.3852959354960157d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.644931860679397d, y: 0.8831872769939522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299226016466732d, y: 0.711022297654897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7502674884719307d, y: 0.8593628239999369d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5699652692776003d, y: 0.7397758525588626d), new NpgsqlTypes.NpgsqlPoint(x: 0.24129054178699882d, y: 0.16197914990215756d), new NpgsqlTypes.NpgsqlPoint(x: 0.4743635811744612d, y: 0.8149347518739144d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.023143454880199532d, y: 0.2272685117242912d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835789881264232d, y: 0.9035169116969378d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024721560051562674d, y: 0.922188517760455d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8981301976666947d, y: 0.9272252780474609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978816373522851d, y: 0.957197030510249d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307860839837838d, y: 0.2818598097811481d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5312532061372081d, y: 0.25498877395114994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7931576637578772d, y: 0.34129332234701815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496602670685517d, y: 0.9815742390003336d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.994376885193912d, y: 0.692274518086973d), new NpgsqlTypes.NpgsqlPoint(x: 0.48235545799358215d, y: 0.8362727451195879d), new NpgsqlTypes.NpgsqlPoint(x: 0.7332975334346432d, y: 0.20485902326059158d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4910163682540374d, y: 0.2899293314016681d), new NpgsqlTypes.NpgsqlPoint(x: 0.3972979037062576d, y: 0.07324089545856349d), new NpgsqlTypes.NpgsqlPoint(x: 0.4799129689870626d, y: 0.7406774354024666d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5244778862118207d, y: 0.1404172782799764d), new NpgsqlTypes.NpgsqlPoint(x: 0.1419166359432139d, y: 0.9003360397868571d), new NpgsqlTypes.NpgsqlPoint(x: 0.061459520930299605d, y: 0.393373700713303d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5836269556923401d, y: 0.5774791240245893d), new NpgsqlTypes.NpgsqlPoint(x: 0.33403809659159234d, y: 0.024406884928693695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9666386192691799d, y: 0.4297187487418339d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6719859038526976d, y: 0.8485354000060672d), new NpgsqlTypes.NpgsqlPoint(x: 0.6214948550194451d, y: 0.8740058817581524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942900694582612d, y: 0.9908799166662191d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3145291791011381d, y: 0.32203320312411987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342613794551657d, y: 0.1150552603979883d), new NpgsqlTypes.NpgsqlPoint(x: 0.20291481596588834d, y: 0.618405742142478d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20140249932000753d, y: 0.7738097108706594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4677914674172855d, y: 0.020781261892478864d), new NpgsqlTypes.NpgsqlPoint(x: 0.4809439268907816d, y: 0.08971175837943535d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40355351978105947d, y: 0.1655629888357758d), new NpgsqlTypes.NpgsqlPoint(x: 0.899536692964362d, y: 0.8440293747467646d), new NpgsqlTypes.NpgsqlPoint(x: 0.03432626382586146d, y: 0.9097827786856983d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13040941785962068d, y: 0.0753632855487325d), new NpgsqlTypes.NpgsqlPoint(x: 0.482288654395846d, y: 0.12775805141857033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115586883663763d, y: 0.9908932854786774d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.627888813542669d, y: 0.7978463672852453d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351099798866942d, y: 0.39965054217684515d), new NpgsqlTypes.NpgsqlPoint(x: 0.7250452561442361d, y: 0.9982097340829983d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8145582896077972d, y: 0.06585654528024487d), new NpgsqlTypes.NpgsqlPoint(x: 0.44503450533542044d, y: 0.37665138786530383d), new NpgsqlTypes.NpgsqlPoint(x: 0.3942103385874217d, y: 0.31933711859223746d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9396967632590129d, y: 0.06973115409066466d), new NpgsqlTypes.NpgsqlPoint(x: 0.2666544807106209d, y: 0.939989566206559d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499430869012144d, y: 0.2967621538895847d)),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38307806841285286d, y: 0.2543116748715133d), new NpgsqlTypes.NpgsqlPoint(x: 0.593154918750853d, y: 0.3400502041267377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245032713063682d, y: 0.1067756386841866d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2735885345042861d, y: 0.4350270691349779d), new NpgsqlTypes.NpgsqlPoint(x: 0.001154662284501784d, y: 0.46640777353916807d), new NpgsqlTypes.NpgsqlPoint(x: 0.05602092248377388d, y: 0.8806551701111979d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8800568643944194d, y: 0.14346912670000334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015148619618689d, y: 0.9443941318663048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5237142134654188d, y: 0.4536725636342931d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4813414516076191d, y: 0.01377095031990827d), new NpgsqlTypes.NpgsqlPoint(x: 0.44437076236283635d, y: 0.6283481554528173d), new NpgsqlTypes.NpgsqlPoint(x: 0.038326969903602515d, y: 0.40129912719957195d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03682383473339457d, y: 0.6007816861159511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309223396366971d, y: 0.49957024263582817d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503872167358729d, y: 0.9982289406524913d))));
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
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

                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 11, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelBatchAsync(connection, 75, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[29], false);
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelBatch(connection, 64, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21230653171740854d, y: 0.2891972776435754d), new NpgsqlTypes.NpgsqlPoint(x: 0.1901646774969975d, y: 0.6141051758420918d), new NpgsqlTypes.NpgsqlPoint(x: 0.28900020778907964d, y: 0.8361577382155688d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8607447338860753d, y: 0.29969086905597775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2475630289126497d, y: 0.6633894886325903d), new NpgsqlTypes.NpgsqlPoint(x: 0.09104190580987881d, y: 0.7987685562116159d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8983731782451899d, y: 0.5474740104001747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182026163745044d, y: 0.17218230295274062d), new NpgsqlTypes.NpgsqlPoint(x: 0.4196424151791728d, y: 0.6069136051998334d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22472919763247168d, y: 0.6798537115809208d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551849096937999d, y: 0.7192767203080735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3979347562311455d, y: 0.7617735088093134d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7290630674760679d, y: 0.3500905368111902d), new NpgsqlTypes.NpgsqlPoint(x: 0.29819572530170924d, y: 0.14261600961918575d), new NpgsqlTypes.NpgsqlPoint(x: 0.35096720411261495d, y: 0.5510135403759495d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5081451821373141d, y: 0.7381499087319795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800475424489419d, y: 0.7559381958310714d), new NpgsqlTypes.NpgsqlPoint(x: 0.33340847659591744d, y: 0.9421908658392626d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2567066392196602d, y: 0.5790164049556691d), new NpgsqlTypes.NpgsqlPoint(x: 0.8462675183584998d, y: 0.9730179927287433d), new NpgsqlTypes.NpgsqlPoint(x: 0.07538992375008557d, y: 0.49619124745360066d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5458800780892691d, y: 0.21047802790305425d), new NpgsqlTypes.NpgsqlPoint(x: 0.824629220390081d, y: 0.8352575668549367d), new NpgsqlTypes.NpgsqlPoint(x: 0.0838230584212617d, y: 0.5827760869879487d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.215026404534842d, y: 0.028265968143295295d), new NpgsqlTypes.NpgsqlPoint(x: 0.41608603409625267d, y: 0.21145406051802007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5501958615561364d, y: 0.7078590524301706d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0963885608931313d, y: 0.33866389577914435d), new NpgsqlTypes.NpgsqlPoint(x: 0.40263340668198777d, y: 0.33965915937178437d), new NpgsqlTypes.NpgsqlPoint(x: 0.15710272374376433d, y: 0.6387554788002263d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2821096136961715d, y: 0.6188972248622433d), new NpgsqlTypes.NpgsqlPoint(x: 0.4918364956040139d, y: 0.10846222247451598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4772856535248684d, y: 0.4847152866199914d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38307806841285286d, y: 0.2543116748715133d), new NpgsqlTypes.NpgsqlPoint(x: 0.593154918750853d, y: 0.3400502041267377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245032713063682d, y: 0.1067756386841866d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4052282757290915d, y: 0.7370262674383825d), new NpgsqlTypes.NpgsqlPoint(x: 0.003318068336155222d, y: 0.988325434750932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443838919852716d, y: 0.5127248792966144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9352693465127996d, y: 0.972825955423745d), new NpgsqlTypes.NpgsqlPoint(x: 0.18931218335360112d, y: 0.1390255061826149d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818469409034568d, y: 0.658227069483009d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33592762286015876d, y: 0.548468711077957d), new NpgsqlTypes.NpgsqlPoint(x: 0.46420397241525524d, y: 0.7707177202109646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241034284339021d, y: 0.4567107330334943d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06199587965292652d, y: 0.5289559272516806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9749331338291766d, y: 0.11400805335418407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132095335522185d, y: 0.39072479461172005d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2735885345042861d, y: 0.4350270691349779d), new NpgsqlTypes.NpgsqlPoint(x: 0.001154662284501784d, y: 0.46640777353916807d), new NpgsqlTypes.NpgsqlPoint(x: 0.05602092248377388d, y: 0.8806551701111979d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3076229438272585d, y: 0.04734799486972319d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102515526071403d, y: 0.903828195221976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324616788644933d, y: 0.41366950725733465d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6104315448241528d, y: 0.6117562072903052d), new NpgsqlTypes.NpgsqlPoint(x: 0.3426839986987892d, y: 0.7619787535616184d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813181765155063d, y: 0.6699989461663731d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7215150924490317d, y: 0.592360668027126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290172605588614d, y: 0.4738308244416981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864945555405013d, y: 0.5943953947907455d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8800568643944194d, y: 0.14346912670000334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015148619618689d, y: 0.9443941318663048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5237142134654188d, y: 0.4536725636342931d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39803551490508005d, y: 0.35009806594084203d), new NpgsqlTypes.NpgsqlPoint(x: 0.718225089779281d, y: 0.6930209678733855d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883819872654756d, y: 0.39250203482296164d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4813414516076191d, y: 0.01377095031990827d), new NpgsqlTypes.NpgsqlPoint(x: 0.44437076236283635d, y: 0.6283481554528173d), new NpgsqlTypes.NpgsqlPoint(x: 0.038326969903602515d, y: 0.40129912719957195d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8447532465562799d, y: 0.5633827891164557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6491997459954675d, y: 0.9631443709210676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3002522485697011d, y: 0.6834445467751669d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2937879828969553d, y: 0.2972512180851056d), new NpgsqlTypes.NpgsqlPoint(x: 0.87110842876555d, y: 0.29884855495242857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9708275274223279d, y: 0.9453093872021282d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03682383473339457d, y: 0.6007816861159511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309223396366971d, y: 0.49957024263582817d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503872167358729d, y: 0.9982289406524913d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8957620037699933d, y: 0.6108943051533d), new NpgsqlTypes.NpgsqlPoint(x: 0.25967068572392793d, y: 0.10176942285199453d), new NpgsqlTypes.NpgsqlPoint(x: 0.14545683786134267d, y: 0.5893298343652067d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5037092691573933d, y: 0.17791720679322442d), new NpgsqlTypes.NpgsqlPoint(x: 0.19125948657277647d, y: 0.26188461861849444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285988527135685d, y: 0.6059805864569894d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6064665292433776d, y: 0.882824683942671d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061172903775338d, y: 0.1928889853310013d), new NpgsqlTypes.NpgsqlPoint(x: 0.01661430910349182d, y: 0.6395103796075767d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016007038626248193d, y: 0.6124918184845399d), new NpgsqlTypes.NpgsqlPoint(x: 0.753272685562708d, y: 0.9321544795647332d), new NpgsqlTypes.NpgsqlPoint(x: 0.1793363808928301d, y: 0.7683559156379395d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41006384656564565d, y: 0.35300896806585236d), new NpgsqlTypes.NpgsqlPoint(x: 0.2531868473536968d, y: 0.862043976844407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896322685857839d, y: 0.9127321311969112d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4817455813410527d, y: 0.0628092566742312d), new NpgsqlTypes.NpgsqlPoint(x: 0.3585513246251214d, y: 0.6473595474501589d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454019497891154d, y: 0.03368253547753064d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042163334909201655d, y: 0.35421687156959714d), new NpgsqlTypes.NpgsqlPoint(x: 0.989376859633718d, y: 0.7159550230372234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6404194682723662d, y: 0.7478242162305879d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3778340242356063d, y: 0.18615079362106213d), new NpgsqlTypes.NpgsqlPoint(x: 0.752619306341367d, y: 0.7061309502138036d), new NpgsqlTypes.NpgsqlPoint(x: 0.33111976661249587d, y: 0.3382055771815463d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6663715019846703d, y: 0.926938442711607d), new NpgsqlTypes.NpgsqlPoint(x: 0.1156245692658977d, y: 0.3907462554715003d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222752077385348d, y: 0.37226996467042495d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04262030586133536d, y: 0.7830611139368654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5635973683556348d, y: 0.6901516722112616d), new NpgsqlTypes.NpgsqlPoint(x: 0.009024201348723948d, y: 0.6569988394894605d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18816978609541812d, y: 0.5350558508103618d), new NpgsqlTypes.NpgsqlPoint(x: 0.17881175050642661d, y: 0.4461341700333905d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472689898385688d, y: 0.8889943914731887d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9663304429614837d, y: 0.8044599670449092d), new NpgsqlTypes.NpgsqlPoint(x: 0.32094016728379027d, y: 0.9277710347948424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9873727095760056d, y: 0.18950009980155902d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.720081513565905d, y: 0.2878347611994817d), new NpgsqlTypes.NpgsqlPoint(x: 0.270074375113564d, y: 0.9982916209110406d), new NpgsqlTypes.NpgsqlPoint(x: 0.3798533196840873d, y: 0.9104043440237561d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11108702754826283d, y: 0.4874025967570651d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280836330770945d, y: 0.8704444189685497d), new NpgsqlTypes.NpgsqlPoint(x: 0.14665023582295922d, y: 0.5411188983016888d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11639309633640726d, y: 0.6144477732080054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6835695893001618d, y: 0.296879172549543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480299356841555d, y: 0.8963955882339802d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5825687700232047d, y: 0.5254183946482684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6779931796208161d, y: 0.3621639678530766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071350464622058d, y: 0.2521830890311283d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42332456553806763d, y: 0.3511744246774018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6926818414013388d, y: 0.7522823353908439d), new NpgsqlTypes.NpgsqlPoint(x: 0.3728325498529854d, y: 0.49066071470662465d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4527174551840565d, y: 0.4093314394531221d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933376632401274d, y: 0.34614127771904446d), new NpgsqlTypes.NpgsqlPoint(x: 0.2802686211245875d, y: 0.5322855812989852d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8016773713751345d, y: 0.19527850751900055d), new NpgsqlTypes.NpgsqlPoint(x: 0.22536874098844417d, y: 0.44989085382770455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440621844324049d, y: 0.8344783926865496d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9753707328921553d, y: 0.3796855348292941d), new NpgsqlTypes.NpgsqlPoint(x: 0.37257913364009076d, y: 0.8327046033477594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774127252283748d, y: 0.590177637485429d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.492913040326428d, y: 0.45188576920773793d), new NpgsqlTypes.NpgsqlPoint(x: 0.38698645538243737d, y: 0.8671480995613573d), new NpgsqlTypes.NpgsqlPoint(x: 0.29670298480280255d, y: 0.9898672500293422d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4324593939540944d, y: 0.5927800976651687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537030824925868d, y: 0.9496549669173598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572315383652419d, y: 0.3852959354960157d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.644931860679397d, y: 0.8831872769939522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299226016466732d, y: 0.711022297654897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7502674884719307d, y: 0.8593628239999369d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5699652692776003d, y: 0.7397758525588626d), new NpgsqlTypes.NpgsqlPoint(x: 0.24129054178699882d, y: 0.16197914990215756d), new NpgsqlTypes.NpgsqlPoint(x: 0.4743635811744612d, y: 0.8149347518739144d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.023143454880199532d, y: 0.2272685117242912d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835789881264232d, y: 0.9035169116969378d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024721560051562674d, y: 0.922188517760455d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8981301976666947d, y: 0.9272252780474609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978816373522851d, y: 0.957197030510249d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307860839837838d, y: 0.2818598097811481d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5312532061372081d, y: 0.25498877395114994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7931576637578772d, y: 0.34129332234701815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496602670685517d, y: 0.9815742390003336d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.994376885193912d, y: 0.692274518086973d), new NpgsqlTypes.NpgsqlPoint(x: 0.48235545799358215d, y: 0.8362727451195879d), new NpgsqlTypes.NpgsqlPoint(x: 0.7332975334346432d, y: 0.20485902326059158d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4910163682540374d, y: 0.2899293314016681d), new NpgsqlTypes.NpgsqlPoint(x: 0.3972979037062576d, y: 0.07324089545856349d), new NpgsqlTypes.NpgsqlPoint(x: 0.4799129689870626d, y: 0.7406774354024666d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5244778862118207d, y: 0.1404172782799764d), new NpgsqlTypes.NpgsqlPoint(x: 0.1419166359432139d, y: 0.9003360397868571d), new NpgsqlTypes.NpgsqlPoint(x: 0.061459520930299605d, y: 0.393373700713303d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5836269556923401d, y: 0.5774791240245893d), new NpgsqlTypes.NpgsqlPoint(x: 0.33403809659159234d, y: 0.024406884928693695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9666386192691799d, y: 0.4297187487418339d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6719859038526976d, y: 0.8485354000060672d), new NpgsqlTypes.NpgsqlPoint(x: 0.6214948550194451d, y: 0.8740058817581524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942900694582612d, y: 0.9908799166662191d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3145291791011381d, y: 0.32203320312411987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342613794551657d, y: 0.1150552603979883d), new NpgsqlTypes.NpgsqlPoint(x: 0.20291481596588834d, y: 0.618405742142478d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20140249932000753d, y: 0.7738097108706594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4677914674172855d, y: 0.020781261892478864d), new NpgsqlTypes.NpgsqlPoint(x: 0.4809439268907816d, y: 0.08971175837943535d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40355351978105947d, y: 0.1655629888357758d), new NpgsqlTypes.NpgsqlPoint(x: 0.899536692964362d, y: 0.8440293747467646d), new NpgsqlTypes.NpgsqlPoint(x: 0.03432626382586146d, y: 0.9097827786856983d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13040941785962068d, y: 0.0753632855487325d), new NpgsqlTypes.NpgsqlPoint(x: 0.482288654395846d, y: 0.12775805141857033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115586883663763d, y: 0.9908932854786774d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.627888813542669d, y: 0.7978463672852453d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351099798866942d, y: 0.39965054217684515d), new NpgsqlTypes.NpgsqlPoint(x: 0.7250452561442361d, y: 0.9982097340829983d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8145582896077972d, y: 0.06585654528024487d), new NpgsqlTypes.NpgsqlPoint(x: 0.44503450533542044d, y: 0.37665138786530383d), new NpgsqlTypes.NpgsqlPoint(x: 0.3942103385874217d, y: 0.31933711859223746d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9396967632590129d, y: 0.06973115409066466d), new NpgsqlTypes.NpgsqlPoint(x: 0.2666544807106209d, y: 0.939989566206559d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499430869012144d, y: 0.2967621538895847d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21230653171740854d, y: 0.2891972776435754d), new NpgsqlTypes.NpgsqlPoint(x: 0.1901646774969975d, y: 0.6141051758420918d), new NpgsqlTypes.NpgsqlPoint(x: 0.28900020778907964d, y: 0.8361577382155688d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8607447338860753d, y: 0.29969086905597775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2475630289126497d, y: 0.6633894886325903d), new NpgsqlTypes.NpgsqlPoint(x: 0.09104190580987881d, y: 0.7987685562116159d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8983731782451899d, y: 0.5474740104001747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182026163745044d, y: 0.17218230295274062d), new NpgsqlTypes.NpgsqlPoint(x: 0.4196424151791728d, y: 0.6069136051998334d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22472919763247168d, y: 0.6798537115809208d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551849096937999d, y: 0.7192767203080735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3979347562311455d, y: 0.7617735088093134d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7290630674760679d, y: 0.3500905368111902d), new NpgsqlTypes.NpgsqlPoint(x: 0.29819572530170924d, y: 0.14261600961918575d), new NpgsqlTypes.NpgsqlPoint(x: 0.35096720411261495d, y: 0.5510135403759495d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5081451821373141d, y: 0.7381499087319795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800475424489419d, y: 0.7559381958310714d), new NpgsqlTypes.NpgsqlPoint(x: 0.33340847659591744d, y: 0.9421908658392626d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2567066392196602d, y: 0.5790164049556691d), new NpgsqlTypes.NpgsqlPoint(x: 0.8462675183584998d, y: 0.9730179927287433d), new NpgsqlTypes.NpgsqlPoint(x: 0.07538992375008557d, y: 0.49619124745360066d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5458800780892691d, y: 0.21047802790305425d), new NpgsqlTypes.NpgsqlPoint(x: 0.824629220390081d, y: 0.8352575668549367d), new NpgsqlTypes.NpgsqlPoint(x: 0.0838230584212617d, y: 0.5827760869879487d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.215026404534842d, y: 0.028265968143295295d), new NpgsqlTypes.NpgsqlPoint(x: 0.41608603409625267d, y: 0.21145406051802007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5501958615561364d, y: 0.7078590524301706d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0963885608931313d, y: 0.33866389577914435d), new NpgsqlTypes.NpgsqlPoint(x: 0.40263340668198777d, y: 0.33965915937178437d), new NpgsqlTypes.NpgsqlPoint(x: 0.15710272374376433d, y: 0.6387554788002263d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2821096136961715d, y: 0.6188972248622433d), new NpgsqlTypes.NpgsqlPoint(x: 0.4918364956040139d, y: 0.10846222247451598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4772856535248684d, y: 0.4847152866199914d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38307806841285286d, y: 0.2543116748715133d), new NpgsqlTypes.NpgsqlPoint(x: 0.593154918750853d, y: 0.3400502041267377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245032713063682d, y: 0.1067756386841866d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4052282757290915d, y: 0.7370262674383825d), new NpgsqlTypes.NpgsqlPoint(x: 0.003318068336155222d, y: 0.988325434750932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443838919852716d, y: 0.5127248792966144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9352693465127996d, y: 0.972825955423745d), new NpgsqlTypes.NpgsqlPoint(x: 0.18931218335360112d, y: 0.1390255061826149d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818469409034568d, y: 0.658227069483009d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33592762286015876d, y: 0.548468711077957d), new NpgsqlTypes.NpgsqlPoint(x: 0.46420397241525524d, y: 0.7707177202109646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241034284339021d, y: 0.4567107330334943d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06199587965292652d, y: 0.5289559272516806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9749331338291766d, y: 0.11400805335418407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132095335522185d, y: 0.39072479461172005d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2735885345042861d, y: 0.4350270691349779d), new NpgsqlTypes.NpgsqlPoint(x: 0.001154662284501784d, y: 0.46640777353916807d), new NpgsqlTypes.NpgsqlPoint(x: 0.05602092248377388d, y: 0.8806551701111979d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3076229438272585d, y: 0.04734799486972319d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102515526071403d, y: 0.903828195221976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324616788644933d, y: 0.41366950725733465d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6104315448241528d, y: 0.6117562072903052d), new NpgsqlTypes.NpgsqlPoint(x: 0.3426839986987892d, y: 0.7619787535616184d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813181765155063d, y: 0.6699989461663731d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7215150924490317d, y: 0.592360668027126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290172605588614d, y: 0.4738308244416981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864945555405013d, y: 0.5943953947907455d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8800568643944194d, y: 0.14346912670000334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015148619618689d, y: 0.9443941318663048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5237142134654188d, y: 0.4536725636342931d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39803551490508005d, y: 0.35009806594084203d), new NpgsqlTypes.NpgsqlPoint(x: 0.718225089779281d, y: 0.6930209678733855d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883819872654756d, y: 0.39250203482296164d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4813414516076191d, y: 0.01377095031990827d), new NpgsqlTypes.NpgsqlPoint(x: 0.44437076236283635d, y: 0.6283481554528173d), new NpgsqlTypes.NpgsqlPoint(x: 0.038326969903602515d, y: 0.40129912719957195d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8447532465562799d, y: 0.5633827891164557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6491997459954675d, y: 0.9631443709210676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3002522485697011d, y: 0.6834445467751669d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2937879828969553d, y: 0.2972512180851056d), new NpgsqlTypes.NpgsqlPoint(x: 0.87110842876555d, y: 0.29884855495242857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9708275274223279d, y: 0.9453093872021282d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03682383473339457d, y: 0.6007816861159511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309223396366971d, y: 0.49957024263582817d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503872167358729d, y: 0.9982289406524913d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8957620037699933d, y: 0.6108943051533d), new NpgsqlTypes.NpgsqlPoint(x: 0.25967068572392793d, y: 0.10176942285199453d), new NpgsqlTypes.NpgsqlPoint(x: 0.14545683786134267d, y: 0.5893298343652067d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5037092691573933d, y: 0.17791720679322442d), new NpgsqlTypes.NpgsqlPoint(x: 0.19125948657277647d, y: 0.26188461861849444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285988527135685d, y: 0.6059805864569894d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6064665292433776d, y: 0.882824683942671d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061172903775338d, y: 0.1928889853310013d), new NpgsqlTypes.NpgsqlPoint(x: 0.01661430910349182d, y: 0.6395103796075767d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016007038626248193d, y: 0.6124918184845399d), new NpgsqlTypes.NpgsqlPoint(x: 0.753272685562708d, y: 0.9321544795647332d), new NpgsqlTypes.NpgsqlPoint(x: 0.1793363808928301d, y: 0.7683559156379395d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41006384656564565d, y: 0.35300896806585236d), new NpgsqlTypes.NpgsqlPoint(x: 0.2531868473536968d, y: 0.862043976844407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896322685857839d, y: 0.9127321311969112d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4817455813410527d, y: 0.0628092566742312d), new NpgsqlTypes.NpgsqlPoint(x: 0.3585513246251214d, y: 0.6473595474501589d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454019497891154d, y: 0.03368253547753064d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042163334909201655d, y: 0.35421687156959714d), new NpgsqlTypes.NpgsqlPoint(x: 0.989376859633718d, y: 0.7159550230372234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6404194682723662d, y: 0.7478242162305879d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3778340242356063d, y: 0.18615079362106213d), new NpgsqlTypes.NpgsqlPoint(x: 0.752619306341367d, y: 0.7061309502138036d), new NpgsqlTypes.NpgsqlPoint(x: 0.33111976661249587d, y: 0.3382055771815463d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6663715019846703d, y: 0.926938442711607d), new NpgsqlTypes.NpgsqlPoint(x: 0.1156245692658977d, y: 0.3907462554715003d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222752077385348d, y: 0.37226996467042495d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04262030586133536d, y: 0.7830611139368654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5635973683556348d, y: 0.6901516722112616d), new NpgsqlTypes.NpgsqlPoint(x: 0.009024201348723948d, y: 0.6569988394894605d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18816978609541812d, y: 0.5350558508103618d), new NpgsqlTypes.NpgsqlPoint(x: 0.17881175050642661d, y: 0.4461341700333905d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472689898385688d, y: 0.8889943914731887d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9663304429614837d, y: 0.8044599670449092d), new NpgsqlTypes.NpgsqlPoint(x: 0.32094016728379027d, y: 0.9277710347948424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9873727095760056d, y: 0.18950009980155902d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.720081513565905d, y: 0.2878347611994817d), new NpgsqlTypes.NpgsqlPoint(x: 0.270074375113564d, y: 0.9982916209110406d), new NpgsqlTypes.NpgsqlPoint(x: 0.3798533196840873d, y: 0.9104043440237561d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11108702754826283d, y: 0.4874025967570651d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280836330770945d, y: 0.8704444189685497d), new NpgsqlTypes.NpgsqlPoint(x: 0.14665023582295922d, y: 0.5411188983016888d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11639309633640726d, y: 0.6144477732080054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6835695893001618d, y: 0.296879172549543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480299356841555d, y: 0.8963955882339802d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5825687700232047d, y: 0.5254183946482684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6779931796208161d, y: 0.3621639678530766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071350464622058d, y: 0.2521830890311283d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42332456553806763d, y: 0.3511744246774018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6926818414013388d, y: 0.7522823353908439d), new NpgsqlTypes.NpgsqlPoint(x: 0.3728325498529854d, y: 0.49066071470662465d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4527174551840565d, y: 0.4093314394531221d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933376632401274d, y: 0.34614127771904446d), new NpgsqlTypes.NpgsqlPoint(x: 0.2802686211245875d, y: 0.5322855812989852d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8016773713751345d, y: 0.19527850751900055d), new NpgsqlTypes.NpgsqlPoint(x: 0.22536874098844417d, y: 0.44989085382770455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440621844324049d, y: 0.8344783926865496d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9753707328921553d, y: 0.3796855348292941d), new NpgsqlTypes.NpgsqlPoint(x: 0.37257913364009076d, y: 0.8327046033477594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774127252283748d, y: 0.590177637485429d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.492913040326428d, y: 0.45188576920773793d), new NpgsqlTypes.NpgsqlPoint(x: 0.38698645538243737d, y: 0.8671480995613573d), new NpgsqlTypes.NpgsqlPoint(x: 0.29670298480280255d, y: 0.9898672500293422d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4324593939540944d, y: 0.5927800976651687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537030824925868d, y: 0.9496549669173598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572315383652419d, y: 0.3852959354960157d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.644931860679397d, y: 0.8831872769939522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299226016466732d, y: 0.711022297654897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7502674884719307d, y: 0.8593628239999369d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5699652692776003d, y: 0.7397758525588626d), new NpgsqlTypes.NpgsqlPoint(x: 0.24129054178699882d, y: 0.16197914990215756d), new NpgsqlTypes.NpgsqlPoint(x: 0.4743635811744612d, y: 0.8149347518739144d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.023143454880199532d, y: 0.2272685117242912d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835789881264232d, y: 0.9035169116969378d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024721560051562674d, y: 0.922188517760455d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8981301976666947d, y: 0.9272252780474609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978816373522851d, y: 0.957197030510249d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307860839837838d, y: 0.2818598097811481d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5312532061372081d, y: 0.25498877395114994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7931576637578772d, y: 0.34129332234701815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496602670685517d, y: 0.9815742390003336d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.994376885193912d, y: 0.692274518086973d), new NpgsqlTypes.NpgsqlPoint(x: 0.48235545799358215d, y: 0.8362727451195879d), new NpgsqlTypes.NpgsqlPoint(x: 0.7332975334346432d, y: 0.20485902326059158d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4910163682540374d, y: 0.2899293314016681d), new NpgsqlTypes.NpgsqlPoint(x: 0.3972979037062576d, y: 0.07324089545856349d), new NpgsqlTypes.NpgsqlPoint(x: 0.4799129689870626d, y: 0.7406774354024666d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5244778862118207d, y: 0.1404172782799764d), new NpgsqlTypes.NpgsqlPoint(x: 0.1419166359432139d, y: 0.9003360397868571d), new NpgsqlTypes.NpgsqlPoint(x: 0.061459520930299605d, y: 0.393373700713303d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5836269556923401d, y: 0.5774791240245893d), new NpgsqlTypes.NpgsqlPoint(x: 0.33403809659159234d, y: 0.024406884928693695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9666386192691799d, y: 0.4297187487418339d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6719859038526976d, y: 0.8485354000060672d), new NpgsqlTypes.NpgsqlPoint(x: 0.6214948550194451d, y: 0.8740058817581524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942900694582612d, y: 0.9908799166662191d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3145291791011381d, y: 0.32203320312411987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342613794551657d, y: 0.1150552603979883d), new NpgsqlTypes.NpgsqlPoint(x: 0.20291481596588834d, y: 0.618405742142478d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20140249932000753d, y: 0.7738097108706594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4677914674172855d, y: 0.020781261892478864d), new NpgsqlTypes.NpgsqlPoint(x: 0.4809439268907816d, y: 0.08971175837943535d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40355351978105947d, y: 0.1655629888357758d), new NpgsqlTypes.NpgsqlPoint(x: 0.899536692964362d, y: 0.8440293747467646d), new NpgsqlTypes.NpgsqlPoint(x: 0.03432626382586146d, y: 0.9097827786856983d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13040941785962068d, y: 0.0753632855487325d), new NpgsqlTypes.NpgsqlPoint(x: 0.482288654395846d, y: 0.12775805141857033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115586883663763d, y: 0.9908932854786774d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.627888813542669d, y: 0.7978463672852453d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351099798866942d, y: 0.39965054217684515d), new NpgsqlTypes.NpgsqlPoint(x: 0.7250452561442361d, y: 0.9982097340829983d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8145582896077972d, y: 0.06585654528024487d), new NpgsqlTypes.NpgsqlPoint(x: 0.44503450533542044d, y: 0.37665138786530383d), new NpgsqlTypes.NpgsqlPoint(x: 0.3942103385874217d, y: 0.31933711859223746d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9396967632590129d, y: 0.06973115409066466d), new NpgsqlTypes.NpgsqlPoint(x: 0.2666544807106209d, y: 0.939989566206559d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499430869012144d, y: 0.2967621538895847d)))));

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0M>(15);

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
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

