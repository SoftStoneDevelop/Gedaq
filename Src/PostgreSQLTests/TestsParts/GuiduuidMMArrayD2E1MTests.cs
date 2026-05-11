

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
new System.Guid[,] { {
Guid.Parse("3693ec21-80c8-4cfc-ad70-f0e66df4b04b"),
Guid.Parse("d5429417-93f2-4c04-82de-58e254e90187"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Guid[,] { {
Guid.Parse("26c3ddbd-2b4c-474c-af60-616f837ac249"),
Guid.Parse("bb4c5bfa-7a84-43b1-b2d8-961d9a92dc0b"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Guid[,] { {
Guid.Parse("25ac339c-af2b-4637-9681-feac484e3a79"),
Guid.Parse("0a2bb35e-129b-4e6a-b0ed-01a25d2cd38b"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Guid[,] { {
Guid.Parse("da656b1c-6b75-4a0c-9779-f3f60625bc6c"),
Guid.Parse("21e13cb2-749c-4cca-aeef-a5fa27091cf6"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("de1c0430-2d80-4964-9e96-e915d23cedb6"),
Guid.Parse("bae5b6c0-97ad-45e2-a62d-739b6257d018"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Guid[,] { {
Guid.Parse("1f29e55f-89f0-4ccd-9a1d-930e7aeba5f8"),
Guid.Parse("0e39d0b1-976a-40d6-8d7c-145defaff790"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Guid[,] { {
Guid.Parse("782cc96f-4374-4693-8895-6806850b53e5"),
Guid.Parse("4a20d25b-dfb8-471b-b5bc-9ef2751366d1"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("480627e5-14a3-49f4-b5fc-d149a58188c1"),
Guid.Parse("116ad267-21cc-41f0-8589-d5cc219a4b16"), } },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Guid[,] { {
Guid.Parse("270bbfbe-58a4-42fd-97ed-c01a06597dda"),
Guid.Parse("9023d65b-8fc8-4a70-b0f7-b70040d2dec2"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Guid[,] { {
Guid.Parse("b2988824-9af4-4e6c-9875-e5389f3b8fd5"),
Guid.Parse("678284b5-df3b-4def-9fec-a5b5981b07d3"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Guid[,] { {
Guid.Parse("c2ca13f5-22d7-4302-8999-cbf1b718aeb2"),
Guid.Parse("447e2461-99ae-49ea-8a9a-ebc3a2888aad"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("344e39e8-9bf2-4e47-8b21-dc0618b6cd7a"),
Guid.Parse("f24ce22f-4d31-444b-8653-c364c09b43b3"), } },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Guid[,] { {
Guid.Parse("3aad12f2-6356-47bd-a629-ffd30f68ce94"),
Guid.Parse("00502396-6cd0-4cc9-b544-362474100ca0"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("0f69eb1f-c2c7-4cc6-9573-3def497d1f57"),
Guid.Parse("2b5400ba-dd8c-497b-b08d-445b2169f6b0"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Guid[,] { {
Guid.Parse("0d6f7b23-716a-4951-a702-be30f47160f9"),
Guid.Parse("ba3b6ec9-2c9a-43ce-a397-b9e11201d03e"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Guid[,] { {
Guid.Parse("f58b50a8-4368-4441-b402-111363da8377"),
Guid.Parse("4e0f5521-2953-4b92-9439-f2669b0a6e52"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("400f8ae2-9746-4b27-bd94-0da68e939478"),
Guid.Parse("4ef1abd5-eeba-4da7-8c75-06a786daa050"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 30,
    Value = 
new System.Guid[,] { {
Guid.Parse("b1271333-de84-4062-9778-e3c930cf917b"),
Guid.Parse("24ca293f-1a80-4e36-a7dc-21591601020d"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Guid[,] { {
Guid.Parse("12bb63b7-9483-485d-aa2a-73d50677eaf6"),
Guid.Parse("58779c73-00f4-4a21-b406-2bfac383bef8"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Guid[,] { {
Guid.Parse("14187e3c-ddb2-4586-9e15-e43e5bafb75a"),
Guid.Parse("f5a6dda6-0f9d-404c-8f77-264faf3ad5ff"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("d422299f-d59e-4ac4-be37-bc6cfd6435bc"),
Guid.Parse("2c2f3652-9e5f-49eb-9bb2-f3ae8f043039"), } },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Guid[,] { {
Guid.Parse("aafd0eb0-b09b-4ca2-a083-451b307d2b79"),
Guid.Parse("abc3be29-5a81-4849-8ec2-dee7ecf8820e"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Guid[,] { {
Guid.Parse("2ccf740f-249e-43a0-a8d2-2aafcf779b41"),
Guid.Parse("8c0b8bbd-681a-4f99-a476-7da156b9d3e4"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Guid[,] { {
Guid.Parse("8b2bac3d-bfca-4c4c-b88b-5982f6e67790"),
Guid.Parse("ec96cabf-33b2-4d37-87c2-70ddfe1e720f"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("2c655273-7bd0-4afe-a11c-ced14b56cc6b"),
Guid.Parse("fb81bbd5-cd17-4c03-b195-c0059e850f8a"), } },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Guid[,] { {
Guid.Parse("2580b971-a829-468d-9823-8fb87b6a44fb"),
Guid.Parse("6ec3f48e-c4fb-4fad-8a9a-f7f55ca9fd42"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("8234095e-19d6-4b74-9fa3-f3c07d093a5c"),
Guid.Parse("5b28b15b-1b51-470c-a987-179f84f22716"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Guid[,] { {
Guid.Parse("9d7ba813-a402-48ca-a692-fc75c7823465"),
Guid.Parse("0702dad0-aa0c-4ab5-865a-a9d9647a4dcc"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Guid[,] { {
Guid.Parse("59b0b061-6236-4e7c-b60e-c337e13416fa"),
Guid.Parse("d2492605-8347-4dea-91f9-5af52e5f73e8"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 71,
    Value = 
new System.Guid[,] { {
Guid.Parse("0345dae8-a904-4b71-b98c-e9cbdd8f96ba"),
Guid.Parse("eea2baf0-458d-44fb-bc12-9c2db451cc27"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Guid[,] { {
Guid.Parse("c095235c-3b2a-463e-bbc3-580e3909612b"),
Guid.Parse("ab04719b-7bf3-4458-bde5-88f3e9b37f10"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Guid[,] { {
Guid.Parse("1a316f77-9a3f-47ca-a324-b1dfb7ed121d"),
Guid.Parse("6b5148f1-a3a4-4d3f-bb96-f7ea625a30d8"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("37d7da28-fe4c-45b3-b71a-cd5f88d6b0a9"),
Guid.Parse("806e8cce-12d5-452a-8c31-778e94aa3649"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("c68dec54-3300-4439-8363-5d82f1d6989f"),
Guid.Parse("83882a63-b296-42a4-a363-573b339c691b"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Guid[,] { {
Guid.Parse("d99272df-9aba-447a-86f3-03cc77127673"),
Guid.Parse("e4f8b42d-d480-45d6-bd7c-fb42d8db2e55"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("d265063b-e89a-408d-9f4b-78668931bc56"),
Guid.Parse("b78ba628-306e-4ef4-9283-e7656669b4be"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Guid[,] { {
Guid.Parse("fbef9a72-3e6c-4235-9be0-e99909f127fe"),
Guid.Parse("34ddd09e-af8b-4a7d-88af-9ff67d5e8c4f"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Guid[,] { {
Guid.Parse("522c4850-5e86-480e-a491-150bbee27134"),
Guid.Parse("b69268a4-beef-432a-9027-7dedc2971f5e"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("5b55116a-3358-49c9-9f67-2daf4823adb6"),
Guid.Parse("72ec80cc-5bdb-4941-b03f-90ad31e2d394"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("2aa4203b-ada1-45bd-ba56-a651ca276e6e"),
Guid.Parse("1cb32392-5c56-471f-9f03-bc13db7b01b6"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Guid[,] { {
Guid.Parse("6a737925-926d-403a-b6a4-22b794d4a9b6"),
Guid.Parse("c9ea6fe1-1834-4725-99c2-1f69745d06c9"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Guid[,] { {
Guid.Parse("6ed6606c-5a9b-4fda-9da1-db137613da17"),
Guid.Parse("48d5de07-1c74-4382-9fe1-51ced5130028"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Guid[,] { {
Guid.Parse("c44562ce-e37f-4c63-9bd3-467a78fcc2d6"),
Guid.Parse("3e410543-3f8d-453c-9f8f-b00daab46ae8"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("a8e67f13-62d0-4e4a-bd7c-9afb09a80196"),
Guid.Parse("c709371a-ffb1-4e02-abd3-9bed9e661552"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("797f1e5b-6730-444d-b4e1-c95d026db2c5"),
Guid.Parse("3d612023-f583-4676-b834-1b61b6bc83e1"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Guid[,] { {
Guid.Parse("e07b8ae1-8dc1-4fbf-8a52-dca75ce0dc0c"),
Guid.Parse("51d5e1e1-712d-42ba-994a-3b84421a8a98"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("5293cb62-6e7a-41bd-9019-2652ff638207"),
Guid.Parse("a1beaa75-e64f-4c14-937e-e7ccedf157ce"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Guid[,] { {
Guid.Parse("41656073-c280-4b52-b3f2-ee3d6c38d1e7"),
Guid.Parse("0ce66a09-bf01-4dd7-8282-ca27b1194a17"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Guid[,] { {
Guid.Parse("36a5504e-a753-4f92-91e3-b1aa0091ef4c"),
Guid.Parse("a9b23e59-9bc0-4d7d-a1a6-106abe69d7b2"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("ac4bfb3b-4099-4694-b669-868dd92febb9"),
Guid.Parse("f0770e47-a3bc-449c-9a56-ce69402bcfe5"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Guid[,] { {
Guid.Parse("fc28465c-0a57-45b5-b2fc-c2007ea40f7f"),
Guid.Parse("c07bc1ec-8da9-4acb-a0d3-d4fdf5991163"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("01c4d5d1-6dbe-4e5e-940a-b7356f78ca60"),
Guid.Parse("6016faa8-d688-4735-9b35-6c96ddfeb379"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Guid[,] { {
Guid.Parse("f333cb25-715b-46c2-b56c-34e8ee090238"),
Guid.Parse("c0b0175d-0589-4eac-8a39-24fc69adc2d3"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Guid[,] { {
Guid.Parse("7acff1dd-9a51-403a-95c4-9cb30b07b0a7"),
Guid.Parse("9f7b5fa8-0e6c-4c93-99ac-3f16a8aa6026"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Guid[,] { {
Guid.Parse("6be15b99-cff7-44a3-9324-c2369174a3fc"),
Guid.Parse("486dd966-b4b9-420b-85c6-365f7e62c77c"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 128,
    Value = 
new System.Guid[,] { {
Guid.Parse("28e29d8e-4727-4ad3-b464-9ff9c95a9593"),
Guid.Parse("c92e54f4-5ecb-4527-b156-0e321e19314b"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Guid[,] { {
Guid.Parse("bb5ef37d-c4d9-4242-88aa-faf33b77fce1"),
Guid.Parse("f01e6c62-8459-4ae8-8071-eea0cac0b072"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("f3d17984-fe7e-4bea-ba18-23a082cd84b1"),
Guid.Parse("6e49fb47-878c-47b0-b338-f8dbda122298"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("29a398ee-714e-4ff3-94d7-6408827f7814"),
Guid.Parse("ca7153b8-7dab-4416-919e-4cb93554862a"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Guid[,] { {
Guid.Parse("e4cc2ffa-b7ef-44c9-9c1f-127ecfe84e45"),
Guid.Parse("27c173a9-707c-4a90-be98-977dbf5ec5d0"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Guid[,] { {
Guid.Parse("b3220c86-48de-4056-82a3-bea0798138c8"),
Guid.Parse("cf94faaa-4153-4815-97cb-25782515dd91"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Guid[,] { {
Guid.Parse("4ab3f49d-b36a-46c9-971b-026cefdc904c"),
Guid.Parse("97911d0a-f1de-4fa2-adea-2243e2b0f19e"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Guid[,] { {
Guid.Parse("5b057485-8b85-413c-a0bc-bc41a8075f9b"),
Guid.Parse("2d61201c-1fc2-4620-ab8c-b4cd57391522"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("4a9d035c-85ae-49ff-99fd-61c29b89e402"),
Guid.Parse("62b1995b-fdb7-4dcf-a8a7-31dfe1e1bee8"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Guid[,] { {
Guid.Parse("04aeee88-deb0-4d77-860e-17c0329f4f80"),
Guid.Parse("bb6777bd-604e-47fb-b7f2-2bef1c251092"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Guid[,] { {
Guid.Parse("41c88877-0561-4737-9795-3ede41b1e5c6"),
Guid.Parse("3f4a45f1-d72e-4deb-85f7-ceae787f99fb"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("d872db26-1411-4180-a613-f183b407aa85"),
Guid.Parse("48ad2d40-a019-44c0-affb-c44b5813874d"), } },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 147,
    Value = 
new System.Guid[,] { {
Guid.Parse("94b5ce0d-6ceb-49fc-a2c1-f5bd57ec084d"),
Guid.Parse("6fee068b-294b-4772-9794-d7e30e75d133"), } },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Guid[,] { {
Guid.Parse("107b5728-3905-4dc8-a2f8-da50b1a5175a"),
Guid.Parse("eb95e0a5-b3ff-4d99-811c-34e3ea6d8d7d"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Guid[,] { {
Guid.Parse("459bfe53-af19-41eb-92c4-753e97ba9c4a"),
Guid.Parse("f1c11912-c6f9-478d-92fe-e219401fb9cf"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("6968f9e2-4796-47b1-be8f-a2551e7fc6ac"),
Guid.Parse("ac804ff3-cf2f-4364-9373-997bdc9a3dad"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Guid[,] { {
Guid.Parse("95ea4406-8be6-4d89-8ac5-48f3c33ecf0b"),
Guid.Parse("6d5a821e-3d41-4998-bd11-8ec205e6e121"), } },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("65332f20-5d51-41e1-b74e-38958359d160"),
Guid.Parse("d4beccf8-c9c3-491e-961f-457f4d7a4d6d"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Guid[,] { {
Guid.Parse("645326bd-ef1b-49e9-a210-ae7f5e4ea3a8"),
Guid.Parse("5df6c08b-3228-4c31-a8b2-9f906f485a8c"), } },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Guid[,] { {
Guid.Parse("4467eb25-06a1-4f64-b5a4-c84f663a4dd9"),
Guid.Parse("09ac6d10-7754-4a9a-aad7-791f7d7c12e4"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("e28a65a6-601c-4978-ad8c-eb74236ab4c6"),
Guid.Parse("6a1a40e8-fad0-4194-95ab-9412a1f0ee0b"), } },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 175,
    Value = 
new System.Guid[,] { {
Guid.Parse("36c66b83-9945-471a-81e5-30d5f0c4d1df"),
Guid.Parse("1bccc36c-5a25-4211-bf9c-34575a1170a8"), } },
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { {
Guid.Parse("0f69eb1f-c2c7-4cc6-9573-3def497d1f57"),
Guid.Parse("2b5400ba-dd8c-497b-b08d-445b2169f6b0"), } }));
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
new System.Guid[,] { {
Guid.Parse("400f8ae2-9746-4b27-bd94-0da68e939478"),
Guid.Parse("4ef1abd5-eeba-4da7-8c75-06a786daa050"), } }));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 59, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 85, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 29, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 128, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 13, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 117, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 11, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 20, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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

