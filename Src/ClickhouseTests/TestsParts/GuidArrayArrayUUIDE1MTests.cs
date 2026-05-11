

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
    internal partial interface IGuidMArrayArrayArrayUUID
    {
    }
    
    internal partial class GuidMArrayArrayArrayUUID : IGuidMArrayArrayArrayUUID
    {


#region TestData

        private readonly GuidArrayArrayUUIDE1M[] _testData = new GuidArrayArrayUUIDE1M[]
        {
            new GuidArrayArrayUUIDE1M
{
    Id = 8,
    Value = 
new System.Guid[,] { {
Guid.Parse("4db44049-96bd-41fc-932b-5dfe6c365788"),
Guid.Parse("dd2efda4-c889-4754-9c40-d49450dfd51e"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 5,
    Value = 
new System.Guid[,] { {
Guid.Parse("ebe18620-d657-478e-ad8d-a708a3bde465"),
Guid.Parse("1137d147-ec80-4282-9bca-0259f7a38b13"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("2e4aac5b-b88f-4ab0-a2fe-8b09dd9aa4eb"),
Guid.Parse("9b890d6f-5550-4d20-bfc6-7b6564ae68e4"), } },
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 11,
    Value = 
new System.Guid[,] { {
Guid.Parse("af4c77ad-1c89-4bd6-8f94-4a20ab718c8c"),
Guid.Parse("bf8130a7-d1bd-451e-99a7-b5292b89c70a"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 7,
    Value = 
new System.Guid[,] { {
Guid.Parse("d8b10390-d262-4941-969e-118d02203888"),
Guid.Parse("9dcf1b43-b610-48a1-8985-3ea724dfdf0a"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("745f7ef2-a73a-4524-99fc-a7a30b0e8b3d"),
Guid.Parse("e724776c-45a5-48ca-b530-193ecb75c159"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("190bd8bd-8169-4ee6-aa1a-e0fdd88511c0"),
Guid.Parse("87a4fe4e-0705-40fd-bbbc-be8966765324"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 18,
    Value = 
new System.Guid[,] { {
Guid.Parse("5505d0fe-82ff-4694-b6c5-230514378d91"),
Guid.Parse("e1dcb276-fad2-451e-bec8-62dc07fd0a33"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 14,
    Value = 
new System.Guid[,] { {
Guid.Parse("3f43458a-a45f-45c2-9b4b-39106d5df703"),
Guid.Parse("10fe7e8f-863d-4953-b959-5897e6fd11ee"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 27,
    Value = 
new System.Guid[,] { {
Guid.Parse("68c3ba1a-add7-4e45-a5d8-d398fbbf3560"),
Guid.Parse("5b7c5fcc-6f58-49bb-a1b1-7dbcf0176298"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 19,
    Value = 
new System.Guid[,] { {
Guid.Parse("5972a6fe-863f-47cc-936a-1f7269167834"),
Guid.Parse("f9540965-812d-408a-8665-64ed131557f6"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("1e40ae81-9dd5-4e50-aebb-be9603921a89"),
Guid.Parse("2c8e823d-a8a0-4428-9451-98f087921d25"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("2982f1ab-2eac-48ad-aba0-bb7157053889"),
Guid.Parse("20cc61e1-16b4-4f61-9c8b-7e4bd9f38f7c"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 34,
    Value = 
new System.Guid[,] { {
Guid.Parse("948790c8-712a-40d7-bb5a-017d75707167"),
Guid.Parse("e9794101-7a23-43b3-b2e7-6866e16bd0aa"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 24,
    Value = 
new System.Guid[,] { {
Guid.Parse("82608d58-dbe7-47fc-893d-b227e293206d"),
Guid.Parse("6198e857-8f89-4bc9-9fe4-54aa1af06d39"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 38,
    Value = 
new System.Guid[,] { {
Guid.Parse("a9691741-b3cd-4d8b-9b70-7a5d034b51bb"),
Guid.Parse("443f1c55-a5d8-4a8c-95e4-5f4154b66a63"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 31,
    Value = 
new System.Guid[,] { {
Guid.Parse("9be0b361-828c-495d-9c66-7deb4b103d3a"),
Guid.Parse("e809f6b4-f0ce-44c0-a151-f8b75aa348ca"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("9b4b8ccd-a803-42a9-8562-33b42b7731d5"),
Guid.Parse("c524dcf1-5862-4c83-a9fe-f0da6182c977"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("fb0e1d0e-5a37-4c7f-b1f7-3b93064734f5"),
Guid.Parse("611c30ed-1a92-46c5-aa88-c54737a5599c"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 39,
    Value = 
new System.Guid[,] { {
Guid.Parse("2b590d7a-4443-4707-a26c-bda3f1cd0323"),
Guid.Parse("e3e335d5-4c99-4388-bffd-bd49cf18ce40"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 36,
    Value = 
new System.Guid[,] { {
Guid.Parse("effa0f4c-ac33-4bdf-9f6f-21bc19a0033c"),
Guid.Parse("3a0d9b46-7900-4480-9e7e-0153b937e330"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("eaaf0151-9eb7-409e-a9f5-16f80cd64744"),
Guid.Parse("f1134bd2-4204-4b42-b911-0f0047bdd93d"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 40,
    Value = 
new System.Guid[,] { {
Guid.Parse("1ed27f1e-0a65-438a-b883-eee2e05a1ad8"),
Guid.Parse("cc7808ca-820b-44be-96c5-670d3615d5cd"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 45,
    Value = 
new System.Guid[,] { {
Guid.Parse("d4e29886-e637-4e29-bb2c-8a3f0539d5a6"),
Guid.Parse("e6190c20-455c-4908-9e90-ffa3e104b97f"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("5da0b035-59b3-4471-9a38-12d5c556bb1c"),
Guid.Parse("5f1a9810-2df5-4fc5-aa4b-9c8c5827f402"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 49,
    Value = 
new System.Guid[,] { {
Guid.Parse("c4e3451d-2ed9-4f12-ab67-c20dc9062a90"),
Guid.Parse("4469a3a6-d2de-4ffd-84d5-b3d014b3ee16"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 53,
    Value = 
new System.Guid[,] { {
Guid.Parse("b17b19f4-8da8-4f6f-840f-b7d000b0bf93"),
Guid.Parse("8ffb04f9-4e33-4fc0-af39-8c88d8b41323"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("00a35892-aa5b-4414-adb3-eeff63ce6873"),
Guid.Parse("79805c40-2ccd-44e6-bc8a-d224a2ec3cea"), } },
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 57,
    Value = 
new System.Guid[,] { {
Guid.Parse("ce5058fd-a868-43d1-b256-57d289b76c42"),
Guid.Parse("e540e3f7-99eb-45b7-8556-0675c18b1e17"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 54,
    Value = 
new System.Guid[,] { {
Guid.Parse("2b853aa8-e0da-4107-8cce-b36fb74ea21f"),
Guid.Parse("4ae565a3-2243-4f2b-87d9-d90cbad16cae"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("338ba800-4e46-4f37-92d8-a938c6135c2b"),
Guid.Parse("1741bfc8-163d-4459-9748-2416962c2edc"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("0356aba0-b74a-4643-9993-99f31dd875a9"),
Guid.Parse("8f6c468d-088b-41df-be44-e23e4e74a9d0"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 58,
    Value = 
new System.Guid[,] { {
Guid.Parse("1159b4e5-d184-4765-bbf9-effb544d95ca"),
Guid.Parse("1867e367-497d-41d5-a8b8-9156646435e0"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 58,
    Value = 
new System.Guid[,] { {
Guid.Parse("ddd645ee-7b66-4d7e-b2c0-b521d5ebabdd"),
Guid.Parse("0a415307-aaed-4079-b84a-9f29afeb1d82"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 60,
    Value = 
new System.Guid[,] { {
Guid.Parse("4cca3126-bfd0-49fd-826f-097f17bf5ff8"),
Guid.Parse("cb4d194c-4f28-4476-bef2-5bf6bb7ec4de"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 66,
    Value = 
new System.Guid[,] { {
Guid.Parse("3dd22871-7409-4a18-89f2-7666c055d754"),
Guid.Parse("1ceb2e03-aa9f-4046-a626-ad3ea5d6b1e2"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("1856ecc6-e4ba-4e1f-99e9-f3d458c5010c"),
Guid.Parse("7184ebfa-0956-4204-b6e2-fde0e93fc99a"), } },
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 61,
    Value = 
new System.Guid[,] { {
Guid.Parse("a85cd70c-6850-4727-b59c-a97f691b9585"),
Guid.Parse("f7bdd341-31a9-444e-8d57-6ab965e167f7"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 70,
    Value = 
new System.Guid[,] { {
Guid.Parse("e85899c2-73c2-4172-96b9-fe72c108fbdc"),
Guid.Parse("29f17f5e-30d0-4a74-bb80-c75c70d93bfb"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("05639726-1153-4704-8067-a2763999d688"),
Guid.Parse("1ab18e2a-2939-479a-89d7-12cf8338f8d6"), } },
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 63,
    Value = 
new System.Guid[,] { {
Guid.Parse("7128c96f-a260-491b-93f3-2ad25be7d3a0"),
Guid.Parse("d8f0285b-3934-47b8-9aec-2ca1ea86ef53"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 79,
    Value = 
new System.Guid[,] { {
Guid.Parse("f370a89d-c41d-4fdc-a0b0-3ef48ae4b50d"),
Guid.Parse("f99b569d-947d-4774-be85-db67251d4fb7"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("c4ecf739-baad-4498-b870-b26389592ece"),
Guid.Parse("9023086b-dadc-43a3-a5a9-b3a5f85ca538"), } },
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 65,
    Value = 
new System.Guid[,] { {
Guid.Parse("1a4de048-2805-49d6-be52-1eedfc846018"),
Guid.Parse("8017d679-1c6c-4d92-b0a4-5775fcb0f421"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 80,
    Value = 
new System.Guid[,] { {
Guid.Parse("cf67f111-eabd-4521-a374-d690094f3e71"),
Guid.Parse("83e6e692-5591-43e1-a02c-0bc30c49cc14"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("0b15fed0-8ced-446e-acc1-960104f1e302"),
Guid.Parse("975b07a0-bf87-4135-9591-cc935acde2b7"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("28cec68c-867e-46eb-98e9-331b7b566d39"),
Guid.Parse("993460f6-4988-42cf-8b24-b7105f08fffd"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 68,
    Value = 
new System.Guid[,] { {
Guid.Parse("38101fda-c82a-4fd2-be86-d69705f8ed85"),
Guid.Parse("fc2d6df6-4857-4cbd-9d85-e413ee44647a"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 89,
    Value = 
new System.Guid[,] { {
Guid.Parse("32df3058-471a-4d4b-b73a-7713ae03f750"),
Guid.Parse("0e83703a-b3b9-4ef4-9205-0efab1fa55a9"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("f0f209c8-ede3-41de-b67f-9ab171a7340a"),
Guid.Parse("a41bd278-03e2-4e82-8791-271792014972"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 70,
    Value = 
new System.Guid[,] { {
Guid.Parse("afff2df3-8f7b-4e68-a700-3438cef41253"),
Guid.Parse("8ceed202-66fb-4b76-8141-6cc8a65e1c4f"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 90,
    Value = 
new System.Guid[,] { {
Guid.Parse("3e24f5dc-ff5a-4268-a563-9d778d6e9d5d"),
Guid.Parse("d36e9f1a-2ae5-467f-8182-d75c4c406ac5"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("6f3d4435-c2b8-4322-a74c-dcf0eedd09e9"),
Guid.Parse("71520dd2-ce8d-4b61-85a3-9139b1965e65"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 75,
    Value = 
new System.Guid[,] { {
Guid.Parse("8766364d-55b9-48af-afdb-d5d76168fb83"),
Guid.Parse("408711be-e0a9-4626-923c-55d45022592f"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 98,
    Value = 
new System.Guid[,] { {
Guid.Parse("55eb40d2-3bbf-4c5e-ab91-5db5754c9e1a"),
Guid.Parse("d098f23e-ce98-49e2-a736-0bce962962cc"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 80,
    Value = 
new System.Guid[,] { {
Guid.Parse("5f92dae0-f6d3-4f9e-b445-e364eb20bda3"),
Guid.Parse("6c979768-2c1e-41ea-903a-2ce22e33332f"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 104,
    Value = 
new System.Guid[,] { {
Guid.Parse("0721a472-bd30-411b-8a05-7b8fcceb69a6"),
Guid.Parse("209f442a-d554-4b1b-a403-6dee50c82142"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 84,
    Value = 
new System.Guid[,] { {
Guid.Parse("092966e0-6a8c-44bc-b5bb-ff582fb06aae"),
Guid.Parse("1f169a14-1645-41d3-9e4c-b450516f0699"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 108,
    Value = 
new System.Guid[,] { {
Guid.Parse("89d04fc1-f02f-47fd-8ba0-933defc3e5db"),
Guid.Parse("816d85ca-bf82-49a5-ad35-b80cfa98fc3a"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("f5a4797f-fbd8-4687-9794-68589fb473d3"),
Guid.Parse("49c77902-04f4-47f4-b8eb-03d59dd53bdc"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 90,
    Value = 
new System.Guid[,] { {
Guid.Parse("0ca8f834-0d89-42ab-9fc8-71f7f9a75f03"),
Guid.Parse("7cc58dbd-b7ba-432c-9316-14553b743fcd"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 117,
    Value = 
new System.Guid[,] { {
Guid.Parse("7f11ebea-3c44-41c5-8893-2167e5da4d5e"),
Guid.Parse("77a6d058-7cc1-4423-90f3-b4e99458d1bc"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("c182bc9f-e65e-4b40-961f-a4417c289be0"),
Guid.Parse("52e3ce1a-6582-4400-b716-37131ae4b5f7"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("e2a182e1-5784-4301-a696-565f961439e5"),
Guid.Parse("d357626b-8c88-4ee9-b476-31312e524565"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 97,
    Value = 
new System.Guid[,] { {
Guid.Parse("46675ada-92a8-4b54-b659-7785fddea769"),
Guid.Parse("d7751783-9e4b-4718-a028-16feab84cefa"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 122,
    Value = 
new System.Guid[,] { {
Guid.Parse("e1dd4fef-bdce-464c-86e5-b07e0352e475"),
Guid.Parse("5c05be08-3ecc-413f-ab39-c24904b78305"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("4a506a48-6b6d-47a6-b190-5aac4420e65a"),
Guid.Parse("45111899-08de-484d-87b8-d2df78c21e3f"), } },
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 103,
    Value = 
new System.Guid[,] { {
Guid.Parse("3e0fd448-bb7d-404c-ab87-9acddbd28100"),
Guid.Parse("85fdbfb0-7370-44b3-ad68-f78b952b463a"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 127,
    Value = 
new System.Guid[,] { {
Guid.Parse("fa0d299b-e33f-4072-9c03-0bda0d06f2b0"),
Guid.Parse("83d109dd-ce39-4d47-9a33-818113730ba3"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("121e85b7-e93d-498d-8441-891a65ad7105"),
Guid.Parse("bbad73da-a136-4e26-9c38-8d4f865eb32e"), } },
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 109,
    Value = 
new System.Guid[,] { {
Guid.Parse("969cbf82-be81-4121-8cdb-a76f236d4d00"),
Guid.Parse("18d0b56b-e59e-4430-86b0-73f2d81ec43a"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 131,
    Value = 
new System.Guid[,] { {
Guid.Parse("d12f3dc7-67db-4176-99bf-bc0a72700661"),
Guid.Parse("41f5841f-d27f-4249-85a5-2c87a57b35be"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("c28266d7-a736-484d-8f87-c6d2c2febef3"),
Guid.Parse("e4025201-2138-4c0a-a7af-b60221623199"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("44e2ffc9-7368-4989-874d-c93ccd57c99b"),
Guid.Parse("b079e6c4-68fc-4226-90ce-1948f5f87dc5"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 112,
    Value = 
new System.Guid[,] { {
Guid.Parse("21464206-66ca-4ebc-88e4-326b3e79851b"),
Guid.Parse("1b654808-bcd2-450a-b03c-9d87a010b2b0"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 138,
    Value = 
new System.Guid[,] { {
Guid.Parse("b60a3f71-2a33-4b13-9ae3-06e4519e0fce"),
Guid.Parse("3dffc13f-bf20-4ffa-8696-c491702d8a27"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("94d4e2dc-c9f9-442d-8118-6e3352d86395"),
Guid.Parse("efea109e-cc4d-400d-88c0-61f017d494d8"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 116,
    Value = 
new System.Guid[,] { {
Guid.Parse("b7b88a72-734e-417c-acc4-389c42778861"),
Guid.Parse("60f4fc1d-f2d3-4a2a-9600-8ff2c7e1f831"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 143,
    Value = 
new System.Guid[,] { {
Guid.Parse("c22bafeb-4179-4c39-a2f6-b23a30d5088c"),
Guid.Parse("0873e9cb-5f0e-4e95-a1b1-347e83362740"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("f15ed181-07e3-489a-a414-bc84c382da59"),
Guid.Parse("1f30a8c9-82ea-4794-a1a2-42c2f722e4ed"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("260ea771-e619-4f3c-a135-9be586c667d5"),
Guid.Parse("57c2eed5-9f45-42bf-a205-e6c3ddd153b7"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 124,
    Value = 
new System.Guid[,] { {
Guid.Parse("2493d044-2746-4469-ae78-8211b40c50a6"),
Guid.Parse("906d0db6-38ab-4786-8421-1b24b46387a2"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 150,
    Value = 
new System.Guid[,] { {
Guid.Parse("2604d113-aa13-4c97-8ace-740c47cc8ff1"),
Guid.Parse("4f83348a-9869-4d63-8c8d-1554c1f0fe12"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("2f2ce661-b422-41bd-9b71-94fb7ded80aa"),
Guid.Parse("dd26f039-a0cb-4cb3-ba81-4b8fe3f23ee9"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("7c3b0d3d-1bd9-4a1f-9e16-54b1b02b5dfa"),
Guid.Parse("80b87737-1535-4899-a1ce-3e34e1e31914"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 129,
    Value = 
new System.Guid[,] { {
Guid.Parse("aee274fe-ae1b-41d4-8bf3-1e3bd7193dd0"),
Guid.Parse("ef989366-a95d-4e27-aa1e-b514167f8c24"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 157,
    Value = 
new System.Guid[,] { {
Guid.Parse("b05e7efb-4ee6-48bf-8d56-1251093cbdb4"),
Guid.Parse("b3b1abb0-048f-4bfb-8579-4ec3183d0e79"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 131,
    Value = 
new System.Guid[,] { {
Guid.Parse("b74670b2-8a3e-4c9b-8810-24614d2dd204"),
Guid.Parse("fc1973b9-ba3d-419b-b405-224d128cd2b4"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 163,
    Value = 
new System.Guid[,] { {
Guid.Parse("9404022f-c69f-46d0-8ebb-84ec9d6c9170"),
Guid.Parse("a90a78ed-9a35-4228-a363-60745f4af615"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 138,
    Value = 
new System.Guid[,] { {
Guid.Parse("16925a68-6963-4f1b-b298-8a49d554efeb"),
Guid.Parse("955c3ee0-4cf4-4f84-88c2-8ed00aee2499"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 167,
    Value = 
new System.Guid[,] { {
Guid.Parse("bb9febdf-44f2-4ade-8cf8-64ba80eeba12"),
Guid.Parse("8e6620d6-14cf-467e-8106-978471853143"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("a11a1b06-6b49-4b61-bb52-4a6f85dbab4a"),
Guid.Parse("a723b817-9317-4c72-8726-7831982061f6"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("ae09c781-8b9a-41a4-84dc-e90af197d020"),
Guid.Parse("632595ba-9030-43e3-bfa0-92905252a6e8"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 142,
    Value = 
new System.Guid[,] { {
Guid.Parse("81b0b1f3-af7b-474d-80ce-0018bbfc07f4"),
Guid.Parse("0465366d-e8a2-4a34-9eea-24b5c9d98696"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 175,
    Value = 
new System.Guid[,] { {
Guid.Parse("34f88341-8fad-4c58-84b6-dbf27b523de7"),
Guid.Parse("557d5139-edf9-4352-a34d-c25d667f4356"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("c33b6f45-a34d-4f08-b1b5-992ea07e7c58"),
Guid.Parse("c3de14b8-7858-4d2d-93fe-cd4b346eb544"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("1e3cf8c4-0453-43b4-b912-b2af2c610fcf"),
Guid.Parse("ff45bd81-8d22-4f55-bc66-7788034ff3f5"), } },
},
            new GuidArrayArrayUUIDE1M
{
    Id = 148,
    Value = 
new System.Guid[,] { {
Guid.Parse("b02d26f6-bcfd-4fa4-a69e-167eaaec76b2"),
Guid.Parse("de54841d-460a-4df4-8d25-9f9b94cb54f3"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 183,
    Value = 
new System.Guid[,] { {
Guid.Parse("8a007189-2768-43fd-926a-281bcd6a6e99"),
Guid.Parse("4f583074-1ca7-4931-b895-eae3cb58b48f"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 155,
    Value = 
new System.Guid[,] { {
Guid.Parse("60b59bf2-8a93-4d31-ad32-cd6f25d411f5"),
Guid.Parse("9be9fc20-5b4e-4a05-8cdd-ea65391d619e"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 190,
    Value = 
new System.Guid[,] { {
Guid.Parse("03c549b8-bbb2-442b-b381-d92b0dcd8e71"),
Guid.Parse("f11bed22-a338-441e-a972-a23d3ddac90b"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("d8ebfb1b-a620-4a5c-b52b-1139bd74d912"),
Guid.Parse("5d49285b-4460-4b69-bd1e-2422ffdce0d0"), } },
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 163,
    Value = 
new System.Guid[,] { {
Guid.Parse("744a87b7-f773-41db-91fb-0e5c03e9d4f6"),
Guid.Parse("ca4cf91d-0feb-4ecc-94b2-f3377279fc18"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 199,
    Value = 
new System.Guid[,] { {
Guid.Parse("00fc1623-8df6-4d89-8d82-dc03db85ef9a"),
Guid.Parse("a1fda488-0f1c-4dc9-890c-33c2cb61775f"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("77188f09-373d-4a98-901a-cb8c389af4a3"),
Guid.Parse("6baf5361-56e2-44bc-b8e4-a078c8d0b796"), } },
},
    NullableValue = null,
},
            new GuidArrayArrayUUIDE1M
{
    Id = 167,
    Value = 
new System.Guid[,] { {
Guid.Parse("32a3fbc0-e40c-47bf-82a2-295055672902"),
Guid.Parse("6bf949c2-75da-45a0-b2f9-665a6e2c83d9"), } },
    ModelInner = new GuidArrayArrayUUID1MI
{
    Id = 207,
    Value = 
new System.Guid[,] { {
Guid.Parse("521932f6-7612-4443-bfb9-4a7a734ba858"),
Guid.Parse("6420dcc1-8101-4597-b0c9-77e74301f664"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("a72b9cc4-3984-49bd-8c34-d3a265cf71ab"),
Guid.Parse("6b27a5a8-bca0-463a-a19f-4f71b42b6ca2"), } },
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
INSERT INTO gedaqtests.guidarrayarrayuuide1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UUID))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UUID))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayArrayArrayUUID)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
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
                    await ((IGuidMArrayArrayArrayUUID)this).InsertModelDbConnectionAsync(
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
                     ((IGuidMArrayArrayArrayUUID)this).InsertModelDbConnection(
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
FROM gedaqtests.guidarrayarrayuuide1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidArrayArrayUUIDE1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayArrayArrayUUID)),
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
                    var models = await ((IGuidMArrayArrayArrayUUID)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidArrayArrayUUIDE1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidMArrayArrayArrayUUID)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidArrayArrayUUIDE1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

