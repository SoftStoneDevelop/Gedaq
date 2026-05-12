

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
    internal partial interface IGuidMArrayuuidMMArrayD2
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD2 : IGuidMArrayuuidMMArrayD2
    {


#region TestData

        private readonly GuiduuidMMArrayD2E1M[] _testData = new GuiduuidMMArrayD2E1M[]
        {
            new GuiduuidMMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Guid[,] { { Guid.Parse("3d5b68ad-9fb3-49cf-844f-ae6cf44069df"), Guid.Parse("85fc90be-dee2-4c9d-b36e-5d9258f2cedf"), }, { Guid.Parse("645272a1-cbf4-4eeb-8823-42eccce006b7"), Guid.Parse("6db5c7f4-1d92-40ac-bf39-0b387936eafe"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Guid[,] { { Guid.Parse("8ce59ba8-68ad-4507-a5d5-d5fbe357cb05"), Guid.Parse("fb3482b1-8ceb-493a-a9ae-9176c0d8fafb"), }, { Guid.Parse("8672b467-5b66-4e89-84bf-8bd3b9c148ed"), Guid.Parse("ed5ce04d-74f9-47b9-9f33-1411eddd582f"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Guid[,] { { Guid.Parse("a8ab6220-8d3f-4bae-bb1b-7d300c1ff81b"), Guid.Parse("473c5865-ba7f-4f02-8528-d9a4c79daae3"), }, { Guid.Parse("82f24da6-06e1-4e31-84dc-cdfad41fc521"), Guid.Parse("0988472c-00f0-4b40-a2b0-0fcbfbdc5a25"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e9749dbe-0c9d-4d02-9db5-5ff525f49dae"), Guid.Parse("fe2fdd15-2acb-4d0c-95c5-3863016a6ef4"), }, { Guid.Parse("6b522749-cea6-4afd-a838-922066e7b1d9"), Guid.Parse("34a99c9b-b617-4761-9ec1-bdbf87a556d0"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Guid[,] { { Guid.Parse("9f39b455-2518-405c-b258-d454d8a3a024"), Guid.Parse("2f1b62b1-48b8-4ed3-b7e2-9178c916e15c"), }, { Guid.Parse("5534df52-fa93-47a0-bbde-9a8e145babc0"), Guid.Parse("bea200c4-de2f-4e42-aee1-84ac67350801"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Guid[,] { { Guid.Parse("4bd22967-b8c1-44ef-aafb-6407ab9cbc48"), Guid.Parse("e913075c-6552-4742-bfd5-b15778b0e560"), }, { Guid.Parse("5a24893e-dbb1-46fa-b527-ed7c147c1b1b"), Guid.Parse("bf726014-9b18-4791-8911-42a9427210fb"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("b8835767-37bd-4d44-bb9c-5a9790d5f720"), Guid.Parse("9e5c1859-c8d8-41ff-9b2f-d9baa350596d"), }, { Guid.Parse("f01610ef-b384-48e3-888a-64a6c445de77"), Guid.Parse("f9084d0f-91f6-4223-9d0a-6303ad8aa11b"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8f5cdbc5-b735-4d74-a417-e5510dd7c26a"), Guid.Parse("cc4e27d8-ba0f-41f8-b908-2be76cf1643d"), }, { Guid.Parse("8bd95250-20d2-4909-b62f-4271cc6937ef"), Guid.Parse("be06124d-c680-47d8-8014-a0912dd2b97d"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Guid[,] { { Guid.Parse("b17e4a31-22c8-4565-8158-f5c5e00a014f"), Guid.Parse("2b92ea9e-925c-49a8-9f07-f7e258157d4b"), }, { Guid.Parse("af117b1b-e003-41f3-8507-933e4d36a53a"), Guid.Parse("29521a16-fee1-467b-9407-9c1bb9349ca1"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ea8da14e-2cfa-42a2-9754-3067a9ed0609"), Guid.Parse("e713a618-5bed-4634-b160-f6e75860eb44"), }, { Guid.Parse("05e692d6-3a5f-4013-8bbb-e59f58d38f8b"), Guid.Parse("dd0a2cab-c914-42d6-823f-7d10ae6bf6e4"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Guid[,] { { Guid.Parse("46362d5e-8035-4489-9f9d-d36bec286327"), Guid.Parse("69b9ab5f-282a-44e9-a352-81efc338cceb"), }, { Guid.Parse("de293aef-7e36-478e-b4b3-11410d8a6333"), Guid.Parse("897a128e-9270-48d4-8876-9e73ef6a9ab0"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Guid[,] { { Guid.Parse("b0e7fd38-3e6e-42d8-9519-2ab4778ae0c2"), Guid.Parse("684227cf-f9dd-42a1-897d-90a5f2ce3e14"), }, { Guid.Parse("66d5c3be-294c-4066-b1a0-1cd9118d6596"), Guid.Parse("3e2798ea-9020-4bf4-bf9d-db7f9f92a172"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Guid[,] { { Guid.Parse("a1e9086e-6b47-45f3-9a19-b078d26a700f"), Guid.Parse("9ce54dce-0095-4908-88d2-ba03f1fc9cf4"), }, { Guid.Parse("9c6c070b-f862-43d7-9135-13144170121f"), Guid.Parse("091863cb-d189-4752-8ac5-6b48e1a968f2"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("f48f18fc-e84c-4cc7-8c60-4b577e9d63ee"), Guid.Parse("ce8323d4-20f2-4d06-8e25-eb1fb57f11bf"), }, { Guid.Parse("311296c1-010e-4e05-b846-ecdccface2ff"), Guid.Parse("07afd11a-fb7e-47fd-b99b-1f4884031a12"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Guid[,] { { Guid.Parse("a7c433fb-f526-4589-b337-5932f9981de9"), Guid.Parse("4b117d9e-0da2-458c-bf11-19779e20c562"), }, { Guid.Parse("9eb13420-309a-4515-a8e1-5dedb91b7e5b"), Guid.Parse("50342155-fa23-4b9d-83aa-f7f9f825570c"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a5c2f240-67a4-400f-b52a-84c596440822"), Guid.Parse("826490be-3389-4986-8ebf-f405cc2ae873"), }, { Guid.Parse("36e10ab4-33ae-43f8-b29f-541ea0a6333f"), Guid.Parse("4cbd7db5-1cd4-4798-aea7-4d63be911d17"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("0e09563f-9cc5-4bb1-ada1-64ff1fa3c5df"), Guid.Parse("10b09dfd-a7af-41ae-a2d1-d0779ba0f99d"), }, { Guid.Parse("be2d9e89-213b-47a5-96ce-3ed893180d67"), Guid.Parse("3e85fd0b-d044-4160-b5af-221746b4777a"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e6bb213a-c4dc-4868-aeb5-70ac937cda91"), Guid.Parse("945d48b5-a698-4a2d-b0f2-982a0f2e9fd0"), }, { Guid.Parse("d919058c-5ff2-4604-9c1c-2608906e9ecc"), Guid.Parse("eebe7587-4808-4934-bb36-be657934704b"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Guid[,] { { Guid.Parse("9e1a732f-2c38-4b73-888d-7af5a6729dc6"), Guid.Parse("a879ac57-73aa-4513-874a-1cadbe968122"), }, { Guid.Parse("18359f0f-5ddf-442d-8704-426f95d3d2ac"), Guid.Parse("d9239f10-d388-4cf8-a8c1-902bed15999b"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Guid[,] { { Guid.Parse("f76e5748-334d-4bb1-b59d-2f1d76d293b2"), Guid.Parse("4c90a846-93fd-40e2-8b37-fa6a500b631e"), }, { Guid.Parse("4a085606-13d1-45d3-ba19-a4ab9c7cd20b"), Guid.Parse("cbcaa824-8b0f-4b11-9ca5-86e41080a162"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("de64ba3f-7252-4b43-b0db-0e66351f0732"), Guid.Parse("09f7aabd-78ef-4f97-a74c-e2876b143ebd"), }, { Guid.Parse("e7cce69a-2258-4720-85a8-38845f3b9142"), Guid.Parse("cb267bbb-21a8-4967-9e3a-f4d7f46a9e2f"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("243589ae-9e9f-4f74-9e50-89231bf88d19"), Guid.Parse("fb9db52a-7883-41a8-a143-5a3b326cfb37"), }, { Guid.Parse("68eafc1d-a687-4250-8eee-5d6592191b00"), Guid.Parse("6b163b3b-e054-4bc3-9149-99734e23f345"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Guid[,] { { Guid.Parse("223d8c50-a4ac-414c-b519-db9e15e6a384"), Guid.Parse("ed083703-e86b-4a63-9ede-550c418e5e76"), }, { Guid.Parse("e44a4cba-604e-40f7-8fab-b0a6d147f286"), Guid.Parse("7785a2f9-1d2b-420e-8180-366ca5b39d49"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("437c0774-63f8-4831-9e47-35a61b4cf64c"), Guid.Parse("a7d6c0c0-3685-4d7b-b1ee-8eaf3e376ab3"), }, { Guid.Parse("9227ce80-3ed4-469d-a495-3e40ac1d8396"), Guid.Parse("ea28ee24-dee2-4a5d-854a-a53b0a422fa0"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Guid[,] { { Guid.Parse("2dc38af5-a183-4044-9046-9ce97593498a"), Guid.Parse("de19a325-a2f1-428a-9088-65cce875d401"), }, { Guid.Parse("02e22bcd-b56c-4eea-91a2-744e1d9e3da3"), Guid.Parse("d939e297-d6ab-492e-9d0a-c0a2d367d83a"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Guid[,] { { Guid.Parse("474c6fb4-ae90-493a-8a5e-89e69744dedc"), Guid.Parse("f5699dd4-a116-4ea0-918b-f07434b25201"), }, { Guid.Parse("e7813e2d-f28e-43c4-a581-7866c78d4a21"), Guid.Parse("47a48ad9-2f2a-4149-ba6e-12eb76176f94"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4ee52d4a-16ad-4486-8bfc-7aa8242aa8ba"), Guid.Parse("e27ca668-a330-435c-ad0a-5046a989f1d0"), }, { Guid.Parse("e0b9b87f-3a6b-4382-9063-c273886aaf53"), Guid.Parse("64fe6c15-82a7-4a22-ab76-ab3d29fc3e3d"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1d791edd-ce1f-4987-a19f-e837c1e2c88c"), Guid.Parse("ebc26a66-5635-4116-8346-55797cf3625b"), }, { Guid.Parse("09a11d18-bdcf-4578-a588-27042ebd72ae"), Guid.Parse("2f56f6e9-b234-4966-a7a3-55a6f67632ed"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Guid[,] { { Guid.Parse("6b819142-cca8-417d-96ce-2036f7bb8a86"), Guid.Parse("c7699481-3be5-4b3a-b3b8-5972a6055203"), }, { Guid.Parse("411fa5e3-cc01-4d46-94b8-df66273fb721"), Guid.Parse("d331013f-762b-460c-ae77-10b8f4199fdd"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("df57b8e4-3653-47ca-a54f-81c442538ab9"), Guid.Parse("c27f0cc5-cf62-4974-866d-a321d7242308"), }, { Guid.Parse("41587373-37ac-4d23-ac45-bd9b00804c87"), Guid.Parse("a760f265-f113-4798-853f-76988702e7f6"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Guid[,] { { Guid.Parse("1b5c0c96-1820-4a57-8983-98c75eec7646"), Guid.Parse("9e1e415d-d3a4-415d-8913-e7d9673a978d"), }, { Guid.Parse("bb3c1836-3f5d-4b1f-a9a2-7001aedb22ad"), Guid.Parse("3bd236f8-8c07-4c01-b767-86a7693dc969"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Guid[,] { { Guid.Parse("ff37ef70-e185-4c45-941c-fb7a4307b648"), Guid.Parse("e5077ed7-f4e7-40d6-a744-c6d383139e39"), }, { Guid.Parse("c8bae82b-a07a-402d-971f-b1a221248503"), Guid.Parse("0f2436cc-bd9c-40c8-895c-ba931a5cedd5"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5c302ffa-12a4-4c3e-8b08-a67fe64e0243"), Guid.Parse("01559a89-d7b9-432e-8abd-586c932cc327"), }, { Guid.Parse("7dedd2ea-12be-4edb-a38e-171ce09ef41e"), Guid.Parse("26fb2a52-4d9f-41e1-9162-ab704676533f"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Guid[,] { { Guid.Parse("1dd12d52-fed5-4269-a81a-3cec461cd5e2"), Guid.Parse("08d37c37-09e1-4969-9c94-94eb0e7fb3b1"), }, { Guid.Parse("8e642b30-91d7-4d5b-821f-c723585d5e66"), Guid.Parse("b5f5f2cf-a844-4ace-b749-99b6e62f6097"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d6f5e62f-a30f-4bad-983a-51f191cfc16f"), Guid.Parse("d04db673-bd6f-45b3-9ba0-9706bc5224c9"), }, { Guid.Parse("ec0c1cae-0a9a-4f97-a9b6-2ce27dc1d21a"), Guid.Parse("fdb67fb1-6a76-4699-8376-fe17e552dde3"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Guid[,] { { Guid.Parse("9a51ce93-ce30-4089-a038-34b8dd4a4c1f"), Guid.Parse("5030e424-ea27-4e3d-ab56-2bcac49a05cd"), }, { Guid.Parse("3c6f934b-333a-4dde-b59b-06627d0ebbf7"), Guid.Parse("adf49562-3e14-4ad0-bd95-864fc2692264"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Guid[,] { { Guid.Parse("3c43a64e-82cc-4b5a-8a4b-950df900c2ba"), Guid.Parse("57aaa2c0-2a3a-4a75-abd0-b2529e36befd"), }, { Guid.Parse("cd4d41fb-c746-4239-a96f-93ac1e3c0e72"), Guid.Parse("bc06468f-844a-49b2-8554-677456f764b8"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8753766f-7edc-4f07-91f1-668fe0191bcb"), Guid.Parse("62fccffb-be01-4750-b376-f13a3bdacfd2"), }, { Guid.Parse("d888cce1-a8d1-4bd5-8dcd-38134b54ff2d"), Guid.Parse("648116b2-c8cc-4fb1-85b2-a740cccb64a8"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Guid[,] { { Guid.Parse("c174cafe-3c87-45d8-aba6-8d10e0f0fcf1"), Guid.Parse("a97bcfc5-5f46-4fc8-becb-ab960a6e8757"), }, { Guid.Parse("e9d43a21-92d4-4e1d-9824-4b469ca29644"), Guid.Parse("8571d5d7-b858-4e2c-874a-7ea9397b8111"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Guid[,] { { Guid.Parse("91c49b17-7824-45cd-b3b8-4164c6e987eb"), Guid.Parse("9cc7f5ac-f0a9-43d1-bf83-189492fbf4d8"), }, { Guid.Parse("76de5006-2bcf-4415-b440-ff7cc9ec7661"), Guid.Parse("89f3c8a9-17cf-44c7-816b-dbd9819b951c"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("8ad7e5c7-1679-498c-bf0a-ee664d818cdb"), Guid.Parse("f03dc50f-d05b-4528-951d-c48415caeb61"), }, { Guid.Parse("834a13dc-783a-4d2f-81d7-71ae14e3c250"), Guid.Parse("3c0fa388-1961-4df0-be66-0037cbe61f95"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Guid[,] { { Guid.Parse("f28f9125-a351-429b-b3ed-8b9237cbe745"), Guid.Parse("c8f5e863-56bf-4f5c-8ce1-b9db9b17129e"), }, { Guid.Parse("e7e0f5da-c3e5-4da9-b451-63e5f105abce"), Guid.Parse("b240d57d-e24f-45bf-9ba0-6e757651969b"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Guid[,] { { Guid.Parse("628b77eb-0b48-4ffb-b53a-7a27125576e7"), Guid.Parse("59aa55e8-91d5-4ce8-a11b-f26201fb0334"), }, { Guid.Parse("b1eb943d-bacd-43f0-91b2-9fcb9c74eaa0"), Guid.Parse("925f56bc-b5ad-4a02-a0bc-5283ff9ecf93"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("af3a74e0-f928-4657-baad-a477e22274c1"), Guid.Parse("ab5dd89c-13df-429c-b12c-c40b29b96430"), }, { Guid.Parse("96af45c3-8819-4c2f-83cf-61138f4b6f61"), Guid.Parse("a338f515-07f9-4f22-bfc0-837f5da70265"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Guid[,] { { Guid.Parse("d230891d-f83c-46ac-a6c0-2b46e4cd515b"), Guid.Parse("8cf8105f-b880-4c8a-9881-3ced3ec5b1c4"), }, { Guid.Parse("69aa70dc-89f5-4b62-a3be-1f27973732c7"), Guid.Parse("3b74545e-1a9e-4529-82da-9e0e1e44eab5"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Guid[,] { { Guid.Parse("47b05769-014e-46c1-a6d8-ba1319801fab"), Guid.Parse("d538f47c-facf-428c-b2fb-09eaefeab9df"), }, { Guid.Parse("44935453-b7d4-4b98-ac68-d08eabfe896e"), Guid.Parse("e8f120d5-94cd-4d8a-869b-82c43b829bed"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Guid[,] { { Guid.Parse("28a0978c-ebab-4603-a67a-ad45abe09831"), Guid.Parse("5d4392c7-555f-4577-9228-0bab684d40ec"), }, { Guid.Parse("d0f0b5a0-4998-442e-bb4b-12d8d622a9d9"), Guid.Parse("5aa85a90-3176-437a-9cee-e447a5c4637b"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("363a885d-7f8e-43af-a9ab-8e9ea252abd7"), Guid.Parse("63362dfb-d54b-4ad4-861b-d61904312fa1"), }, { Guid.Parse("a80fcbf4-bd8f-45ae-a68b-ecc48da37cd8"), Guid.Parse("8d702c76-f7a1-4c17-a76b-3c9903c10071"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("36dec6ad-0734-485f-8b72-08bbfad97838"), Guid.Parse("b0edee0c-88e4-4339-bc65-195b6ae03703"), }, { Guid.Parse("a33447f2-8fb1-4d20-af6e-049aa5ed02b4"), Guid.Parse("03ef1292-ef2d-4213-93b3-b494b4a7b1b1"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Guid[,] { { Guid.Parse("0766faa2-d62c-41b7-9e15-e93377cea6c6"), Guid.Parse("6734f3e6-7619-41c1-90ad-afbc7818fe22"), }, { Guid.Parse("bb7a0733-b521-49f2-9260-dd6d1dc32eb7"), Guid.Parse("9aa64436-d540-4f25-a3d2-07575d333aa4"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c75df2a4-7ac0-4e3b-99f3-2e6e3fa165ec"), Guid.Parse("98305db6-38bc-4fd4-b4f6-02438023ff7d"), }, { Guid.Parse("2abc9052-984a-43f6-9266-c6d523c08885"), Guid.Parse("3f1d631c-8292-43d2-95c0-37c3cf9f7550"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Guid[,] { { Guid.Parse("c5eb74da-9ae8-421e-b903-091ebc44c3ed"), Guid.Parse("6b24040d-94dc-483e-a642-e1dcda6ee28c"), }, { Guid.Parse("05e02c66-4f9c-4f80-84fd-5bf2cfccae4d"), Guid.Parse("20f412a1-f9db-42ee-979f-1af32d9a0e41"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Guid[,] { { Guid.Parse("bc53ff7b-c4f7-41e6-9ea6-cdc59bd60bf5"), Guid.Parse("0d0f0e3e-5333-44e7-bdd8-ffae6f4b616a"), }, { Guid.Parse("46b71b92-64cd-416d-b818-f7c8a9caec84"), Guid.Parse("64df2740-49cc-4ad3-914d-b9880e990802"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c56d9313-46fe-486a-a539-10e404310308"), Guid.Parse("1c583f74-c7d9-4f55-9312-3fbb37d5ae0b"), }, { Guid.Parse("5a573471-3853-46c0-bd9b-b5c059bdb3d2"), Guid.Parse("bca92900-0231-4e8c-ace3-109187de7370"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c293f271-0e41-4296-8b2e-24ddb77240a2"), Guid.Parse("3a983825-e4b0-415d-92ee-d965cc7e6428"), }, { Guid.Parse("4f13064a-59d1-452c-b51b-a03bbefafbd2"), Guid.Parse("652a5bd2-b7b5-405d-9f16-df0e20107eb1"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Guid[,] { { Guid.Parse("9d717c73-9db2-48e4-be9e-85e1335e8592"), Guid.Parse("36ba7756-74a1-4d04-8f1d-e35e6e838498"), }, { Guid.Parse("00d62466-9ca3-4c7f-86d1-ee922b55001f"), Guid.Parse("bd314c5d-e8b1-4384-871a-3edf2af96f04"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("936c512f-ffe7-4ade-bb90-24bdacca2d54"), Guid.Parse("aaae6392-d6f9-4bf5-bb4c-01b19847dff3"), }, { Guid.Parse("772f6a7e-63e9-4347-8e07-7b09487169be"), Guid.Parse("31b1b7cf-838a-4bd1-9890-30e3c734b223"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Guid[,] { { Guid.Parse("001eab35-2a51-4fec-9ff2-87979b12d1d3"), Guid.Parse("47d4d602-8067-4716-813e-d827f0bd7349"), }, { Guid.Parse("ea0f08b5-95d7-4600-b828-f18058e94d24"), Guid.Parse("229b2a36-a276-4cb5-a3e5-79ad16b1c977"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Guid[,] { { Guid.Parse("917e58e0-6899-44a2-97c0-1455c99f6336"), Guid.Parse("d63dbf4d-ad62-47cf-8af3-17fde2172a10"), }, { Guid.Parse("7b4e0a9f-89c1-42e6-bfed-4d3549b088dd"), Guid.Parse("72c9c63f-5cdc-4c70-873e-297c84c2326a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b0a7e831-2600-470b-8a7e-8429a8ec4dab"), Guid.Parse("bf0a4f1b-5779-4d5d-8d1c-256003c66ce0"), }, { Guid.Parse("5de0711b-b7b5-4c1a-8453-bde82991cfa5"), Guid.Parse("7e221009-ac3d-4d7f-bfc6-f173cd6fc3ba"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("fd9c6c45-f7d3-4d24-8b1d-4799da4d369e"), Guid.Parse("34c3751a-9e25-4d47-90da-27828e9b2a9a"), }, { Guid.Parse("c9b795de-0545-47cd-bbb5-98415c628331"), Guid.Parse("b6047b3f-f527-42e1-a719-55cdb8d09c27"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Guid[,] { { Guid.Parse("032122ae-30d8-4ebd-b7b5-022f8ad80e35"), Guid.Parse("8c76c939-b63c-4b12-b358-1eac39d45b43"), }, { Guid.Parse("6b611fc0-5225-481f-a7b2-8988ae84c983"), Guid.Parse("24f3efb2-e9af-4570-84b4-e5f2c4a5ef33"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 163,
    Value = 
new System.Guid[,] { { Guid.Parse("7988cd96-507d-4393-b113-318e72872df2"), Guid.Parse("a24eb576-dbf2-4e04-820d-5630a5f7a9aa"), }, { Guid.Parse("2bf1794e-1c10-470c-b716-612bb181284c"), Guid.Parse("c7d8b3ca-a547-49b7-8064-c7d393590082"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Guid[,] { { Guid.Parse("1581a9c7-eba9-4273-9364-755018beb59e"), Guid.Parse("3e9d3f56-b7b5-4b31-a20e-553f0f4b933f"), }, { Guid.Parse("2ae6ca75-5368-4dd1-809b-7f877d8decad"), Guid.Parse("5b905ad6-edc6-4d1c-b5c8-39e89a5a3d33"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5fb91b59-9295-419a-bf7c-0fc2b307b59a"), Guid.Parse("b9a97959-8bc5-4079-bf99-9cfbcdf8b4ba"), }, { Guid.Parse("fc548282-7b72-4e09-8f19-8f38b8cb87dc"), Guid.Parse("437d412f-cd75-409f-86f9-6a0883b418be"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6868bdbb-4e4a-4bfe-b8a3-963a323e0a0b"), Guid.Parse("902c2761-3b64-4956-bb4b-cc8a9c8a62b5"), }, { Guid.Parse("a9703e16-7928-4c6d-b265-213e12ea4fbb"), Guid.Parse("8a5216b8-e264-4e34-bda6-a1f3556fd3fa"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Guid[,] { { Guid.Parse("29ba9809-6d49-423b-a238-f2a8e3b1672e"), Guid.Parse("273b10e4-34dc-456a-882b-a690f959610c"), }, { Guid.Parse("e67f8520-3ab5-4613-8d9c-1779f820493e"), Guid.Parse("006a63d9-e33f-454f-b1fa-8043bd96266c"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("bd90073e-90c4-48c0-b35f-ee753411aaf9"), Guid.Parse("c2f4608f-549f-4861-b800-ec32cee75f08"), }, { Guid.Parse("dea2384a-73b1-4e9a-a809-838b9b2eb452"), Guid.Parse("eee2b8f0-0960-455c-997c-16a2d2b18ed2"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Guid[,] { { Guid.Parse("4a497a15-f0ee-4d47-bd8b-c628a8d63b36"), Guid.Parse("934fa4fe-3f5a-4090-9e01-8673a900520a"), }, { Guid.Parse("e9b0b7e5-9963-49a4-8b50-10eec05c244b"), Guid.Parse("488eaafc-acdc-4edb-a5c9-00b2b4fb6334"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("182b9a65-f279-4efd-a5a1-643bc9f52d34"), Guid.Parse("179b8f35-b712-4d6f-b187-eada21d53da5"), }, { Guid.Parse("cd9ffce7-82a6-452a-be3d-63f22c3a8692"), Guid.Parse("0c396db0-53a3-4c12-b197-ee52f462f47d"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Guid[,] { { Guid.Parse("7bd5db12-4d2a-48a7-91fe-0fc047b511dc"), Guid.Parse("1d4fc65f-96e1-4d62-bb2b-0d89f862dd32"), }, { Guid.Parse("3f4b3328-03f8-4ec2-965e-a65f5d2c92ef"), Guid.Parse("62efbe68-832f-4a7e-a6eb-e6ede6a9deb7"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 176,
    Value = 
new System.Guid[,] { { Guid.Parse("8def32e6-79a0-4082-9a21-653d896a8d0d"), Guid.Parse("ce323fbf-ff9e-4608-b5a9-3192083f62c7"), }, { Guid.Parse("1c37310a-7cfb-4b0f-a36a-85f7c58f5894"), Guid.Parse("4b3e098c-234f-4702-8d17-b786be50487f"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Guid[,] { { Guid.Parse("b3fd83b5-2e57-427d-8749-cc83b8aea956"), Guid.Parse("53d2888e-34b5-4303-9027-1f38c7f4f320"), }, { Guid.Parse("93cc061c-2310-405e-9678-7ea54f267bd6"), Guid.Parse("1b84e4b1-c80b-478b-ab33-dba400188694"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 179,
    Value = 
new System.Guid[,] { { Guid.Parse("bf2c8215-50d8-44fb-98af-bc5429494feb"), Guid.Parse("b4c0ad2f-0df1-4eb4-9673-0bb2bb6ff548"), }, { Guid.Parse("8b2599ad-612d-42e3-92de-18b535390599"), Guid.Parse("9a952205-4a7c-4692-90d1-cede08871bd3"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("486bc2f7-5ccd-418a-afc8-cd27f3072ea2"), Guid.Parse("6a38d1b5-5e66-42c8-a4fd-197d0929286e"), }, { Guid.Parse("02e1931f-9bc3-49cb-bdf0-27a935804458"), Guid.Parse("68b6696f-4014-49c7-a3e9-7e95c8d9d932"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 187,
    Value = 
new System.Guid[,] { { Guid.Parse("eebdc3da-ea98-4af1-b45e-c2c3bfe8f603"), Guid.Parse("328449e3-9dde-4e2c-b968-88698fbc58ce"), }, { Guid.Parse("889c9156-5a70-4691-9e5c-f64243844310"), Guid.Parse("5ff09471-accb-424a-bfa7-a3c0b9d9018d"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Guid[,] { { Guid.Parse("ad76efc1-0e24-47b9-9ffd-572c52137e48"), Guid.Parse("6eba9e66-1735-45e8-8ca8-2bc8721dca20"), }, { Guid.Parse("8b46eeab-dbcf-4c31-84c7-a3d045419ed2"), Guid.Parse("15a9b017-821f-4c1e-9a90-5cc1c652e984"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0ea12452-9209-40cf-b416-fe2aa81714b5"), Guid.Parse("c170efd5-bf71-42cc-a55c-c12c58d32406"), }, { Guid.Parse("6d209faf-ae99-4522-9dd8-4ab9d80942ad"), Guid.Parse("62bffbbc-893c-4838-a734-8909a8510759"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 189,
    Value = 
new System.Guid[,] { { Guid.Parse("c577bcb5-7766-4870-9a44-f407b7fe2e1c"), Guid.Parse("03fbaa04-b22a-478a-8cc2-5afbe491e68c"), }, { Guid.Parse("00f92872-c7a3-4150-9aa8-2189c5ac2887"), Guid.Parse("d7be255e-9f5d-430d-b25c-e1769b91a988"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7f611ca0-90ad-4a04-b59c-93b6c0897d5c"), Guid.Parse("ef472e8f-912b-41c9-843e-9dd67493f34d"), }, { Guid.Parse("2e63029a-a270-4b2f-90eb-b33478ceb5f1"), Guid.Parse("9c2faf5a-bc01-4b20-974e-9a8cf9b5ccd9"), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
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

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("ea8da14e-2cfa-42a2-9754-3067a9ed0609"), Guid.Parse("e713a618-5bed-4634-b160-f6e75860eb44"), }, { Guid.Parse("05e692d6-3a5f-4013-8bbb-e59f58d38f8b"), Guid.Parse("dd0a2cab-c914-42d6-823f-7d10ae6bf6e4"), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("a5c2f240-67a4-400f-b52a-84c596440822"), Guid.Parse("826490be-3389-4986-8ebf-f405cc2ae873"), }, { Guid.Parse("36e10ab4-33ae-43f8-b29f-541ea0a6333f"), Guid.Parse("4cbd7db5-1cd4-4798-aea7-4d63be911d17"), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                System.Guid[,] nullable = null;
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("e6bb213a-c4dc-4868-aeb5-70ac937cda91"), Guid.Parse("945d48b5-a698-4a2d-b0f2-982a0f2e9fd0"), }, { Guid.Parse("d919058c-5ff2-4604-9c1c-2608906e9ecc"), Guid.Parse("eebe7587-4808-4934-bb36-be657934704b"), }, }));
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("243589ae-9e9f-4f74-9e50-89231bf88d19"), Guid.Parse("fb9db52a-7883-41a8-a143-5a3b326cfb37"), }, { Guid.Parse("68eafc1d-a687-4250-8eee-5d6592191b00"), Guid.Parse("6b163b3b-e054-4bc3-9149-99734e23f345"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("437c0774-63f8-4831-9e47-35a61b4cf64c"), Guid.Parse("a7d6c0c0-3685-4d7b-b1ee-8eaf3e376ab3"), }, { Guid.Parse("9227ce80-3ed4-469d-a495-3e40ac1d8396"), Guid.Parse("ea28ee24-dee2-4a5d-854a-a53b0a422fa0"), }, }));
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("1d791edd-ce1f-4987-a19f-e837c1e2c88c"), Guid.Parse("ebc26a66-5635-4116-8346-55797cf3625b"), }, { Guid.Parse("09a11d18-bdcf-4578-a588-27042ebd72ae"), Guid.Parse("2f56f6e9-b234-4966-a7a3-55a6f67632ed"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 162;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 176, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 169, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 20, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 20, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 5, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 52, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 167, query1, 179, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 169, 25))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 79, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 162);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
FROM public.binary_guiduuidmmarrayd2e1m m
LEFT JOIN public.binary_guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI), typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

