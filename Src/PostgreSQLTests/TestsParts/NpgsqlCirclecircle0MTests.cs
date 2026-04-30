

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
    internal partial interface INpgsqlCircleSingleTypecircle
    {
    }
    
    internal partial class NpgsqlCircleSingleTypecircle : INpgsqlCircleSingleTypecircle
    {


#region TestData

        private readonly NpgsqlCirclecircle0M[] _testData = new NpgsqlCirclecircle0M[]
        {
            new NpgsqlCirclecircle0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7016578980302425d, y: 0.49813072104910827d), radius: 0.25914203135771574d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15960185954792738d, y: 0.3725363896738523d), radius: 0.833206352888764d),
},
            new NpgsqlCirclecircle0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6407370238636201d, y: 0.9453183099807573d), radius: 0.9612919752542167d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.294983831022228d, y: 0.5146574414284228d), radius: 0.7172429891015434d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1745740955606534d, y: 0.7520316773271494d), radius: 0.8118295239032598d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4030246952063614d, y: 0.48802548397846446d), radius: 0.6664956399593666d),
},
            new NpgsqlCirclecircle0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12244277044189555d, y: 0.7863167704249301d), radius: 0.47902041359480196d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47755583552106506d, y: 0.17552758829652582d), radius: 0.2916026599512972d),
},
            new NpgsqlCirclecircle0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8755997946782069d, y: 0.03113626143630488d), radius: 0.8778069595641943d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33762633717907475d, y: 0.5486815883435865d), radius: 0.9450980675845997d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5730859058745849d, y: 0.6372922109204742d), radius: 0.4085905234595464d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8097164822051386d, y: 0.53114036395602d), radius: 0.3934611912833529d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8193856225622522d, y: 0.31212106841506004d), radius: 0.9356776773125324d),
},
            new NpgsqlCirclecircle0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23070575904558188d, y: 0.7733334180664497d), radius: 0.673340118419084d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6234121164695987d, y: 0.09766037710918662d), radius: 0.8533243751497486d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08037518967409574d, y: 0.1997948895583601d), radius: 0.24651996565841172d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9490832102374244d, y: 0.801480233464308d), radius: 0.9315309656211476d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5571390078923145d, y: 0.48831591293998633d), radius: 0.5158152946284655d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3416240916251372d, y: 0.1835886782938193d), radius: 0.6741480062736366d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6857543808511968d, y: 0.2458222442157324d), radius: 0.20541170280562027d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41481881104657936d, y: 0.4262763283532408d), radius: 0.39455056563783186d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9486055344256082d, y: 0.11890249150180421d), radius: 0.28170036457169956d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4244362312274388d, y: 0.08015739727227722d), radius: 0.6393979767176938d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1539723063676619d, y: 0.5430543017859999d), radius: 0.523303565067941d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4145375109708238d, y: 0.741661162136991d), radius: 0.18697612523385332d),
},
            new NpgsqlCirclecircle0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03793504127043279d, y: 0.41167151319726136d), radius: 0.1975420885358754d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10991298643950909d, y: 0.2555958513635723d), radius: 0.19406237060157738d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9091186051244998d, y: 0.0032672296798927913d), radius: 0.5778944752899052d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.81750941556185d, y: 0.03564577773548716d), radius: 0.4101911063099214d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7991417509724718d, y: 0.9948441682499736d), radius: 0.3536196993410491d),
},
            new NpgsqlCirclecircle0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6557192493623087d, y: 0.49347341553158075d), radius: 0.10019021079892021d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6351602533605796d, y: 0.1722225869714743d), radius: 0.07412971560597448d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10757079960475846d, y: 0.26334362705938097d), radius: 0.4928739747640236d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36952058847396585d, y: 0.6632351200044588d), radius: 0.20713718472596854d),
},
            new NpgsqlCirclecircle0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08497021776547964d, y: 0.909329647683883d), radius: 0.7184979587728305d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8023097422558667d, y: 0.3446962601106581d), radius: 0.4385606797177326d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6147306129867329d, y: 0.8814295085181928d), radius: 0.3056412317509136d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3786902114243704d, y: 0.5609562311838605d), radius: 0.372288326909994d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4443259054525589d, y: 0.17835520506999425d), radius: 0.9932557080435078d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15802912689640036d, y: 0.5025222364932275d), radius: 0.9760574539547957d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3223478810452831d, y: 0.42919864128731267d), radius: 0.14240143581616438d),
},
            new NpgsqlCirclecircle0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7164746547949978d, y: 0.27358118280388666d), radius: 0.8374269304648142d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7611170996576653d, y: 0.2958507491389052d), radius: 0.9934439960820001d),
},
            new NpgsqlCirclecircle0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5607685962583496d, y: 0.4754952539609778d), radius: 0.17528704251917981d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2024774948795175d, y: 0.6508743008263926d), radius: 0.7199888289321447d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3405111336484238d, y: 0.8583792062976549d), radius: 0.33998577191084867d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4554488534793958d, y: 0.744261170979669d), radius: 0.27486277686976057d),
},
            new NpgsqlCirclecircle0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14947942976171902d, y: 0.8578618457914248d), radius: 0.890848971290542d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9693797779519495d, y: 0.05883496597242044d), radius: 0.5888627530332479d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3991964100862815d, y: 0.7759820074888683d), radius: 0.18512163707693863d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.56881292975662d, y: 0.01870488708446516d), radius: 0.7523052118515583d),
},
            new NpgsqlCirclecircle0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6524312705025193d, y: 0.8430438571430705d), radius: 0.7276168767940319d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42908243886656816d, y: 0.19268317988157757d), radius: 0.056670544129177935d),
},
            new NpgsqlCirclecircle0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43732784933650604d, y: 0.8250189236507379d), radius: 0.6183937058045d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7824806971898679d, y: 0.6959655378259096d), radius: 0.4095929333515632d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4347127838804825d, y: 0.9442160268060725d), radius: 0.47379413089083d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3691858115160296d, y: 0.2590086572260888d), radius: 0.5382854291785205d),
},
            new NpgsqlCirclecircle0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3684551419726797d, y: 0.04708780546235314d), radius: 0.09300170972740252d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667822725407898d, y: 0.022188536878110954d), radius: 0.9212765070773148d),
},
            new NpgsqlCirclecircle0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2224528571181924d, y: 0.737597669584867d), radius: 0.1916654542319317d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34671335025724437d, y: 0.13307044416387326d), radius: 0.32782535986579886d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.292963276014616d, y: 0.8360014912666774d), radius: 0.9970011562118608d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31765927422709994d, y: 0.06188476533734899d), radius: 0.35067579214087896d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3102827448375668d, y: 0.42973305409830587d), radius: 0.7775684893546657d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3489674303301623d, y: 0.14500223576525118d), radius: 0.07743351084671779d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34923006443774396d, y: 0.2346226388063144d), radius: 0.8070937611898439d),
},
            new NpgsqlCirclecircle0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0404447104469674d, y: 0.8787950992573509d), radius: 0.3463261736378457d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.040947211150080376d, y: 0.4549245822625596d), radius: 0.05124769261280793d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.834656559132241d, y: 0.11238699969137067d), radius: 0.649455886021107d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8314732607185811d, y: 0.6555730797637255d), radius: 0.05819301993842041d),
},
            new NpgsqlCirclecircle0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4437892071450208d, y: 0.26625451551398505d), radius: 0.9523211338644694d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5377381818328766d, y: 0.5515364325967164d), radius: 0.09591185972995275d),
},
            new NpgsqlCirclecircle0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7053733759115084d, y: 0.7069889482546466d), radius: 0.49883388261432704d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6866625556125612d, y: 0.16653344407415782d), radius: 0.8586888335581108d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1718987834320027d, y: 0.7189993444648298d), radius: 0.17094249376206316d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7852930985711649d, y: 0.21065317792317917d), radius: 0.47768290779682865d),
},
            new NpgsqlCirclecircle0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.576061482990803d, y: 0.17128726952965612d), radius: 0.4142768166215113d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1252368602132925d, y: 0.5279041887793817d), radius: 0.36296757225835874d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5179266028438686d, y: 0.19003601471623233d), radius: 0.9239191468670492d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8193856225622522d, y: 0.31212106841506004d), radius: 0.9356776773125324d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4145375109708238d, y: 0.741661162136991d), radius: 0.18697612523385332d)));
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecircle0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlCircle), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlcirclecircle0mi_id", 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 26;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 143;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 46, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 128, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 65, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 106, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 101, query1, 99, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 150, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 99, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 12, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[29], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[30], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[31], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[32], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[33], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 156);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[33], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7016578980302425d, y: 0.49813072104910827d), radius: 0.25914203135771574d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15960185954792738d, y: 0.3725363896738523d), radius: 0.833206352888764d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6407370238636201d, y: 0.9453183099807573d), radius: 0.9612919752542167d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.294983831022228d, y: 0.5146574414284228d), radius: 0.7172429891015434d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1745740955606534d, y: 0.7520316773271494d), radius: 0.8118295239032598d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4030246952063614d, y: 0.48802548397846446d), radius: 0.6664956399593666d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12244277044189555d, y: 0.7863167704249301d), radius: 0.47902041359480196d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47755583552106506d, y: 0.17552758829652582d), radius: 0.2916026599512972d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8755997946782069d, y: 0.03113626143630488d), radius: 0.8778069595641943d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33762633717907475d, y: 0.5486815883435865d), radius: 0.9450980675845997d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5730859058745849d, y: 0.6372922109204742d), radius: 0.4085905234595464d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8097164822051386d, y: 0.53114036395602d), radius: 0.3934611912833529d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8193856225622522d, y: 0.31212106841506004d), radius: 0.9356776773125324d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23070575904558188d, y: 0.7733334180664497d), radius: 0.673340118419084d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6234121164695987d, y: 0.09766037710918662d), radius: 0.8533243751497486d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08037518967409574d, y: 0.1997948895583601d), radius: 0.24651996565841172d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9490832102374244d, y: 0.801480233464308d), radius: 0.9315309656211476d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5571390078923145d, y: 0.48831591293998633d), radius: 0.5158152946284655d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3416240916251372d, y: 0.1835886782938193d), radius: 0.6741480062736366d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6857543808511968d, y: 0.2458222442157324d), radius: 0.20541170280562027d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41481881104657936d, y: 0.4262763283532408d), radius: 0.39455056563783186d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9486055344256082d, y: 0.11890249150180421d), radius: 0.28170036457169956d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4244362312274388d, y: 0.08015739727227722d), radius: 0.6393979767176938d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1539723063676619d, y: 0.5430543017859999d), radius: 0.523303565067941d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4145375109708238d, y: 0.741661162136991d), radius: 0.18697612523385332d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03793504127043279d, y: 0.41167151319726136d), radius: 0.1975420885358754d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10991298643950909d, y: 0.2555958513635723d), radius: 0.19406237060157738d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9091186051244998d, y: 0.0032672296798927913d), radius: 0.5778944752899052d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.81750941556185d, y: 0.03564577773548716d), radius: 0.4101911063099214d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7991417509724718d, y: 0.9948441682499736d), radius: 0.3536196993410491d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6557192493623087d, y: 0.49347341553158075d), radius: 0.10019021079892021d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6351602533605796d, y: 0.1722225869714743d), radius: 0.07412971560597448d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10757079960475846d, y: 0.26334362705938097d), radius: 0.4928739747640236d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36952058847396585d, y: 0.6632351200044588d), radius: 0.20713718472596854d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08497021776547964d, y: 0.909329647683883d), radius: 0.7184979587728305d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8023097422558667d, y: 0.3446962601106581d), radius: 0.4385606797177326d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6147306129867329d, y: 0.8814295085181928d), radius: 0.3056412317509136d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3786902114243704d, y: 0.5609562311838605d), radius: 0.372288326909994d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4443259054525589d, y: 0.17835520506999425d), radius: 0.9932557080435078d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15802912689640036d, y: 0.5025222364932275d), radius: 0.9760574539547957d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3223478810452831d, y: 0.42919864128731267d), radius: 0.14240143581616438d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7164746547949978d, y: 0.27358118280388666d), radius: 0.8374269304648142d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7611170996576653d, y: 0.2958507491389052d), radius: 0.9934439960820001d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5607685962583496d, y: 0.4754952539609778d), radius: 0.17528704251917981d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2024774948795175d, y: 0.6508743008263926d), radius: 0.7199888289321447d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3405111336484238d, y: 0.8583792062976549d), radius: 0.33998577191084867d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4554488534793958d, y: 0.744261170979669d), radius: 0.27486277686976057d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14947942976171902d, y: 0.8578618457914248d), radius: 0.890848971290542d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9693797779519495d, y: 0.05883496597242044d), radius: 0.5888627530332479d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3991964100862815d, y: 0.7759820074888683d), radius: 0.18512163707693863d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.56881292975662d, y: 0.01870488708446516d), radius: 0.7523052118515583d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6524312705025193d, y: 0.8430438571430705d), radius: 0.7276168767940319d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42908243886656816d, y: 0.19268317988157757d), radius: 0.056670544129177935d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43732784933650604d, y: 0.8250189236507379d), radius: 0.6183937058045d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7824806971898679d, y: 0.6959655378259096d), radius: 0.4095929333515632d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4347127838804825d, y: 0.9442160268060725d), radius: 0.47379413089083d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3691858115160296d, y: 0.2590086572260888d), radius: 0.5382854291785205d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3684551419726797d, y: 0.04708780546235314d), radius: 0.09300170972740252d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667822725407898d, y: 0.022188536878110954d), radius: 0.9212765070773148d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2224528571181924d, y: 0.737597669584867d), radius: 0.1916654542319317d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34671335025724437d, y: 0.13307044416387326d), radius: 0.32782535986579886d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.292963276014616d, y: 0.8360014912666774d), radius: 0.9970011562118608d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31765927422709994d, y: 0.06188476533734899d), radius: 0.35067579214087896d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3102827448375668d, y: 0.42973305409830587d), radius: 0.7775684893546657d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3489674303301623d, y: 0.14500223576525118d), radius: 0.07743351084671779d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34923006443774396d, y: 0.2346226388063144d), radius: 0.8070937611898439d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0404447104469674d, y: 0.8787950992573509d), radius: 0.3463261736378457d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.040947211150080376d, y: 0.4549245822625596d), radius: 0.05124769261280793d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.834656559132241d, y: 0.11238699969137067d), radius: 0.649455886021107d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8314732607185811d, y: 0.6555730797637255d), radius: 0.05819301993842041d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4437892071450208d, y: 0.26625451551398505d), radius: 0.9523211338644694d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5377381818328766d, y: 0.5515364325967164d), radius: 0.09591185972995275d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7053733759115084d, y: 0.7069889482546466d), radius: 0.49883388261432704d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6866625556125612d, y: 0.16653344407415782d), radius: 0.8586888335581108d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1718987834320027d, y: 0.7189993444648298d), radius: 0.17094249376206316d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7852930985711649d, y: 0.21065317792317917d), radius: 0.47768290779682865d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.576061482990803d, y: 0.17128726952965612d), radius: 0.4142768166215113d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1252368602132925d, y: 0.5279041887793817d), radius: 0.36296757225835874d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5179266028438686d, y: 0.19003601471623233d), radius: 0.9239191468670492d))));//Value

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
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7016578980302425d, y: 0.49813072104910827d), radius: 0.25914203135771574d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15960185954792738d, y: 0.3725363896738523d), radius: 0.833206352888764d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6407370238636201d, y: 0.9453183099807573d), radius: 0.9612919752542167d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.294983831022228d, y: 0.5146574414284228d), radius: 0.7172429891015434d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1745740955606534d, y: 0.7520316773271494d), radius: 0.8118295239032598d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4030246952063614d, y: 0.48802548397846446d), radius: 0.6664956399593666d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12244277044189555d, y: 0.7863167704249301d), radius: 0.47902041359480196d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47755583552106506d, y: 0.17552758829652582d), radius: 0.2916026599512972d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8755997946782069d, y: 0.03113626143630488d), radius: 0.8778069595641943d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33762633717907475d, y: 0.5486815883435865d), radius: 0.9450980675845997d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5730859058745849d, y: 0.6372922109204742d), radius: 0.4085905234595464d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8097164822051386d, y: 0.53114036395602d), radius: 0.3934611912833529d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8193856225622522d, y: 0.31212106841506004d), radius: 0.9356776773125324d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23070575904558188d, y: 0.7733334180664497d), radius: 0.673340118419084d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6234121164695987d, y: 0.09766037710918662d), radius: 0.8533243751497486d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08037518967409574d, y: 0.1997948895583601d), radius: 0.24651996565841172d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9490832102374244d, y: 0.801480233464308d), radius: 0.9315309656211476d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5571390078923145d, y: 0.48831591293998633d), radius: 0.5158152946284655d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3416240916251372d, y: 0.1835886782938193d), radius: 0.6741480062736366d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6857543808511968d, y: 0.2458222442157324d), radius: 0.20541170280562027d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41481881104657936d, y: 0.4262763283532408d), radius: 0.39455056563783186d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9486055344256082d, y: 0.11890249150180421d), radius: 0.28170036457169956d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4244362312274388d, y: 0.08015739727227722d), radius: 0.6393979767176938d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1539723063676619d, y: 0.5430543017859999d), radius: 0.523303565067941d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4145375109708238d, y: 0.741661162136991d), radius: 0.18697612523385332d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03793504127043279d, y: 0.41167151319726136d), radius: 0.1975420885358754d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10991298643950909d, y: 0.2555958513635723d), radius: 0.19406237060157738d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9091186051244998d, y: 0.0032672296798927913d), radius: 0.5778944752899052d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.81750941556185d, y: 0.03564577773548716d), radius: 0.4101911063099214d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7991417509724718d, y: 0.9948441682499736d), radius: 0.3536196993410491d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6557192493623087d, y: 0.49347341553158075d), radius: 0.10019021079892021d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6351602533605796d, y: 0.1722225869714743d), radius: 0.07412971560597448d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10757079960475846d, y: 0.26334362705938097d), radius: 0.4928739747640236d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36952058847396585d, y: 0.6632351200044588d), radius: 0.20713718472596854d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08497021776547964d, y: 0.909329647683883d), radius: 0.7184979587728305d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8023097422558667d, y: 0.3446962601106581d), radius: 0.4385606797177326d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6147306129867329d, y: 0.8814295085181928d), radius: 0.3056412317509136d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3786902114243704d, y: 0.5609562311838605d), radius: 0.372288326909994d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4443259054525589d, y: 0.17835520506999425d), radius: 0.9932557080435078d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15802912689640036d, y: 0.5025222364932275d), radius: 0.9760574539547957d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3223478810452831d, y: 0.42919864128731267d), radius: 0.14240143581616438d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7164746547949978d, y: 0.27358118280388666d), radius: 0.8374269304648142d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7611170996576653d, y: 0.2958507491389052d), radius: 0.9934439960820001d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5607685962583496d, y: 0.4754952539609778d), radius: 0.17528704251917981d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2024774948795175d, y: 0.6508743008263926d), radius: 0.7199888289321447d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3405111336484238d, y: 0.8583792062976549d), radius: 0.33998577191084867d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4554488534793958d, y: 0.744261170979669d), radius: 0.27486277686976057d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14947942976171902d, y: 0.8578618457914248d), radius: 0.890848971290542d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9693797779519495d, y: 0.05883496597242044d), radius: 0.5888627530332479d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3991964100862815d, y: 0.7759820074888683d), radius: 0.18512163707693863d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.56881292975662d, y: 0.01870488708446516d), radius: 0.7523052118515583d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6524312705025193d, y: 0.8430438571430705d), radius: 0.7276168767940319d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42908243886656816d, y: 0.19268317988157757d), radius: 0.056670544129177935d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43732784933650604d, y: 0.8250189236507379d), radius: 0.6183937058045d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7824806971898679d, y: 0.6959655378259096d), radius: 0.4095929333515632d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4347127838804825d, y: 0.9442160268060725d), radius: 0.47379413089083d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3691858115160296d, y: 0.2590086572260888d), radius: 0.5382854291785205d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3684551419726797d, y: 0.04708780546235314d), radius: 0.09300170972740252d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667822725407898d, y: 0.022188536878110954d), radius: 0.9212765070773148d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2224528571181924d, y: 0.737597669584867d), radius: 0.1916654542319317d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34671335025724437d, y: 0.13307044416387326d), radius: 0.32782535986579886d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.292963276014616d, y: 0.8360014912666774d), radius: 0.9970011562118608d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31765927422709994d, y: 0.06188476533734899d), radius: 0.35067579214087896d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3102827448375668d, y: 0.42973305409830587d), radius: 0.7775684893546657d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3489674303301623d, y: 0.14500223576525118d), radius: 0.07743351084671779d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34923006443774396d, y: 0.2346226388063144d), radius: 0.8070937611898439d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0404447104469674d, y: 0.8787950992573509d), radius: 0.3463261736378457d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.040947211150080376d, y: 0.4549245822625596d), radius: 0.05124769261280793d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.834656559132241d, y: 0.11238699969137067d), radius: 0.649455886021107d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8314732607185811d, y: 0.6555730797637255d), radius: 0.05819301993842041d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4437892071450208d, y: 0.26625451551398505d), radius: 0.9523211338644694d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5377381818328766d, y: 0.5515364325967164d), radius: 0.09591185972995275d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7053733759115084d, y: 0.7069889482546466d), radius: 0.49883388261432704d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6866625556125612d, y: 0.16653344407415782d), radius: 0.8586888335581108d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1718987834320027d, y: 0.7189993444648298d), radius: 0.17094249376206316d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7852930985711649d, y: 0.21065317792317917d), radius: 0.47768290779682865d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.576061482990803d, y: 0.17128726952965612d), radius: 0.4142768166215113d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1252368602132925d, y: 0.5279041887793817d), radius: 0.36296757225835874d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5179266028438686d, y: 0.19003601471623233d), radius: 0.9239191468670492d))));//Value

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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
FROM public.binary_npgsqlcirclecircle0m m
LEFT JOIN public.binary_npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircle0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircle0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlCircleSingleTypecircle)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

