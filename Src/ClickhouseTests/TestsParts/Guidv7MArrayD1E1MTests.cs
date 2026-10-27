

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidv7MArrayMArrayD1
    {
    }
    
    internal partial class Guidv7MArrayMArrayD1 : IGuidv7MArrayMArrayD1
    {


#region TestData

        private readonly Guidv7MArrayD1E1M[] _testData = new Guidv7MArrayD1E1M[]
        {
            new Guidv7MArrayD1E1M
{
    Id = 3,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-78ff-b32b-9ff3bc65d129"),
Guid.Parse("01a17ef0-392d-76b1-8eb7-d1fcd4314c60"),
Guid.Parse("01a17ef0-392d-7df9-9de8-f08d711bf1ee"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-788b-9627-9c7f84794f30"),
Guid.Parse("01a17ef0-392d-7559-a7a0-182134d02a44"),
Guid.Parse("01a17ef0-392d-7c68-8ced-2cf92b81a483"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-739e-8044-2b5354d3557b"),
Guid.Parse("01a17ef0-392d-7604-ac91-d8f6535ba541"),
Guid.Parse("01a17ef0-392d-7835-a5ee-b6f2a292a2a4"),
Guid.Parse("01a17ef0-392d-7f23-bb2b-069d8d04f12f"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-75f7-98fb-e652338028f4"),
Guid.Parse("01a17ef0-392d-704b-a131-909faedd2287"),
Guid.Parse("01a17ef0-392d-76f8-8047-2f53b1fcc7f3"),
Guid.Parse("01a17ef0-392d-7fb7-b57c-f6fbff4639bd"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 10,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-77b8-9816-97c1932dae9e"),
Guid.Parse("01a17ef0-392d-7748-8167-4082bc3a7d4f"),
Guid.Parse("01a17ef0-392d-7d98-91d9-668abf3dda02"),
Guid.Parse("01a17ef0-392d-7fe6-92a8-396a94a77d96"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-78af-bc5e-cd4ae37f9015"),
Guid.Parse("01a17ef0-392d-71e5-82c4-eb82612f6d50"),
Guid.Parse("01a17ef0-392d-7a53-935a-ec681fc975da"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7997-ae5a-75e98617d16c"),
Guid.Parse("01a17ef0-392d-7209-8443-5b53c3b02f0c"),
Guid.Parse("01a17ef0-392d-7f2e-a361-df5c47f68522"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7dab-8259-c7d3e6cf3d42"),
Guid.Parse("01a17ef0-392d-7178-93c0-5c46d02df469"),
Guid.Parse("01a17ef0-392d-7f57-9807-a69acfc64da8"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 13,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7f1c-b2b8-3a3e2ffcdcfe"),
Guid.Parse("01a17ef0-392d-7191-993f-235a8dda8d66"),
Guid.Parse("01a17ef0-392d-7bc1-8c5f-bc800620673d"),
Guid.Parse("01a17ef0-392d-77d3-92da-47c3dde6b0e9"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7018-8c29-e059dada6896"),
Guid.Parse("01a17ef0-392d-7979-8739-5065eeec474d"),
Guid.Parse("01a17ef0-392d-7885-a3ad-048e2db6bd10"),
Guid.Parse("01a17ef0-392d-726d-888e-d03626f79c89"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-749a-9366-fd8ace7b8dd7"),
Guid.Parse("01a17ef0-392d-71fa-8ec4-0720e9f4b79c"),
Guid.Parse("01a17ef0-392d-728b-99d3-0c221d8940b4"),
Guid.Parse("01a17ef0-392d-7382-8fe4-3afc48716887"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7d71-ab07-178b67d014c6"),
Guid.Parse("01a17ef0-392d-7d73-9bf3-1c5db40fe2df"),
Guid.Parse("01a17ef0-392d-70b1-84ef-b8ff9c9d331d"),
Guid.Parse("01a17ef0-392d-71e7-9bdc-fec482828d77"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7230-88d7-a93ebc8f8c0e"),
Guid.Parse("01a17ef0-392d-7c79-a704-4ea965d6184a"),
Guid.Parse("01a17ef0-392d-79a4-bdb7-f51a8ec6cccf"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-764e-971c-4b01ab3a4464"),
Guid.Parse("01a17ef0-392d-7de2-a6a1-3667cc134401"),
Guid.Parse("01a17ef0-392d-7a93-ae30-5c0e7dbd6497"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-74b5-af45-3d2c4d83569f"),
Guid.Parse("01a17ef0-392d-7601-8074-1177dee129d7"),
Guid.Parse("01a17ef0-392d-76f1-92a5-c4364d90e2b6"),
Guid.Parse("01a17ef0-392d-7afc-be34-3022eada9d6e"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-718f-84cd-fab0f100f84c"),
Guid.Parse("01a17ef0-392d-7d5f-9226-20189d379596"),
Guid.Parse("01a17ef0-392d-7c09-93a3-8e841071db8b"),
Guid.Parse("01a17ef0-392d-7a80-b9a4-7ee8c1c79769"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-718b-9352-45c986150472"),
Guid.Parse("01a17ef0-392d-7566-8bd7-807ef3680543"),
Guid.Parse("01a17ef0-392d-72b7-b2fc-5538bce1e9b5"),
Guid.Parse("01a17ef0-392d-7b33-a560-ea16059a88d0"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7fa2-886e-9e6786655354"),
Guid.Parse("01a17ef0-392d-7845-aaab-e8538e2aef3e"),
Guid.Parse("01a17ef0-392d-78c0-b2ff-01da3824dcc2"),
Guid.Parse("01a17ef0-392d-73ff-9bc6-c9be59980dee"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7def-9944-168882b0b42c"),
Guid.Parse("01a17ef0-392d-7106-886e-cf48f882442e"),
Guid.Parse("01a17ef0-392d-79e3-ab75-8734de716591"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 36,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7a72-950a-dc8479785d58"),
Guid.Parse("01a17ef0-392d-7cc2-9cbd-d3d5eee096c5"),
Guid.Parse("01a17ef0-392d-7cd6-ba70-8e25dda1e4e0"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7042-ae7d-38e7384cd554"),
Guid.Parse("01a17ef0-392d-7835-99e5-e290b492780d"),
Guid.Parse("01a17ef0-392d-7265-abce-758efe3add1b"),
Guid.Parse("01a17ef0-392d-7abc-9d7f-f554a1a887d6"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-75a0-9e78-0923e339fc15"),
Guid.Parse("01a17ef0-392d-7ffa-b74f-dc27c9972a74"),
Guid.Parse("01a17ef0-392d-7e1b-9aed-aa8b6c92fbe0"),
Guid.Parse("01a17ef0-392d-7604-8529-f7fce5da5538"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7a5f-be4e-77671ca8f98f"),
Guid.Parse("01a17ef0-392d-79ff-b875-e017a35231f5"),
Guid.Parse("01a17ef0-392d-7357-9626-c5239da79f1f"),
Guid.Parse("01a17ef0-392d-7958-b765-dc8bc654f0d0"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7183-80a9-7a0f60b59a7d"),
Guid.Parse("01a17ef0-392d-7341-8a57-859a5cffb0f7"),
Guid.Parse("01a17ef0-392d-7c5f-b410-b408c940e813"),
Guid.Parse("01a17ef0-392d-703c-8e13-0809ffd4535f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-739b-9e09-2afe3e292c5d"),
Guid.Parse("01a17ef0-392d-7f9b-a6e4-e57ffd395230"),
Guid.Parse("01a17ef0-392d-76be-87d9-b5d4e81342e1"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 45,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-78fe-8ca1-7e1811334045"),
Guid.Parse("01a17ef0-392d-7eaa-bcf5-a344a47e9ed3"),
Guid.Parse("01a17ef0-392d-78a3-89a2-cfc4536c908d"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7996-ab8c-b19c44ae6e13"),
Guid.Parse("01a17ef0-392d-7f6a-a259-724a5440c8dd"),
Guid.Parse("01a17ef0-392d-7784-a812-a9330d88e5e8"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7c2e-b9b1-c9319920c4d6"),
Guid.Parse("01a17ef0-392d-75a1-abed-ee77a3895400"),
Guid.Parse("01a17ef0-392d-754c-851b-0f436738421c"),
Guid.Parse("01a17ef0-392d-7142-b517-0271cf355683"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7c6b-91ff-53e8e32d02c8"),
Guid.Parse("01a17ef0-392d-7908-aa96-603bd0f99bec"),
Guid.Parse("01a17ef0-392d-748d-91ec-5dabd57b5c3f"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7d9c-9644-6c225b0f8dc7"),
Guid.Parse("01a17ef0-392d-70dd-90d8-dc112ce28360"),
Guid.Parse("01a17ef0-392d-7171-ab2f-b4635611e296"),
Guid.Parse("01a17ef0-392d-7e9b-8850-8b7636ae87e0"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7f18-a078-9709bb8d4fa1"),
Guid.Parse("01a17ef0-392d-7c65-a9f7-ce314b731239"),
Guid.Parse("01a17ef0-392d-7b1d-9e08-ecaa7743c0df"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-73be-9733-9eb350cc8703"),
Guid.Parse("01a17ef0-392d-75de-b159-50d4a199d5a9"),
Guid.Parse("01a17ef0-392d-79af-9f33-cad303f69777"),
Guid.Parse("01a17ef0-392d-71e7-8938-4042be976cc9"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-74e3-af47-09258a254195"),
Guid.Parse("01a17ef0-392d-722b-8b8a-1e2c12a0bbe5"),
Guid.Parse("01a17ef0-392d-7ea7-bed1-1f98fac45aed"),
Guid.Parse("01a17ef0-392d-7d3b-a064-753032c23823"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-75d5-9ef3-bbace69d288e"),
Guid.Parse("01a17ef0-392d-7ff7-9dc4-a224cba07ce4"),
Guid.Parse("01a17ef0-392d-7971-bde4-061f91706761"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 63,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-77ff-aa26-5490294caea7"),
Guid.Parse("01a17ef0-392d-7ffe-8854-454e0559376a"),
Guid.Parse("01a17ef0-392d-7f97-b41a-a28500c97478"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7b6c-8273-ba5e8f4e7a37"),
Guid.Parse("01a17ef0-392d-7b0c-908e-7d469c274dde"),
Guid.Parse("01a17ef0-392d-7e26-8137-9109467f3948"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 67,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7ace-82e0-6f4b60f93ee4"),
Guid.Parse("01a17ef0-392d-7a01-aab8-c2731b3d076e"),
Guid.Parse("01a17ef0-392d-7012-850a-81f7ed8df085"),
Guid.Parse("01a17ef0-392d-7f77-831e-fd542084e7c6"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7c62-9f7e-1c5c9ae717de"),
Guid.Parse("01a17ef0-392d-7c4f-a836-49bc05042756"),
Guid.Parse("01a17ef0-392d-7812-9567-4da9c1cd1bc5"),
Guid.Parse("01a17ef0-392d-7065-a29b-2a37f493b8f0"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7bab-8de2-e682efb28e09"),
Guid.Parse("01a17ef0-392d-77e5-8912-d8a6c711e5d9"),
Guid.Parse("01a17ef0-392d-77a4-a5b3-48027bf42745"),
Guid.Parse("01a17ef0-392d-77f8-98bb-733e47f54548"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 76,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7356-984b-240c821636e1"),
Guid.Parse("01a17ef0-392d-7c6e-84fb-7d2851ed42ed"),
Guid.Parse("01a17ef0-392d-7c0e-b230-72b378797664"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-72b6-b973-fa6b93fe6045"),
Guid.Parse("01a17ef0-392d-77a9-b6af-b1766478f720"),
Guid.Parse("01a17ef0-392d-7b56-80f2-599326f72de3"),
Guid.Parse("01a17ef0-392d-7c9c-a2c7-64782cf69341"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7b6a-8a84-13e6097721a6"),
Guid.Parse("01a17ef0-392d-79b1-8a01-e319e792a0bb"),
Guid.Parse("01a17ef0-392d-7d41-8b09-75fb2c4e4e19"),
Guid.Parse("01a17ef0-392d-763f-90f9-e86e4bb64b89"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-79d9-a210-5514c8ea7c3f"),
Guid.Parse("01a17ef0-392d-7030-8f82-9ebd63c832a5"),
Guid.Parse("01a17ef0-392d-7b2b-990a-c06103228166"),
Guid.Parse("01a17ef0-392d-7e82-8ab9-a43a0fc66d09"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7454-bcaa-16866f9244ef"),
Guid.Parse("01a17ef0-392d-73ef-9a70-14cef5ffc30d"),
Guid.Parse("01a17ef0-392d-7e71-94b6-887ca1ad6468"),
Guid.Parse("01a17ef0-392d-73d9-9654-e9f991f9c9b9"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7bab-9248-56d00c4fa9fd"),
Guid.Parse("01a17ef0-392d-79e1-894f-4320fbd9cbf8"),
Guid.Parse("01a17ef0-392d-7053-a7b0-3a4d919daca0"),
Guid.Parse("01a17ef0-392d-7297-8002-79c9207c7e76"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7b81-b715-25e987f36ecd"),
Guid.Parse("01a17ef0-392d-720a-a2d1-9125a9cef080"),
Guid.Parse("01a17ef0-392d-78ef-b81a-d5eb10dfd291"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7eaf-ab21-406749c98a37"),
Guid.Parse("01a17ef0-392d-7bfe-b4ab-26464ffcf61b"),
Guid.Parse("01a17ef0-392d-7d4b-8f8a-a0e2630f4c48"),
Guid.Parse("01a17ef0-392d-7516-85b5-a429aa9456d5"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7b58-bf1c-cbb198f8deeb"),
Guid.Parse("01a17ef0-392d-7750-b355-2d3eea053639"),
Guid.Parse("01a17ef0-392d-75fc-87e7-95d099438b8a"),
Guid.Parse("01a17ef0-392d-72a8-87c1-b6e758cdf2d8"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-715d-9fa6-c14b70343d3b"),
Guid.Parse("01a17ef0-392d-7888-a1a2-9ea4a1e8939b"),
Guid.Parse("01a17ef0-392d-7570-b0bf-fadefc090234"),
Guid.Parse("01a17ef0-392d-7abc-9c88-fdbe6ea89e75"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7c1a-8cc2-d0c6f43e2ae3"),
Guid.Parse("01a17ef0-392d-71f3-9a7a-789d7220a0bc"),
Guid.Parse("01a17ef0-392d-72d9-94a6-ad7b2474f722"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 94,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7fc0-9472-52776b51004c"),
Guid.Parse("01a17ef0-392d-7cec-80ef-6c95de645e6a"),
Guid.Parse("01a17ef0-392d-7009-960c-475c40a726a4"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-78bf-bd48-61b2f409aadc"),
Guid.Parse("01a17ef0-392d-724f-989a-6401aaea9907"),
Guid.Parse("01a17ef0-392d-7aaf-b8cf-11f913d53478"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 97,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7be1-8d2d-791ea3d3b77c"),
Guid.Parse("01a17ef0-392d-71d0-8b9d-8dcf85308d27"),
Guid.Parse("01a17ef0-392d-784b-b505-72718164e23c"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7f31-a1de-991a895f2c5c"),
Guid.Parse("01a17ef0-392d-79af-81b5-7715ede643b7"),
Guid.Parse("01a17ef0-392d-7044-808a-d403c11108e6"),
Guid.Parse("01a17ef0-392d-72ab-9164-15f598d28072"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 106,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-71a0-99f8-09b95b75dbca"),
Guid.Parse("01a17ef0-392d-74b7-89f7-06364850b08b"),
Guid.Parse("01a17ef0-392d-7280-aec6-05feb5eb7329"),
Guid.Parse("01a17ef0-392d-7081-9aa9-24413253737c"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7c2a-beb6-843ba432b656"),
Guid.Parse("01a17ef0-392d-754b-b3e7-924fb4f336b4"),
Guid.Parse("01a17ef0-392d-74e8-a115-5e9e6789fdd6"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7eb0-94c2-7ff0bf3ab9fd"),
Guid.Parse("01a17ef0-392d-7cf8-9f85-37125f5d67b1"),
Guid.Parse("01a17ef0-392d-7c52-9e43-4cbae68b77c3"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-79b5-abb4-60130c50b4b8"),
Guid.Parse("01a17ef0-392d-797a-899d-b773d0323b9d"),
Guid.Parse("01a17ef0-392d-707d-a629-f98847bdbbe0"),
Guid.Parse("01a17ef0-392d-7374-8eca-359dc0c3efe0"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-76dd-ae00-18a941bdb9fb"),
Guid.Parse("01a17ef0-392d-79a7-a474-395a53c7bf88"),
Guid.Parse("01a17ef0-392d-7a0d-92f4-06fd765df793"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-75dd-9b41-948c289aed73"),
Guid.Parse("01a17ef0-392d-7b54-8448-d668d5b5a149"),
Guid.Parse("01a17ef0-392d-727f-919e-a8c1349b5078"),
Guid.Parse("01a17ef0-392d-7943-b2cf-31fab6219c6f"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 117,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7d0a-8753-3908c5d67e4c"),
Guid.Parse("01a17ef0-392d-7196-8c9e-1c75ce929bae"),
Guid.Parse("01a17ef0-392d-7c90-8589-1107d0de7f39"),
Guid.Parse("01a17ef0-392d-7516-998a-92ff529ae832"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7884-84cd-807ba05deeb8"),
Guid.Parse("01a17ef0-392d-7ec3-b8a3-ea4f93369634"),
Guid.Parse("01a17ef0-392d-72ca-a4bb-05a85b3b1cff"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 119,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-70d8-88a2-8d18aeaec05a"),
Guid.Parse("01a17ef0-392d-71b4-81f7-171afd39feda"),
Guid.Parse("01a17ef0-392d-739a-9911-187a61d0de78"),
Guid.Parse("01a17ef0-392d-777c-b448-1ec208d8b3e7"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7657-996d-d885db5b89c2"),
Guid.Parse("01a17ef0-392d-7d1d-af0b-0b8f5efb0f6a"),
Guid.Parse("01a17ef0-392d-7be0-b3d9-b2486828b976"),
Guid.Parse("01a17ef0-392d-7161-bb67-88552ebdb6b3"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7bf9-bb58-3b35fd706438"),
Guid.Parse("01a17ef0-392d-7ecc-9bb0-1bdcb148a103"),
Guid.Parse("01a17ef0-392d-72d9-8b92-6a15de8b4e0c"),
Guid.Parse("01a17ef0-392d-709c-a885-132a25cc6c20"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 127,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7f1d-9c94-2e965835d99b"),
Guid.Parse("01a17ef0-392d-7154-805f-d5f211f08724"),
Guid.Parse("01a17ef0-392d-77b6-9d40-b994212078f5"),
Guid.Parse("01a17ef0-392d-7902-a0cc-c1f45df02c45"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7eb2-9191-b38b6134fb92"),
Guid.Parse("01a17ef0-392d-7c8a-8f06-38263ba894a8"),
Guid.Parse("01a17ef0-392d-72f0-8c86-696f4f38e720"),
Guid.Parse("01a17ef0-392d-7407-bcaf-38ea36e78737"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7d26-83f9-af0aabbbd189"),
Guid.Parse("01a17ef0-392d-7487-b483-5455dd50064b"),
Guid.Parse("01a17ef0-392d-7810-a765-ac654aea6f19"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-765a-ab2f-00fbebcbd83f"),
Guid.Parse("01a17ef0-392d-7a64-b8c8-e7c5657f5f70"),
Guid.Parse("01a17ef0-392d-7422-8c1d-3a5189ed6fe0"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 131,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7d84-9a17-90c523be4669"),
Guid.Parse("01a17ef0-392d-75a6-aa07-2927b7d48c84"),
Guid.Parse("01a17ef0-392d-7d84-8f68-8492fe550c1c"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7e09-8dda-5743c918857a"),
Guid.Parse("01a17ef0-392d-72c7-84e6-8d0077a82d19"),
Guid.Parse("01a17ef0-392d-7377-8340-5963c7934149"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7a40-8fc9-c6e0cae6cef7"),
Guid.Parse("01a17ef0-392d-7c6d-a277-f60fb2e8c4ed"),
Guid.Parse("01a17ef0-392d-78f6-aca3-5aca42b726a4"),
Guid.Parse("01a17ef0-392d-7faf-8a11-23472a353504"),
},
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 134,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-75ac-975b-9fa8deff0e8f"),
Guid.Parse("01a17ef0-392d-7143-955b-93710c138f64"),
Guid.Parse("01a17ef0-392d-7632-902d-fb218f43f896"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7fe0-beec-ddbaefadb9b9"),
Guid.Parse("01a17ef0-392d-79ba-a403-63464e68b419"),
Guid.Parse("01a17ef0-392d-7cda-87ed-e10f2db8ea8d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-731f-9f37-22e621df3edd"),
Guid.Parse("01a17ef0-392d-7043-b97f-46d79bc36673"),
Guid.Parse("01a17ef0-392d-7be4-8e7c-6ca611979271"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-72a2-a74c-84000885e5f6"),
Guid.Parse("01a17ef0-392d-7880-ac33-e561b5878219"),
Guid.Parse("01a17ef0-392d-7f81-9016-83866b8f0b0f"),
Guid.Parse("01a17ef0-392d-7a26-8eae-f46eaf85d92b"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 138,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7c5a-9437-71f5f3e26115"),
Guid.Parse("01a17ef0-392d-71bf-a377-8875eff2b158"),
Guid.Parse("01a17ef0-392d-7205-b463-adb740ac2db4"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 117,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7fe6-8c4a-6dcf5665d640"),
Guid.Parse("01a17ef0-392d-791d-b7ae-950f8a6800f3"),
Guid.Parse("01a17ef0-392d-719b-a6ce-e5a55b47c754"),
Guid.Parse("01a17ef0-392d-7e96-b84f-a5a5df76b416"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7d93-8e9f-49bf637302cc"),
Guid.Parse("01a17ef0-392d-79a3-8939-ca5019147702"),
Guid.Parse("01a17ef0-392d-7a13-8d91-02c43615ddf3"),
Guid.Parse("01a17ef0-392d-76c0-b601-d62c21ccd522"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-78e2-9925-4e02da1071b6"),
Guid.Parse("01a17ef0-392d-76c2-b09c-2e5eb1a92927"),
Guid.Parse("01a17ef0-392d-7732-9271-b1af19036328"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 145,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7a14-8766-acb1cdacc819"),
Guid.Parse("01a17ef0-392d-77f4-bcb4-dfb9bac8e42f"),
Guid.Parse("01a17ef0-392d-7f4e-8e64-6afe79df896a"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-73e9-8b16-261406e540e4"),
Guid.Parse("01a17ef0-392d-7a5b-8394-1435f16a591f"),
Guid.Parse("01a17ef0-392d-7919-8cf4-029c4a174618"),
Guid.Parse("01a17ef0-392d-7dd1-9db3-55f0ac6138bf"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7b84-8fea-1d431fe5896d"),
Guid.Parse("01a17ef0-392d-72b9-b54b-f51ebb851ef6"),
Guid.Parse("01a17ef0-392d-7d16-ad02-c418a8a12af9"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-71db-b30c-af3f7b052091"),
Guid.Parse("01a17ef0-392d-7527-bafc-6b4973bdc5d3"),
Guid.Parse("01a17ef0-392d-741d-b506-0697ce90825a"),
Guid.Parse("01a17ef0-392d-7c68-98b9-643f732af983"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 148,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-737a-9886-4dc1cb594500"),
Guid.Parse("01a17ef0-392d-7593-a617-c40958c95df8"),
Guid.Parse("01a17ef0-392d-741e-a0ed-4d30b65c3f22"),
Guid.Parse("01a17ef0-392d-7ed6-a554-4c0a38591aa2"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7b03-9a76-6a6c92d84fb2"),
Guid.Parse("01a17ef0-392d-77ac-a824-e2673e306ead"),
Guid.Parse("01a17ef0-392d-79aa-b37a-e50e216d0b57"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7c3a-9292-ff197af2c63f"),
Guid.Parse("01a17ef0-392d-7173-bf4b-424aa0d0ae28"),
Guid.Parse("01a17ef0-392d-7a99-acb9-e7bda6a1ad3c"),
Guid.Parse("01a17ef0-392d-776f-aabb-9d12fd6a52c8"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-72b4-9c90-0b47d7813f41"),
Guid.Parse("01a17ef0-392d-7c6d-805b-5063eff69d1c"),
Guid.Parse("01a17ef0-392d-70b0-97ed-804f0a33a140"),
Guid.Parse("01a17ef0-392d-76e6-83cd-9dc6418eb22b"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-704d-bfc9-6a663a2a4c59"),
Guid.Parse("01a17ef0-392d-7710-8294-50ed5eb423f2"),
Guid.Parse("01a17ef0-392d-7b27-a498-ccdab926be55"),
Guid.Parse("01a17ef0-392d-78c5-b766-a1baaff0a8d9"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD1E1M
{
    Id = 162,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7ef4-9656-06b10bd46c65"),
Guid.Parse("01a17ef0-392d-7d82-92d0-efda43f177e2"),
Guid.Parse("01a17ef0-392d-75ee-be91-d66b0df5677c"),
Guid.Parse("01a17ef0-392d-7a15-9cb8-14071252ed96"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 139,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-73e8-8bec-e10294a1180c"),
Guid.Parse("01a17ef0-392d-7676-bd0b-d11530c5df3e"),
Guid.Parse("01a17ef0-392d-7359-af61-6005eccd9a5e"),
Guid.Parse("01a17ef0-392d-7727-be7d-364a8a7f7da3"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7339-b981-86375505dc1f"),
Guid.Parse("01a17ef0-392d-7642-9a83-64580bc48b7a"),
Guid.Parse("01a17ef0-392d-733a-9554-54c07f853ec5"),
Guid.Parse("01a17ef0-392d-71c5-b76d-dcfe6bc96797"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 166,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-774f-a784-e2c44c1dde77"),
Guid.Parse("01a17ef0-392d-7409-b67b-cde0f7f2e0c2"),
Guid.Parse("01a17ef0-392d-7b62-ac7c-088f248b43df"),
Guid.Parse("01a17ef0-392d-711a-9cc2-46a5c0964f67"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7f5d-a01c-b8d432e75136"),
Guid.Parse("01a17ef0-392d-78e2-b255-e27bd92c1d72"),
Guid.Parse("01a17ef0-392d-73b3-9026-8aa93bdc2802"),
Guid.Parse("01a17ef0-392d-786e-8513-8e97bfd5f04a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7f00-ba8a-e3ace867e7f8"),
Guid.Parse("01a17ef0-392d-7e03-b1cf-068b1664674f"),
Guid.Parse("01a17ef0-392d-7aaf-a7e7-271c7dfbd6e9"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 167,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7928-b078-b2c5e541d274"),
Guid.Parse("01a17ef0-392d-76af-bc1b-d825dbfe76c8"),
Guid.Parse("01a17ef0-392d-784c-bef5-8d470d0906e3"),
Guid.Parse("01a17ef0-392d-72a4-a0d9-f817ce490789"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7cc8-84ea-748b693f557e"),
Guid.Parse("01a17ef0-392d-7836-81e9-f91bdcc4f7a2"),
Guid.Parse("01a17ef0-392d-7d6d-81e2-14399789f8b5"),
Guid.Parse("01a17ef0-392d-75a6-912b-f4660dbbf07a"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-72f5-b0fa-6f4721cbfb10"),
Guid.Parse("01a17ef0-392d-76b8-8f44-aa244c5ef053"),
Guid.Parse("01a17ef0-392d-7a23-8243-4ccef5db4d88"),
Guid.Parse("01a17ef0-392d-7047-8409-dd87fc963c7f"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-71c9-b05a-1aee266e5e03"),
Guid.Parse("01a17ef0-392d-75f5-9329-0f61ace16470"),
Guid.Parse("01a17ef0-392d-704f-97b6-66b4e60f45f2"),
Guid.Parse("01a17ef0-392d-7f91-868f-e456029a977c"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 168,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-71ed-a117-19078a3b7128"),
Guid.Parse("01a17ef0-392d-7ec1-91ff-b18126401338"),
Guid.Parse("01a17ef0-392d-7b57-bfda-0e8f3e368801"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7587-a011-90288db77503"),
Guid.Parse("01a17ef0-392d-77d2-a6b2-045555d7e573"),
Guid.Parse("01a17ef0-392d-7e3e-a658-bc55232d3570"),
Guid.Parse("01a17ef0-392d-7979-b7b3-93323d1366f6"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7d95-8d18-eb79b67c7ab0"),
Guid.Parse("01a17ef0-392d-78da-929f-ca6601f28382"),
Guid.Parse("01a17ef0-392d-745e-8fe1-a9056f3cbb24"),
Guid.Parse("01a17ef0-392d-724a-a697-33ca0d871e3f"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01a17ef0-392d-7e7c-be37-66fbc0ba924b"),
Guid.Parse("01a17ef0-392d-703a-963b-b93ea9b59ab9"),
Guid.Parse("01a17ef0-392d-75b4-89fc-7459e38b3132"),
Guid.Parse("01a17ef0-392d-767c-9927-ed4c66e2439c"),
},
},
            new Guidv7MArrayD1E1M
{
    Id = 172,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7db4-a361-f65c3b275309"),
Guid.Parse("01a17ef0-392d-7f02-adee-817910c0ded8"),
Guid.Parse("01a17ef0-392d-78a8-9923-595e116506ac"),
},
    ModelInner = new Guidv7MArrayD1E1MI
{
    Id = 167,
    Value = 
new System.Guid[3]
{
Guid.Parse("01a17ef0-392d-7823-bdd7-e6837370aa73"),
Guid.Parse("01a17ef0-392d-7f06-9e43-cfd4d1929441"),
Guid.Parse("01a17ef0-392d-7689-8827-5f0513785002"),
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidv7marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UUID)}, 
    {mi_id:Int32},
    {mi_value:Array(UUID)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IGuidv7MArrayMArrayD1)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IGuidv7MArrayMArrayD1)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.guidv7marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Guidv7MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IGuidv7MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Guidv7MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IGuidv7MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Guidv7MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

