

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
    internal partial interface IGuidMArrayMArrayD1
    {
    }
    
    internal partial class GuidMArrayMArrayD1 : IGuidMArrayMArrayD1
    {


#region TestData

        private readonly GuidMArrayD1E1M[] _testData = new GuidMArrayD1E1M[]
        {
            new GuidMArrayD1E1M
{
    Id = 1,
    Value = 
new System.Guid[3]
{
Guid.Parse("2a82e6f7-da90-47b4-bd4d-dcec56b959c4"),
Guid.Parse("939ac02e-0472-4efc-bbd3-f9fad29b2a89"),
Guid.Parse("c547f3e2-4dca-44a4-8f68-c923b4ec006e"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("4bf202d6-25ec-42c7-8511-4552be34682b"),
Guid.Parse("dc09b667-d65d-4b87-a09e-e0c801705215"),
Guid.Parse("974a47ea-c7b9-48cd-9b48-a0bf549133c3"),
Guid.Parse("ebc3ce6a-e49f-4dfd-8a0a-e49b0de17d7d"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6cc57451-9956-4eda-ad66-bf9898afc7db"),
Guid.Parse("38056d10-a0a5-4057-9d4b-4a754c191d56"),
Guid.Parse("378e183b-6390-4515-946b-5511cbaeae70"),
Guid.Parse("fc6a76c6-aee1-4177-b275-9d6ddd76d785"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Guid[3]
{
Guid.Parse("c23c2d4f-8f02-4c3d-91bc-908e8f49ce7b"),
Guid.Parse("6021f0c8-b4fd-4641-bdba-9aa02b222213"),
Guid.Parse("40a1dbfb-fda1-40d9-926a-edf579d4db95"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Guid[3]
{
Guid.Parse("7c8fe06e-78b7-465e-a137-abf15ff478e4"),
Guid.Parse("d4e44ec0-e78b-4141-817b-6ddb09869e7d"),
Guid.Parse("b061f791-c33d-45c7-92ef-b2a2bfc2ebf8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("88714bc6-c411-42e6-a7c8-8f85a53861c1"),
Guid.Parse("3ac0e468-85e0-4e26-b672-6bdb0726d5df"),
Guid.Parse("5cdd49a0-1ed5-4e92-a122-f3358551b3c0"),
Guid.Parse("cb135532-6d0d-4ba0-b552-79d995a745b6"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("67e2cb52-7a80-414a-b002-40587ab27714"),
Guid.Parse("611d09b2-e873-449a-8ec7-2e8451e5fd23"),
Guid.Parse("6911076e-4ced-43cd-b3bf-ca43afd264d5"),
},
},
            new GuidMArrayD1E1M
{
    Id = 12,
    Value = 
new System.Guid[3]
{
Guid.Parse("601106d0-9ad5-433a-b22f-a537e438aac8"),
Guid.Parse("a2fa3877-30c0-47ef-879a-8d3607157eb9"),
Guid.Parse("daaf2756-ac06-4268-b2f1-101e3d049a40"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Guid[3]
{
Guid.Parse("4ae312b7-3c04-4098-b6d5-e964c20a8f9a"),
Guid.Parse("7c4d12e5-2732-4db0-88aa-abdd2a9adc34"),
Guid.Parse("82f56472-d6e3-455b-8b1f-011fcc916575"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2645a152-8d8f-45f3-b021-1e50e613af75"),
Guid.Parse("93716a03-e716-418e-bf7f-1fed146cea2c"),
Guid.Parse("96bb73dd-431a-4aaa-97d9-dfec9eb82ec7"),
},
},
            new GuidMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("bd16bc50-ebb3-4b2c-a439-246ad97b48d1"),
Guid.Parse("81c14d6c-e691-4d1c-bc44-38636e2effae"),
Guid.Parse("065fff2f-d074-4eaf-b09b-e29e793f2987"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Guid[4]
{
Guid.Parse("b662bbfd-9468-4351-b753-ca806c0b328c"),
Guid.Parse("4c71dce6-76b7-436c-b189-4201fe981e93"),
Guid.Parse("c9f9722b-2016-4f41-8c1f-65d4b0517707"),
Guid.Parse("5e52b848-6ef6-44a8-909c-72ac97c4b54a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Guid[3]
{
Guid.Parse("724074a9-0654-4160-a019-616e2018ef6a"),
Guid.Parse("63337f46-6892-48ab-9966-e7214b003007"),
Guid.Parse("ae7f3533-a251-4c35-b5e9-d890db6b1c5b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("4556b947-8b46-4342-9b06-f6f132787868"),
Guid.Parse("354ee5a7-ce41-44b1-ba8f-bcc3b5277390"),
Guid.Parse("7317f61b-10bb-456b-adc2-a0125079cd87"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9cb7442d-2a5b-41ab-a6a3-a971b84d7d06"),
Guid.Parse("0ae463cd-0dce-452f-a135-2492964af189"),
Guid.Parse("e6e256b7-f67a-403c-a3f4-99eb4d9ae141"),
Guid.Parse("57ce5438-9d34-47f4-97aa-0ce3165bb938"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a9323e1f-122a-4ff9-bb14-003e217621bf"),
Guid.Parse("389db043-ce48-4c95-b713-2d0ab926c03a"),
Guid.Parse("be7f3086-426f-4102-9f73-8b33752f785d"),
},
},
            new GuidMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Guid[3]
{
Guid.Parse("772ebdb1-ed50-438f-97b3-9c72455a3575"),
Guid.Parse("cb42b4b4-8f8f-45ed-95bb-24e3c053f2c4"),
Guid.Parse("7cc520e2-43ac-4bed-b26b-50862b8a3428"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("0bebdf69-e408-48f8-9aff-e30976f64f9c"),
Guid.Parse("35ea3354-d9be-4039-adcb-7e97973b1e9a"),
Guid.Parse("2fc2fb5a-ba6d-439b-89be-a605a2e87529"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("ed7f6a82-e2fa-4359-8afb-0aa7eb91f43b"),
Guid.Parse("3215a499-e143-48c1-8f55-95735883c746"),
Guid.Parse("c330440a-6905-4798-83bb-273a2b5c655b"),
Guid.Parse("eecf5b34-410d-4ad8-b7ed-8b94eb1bce27"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Guid[4]
{
Guid.Parse("7b2a10c9-a608-4228-9839-c1f492c2f1a0"),
Guid.Parse("23237771-c9be-4ee3-940e-b03702c294fa"),
Guid.Parse("39d9c066-8b98-4018-a50c-907f1bc91cbb"),
Guid.Parse("7d5d181a-9b4a-4db0-978b-f3b385f9c756"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Guid[3]
{
Guid.Parse("4ebaaeb7-8e2a-4192-946f-fb783782d605"),
Guid.Parse("eab7aa2e-109e-4469-8c87-0cfb6e678375"),
Guid.Parse("d1616131-0d66-4b9b-816b-a3f7518af802"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Guid[4]
{
Guid.Parse("84d1bc65-6278-4cca-85ba-ca5c891f81fe"),
Guid.Parse("fa35bea2-78ce-4239-b9fd-616b854d4cb3"),
Guid.Parse("d1c99741-f3c2-4714-9417-0d6f2e0afe69"),
Guid.Parse("ae0fdf25-f2a9-4a3d-aa1f-e6bd90fa1b2b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d60ebc14-3bdb-45db-9c13-48f6a6c71ca5"),
Guid.Parse("a65e227c-a550-47b4-a29e-070fd52223a8"),
Guid.Parse("f74a0bbc-60d4-4992-ba9f-8b3493a1978b"),
},
},
            new GuidMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Guid[3]
{
Guid.Parse("c2c82984-88c6-40ce-b424-391c83fd5c3d"),
Guid.Parse("e80584ad-1c75-41ab-a967-f2649466e802"),
Guid.Parse("b3a36a84-650c-4096-a688-663ff2a0bdcc"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Guid[3]
{
Guid.Parse("cda542b0-ae88-4299-970f-d8f8ab44e1a1"),
Guid.Parse("1f83fbd1-1e79-498d-8784-bba4e1e2c19d"),
Guid.Parse("abfd8248-9b1c-446c-8417-c8516d4dcd34"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("e334289a-d2d0-4c87-9c5d-f39f33686899"),
Guid.Parse("5d724c47-1bec-48d2-af61-650d559a614c"),
Guid.Parse("b657d7bb-081c-40ca-97b1-39f7f52e223f"),
Guid.Parse("449902e0-1f04-4261-9467-2fa00ca82f8d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Guid[3]
{
Guid.Parse("cb5de6ef-4a4d-4a95-a272-9df50fa4db8d"),
Guid.Parse("a438de2c-3e1b-4ec9-bbfe-de92098787ef"),
Guid.Parse("4b0f30c6-ed03-429a-9d71-f24d917e4053"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9db5fcfa-14af-4d9d-af28-736de2216b8a"),
Guid.Parse("35668935-07e5-453d-bb01-6ef7ef3fc97e"),
Guid.Parse("e0743a35-280b-4969-bcb7-9f0967380caf"),
Guid.Parse("86f92b29-5960-41d6-a5f9-f2f388ca2ba1"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d06c75dd-cad6-45c5-943c-2bbba5353129"),
Guid.Parse("394d5d23-1e40-48c9-b674-a64278fc6429"),
Guid.Parse("1a255296-6a1b-4632-9d46-d795271f290b"),
Guid.Parse("ee91be79-4036-4073-83a0-7bd069e6e41c"),
},
},
            new GuidMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Guid[3]
{
Guid.Parse("c1a25510-cced-4a41-a592-66fcc46f73c1"),
Guid.Parse("9bd233c8-acc7-4847-a186-01095dbd67d2"),
Guid.Parse("7d179e35-7743-4147-899f-5b09bf7ca3ec"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("86b7cce4-5cf2-4f75-a996-2ca53f842675"),
Guid.Parse("a5a78d02-070d-45a0-8dbb-ddbde8e475f8"),
Guid.Parse("d596342d-38ca-42a3-859c-21d152370ee0"),
Guid.Parse("694a8f9b-d954-487e-953f-03e148befdc2"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a55fedb6-dc8d-48cd-8507-8cc35432787e"),
Guid.Parse("b5dfbf9c-b8d4-41a6-9a01-92c62bdd43eb"),
Guid.Parse("46019674-3a2b-48ad-80b0-6c0b49377814"),
Guid.Parse("d7348b82-421e-4063-baad-295d5ff4a321"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bf2de442-bedd-4706-9aef-c3c182bdf2db"),
Guid.Parse("6437a14c-3769-4032-8e82-f830e60fe57b"),
Guid.Parse("accbea2c-45a2-400c-bf89-9bb03b25e9ab"),
},
},
            new GuidMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("c7fc7976-c655-4d82-bbb9-605a15dcc81b"),
Guid.Parse("6079366c-c132-449b-9334-92141722c46c"),
Guid.Parse("07910f51-5bbe-419e-a062-f6daeea329a9"),
Guid.Parse("f165346c-048e-4bb3-8744-b9de45a18c8f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("9206581b-64b0-47f3-9087-1543a2e6a1bc"),
Guid.Parse("08b7d26a-b1f3-420d-bb4c-cfe5492fd0ed"),
Guid.Parse("a3bcf1d5-ca8c-4dbd-8da7-f9e8499a504e"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("6090c585-1022-4ef4-a86a-d182fe084c65"),
Guid.Parse("9020f19d-4a3e-4ce5-8de0-9823b1a73c22"),
Guid.Parse("3245062e-1e46-43c0-9141-ab1eb1c3ee12"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("dde3085f-c7d7-4ac1-a3ed-edc53269d1d2"),
Guid.Parse("8bcdd312-5327-4d39-b01e-0366852b5153"),
Guid.Parse("1063f8c5-7e37-418c-b40d-558f7dbeb7c4"),
Guid.Parse("9eb90692-9310-473c-92ed-2c3242e09db2"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("30a738b9-21a1-45ca-8bfc-456431a2b522"),
Guid.Parse("0b382be5-9de5-41af-96f2-9b05e42b5287"),
Guid.Parse("d3a6913b-baa7-4ffb-ba3c-e384f0f66c1d"),
Guid.Parse("55b4ea39-edc0-4a74-826c-23b168c32bd6"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("35b00566-54f5-4bb1-8d39-a3da157461fa"),
Guid.Parse("39a6304b-9b6b-4d7a-ac4f-cd7a9fed39e2"),
Guid.Parse("39f11d2a-c37a-4919-9912-bc6e783db32c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("2509ac22-ae48-4306-b901-18753d4deac1"),
Guid.Parse("a015b819-0c72-444b-9d3e-859ded32feab"),
Guid.Parse("f8544924-1123-4adf-9d1d-3d4b18ee0b66"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("abad696c-8ac7-4011-a2c3-af4bcbb2d95a"),
Guid.Parse("04732b25-ae80-4413-b719-cc9c66ea189d"),
Guid.Parse("19787dbd-c13d-4485-adc6-8479bc012abc"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("5e26b1e8-335e-408e-920e-c716c28b07a9"),
Guid.Parse("6b9542e7-230d-4dea-bc00-a787c2758398"),
Guid.Parse("56e78025-edf2-4b94-b0b3-33e83ed2d054"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("7734cdbc-944b-402a-a004-0ee677a842d6"),
Guid.Parse("d601c497-494d-45fe-a40f-54c5b37695d5"),
Guid.Parse("c2413654-c1df-48f6-8c37-fe4b2a066b89"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("78ae4c78-ae4f-478f-a6e2-9e2faf7b1636"),
Guid.Parse("55f6b318-576b-4389-b78b-896bf048d42e"),
Guid.Parse("f6822a2e-f96c-47be-89c1-5b7f97f387f7"),
Guid.Parse("b6581e02-897c-4806-9bc2-4135f5a96389"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Guid[3]
{
Guid.Parse("1aac595a-d911-4195-b227-40ebd2c1e403"),
Guid.Parse("72156b2d-3cba-4f25-a103-e00a10083722"),
Guid.Parse("3b20a3b4-b780-42ce-b8bf-a7a6592efafa"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Guid[4]
{
Guid.Parse("3a13a533-0620-4536-85ae-34b8f98f8cde"),
Guid.Parse("648897ed-8710-4f50-8e0f-5c9a837689bc"),
Guid.Parse("2841714b-09e7-484a-83d1-436da00f40a8"),
Guid.Parse("3dedfed1-ddf4-4c8b-bebf-855d19f38ee9"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("30a22b7b-204c-46c3-aa0e-a24ed525023f"),
Guid.Parse("15e73680-a2a2-4f04-a83a-3c8f558c4664"),
Guid.Parse("f802dc72-cc22-4846-8e93-85276390ec90"),
},
},
            new GuidMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("0c557426-d82a-404b-aec1-71ae9d9d75c5"),
Guid.Parse("f0066d12-7dfa-4639-82b6-bdaaa4ab0f29"),
Guid.Parse("30bf7031-6bb6-4d69-bdf1-0c3136aeaeaa"),
Guid.Parse("4005b57c-6eb8-476d-b100-29cc7751b911"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("9c9fd3f2-3fa6-412c-a572-174348e112d7"),
Guid.Parse("676ea099-64ef-483c-b2b0-a62cf0bf004d"),
Guid.Parse("238fc9cb-aadb-4482-b77f-6d0d31a65e4d"),
Guid.Parse("4805c7a9-c393-4554-b798-c6fe87bae8de"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8c7a7eb2-734c-4b3a-9459-a017dbea8915"),
Guid.Parse("5a806957-8f41-41c7-a26b-c555d0a8e400"),
Guid.Parse("ca80d2eb-a825-4a26-b3e6-41be94683a1f"),
Guid.Parse("c5408bf0-a53d-4dbb-b301-485b5b393594"),
},
},
            new GuidMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("b4375b2e-ab0c-4628-8df0-684debfa0c98"),
Guid.Parse("78a6719b-15c2-4df3-a43c-dd3eac1af12f"),
Guid.Parse("ffd2a116-a4e8-4311-a6c0-c849abb02352"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("ad5b7f1e-c5ff-40f7-87bb-b46c0e1f9fe7"),
Guid.Parse("f30c22c0-b34e-4ac6-8540-ee8edcbc880a"),
Guid.Parse("4a3fc94a-6827-448e-aba0-26834c3dd24c"),
Guid.Parse("3052a5fc-9304-4f83-8060-847beea0c96f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("56942db5-ff24-4395-b22e-07270fc1617b"),
Guid.Parse("c6e75318-32ce-436e-b3ad-f856fc3dac82"),
Guid.Parse("38349b00-43d4-4c37-8404-4beae99f8fbb"),
Guid.Parse("9ddd0660-f4ed-4495-86a6-27607ee539db"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 101,
    Value = 
new System.Guid[3]
{
Guid.Parse("f07a469e-492e-450e-a44f-8952ba1ad60c"),
Guid.Parse("ab82969c-c72b-4018-9748-644dc7efb69c"),
Guid.Parse("fafb2f70-7ae0-40d3-b678-95e707b92720"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("00cd3b32-1add-4f86-af33-0b4574685fae"),
Guid.Parse("8d678f9e-c3e1-4a44-83a2-e7fde6560bea"),
Guid.Parse("855ab6c7-073d-4dfd-96a2-759d3ff7e120"),
Guid.Parse("6d987f66-098e-4d1c-bf80-d4b509f88f7c"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6b5f9f19-18c4-4c0c-b090-75952ad7aeb0"),
Guid.Parse("c35a1424-4151-42a9-b7be-62334b6258d9"),
Guid.Parse("e582f53a-d315-4bdf-903d-7a6159378ef5"),
Guid.Parse("bc5e174f-8cff-4dcd-a4be-10b9de080557"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("262a03a8-35bc-4694-a6dd-68dcbc5d4891"),
Guid.Parse("95756b9c-83f2-4358-b429-040166989f20"),
Guid.Parse("be447407-0095-4fd2-9bb3-5518dc03381a"),
},
},
            new GuidMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Guid[4]
{
Guid.Parse("77735646-a705-4af9-854c-7449b3bc9f69"),
Guid.Parse("86729898-f215-4a81-a4e3-09b8ac77f2db"),
Guid.Parse("20a12bdc-814a-4abf-ba52-2ffc627095df"),
Guid.Parse("59e00510-b956-46a5-b316-2b12738b8e7f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Guid[4]
{
Guid.Parse("5acd6a95-57a2-40ad-911c-1eec8f4d7796"),
Guid.Parse("d5dab8b2-8341-4a77-b895-cec83e6c3f2c"),
Guid.Parse("1084b399-fa0e-4e0a-bb66-3e042e722a63"),
Guid.Parse("e395b35b-b82c-4494-9b65-39fbe3c152e9"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Guid[3]
{
Guid.Parse("b75534cd-1786-4013-9f56-7a659bc689a2"),
Guid.Parse("b7870388-e20f-4544-8e93-6c60815e6ac4"),
Guid.Parse("0c8a44a9-4795-4413-acfd-2e36459d1612"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Guid[3]
{
Guid.Parse("964a21ca-5a91-43d2-8f28-565909ff2973"),
Guid.Parse("e2c26112-d02e-4d7e-9256-b9a07676711b"),
Guid.Parse("de045c51-0f14-4bf6-87c3-55d89ffeb1ff"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("23d19ac6-d07d-4f90-a467-d93c7a64b51b"),
Guid.Parse("24fda6e8-a635-4cf7-ab91-20772f84b6b2"),
Guid.Parse("6092dfc7-6d03-4452-8b81-cb54d6f36ab8"),
},
},
            new GuidMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Guid[4]
{
Guid.Parse("cc52bcb7-f352-46ec-b0e8-36131ea811ec"),
Guid.Parse("aae77f22-80db-454e-b47c-5d71cd603f19"),
Guid.Parse("f38e2ebf-9676-4cb5-be92-42322d72e7f7"),
Guid.Parse("c90ac60d-85e4-40fe-a8d7-07ef067abb36"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Guid[4]
{
Guid.Parse("8f2f2f0f-b6f6-4cc3-ac0a-6b19f4d11411"),
Guid.Parse("d79d561e-1308-45ff-89a9-a30c13525ca2"),
Guid.Parse("5f3a9808-4fb1-453e-b291-982df61887cf"),
Guid.Parse("08b1292d-2be3-44f9-9303-3ddaa9fd0d6c"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5db72c71-f694-4611-a7a0-a2f420b47331"),
Guid.Parse("30fe5ff0-8a27-48f0-8cc7-ad4074998d21"),
Guid.Parse("46d96904-ec5f-4e46-9c1f-33137f19a5ee"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ee8ae3ac-3aed-4d08-a835-274c2ae97fa4"),
Guid.Parse("dfd38955-3452-416f-872b-a44a16736ae1"),
Guid.Parse("049e7a7e-0e9a-42e5-8530-33b63fa6802b"),
Guid.Parse("baa9aa18-7428-4d7b-813e-dfa08f5505d0"),
},
},
            new GuidMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Guid[3]
{
Guid.Parse("9545790b-3bd9-45ba-9d5f-8fe7d8a036cd"),
Guid.Parse("35fda406-63de-43c4-9e8a-994f0e645caf"),
Guid.Parse("c0b8de27-d229-4dad-9fb0-fd217f180cbc"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("7d57f212-be81-403f-8b69-a2628ffd7630"),
Guid.Parse("a50fceff-febf-4b14-b41b-29360d064c54"),
Guid.Parse("8e481d45-1555-4629-a071-ea42e63c2dca"),
Guid.Parse("759b7e43-2faf-4368-ac96-6b946e468706"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("cec27612-5714-4a39-a083-42cbabfe19c1"),
Guid.Parse("0596d136-3eb9-48f0-a018-fbe5a633c894"),
Guid.Parse("6e529562-13c9-460d-af80-32a45b4f3cce"),
Guid.Parse("e8403268-b789-43e9-a977-24d15e632505"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Guid[4]
{
Guid.Parse("95941a0d-f429-4bbf-ab60-e5184da917e3"),
Guid.Parse("6fefd2e6-8481-4904-a68b-985aa3625a67"),
Guid.Parse("62918d8d-a324-4201-9919-4bb141ab4520"),
Guid.Parse("0468e6bd-4df4-484f-b62c-af247ca8078d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("1184827b-01ae-4799-948d-81c6317e616c"),
Guid.Parse("8b79686b-b9c8-43d5-9709-ca5a65cec13e"),
Guid.Parse("4831b30f-3639-4f30-a914-7251b62eefda"),
Guid.Parse("ac70508c-9649-4cd8-a8f9-f883c640ef69"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Guid[4]
{
Guid.Parse("120790eb-66b0-4628-a2b6-1e5fbf7a81b1"),
Guid.Parse("07019b33-3a05-4aaa-8b86-1d02d5051842"),
Guid.Parse("72d46f17-4ffe-484d-8f0c-38520efbb254"),
Guid.Parse("58d7d209-9eb1-4752-8c26-aeb1aec16a54"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.Guid[3]
{
Guid.Parse("eaf5f0d1-4295-4da4-a711-2aefd935938c"),
Guid.Parse("a58d0ba8-a588-4ddf-844f-22d3a86b252a"),
Guid.Parse("77668ea0-b12f-4aee-bc2b-74e2da1d1423"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7d125b97-1efa-4c53-b419-e147b087d191"),
Guid.Parse("274a9b76-f82f-4b31-acd7-68621ba49ec8"),
Guid.Parse("30a8289e-4561-4946-803a-e07e8c3101d9"),
Guid.Parse("7db3f4bb-1113-4a3b-83cf-87e9aa677d19"),
},
},
            new GuidMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Guid[3]
{
Guid.Parse("24bc40e5-823d-4167-8318-7b7156a2a67e"),
Guid.Parse("e494869d-0473-4646-be98-fa95b707f318"),
Guid.Parse("628cb13b-87f6-42f8-962e-5739d810054a"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 137,
    Value = 
new System.Guid[4]
{
Guid.Parse("4add4995-96b2-42a3-aeb4-b419fc90bb7e"),
Guid.Parse("ca523de1-f2b6-46a5-bfbe-d0f51c9447e5"),
Guid.Parse("9f7ca639-4328-415c-be1d-e0792e854120"),
Guid.Parse("bb4f544a-a364-466b-a9a2-f7a43e442557"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d29e8cf3-ba38-4ce3-8271-bf10deb50989"),
Guid.Parse("a6efc892-c5a8-4874-9b33-dfc8028a98c1"),
Guid.Parse("9e190968-54d7-46ea-a620-9d3c7a3ab469"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Guid[4]
{
Guid.Parse("e78e3937-c13e-4de1-8c49-cce5d98b2018"),
Guid.Parse("0069e8be-9881-4e37-8a43-e0bba01430d3"),
Guid.Parse("73595f8a-6273-4a9f-883d-1824f781b3bd"),
Guid.Parse("bcd32bfd-329f-4157-b117-7b0ab2f91dd9"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 145,
    Value = 
new System.Guid[3]
{
Guid.Parse("b6a49e4d-6bb9-44da-aa11-341ecbc9164a"),
Guid.Parse("78633397-bfef-4ecc-bf13-cc9c3d4035c4"),
Guid.Parse("f63b07b8-4b3e-4328-b1ae-66409d90aee4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("190c0024-ac8d-439e-b1c7-8d941dded849"),
Guid.Parse("5093bafc-7489-4718-a7a5-6532204a589a"),
Guid.Parse("e8e8fd81-d607-44f6-b7dd-f5ef91d68e01"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Guid[4]
{
Guid.Parse("81f3e19e-3692-4212-be4f-630d40605e1a"),
Guid.Parse("6d0ed7b3-78b5-497a-9db5-6b68f0c08b87"),
Guid.Parse("f01f83ee-eb47-4ea5-9cca-a7f116ffce10"),
Guid.Parse("aa963545-94f0-45b2-9794-750a57e1d001"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("fb55427c-e8e8-4d7d-8fc2-ce032e8e6af0"),
Guid.Parse("e3817c6c-48bb-4d3c-8fb8-aa96e98d3069"),
Guid.Parse("428cd8fc-480b-49a6-acba-3308420f7dc8"),
Guid.Parse("c5a6fb07-20d5-4700-94de-1f471788ae0b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5de00501-b19e-4b4c-bf4a-734312f98c9f"),
Guid.Parse("7b54025f-8d1d-47b7-849b-4ce36d4ea301"),
Guid.Parse("da3f8452-93ca-40bb-8d51-eed5a23571fd"),
Guid.Parse("ced5b499-2bb2-4420-96cf-879568dd5cfa"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("daf18992-d8bb-47ea-9409-5dfc6ebefcc6"),
Guid.Parse("5f2a8a1f-98e0-40fe-a093-2fef56a4126b"),
Guid.Parse("edb34231-d67e-43a4-8ab5-f5820791484e"),
Guid.Parse("c7270310-b61c-414b-ae9b-8e59403f620a"),
},
},
            new GuidMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Guid[4]
{
Guid.Parse("27f0b603-16d8-4808-90de-d61ba0a858d6"),
Guid.Parse("8cd4b9e3-18a5-4c91-8287-9e894cbc92cb"),
Guid.Parse("9c7ae94a-88d5-415e-87e4-44301e284943"),
Guid.Parse("08b7796f-8a65-4fdc-b0b5-b0a881e49339"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 159,
    Value = 
new System.Guid[3]
{
Guid.Parse("2ae72b5c-ecb0-4673-a1a0-2ed84eda54dc"),
Guid.Parse("80747f68-420b-4c30-9dd8-8d6044d2cead"),
Guid.Parse("bba838d0-d2e9-434c-bb94-37eef8914145"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6789d6ee-7235-483a-9269-21004b587856"),
Guid.Parse("620fbedc-221e-4fdd-ba9d-b68d08539a47"),
Guid.Parse("db6fe849-d283-4c85-8483-e2a01a886f81"),
Guid.Parse("862d344b-a955-4021-a978-c94acaa45a85"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Guid[3]
{
Guid.Parse("bf005187-2027-4998-ac8e-5f579a1c2b0e"),
Guid.Parse("33a2c3f6-3a70-4943-9c61-48885b4f1a7a"),
Guid.Parse("9a48ec32-6336-4acb-aa9c-c62110cdb163"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 166,
    Value = 
new System.Guid[3]
{
Guid.Parse("f1d0b9bd-06f4-4df7-8dd1-4cff12bfd889"),
Guid.Parse("5297da91-df99-48c3-bfeb-b3862caf67c2"),
Guid.Parse("19082273-b1cc-45ff-9608-b9eec9c34640"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("025a7455-9688-4160-be8c-beafcab6f52a"),
Guid.Parse("6c399629-1383-49f8-8d29-81883ba0ccc8"),
Guid.Parse("58172888-22c9-4344-9878-7390109306ea"),
Guid.Parse("1b927a9c-d939-4eb1-9dab-c50d928d7a0d"),
},
},
            new GuidMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Guid[3]
{
Guid.Parse("63800eca-c579-4950-a0ed-08e954f69d71"),
Guid.Parse("91883041-f9c9-40e0-815f-a2b22ee7b60a"),
Guid.Parse("039ff302-00e5-46ee-ba7a-a4a8b319c4ad"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 172,
    Value = 
new System.Guid[4]
{
Guid.Parse("e630126a-4007-49f8-826e-a2531c5a28ab"),
Guid.Parse("150e2c7b-2e7a-4a51-a9f0-9caf9b960165"),
Guid.Parse("5904c61f-5412-4fc3-a20a-374557ff491c"),
Guid.Parse("5a7b3e28-86c8-4fa8-b8e2-ed74639810a8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3479d046-ae0c-457b-899f-0c263722e357"),
Guid.Parse("6d604f74-89c2-435b-9068-900837d28040"),
Guid.Parse("c5f752a2-e349-4752-897a-f0630eded578"),
Guid.Parse("98d77d0d-897a-4db5-bb4d-3b6efb5f9ce0"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Guid[4]
{
Guid.Parse("21b1474f-2b69-4845-99e5-1ae39de4198e"),
Guid.Parse("fe1d9e76-d8bd-4466-a9f6-192d97b8cf64"),
Guid.Parse("71082b73-9287-4cf5-a845-11a0901d246f"),
Guid.Parse("79dcf484-f9a7-4f85-b165-723526bb4ad4"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 179,
    Value = 
new System.Guid[4]
{
Guid.Parse("81169472-3a0a-4eb1-965b-9ed97a18550b"),
Guid.Parse("f2ca5e06-5e3a-4c8e-9ffe-eca66381ae26"),
Guid.Parse("d2b74c56-a096-45b1-829e-8af9379c1f2e"),
Guid.Parse("0fbd2a2e-2c49-473f-aa6f-655ecd7a2e20"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4664191b-9593-4ea7-b984-831c98a7bb03"),
Guid.Parse("dd4f892a-f4b7-4e9b-a199-215cb23cd49d"),
Guid.Parse("9083273c-65db-494a-bc38-aa00aac6f366"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Guid[4]
{
Guid.Parse("66d8212e-dba1-46bb-8cbf-1a645c3aa05f"),
Guid.Parse("1f9138d4-df21-4383-9f16-26536f661e4b"),
Guid.Parse("56476faa-9b3b-4695-aa4a-a2446168047a"),
Guid.Parse("2d2bae6f-9393-432f-8f6d-4e9a0e2c09dc"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 181,
    Value = 
new System.Guid[4]
{
Guid.Parse("a68d690f-0090-4a2f-8da5-89d7b8699ec6"),
Guid.Parse("1214ac05-2f1f-41c0-8947-29ff6cce44b4"),
Guid.Parse("3b0f3d00-7a4d-4c24-a499-e7dcdfdd3726"),
Guid.Parse("eff2e39a-fe1c-4df6-af48-04b7af425c5b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d35c4915-92f1-41b0-b5d0-b120c9e64562"),
Guid.Parse("5ebf497c-2864-439f-a617-33e19b676cf4"),
Guid.Parse("f1026e73-a44d-4c39-a274-90e67fc36155"),
Guid.Parse("8af1bc39-e3db-4b04-8a95-8eeef277617d"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 166,
    Value = 
new System.Guid[4]
{
Guid.Parse("a87fe11b-d53f-4f08-b4e9-fc6d084a60a0"),
Guid.Parse("11438888-a071-43c2-921c-b8e3441a36bb"),
Guid.Parse("5247081e-3f04-48dd-bdba-711e7cb9cdf2"),
Guid.Parse("44b17461-5f69-4c8d-be98-4c434d6eff9e"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 189,
    Value = 
new System.Guid[3]
{
Guid.Parse("151b87d0-a5eb-4755-bbf7-fb059239fa5e"),
Guid.Parse("ade3930c-4bb1-4d98-b9bb-e3458d6d5bb7"),
Guid.Parse("4ec72ee5-876d-464d-9049-983ee98dd91a"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ac023092-0972-4fc7-950d-f81a9fb5a8f1"),
Guid.Parse("647a314f-67ed-4463-b49d-990d2efc516a"),
Guid.Parse("a28f67c4-6673-4904-94e9-47e1c4db0ee2"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d02368ce-4730-4bf7-aa13-d56303d2c70b"),
Guid.Parse("4663e805-0581-476d-a531-1cf6f784af51"),
Guid.Parse("d549604d-35f1-42a0-94cb-7c3d20f490a2"),
},
},
            new GuidMArrayD1E1M
{
    Id = 171,
    Value = 
new System.Guid[3]
{
Guid.Parse("6779d42e-46c5-4691-94ca-316b990df3f2"),
Guid.Parse("3e392a44-58bf-47e4-8747-9b2145e383d1"),
Guid.Parse("1d5da16a-9603-439c-8346-f7b4689898e0"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 194,
    Value = 
new System.Guid[3]
{
Guid.Parse("b009dbe3-c0d2-4469-b343-8679268ad6a8"),
Guid.Parse("b79f4ecd-feb3-454b-9aff-c52deb8c6484"),
Guid.Parse("81e6cabe-4592-444a-b57e-08d3a35040c0"),
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
INSERT INTO gedaqtests.guidmarrayd1e1m(
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
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
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
                    await ((IGuidMArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IGuidMArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.guidmarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
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
                    var models = await ((IGuidMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

